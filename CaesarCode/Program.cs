//string text = "Felipe";
//int index = 2;
//string output = "";



//foreach (char ch in text)
//{
//    output += (char)(ch + index);
//}
//Console.WriteLine(output);

public class Program {

    static void Main(string[] args)
    {
        Console.WriteLine("Type a string to encrypt:");
        string userInput = Console.ReadLine();

        Console.WriteLine("Enter a key for the encryption:");
        int key = Convert.ToInt32(Console.ReadLine());

        string encryptedText = EncryptUserInput(userInput, key);
        Console.WriteLine(encryptedText);
        Console.WriteLine(DecryptUserInput(encryptedText, key));

        //    Console.WriteLine("Encrypted Text:");

        //    string encryptedText = EncryptUserInput(userInput, key);
        //    Console.WriteLine(encryptedText);
        //    Console.WriteLine("\n");

        //    Console.WriteLine("Decrypted Text:");

        //    string decryptedText = DecryptUserInput(encryptedText, key);
        //    Console.WriteLine(decryptedText);

        //    Console.ReadKey();

        //}
        //public static string EncryptUserInput(string userInput, int key)
        //{
        //    string output = string.Empty;

        //    foreach (char ch in userInput)
        //        output += cipher(ch, key);

        //    return output;
        //}

        //public static string DecryptUserInput(string input, int key)
        //{
        //    return EncryptUserInput(input, 26 - key);
        //}

        //public static char cipher(char ch, int key)
        //{
        //    if (!char.IsLetter(ch))
        //    {

        //        return ch;
        //    }

        //    char d = char.IsUpper(ch) ? 'A' : 'a';
        //    return (char)((((ch + key) - d) % 26) + d);


    }

    public static string output = "";
    public static string EncryptUserInput(string userInput, int key) 
    {
        foreach (char letter in userInput)
        {
            if (letter >= 123)
            {
                output += (char)(letter - 26 + key);
            }
            else
            {
                output += (char)(letter + key);
            }
        }

        return output;

    }

    public static string DecryptUserInput(string userInput, int key)
    {
        output = "";

        foreach (char letter in userInput)
        {
            if (letter >= 123)
            {
                output += (char)(letter + 26 - key);
            }
            else
            {
                output += (char)(letter - key);
            }
        }

        return output;

    }
}