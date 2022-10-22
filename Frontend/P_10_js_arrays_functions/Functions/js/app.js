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

    function outer() {
        let movie = 'Amadeus';

        function inner() {
            console.log(movie.toUpperCase());
        
        
        function extraInner() {
            console.log(movie.toUpperCase());
        }
        extraInner();
    }
    inner();
    }

    outer();



    //Function Expressions
    //Functions are objects

    console.dir(sum);

    //Annonymous
    const sumAnnon = function (a, b) {
        return a + b
    }

    console.log(sumAnnon(5,5))

// Named
    const product = function multiplyNamed(a, b) {
        return a *b;
    }
    console.log(product(5,5))

    //Higher order functions
    //Tai yra funkcijos, kurios priima funkcijas kaip parametrus, arba grazina funkcija kaip return value


    function addFtion(a, b) {
        return a + b
    }

    function substractFtion(a, b) {
        return a - b
    }

    function multiplyFtion(a, b) {
        return a * b
    }

    function divideFtion(a, b) {
        return a / b
    }

    const operation = [addFtion, substractFtion, multiplyFtion, divideFtion];

    //console.log(operation[0])
    //console.log(operation[0](100,4))

    for(let func of operation) {
        let result = func(50,8)
        console.log(result)
    }

    const thing = {
        doSomething: multiplyFtion
    }
    console.log(thing.doSomething(70,8))

    //FUNCTION AS PARAMETER

    function callThreeTimes(f) {
        f();
        f();
        f();
    }

    function callGeneric() {
        console.log("Generic call");
    }
    
    function callMoreGeneric() {
        console.log("More generic call");
    }
    
    callThreeTimes(callGeneric);
    callThreeTimes(callMoreGeneric);
    
    // Funkcijos deklaravimas
    function repeatNTimes(action, num) {
        for (let i = 0; i < num; i++) {
            action();      
        }
    }
    
    repeatNTimes(callGeneric, 5);
    
    
    function pickOne(f1, f2) {
        let rand = Math.random();
        console.log(rand);
        if(rand < 0.5) {
            f1();
        }
        else {
            f2();
        }
    }
    
    pickOne(callGeneric, callMoreGeneric);
//pickOne(callGeneric, callm)

//RETURNING FUNCTION FROM FUNCTION
//Works like function factories

function multiplyBy(num) { // multiplyBy(3)
    return function(x) {
        return x * num; //return x * 3
    }
}

//sitoje vietoje musu double atrodo taip:
/*
    const double = function(x) {
        return x *2;
    }
*/

const double = multiplyBy(2)
console.log(double(8))

function makeBetweenFunc(a, b) {
    return function(num) {
        return num >= a && num <= b
    }
}

const isChild = makeBetweenFunc(0, 18)
console.log(isChild(17))
console.log(isChild(19))

const isInNineties = makeBetweenFunc(1990, 2000)
const isGoodWeather = makeBetweenFunc(20,30)

// ARROW FUNCTIONS

let greetArrow = () => {
    console.log("Hello using arrow!");
}

greetArrow();

let greetArrowName = (name) => {
    console.log(`Hello ${name} using arrow!`);
}

greetArrowName("Edvinas");

let sumArrow = (a, b) => a + b;

console.log(sumArrow(8,8));



// function duomenuIvedimas() {
//     let vardas = prompt('vardas')
//     let pavarde = prompt('pavarde')
//     let amzius = prompt('amzius')
//     let elpastas = prompt('elpastas')

// console.log(vardas)
// console.log(pavarde)
// console.log(amzius)
// console.log(elpastas)


// }

// duomenuIvedimas();

// function amziausValidacija(num) {
//     if(num >= 18) 
//     {
//         alert('Amzius tinkamas')
//     }
//     else 
//     {
//        isApprooved = (confirm("Ar duodate leidima"));
//        if (isApprooved)
//         {
//         alert('Leidimas duotas')
//         }
//         else
//         {
//         alert('Leidimas neduotas')
//         }
//     }
// }
// amziausValidacija(17)


function arKeliamiejiMetai(metai){
    if(metai % 4 === 0 || metai % 100 === 0 || metai % 400 === 0)
    {
        alert('metai keliamieji') 
    }
    else {
        alert('metai nekeliamieji') 
    }
}

arKeliamiejiMetai(1817)

