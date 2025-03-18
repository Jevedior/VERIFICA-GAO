using System.Security.Cryptography;
using System.Text.RegularExpressions;

void popolatemperature(int[,] temp, int temperatura, Random rnd)
{

    for (int i = 0; i < temp.GetLength(0); i++)
    {

        for (int j = 0; j < temp.GetLength(1); j++)
        {
            temperatura = rnd.Next(-10, 36);
            if (i == 0)
            {
                temp[i, j] = temperatura;
            }
            else
            {
                temp[i, j] = 0;
            }

            Console.Write("[" + temp[i, j] + "]");
        }
        Console.WriteLine("");
    }

}
void mediaProgressiva(int[,] temp, int temperatura, Random rnd, int somma, int media)
{

    int dividendo = 0;
    int val = 0;
    for (int i = 0; i < temp.GetLength(1); i++)
    {
        dividendo++;
        Console.WriteLine(media);
        for (int j = 0; j < temp.GetLength(0); j++)
        {
            val = temp[j, i];
            somma += val;
            if (j == 1)
            {
                temp[j, i] = media;
            }
            Console.Write("[" + temp[j, i] + "]");
        }
        media = somma / dividendo;

        Console.WriteLine("");

    }
}
void temperaturamassima(int[,] Temp, int temperatura, Random rnd, int max)
{
    for (int i = 0; i < Temp.GetLength(0); i++)
    {
        for (int j = 0; j < Temp.GetLength(1); j++)
        {
            if (Temp[i, j] > max)
            {
                max = Temp[i, j];
            }
        }
    }
    Console.WriteLine("Valore massimo registrato : " + max);
}


Random rnd = new Random();
int temperatura = 0;
int somma = 0;
int media = 0;
int max = -999;

int[,] Temp = new int[2, 12];

popolatemperature(Temp, temperatura, rnd);
Console.WriteLine(" ");
mediaProgressiva(Temp, temperatura, rnd, somma, media);
Console.WriteLine(" ");
temperaturamassima(Temp, temperatura, rnd, max);
