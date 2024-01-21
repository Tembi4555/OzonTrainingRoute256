

string countTestString = Console.ReadLine();
int countTest = StringToIntMoreThanZero(countTestString);
if (countTest <= 0)
{
    Console.WriteLine("NO");
    Environment.Exit(0);
}

string result = "";
for(int i = 0; i < countTest; i++)
{
    string readData  = Console.ReadLine();
    int[] dataToIntArr = StringToArrIntBySpace(readData);
    result += CheckForSeaWar(dataToIntArr) + "\n";
}
Console.WriteLine(result);

static string CheckForSeaWar(int[] dataToIntArr)
{
    int oneCount = 0;
    int twoCount = 0;
    int threeCount = 0;
    int fourCount = 0;
    if (dataToIntArr.Length < 10)
        return "NO";
    foreach(int d in dataToIntArr)
    {
        if (d == 1)
            oneCount++;
        else if (d == 2)
            twoCount++;
        else if (d == 3)
            threeCount++;
        else if (d == 4)
            fourCount++;
        else
        {
            return "NO";
        }
            
        if (oneCount > 4 || twoCount > 3 || threeCount > 2 || fourCount > 1)
            return "NO";
    }

    if (oneCount == 4 && twoCount == 3 && threeCount == 2 && fourCount == 1)
        return "YES";
    else
        return "NO";
}

static int StringToIntMoreThanZero (string str)
{
    int result = -1;
    if(!string.IsNullOrEmpty(str))
    {
        int.TryParse(str, out result );
    }
    return result;
}

static int[] StringToArrIntBySpace(string str)
{
    if(string.IsNullOrEmpty(str))
        return new int[0];

    string[] arrBySpace = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arrBySpace.Length];

    for(int i = 0; i < arrBySpace.Length; i++)
    {
        bool isInt = int.TryParse(arrBySpace[i], out result[i]);
        if(!isInt)
            result[i] = 0;
    }

    return result;
}

