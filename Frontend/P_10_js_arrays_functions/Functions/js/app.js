// BASICS
function helloWorld() {
    let worldText = 'World';
    console.log("Hello World!");
    console.log("Nice weather were having!");
    // console.log(`Hello ${worldText}!`);
}

helloWorld();
helloWorld();
helloWorld();

for (let i = 0; i < 20; i++) {
    helloWorld();
}

// Math funkcijos
let mathPi = Math.PI;
console.log(mathPi);
// let roundValueMath = Math.round(4,9); // INCORRECT ARGUMENT USAGE
let roundValueMath = Math.round(mathPi)
                        .toFixed(2);
console.log(roundValueMath);
let absValueMath = Math.abs(-456);
console.log(absValueMath);
let floorValueMath = Math.floor(2.8);
console.log(floorValueMath);
let ceilValueMath = Math.ceil(2.5);
console.log(ceilValueMath);
let powValueMath = Math.pow(2,5);
console.log(powValueMath);
let randomFromMath = Math.random()*10;
console.log(`Number was calculated: ${randomFromMath}`);

function throwDie() {
    let roll = Math.floor(Math.random() * 6) + 1;
    console.log(`Die was rolled: ${roll}`);
}

throwDie();

function throwDice() {
    throwDie();
    throwDie();
    throwDie();
}

throwDice();

console.log('hello'.toLocaleUpperCase());
console.log('hello'.indexOf('l'));

function greet(name) {
console.log(`Hello ${name}!`)  
console.log('Nice to meet you!')  
}

greet();
greet(null);
greet('Edvinas');

function throwDice(numRolls) {
for( let i = 0; i < numRolls; i++) {
    throwDie
}
}

throwDice(5);


function squere(num) {
    console.log(num*num)
}

squere(9);

function sum(firstNumber, secondNumber)  {
    console.log(firstNumber + secondNumber);
}

sum(8,9)

function dalyba(firstNumber, secondNumber) {
    console.log(firstNumber / secondNumber);
}

dalyba(10,2)

//FUNCTIONS RETURNING VALUES
const yell = 'welcome'.toLocaleUpperCase
console.log(yell);

function sumReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber
}

console.log(sumReturn(8,9))

function sumBrokenReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber
    console.log(firstNumber + secondNumber)// Neisigyvendina sios dalies nes jau grazinta reiksme
}

function sumTextReturn(firstNumber, secondNumber) {
    return `Sum ${firstNumber + secondNumber}`;
}

console.log(sumTextReturn(78,89))

function isGreen(color) {
    if(color.toLowerCase() === 'green') {
        return true
    }
    else {
        return false;
    }
}

console.log(`isGreen: ${isGreen('Green')}`);
console.log(`isGreen: ${isGreen('Blue')}`);

function isBetterGreen(color) {
    if(color.toLowerCase() === 'green') {
        return true
    }

    return false;
}

function isBestGreen(color) {
    return color.toLowerCase() === 'green';
}

function containGreen(arr) {
    for(let color of arr) {
        if(color.toLowerCase() === 'green' || color.toLowerCase() === 'lime')
        return true;
    }
    return false;
}

let colorArr = ['Ping', 'Blue', 'Green']

console.log(`Is array contains green: ${containGreen(colorArr)}`);

//Scope
//Function scope

function scopeExample() {
    let scopeName = 'Example scope';
    const creationDate = Date.UTC();
    var tag = 'Learing'
    console.log(tag);
}

//console.log(tag); // not possible to acces direct function scope

scopeExample();

//Block scope
let animal1 = 'dog';

function printAnimal1() {
    let animal1 = 'cat';
    console.log(animal1);
}

printAnimal1();
console.log(animal1);


if(true) { //block scope
var animal2 = 'owl'
console.log(animal2) // var is scoped only to function
}
console.log(`$Outer animal2 call: ${animal2}`)

let animal = ['Bear', 'Deer', 'Zebra'];
var i = 10;
for (let i = 0; i < animal.length; i++) {
   console.log(i, animal[i]);
    }

    console.log(i) // with let - 10 if with var - 3

    function doubleEleInArray(arr) {
        const result = [];
        for(let num of arr) {
            let double = num * 2
            result[result.length] = double
        }
        return result
    }

    let doubleNumbersArr = [5,8,9,7,4,7]

    console.log(doubleEleInArray(doubleNumbersArr))