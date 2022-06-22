"use strict";
const endpoint = 'https://localhost:44361/api/Contacts';
const imgBaseUrl = 'https://localhost:44361/images/';
const filterEndP = '/GetPagedListAsync'; //endPoint with pagination
// this ppicute will be on server in a shared folder resources
const urlImages = ["img_avatar1.png", "img_avatar2.png", "img_avatar3.png", "img_avatar4.png", "img_avatar5.png"];

// params for filtring
/* 
global variable for items per page, this variable is set when renderContacts() is called
without params or validarForm() is true, is set to 1
Also this value is set on moveToPage()
*/
let maxResultCount = 0 
let currentPage = 1
// end params for filtring

// get endpoint
function buildEndPoint(param) {
    let dget = endpoint + filterEndP;
    const ands = [];
    ands.push(`maxResultCount=${maxResultCount}`);
    ands.push(`skipCount=${(currentPage-1) * maxResultCount}`);
    for (const prop in param) { //properties from filter
        if (param[prop])
            ands.push(prop + "=" + param[prop]);
    }
    
    return dget + "?" + ands.join('&');
}

// read all using filter , method: get (default)
async function getContacts(param) {
    try {
        //const url = (typeof param === "undefined") ? endpoint + filterEndP : buildEndPoint(param);
        if(typeof param === "undefined"){
            currentPage = 1;
        }

        const url = buildEndPoint(param);  
        //console.log(url);
        const res = await fetch(url);
        return await res.json();
    } catch (error) {
        //console.log(error);
        return error;
    }
}


async function getContact(id) {
    try {
        const res = await fetch(endpoint + "/" + id);
        return await res.json();
    } catch (error) {
        console.log(error);
    }
}

async function deleteContact(id) {

    try {
        await fetch(endpoint + "/" + id, {
            method: 'delete'
        });
        //return await res.json(); // dont return anything
    } catch (error) {
        console.log(error);
    }
}

async function updateContact(id, contact) {

    try {
        await fetch(endpoint + "/" + id, {
            method: "PUT",
            body: JSON.stringify(contact),
            headers: { "Content-type": "application/json; charset=UTF-8" }
        });
        //return await res.json(); // dont return anything
    } catch (error) {
        console.log(error);
    }
}

async function createContact(contact) {

    try {
        const res = await fetch(endpoint, {
            method: "POST",
            body: JSON.stringify(contact),
            headers: { "Content-type": "application/json; charset=UTF-8" }
        });
        return await res.json();
    } catch (error) {
        console.log(error);
    }
}


async function renderContacts(param) {
    const spinner = document.getElementById('my_spinner');
    spinner.classList.add("spinner-border");

    const resp = await getContacts(param);
    console.log(resp);
    if (!(resp instanceof TypeError || resp instanceof SyntaxError)) {
        const headers = ["First Name", "Second Name", "Addresses", "Date of Birth",
            "Phone Number", "Actions"];
        const txt = buildTable(resp.items, headers)
        const loadData = document.getElementById("loadData");
        loadData.innerHTML = txt;
        // load pagination
        buildPagination(resp.totalCount)
        if (resp.items.length == 0) {
            loadData.innerHTML += "<h1 class='text-center text-success'>There is no data.</h1>";
        }

    } else { //capture error
        alert(resp.message);
    }

    spinner.classList.remove("spinner-border");
}

// functions expression using lambda
const buildTable = (arr, headers) => {
    let txt = `<table class='table text-center'><tr class='bg-dark text-white'>`;
    for (const h of headers) {
        txt += `<th>${h}</th>`;
    }
    txt += `</tr>`;
    for (const item of arr) {
        txt += `<tr>`;
        // make id and personalPhoto not enumerable
       
        const { id, firstName, secondName, addresses, dateofBirth, phoneNumber } = item;
        const propVal = [firstName, secondName, addresses, dateofBirth, phoneNumber];
        //console.log(firstName);
        for (const pv of propVal) {
            txt += `<td>${pv}</td>`;
        }
        txt += `<td>
            <button type="button" class="btn btn-info" onclick="showDetails(${id})">Details</button>
            <button type="button" class="btn btn-warning" onclick="handleEdit(${id})">Edit</button>
            <button type="button" class="btn btn-danger" onclick="handleDelete(${id})">Delete</button>
        </td>`;
        txt += `</tr>`;
    }
    txt += `</table>`;
    return txt;
}

const showDetails = async (id) => {

    // make petition to api and show details and build a modal with the data
    const contact = await getContact(id);
    console.log(contact);
    const myModal = new bootstrap.Modal(document.getElementById('detailsModal'), {
        backdrop: false
    })

    const modal_data = document.getElementById('modal-data-dinamic');
    modal_data.innerHTML = ""; // clear

    const headers = ["Addresses", "Date of Birth", "Phone Number", "Age"];
    const { fullName, addresses, dateofBirth, phoneNumber, age } = contact;
    const propVal = [addresses, dateofBirth, phoneNumber, age];
    let i = 0;
    modal_data.innerHTML += `<h4 class="card-title">${fullName}</h4>`;
    for (const pv of propVal) {
        modal_data.innerHTML += `<p class="card-title"><b>${headers[i]}: </b>${pv}<p>`;
        i++;
    }

    const avatar = document.getElementById('avatar_id');
    avatar.src = imgBaseUrl + contact.personalPhoto;
    myModal.show();
}

const handleDelete = async (id) => {
    //alert(id)
    if (confirm("Are you sure you want to delete this record?")) {
        // make request with fetch
        await deleteContact(id);
        alert("The contact with id: " + id + " was removed.")
        //console.log(res)
        renderContacts()

    }
}

/** La opcion correcta es crear un form y validarlo, pero pa simplificar edito algunos campos
 * de la entidad y los guardo, luego muestro unn alert q se guardo satisifactoriamente
 */
const handleEdit = async (id) => {
    //alert(id)

    if (confirm("Are you sure you want to edit this record?")) {
        const contact = await getContact(id)
        // make some mock edit
        contact.firstName = contact.firstName + "1";
        contact.secondName = contact.secondName + "2";
        contact.addresses = contact.addresses + "3";
        contact.phoneNumber = generatePhone();
        contact.personalPhoto = urlImages[Math.floor(Math.random() * urlImages.length)];
        await updateContact(id, contact);
        alert("The contact with id: " + id + " was updated.")
        //console.log(res)
        renderContacts()

    }
}


/** La opcion correcta es crear un form y validarlo, pero pa simplificar creo los campos
 * de la entidad y los guardo, luego muestro unn alert q se guardo satisifactoriamente
 */
const handleCreate = async () => {
    //alert(id)

    if (confirm("Are you sure you want to create a new contact?")) {
        const contact = {}; //create a new contact
        // make some mock insert, dont send ID
        contact.firstName = "Some fName" + Math.floor(Math.random() * 100);
        contact.secondName = "Some sName" + Math.floor(Math.random() * 100);
        contact.addresses = "Some address" + Math.floor(Math.random() * 100);
        contact.phoneNumber = /*Math.random() < 0.5 ? "Some phone" : */generatePhone(); // in some case a right phone number, otherwise the api should throw exception with this field
        contact.personalPhoto = urlImages[Math.floor(Math.random() * urlImages.length)];
        contact.dateofBirth = new Date(100000000000 * Math.floor(Math.random() * 10))
        const res = await createContact(contact);
        console.log(res);
        if (res.id) {
            alert("The contact was created.")
            renderContacts()
        } else {
            alert("Error: Some fields are not valid")
        }

    }
}

function validarForm() {
    // just one validation if fromAge is higher than toAge
   
    const dataForm = collectDataFromForm()
    //console.log(fromAge + " " + typeof toAge+ " " + typeof firstName)
    if (dataForm.fromAge > dataForm.toAge) {
        alert("From age must be less than or equal ToAge");

    } else {
        // if true send to the api for make the filter and render the result
        currentPage = 1;
        renderContacts(dataForm);
    }
    return false; // for prevent event default

}

function generatePhone() {
    return (10000000 + Math.floor(Math.random() * 90000000)).toString();
}

// return li element
const createPrevNextLi = (condition, text, fn) => {
    let disableLi = condition ? "disabled" : ""
    const li = document.createElement("li");
    li.className = `page-item ${disableLi}`
    const a = document.createElement("a");
    a.className = 'page-link'
    a.innerHTML = text;
    li.appendChild(a);
    li.onclick = fn
    return li;
}

/**
 * @param totalCount Amount of records from Database
 */
const buildPagination = (totalCount) => {
    const ul = document.getElementById("pagination");
    ul.innerHTML = "" // clear ul
    const totalPages = Math.ceil(totalCount / (maxResultCount * 1.0)) 
    
    ul.appendChild( createPrevNextLi(currentPage === 1, "Previous", () => moveToPage(currentPage - 1, totalPages)));

    for (let i = 1; i <= totalPages; i++) { 
        const li = document.createElement("li");
        const active = i == currentPage ? "active" : ""
        li.className = `page-item ${active}`
        const a = document.createElement("a");
        a.className = 'page-link'
        li.onclick = () => moveToPage(i, totalPages);
        a.innerHTML = i;
        li.appendChild(a);
        ul.appendChild(li);
    }
    ul.appendChild( createPrevNextLi(currentPage === totalPages || totalPages === 0, "Next", () => moveToPage(currentPage + 1, totalPages)));
}

function buildItemPerPage() {
    const items = [5, 10, 15, 20]
    const selectList = document.getElementById('maxResultCount')
    maxResultCount = items[0]
    for (const it of items) {
        const selected = it === maxResultCount ? "selected" : ""
        const option = document.createElement("option");
        option.value = it;
        option.text = it;
        option.selected = selected
        selectList.appendChild(option);
    }

}

function collectDataFromForm(){
    const form = document.forms["filterForm"]
    maxResultCount = form["maxResultCount"].value
    const fromAge = parseInt(form["fromAge"].value)
    const toAge = parseInt(form["toAge"].value) //Nan when it's empty
    const address = form["address"].value
    const firstName = form["firstName"].value
    const secondName = form["secondName"].value
    
    return {firstName: firstName, secondName: secondName,
        address: address, fromAge: fromAge, toAge: toAge};
}

function moveToPage(page, totalPages){
    if(page >= 1 && page <= totalPages){
        currentPage = page
        //colllect form param
        renderContacts(collectDataFromForm())
        
    }
    
}

// main 
buildItemPerPage()
renderContacts();

