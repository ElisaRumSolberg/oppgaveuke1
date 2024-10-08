namespace oppgaveuke1;

class Program
{
    static void Main(string[] args)
    {
        // oppgave 1
        Console.WriteLine("Hello, World!");


        // Variabel av datatypen integer
        int myInteger = 42;
        
        // Variabel av datatypen string
        string myString = "Hei, verden!";
        
        // Variabel av datatypen double
        double myDouble = 3.14;
        
        // Variabel av datatypen char
        char myChar = 'A';

        // Array av datatypen integer og skriv ut verdiene med en for-løkke
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < myIntArray.Length; i++)
        {
            Console.WriteLine(myIntArray[i]);
        }

        // Array av datatypen string og skriv ut verdiene med en foreach-løkke
        string[] myStringArray = { "En", "To", "Tre", "Fire", "Fem" };
        foreach (string str in myStringArray)
        {
            Console.WriteLine(str);
        }

        // List av datatypen string og tildel verdier ved hjelp av Add()
        List<string> myExampleList = new List<string>();
        myExampleList.Add("Min første string");
        myExampleList.Add("Min andre string");
        myExampleList.Add("Min tredje string");

        // Skriv ut verdiene i listen ved hjelp av en foreach-løkke
        foreach (string item in myExampleList)
        {
            Console.WriteLine(item);
        }
    
    }
}

 
