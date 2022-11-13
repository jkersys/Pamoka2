const url = 'https://swapi.dev/api/species'
const options = {}
const rezult = {}

// fetch(url, options)
// .then(response => response.json() )
// .then(data => console.log(data))

const loadDataSimple = () => {
fetch(url, options)
//.then(response => response.json() )
.then(res => {
    if(res.ok) {
        console.log(res)
        return res.json()
    }
    else {
        console.log(`Got error. Status : ${res}`)
    }
}).then(data => console.log(data.result[2]))
}

const loadDataAsync = async () => {
    try {
console.log('Traukiam duomenis')
const response = await fetch(url);
console.log('Atsakyma gavom')
const data = await response.json();

console.log(data)
    }
    catch(error) {
        console.error(error)
    }
}

loadDataAsync(url)
console.log('Mes dabar esam cia')



const elementArr = []

const loadDataAsyncUzduotis = async () => {
        const response = await fetch ('https://swapi.dev/api/species');
        const data = await response.json();
        showData(data)                 
        }

const dataArr = []
const showData = data => {
     data.results.forEach(element => {
         dataArr.push(element)
        document.getElementById('test').innerHTML += `<p>${element.name}</p>`
    });
    
}

console.log( "Mes dabar esam cia");


// const dataArr = []
// const showData = data => {
//      for (let i = 0; i < data.length; i++) {
//         document.body.innerHTML += `<p>${data.results.name[i]}</p>`;
        
//      }
//     //    document.body.innerHTML += `<p>${element['results']}</p>`
//     }
    // const showData = data => {
    // for (const property in object) {
    //     console.log(`${property}: ${object[property]}`);
    //   }
    // }



loadDataAsyncUzduotis()