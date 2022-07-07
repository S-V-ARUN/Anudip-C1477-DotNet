using System;

using System.Timers;
using Timer = System.Timers.Timer;
namespace McqTest
{
    //Console Application For Mcq Test
    class Test
    {
        
        //Declaring Recquired Variables

        int key;
        string[,] questions1 = new string[10, 5];
        string[,] questions2 = new string[10, 5];
        string[,] questions3 = new string[10, 5];
        string[,] questions4 = new string[10, 5];
        string[,] questions5 = new string[10, 5];
        string[,] questions6 = new string[10, 5];
        string[,] questions7 = new string[10, 5];
        string[,] questions8 = new string[10, 5];
        string[,] questions9 = new string[10, 5];
        string[,] questions10 = new string[10, 5];
        string[,] questions11 = new string[10, 5];
        string[,] questions12 = new string[10, 5];
        string[,] questions13 = new string[10, 5];
        string[,] questions14 = new string[10, 5];
        string[,] questions15 = new string[10, 5];
       
        string[] answers = new string[10];
        int mark = 0;

        void InitQuestions()
        {
            //Initilizating De
            questions1[0, 0] = " Constructors are used to ";
            questions1[0, 1] = "a.  Initialize the objects ";
            questions1[0, 2] = "b. Construct the data numbers";
            questions1[0, 3] = "c. Initialize the objects and Construct the data numbers  ";
            questions1[0, 4] = "d. None of the mentioned";
            questions1[1, 0] = " Which of the following statements is correct about constructor ";
            questions1[1, 1] = "a. Constructor cannot be declared as private";
            questions1[1, 2] = "b. Constructor cannot be overloaded";
            questions1[1, 3] = "c. Constructor can be a static constructor";
            questions1[1, 4] = "d. None of the mentioned";
            questions1[2, 0] = " What is the return type of constructors?";
            questions1[2, 1] = "a. int";
            questions1[2, 2] = "b. float";
            questions1[2, 3] = "c. void";
            questions1[2, 4] = "d. None of the mentioned";
            questions1[3, 0] = " Which method has the same name as that of its class";
            questions1[3, 1] = "a. Class";
            questions1[3, 2] = "b. Constructor";
            questions1[3, 3] = "c.  Delete";
            questions1[3, 4] = "d. None of the mentioned";
            questions1[4, 0] = " Correct statement about constructors is ?";
            questions1[4, 1] = "a. Constructors can be overloaded";
            questions1[4, 2] = "b. Constructors does not have return type";
            questions1[4, 3] = "c. Constructors have same name as name of the class ";
            questions1[4, 4] = "d. All of the mentioned";
            questions1[5, 0] = " Constructor is a  ";
            questions1[5, 1] = "a. Method";
            questions1[5, 2] = "b. Class";
            questions1[5, 3] = "c. Variable";
            questions1[5, 4] = "d. Keyword";
            questions1[6, 0] = " Which is not the type of constructor ?";
            questions1[6, 1] = "a. Copy constructor";
            questions1[6, 2] = "b. Body constructor ";
            questions1[6, 3] = "c. Parameterized constructor ";
            questions1[6, 4] = "d. Default constructor ";
            questions1[7, 0] = " Which constructor as no argument constructor";
            questions1[7, 1] = "a. Parameterized constructor ";
            questions1[7, 2] = "b. Body constructor ";
            questions1[7, 3] = "c. Default constructor ";
            questions1[7, 4] = "d. Copy constructor ";
            questions1[8, 0] = "Which of the following keywords is used to refer base class constructor to subclass constructor ?";
            questions1[8, 1] = "a. this";
            questions1[8, 2] = "b. extend";
            questions1[8, 3] = "c. base";
            questions1[8, 4] = "d. static";
            questions1[9, 0] = " Number of constructors a class can define is ?";
            questions1[9, 1] = "a. 1";
            questions1[9, 2] = "b. 2 ";
            questions1[9, 3] = "c. Any number ";
            questions1[9, 4] = "d. None of the mentioned";
            //----------------------------chapter 1----------------------------------
            questions2[0, 0] = " Which of the following are reuse mechanisms ? ";
            questions2[0, 1] = "a. Encapsulation";
            questions2[0, 2] = "b. Inheritance";
            questions2[0, 3] = "c. Polymorphism";
            questions2[0, 4] = "d. Abstraction";
            questions2[1, 0] = " What are the type of inheritance ?";
            questions2[1, 1] = "a. 2";
            questions2[1, 2] = "b. 4";
            questions2[1, 3] = "c. 6";
            questions2[1, 4] = "d. 5";
            questions2[2, 0] = " Which of the following members of the class are accessible to derived class members ?";
            questions2[2, 1] = "a. static ";
            questions2[2, 2] = "b. public";
            questions2[2, 3] = "c. private";
            questions2[2, 4] = "d. protected";
            questions2[3, 0] = " Which form of inheritance is not supported directly ? ";
            questions2[3, 1] = "a. Multiple inheritance";
            questions2[3, 2] = "b. Single inheritance ";
            questions2[3, 3] = "c.  Multi-level inheritance ";
            questions2[3, 4] = "d. Hierarchical inheritance ";
            questions2[4, 0] = " How can you prevent inheritance from a class ?";
            questions2[4, 1] = "a. Declare the class as overloads";
            questions2[4, 2] = "b. Declare the class as override ";
            questions2[4, 3] = "c. Declare the class as  constructor";
            questions2[4, 4] = "d. Declare the class as  sealed";
            questions2[5, 0] = " The class that inherits the other class is known   ";
            questions2[5, 1] = "a.  Super class";
            questions2[5, 2] = "b. Sub class";
            questions2[5, 3] = "c.  Abstract class";
            questions2[5, 4] = "d.  None";
            questions2[6, 0] = " It is a mix of two or more types of inheritance";
            questions2[6, 1] = "a. Single inheritance ";
            questions2[6, 2] = "b. Multiple inheritance";
            questions2[6, 3] = "c. Hybrid inheritance";
            questions2[6, 4] = "d. Multiple inheritance";
            questions2[7, 0] = " We can achieve hybrid inheritance only through  ";
            questions2[7, 1] = "a.  Inheritance";
            questions2[7, 2] = "b. Interface";
            questions2[7, 3] = "c.  Abstract";
            questions2[7, 4] = "d. None";
            questions2[8, 0] = " Why do we need inheritance ?";
            questions2[8, 1] = "a.  Reuse";
            questions2[8, 2] = "b.  Extend";
            questions2[8, 3] = "c.  Modify behavior";
            questions2[8, 4] = "d. All of the above";
            questions2[9, 0] = "  The member can be accessed only by code in the same class is called  ";
            questions2[9, 1] = "a.  Public";
            questions2[9, 2] = "b.  Private";
            questions2[9, 3] = "c.  Protected";
            questions2[9, 4] = "d. None of the mentioned";
            //----------------------------chapter 2----------------------------------
            questions3[0, 0] = " Which keyword is used to declare in interface ? ";
            questions3[0, 1] = "a. Interface";
            questions3[0, 2] = "b. interface";
            questions3[0, 3] = "c. Implement";
            questions3[0, 4] = "d. implement";
            questions3[1, 0] = " The default interfaces methods are  ";
            questions3[1, 1] = "a. Virtual";
            questions3[1, 2] = "b. Private";
            questions3[1, 3] = "c. Public";
            questions3[1, 4] = "d. Sealed";
            questions3[2, 0] = " Which of the following cannot be used to declare an interface ? ";
            questions3[2, 1] = "a. Methods";
            questions3[2, 2] = "b. Properties";
            questions3[2, 3] = "c. Events";
            questions3[2, 4] = "d. Structures";
            questions3[3, 0] = "  Which of the access specifier is used in interface ? ";
            questions3[3, 1] = "a. Public";
            questions3[3, 2] = "b. Private";
            questions3[3, 3] = "c.  Protected";
            questions3[3, 4] = "d. All of the above";
            questions3[4, 0] = " By default all the members of interface are  ";
            questions3[4, 1] = "a. Public";
            questions3[4, 2] = "b. Abstract";
            questions3[4, 3] = "c. Both";
            questions3[4, 4] = "d. None";
            questions3[5, 0] = " Multiple inheritance is possible with the help of   ";
            questions3[5, 1] = "a.  Inheritance";
            questions3[5, 2] = "b.  Interfaces";
            questions3[5, 3] = "c. Abstract";
            questions3[5, 4] = "d. None of the mentioned";
            questions3[6, 0] = " Which is a specification for  a set of class members, not an implementation ?";
            questions3[6, 1] = "a. Inheritance ";
            questions3[6, 2] = "b. Interface";
            questions3[6, 3] = "c. Abstract";
            questions3[6, 4] = "d. None";
            questions3[7, 0] = " Interfaces cannot be used to create ? ";
            questions3[7, 1] = "a. Class";
            questions3[7, 2] = "b. Objects";
            questions3[7, 3] = "c. Abstract class";
            questions3[7, 4] = "d. Encapsulation";
            questions3[8, 0] = " Whenever you inherit both class and interface, you put          first and then put interface names  ?";
            questions3[8, 1] = "a. Sub class ";
            questions3[8, 2] = "b. Super class";
            questions3[8, 3] = "c. Class name";
            questions3[8, 4] = "d. Abstract class";
            questions3[9, 0] = " All the methods inside the interface must be implemented inside the    ";
            questions3[9, 1] = "a. Super class";
            questions3[9, 2] = "b. Derived class";
            questions3[9, 3] = "c. Abstract class";
            questions3[9, 4] = "d.  None";
            //-----------------------------chapter 3----------------------------------
            questions4[0, 0] = " Which of the following modifiers is used when an abstract method is redefined by a derived class ? ";
            questions4[0, 1] = "a.  Overloads";
            questions4[0, 2] = "b.  Override";
            questions4[0, 3] = "c.  Base";
            questions4[0, 4] = "d.  Virtual";
            questions4[1, 0] = " The modifier used to define a class which does not have objects of its own but acts as a base class for its subclass is ?";
            questions4[1, 1] = "a.  Sealed";
            questions4[1, 2] = "b.  Static";
            questions4[1, 3] = "c. New";
            questions4[1, 4] = "d. Abstract";
            questions4[2, 0] = " Choose the correct statements among the following ";
            questions4[2, 1] = "a. An abstract method does not have implementation";
            questions4[2, 2] = "b. An abstract method can take either static or virtual modifier";
            questions4[2, 3] = "c. An abstract method can be declared only in abstract class";
            questions4[2, 4] = "d. All of the mentioned";
            questions4[3, 0] = " If a class inheriting an abstract class does not define all of its functions then it is known as ? ";
            questions4[3, 1] = "a. Abstract ";
            questions4[3, 2] = "b. Simple class";
            questions4[3, 3] = "c.  Static class";
            questions4[3, 4] = "d. None of the mentioned";
            questions4[4, 0] = " Abstract class contains  ";
            questions4[4, 1] = "a. Abstract methods";
            questions4[4, 2] = "b.  Non Abstract methods";
            questions4[4, 3] = "c.  Both";
            questions4[4, 4] = "d.  None";
            questions4[5, 0] = " A method that does not have the body is called   ";
            questions4[5, 1] = "a.  Abstract class ";
            questions4[5, 2] = "b. Abstract method";
            questions4[5, 3] = "c. Static method";
            questions4[5, 4] = "d. None";
            questions4[6, 0] = " Abstract modifier indicates the ";
            questions4[6, 1] = "a.  Complete implementation ";
            questions4[6, 2] = "b. Incomplete implementation";
            questions4[6, 3] = "c.  Both";
            questions4[6, 4] = "d.  None";
            questions4[7, 0] = " Abstract modifier can be used with  ";
            questions4[7, 1] = "a. Indexers";
            questions4[7, 2] = "b.  Events";
            questions4[7, 3] = "c.  Properties";
            questions4[7, 4] = "d.  All of the mentioned";
            questions4[8, 0] = " After overriding the abstract method is in the ";
            questions4[8, 1] = "a. Abstract class";
            questions4[8, 2] = "b. Non-Abstract class";
            questions4[8, 3] = "c. Abstract method";
            questions4[8, 4] = "d. None of the mentioned";
            questions4[9, 0] = " Abstract class contains   ";
            questions4[9, 1] = "a. Constructors";
            questions4[9, 2] = "b. Destructors";
            questions4[9, 3] = "c. Both";
            questions4[9, 4] = "d. None of the mentioned";
            //----------------------------chapter 4----------------------------------
            questions5[0, 0] = " What are the three types of control flow statements ? ";
            questions5[0, 1] = "a.  Decision making, Looping statements, Branching statements ";
            questions5[0, 2] = "b.  Multiple inheritance, Single inheritance, Multi-level inheritance";
            questions5[0, 3] = "c. Abstraction, Encapsulation, Polymorphism";
            questions5[0, 4] = "d. None of the mentioned";
            questions5[1, 0] = " Which keyword can be used for coming out of recursion ? ";
            questions5[1, 1] = "a. break ";
            questions5[1, 2] = "b. return ";
            questions5[1, 3] = "c.  exit";
            questions5[1, 4] = "d.  Both a and b";
            questions5[2, 0] = " Which keyword is used to come out of a loop only for that iteration ? ";
            questions5[2, 1] = "a. break ";
            questions5[2, 2] = "b. continue";
            questions5[2, 3] = "c. return";
            questions5[2, 4] = "d. None of the mentioned";
            questions5[3, 0] = " goto can be used to jump from main to within a function ? ";
            questions5[3, 1] = "a.  true";
            questions5[3, 2] = "b. false";
            questions5[3, 3] = "c.  depends ";
            questions5[3, 4] = "d.  varies;";
            questions5[4, 0] = " Which loop is first perform the operation and then test the condition ? ";
            questions5[4, 1] = "a. for loop ";
            questions5[4, 2] = "b. while loop";
            questions5[4, 3] = "c. do-while loop";
            questions5[4, 4] = "d. none of the mentioned";
            questions5[5, 0] = " Example of iteration in c  ";
            questions5[5, 1] = "a.  for";
            questions5[5, 2] = "b.  while";
            questions5[5, 3] = "c.  do-while";
            questions5[5, 4] = "d.  All of the mentioned";
            questions5[6, 0] = " What is the output of this code ?int i=0;while(++i){Console.Writeline('H');}";                                      
            questions5[6, 1] = "a. H ";
            questions5[6, 2] = "b.  H is printed infinite times";
            questions5[6, 3] = "c.  compile time error";
            questions5[6, 4] = "d.  varies";
            questions5[7, 0] = " Switch statements accepts ";
            questions5[7, 1] = "a. int";
            questions5[7, 2] = "b. char";
            questions5[7, 3] = "c.  long";
            questions5[7, 4] = "d. All of the mentioned";
            questions5[8, 0] = " The output of the below code is ? int x = 5 ; if(x<1); Console.WriteLine(Hello)";            
            questions5[8, 1] = "a. Nothing ";
            questions5[8, 2] = "b. Run time error ";
            questions5[8, 3] = "c.  Hello";
            questions5[8, 4] = "d.  Varies";
            questions5[9, 0] = " What is the output of this code ?    if(true){Console.Writeline(Hello)}";               
            questions5[9, 1] = "a. Hello is printed infinite times ";
            questions5[9, 2] = "b.  Hello";
            questions5[9, 3] = "c.  Varies";
            questions5[9, 4] = "d. Compile time error ";
            //----------------------------chapter 5----------------------------------

          /*  questions6[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions6[0, 1] = "a. 9 ";
            questions6[0, 2] = "b. 8";
            questions6[0, 3] = "c. 7";
            questions6[0, 4] = "d. 6";
            questions6[1, 0] = "Total no od strength in Dotnet Batch ";
            questions6[1, 1] = "a. 36";
            questions6[1, 2] = "b. 37";
            questions6[1, 3] = "c. 38";
            questions6[1, 4] = "d. 39";
            questions6[2, 0] = "Best Comedian in Tamil Cinima";
            questions6[2, 1] = "a. SivaKarthikeyan";
            questions6[2, 2] = "b. Santhanam";
            questions6[2, 3] = "c. Yogibabu";
            questions6[2, 4] = "d. Soori";
            questions6[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions6[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions6[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions6[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions6[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions6[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions6[4, 1] = "a. 66";
            questions6[4, 2] = "b. 67";
            questions6[4, 3] = "c. 68";
            questions6[4, 4] = "d. 65";
            questions6[5, 0] = "Who is most intelligent Person ? ";
            questions6[5, 1] = "a. arun";
            questions6[5, 2] = "b. Arun";
            questions6[5, 3] = "c. ARUN";
            questions6[5, 4] = "d. ARun";
            questions6[6, 0] = "What color is water";
            questions6[6, 1] = "a. Blue";
            questions6[6, 2] = "b. Green";
            questions6[6, 3] = "c. White";
            questions6[6, 4] = "d. None of above";
            questions6[7, 0] = "Correct syntax initilize of 1d array";
            questions6[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions6[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions6[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions6[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions6[8, 0] = "Whice clash is el classico";
            questions6[8, 1] = "a. CSK vs MI";
            questions6[8, 2] = "b. IND vs PAk";
            questions6[8, 3] = "c. Thalapathy vs Thala";
            questions6[8, 4] = "d. Messi vs Ronaldo";
            questions6[9, 0] = "Who is best Football Player? ";
            questions6[9, 1] = "a. Neymar";
            questions6[9, 2] = "b. Dhoni";
            questions6[9, 3] = "c. Ronaldo";
            questions6[9, 4] = "d. Kolhi";
            //----------------------------chapter 6----------------------------------
            questions7[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions7[0, 1] = "a. 9 ";
            questions7[0, 2] = "b. 8";
            questions7[0, 3] = "c. 7";
            questions7[0, 4] = "d. 6";
            questions7[1, 0] = "Total no od strength in Dotnet Batch ";
            questions7[1, 1] = "a. 36";
            questions7[1, 2] = "b. 37";
            questions7[1, 3] = "c. 38";
            questions7[1, 4] = "d. 39";
            questions7[2, 0] = "Best Comedian in Tamil Cinima";
            questions7[2, 1] = "a. SivaKarthikeyan";
            questions7[2, 2] = "b. Santhanam";
            questions7[2, 3] = "c. Yogibabu";
            questions7[2, 4] = "d. Soori";
            questions7[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions7[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions7[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions7[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions7[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions7[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions7[4, 1] = "a. 66";
            questions7[4, 2] = "b. 67";
            questions7[4, 3] = "c. 68";
            questions7[4, 4] = "d. 65";
            questions7[5, 0] = "Who is most intelligent Person ? ";
            questions7[5, 1] = "a. arun";
            questions7[5, 2] = "b. Arun";
            questions7[5, 3] = "c. ARUN";
            questions7[5, 4] = "d. ARun";
            questions7[6, 0] = "What color is water";
            questions7[6, 1] = "a. Blue";
            questions7[6, 2] = "b. Green";
            questions7[6, 3] = "c. White";
            questions7[6, 4] = "d. None of above";
            questions7[7, 0] = "Correct syntax initilize of 1d array";
            questions7[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions7[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions7[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions7[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions7[8, 0] = "Whice clash is el classico";
            questions7[8, 1] = "a. CSK vs MI";
            questions7[8, 2] = "b. IND vs PAk";
            questions7[8, 3] = "c. Thalapathy vs Thala";
            questions7[8, 4] = "d. Messi vs Ronaldo";
            questions7[9, 0] = "Who is best Football Player? ";
            questions7[9, 1] = "a. Neymar";
            questions7[9, 2] = "b. Dhoni";
            questions7[9, 3] = "c. Ronaldo";
            questions7[9, 4] = "d. Kolhi";
            //----------------------------chapter 7----------------------------------
            questions8[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions8[0, 1] = "a. 9 ";
            questions8[0, 2] = "b. 8";
            questions8[0, 3] = "c. 7";
            questions8[0, 4] = "d. 6";
            questions8[1, 0] = "Total no od strength in Dotnet Batch ";
            questions8[1, 1] = "a. 36";
            questions8[1, 2] = "b. 37";
            questions8[1, 3] = "c. 38";
            questions8[1, 4] = "d. 39";
            questions8[2, 0] = "Best Comedian in Tamil Cinima";
            questions8[2, 1] = "a. SivaKarthikeyan";
            questions8[2, 2] = "b. Santhanam";
            questions8[2, 3] = "c. Yogibabu";
            questions8[2, 4] = "d. Soori";
            questions8[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions8[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions8[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions8[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions8[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions8[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions8[4, 1] = "a. 66";
            questions8[4, 2] = "b. 67";
            questions8[4, 3] = "c. 68";
            questions8[4, 4] = "d. 65";
            questions8[5, 0] = "Who is most intelligent Person ? ";
            questions8[5, 1] = "a. arun";
            questions8[5, 2] = "b. Arun";
            questions8[5, 3] = "c. ARUN";
            questions8[5, 4] = "d. ARun";
            questions8[6, 0] = "What color is water";
            questions8[6, 1] = "a. Blue";
            questions8[6, 2] = "b. Green";
            questions8[6, 3] = "c. White";
            questions8[6, 4] = "d. None of above";
            questions8[7, 0] = "Correct syntax initilize of 1d array";
            questions8[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions8[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions8[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions8[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions8[8, 0] = "Whice clash is el classico";
            questions8[8, 1] = "a. CSK vs MI";
            questions8[8, 2] = "b. IND vs PAk";
            questions8[8, 3] = "c. Thalapathy vs Thala";
            questions8[8, 4] = "d. Messi vs Ronaldo";
            questions8[9, 0] = "Who is best Football Player? ";
            questions8[9, 1] = "a. Neymar";
            questions8[9, 2] = "b. Dhoni";
            questions8[9, 3] = "c. Ronaldo";
            questions8[9, 4] = "d. Kolhi";
            //----------------------------chapter 8----------------------------------
            questions9[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions9[0, 1] = "a. 9 ";
            questions9[0, 2] = "b. 8";
            questions9[0, 3] = "c. 7";
            questions9[0, 4] = "d. 6";
            questions9[1, 0] = "Total no od strength in Dotnet Batch ";
            questions9[1, 1] = "a. 36";
            questions9[1, 2] = "b. 37";
            questions9[1, 3] = "c. 38";
            questions9[1, 4] = "d. 39";
            questions9[2, 0] = "Best Comedian in Tamil Cinima";
            questions9[2, 1] = "a. SivaKarthikeyan";
            questions9[2, 2] = "b. Santhanam";
            questions9[2, 3] = "c. Yogibabu";
            questions9[2, 4] = "d. Soori";
            questions9[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions9[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions9[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions9[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions9[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions9[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions9[4, 1] = "a. 66";
            questions9[4, 2] = "b. 67";
            questions9[4, 3] = "c. 68";
            questions9[4, 4] = "d. 65";
            questions9[5, 0] = "Who is most intelligent Person ? ";
            questions9[5, 1] = "a. arun";
            questions9[5, 2] = "b. Arun";
            questions9[5, 3] = "c. ARUN";
            questions9[5, 4] = "d. ARun";
            questions9[6, 0] = "What color is water";
            questions9[6, 1] = "a. Blue";
            questions9[6, 2] = "b. Green";
            questions9[6, 3] = "c. White";
            questions9[6, 4] = "d. None of above";
            questions9[7, 0] = "Correct syntax initilize of 1d array";
            questions9[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions9[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions9[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions9[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions9[8, 0] = "Whice clash is el classico";
            questions9[8, 1] = "a. CSK vs MI";
            questions9[8, 2] = "b. IND vs PAk";
            questions9[8, 3] = "c. Thalapathy vs Thala";
            questions9[8, 4] = "d. Messi vs Ronaldo";
            questions9[9, 0] = "Who is best Football Player? ";
            questions9[9, 1] = "a. Neymar";
            questions9[9, 2] = "b. Dhoni";
            questions9[9, 3] = "c. Ronaldo";
            questions9[9, 4] = "d. Kolhi";
            //----------------------------chapter 9----------------------------------
            questions10[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions10[0, 1] = "a. 9 ";
            questions10[0, 2] = "b. 8";
            questions10[0, 3] = "c. 7";
            questions10[0, 4] = "d. 6";
            questions10[1, 0] = "Total no od strength in Dotnet Batch ";
            questions10[1, 1] = "a. 36";
            questions10[1, 2] = "b. 37";
            questions10[1, 3] = "c. 38";
            questions10[1, 4] = "d. 39";
            questions10[2, 0] = "Best Comedian in Tamil Cinima";
            questions10[2, 1] = "a. SivaKarthikeyan";
            questions10[2, 2] = "b. Santhanam";
            questions10[2, 3] = "c. Yogibabu";
            questions10[2, 4] = "d. Soori";
            questions10[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions10[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions10[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions10[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions10[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions10[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions10[4, 1] = "a. 66";
            questions10[4, 2] = "b. 67";
            questions10[4, 3] = "c. 68";
            questions10[4, 4] = "d. 65";
            questions10[5, 0] = "Who is most intelligent Person ? ";
            questions10[5, 1] = "a. arun";
            questions10[5, 2] = "b. Arun";
            questions10[5, 3] = "c. ARUN";
            questions10[5, 4] = "d. ARun";
            questions10[6, 0] = "What color is water";
            questions10[6, 1] = "a. Blue";
            questions10[6, 2] = "b. Green";
            questions10[6, 3] = "c. White";
            questions10[6, 4] = "d. None of above";
            questions10[7, 0] = "Correct syntax initilize of 1d array";
            questions10[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions10[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions10[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions10[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions10[8, 0] = "Whice clash is el classico";
            questions10[8, 1] = "a. CSK vs MI";
            questions10[8, 2] = "b. IND vs PAk";
            questions10[8, 3] = "c. Thalapathy vs Thala";
            questions10[8, 4] = "d. Messi vs Ronaldo";
            questions10[9, 0] = "Who is best Football Player? ";
            questions10[9, 1] = "a. Neymar";
            questions10[9, 2] = "b. Dhoni";
            questions10[9, 3] = "c. Ronaldo";
            questions10[9, 4] = "d. Kolhi";
            //----------------------------chapter 10----------------------------------
            questions11[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions11[0, 1] = "a. 9 ";
            questions11[0, 2] = "b. 8";
            questions11[0, 3] = "c. 7";
            questions11[0, 4] = "d. 6";
            questions11[1, 0] = "Total no od strength in Dotnet Batch ";
            questions11[1, 1] = "a. 36";
            questions11[1, 2] = "b. 37";
            questions11[1, 3] = "c. 38";
            questions11[1, 4] = "d. 39";
            questions11[2, 0] = "Best Comedian in Tamil Cinima";
            questions11[2, 1] = "a. SivaKarthikeyan";
            questions11[2, 2] = "b. Santhanam";
            questions11[2, 3] = "c. Yogibabu";
            questions11[2, 4] = "d. Soori";
            questions11[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions11[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions11[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions11[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions11[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions11[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions11[4, 1] = "a. 66";
            questions11[4, 2] = "b. 67";
            questions11[4, 3] = "c. 68";
            questions11[4, 4] = "d. 65";
            questions11[5, 0] = "Who is most intelligent Person ? ";
            questions11[5, 1] = "a. arun";
            questions11[5, 2] = "b. Arun";
            questions11[5, 3] = "c. ARUN";
            questions11[5, 4] = "d. ARun";
            questions11[6, 0] = "What color is water";
            questions11[6, 1] = "a. Blue";
            questions11[6, 2] = "b. Green";
            questions11[6, 3] = "c. White";
            questions11[6, 4] = "d. None of above";
            questions11[7, 0] = "Correct syntax initilize of 1d array";
            questions11[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions11[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions11[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions11[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions11[8, 0] = "Whice clash is el classico";
            questions11[8, 1] = "a. CSK vs MI";
            questions11[8, 2] = "b. IND vs PAk";
            questions11[8, 3] = "c. Thalapathy vs Thala";
            questions11[8, 4] = "d. Messi vs Ronaldo";
            questions11[9, 0] = "Who is best Football Player? ";
            questions11[9, 1] = "a. Neymar";
            questions11[9, 2] = "b. Dhoni";
            questions11[9, 3] = "c. Ronaldo";
            questions11[9, 4] = "d. Kolhi";
            //----------------------------chapter 11----------------------------------
            questions12[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions12[0, 1] = "a. 9 ";
            questions12[0, 2] = "b. 8";
            questions12[0, 3] = "c. 7";
            questions12[0, 4] = "d. 6";
            questions12[1, 0] = "Total no od strength in Dotnet Batch ";
            questions12[1, 1] = "a. 36";
            questions12[1, 2] = "b. 37";
            questions12[1, 3] = "c. 38";
            questions12[1, 4] = "d. 39";
            questions12[2, 0] = "Best Comedian in Tamil Cinima";
            questions12[2, 1] = "a. SivaKarthikeyan";
            questions12[2, 2] = "b. Santhanam";
            questions12[2, 3] = "c. Yogibabu";
            questions12[2, 4] = "d. Soori";
            questions12[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions12[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions12[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions12[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions12[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions12[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions12[4, 1] = "a. 66";
            questions12[4, 2] = "b. 67";
            questions12[4, 3] = "c. 68";
            questions12[4, 4] = "d. 65";
            questions12[5, 0] = "Who is most intelligent Person ? ";
            questions12[5, 1] = "a. arun";
            questions12[5, 2] = "b. Arun";
            questions12[5, 3] = "c. ARUN";
            questions12[5, 4] = "d. ARun";
            questions12[6, 0] = "What color is water";
            questions12[6, 1] = "a. Blue";
            questions12[6, 2] = "b. Green";
            questions12[6, 3] = "c. White";
            questions12[6, 4] = "d. None of above";
            questions12[7, 0] = "Correct syntax initilize of 1d array";
            questions12[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions12[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions12[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions12[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions12[8, 0] = "Whice clash is el classico";
            questions12[8, 1] = "a. CSK vs MI";
            questions12[8, 2] = "b. IND vs PAk";
            questions12[8, 3] = "c. Thalapathy vs Thala";
            questions12[8, 4] = "d. Messi vs Ronaldo";
            questions12[9, 0] = "Who is best Football Player? ";
            questions12[9, 1] = "a. Neymar";
            questions12[9, 2] = "b. Dhoni";
            questions12[9, 3] = "c. Ronaldo";
            questions12[9, 4] = "d. Kolhi";
            //----------------------------chapter 12----------------------------------
            questions13[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions13[0, 1] = "a. 9 ";
            questions13[0, 2] = "b. 8";
            questions13[0, 3] = "c. 7";
            questions13[0, 4] = "d. 6";
            questions13[1, 0] = "Total no od strength in Dotnet Batch ";
            questions13[1, 1] = "a. 36";
            questions13[1, 2] = "b. 37";
            questions13[1, 3] = "c. 38";
            questions13[1, 4] = "d. 39";
            questions13[2, 0] = "Best Comedian in Tamil Cinima";
            questions13[2, 1] = "a. SivaKarthikeyan";
            questions13[2, 2] = "b. Santhanam";
            questions13[2, 3] = "c. Yogibabu";
            questions13[2, 4] = "d. Soori";
            questions13[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions13[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions13[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions13[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions13[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions13[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions13[4, 1] = "a. 66";
            questions13[4, 2] = "b. 67";
            questions13[4, 3] = "c. 68";
            questions13[4, 4] = "d. 65";
            questions13[5, 0] = "Who is most intelligent Person ? ";
            questions13[5, 1] = "a. arun";
            questions13[5, 2] = "b. Arun";
            questions13[5, 3] = "c. ARUN";
            questions13[5, 4] = "d. ARun";
            questions13[6, 0] = "What color is water";
            questions13[6, 1] = "a. Blue";
            questions13[6, 2] = "b. Green";
            questions13[6, 3] = "c. White";
            questions13[6, 4] = "d. None of above";
            questions13[7, 0] = "Correct syntax initilize of 1d array";
            questions13[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions13[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions13[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions13[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions13[8, 0] = "Whice clash is el classico";
            questions13[8, 1] = "a. CSK vs MI";
            questions13[8, 2] = "b. IND vs PAk";
            questions13[8, 3] = "c. Thalapathy vs Thala";
            questions13[8, 4] = "d. Messi vs Ronaldo";
            questions13[9, 0] = "Who is best Football Player? ";
            questions13[9, 1] = "a. Neymar";
            questions13[9, 2] = "b. Dhoni";
            questions13[9, 3] = "c. Ronaldo";
            questions13[9, 4] = "d. Kolhi";
            //----------------------------chapter 13----------------------------------
            questions14[0, 0] = "How many boys in Anudip Dotnet Batch ? ";
            questions14[0, 1] = "a. 9 ";
            questions14[0, 2] = "b. 8";
            questions14[0, 3] = "c. 7";
            questions14[0, 4] = "d. 6";
            questions14[1, 0] = "Total no od strength in Dotnet Batch ";
            questions14[1, 1] = "a. 36";
            questions14[1, 2] = "b. 37";
            questions14[1, 3] = "c. 38";
            questions14[1, 4] = "d. 39";
            questions14[2, 0] = "Best Comedian in Tamil Cinima";
            questions14[2, 1] = "a. SivaKarthikeyan";
            questions14[2, 2] = "b. Santhanam";
            questions14[2, 3] = "c. Yogibabu";
            questions14[2, 4] = "d. Soori";
            questions14[3, 0] = " Correct Syntax for declaring multi dimentional array  ";
            questions14[3, 1] = "a. datatype [] arrayname = new datatype [a,b]";
            questions14[3, 2] = "b. datatype [,] arrayname = new datatype [a,b]";
            questions14[3, 3] = "c. datatype [,] arrayname = {{1,2,2},{4,5,6}} ";
            questions14[3, 4] = "d. datatype [] arrayname = {{1,2,2},{4,5,6}}";
            questions14[4, 0] = "Which is the Movie no of vijays Upcoming Movie ";
            questions14[4, 1] = "a. 66";
            questions14[4, 2] = "b. 67";
            questions14[4, 3] = "c. 68";
            questions14[4, 4] = "d. 65";
            questions14[5, 0] = "Who is most intelligent Person ? ";
            questions14[5, 1] = "a. arun";
            questions14[5, 2] = "b. Arun";
            questions14[5, 3] = "c. ARUN";
            questions14[5, 4] = "d. ARun";
            questions14[6, 0] = "What color is water";
            questions14[6, 1] = "a. Blue";
            questions14[6, 2] = "b. Green";
            questions14[6, 3] = "c. White";
            questions14[6, 4] = "d. None of above";
            questions14[7, 0] = "Correct syntax initilize of 1d array";
            questions14[7, 1] = "a. datatype [] arrayname = new datatype [a,b];";
            questions14[7, 2] = "b. datatype [,] arrayname = new datatype [a,b];";
            questions14[7, 3] = "c. datatype [] arrayname = {{1,2,2},{4,5,6}};";
            questions14[7, 4] = "d. datatype [] arrayname = new datatype[];";
            questions14[8, 0] = "Whice clash is el classico";
            questions14[8, 1] = "a. CSK vs MI";
            questions14[8, 2] = "b. IND vs PAk";
            questions14[8, 3] = "c. Thalapathy vs Thala";
            questions14[8, 4] = "d. Messi vs Ronaldo";
            questions14[9, 0] = "Who is best Football Player? ";
            questions14[9, 1] = "a. Neymar";
            questions14[9, 2] = "b. Dhoni";
            questions14[9, 3] = "c. Ronaldo";
            questions14[9, 4] = "d. Kolhi";
            //----------------------------chapter 14----------------------------------*/
            questions15[0, 0] = "What is a StringBuilder ? ";
            questions15[0, 1] = "a. datatype ";
            questions15[0, 2] = "b. class";
            questions15[0, 3] = "c. object";
            questions15[0, 4] = "d. variable";
            questions15[1, 0] = "What is string ?";
            questions15[1, 1] = "a. datatype";
            questions15[1, 2] = "b. class";
            questions15[1, 3] = "c. object";
            questions15[1, 4] = "d. variable";
            questions15[2, 0] = "Choose the Statement Which is true";
            questions15[2, 1] = "a. String is not depend upon values";
            questions15[2, 2] = "b. String is mutable";
            questions15[2, 3] = "c. stringBuilder is immutable";
            questions15[2, 4] = "d. String Builder is used when value is keepon changes";
            questions15[3, 0] = " Correct Syntax for declaring StringBuilder  ";
            questions15[3, 1] = "a. StringBuilder name = new StringBuilder()";
            questions15[3, 2] = "b. stringbuilder name = new stringbuilder(value)";
            questions15[3, 3] = "c. StringBuilder name = new StringBuilder(value)";
            questions15[3, 4] = "d. stringbuilder name = new stringbuilder()";
            questions15[4, 0] = " Correct Syntax for initilizing StringBuilder  ";
            questions15[4, 1] = "a. StringBuilder name = new StringBuilder()";
            questions15[4, 2] = "b. stringbuilder name = new stringbuilder(value)";
            questions15[4, 3] = "c. StringBuilder name = new StringBuilder(value)";
            questions15[4, 4] = "d. stringbuilder name = new stringbuilder()";
            questions15[5, 0] = " Equals() return ";
            questions15[5, 1] = "a. integer";
            questions15[5, 2] = "b. boolean";
            questions15[5, 3] = "c. float";
            questions15[5, 4] = "d. string";
            questions15[6, 0] = " CompareTo() return ";
            questions15[6, 1] = "a. integer";
            questions15[6, 2] = "b. boolean";
            questions15[6, 3] = "c. float";
            questions15[6, 4] = "d. string";
            questions15[7, 0] = "Total number of parameters in Trim() method";
            questions15[7, 1] = "a. 1";
            questions15[7, 2] = "b. 2";
            questions15[7, 3] = "c. 3";
            questions15[7, 4] = "d. 4";
            questions15[8, 0] = "To change one character to another characte _______ method is used";
            questions15[8, 1] = "a. Length()";
            questions15[8, 2] = "b. ToString()";
            questions15[8, 3] = "c. Convert()";
            questions15[8, 4] = "d. Replace()";
            questions15[9, 0] = "To add One string to another string _______ method is used ";
            questions15[9, 1] = "a. Concade()";
            questions15[9, 2] = "b. Append()";
            questions15[9, 3] = "c. +";
            questions15[9, 4] = "d. Add()";
            //----------------------------chapter 15----------------------------------

        }

            string[] crtAnswers1 = { "a", "c", "d", "b", "d", "a", "b", "c", "c", "" };
            string[] crtAnswers2 = { "b", "b", "d", "a", "d", "b", "c", "b", "d", "b" };
            string[] crtAnswers3 = { "c", "a", "d", "a", "c", "b", "b", "b", "c", "b" };
            string[] crtAnswers4 = { "b", "d", "d", "a", "c", "b", "b", "d", "b", "c" };
            string[] crtAnswers5 = { "a", "b", "b", "b", "c", "d", "b", "d", "c", "d" };
            string[] crtAnswers6 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers7 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers8 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers9 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers10 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers11 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers12 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers13 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers14 = { "", "", "", "", "", "", "", "", "", "" };
            string[] crtAnswers15 = { "b", "a", "d", "a", "c", "b", "a", "b", "d", "b" };

        
        
        void ShowQuestions()
        {
            Console.WriteLine("Available Topics : ");
            Console.WriteLine("1. Constructor (key = 1)");
            Console.WriteLine("2. Inheritance (key = 2)");
            Console.WriteLine("3. Interface (key = 3)");
            Console.WriteLine("4. Abstract  (key = 4)");
            Console.WriteLine("5. Control Flow Statements (key = 5)");
            /*Console.WriteLine("6. Sealed (key = 6)");
            Console.WriteLine("7. Static (key = 7)");
            Console.WriteLine("8. Method OverLoading (key = 8)");
            Console.WriteLine("9. Method Overriding (key = 9)");
            Console.WriteLine("10. Exception Handling (key = 10)");
            Console.WriteLine("11. Threading (key = 11)");
            Console.WriteLine("12. Array (key = 12)");
            Console.WriteLine("13. Delegate (key = 13)");
            Console.WriteLine("14. Event (key = 14)");*/
            Console.WriteLine("6. String & String Builder (key = 15)");
            Console.WriteLine();
            Console.Write("Enter a key You wanna attend : ");
            try
            {
                int key1 = int.Parse(Console.ReadLine());
                key = key1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Key Value must be in number");
            }
            Console.WriteLine();

            if (key == 1)
            {

               // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions1[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 2)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions2[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 3)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions3[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
           else if (key == 4)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions4[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 5)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions5[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 6)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions6[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 7)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions7[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 8)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions8[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 9)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions9[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 10)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions10[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 11)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions11[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 12)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions12[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 13)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions13[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 14)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions14[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else if (key == 15)
            {

                // Console.WriteLine("Your Questions are : ");
                int q = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Question {0}", q);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(questions15[i, j]);
                    }
                    Console.Write("Enter Option( a,b,c or d ) for question {0} : ", q);
                    try
                    {
                        answers[i] = Console.ReadLine();
                        answers[i] = answers[i].ToLower();
                        q++;
                        Console.WriteLine();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine(" Enter Correct Key");
            }
        }
        void CalulateMark()
        {
            if (key == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers1[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers2[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers3[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 4)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers4[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 5)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers5[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 6)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers6[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 7)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers7[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 8)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers8[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 9)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers9[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers10[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 11)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers11[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 12)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers12[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 13)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers13[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 14)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers14[i])
                    {
                        mark++;
                    }
                }
            }
            else if (key == 15)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == crtAnswers15[i])
                    {
                        mark++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ignore the marks and Grade and Run again");
            }
        }
        void CalculateGrade()
        {
            if (mark >= 9)
            {
                Console.WriteLine("Your Grade is Green");
            }
            else if (mark < 9 && mark > 5)
            {
                Console.WriteLine("Your Grade is Red");
            }
            else
            {
                Console.WriteLine("Your Grade is Amber");
            }
        }
        public void Show()
        {   
            Console.WriteLine("                                                                    Anudip Foundation (Life Transformed)                                                                    ");
            Console.WriteLine("                                                                              C# Mcq Quiz                                                                    ");
            InitQuestions();
            ShowQuestions();
            CalulateMark();
            Console.WriteLine();
            Console.WriteLine("Your Mark is : {0}",mark);
            CalculateGrade();
          

        }
    }
    class MainClass
    {
       /* public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            Console.Write(" \r{0} ", DateTime.Now.ToString("h:mm:ss tt"));
        }*/

        static void Main(string[] args)
        {
            /*Timer newTimer = new Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 1000;
            newTimer.Start();
            while (Console.Read() != 'q')
            {

            }*/
            Test test = new Test();
            test.Show();
        }
    }
}