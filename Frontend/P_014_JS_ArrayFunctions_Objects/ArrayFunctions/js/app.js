let topSongs = [
    'First Time Ever I Saw Your Face',
    'God Only Knows',
    'A Day In The Life',
    'Life On Mars'
];

// Push ideda i array gala nauja elementa
topSongs[topSongs.length] = "Fortune Song";
topSongs.push("Tie Keliai");
topSongs.push("Zombiai Atrieda");
topSongs.push(true);
console.log(topSongs.push("Candy Shop"));
console.log(`Dainu length: ${topSongs.push("Boruzele")}`);

// Pop returns deleted element
const poppedIncorrectVal = topSongs.pop(); // Boruzele
topSongs.pop(); // Candy Shop
topSongs.pop(); // true
console.log(poppedIncorrectVal);
console.log(topSongs);

let dishesToWash = ['big plater'];
dishesToWash.unshift('large plate'); // Returns array length
console.log(dishesToWash.unshift('small plate'));
dishesToWash.unshift('cereal bowl');
dishesToWash.unshift('mug');
dishesToWash.unshift('dirty spoon');
dishesToWash.unshift('fork', 'knife');

console.log(dishesToWash);

let removedDish = dishesToWash.shift(); // Removes first element of array and returns it
console.log(`${removedDish} was cleaned.`);
console.log(dishesToWash);
dishesToWash.shift();
dishesToWash.shift();
dishesToWash.shift();
dishesToWash.shift();
dishesToWash.shift();
dishesToWash.shift();
dishesToWash.shift();

console.log(dishesToWash);
console.log('Dishes were cleaned');




// CONCAT
// Joins 2 arrays and creates a new array from them both
let fruits = ['apple', 'banana'];
let veggies = ['asparagus', 'bruseel sprouts'];
let meats = ['steak', 'chicken breast'];

let veganFood = fruits.concat(veggies);

console.log(fruits.concat(veggies));
console.log(fruits);
console.log(veggies);
console.log(fruits, veggies);
console.log(veganFood);

let allFood = fruits.concat(veggies, meats);
console.log(allFood);





// INCLUDES AND INDEXOF
// Searches for atleast a single occurance
// Include returns a boolean
// IndexOf returns an integer. If nothing is found returns -1.
let ingredients = [
    'Water',
    'Eel',
    'Corn',
    'Flour',
    'Cheese',
    'Shrimp',
    'Brown sugar',
    'Butter'
];

console.log(ingredients.includes('fish')); // False
console.log(ingredients.includes('Shrimp')); // True
console.log(ingredients.includes('sugar')); // False
console.log(ingredients.includes('Water', 3)); // We start searching from Flour
console.log(ingredients.includes('Cheese', 3));

if(ingredients.includes('Flour')) {
    console.log("I am gluten free, I cannot eat that.");
}

console.log(ingredients.indexOf('Eel'));
console.log(ingredients.indexOf('sugar'));
console.log(ingredients.indexOf('maple syrup'));
console.log(ingredients.indexOf('Cheese', 5)); // Search for Cheese from Shrimp
console.log(ingredients.indexOf('Cheese', 3));

// Truthy or Falsy values
if(ingredients.indexOf('Flour') !== -1) {
    console.log("I am gluten free, I cannot eat that.");
}






// REVERSE AND JOIN
// Reverse - Mutates array
// Join - joins all elements into a single string without mutation
let letters = [
    'T',
    'C',
    'E',
    'P',
    'S',
    'E',
    'R',
];

let randomArrayForReverse = [
    12.3,
    60,
    false
];

console.log(letters);
console.log(letters.reverse()); // Mutates array
console.log(letters);

console.log(letters.join());
console.log(letters.join('&'));
console.log(letters.join('.'));
console.log(letters);

console.log(randomArrayForReverse.join());
console.log(randomArrayForReverse.reverse());
console.log(randomArrayForReverse.join());




// Uzdavinys 1

const exercise1Arr = [];
const resultP = document.querySelector("#result-paragraph");
const arrayItemInput = document.querySelector("#array-item");

function updateParagraph(operation) {
    let appendText = arrayItemInput.value;
    arrayItemInput.value = "";
    operateElement(appendText, operation);
    resultP.textContent = exercise1Arr.join(" ");
    arrayItemInput.focus();
}

function operateElement(ele, operation) {
    switch(operation) {
        case 'push':
            exercise1Arr.push(ele);
            break;
        case 'pop':
            exercise1Arr.pop(ele);
            break;
        case 'unshift':
            exercise1Arr.unshift(ele);
            break;
        case 'shift':
            exercise1Arr.shift(ele);
            break;
    }
}

const pushBtn = document.querySelector('#push')
    .addEventListener('click', function() {
        updateParagraph('push');
    });

const popBtn = document.querySelector('#pop')
    .addEventListener('click', function() {
        updateParagraph('pop');
    });

const unshiftBtn = document.querySelector('#unshift')
    .addEventListener('click', function() {
        updateParagraph('unshift');
    });

const shiftBtn = document.querySelector('#shift')
    .addEventListener('click', function() {
        updateParagraph('shift');
    });

// Uzdavinys 1 DONE



//SLICE
//
let animals = [
    'shark',
    'salmon',
    'whale',
    'bear',
    'lizard',
    'tortoise'
];
let swimmers = animals.slice(0,3) // include 0, but exclude 3
console.log(swimmers)
let mammals = animals.slice(2,4)
let reptiles = animals.slice(4) //go from 4th element till the end

let qudrupeds = animals.slice(-3); // Takes 3 elements from the back
let twoAnimalsFromTheBack = animals.slice(-3, -1)
//Go 3 elements from back (bear), take all and lastly removelast element.

let animalCopyViaSlice = animals.slice();

console.log(`animalCopyViaSlice === animals: ${animalCopyViaSlice === animals}`)

//SPLICE
//Remove, add and updateelements in a specified locations
//Ussualy used in the middle of an array
//array.splice(start,deleteCount,[itemArr])

animals.splice(1,0,'octopus')
console.log(animals);
animals.splice(3,2, 'snake','frog')
console.log(animals);