// Jacob Dekok
// 10/17/2022
// Challenge #0 - Mini Challenge #4 Comparing two numbers
// This is a console project that will ask the user for two numbers
// and compare the value of them.

Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

bool firstIsConverted = false;
string userNum1;
bool firstIsNumber;
int firstNum = 0;

bool secondIsConverted = false;
string userNum2;
bool secondIsNumber;
int secondNum = 0;

while(!firstIsConverted){

    Console.Write("Please enter your first whole number: ");
    userNum1 = Console.ReadLine();

    firstIsNumber = Int32.TryParse(userNum1, out firstNum);

    if(firstIsNumber == true){
        firstIsConverted = true;
    }else{
        Console.WriteLine("Invalid entry, please try again.");
    }
}

while(!secondIsConverted){

    Console.Write("Please enter your second whole number: ");
    userNum2 = Console.ReadLine();

    secondIsNumber = Int32.TryParse(userNum2, out secondNum);

    if(secondIsNumber == true){
        secondIsConverted = true;
    }else{
        Console.WriteLine("Invalid entry, please try again.");
    }
}

if(firstNum > secondNum){
    Console.WriteLine(firstNum + " is greater than " + secondNum);
    Console.WriteLine(secondNum + " is less than " + firstNum);
}else if(firstNum < secondNum){
    Console.WriteLine(firstNum + " is less than " + secondNum);
    Console.WriteLine(secondNum + " is greater than " + firstNum);
}else if(firstNum == secondNum){
    Console.WriteLine(firstNum + " is equal to " + secondNum);
}


Console.WriteLine("Would you like to give me two more numbers? 'YES' 'NO'");
playAgain = Console.ReadLine().ToUpper();

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }
}
