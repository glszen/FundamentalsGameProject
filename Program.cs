using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome! Which program would you like to run? 3 different options: \r\n\n1 - Random Number Finding Game\r\n\r\n2 - Calculator\r\n\r\n3 - Average Calculation");
string selectedOptions = Console.ReadLine(); //The user was asked which game wanted to choose with the welcome message and was asked to choose.


if (selectedOptions == "1") //If option 1 is chosen, the first game will be played.
{
    Console.WriteLine( "\n***Welcome to Random Number Finding Game***");
    int RandomValue(int random) //A method has been defined to be used when generating between 1 amd 100 random numbers.
    {
        Random rnd = new Random();
        random = rnd.Next(1, 100);
        return random;
    }

    int random = (RandomValue(0)); //The previously defined method was assigned to the 'random' command and random numbers started to be generated.

    int heal = 5; //The user's heal is defined.
    int total = 0; //The value at which the user's heals will be collected has been defined.

    Console.Write("\nYour current heal is: " + heal + "\nPlease predict a number between 1 and 100: "); //The user was asked to guess a random number and it shows that the user has 5 heal.
    int predict = Convert.ToInt32(Console.ReadLine());

    if (predict <= 0 || predict > 100)
    {
        Console.WriteLine("\nPlease enter a number between 1 and 100."); //If the user does not enter a number within the desired range, a warning is given and the program terminates.
        return;
    }

        while (true) //Creating a loop with while
    {
        if (heal == 1) //If the user's heal is equal to 1, that is, when his heal is 0 in total (a total of 5 guessing rights are over); It finishes the loop and says the correct number.
        {
            Console.WriteLine("\nYour heals are over. Random number is: " + random);
            break;
        }

        else //If the user still hasn't finished his or her guesses and hasn't predicted the number correctly, the cycle continues and the user is given the heal to predict again.
        {
            if (predict < random) //If the number it predicts is smaller than the randomly generated number, it tells you how close it is and asks for another predict;
            {
                Console.WriteLine("\nThe number you predicted is smaller than the random number.");
                heal = heal - 1;
                total = heal;
                Console.WriteLine("\nYour current heal is: " + heal);

                Console.Write("\nPlease predict a number between 1 and 100: ");
                predict = Convert.ToInt32(Console.ReadLine());
            }
            else if (predict > random) //If the number it guesses is bigger than the randomly generated number, it tells you how close it is and asks for another predict;
            {
                Console.WriteLine("\nThe number you predicted is bigger than the random number.");
                heal = heal - 1;
                total = heal;
                Console.WriteLine("\nYour current heal is: " + heal);

                Console.Write("\nPlease predict a number between 1 and 100: ");
                predict = Convert.ToInt32(Console.ReadLine());
            }
            else if (predict == random) //If the number she guesses is equal to the randomly generated number, the user wins and receives a congratulatory message and the loop ends.
            {
                Console.WriteLine("\nCongratulations! Your predicted is correct.");
                total = heal;
                break;
            }
        }
    }
}





else if (selectedOptions == "2") //If option number 2 is chosen, the second game will be played.
{
    Console.WriteLine("\n***Welcome to Calculator Game***");

    Console.Write("\nPlease enter a first number: ");
    double number1 = Convert.ToDouble(Console.ReadLine()); //The user was asked for a number and this number variable was converted to double

    Console.Write("Please enter a second number: ");
    double number2 = Convert.ToDouble(Console.ReadLine()); //The user was asked for a number and this number variable was converted to double

    Console.Write("Please select the action you want to take: ");
    string action = Console.ReadLine(); //The user was asked to select the action wanted to perform.

    double addition = number1 + number2; //addition, subtraction, multiplication and division operations were defined numerically.
    double subtraction = number1 - number2;
    double multiplication = number1 * number2;
    double division = number1 / number2;

    if (action == "+") //If the user chooses collection, the action to be taken is:
    {
        Console.WriteLine("\nThe sum of the two numbers you choose is: " + addition);
    }
    else if (action == "-") //If the user chooses to extract:
    {
        Console.WriteLine("\nThe difference between the two numbers you chose is: " + subtraction);
    }
    else if (action == "*") //If the user chooses multiplication, the following is the procedure:
    {
        Console.WriteLine("\nMultiplication of two numbers you choose: " + multiplication);
    }
    else if (action == "/") //If the user chooses division, the following is the procedure:
    {
        Console.WriteLine(number1 == 0 ? "\nYou can't divide zero by a number." : "\nThe quotient of two numbers you choose: " + division); //Since zero cannot be divided by any number, the user was given a warning and no action was taken.
    }
    else
    {
        Console.WriteLine("\nYou entered an incorrect transaction type."); //A warning was issued if the user entered an incorrect operator.
    }
}






else if(selectedOptions == "3") //If option number 3 is chosen, the third game will be played.

{
    Console.WriteLine("\n***Welcome to Average Calculation Game!***");

    Console.Write("\nEnter your first exam score: ");
    double examScore1 = Convert.ToDouble(Console.ReadLine()); //User asked for first score.

    if (examScore1 <= 100 && examScore1 > 0) //If the score is not within the desired range, the user will receive a warning message and the program will terminate.If it is in the correct range, the program will print the score.
    {
        Console.WriteLine("First exam score:  " + examScore1);
    }
    else
    {
        Console.WriteLine("You entered the wrong score. Please enter a number between 0 and 100.");
        return;
    }

    Console.Write("Enter your second exam score: ");
    double examScore2 = Convert.ToDouble(Console.ReadLine()); //User asked for second score.

    if (examScore2 <= 100 && examScore2 > 0)
    {
        Console.WriteLine("Second exam score:  " + examScore2);
    }
    else
    {
        Console.WriteLine("You entered the wrong score. Please enter a number between 0 and 100.");
        return;
    }

    Console.Write("Enter your third exam score: ");
    double examScore3 = Convert.ToDouble(Console.ReadLine()); //User asked for third score.

    if (examScore3 <= 100 && examScore3 > 0)
    {
        Console.WriteLine("Third exam score:  " + examScore3);
    }
    else
    {
        Console.WriteLine("You entered the wrong score. Please enter a number between 0 and 100.");
        return;
    }

    double averageScore = (examScore1 + examScore2 + examScore3) / 3; //The average of the three exam scores taken was taken.

    if (averageScore <= 100 && averageScore >= 90) //In the if-elseif blocks here, the letter grade corresponding to the average grade was printed.
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: AA");
    }
    else if (averageScore <= 89 && averageScore >= 85)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: BA");
    }
    else if (averageScore <= 84 && averageScore >= 80)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: BB");
    }
    else if (averageScore <= 79 && averageScore >= 75)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: CB");
    }
    else if (averageScore <= 74 && averageScore >= 70)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: CC");
    }
    else if (averageScore <= 69 && averageScore >= 65)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: DC");
    }
    else if (averageScore <= 64 && averageScore >= 60)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: DD");
    }
    else if (averageScore <= 59 && averageScore >= 55)
    {
        Console.WriteLine("Your average score is: " + averageScore + " and letter equivalent of your average grade is: FD");
    }
    else if (averageScore <= 54 && averageScore >= 0)
    {
        Console.WriteLine("\nYour average score is: " + averageScore + " and letter equivalent of your average grade is: FF");
    }
}

else //If an incorrect option is selected, you will receive an error message and the application will terminate.
{
    Console.WriteLine("There is no such option.");
    return;
}

