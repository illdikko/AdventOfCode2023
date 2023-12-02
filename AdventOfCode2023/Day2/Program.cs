using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] texte = File.ReadAllLines("./day2input.txt");

int gameIndex = 0;
int lineIndex = 0;


foreach (string line in texte)
{

    lineIndex++;

    string[] games = line.Split(':');
    string[] sets = games[1].Split(';');

    bool isValid = true;

    foreach (string s in sets)
    {
        string[] subset = s.Split(',');
        foreach (string cubes in subset)
        {
            int numIndex = cubes.IndexOf("red");
            if (numIndex >= 0)
            {
                int redCubes = Int32.Parse(cubes.Substring(0, numIndex));

                if (redCubes > 12)
                {
                    isValid = false; break;
                }
            }

            numIndex = cubes.IndexOf("green");
            if (numIndex >= 0)
            {
                int greenCubes = Int32.Parse(cubes.Substring(0, numIndex));

                if (greenCubes > 13)
                {
                    isValid = false; break;
                }
            }

            numIndex = cubes.IndexOf("blue");
            if (numIndex >= 0)
            {
                int blueCubes = Int32.Parse(cubes.Substring(0, numIndex));

                if (blueCubes > 14)
                {
                    isValid = false; break;
                }
            }
        }
        if (isValid == false)
        {
            break;
        }
    }

    if (isValid == true)
    {
        gameIndex += lineIndex;
    }

}

Console.WriteLine(gameIndex);


int sumPower =0;

foreach (string line in texte)
{

    int green = 0;
    int red = 0;
    int blue = 0;

    string[] games = line.Split(':');
    string[] sets = games[1].Split(';');

    foreach (string s in sets)
    {
        string[] subset = s.Split(',');
        foreach (string cubes in subset)
        {
            int numIndex = cubes.IndexOf("red");

            if (numIndex >= 0)
            {
                int redCubes = Int32.Parse(cubes.Substring(0, numIndex));

                //if (redCubes > red)
                //{
                //    red = redCubes;

                //}

                red=Math.Max(red, redCubes);
            }

            numIndex = cubes.IndexOf("green");
            if (numIndex >= 0)
            {
                int greenCubes = Int32.Parse(cubes.Substring(0, numIndex));

                //if (greenCubes > green)
                //{
                //    green = greenCubes;
                //}

                green=Math.Max(green, greenCubes);
            }

            numIndex = cubes.IndexOf("blue");
            if (numIndex >= 0)
            {
                int blueCubes = Int32.Parse(cubes.Substring(0, numIndex));

                //if (blueCubes > blue)
                //{
                //    blue = blueCubes;
                //}

                blue = Math.Max(blue, blueCubes);
            }
        }

    }

    int setPower = green * red * blue;
    sumPower += setPower;
}

    Console.WriteLine(sumPower);