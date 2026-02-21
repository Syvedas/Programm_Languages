//Javascript Arrays

let colors = ["green", "red", "blue"];      //Let um die Werte der Variable zu bestimmne
colors[2] = "yellow"        //Grün wurde zu Gelb geändert
colors.pop()                //entfernt den letzten Wert im Array
colors.push("purple");      //hinzufügen von Sachen zum Array im Nachhinein
console.log(colors)         //Welche inhalte sind in dem Array
console.log(colors.length)  //Anzahl der Inhalte des Arrays

//Javascript Schleifen

let Rennrad = ["Canyon", "Bianchi","Pinarello"];

//for Schleife
for(let i = 0; i < Rennrad.length; i++)  //Die for-Schleife wird ausgeführt so lange die Bedingung (i<3) klappt
{                                   //"i" ist einfach nur eine Variable
    console.log(Rennrad[i]);
}  
//Leerzeichen
console.log()

//for-of Schleife
for(let Rennraeder of Rennrad)      //Man erstellt eine Variable welche sich auf den Array bezieht
{
    console.log(Rennraeder)
}

console.log()

//While Schleife
let e =0;       //Der code wird immer geprüft, ob es ausgeführt werden kann wegen der Bedingung
while(e < 5)
{
    console.log(e);
    e++
}
console.log();

//Do-While Schleife     
let y = 0;      //Der Code wird als erstes ausgeführt und dann gefprüft

do
{
    console.log(y);
    y++
}while(y < 5);


//JavaScript Arrow Functions
let Motorrad = () => console.log("Motorräder sind cool");   //Kürzere Schreibweise als unten
Motorrad()

function Motorrad1 ()                                       //längerer Schreibweise
{
    console.log("Motorräder sind cool")
}
Motorrad1();


let add = (a,b) => a + b;       //Bei mehreren Parametern (a, b) braucht man ()
console.log(add(1,2))

let square = x => x * x;        //Bei einem Parameter (x) braucht man keine ()
console.log(square(9))


let multiply = (a, b) => 
{
    let result = a * b;
    return result;
}
console.log(multiply(3, 4));


//JavaScript Filer Funktion
let numbers = [1, 2, 3, 4, 5, 6];       //Werte Filter

let evenNumbers = numbers.filter(number => number % 2 === 0);
console.log(evenNumbers);

let marken =
    [
        {name: "Porsche", tueren: 2},
        {name: "Ferarri", tueren: 4},
        {name: "Limosine", tueren: 8}
    ];

let familienauto = marken.filter(marke => marke.tueren >= 4); // mit && kann man noch eine 2 Bedingung hinzufügen