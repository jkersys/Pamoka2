const loginFormSbmBtn = document.querySelector('#login-submit');
const inputFirstName = document.querySelector('#input-firstname');
const inputLastName = document.querySelector('#input-lastname');
const failMsg = document.querySelector('#failed');



const url = 'https://testapi.io/api/jkersys/resource/users';
const options = {
    method: 'get',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
}

const response = {};

function userValidation() {
    fetch(url, options)
    .then((response) => response.json())
    .then((users) => {
        console.log(users);
       
      //  users.data.forEach(user => {

      for (const user of users.data) {
        
      
            console.log(user);

            if(user.firstname.toLowerCase() === inputFirstName.value.toLowerCase() && 
            user.lastname.toLowerCase() === inputLastName.value.toLowerCase()) {
                console.log(`${user.firstname} ${user.lastname}`);
                const usedData = JSON.stringify(user)
                localStorage.setItem(user.firstname + ' ' + user.lastname, usedData)
                failMsg.innerHTML = (`${user.firstname} ${user.lastname}`)
                window.location.href = '../todo/todo.html'
                     break
            }
            else {
                console.log(`tokio vartojo nera`);
                failMsg.innerHTML = `<div id="redTable"><p>Account does not exist</p></div>`
                console.log(`${user.firstname} ${user.lastname}`);
                console.log(`${inputFirstName.value} ${inputLastName.value}`);
            }
           
        };

      
    })
}

btn_return.onclick = () => {
    window.location.href = "../index.html"
    };

loginFormSbmBtn.addEventListener("click", (e) => {
    e.preventDefault();
    localStorage.clear();
    userValidation(); 
  });

