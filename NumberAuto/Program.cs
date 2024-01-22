string countTestString = Console.ReadLine();
int countTest = StringToIntMoreThanZero(countTestString);
if (countTest <= 0)
{
    Console.WriteLine("-");
    Environment.Exit(0);
}

string result = "";
for (int i = 0; i < countTest; i++)
{
    string readData = Console.ReadLine();

    result += CheckNumberAuto(readData) + "\n";
}

Console.WriteLine(result);

string CheckNumberAuto(string? readData)
{
    if (string.IsNullOrEmpty(readData) || readData.Length < 4)
        return "-";

    int countNumbers = 0;
    int countSymbols = 0;

    int number = -1;
    string oneNumber = "";
    List<string> listWrightNumbers = new();

    foreach(char s in readData)
    {
        double isNumber = Char.GetNumericValue(s);
        if(oneNumber.Length > 3)
        {
            listWrightNumbers.Add(oneNumber);
            oneNumber = String.Empty;
        }

        //if(oneNumber.Length == 3 && )
            
        if (isNumber != -1.0)
        {
            if(!string.IsNullOrEmpty(oneNumber) && oneNumber.Length >= 1 /*&& oneNumber.Length < 3*/)
                oneNumber += isNumber;
            else
                return "-";
        }
        else
        {
            return "-";
        }
    }
    string result = String.Join(" ", listWrightNumbers);
    return result;
}

static int StringToIntMoreThanZero(string str)
{
    int result = -1;
    if (!string.IsNullOrEmpty(str))
    {
        int.TryParse(str, out result);
    }
    return result;
}
