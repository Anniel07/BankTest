using System.Collections.Generic;

namespace BankTest.DTO
{
    public class PagedResultDto<Entity>
    {
        public int TotalCount { get; set; }
        public IEnumerable<Entity> Items { get; set; }

        public PagedResultDto()
        {
            Items = new List<Entity>();
        }
    }
}
