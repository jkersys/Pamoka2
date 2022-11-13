//pirma uzduotis
const functionStarted = () => {
    console.log('funkcija paleista')
}

const sum = (a, b) => {
    console.log('įgyvendinta sudėties funkcija')
    return a * b
}

const showRezult = (sumFunction) => {
    console.log(`igyvendinus sum funkciją rezultatas yra ${sumFunction}`)
}

const functionEnd = () => {
    console.log('funcija uzbaigta')
}

const start = () => {
    setTimeout(() => {
        functionEnd();
    }, 3000)
    setTimeout(() => {
        showRezult(sum(2, 5));
    }, 2000)
    setTimeout(() => {
        functionStarted();
    }, 1000)

}
start();


//antra uzduotis
//sinchroninis paleidimas
const alertText = (txt) => {
    alert(txt)
    let pTag = document.querySelector('#uzd')
    pTag.innerHTML = txt
    pTag.style.color = 'red'
}

//asinchorinis paleidimas
const alertText1 = (txt) => {
    setTimeout(() => {
        alert(txt)
    }, 3000)
    let pTag = document.querySelector('#uzd')
    pTag.innerHTML = txt
    pTag.style.color = 'red'
}

setTimeout(alertText1('Laba diena'), 3000)
//alertText('Laba diena')



//trecia uzduotis

const ingredients = ['suris', 'grybai', 'pomidoru padazas', 'pomidorai', 'ananasas']

const pizzaMaker = (toppings) => {
    return new Promise((resolve, reject) => {
        if (toppings.includes('ananasas')) {
            reject();
        }
        else {
            resolve();
        }

    })

};

// pizzaMaker(ingredients).then(() => {
//     console.log(`Stai Jusu pica su ${ingredients} ingridientais`)
// }).catch(() => {
//     console.log(`Sioje picoje yra ananasu!!`)
// })

const pizzaMakerVariable = pizzaMaker(['suris', 'grybai', 'pomidoru padazas', 'pomidorai', 'ananasas'])
    .then(console.log(`Stai Jusu pica su ${ingredients} ingridientais`))
    .catch(console.log(`Sioje picoje yra ananasu!!`))



//pizzaMaker(ingredients)


//Laikrdotis


const clockTime = () => {
    let dateTime = new Date()

    let hours = dateTime.getHours()
    let minutes = dateTime.getMinutes()
    let seconds = dateTime.getSeconds()

    if (hours < 10) {
        hours = '0' + hours
    }
    if (minutes < 10) {
        minutes = '0' + minutes
    }
    if (seconds < 10) {
        seconds = '0' + seconds
    }

    document.getElementById('hours').innerHTML = hours,
        document.getElementById('minutes').innerHTML = minutes,
        document.getElementById('seconds').innerHTML = seconds,
        document.getElementById('amAndPm').innerHTML = hours >= 12 ? "AM" : "PM"

    return `hours: ${hours}, minutes: ${minutes}, seconds: ${seconds}`

}
let start_Clock = setInterval(clockTime, 1000)


const startCount = () => {
    start = setInterval(clockTime, 1000)
}


let logFile = []


btn_stop.onclick = () => {
    clearInterval(start_Clock)
    document.getElementById("print").innerHTML = ''
    logFile.push(clockTime())

};


print_btn.onclick = () => {
    logFile.forEach(function (element, index) {
        document.getElementById("print").innerHTML += `<p>Index Nr: ${index}, was stoped at ${element}</p>`
    });
}


start_btn.onclick = () => {
    start_Clock = setInterval(clockTime, 1000);
    document.getElementById("print").innerHTML = ''
};

