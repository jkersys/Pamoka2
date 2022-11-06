// //pirma uzduotis
// const functionStarted = () => {
//     console.log('funkcija paleista')
// }

// const sum = (a, b) => {
//     console.log('įgyvendinta sudėties funkcija')
// return a * b
// }

// const showRezult = (sumFunction) => {
//     console.log(`igyvendinus sum funkciją rezultatas yra ${sumFunction}`)
// }

// const functionEnd = () => {
//     console.log('funcija uzbaigta')
// }

// const start = () => { 
//     setTimeout(() => {
//         functionEnd();
//     },3000)
//     setTimeout(() => {
//         showRezult(sum(2, 5));
//     }, 2000)
//     setTimeout(() => {
//         functionStarted();
//     }, 1000)
   
// }
// start();

// //antra uzduotis
// //sinchroninis paleidimas
// const alertText = (txt) => {
// let pTag = document.querySelector('#uzd')
// pTag.innerHTML = txt
// pTag.style.color = 'red'
// alert(txt)
// }

// //asinchorinis paleidimas
// const alertText1 = (txt) => {
//     let pTag = document.querySelector('#uzd')
//     pTag.innerHTML = txt
//     setTimeout(() => {
//         alert(txt) 
//     }, 3000)
//     pTag.style.color = 'red'
//     }

// //alertText('Laba diena')



//trecia uzduotis

const ingredients = ['suris', 'grybai', 'pomidoru padazas', 'pomidorai']

const pizzaMaker = (toppings) => {
return new Promise((resolve, reject) => {
    if(toppings.includes('ananasas'))  {
    reject(); }
    else {
        resolve(); 
    }
    
})

};

pizzaMaker(ingredients).then(() => {
    console.log(`Stai Jusu pica su ${ingredients} ingridientais`)
}).catch(() => {
    console.log(`Sioje picoje yra ananasu!!`)
})


//pizzaMaker(ingredients)


//Laikrdotis

//const clockParagraph = document.getElementById('hours')


const clockUpdate = (clockTime) => {
    //     clockParagraph.innerHTML(clockTime)   
    
}

const clockTime = () => {
    let dateTime = new Date()    
    
    
   //.apply. dateTime = dateTime.toLocaleString('en-Gb')
    let hours = dateTime.getHours()
    let minutes = dateTime.getMinutes()
    let seconds = dateTime.getSeconds()
    
    if(hours < 10) {
        hours = '0' + hours
    }
    if(minutes < 10) {
        minutes = '0' + minutes
    }
    if(seconds < 10) {
        seconds = '0' + seconds
    }
    
    document.getElementById('hours').innerHTML = hours,
    document.getElementById('minutes').innerHTML = minutes, 
    document.getElementById('seconds').innerHTML = seconds,
    document.getElementById('amAndPm').innerHTML = hours >= 12 ? "AM" : "PM"
    
}


clockTime()
setInterval(clockTime, 900)

//clockUpdate(clockTime(dateTime))