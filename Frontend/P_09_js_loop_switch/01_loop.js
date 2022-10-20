console.log('Hello loops')

let n = 0;
while (n < 3)
{
    n++
    console.log(n)
}
console.log('---- do.. while------')

let result = ''; // padaro konkadinacija
let numberResult = 0 // sudeda skaicius
let i = 0;
do 
{
i++;
result += i;
numberResult += i;
console.log(` ${i}`);
}
while (i< 5);
console.log(` ${result}`);
console.log(` ${numberResult}`);
let suma1 = result / 2;
let suma2 = numberResult / 2;
console.log(`suma1 = ${suma1}`);
console.log(`suma1 = ${suma2}`);

console.log('---- for------')
let str = ''
for(let i = 0; i < 9; i++)
{
    str += i
}
console.log(str)

console.log('---- for with step------')
str = '';
for(let i = 0; i < 9; i+=2)
{
    str += i;
}
console.log(str);

console.log('---- for... of (foreach)------')
let arr = ['a', 'b', 'c', 2, true ]
for(let item of arr)
{
    console.log(` ${item} - ${typeof item}`)
}

console.log('---- for... in------')
let objektas = { 
    vardas: 'Jonas', 
    pavarde: 'Jonaitis', 
    amzius: 30 };
    for(let prop in objektas)
    {
        console.log(` ${prop} reiksme yra ${objektas[prop]}`)
    }