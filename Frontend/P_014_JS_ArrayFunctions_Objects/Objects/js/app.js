const fitBitData = {
    totalSteps: 308727,
    // totalSteps: 308727, // We just override ANYTHING with the same name
    totalKms: 387.7,
    avgCalorieBurn: 400,
    workoutsThisWeek: '5 of 7',
    avgGoodSleep: '2:13',
    45: 'forty five',
    '79 trombones': 'great song'
};

console.log(fitBitData.totalSteps);
// console.log(fitBitData.45); // Throws error. Needs a different syntax to access property.

// Dot syntax
let dataDotSyntax = {a:1, b:2, c:3};
console.log(dataDotSyntax.a);

// Square bracket syntax
const numbers = {
    100: 'one hundred',
    16: 'sixteen'
};

console.log(numbers[100]); // 100 gets converted to '100' string
console.log(numbers['100']);
console.log(fitBitData['avgCalorieBurn']);
console.log(fitBitData['79 trombones']);

const pallete = {
    red: '#eb4d4b',
    yellow: '#f9ca24',
    blue: '#30336b'
};

console.log(pallete.blue);

// Lets user pick random color
let mysteryColor = 'blue';
console.log(pallete[mysteryColor]);




// ADDING AND UPDATE PROPERTIES
const userReviews = {};
// userReviews['colorEnabled'] = true;
userReviews['queenBee49'] = 4.0;
userReviews.mrSmith78 = 3.5;

userReviews['queenBee49'] += 0.5;
userReviews.mrSmith78++;

console.log(userReviews);






// NESTING ARRAYS AND OBJECTS
const student = {
    firstName: 'David',
    lastName: 'Jones',
    strengths: ['Music', 'Art'],
    exams: {
        midterm: 10,
        final: 9
    },
    fullName: function() {
        return this.firstName + ' ' + this.lastName;
    },
    logFullfullName: function() {
        console.log(this.firstName + ' ' + this.lastName);
    }
};

console.log(student.fullName())


const studentAvgExamMark = (student.exams.midterm + student.exams.final) / 2;

console.log(student.strengths[1])

const shoppingCart = [
{
    produc: 'Janga',
    price: 6.88,
    quantity: 1
},
{
    produc: 'Warcraft TableTop',
    price: 49.99,
    quantity: 3
},
{
    produc: 'Pandemic',
    price: 39.99,
    quantity: 2
}
];

console.log(shoppingCart)

const game = {
    player1: {
        username: 'Blue',
        playingAs: 'X'
    },
    player2: {
        username: 'Red',
        playingAs: 'X'
    },
    board: [
        ['o', null, 'x'],
        [null, 'x', 'o'],
        ['x', 'o', null]
    ]
}


//OBJECTS AND REFERENCE TYPES

//Reference type yra array ir objektai

const pallete2 = pallete; //assigning a refference
pallete2.green = '#ebf876'
pallete2.blue = '#30336b'
console.log(pallete)
console.log(pallete2)

//ArRAY/OBJECT EQUALITY

let nums = [1,2,3]
let mysteryNums = [1,2,3]

console.log(nums===mysteryNums) //nums = 5asdas
console.log(nums==mysteryNums)  //mysteryNums = adasd

let moreNums = nums
console.log(moreNums===nums)

const user2 = {
    username: 'Brownie45',
    email: 'browny85@gmail.com',
    norifications: []
};

//[] is not equal to []. Points to different addresses.
console.log(user2.norifications == [])
//! -> casting to boolean
//! -> inverse logic (NOT)
//user2.notifications.length -> 0
// 0-> falsy
// !falsy -> truthly
console.log(!user2.norifications.length)
console.log(!user2.norifications.length > 0)
console.log(user2.norifications.length === 0)

const movieReviews = {
    Arrival: 9.5,
    Aliens: 9.5,
    Amelie: 9.5,
    "In Bruges": 9.5,
    Amadeus: 9.5
}

movieReviews['Lord of the Rings'] = 9.8;

for(let propKey of Object.keys(movieReviews)) {
    console.log(`${propKey} -> ${movieReviews[propKey]}`);
}

const movieRatings = Object.values(movieReviews);
let totalRating = 0;
for (let propValue of movieRatings) {
    console.log(propValue);
    totalRating += propValue
}

console.log(totalRating)
console.log(totalRating/movieRatings.length)


//uzduotis nr2

// let vaikas = {
//     name: 'Jonas',
//     toysArray: ['Lele', 'Masina', 'Sautuvas'],
//     yearsOld: 10,
//     birthday: true,
//     totalToys: null,
//     friends: [{
//         name: 'Petras',
//         activity: 'Sitting'
//     },
//     {
//         name: 'Lukas',
//         activity: 'Playing'
//     },
//     {
//         name: 'Audrius',
//         activity: 'Eating'
//     }
// ]    
// }


// if(vaikas.birthday === true) {
//     vaikas.toysArray.splice(0,1,'Knyga')
//     console.log(vaikas.toysArray)
//     vaikas.yearsOld = vaikas.yearsOld + 1
//     console.log(vaikas.yearsOld)    
//     vaikas.totalToys = vaikas.toysArray.length
//     console.log(vaikas.totalToys) 

//     for (const friend of vaikas.friends) {
//         console.log(` ${friend.name} ${friend.activity}`)
//     }

    
// }

//baigta uzduotis nr2.

// const person = {
//     name: 'Rosa',
//     age: 120,
//     alive: false,
//     interests: ['swiming', 'cards']
// }

// function rosa(person, newName) {
//     person.name = newName
    
//     console.log(person.name)
//     person.age = Math.floor(Math.random() * 120) + 20
//     console.log(person.age)
//     if(person.age < 100) {
//         if(person.alive === false)
//         person.alive = true    
//     console.log(person.alive)

//     if(person.age < 100) {
//         person.interests.push('Enjoying life')
// }
// for (const intersest of person.interests) {
//          console.log(intersest)
// }
//     }
// }


// rosa(person,'Elizabeth')
// rosa(person,'Ana')
// rosa(person,'Elza')
// rosa(person,'Beata')
// rosa(person,'nick')
// rosa(person,'John')
// rosa(person,'Luke')


let first = ['slice', 'splice', 'concat'];
let second = ['push', 'pop', 'shift', 'unshift'];
let firstSecond = first.concat(second);
firstSecond.push('length', 7, {
    subject: 'methods'
});

console.log(firstSecond);

//CALLBACKS

function MessageUserAboutClick() {
    alert('Wow, a button was clicked')
}

let btnRunFunction = document.querySelector('button')
btnRunFunction.addEventListener('click',MessageUserAboutClick)
btnRunFunction.addEventListener('click', function() {console.log('Ohh wow, a function in REPL')
setTimeout(MessageUserAboutClick, 3000)
})

function concatString(acord) {
   acord = acord += '7'
   console.log(acord)
   return acord
}


let accords = ['D', 'G', 'C', 'C7', 'F']

function pridetiSeptynis(accords) {
    for (let acord of accords) {
        if(!acord.endsWith('7')) {
            concatString(acord)  
            //console.log(acord)      
    }
   

    }
    console.log(accords)
}

pridetiSeptynis(accords)


// .FOREACH
// .forEach is a syntax sugar to help avoid using keyword function through our whole application. It is quite a bit slower than forOf.
const numbers2 = [20,21,22,23,24,25,26,27];
numbers2.forEach(function(num) {
    console.log(num * 2);
});

numbers2.forEach(num => console.log(num * 2));

function printTriple(n) {
    console.log(n * 3);
}

numbers2.forEach(printTriple);

// MAP()
// Creates a new array based on our callback function
const doubles = numbers2.map(function(elementOfNumbers2) { //elementOfNumbers2 is an element of numbers2
    return elementOfNumbers2 * 2;
});

console.log(numbers2);
console.log(doubles);

const numDetail = numbers2.map(function(n) { // n is just a name for our element
    return {
        value: n,
        isEven: n % 2 === 0
    };
})

const fakeNumDetails = numbers2.map(function() {
    return {
        value: 10,
        isEven: 10 % 2 === 0
    };
})

console.log(numDetail);
console.log(fakeNumDetails);

// FILTER()
// Creates an array with all elements which pass callback test/function
// Main thing to remember is that your function HAS to return boolean
const filteredOddNumbersNA = numbers2.filter(function(n) { 
    return n % 2 === 1
});
const filteredOddNumbers = numbers2.filter(n => n % 2 === 1);
const filteredEvenNumbers = numbers2.filter(n => n % 2 === 0);

console.log(filteredOddNumbersNA);
console.log(filteredOddNumbers);
console.log(filteredEvenNumbers);




// SOME() AND EVERY()
// EVERY returns a boolean 
const words2 = [
    "dog",
    "dig",
    "log",
    "bag",
    "wag",
];

const all3Letters = words2.every(word => word.length === 3);
const allEndInG = words2.every(word => {
    const last = word.length-1;
    return word[last] === 'g';
});

console.log(all3Letters);
console.log(allEndInG);

const someStartWithD = words2.some(word => word[0] === 'd');
console.log(someStartWithD);




//Nd uždavinys Nr. 1

let numbersArr = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6]

const budgets = [
    {
      name: "Rytis",
      budget: 50,
    },
    {
      name: "Saulė",
      budget: 230,
    },
    {
      name: "Paulius",
      budget: 1500,
    },
    {
      name: "Gytis",
      budget: 92,
    },
    {
      name: "Sandra",
      budget: 7,
    },
  ];




numbersArr.forEach(function(element, index) { 
document.getElementById("pirmauzduotis").innerHTML += `<p>Index Nr: ${index}, value ${element}</p>`
});

document.getElementById("pirmauzduotis").innerHTML += `<hr/>`;

for(let i = 0; i < numbersArr.length; i++) {
    document.getElementById("pirmauzduotis").innerHTML += `<p>Index Nr: ${i}, value ${numbersArr[i]}</p>`
};

//uzdavinys Nr. 2

//multiply numbers
function arrDouble(arr){
   return arr.map(arrEle => arrEle *2)
}
console.log(arrDouble(numbersArr))
//padauginti is to paties skaiciaus kaip masyve

function arrMultiplied(arr, number) {
    return arr.map(m => m * number)
}

console.log(arrMultiplied(numbersArr, 3))

// let ivestasSkaicius = 3
// let arrMultiplied = numbersArr.map(function(ivestasSkaicius) {
//     return ivestasSkaicius * arrMultiplied
//  })

// numbersArr.forEach(function(ivestasSkaicius, numbersArr) {
//     let arrMultiplied = [numbersArr * ivestasSkaicius] 

//     return arrMultiplied
    
    
// });

// console.log(arrMultiplied)

//funcija grazina suma visu biudzetu

function getBudget(budgetArr) {
let sum = 0
budgets.forEach(function(ele) {
    sum += ele.budget
})
return sum

}
console.log(getBudget(budgets))


//map funkcija grazina tik vardus

function getPeopleNames(budgets){
return budgets.map(budget => budget.name)

}
 console.log(getPeopleNames(budgets))

 //TRECIAS UZDAVINYS
//3,1 uzduotis

//destytojo sprendimas
const bugetExercise8 = getPeopleNames(budgets);


function isPersonInArr(nameArr, lookupName) {
    return nameArr.includes(lookupName)
        ? getGenderBasedGreet(lookupName)
        : `Unfotunately Name is not in our list`;
}

function getGenderBasedGreet(name) {
    // Alternative: can be used with endswith
    let lastChar = name.charAt(name.length-1); // name[name.length-1]
    if(lastChar === 's') {
        return `Welcome Mr. ${name}`;
    }
    return `Welcome Miss. ${name}`;
}

console.log(isPersonInArr(bugetExercise8, 'Sandra'));



let names = ["Rytis", "Saulė","Paulius","Gytis","Sandra"]

 function isPersonInArray(person, budgets) {
    if(budgets.some(budget => budget.name === person)) {       
       if(person.endsWith('s')) {
        console.log(`Hello Mr. ${person} `)
       }
       else {
      console.log(`Hello Mrs. ${person} `)        
       }    
    }
    else {
        console.log(`Unfortunatly ${person} is not in our list`)
    
    }
} 
 isPersonInArray("Rytis", budgets)

 //3,2 uzduotis
 function arrCountTwo(numbersArr) {
   
    let howManyTwo = numbersArr.filter(t => t === 2).length;
    return `masyve yra ${howManyTwo} dvejetai`
 }
console.log(arrCountTwo(numbersArr))


//KETVIRTA UZDUOTIS


const budgets4 = [
    {
      name: "Rytis",
      budget: 50,
    },
    {
      name: "Saulė",
      budget: 230,
    },
    {
      name: "Paulius",
      budget: 1500,
    },
    {
      name: "Gytis",
      budget: 92,
    },
    {
      name: "Sandra",
      budget: 7,
    },
  ];
  
  const names4 = budgets4.map((person) => person.name);
  const monies = budgets4.map((person) => person.budget);
//4.1
//Ar monies yra negiiama reiksme

  const arYraNeigiamaReiksme = monies.some(n => n < 0)
  
 console.log(`Ar yra neigiama reiksme: ${arYraNeigiamaReiksme}`)

 //4.2
 //ar daugiau uz simta
 let numbersArr4 = [99,100,101,102,103]
 function belowHundred(arr) {
    if(arr.some(n => n < 100)) {
      return `masyve yra sios reiksmes mazesnes uz 100: ${arr.filter(n => n < 100)}`     
    }
   else {
        console.log('All numbers above 100')
    }
 }
 console.log(belowHundred(monies))

 //4.2

 let demoNames = ['Tomas', 'Jonas','Petras','Greta']

 function simbolified(arr) {
    if(arr.every(v => v.length > 3)) {
        console.log('visi vardai ilgesni uz 3 simbolius')
         if(arr.some(v => v.includes('a'))) {
            console.log('yra vardu ilgesniu uz 3 simbolius, kurie turi a raide')
            let naujasArr = arr.filter (v => v.includes('a'))
            return naujasArr.map(a => a.replace('a', '@'))            
        }
    }
    else {
        console.log('masyve yra trumpesniu vardu nei 3 simboliai')
    }
 }

 console.log(simbolified(demoNames))