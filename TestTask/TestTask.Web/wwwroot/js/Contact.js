function showCreatePopup(){
    $("[id=MyModalCreate]").modal('show');
}
function hideCreatePopup() {
    $("[id=MyModalCreate]").modal('hide');
}
function showUpdatePopup(id){
    const b = `contact${id}`;
    //const c = $(`[id=${b}]`)[0].children;
    const contact = Array.from($(`[id=${b}]`)[0].children).map(
        e => e.innerText
    );
    
    $("[id=InputUpdateContactId]")[0].setAttribute('value', id);
    $("[id=InputUpdateContactName]")[0].setAttribute('value', contact[0]);
    $("[id=InputUpdateContactMobilePhone]")[0].setAttribute('value', contact[2]);
    $("[id=InputUpdateContactJobTitle]")[0].setAttribute('value', contact[1]);
    $("[id=InputUpdateContactBirthDate]")[0].setAttribute('value', contact[3]);

    $("[id=MyModalUpdate]").modal('show');
}

function hideUpdatePopup() {
    $("[id=MyModalUpdate]").modal('hide');
}

function saveContact() {
    const name = $("[id=InputContactName]").val();
    const mobilePhone = $("[id=InputContactMobilePhone]").val();
    const jobTitle = $("[id=InputContactJobTitle]").val();
    const dateOfBirth = $("[id=InputContactBirthDate]").val();
    const data = {
        name,
        mobilePhone,
        jobTitle,
        dateOfBirth
    }
    var request = $.ajax({
        contentType: 'application/json',
        url: `/api/ContactApi/Create`,
        data: JSON.stringify(data),
        type: 'post',
    });
    request.done(()=> {
        location.reload();
    });
}

function updateContact() {
    const id = $("[id=InputUpdateContactId]").val();
    const name = $("[id=InputUpdateContactName]").val();
    const mobilePhone = $("[id=InputUpdateContactMobilePhone]").val();
    const jobTitle = $("[id=InputUpdateContactJobTitle]").val();
    const dateOfBirth = $("[id=InputUpdateContactBirthDate]").val();
    const data = {
        id,
        name,
        mobilePhone,
        jobTitle,
        dateOfBirth
    }
    var request = $.ajax({
        contentType: 'application/json',
        url: `/api/ContactApi/Update`,
        data: JSON.stringify(data),
        type: 'post',
    });
    request.done(()=> {
        location.reload();
    });
}

function deleteContact(id) {
    var request = $.ajax({
        contentType: 'application/json',
        url: `/api/ContactApi/Delete/${id}`,
        type: 'post',
    });
    request.done(()=> {
        location.reload();
    });
}

function validateContactPhoneNumber(value) {
    var phone = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;
    if(!value.match(phone))
        alert("phone number is not valid");
}

function validateContactName(value){
    var name = /^[a-zA-Z\-]+$/;
    if(!value.match(name))
        alert("message");
}

function validateContactBirthDate(value){
    var birthDate = /^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$/;
    if(!value.match(birthDate))
        alert("message");
}