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
    sequence[0] = StringToInt(sequenceArr[0]);
    int counter = 0;
    int startKompr = StringToInt(sequenceArr[0]);

    List<int> resultKompr = new();
    for(int j = 0; j < sequenceArr.Length; j++)
    {
        if (j != 0)
        {


            sequence[j] = StringToInt(sequenceArr[j]);

            if (sequence[j - 1] - sequence[j] == 1 && counter <= 0)
            {
                counter--;
            }
            else if (sequence[j - 1] - sequence[j] == -1 && counter >= 0)
                counter++;
            else
            {
                resultKompr.Add(startKompr);
                resultKompr.Add(counter);
                startKompr = sequence[j];

                counter = 0;
            }
        }

        if(j == sequenceArr.Length - 1)
        {
            resultKompr.Add(startKompr);
            resultKompr.Add(counter);
        }
    }
    result += resultKompr.Count() + "\n" + String.Join(' ', resultKompr) + "\n";
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
