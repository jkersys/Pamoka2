let isConected = () => {
    if(KeyName.length < 1) {
        console.log('vartotojas neprisijunges')
        window.location.href = '../index.html'

    }
    else {
        console.log(`prisijunges vartotojas${KeyName}`)
    }
}
//nuskaitom rakto koda
let KeyName = Object.getOwnPropertyNames(localStorage) //grazina masyva
isConected()



const postForm = document.querySelector('#todo-form');
const showUserPosts = document.querySelector('#print-user-posts');




let UserKey = JSON.parse(localStorage.getItem(KeyName))
console.log(UserKey)
let activeUser = UserKey.firstname + ' ' + UserKey.lastname
console.log(activeUser)

document.querySelector('#user-name').innerHTML = activeUser

if(UserKey.length > 0) 
{
console.log('niekas neprisijunges')
//todogrizt i main page
}

console.log(activeUser)


function sendPostData() {
    let data = new FormData(postForm);
    let obj = {};
    obj[`username`] = activeUser
    data.forEach((value, key) => {
        obj[key] = value;
    });

    console.log(obj)
//POSTINA I DUOMBAZE

    fetch(`https://testapi.io/api/jkersys/resource/userPosts`, {
      method: "post",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json",
      },
      body: JSON.stringify(obj),
    })
      .then((obj) => console.log(obj.json()))
      .catch((error) => console.log(error));
      console.log(data);
  }



// let userConected () => {
//     if(Object.keys.(localStorage) > 0 )
// }


console.log(UserKey)

console.log(KeyName)




btn_post.addEventListener("click", (e) => {
            e.preventDefault();
        sendPostData();
      
      });



      function printUserPosts() {

        const url = 'https://testapi.io/api/jkersys/resource/userPosts';
        const options = {
          method: 'get',
          headers: {      
              'Accept': 'application/json',   
                   'Content-Type': 'application/json'  
          }
        }


        fetch(url, options)
        .then((response) => response.json())
        .then((usersPosts) => {
            console.log(usersPosts);
            
            showUserPosts.innerHTML = '';
            for (const post of usersPosts.data) {
                if(post.username === activeUser) {
                console.log(post)
                let activeUserPost = `<div id="${post.id}">
                <div class="printedDataContainer"> <div class="postType">${post.type}</div><input style="display:none" type="text" class='postTypeInput' />` + 
                `<div class="postContent">${post.content}</div><input style="display:none" type="text" class='postContentInput' />` + 
                `<div class="postEndDate">${post.endDate}</div><input style="display:none" type="text" class='postEndDateInput' />` + 
                '<input type="button" class="editButton" value="Edit" onClick="editTodo('+post.id+')" />'+
                '<input type="button" class="updateButton" style="display:none" value="Update" onClick="updateTodo('+post.id+')" />'+
                '<input type="button" value="Delete" onClick="deleteTodo('+post.id+')" /> </div> </div>'
               // htmlPost += activeUserPost
               showUserPosts.innerHTML += activeUserPost 
            }
        }
        
        });
    }
    
    

    printUserPosts()


    //DELETE POST

    const deleteForm = document.querySelector('#delete-todo');
    const deleteTodoBtn = document.querySelector('#btn_delete');

    function updateTodo(id){
        const div = document.getElementById(id);
        const typeValue = div.getElementsByClassName('postTypeInput')[0].value;
        const contentValue = div.getElementsByClassName('postContentInput')[0].value;
        const endDateValue = div.getElementsByClassName('postEndDateInput')[0].value;



        const post = {
            username: activeUser,
            content: contentValue,
            endDate: endDateValue,
            type: typeValue
        }
        const url = 'https://testapi.io/api/jkersys/resource/userPosts/' + id;
        const optionsFetchPosts = {
            method: 'put',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body:JSON.stringify(post) 
        }
    
        fetch(url, optionsFetchPosts)
        .then(() => printUserPosts())
        .catch((error) => {
            console.log(`Request failed with error: ${error}`);
        })
    }
        //type update
    function editTodo(id){
        const div = document.getElementById(id);
        const typeDiv = div.getElementsByClassName('postType')[0];  
        const typeInput = div.getElementsByClassName('postTypeInput')[0];
        const editButton = div.getElementsByClassName('editButton')[0];
        const updateButton = div.getElementsByClassName('updateButton')[0];
        editButton.style.display="none";
        updateButton.style.display="block";
        typeDiv.style.display= "none";
        typeInput.style.display= "block";
        typeInput.value= typeDiv.innerHTML;

        //content update
        const contentDiv = div.getElementsByClassName('postContent')[0];  
        const contentInput = div.getElementsByClassName('postContentInput')[0];
        contentDiv.style.display= "none";
        contentInput.style.display= "block";
        contentInput.value= contentDiv.innerHTML;

        //endDate update
        const endDateDiv = div.getElementsByClassName('postEndDate')[0];  
        const endDateInput = div.getElementsByClassName('postEndDateInput')[0];
        endDateDiv.style.display= "none";
        endDateInput.style.display= "block";
        endDateInput.value= endDateDiv.innerHTML;


    }

    function deleteTodo(id){
        const url = 'https://testapi.io/api/jkersys/resource/userPosts/' + id;

        const optionsFetchPosts = {
            method: 'delete',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        }
    
        fetch(url, optionsFetchPosts)
        .then(() => printUserPosts())
        .catch((error) => {
            console.log(`Request failed with error: ${error}`);
        })
        
    }

    function deleteTodo2() {
        let data = new FormData(deleteForm);
        let obj = {};
    
        // #1 iteracija -> obj {name: 'asd'}
        // #2 iteracija -> obj {type: 'asd'}
        data.forEach((value, key) => {
            // console.log(`${key}(Key): ${value}(Value)`);
            obj[key] = value
        });
    
        const url = 'https://testapi.io/api/jkersys/resource/userPosts/' + obj.id;
    
        const urlFetchPosts = 'https://testapi.io/api/jkersys/resource/userPosts/' + obj.id;
        const optionsFetchPosts = {
            method: 'get',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        }
    
        fetch(url, optionsFetchPosts)
        .then((response) => response.json())
        .then((p) => {
            console.log(`Posts exists: ${p}`);
            return fetch(urlFetchPosts, {
                method: 'delete',
                headers: {
                    'Accept': 'application/json, text/plain, */*',
                    'Content-Type': 'application/json'
                }
            })
        })
        .then(obj => { // Now we are working with our Delete fetch
            const res = obj;// .json()
            console.log(res);
            return res;
        })
        .catch((error) => {
            console.log(`Request failed with error: ${error}`);
        })
        
        
        
    }
    
    deleteTodoBtn.addEventListener('click', (e) => {
        e.preventDefault(); // Breaks manual refresh after submit
        deleteTodo();
    })