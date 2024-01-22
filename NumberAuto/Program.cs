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

    List<string> listWrightNumbers = new();

    while(readData.Length != 0)
    {
        if (readData.Length < 4)
            return "-";
        string subStr;
        bool isOk;

        if (readData.Length > 4)
        {
            subStr = readData.Substring(0, 5);
            isOk = CheckString(subStr);
            if (!isOk)
            {
                subStr = readData.Substring(0, 4);
                isOk = CheckString(subStr);
                if (!isOk)
                    return "-";
                else
                {
                    listWrightNumbers.Add(subStr);
                    readData = readData.Remove(0, 4);
                }
            }
            else
            {
                listWrightNumbers.Add(subStr);
                readData = readData.Remove(0, 5);
            }
        }
        else
        {
            subStr = readData.Substring(0, 4);
            isOk = CheckString(subStr);
            if (!isOk)
                return "-";
            else
            {
                listWrightNumbers.Add(subStr);
                readData = readData.Remove(0, 4);
            }
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

bool CheckString(string checkedString)
{
    if(checkedString.Length == 4)
    {
        bool first = Char.IsLetter(checkedString[0]);
        bool second = Char.IsNumber(checkedString[1]);
        bool third = Char.IsLetter(checkedString[2]);
        bool four = Char.IsLetter(checkedString[3]);
        if(first && second && third && four)
            return true;
        else return false;
    }
    else if(checkedString.Length == 5)
    {
        bool first = Char.IsLetter(checkedString[0]);
        bool second = Char.IsNumber(checkedString[1]);
        bool third = Char.IsNumber(checkedString[2]);
        bool four = Char.IsLetter(checkedString[3]);
        bool five = Char.IsLetter(checkedString[4]);
        if (first && second && third && four && five)
            return true;
        else return false;
    }
    else
        return false;
}
