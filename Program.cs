Random dice1 = new Random();// simula un lanzamiento de dado mediante  le metodo ramdom.next
int roll = dice1.Next(1, 7); // new es una nueva instacia de la clase Random.
Console.WriteLine(roll);

//int  result = Random.Next(); // indica que tiene un error de compilacion -- linea roja

Random dice = new Random();
int roll1 = dice.Next(); // no establece limites inferiores ni superiores
int roll2 = dice.Next(101);// establece como limite superior el valor de 100
int roll3 = dice.Next(50, 101);// establce un valor inferior y superior
Console.WriteLine($" first roll: {roll1}");
Console.WriteLine($" second roll: {roll2}");
Console.WriteLine($" third roll: {roll3}");

//ejercicio el mayor de dos numero del metodo systeme.math
int first1 = 500;
int second = 200;
int largeValue = Math.Max(first1, second);
Console.WriteLine(largeValue);

// ejercicio con condicionales
Random juego = new();
int dado1 = juego.Next(1, 7);
int dado2 = juego.Next(1, 7);
int dado3 = juego.Next(1, 7);

int total = dado1 + dado2 + dado3;
Console.WriteLine($"score: {dado1} + {dado2} + {dado3} = {total}");
if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    if ((dado1 == dado2) && (dado2 == dado3))
    {
        Console.WriteLine("you rolled triple! 6 point to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("you rolled double! 2 point to total");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a car");
}
else if (total >= 10)
{
    Console.WriteLine("you win a new laptop");
}
else if (total == 7)
{
    Console.WriteLine("you win a trip for two");

}
else
{
    Console.WriteLine("you win a kitte");

}
// ejercicio desafio de negocio
Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your suscription has expired");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your suscription expires within a day");
    discountPercentage = 20;
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"your suscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your suscription expire soon. Renew Now");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

//matrices
/*string [] fraudlentOrderIds = new string [3]; // crea una nueva estancia de una matriz en memoria
fraudlentOrderIds [0] ="A123";
fraudlentOrderIds [1] = "B456";
fraudlentOrderIds [2] = "C789";*/
string[] fraudlentOrderIds = { "A123", "B456", "C789" };// inicializa una matriz, usar llaves


Console.WriteLine($"uno: {fraudlentOrderIds[0]}");
Console.WriteLine($"dos: {fraudlentOrderIds[1]}");
Console.WriteLine($"tres:{fraudlentOrderIds[2]}");
fraudlentOrderIds[2] = "000";
Console.WriteLine($"tres:{fraudlentOrderIds[2]}");
Console.WriteLine($"There are {fraudlentOrderIds.Length} fraudulent orders to process");// longitud de la matriz

string[] numeros = { "2", "4", "5", "6" };
foreach (string joker in numeros)// recorre en bucle la matriz almacena el dato y lo imprime
{
    Console.WriteLine(joker);
}

int[] inventory = { 200, 400, 600, 500, 700 };
int sum = 0;
int bin = 0;
foreach (int lips in inventory)
{
    bin++;// mostrara lo que contiene la matriz en la posicion para el ejemplo numero de contenedor
    sum += lips; // va sumando lo que hay en inventary
    Console.WriteLine($" contenedor {bin}= {lips} items (total= {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

//desafio de matriz
string[] pedidos = { "B123", "C234", "A345", "C15", "B117", "C3003", "C235", "B179" };
foreach (string joke in pedidos)// recorre en bucle la matriz almacena el dato y lo imprime
{
    if (joke.StartsWith("B"))
    {
        Console.WriteLine(joke);
    }
}
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random2 = new();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
//espacios en blanco
string originalMessage = "the quick brown fox jumps over the lazy dog";

// convert the message into a char array
char[] message = originalMessage.ToCharArray();
Array.Reverse(message);//reverse the chars

int letterCount = 0;

//count the o's
foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}
//convert it back to string
string newMessage = new String(message);

//print it out
Console.WriteLine(newMessage);

Console.WriteLine($"'o' appears {letterCount} times.");
