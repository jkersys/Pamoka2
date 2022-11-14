const registrationForm = document.querySelector('#reg-form');
const regFormSbmBtn = document.querySelector('#signup_btn');
const response = {};
const url = 'https://testapi.io/api/jkersys/resource/users';
const userExistsMsg = document.querySelector('#redTable');



const inputFirstName = document.querySelector('#inputFirstName');
const inputLastName = document.querySelector('#inputLastName');
const inputEmail = document.querySelector('#inputEmail');

const inputFirstNameError = document.querySelector('#firstname-err');
const inputLastNameError = document.querySelector('#lastname-err');
const inputEmailError = document.querySelector('#email-err');
const mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/


function regValidation() {
    let userExists = false
    const url = 'https://testapi.io/api/jkersys/resource/users';
    const options = {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    }

    fetch(url, options)
        .then((response) => response.json())
        .then((users) => {
            console.log(users);
            for (const user of users.data) {
                console.log(user);

                if (user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() &&
                    user.lastname.toLowerCase() === inputLastName.value.toLowerCase() &&
                    user.email.toLowerCase() === inputEmail.value.toLowerCase()) {
                    console.log('Toks vartotojas jau yra')
                    userExists = true
                    console.log(`${user.firstname} ${inputFirstName.value} ${user.lastname} ${inputLastName.value} ${user.email} ${inputEmail.value}`);
                    break;
                }
            }

            if (userExists) {
                console.log('Toks vartotojas duomenu bazeje jau yra')
                userExistsMsg.style.visibility = 'visible'
            }
            else {
                console.log(`kuriamas naujas vartotojas`);
                sendRegData()
            }
        })
}

function sendRegData() {
    let data = new FormData(registrationForm);
    let obj = {};
    let createdUser

    data.forEach((value, key) => {
        obj[key] = value;
    });

    fetch(`https://testapi.io/api/jkersys/resource/users`, {
        method: "post",
        headers: {
            Accept: "application/json, text/plain, */*",
            "Content-Type": "application/json",
        },
        body: JSON.stringify(obj),
    })
        .then(async (obj) => {
            const savedUser = await obj.json()
            console.log(savedUser)
            const userData = JSON.stringify(savedUser)
            localStorage.setItem(savedUser.firstname + ' ' + savedUser.lastname, userData)
            //failMsg.innerHTML = (`${loggedUser.firstname} ${loggedUser.lastname}`)
            window.location.href = '../todo/todo.html'
        })
        .catch((error) => console.log(error));
    console.log(data);
}

regFormSbmBtn.addEventListener("click", (e) => {
    e.preventDefault();
    checkFields()
}
);

btn_return.onclick = () => {
    window.location.href = "../index.html"
};

let checkFields = () => {
    let name = true
    let lastname = true
    let email = true
    const mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (inputFirstName.value.length === 0) {
        inputFirstNameError.style.visibility = "visible";
        name = false
    }
    else {
        inputFirstNameError.style.visibility = 'hidden'
    }
    if (inputLastName.value.length === 0) {
        inputLastNameError.style.visibility = "visible";
        lastname = false
    }
    else {
        inputLastNameError.style.visibility = 'hidden'
    }
    if (inputEmail.value.match(mailformat)) {
        inputEmailError.style.visibility = 'hidden'
    }
    else {
        inputEmailError.style.visibility = "visible";
        email = false
    }

    if (!name || !lastname || !email) {
        return
    }
    else {
        regValidation();
    }

}

