const registrationForm = document.querySelector('#reg-form');
const regFormSbmBtn = document.querySelector('#signup_btn');
const response = {};
const url = 'https://testapi.io/api/jkersys/resource/users';



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
           
            if(user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() && 
            user.lastname.toLowerCase() === inputLastName.value.toLowerCase() && 
            user.email.toLowerCase() === inputEmail.value.toLowerCase()) {
                console.log('Toks vartotojas jau yra')
                userExists = true
                console.log(`${user.firstname} ${inputFirstName.value} ${user.lastname} ${inputLastName.value} ${user.email} ${inputEmail.value}`);
                break;
                             
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
      .then(async (obj) => {
        const savedUser = await obj.json();
      })
      .catch((error) => console.log(error));
      console.log(data);
  }

  
  regFormSbmBtn.addEventListener("click", (e) => {
    e.preventDefault();
    checkFields()
    regValidation();
}
);

  
  btn_return.onclick = () => {
    window.location.href = "../index.html"
    };


    let checkFields = () => {
        const mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
        if(inputFirstName.value.length === 0) {        
            inputFirstNameError.style.visibility = "visible";
            //pasidaryt counteri validacijai pvz false +1 ir tikrint su if(false > 0)
        }
        else {
            inputFirstNameError.style.visibility = 'hidden'
        }
        if(inputLastName.value.length === 0) {        
            inputLastNameError.style.visibility = "visible";
        }
        else {
            inputLastNameError.style.visibility = 'hidden'
        }
        if(inputEmail.value.match(mailformat)) {        
            inputEmailError.style.visibility = 'hidden'
        }
        else {
            inputEmailError.style.visibility = "visible";
        }
        // if(inputEmail.value.length > 0 && !inputEmail.value.includes('@')) {   
        //     inputEmailError.innerHTML = "Incorect email"
        //     inputEmailError.style.visibility = "visible";
        // }
        // else {
        //     inputEmailError.style.visibility = 'hidden'
        // }
        
    // if(inputEmail.value.length === 0 || !inputEmail.value.includes('@'))
    // {
    //     document.getElementById('email-err').innerHTML = "Incorect email";
              
    // }    
    // else {
    // }
}

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