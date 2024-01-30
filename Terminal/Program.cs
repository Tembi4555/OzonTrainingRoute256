int[] coursorPosition = new int[2] { 0, 0 };



int countString = StringToInt(Console.ReadLine());

string result = "";

for (int i = 0; i < countString; i++)
{
    string inputString = Console.ReadLine();

    List<string> terminal = new List<string>();
    terminal.Add(String.Empty);

    foreach (char symb in inputString)
    {
        if(symb == 'L')
        {
            if (coursorPosition[0] > 0)
                coursorPosition[0]--;
           
        }
        
        if(symb == 'R')
        {
            if (coursorPosition[0] <= terminal[coursorPosition[1]].Length)
            {
                coursorPosition[0]++;
            }
        }

        if(symb == 'U')
        {
            if (coursorPosition[1] > 0)
                coursorPosition[1]--;
        }

        if(symb == 'D')
        {
            if (coursorPosition[1] < terminal.Count())
                coursorPosition[1]++;

        }

        if(symb == 'B')
        {
            coursorPosition[0] = 0;
            coursorPosition[1] = 0;
        }

        if(symb == 'E')
        {
            coursorPosition[0] = terminal[coursorPosition[1]].Length;
            coursorPosition[1] = terminal.Count()-1;
        }

        if(symb == 'N')
        {
            coursorPosition[1]++;
            coursorPosition[0] = 0;
            if (coursorPosition[1] < terminal.Count())
                terminal.Insert(coursorPosition[1], String.Empty);
            else
                terminal.Add(String.Empty);
        }

        result += terminal[coursorPosition[1]].Insert(coursorPosition[0], symb.ToString());
        //terminal[coursorPosition[1]].Insert(coursorPosition[0], symb.ToString());
    }

    //result += String.Join('\n', terminal) + "\n" + "-" + "\n";
    result += "\n" + "-" + "\n";
}


static int StringToInt(string str)
{
    int result = -2000;
    if (!string.IsNullOrEmpty(str))
    {
        int.TryParse(str, out result);
    }
    return result;
}