using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;

char last = '0';
int numint1 = 0;
int numint2 = 0;

string[] texte = File.ReadAllLines("./day1input.txt");

foreach (string line in texte)
{
    char first = 'a';
    foreach (char c in line)
    {
        if (char.IsDigit(c))
        {
            if (first == 'a')
            {
                first = c;
            }
            last = c;
        }
    }

    string numstr = first.ToString() + last.ToString();
    numint1 += Int32.Parse(numstr);
}

Console.WriteLine(numint1);

foreach (string line in texte)
{
    char first = 'a';
    int firstIndex = 0;
    int lastIndex = 0;

    for (int i = 0; i < line.Length; i++)

    {
        char c = line[i];

        if (char.IsDigit(c))
        {
            if (first == 'a')
            {
                first = c;
                firstIndex = i;
            }
            last = c;
            lastIndex = i;
        }
    }
    #region one
    int numIndex = line.IndexOf("one");

    if (numIndex < firstIndex && numIndex> -1)
    {
        firstIndex = numIndex;
        first = '1';
    }

    numIndex = line.LastIndexOf("one");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '1';
    }
    #endregion
    #region two
    numIndex = line.IndexOf("two");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '2';
    }

    numIndex = line.LastIndexOf("two");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '2';
    }

    #endregion two
    #region three
   numIndex = line.IndexOf("three");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '3';
    }

    numIndex = line.LastIndexOf("three");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '3';
    }
    #endregion three
    #region four
    numIndex = line.IndexOf("four");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '4';
    }

    numIndex = line.LastIndexOf("four");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '4';
    }
    #endregion four
    # region five
    numIndex = line.IndexOf("five");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '5';
    }

    numIndex = line.LastIndexOf("five");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '5';
    }
    #endregion five
    # region six
    numIndex = line.IndexOf("six");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '6';
    }

    numIndex = line.LastIndexOf("six");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '6';
    }
    #endregion six
    # region seven
    numIndex = line.IndexOf("seven");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '7';
    }

    numIndex = line.LastIndexOf("seven");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '7';
    }
    #endregion seven
    # region eight
    numIndex = line.IndexOf("eight");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '8';
    }

    numIndex = line.LastIndexOf("eight");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '8';
    }
    #endregion eight
    # region nine
    numIndex = line.IndexOf("nine");

    if (numIndex < firstIndex && numIndex > -1)
    {
        firstIndex = numIndex;
        first = '9';
    }

    numIndex = line.LastIndexOf("nine");

    if (numIndex > lastIndex)
    {
        lastIndex = numIndex;
        last = '9';
    }
    #endregion nine
    /*string firstCurrentValue = first.ToString();*/

    string numstr = first.ToString() + last.ToString();
    numint2 += Int32.Parse(numstr);

    Console.WriteLine(line+" "+numstr);
}

Console.WriteLine(numint2);