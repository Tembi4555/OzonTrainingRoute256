﻿string countTestString = Console.ReadLine();
int countTest = StringToIntMoreThanZero(countTestString);
if (countTest <= 0)
{
    Console.WriteLine(-1);
    Environment.Exit(0);
}


List<string> answerList = new List<string>();

for (int i = 0; i < countTest; i++)
{
    string countWorkerString = Console.ReadLine();
    int countWorker = StringToIntMoreThanZero(countWorkerString);

    

    if(countWorker <= 0)
    {
        answerList.Add("-1");
    }
    else
    {
        int minTemper = 15;
        int maxTemper = 30;
        for (int j = 0; j < countWorker; j++)
        {
            string temperStr = Console.ReadLine();
            if (answerList.LastOrDefault() == "-1")
            {
                answerList.Add("-1");
                continue;
            }

            string[] tempArr = temperStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int temper = StringToIntMoreThanZero(tempArr[1]);

            if (tempArr[0] == ">=" && temper > minTemper)
            {
                minTemper = temper;
            }
            else if(tempArr[0] == "<=" && temper < maxTemper)
            {
                maxTemper = temper;
            }

            if (minTemper > maxTemper)
                answerList.Add("-1");
            else
                answerList.Add(minTemper.ToString());
        }
    }
    answerList.Add(" ");
}

string result = String.Join('\n', answerList);
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