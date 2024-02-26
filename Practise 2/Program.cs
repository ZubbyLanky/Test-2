/* Program.cs
 * 
 * 
 *     This is a practise section for codes.
 * 
 * Revision History;
        -Nworah Christian Nworah  2024 January 25 -Created.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Declearing a variable.
            int sum;
            int difference;
            int mutltiplication = 7 * 2;
            int Quotient;
            int Modulus;


            ////Doing some mathmatical equation
            sum = 7 + 5;
            difference = 7 - 2;
            mutltiplication = 7 * 3; //Note it will multiple the last assigment which is 7*3 and not 7*2
            Quotient = 7 / 2;
            Modulus = 7 % 3;


            //What to display on the user screen.
            Console.WriteLine($"sum        {sum}\n");
            Console.WriteLine($"Difference {difference}\n");
            Console.WriteLine($"Multiply   {mutltiplication}\n");
            Console.WriteLine($"Quotient   {Quotient}\n");
            Console.WriteLine($"Modulus    {Modulus}");


            //Use of incrfeatment operator.
            int value = 0;
            value = value + 5;
            value += 4;
            Console.WriteLine(value);

            //Use of increment, before and after a value.
            int num1 = 1;
            Console.WriteLine("First" + num1);
            num1++;
            Console.WriteLine(num1);


            //Convert from Fr to celsius

            //Delaring the variable
            int frahrenhit = 94;
            int a = frahrenhit - 32;
            decimal multpy = a * 0.555555m;

            Console.WriteLine(a);
            Console.WriteLine($"The temperature {multpy}");






            //Declaring variables 


            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;


            float averageSophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / 5.0f;


            float averagenicolas = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / 5.0f;


            float averagezahirah = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / 5.0f;


            float avreageJeong = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / 5.0f;

            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine($"Sophia\t\t{averageSophia} A");
            Console.WriteLine($"Nicolas\t\t{averagenicolas} B");
            Console.WriteLine($"Zahirah\t\t{averagezahirah} B");
            Console.WriteLine($"Jeong\t\t{avreageJeong} A");

            //Note casting is used to covertfrom one data type to another data type. 

            //Next question:2



            //calculate GPA by grade value * credit hrs
            //Do this for each course, then add tyhe results

            //For sophia
            string name = "Sophia";

            string english = "Enblish 101";
            string algera = "Algera 101";
            string biology = "Biology 101";
            string cp = "Computer Science 101";
            string psychology = "Psychologyh 101";

            int sophiaGradeEnlish = 4;
            int sophiaGradeAlgebra = 3;
            int sophiaGradeBio = 3;
            int sophiaGradeCp = 3;
            int sophiaGradePsychology = 4;

            int englishCredit = 3;
            int algebraCredit = 3;
            int biologyCredit = 4;
            int cpCredit = 4;
            int psychologyCredit = 3;

            float totalCredit = englishCredit + algebraCredit + biologyCredit + cpCredit + psychologyCredit;


            //Mathematical expression
            int forEnglish = sophiaGradeEnlish * englishCredit;
            int forAlgebra = sophiaGradeAlgebra * algebraCredit;
            int forBiology = sophiaGradeBio * biologyCredit;
            int forCp = sophiaGradeCp * cpCredit;
            int forPsychology = sophiaGradePsychology * psychologyCredit;



            float gpa = (forEnglish + forAlgebra + forBiology + forCp + forPsychology) / totalCredit;


            //output 

            Console.WriteLine($"Name: {name}\nClass Information\nGPA:{gpa}");

            // Note: The codes are read from left to right.Note they are two escape chararter you know. they are \t\n

            //What is difference between float and signle data type ?

            //PART 2 (IDE) Intergarted Development Enviroment



            //When you use integar for a palce where youn suoppse to use decimal, you will be required to use casting to convert it to it to a decimal.

            //Without the read key the codes automaticvally complete, but when you put in the read key  it wait for you to put in a key to complete.
            //Console.ReadLine() is used to fill in the users details.

            //What is difference between ReadLine and ReadKey
            //Why does my Thread.Sleep() always show a red line. Cause you have't added Using System.Threading;
            //Note method always have an paranthesis
            //Note the pnly difference between int32 or int16 os just how many number they can store.
            /*
            single stores only 7 digits 
                decimal store only 28 - 29;
                double stores only 15 - 16;
                float store 7digits
                Console.WindowHeight = 4; what is this used for ?
                What is the difference betwenn Read and ReadLine ?

            */

            //Nesting an if statement is out inside another if statement is called nesting.


            //Will learn the characistic of methods, and why the .NET class library are designaed and implemented differently across the .NET Class library.
            //2. You will .NET library to acheieve specific task.
            //3.     learn how find classes and method in the .NET Class Library 

            /*
             .NET library is a good place to look at becasue it contains an orgainesed collection of programming resources.

            .NET Clasas are collections of thousands of class which contain tens of thounsands of method. e.g the class Console which is a class contains different methods from Write(), WriteLine(), ReadLine(), and ReadKey()
            class are like container for methods. The mehtod camn be a send or recieve message from the console.


            they some families that enable you access native desktop applicatin development and others enables access to dtatbase 
            //have a NET Library of multiple functionality is a huge time saver. THhe classes and method are formed by microsoft 
            //Data type is a form of class.

            How to call a method in C#
            -class name
            -access operator
            -method
            invocationb operator
            -specify the argument operator
            - You might also need to pass additional value as input parameters
            -Accept a return value.
            

            Stateful(Instance methods) and Stateless(static) method.
            State is the condition of the execution enviroment at a given time. 
            stateless method can also be called static method. this don't rely on current stae of the application to work. I.E they can work without refering to other values already stored in the sysytem.
            E.G Console.WriteLine() doesn't require any other value or factor to despaly on the output.
            Stateful method keep tracking of their state in fields, 
            A single class can support both stateful or stateless method, but when you want to call the stateful method, you must first create an instance of the class so that the method can access state.



            How to create an instance for the class
            An instance of a class is called object. to create a new class we use the new operator 
            what the new does:
            -it request an address in the computer memory large enogu to store a new object, based on Random class
            -It creates the new object and store it at the memmory address
            -It return the memory address so it can be saved in a dice.


            Calling a method:
            -Retrun values
            -Input Parameters
            -Overloaded method


            -Retrun values
            some method are designed to end quietly, meaning threy don't return any value and a redfered to as void methods 
            while some are designed to return a value and the value, and the returned value is a way for the method to communicate back to the code that calls the method.


            int roll = dice.Next(1, 7);
            Console.WriteLine(dice.Next(1, 7));
            dice.Next(1, 7);


            Input Parameters
            paramter and arguments 
            not all method requires a aparameter to complete theitask. E.g Console.Clear();

            OverLoad Methods 


            USE INTELLISENSE
            float can be positiv eor native numbers 

            Loop allows us to repeat certain part of our program. E.G reading a number 1-10 or guessing a number hwere the player continiouly 

             Type of loops -for loop and while loop.
            The for loop runs for 10 iteration meaning the for loop runs 10 times.The for loop gives what iteration we are at and we iften call this i.
            we mustly start the iteration at 0. meaning the first time the 


            
            for ( write what should happen before the loop starts; Condition, each time we go though the loop we want .......  ){
                Console.WriteLine(i+1);
            }


            While, we want to repeat code as long as a certain condition is met.

            While (condtion that needs to met for our code to run){

            }
            Array are used to store mutiple values in a single variable unlike variables.

            string[]variable name={
            "vales1", "value2", "value3"
            }
            value1 has the index = 0
            value2 has index of =0 we use the index to access an element in the array

            Creating a list 
            List<string> shoppinmgList = new List<string>(); 

            cHAR is a type of data type that holds a single charater e.g A, B, C,D,E and so on.

            A method is a block of code which we can acall to perform a specific task.




                        Random dice = new Random();
                        int roll1 = dice.Next();
                        int roll2 = dice.Next(101);
                        int roll3 = dice.Next(60, 70);


                        Console.WriteLine($"First Roll: {roll1}");
                        Console.WriteLine($"Second Roll: {roll2}");
                        Console.WriteLine($"Third Roll: {roll3}");

                        string[] movies = {"game of throne", "Seeker", "chuki" };

                        for (int i = 0; i < movies.Length; i++)
                        {
                            int rank = i + 1;
                            Console.WriteLine($"{rank}. {movies[i]}");
                          //  Console.WriteLine(rank);
                        }

                        List<string> shoppingList = new List<string>();

                        shoppingList.Add("Dreams");
                        shoppingList.Add("Miracle");
                        shoppingList.Add("Rainbows");
                        shoppingList.Add("The last thing");

                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine(shoppingList[i]);
                        }

            Console.WriteLine(Math.Max()):
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Squrt(9));
            Console.WriteLine(Round(4.6));

            when working with method nthey are two thimngs we need to do. We define a method then we call it.

            defining a method, we give it a name and desides what we want it to do.

            
             //How to grenertate a gandom number 
            Random randRam = new Random();
            int number = randRam.Next(2,7);
            Console.WriteLine(number);
            ARRAYS 
            int[] luckyNumbers = { 3, 5, 2, 21, 29, 9 };

            //luckyNumbers[0] = 200;
            Console.WriteLine(luckyNumbers[2]);

            string[] friends = new string[4];
            friends[0] = "Zubby";
            friends[1] = "Lanky";
            friends[2] = "Nworah";
             */


            //Without it, the sysytem will auto complete
            //creatinmg a method should be done outside of main. 

            PrintNumber();



            //Method are use to perform a particulare task. and then we can call that function to perform task at a different location, also it can also give us back 

            //Any method written down in main method is waht the codes executes

            //Calling the method
            //Method can also return information back to the caller.
            SayHi("Chibike", 25);
            SayHi("Lanky", 35);
            SayHi("Zubby", 177);
            SayHi("Sly", 4676);


            Console.WriteLine(CubeNum(5));
            //OR
            int CubedNumber = CubeNum(5);
            Console.WriteLine(CubedNumber);



            //IF STATEMENT

            bool isMALE = true;
            bool isTall = true;

            if (isMALE && isTall)
            {
                Console.WriteLine("You are tall and a male");
            }
            else if (isMALE && !isTall)
            {
                Console.WriteLine("You are male but not tall");
            }
            else if (!isMALE && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not tall, and not a male");
            }



            int max = GetMax(102, 95, 60);
            Console.WriteLine(max);


            //If statement
            /*  double num1, num2;
              string op;

              Console.WriteLine("Enter a number ");
             // num1 = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter an operator");
              op = Console.ReadLine();

              Console.WriteLine("Enter a number ");
              num2 = Convert.ToDouble(Console.ReadLine()); 



              if (op == "+")
              {
                  Console.WriteLine(num1 + num2);
              }
              else if (op == "-")
              {
                  Console.WriteLine(num1 - num2);
              }
              else if (op == "*")
              {
                  Console.WriteLine("num1*num2");
              }
              else if (op == "/")
              {
                  Console.WriteLine("num1/num2");
              }
              else
              {
                  Console.WriteLine("Invaild number ");
              }

              */

            //LOOPS
            int index;
            index = 6;
            //will have to specifiy a condition in the while loop, if the condition is met, then I wil have to run what is the curly bracket.
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;

            }

            //infite loop is a comdition where the condition is never false, so the loop keeps looping.

            //DO WHIULE LOOPS

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            int i;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }


            int[] luckNumbers = { 2, 90, 30, 92, 29 };

            for (i = 0; i < luckNumbers.Length; i++)
            {
                Console.WriteLine(luckNumbers[i]);
            }



            //A method can return a value others don't return a value, the

            Random ranRand = new Random();
            int roll = ranRand.Next();


            Random dice = new Random();
            roll = dice.Next(1, 7);

            /*

            The information iused by a method is called pararmeter.Amethod can use one, two or more pararmeter to accomplish it task.
            parameter are variables that's being used inside the method. An argumnet is the value that's passed when the method is called.
            Input pararemter use the parametee passed into it to carry out directly like Random.Next(3,8)
            and uses it indirctly like Console.WriteLine("Print this out on the console");
            Type checking is one way the C# and .Net use to prevent end user from experincing errors at runtime
            //Console.Clear() is use to clear information shared on the Console.

            Overload Methods
            This provides different way to call a method or provide different types of data.


            What are method are used so we can reuse codes. that is write it once and use it mutiple times.

            C# has some method like Math.Max() but sometimes we need define our own method 


             static void MyMethod()
        {
            code you want to be excuted.
        }
            
        MyMethod is my method name.
            static means the method belong to the program class and not an object of the program class.
            void means the method doesn't return a value


            We only use the return key only when we have a single data type 

            Method OverLoad. When a method have the same name but diffrent parameter that means the method is overloaded.
            over loading a method means instead of having two different method that does the same thing, we just over load  single method and does the task at a go.

            const double pi = 3.14;


            Char store single chracter. like A, B, a.

            you can also decalre a variable with assigning the value.

    identifer are variables names, we are advised to use name thatbcan be used to identify whatb the vairable stores. 


            vairables determines the size of data type an element can store.
            double store 15 digits and ends with a D
            float store 6/7 digit and end swith an F
            decimals store between 28-29
            d for d

            bool isCSharpFun = true;

            casting involes converting one data type to another data type 



            //implict mewans putting a small data type into a bigger data type 
            int myNum = 10;
            double myDouble = myNum;
            Console.WriteLine(myDouble);


            //explict mean converting a larger data type to a smaller data type.
            
            
            double myDoubles = 34.29D;
            int myInt = (int)myDoubles;

            Console.WriteLine(myDoubles);
            Console.WriteLine(myInt);

            Two numbers are added, letters are concatinated.
            


            Array are used to store mutilple value of the same data types in a single variable
            In an array you have to signifiy both the data type and size of the array.

            string[] Fradulent = new string[5];
            Note: there is a data type called classes.

            //This is declearing an array of string but the array is empty untill is is decleared 
            string[] fraudlentOrderIDs = new string[3];

            fraudlentOrderIDs[0] = "arejdh";
            fraudlentOrderIDs[1] = "cghsj";
            fraudlentOrderIDs[2] = "hyde";
            fraudlentOrderIDs[3] = "hklfdcf";
        //each array is accessed through the index and the 

            string[] fraudlentOrderIDs = new string[3];

            fraudlentOrderIDs[0] = "arejdh";
            fraudlentOrderIDs[1] = "cghsj";
            fraudlentOrderIDs[2] = "hyde";

            fraudlentOrderIDs[1] = "boy";

            Console.WriteLine($"Third: {fraudlentOrderIDs[1]}");


            //Initializing an array


            string[] fradulentOrderIDs = {"arejd", "cghs", "hyde" };

            Console.WriteLine($"{fradulentOrderIDs[1]}");


            //length property of an array

            Console.WriteLine($"{fradulentOrderIDs.Length}");


            string[] names = {"Chibike", "Chinedu", "Nzube", "Nworah" };

            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }

            //for each loop isused to iterate through an element of array
            int[] inventories = { 100, 2354, 36767, 55 };
              
            int sum = 0;
            int binNumber = 0;
            foreach (int inventory in inventories)
            {

                sum += inventory;
                binNumber++;
            }
            Console.WriteLine($"{sum}");
            Console.WriteLine($"{binNumber}");//if you put it outside it shows the finial result of the addition, if you put it inside it shows the continius gradual addition of each iteration 


            int[] fradulentID = new int[2];

            fradulentID[0] = 8;
            fradulentID[1] = 9;

            Console.WriteLine($"{fradulentID[1]}");

            string[] IDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            Console.WriteLine($"{IDs.Length}");


            foreach (string ID in IDs)
            {
                if (ID.Contains("B"))
                {
                Console.WriteLine($"{ID}");
                }
            }


            COMMENT ARE USED TO STATE THE PURPOSE OF A SECTION OF A PARTICULAR CODE.
            foreach (){} this is used to iterate through each element in a array
            for(){} this is used to loop through an iteration
            //White space 

            //Reverse a string and count the number of times a particula codes appears and print the result to the console .



            //Declaring of variable
            string newMessage;
            string originalMessage = "The quick brown fox jumps over the lazy dog";
            char[] charArr = originalMessage.ToCharArray();

            Array.Reverse(charArr);

            int number = 0;

            foreach (char item in originalMessage)
            {
                if (item == 'o')
                {
                    number++;
                }
            }

            newMessage = new String(charArr);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {number} times.");


            int[] sofpia = new int[7] {};

            the first int[] is used to tell the sysytem you are creating an an array of int,
            int[7] is used to tell the sysytem that array contaons 7 element.
            new is used to tell the sysem that yo ar creating a new instance of array


            //Calculating the indiviual score of student that 
            //Declaring variables.
            double sum, studentASum,  studenrBSum, studnetCSum, studentDSum;
            int studentAScore, studentBScore, studentCScore, studentDScore;
            double studentAAverage, studentBAverage, studentCAverge, studentDAverage;
            const int numberOfCourses = 5;

            int[] studentA = { 36, 3, 100, 13, 92 };
            int[] studentB = { 35, 190, 77, 29, 16 };
            int[] studentC = { 36, 144, 19, 29, 88 };
            int[] studentD = { 42, 74, 45, 100, 63 };

             studentASum = 0;


            foreach (int score in studentA)
            {
                studentASum += score;
            }
            studentAAverage = (double)studentASum / (int)numberOfCourses;



            
            //Will be using the value of score to access the value of each element in the array.
            Console.WriteLine($"Student \t\tGrade\n");
            Console.WriteLine($"Student A:\t\t {studentAAverage} \tA-");











































































































































































































































































            */




























            Console.ReadKey();
        }

        //Creating a method
        static void PrintNumber()
        {
            Random numGren = new Random();
            int number = numGren.Next(0, 20);
            Console.WriteLine(number);
        }

        //Return types: void, int and other. void means the method isn't gonna return any information
        //A parameter are is passed through a method.
        //create my own methods 
        static void SayHi(string name, int age) //this called passing value to the method, 
        {
            Console.WriteLine($"Hello {name} you are {age}");

            //How do we return t

        }

        //Method that cubes a number. 
        static int CubeNum(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 < num2 && num1 < num3)
            {
                result = num1;
            }
            else if (num2 < num3 && num2 < num1)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }



    }
}
