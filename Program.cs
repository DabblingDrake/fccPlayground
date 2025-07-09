// int numExamAssignments = 5;

// string[] studentFirstNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] sophScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmScores = new int[]  { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] logScores = new int[]  { 90, 95, 87, 88, 96, 96 };

// int[] studentGradedScores = new int[10];

// string currentStudentNameLetterGrade = "";

// Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

// // Student         Exam Score      Overall Grade   Extra Credit

// // Sophia          92.2            95.88   A       92 (3.68 pts)
// // Andrew          89.6            91.38   A-      89 (1.78 pts)
// // Emma            85.6            90.94   A-      89 (5.34 pts)
// // Logan           91.2            93.12   A       96 (1.92 pts)

// foreach (string name in studentFirstNames)
// {
//     string currentStudentName = name;

//     if (currentStudentName == "Sophia")
//         studentGradedScores = sophScores;

//     // else if (currentStudentName == "Andrew")
//     //     studentGradedScores = andrScores;

//     // else if (currentStudentName == "Emma")
//     //     studentGradedScores = emmScores;

//     // else if (currentStudentName == "Logan")
//     //     studentGradedScores = logScores;

//     decimal totalSumAssignmentScores = 0;

//     decimal currentStudentNameGrade = 0;

//     int totalGradedAssignments = 0;

//     decimal totalExamAssignmentScore = 0;

//     int extraCreditScore = 0;

//     decimal extraCreditAssignments = 0;

//     foreach (decimal score in studentGradedScores)
//     {
//         totalGradedAssignments += 1;

//         if (totalGradedAssignments <= numExamAssignments)
//         {
//             totalSumAssignmentScores += score;
//             totalExamAssignmentScore += score;
//         }
//         else
//         {
//             totalSumAssignmentScores += score / 10;
//         }
//         Console.WriteLine(totalSumAssignmentScores);
//         // if (totalGradedAssignments > numExamAssignments)
//         // {
//         //     extraCreditScore += score;
//         // }

//     }

//     extraCreditAssignments = totalGradedAssignments - numExamAssignments;
//     currentStudentNameGrade = (decimal)totalSumAssignmentScores / numExamAssignments;

//     if (currentStudentNameGrade >= 97)
//         currentStudentNameLetterGrade = "A+";

//     else if (currentStudentNameGrade >= 93)
//         currentStudentNameLetterGrade = "A";

//     else if (currentStudentNameGrade >= 90)
//         currentStudentNameLetterGrade = "A-";

//     else if (currentStudentNameGrade >= 87)
//         currentStudentNameLetterGrade = "B+";

//     else if (currentStudentNameGrade >= 83)
//         currentStudentNameLetterGrade = "B";

//     else if (currentStudentNameGrade >= 80)
//         currentStudentNameLetterGrade = "B-";

//     else if (currentStudentNameGrade >= 77)
//         currentStudentNameLetterGrade = "C+";

//     else if (currentStudentNameGrade >= 73)
//         currentStudentNameLetterGrade = "C";

//     else if (currentStudentNameGrade >= 70)
//         currentStudentNameLetterGrade = "C-";

//     else if (currentStudentNameGrade >= 67)
//         currentStudentNameLetterGrade = "D+";

//     else if (currentStudentNameGrade >= 63)
//         currentStudentNameLetterGrade = "D";

//     else if (currentStudentNameGrade >= 60)
//         currentStudentNameLetterGrade = "D-";

//     else
//         currentStudentNameLetterGrade = "F";

//     Console.WriteLine($"{currentStudentName}\t\t{(decimal)totalExamAssignmentScore / numExamAssignments}\t\t{currentStudentNameGrade}\t{currentStudentNameLetterGrade}\t{extraCreditScore / extraCreditAssignments} ({currentStudentNameGrade - (decimal)totalExamAssignmentScore / numExamAssignments} pts)");
//     // Console.WriteLine($"Total Exam score {totalSumAssignmentScores}, Number of Exams: {numExamAssignments}");
// }


// int main()
// {
//     int a = 5, b = 10;


//     return (a + b);

// }

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string value1 = " a";
// string value2 = "A ";
// // Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));


// string myString = "I like pineapple on my pizza!";               // Return Value:
// Console.WriteLine(myString ==  "I like pineapple on my pizza!"); // True
// Console.WriteLine(myString.Contains("pineapple"));               // True
// Console.WriteLine(myString.Contains("pepperoni"));               // False        
// // Console.WriteLine(myString.EndsWith("!"));                       // True
// // Console.WriteLine(myString.StartsWith("You"));                   // False


// string myString = "I like pineapple on my pizza!";               // Return Value:
// Console.WriteLine(myString.Contains("pineapple") == false );     // True
// Console.WriteLine(!myString.Contains("pineapple"));              // True


// var x = 2;
// var y = 3;

// // Console.WriteLine("x = 2, y = 3");
// // Console.Write($"{x} == {y}: \t");
// // Console.WriteLine(x == y);
// // Console.Write($"\n!({x} == {y}): \t");
// // Console.WriteLine(!(x == y));
// // Console.Write($"\n{x} != {y}: \t");
// // Console.WriteLine(x != y);
// Console.Write($"\n{x} is not 3: \t");
// Console.WriteLine(x is not 3);
// Console.Write($"\n{x} is 3: \t");
// Console.WriteLine(x is 3);
// Console.Write($"\n{y} is 3: \t");
// Console.WriteLine(y is 3);
// Console.Write($"\n{y} is not 3: \t");
// Console.WriteLine(y is 3);
// Console.Write($"\n{y} is 3: \t");
// Console.WriteLine(y is 3);
// Console.Write($"\n{y} is not 3: \t");
// Console.WriteLine(y is 3);


// using System.Net.Security;

// string s1 = "\"hello\"";
// string s2 = "hello";
// string s3 = "hello";
// Console.WriteLine($"\ns1 = \"hello\", s2 = hello, s3 = hello");
// Console.Write($"{s2} == {s3}\t");
// Console.WriteLine(s2 == s3);
// Console.Write($"{s2} != {s3}\t");
// Console.WriteLine(s2 != s3);
// Console.Write($"{s1} == {s3}\t");
// Console.WriteLine(s1 == s3);
// Console.Write($"{s1} != {s3}\t");
// Console.WriteLine(s1 != s3);

// Console.Write($"\n!({s2} == {s3})\t");
// Console.WriteLine(!(s2 == s3));
// Console.Write($"!({s2} != {s3})\t");
// Console.WriteLine(!(s2 != s3));
// Console.Write($"!({s1} == {s3})\t");
// Console.WriteLine(!(s1 == s3));
// Console.Write($"!({s1} != {s3})\t");
// Console.WriteLine(!(s1 != s3));




// // Logical Negation
// string myString = "I like pineapple on my pizza!";
// Console.WriteLine(!myString.Contains("pineapple")); // False, myString does contain "pineapple", so the output is reversed to 'false'

// // Inequality Operator
// string playerNumber = "Player One";
// Console.WriteLine(playerNumber != "Player One"); // False, Asking if playerNumber not equal to "Player One"
// Console.WriteLine(playerNumber != "Player Two"); // True, Asking if playerNumber not equal to "Player Two"


// int currentHealth = 61;
// int attackBuff = 0;
// if (currentHealth <= 30)
// {
//     attackBuff = 20;
//     Console.WriteLine($"Increases attack by {attackBuff}%");
// }
// else if (currentHealth <= 60)
// { 
//     attackBuff = 5;
//     Console.WriteLine($"Increases attack by {attackBuff}%");
// }
// else
// {
//     Console.WriteLine($"Increases attack by {attackBuff}%");
// }


// Console.WriteLine($"Increases attack by {(currentHealth <= 30 ? 20 : (currentHealth <= 60 ? 5 : 0))}%");

// Random coinToss = new();
// int coinTossResult = coinToss.Next(0, 2);
// if (coinTossResult == 0)
// Console.WriteLine(coinTossResult);

// Random coinToss = new();
// int coinTossResult = coinToss.Next(0, 2);
// Console.WriteLine(coinTossResult);
// Console.WriteLine($"{(coinTossResult == 1 ? "Heads" : "Tails")}");

// Admin, level > 55, "Welcome, Super Admin user."
// Admin, level <= 55, "Welcome, Admin user."
// Manager, level >= 20, "Contact an Admin for access."
// Manager, level < 20, "You do not have sufficient privileges."
// Neither role, "You do not have sufficient privileges."

// using System.ComponentModel;

// string permission = "Staff";
// int level = 100;
// if (permission.Contains("Admin"))
// {
//     Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }


// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }
// Console.WriteLine($"Outside the code block: {value}");

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         string S = Console.ReadLine();
//         int K = int.Parse(Console.ReadLine());

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

//         Console.WriteLine("answer");
//     }


// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;


using System.Globalization;
using Microsoft.Win32;


/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         string[] inputs = Console.ReadLine().Split(' ');
//         int r = int.Parse(inputs[0]);
//         int g = int.Parse(inputs[1]);
//         int b = int.Parse(inputs[2]);
//         int rValue = 0;

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");
//         foreach (string input in inputs)
//         {
//             rValue = int.Parse(input);
//             if (rValue == 0)
//             {
//                 rValue += 255;
//             }
//             else if (rValue == 255)
//             {
//                 rValue -= 255;
//             }
//             Console.WriteLine($"Reverse of {input} is {rValue}");
//         }

//         Console.Error.WriteLine($"{rValue} {rValue} {rValue}");
//     }
// }

// string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine($"{orderID.IndexOf("B")}");
//     }

// }


// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
// }
// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// }
// else if (product[0] == "02")
// {
//     type = "T-Shirt";
// }
// else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// for (int j = 10; j >= 0; j--)
// {
//     Console.WriteLine(j);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" }; // iterates backwards
// for (int i = names.Length -1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }
// string[] namez = { "Alex", "Eddie", "David", "Michael" }; // iterates forwards
// for (int j = 0; j < namez.Length; j++)
// {
//     Console.WriteLine(namez[j]);
// }


//will not run
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }



// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

// // Same as above but more condensed.
// string[] namez = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < namez.Length; i++)
//     if (namez[i] == "David") namez[i] = "Sammy";

// foreach (var name in namez) Console.WriteLine(name);

// Divisible
// 3 = Fizz, 5 = Buzz, both = FizzBuzz

// string byThree = "Fizz", byFive = "Buzz";
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//         Console.WriteLine(i + " - " + byThree + byFive);
//     else if (i % 3 == 0)
//         Console.WriteLine(i + " - " + byThree);
//     else if (i % 5 == 0)
//         Console.WriteLine(i + " - " + byFive);
//     else
//         Console.WriteLine(i);
// }

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }
    else if (i == 1)
    {
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
    }
    else if (i == 2)
    {
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
    }
    else if (i == 3)
    {
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    else
    {
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
