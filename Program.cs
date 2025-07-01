// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// // int sum = 11 + 5, difference = 11 - 5, product = 11 * 5, quotien = 11 / 5;
// // Console.WriteLine("Sum: = " + sum);                // Sum: = 16
// // Console.WriteLine("Difference: = " + difference);  // Difference: = 6
// // Console.WriteLine("Product = " + product);         // Product = 55
// // Console.WriteLine("Quotien = " + quotien);         // Quotien = 2

// // float numOne = 7.0f, numTwo = 6; double numA = 7.0, numB = 6; decimal numX = 7.0m, numY = 6;

// // System.Console.WriteLine("Float: " + (numOne / numTwo));
// // System.Console.WriteLine("Double: " + (numA / numB));
// // System.Console.WriteLine("Decimal: " + (numX / numY));

// // int numX = 7, numY = 6, numA = 7, numB =6, numG = 7, numH = 6;
// // double castNumberX = ((double)numX / (double)numY);
// // decimal castNumberA = ((decimal)numA / (decimal)numB);
// // float castNumberG = ((float)numG / (float)numH);
// // System.Console.WriteLine(castNumberG);
// // System.Console.WriteLine(castNumberX);
// // System.Console.WriteLine(castNumberA);


// // using System.Xml;

// // int odd = 11;
// // if (odd % 2 == 0) // since the remainder of 11 / 2 is 1, then the number is odd 
// // 	Console.WriteLine("The number is even");
// // else if (odd % 2 == 1)
// //     Console.WriteLine("The number is odd");

// // int even = 12;
// // if (even % 2 == 0) // since there is no remainder for 12 / 2, then the number is even
// //     Console.WriteLine("The number is even");
// // else if (even % 2 == 1) 
// //     Console.WriteLine("The number is odd");

// // int bigNum = 150, medNum = 75, smallNum = 30;
// // Console.WriteLine($"Modulus of {bigNum} / {medNum} is: {bigNum % medNum}\n Modulus of {medNum} / {smallNum} is: {medNum % smallNum}");

// // using System.Runtime.CompilerServices;


// // int eNum = 12;
// // if (eNum % 2 == 0) Console.WriteLine($"{eNum} is even");
// //     else if (eNum % 2 == 1) Console.WriteLine($"{eNum} is odd");
// // Console.WriteLine("");


// // int numOne = 4 + 4 * 6, numTwo = (4 + 4) * 6;
// // Console.WriteLine(numOne);
// // Console.WriteLine(numTwo);

// // int i = 1, j;
// // j = ++i; // pre-increment meaning it will do i++ which is i + 1 = 1 + 1 = 2 and then assign that value to 2
// // Console.WriteLine($"'int i = 1, j; j = ++i;' " + $"calculates the value of i before it assigns it to j so i = {i} then j = {j}");

// // int k = 1, n;
// // n = k++; // post-increment meaning it will n = k = 1, then k will increment by 1 and k = 2
// // Console.WriteLine($"'int k = 1, n; n = k++;' " + $"calculates the value of k after it assigns it to n so k = {k} then n = {n}");

// // int v = 1, m;
// // m = --v; // pre-decrement meaning it will do --v which is v - 1 = 1 - 1 = 0 and then assign that value to 0
// // Console.WriteLine("'int v = 1, m; m = --v;' " + $"calculates the value of v before it assigns it to m so v = {v} then m = {m}");

// // int w = 1, p;
// // p = w--; // post-decrement meaning it will p = o = 1, then o will decrement by 1 and o = 0
// // Console.WriteLine("'int w = 1, p; p = w--;' " + $"calculates the value of w after it assigns it to p so w = {w} then p = {p}");

// // int val = 0;   // value is 0
// // System.Console.WriteLine(val);
// // // val = val + 2; // value is 2
// // // System.Console.WriteLine(val);
// // val += 2;      

// // System.Console.WriteLine(val);int value = 1;
// // value++;
// // Console.WriteLine("First: " + value);
// // Console.WriteLine($"Second: {value++}");
// // // Console.WriteLine("Third: " + value);
// // // Console.WriteLine("Fourth: " + (++value));

// // int value = 1;

// // value = value - 1;
// // Console.WriteLine("Decrement 1: " + value);
// // value += 1;
// // Console.WriteLine("Increment 1: " + value);  
// // value++;
// // Console.WriteLine("Increment 2: " + value);  
// // // value -= 1;
// // // Console.WriteLine("Decrement 2: " + value);  


// // int i = 1, j;

// // j = ++i; // pre-increment meaning it will do i++ which is i + 1 = 1 + 1 = 2 and then assign that value to 2
// // Console.WriteLine($"'int i = 1, j; j = ++i;'" + $"calculates the value of i before it assigns it to j so i = {i} then j = {j}");

// // int k = 1, n;
// // n = k++; // post-increment meaning it will n = k = 1, then k will increment by 1 and k = 2
// // Console.WriteLine($"'int k = 1, n; n = k++;'" + $"calculates the value of k after it assigns it to n so k = {k} then n = {n}");

// // int v = 1, m;
// // m = --v; // pre-decrement meaning it will do --v which is v - 1 = 1 - 1 = 0 and then assign that value to 0
// // Console.WriteLine("'int v = 1, m; m = --v;' " + $"calculates the value of v before it assigns it to m so v = {v} then m = {m}");

// // int w = 1, p;
// // // p =w--; // post-decrement meaning it will p = o = 1, then o will decrement by 1 and o = 0
// // // Console.WriteLine("'int w = 1, p; p = w--;' " + $"calculates the value of w before it assigns it to p so w = {w} then p = {p}");


// // int fahrenheit = 94; // celcius = -32 multiply 5/9ths
// // decimal celCon = 5.0m / 9m;

// // System.Console.WriteLine($"The temperature is {(fahrenheit - 32) * celCon} Celsius.");


// // int result = 3 + 1 * 5 / 2;
// // System.Console.WriteLine(result);


Random diceRoll = new();
// int rollOne = 6;
// int rollTwo = 6;
// // int rollThree = 6;
// int rollOne = diceRoll.Next(1, 7);
// int rollTwo = diceRoll.Next(1, 7);
// int rollThree = diceRoll.Next(1, 7);

// int totalRoll = rollOne + rollTwo + rollThree;

// Console.WriteLine($"Dice roll: {rollOne} + {rollTwo} +  {rollThree} = {totalRoll}");
// if (((rollOne == rollTwo) || (rollOne == rollThree) || (rollTwo == rollThree)))
// {
//     if ((rollOne == rollTwo) && (rollTwo == rollThree))
//     {
//         Console.WriteLine($"You rolled tripples! +6 to total");
//         totalRoll += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 Bonus to total!");
//         totalRoll += 2;
//     }
// }


// if (totalRoll >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (totalRoll >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (totalRoll == 7)
// {
//     Console.WriteLine("You win a vacation!");
// }
// else 
// {
//     Console.WriteLine("You win a kitten!");
// }
// string status = "Active", level = "IP";
// int balance = 0;
// if ((balance == 0) && (status == "Active"))
// {
//     Console.WriteLine("Access Granted");
// }
// if ((level == "VIP") || (status == "Active"))
// {
//     Console.WriteLine("Access Granted");

Random random = new Random();
// int daysUntilExpiration = random.Next(12);
int daysUntilExpiration = 5;
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration <= 05)
{
    if (daysUntilExpiration <= 1)
    {
        discountPercentage = 20;
    }
    else
    {
        discountPercentage = 10;
    }
}


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
 