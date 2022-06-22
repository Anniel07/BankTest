using AutoMapper;
using BankTest.Dto;
using BankTest.DTO;
using BankTest.Filters;
using BankTest.Models;
using BankTest.Repos.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankTest.Controllers
{
    
    public class EndPointControllerBase<TEntity, TEntityDto, FilterSortPagedListDto> : ControllerBase where TEntity : EntityBase where TEntityDto : EntityBaseDto where FilterSortPagedListDto : BaseFilter
    {
        protected readonly IMapper _mapper;
        protected readonly IGenericRepository<TEntity> _baseRepository;

        public EndPointControllerBase(IMapper mapper, IGenericRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        // GET: api/Entities
        [HttpGet]
        public async Task<ActionResult<TEntityDto>> GetAll()
        {
            return Ok(await _baseRepository.GetAll());
        }

        protected virtual async Task <PagedResultDto<TEntityDto>> GetPagedListAsync(FilterSortPagedListDto input, params Expression<Func<TEntity, bool>>[] predicates)
        {
                //Filtragem
                IQueryable<TEntity> query = _baseRepository.Where(predicates);
                
                //Contando elementos totais
                int total = await query.CountAsync();
                //Paginating
                query = query.Skip(input.SkipCount).Take(input.MaxResultCount == 0 ? total : input.MaxResultCount);
                return new PagedResultDto<TEntityDto>
                {
                    Items = _mapper.Map<IEnumerable<TEntityDto>>(await query.ToListAsync()),
                    TotalCount = total
                };
        }

        /// <summary>
        /// obter o elemento de acordo com o id
        /// </summary>
        /// <param name="id">ID para encontrar o elemento</param>
        /// <returns></returns>.
        // GET: api/Entity/5 
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntityDto>> GetById(int id)
        {
            try
            {
                TEntity entity = await _baseRepository.GetById(id);
                if (entity == null)
                    return NotFound();
                return _mapper.Map<TEntityDto>(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// criar um novo elemento
        /// </summary>
        /// <param name="createDto">elemento para criar</param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ActionResult<TEntityDto>> Post(TEntity entity)
        {
            try
            {
                entity = (await _baseRepository.Add(entity)).Entity;
                if (await _baseRepository.SaveChangesAsync())
                    return _mapper.Map<TEntityDto>(entity);
                else
                    throw new Exception("Registro no adicionado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// atualizar os dados do elemento de acordo com o Id
        /// </summary>
        /// <param name="id">ID para encontrar o elemento</param>
        /// <returns></returns>
        [HttpPut("{id}")]
       
        public virtual async Task<ActionResult> Put(int id, TEntity entity)
        {
            try
            {
                if (entity.ID != id)
                    throw new Exception("Erro na atualização");
                _baseRepository.Update(entity);
                bool res = await _baseRepository.SaveChangesAsync();
                return Ok(res ? "The entity was updated successfully" : "The entity can't be updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
        
        /// <summary>
        /// remover o elemento de acordo com o Id
        /// </summary>
        /// <param name="id">ID para encontrar o elemento</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            try
            {
                TEntity entity = await _baseRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                _baseRepository.Remove(entity);
                bool res = await _baseRepository.SaveChangesAsync();
                return Ok(res ? "The entity was removed successfully" : "The entity can't be removed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
