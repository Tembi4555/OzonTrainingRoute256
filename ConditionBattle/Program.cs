string countTestString = Console.ReadLine();
int countTest = StringToIntMoreThanZero(countTestString);
if (countTest <= 0)
{
    Console.WriteLine(-1);
    Environment.Exit(0);
}


List<int> answerList = new List<int>();

for (int i = 0; i < countTest; i++)
{
    
    string countWorkerString = Console.ReadLine();
    int countWorker = StringToIntMoreThanZero(countWorkerString);
    

    if(countWorker <= 0)
    {
        answerList[i] = -1;
    }
    else
    {
        int minTemper = 15;
        int maxTemper = 30;
        for (int j = 0; j < countWorker; j++)
        {
            if (answerList.LastOrDefault() == -1)
            {
                answerList.Add(-1);
                continue;
            }

            string temperStr = Console.ReadLine();
            string[] tempArr = temperStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int temper = StringToIntMoreThanZero(tempArr[1]);

            if (tempArr[0] == ">=")
            {
                minTemper = temper;
            }
            else
            {
                maxTemper = temper;
            }

            if (minTemper > maxTemper)
                answerList.Add(-1);
            else
                answerList.Add(minTemper);

        }
    }
    string result = String.Join('\n', answerList);
    Console.WriteLine(result);
    answerList.Clear();
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