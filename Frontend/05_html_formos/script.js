// const fullNameChange = (e) => {
//     const fld = e.target;
   
//         FullName.innerHTML = `${fld.value}`;
     
//   };

//   function fullNameChange() {
// const element = document.getElementById('FullName');
// element.innerHTML = `${fld.value}`
//  }
const changeName = (e) => {
  const fld = e.target; 
    FullName.innerHTML = `${fld.value}`;
};

const inputNumber = (e) => {
  const fld = e.target; 
  output.innerHTML = shift();
};

//cardholder.addEventListener('keyup', fullNameChange)

cardholder.addEventListener('keyup', changeName);
number.addEventListener('keydown', inputNumber);
