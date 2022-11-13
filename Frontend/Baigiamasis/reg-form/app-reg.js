const registrationForm = document.querySelector('#reg-form');
const regFormSbmBtn = document.querySelector('#signup_btn');
const response = {};
const url = 'https://testapi.io/api/jkersys/resource/users';




const inputFirstName = document.querySelector('#inputFirstName');
const inputLastName = document.querySelector('#inputLastName');
const inputEmail = document.querySelector('#inputEmail');


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
           
            if(user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() && 
            user.lastname.toLowerCase() === inputLastName.value.toLowerCase() && 
            user.email.toLowerCase() === inputEmail.value.toLowerCase()) {
                console.log('Toks vartotojas jau yra')
                userExists = true
                console.log(`${user.firstname} ${inputFirstName.value} ${user.lastname} ${inputLastName.value} ${user.email} ${inputEmail.value}`);
                             
            }
            }

            if(userExists) {
                console.log('Toks vartotojas duomenu bazeje jau yra')
            }            
            else {
                console.log(`kuriamas naujas vartotojas`);
                sendRegData()
            }
           
        
      
    })


    //kjhkasd
}


//KAZKO GERAI NESUVEIKIA< NEPRAEINA CIKLO VISO
// const regValidation = async () => {
   
//         const response = await fetch (url);
//         const users = await response.json();
        
//         for await (const user of users.data) {      
//                  console.log(user);
//         if(user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() && 
//             user.lastname.toLowerCase() === inputLastName.value.toLowerCase() && 
//             user.email.toLowerCase() === inputEmail.value.toLowerCase()) {
//                 console.log('Toks vartotojas jau yra')
//                 console.log(`${user.firstname} ${inputFirstName.value} ${user.lastname} ${inputLastName.value} ${user.email} ${inputEmail.value}`);
//                 //const userFandLName = JSON.stringify(user)
//                // localStorage.setItem(user.firstname, userFandLName)
//               //  failMsg.innerHTML = (`${user.firstname} ${user.lastname}`)
//                 //JSON.stringify(`${user.firstname} ${user.lastname}`)
//                      break
//             }
//             else {
//                 console.log(`kuriamas naujas vartotojas`);
//                 //failMsg.innerHTML = "Incorect Name or Last name"
//                 //console.log(`${user.firstname} ${user.lastname}`);
//                 //console.log(`${inputFirstName.value} ${inputLastName.value}`);
//                 sendRegData()
//                 break
//             }
//     }
// }


function sendRegData() {
    let data = new FormData(registrationForm);
    let obj = {};
  
    data.forEach((value, key) => {
      obj[key] = value;
    });

//POSTINA I DUOMBAZE

    fetch(`https://testapi.io/api/jkersys/resource/users`, {
      method: "post",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json",
      },
      body: JSON.stringify(obj),
    })
      .then((obj) => console.log(obj.json())).then(userValidation())
      .catch((error) => console.log(error));
      console.log(data);
  }

  
  regFormSbmBtn.addEventListener("click", (e) => {
    if(document.getElementById("inputFirstName").value.length === 0)
{
    document.getElementById('firstname-err').innerHTML = "Please enter First Name";
           
}
if(document.getElementById("inputLastName").value.length === 0)
{
    document.getElementById('lastname-err').innerHTML = "Please enter Last Name";
           
}
if(document.getElementById("inputEmail").value.length === 0)
{
    document.getElementById('email-err').innerHTML = "Incorect email";
          
}    
else {
    e.preventDefault();
    regValidation();
}
  });

  
  btn_return.onclick = () => {
    window.location.href = "../index.html"
    };


//   function userValidation() {
//     const url = 'https://testapi.io/api/jkersys/resource/users';
// const options = {
//     method: 'get',
//     headers: {
//         'Accept': 'application/json',
//         'Content-Type': 'application/json'
//     }
// }
//     fetch(url, options)
//     .then((response) => response.json())
//     .then((users) => {
//         console.log(users);
       
//       //  users.data.forEach(user => {

//       for (const user of users.data) {
        
      
//             console.log(user);

//             if(user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() && 
//             user.lastname.toLowerCase() === inputLastName.value.toLowerCase()) {
//                 console.log(`${user.firstname} ${user.lastname}`);
//                 const usedData = JSON.stringify(user)
//                 localStorage.setItem(user.firstname + ' ' + user.lastname, usedData)
//                 //failMsg.innerHTML = (`${user.firstname} ${user.lastname}`)
//                 //JSON.stringify(`${user.firstname} ${user.lastname}`)
//                      break
//             }
//             else {
//                 console.log(`tokio vartojo nera`);
//                 failMsg.innerHTML = "Incorect Name or Last name"
//                 console.log(`${user.firstname} ${user.lastname}`);
//                 console.log(`${inputFirstName.value} ${inputLastName.value}`);
//             }
           
//         };

      
//     })
// }