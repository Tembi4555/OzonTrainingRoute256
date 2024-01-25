string countTestString = Console.ReadLine();
int countTest = StringToInt(countTestString);
if (countTest <= 0)
{
    Console.WriteLine("0 0");
    Environment.Exit(0);
}

string result = "";

for (int i = 0; i < countTest; i++)
{
    string numberLengthString = Console.ReadLine();
    //result += numberLengthString + "\n";
    string sequenceStr = Console.ReadLine();
    string[] sequenceArr = sequenceStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] sequence = new int[sequenceArr.Length];
    int counter = 0;
    int startKompr = 0;

    List<int> resultKompr = new();
    for(int j = 0; j < sequenceArr.Length; j++)
    {
        sequence[j] = StringToInt(sequenceArr[j]);

        if(j == 0)
            startKompr = sequence[j];
        else
        {
            if (sequence[j-1] - sequence[j] == 1)
            {
                counter--;
            }
            else if(sequence[j - 1] - sequence[j] == -1)
                counter++;
            else
            {
                if(counter != 0)
                {
                    resultKompr.Add(sequence[j - 1]);
                    
                }
                else
                {
                    resultKompr.Add(sequence[j]);
                }
                resultKompr.Add(counter);
                counter = 0;
            }
        }
    }
    result += resultKompr.Count() + "\n" + String.Join(' ', resultKompr);
}

Console.WriteLine(result);


static int StringToInt(string str)
{
    int result = -2000;
    if (!string.IsNullOrEmpty(str))
    {
        int.TryParse(str, out result);
    }
    return result;
}
