const hour = 20;
//let greeting = 'Good Night' // nebutina deklaruoti javascriptas supranta
if(hour < 18)
{
greeting = 'Good day'
}
else
{
greeting = 'Good Night'
}
console.log(greeting)

if (hour < 10) 
{
    greeting = 'Good morning'
    }
    else if(hour < 20)
    {
    greeting = 'Good Night'
    }
    else 
    {
    greeting = 'Good evening'
    }
    console.log(greeting)

    let day
    if(day)
    {
    greeting = 'GOOD DAY'
    }
    else 
    {
    greeting = 'NOT DAY'
    }
    console.log(greeting)

    let a = parseFloat(prompt("Please enter number 1", ));
    let b = parseFloat(prompt("Please enter number 1", ));

    if (a > b) 
    {
    answer = 'Pirmasis skaicius didesnis'
    }
    else if(a < b)
    {
    answer = 'Antrasis skaicius didesnis'
    }
    else if(a === b)
    {
    answer = 'skaiciai lygus'
    }
    else 
    {
    answer = 'negalima palyginti'
    }
    console.log(answer)