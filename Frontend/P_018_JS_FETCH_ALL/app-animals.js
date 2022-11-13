const url = 'https://testapi.io/api/jkersys/resource/Animals'
const options = {
    method: 'post',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
}
}

const response = {}
function loadData() {
    fetch(url, options)   
    .then((response) => response.json())
    .then((response) => {
        console.log(response);
        const animalEle = document.getElementById('animal-text');
        let htmlAnimal;

        data.results.array.forEach(element => {
            let htmlElement = `<p>${element.name}</p>`
            `<p>${element.type}</p>`
            `<p>${element.legs}</p>`
            htmlAnimal += htmlElement
        });

      animalEle.innerHTML = htmlAnimal;
    })

}
loadData()

