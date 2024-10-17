
Console.WriteLine("Hello, World!");
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));//true 
Console.WriteLine(pangram.Contains("cow")); //false
Console.WriteLine(!pangram.Contains("fox")); //false



int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
//? =0 if 


//----------------------------------------------------------------------------------------------------------------------

//voltear moneda
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "Cruz" : "Cara");

//propiedades MinValue y MaxValue para cada tipo de float con signo----------------------------------------------------------------------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


//definir una variable de tipo referencia-----------------------------------------------------------------------------------------------------------------------
int[] data = new int[5];

//propiedades MinValue y MaxValue para cada tipo de float con signo
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");
/*--Value Types--
val_A: 2
val_B: 5*/

//tipose de referencia matriz-----------------------------------------------------------------------------------------------------------------------

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

/*--Reference Types--
ref_A[0]: 5
ref_B[0]: 5*/


//Cuando se cambia apuntan a los mismos puntos de ubicacion de memoria, por lo tanto ambos cambian.
//.ref_B = ref_Aref_Bref_Aref_B[0]ref_A[0]


//------------------Ejercicio Bool-------------------------------------------------------------------------
//https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2

/*If the user is an Admin with a level greater than 55. ---Welcome, Super Admin user.
Si el usuario es un Admin con un nivel menor o igual a 55. ----Welcome, Admin user.
If the user is a Manager with a level 20 or greater. ---Contact an Admin for access.
If the user is a Manager with a level less than 20. ---- Contact an Admin for access.
If the user is not an Admin or a Manager ---- You do not have sufficient privileges.*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


//-------------------Ejercicio 

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");


/*--------Switch exercise--------*/
/*the switch expression is (employeeLevel)
each switch section has a single switch label (case or default).
the matching switch section is defined by case: 200, since employeeLevel = 200.*/

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName}, {title}");

/*--------if else  + switch--------*/
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");


/*For*/

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}


//  https://learn.microsoft.com/en-us/training/modules/csharp-do-while/4-solution    -----------------------
/*Ejercicio
Debe usar la instrucción o la declaración como un bucle de juego externo.do-whilewhile
El héroe y el monstruo comienzan con 10 puntos de vida.
Todos los ataques tienen un valor entre 1 y 10.
El héroe ataca primero.
Imprime la cantidad de salud que perdió el monstruo y la salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprime la cantidad de vida que perdió el héroe y la vida restante.
Continúa esta secuencia de ataque hasta que la salud del monstruo o la salud del héroe sea cero o menos.
Imprime el ganador.
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int attack = dice.Next(1, 11);
    monster -= attack;
    Console.WriteLine($"Monster was damaged and lost{attack} HP!!");

    if (monster > 0) continue;

    attack = dice.Next(1, 11);
    hero -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {hero} health.");

} while (hero > 0 && monster > 0);
Console.WriteLine(hero > monster ? "Hero wins!!" : "Monster wins!!");



/* ------CREAR DATOS DE MUESTRA Y BUCLES-----*/
// el array ourAnimals almacenará lo siguiente: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables para la entrada de datos
/* "?"  acepta valores NULL. Al leer los valores especificados por el usuario con el método, 
es mejor usar un tipo que acepte valores NULL.stringintstring? readResult;?Console.ReadLine()*/
int maxPets = 8;
string? readResult;
string menuSelection = "";

// declaracion array, matriz utilizada para almacenar datos de tiempo de ejecución, no hay datos persistentes
string[,] ourAnimals = new string[maxPets, 6];
switch (i)
{
    case 1:
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;

    case 2:
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;

    case 3:
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

    default:
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;
}
/*----------Escribir instrucción switch para selecciones de menú----------*/
Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine("Press the Enter key to continue");

// pause code execution
//readResult = Console.ReadLine();

switch (menuSelection)
{
    case "1":
        /*Para proporcionar un mensaje de comentarios al usuario entre las líneas de código y,
         actualice el código de la siguiente manera:case "1":break;
         switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;*/
        break;

    case "2":
        break;

    case "3":
        break;

    case "4":
        break;

    case "5":
        break;

    case "6":
        break;

    case "7":
        break;

    case "8":
        break;

    default:
        break;

}



/*-------Crear bucle de menú de programa-------*/
/*do
{    codigo
// pause code execution
readResult = Console.ReadLine();

} while (menuSelection != "exit");*/

/* la matriz es multidimensional. Dado que es una matriz de cadenas multidimensional,
 cada elemento contenido en ella es un elemento independiente*/
string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
};

foreach (string[] array in jaggedArray)
{
    foreach (string value in array)
    {
        Console.WriteLine(value);
    }
    //Para crear una instrucción que compruebe los datos de identificación de mascotas, actualice el código de la siguiente manera:if
   for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine(ourAnimals[i, 0]);
    }
}
}
//Para crear el bucle que iterará a través de las características de cada mascota, actualice su código de la siguiente manera:for
for (int i = 0; i < maxPets; i++)
{
    if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine(ourAnimals[i, 0]);
        for (int j = 0; j < 6; j++)
        {
            Console.WriteLine(ourAnimals[i, j]);
        }
    }
}

/*Cuente el número de mascotas en la matriz ourAnimals*/
