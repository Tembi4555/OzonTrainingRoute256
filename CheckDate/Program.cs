string countTestString = Console.ReadLine();
int countTest = StringToIntMoreThanZero(countTestString);
if (countTest <= 0)
{
    Console.WriteLine("NO");
    Environment.Exit(0);
}

string result = "";
for (int i = 0; i < countTest; i++)
{
    string readData = Console.ReadLine();
    
    result += StringToArrStrBySpaceWithCheck(readData) + "\n";
}


Console.WriteLine(result);

static int StringToIntMoreThanZero(string str)
{
    int result = -1;
    if (!string.IsNullOrEmpty(str))
    {
        int.TryParse(str, out result);
    }
    return result;
}

static string StringToArrStrBySpaceWithCheck(string str)
{
    if (string.IsNullOrEmpty(str))
        return "NO";

    string[] arrBySpace = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (arrBySpace.Length < 3)
        return "NO";
    string reversStr = $"{arrBySpace[2]}-{arrBySpace[1]}-{arrBySpace[0]}";
    DateTime dateTime = DateTime.Now;
    bool isDate = DateTime.TryParse(reversStr, out dateTime);

    if (isDate)
        return "YES";
    else
        return "NO";

}
