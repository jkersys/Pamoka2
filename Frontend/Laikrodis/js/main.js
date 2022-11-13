

const clockTime = () => {
    let dateTime = new Date()    
    
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
    
return `hours: ${hours}, minutes: ${minutes}, seconds: ${seconds}`

}
let start = setInterval(clockTime, 1000)


const startCount = () => {
start = setInterval(clockTime, 1000)
}


let logFile = []


btn_stop.onclick = () => {
  clearInterval(start)
document.getElementById("print").innerHTML = ''
logFile.push(clockTime())

};


print_btn.onclick = () => {
logFile.forEach(function(element, index) { 
document.getElementById("print").innerHTML += `<p>Index Nr: ${index}, was stoped at ${element}</p>`
});
}


start_btn.onclick = () => {
  start = setInterval(clockTime, 1000);
document.getElementById("print").innerHTML = ''
};

//VEIKIA IR SITAS
// txt.addEventListener('keyup', (e) => {
//      show_txt.innerHTML = e.target.value
// });

txt.keyup = (e) => {
    document.getElementById("show_txt").innerHTML += e.target.value
};



