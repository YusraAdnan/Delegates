namespace Delegates_Intro
{
    internal class Program
    {
        //Step 1: Declare the delegate
        public delegate float MathOperation(float a, float b);    

        //Step 2: Create methods that match the delegate signature
        public static float Add(float a, float b) => a + b;
        public static float Multiply(float a , float b) => a * b;

        public static float Divide(float a, float b) => a/b;

        // This method accepts a delegate as a parameter and calls it
        // This shows how we can "plug in" different operations at runtime without using if-else 
        static void Calculate(MathOperation operation, float a, float b)
        {
            Console.WriteLine("Result: " + operation(a, b));
        }

        static void Main(string[] args)
        {
            float userInput1;
            float userInput2;

            //Step 3: Use the delegates
            MathOperation op = Add; //assign the delegate variable to hold the Add method
           
            Console.WriteLine("Enter the first number: ");
            userInput1 =  float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            userInput2 = float.Parse(Console.ReadLine());

            //Test Add using delegate
            Console.WriteLine("Add: " + op(userInput1,userInput2));

            //Swap the delegate variable to point to the Multiply action
            op = Multiply;
            Console.WriteLine("Multiply: " + op(userInput1, userInput2));

            // Pass different operations as parameters into a reusable method using the delegate
            Calculate(Add, userInput1, userInput2); //performs addition
            Calculate(Multiply, userInput1, userInput2); //performs multiplication
            Calculate(Divide, userInput1, userInput2);
        }
    }
}
