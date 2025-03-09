class TranslateReading
{
    public static int Main()
    {
        string readingPath = "reading_type.txt";
        string writingPath = "needed_nums.txt";
        if (File.Exists(readingPath) == false)
        {
            Console.WriteLine("File not found.");
            return 1;
        }

        ReadFile(readingPath, writingPath);
        return 0;
    }

    public static void ReadFile(string readingPath, string writePath)
    {
        try
        {

            using (StreamReader readIn = new StreamReader(readingPath))
            {
                string newReading = readIn.ReadToEnd();
                if (newReading != null)
                {
                    ParseReading(newReading, writePath);
                    Console.WriteLine("Done.");
                }
                else
                {
                    Console.Write("Null file.");
                }
            }
        }
        catch (Exception e)
        {
            Console.Write("Error reading the file. Error is:");
            Console.Write(e.Message);
        }
    }

    public static void ParseReading(string word, string writePath)
    {
        if (word == "basic")
        {
            WriteFile("3", writePath);
        }
        else if (word == "celtic")
        {
            WriteFile("10", writePath);
        }
    }

    public static void WriteFile(string stringNum, string writePath)
    {
        try
        {
            using (StreamWriter writeOut = new StreamWriter(writePath))
            {
                writeOut.Write(stringNum);
            }
        }
        catch (Exception e)
        {
            Console.Write("Error writing to the file. Error is:");
            Console.Write(e.Message);
        }
    }
}