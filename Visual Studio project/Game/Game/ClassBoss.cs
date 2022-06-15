using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassBoss : ClassGameObject
{
    private int MaxHealthPoints = new();
    private int PercentsHealthPoints = new();
    private string Str = string.Empty;

    public ClassBoss(ref Dictionary<int, string> Tags, string[,,] FieldOfAction)
    {
        Skin = new string[FieldOfAction.GetLength(0),2,2];

        Skin[0,0,0] = "(";

        for (int i = 1; i < FieldOfAction.GetLength(0) - 1; i++)
        { Skin[i, 0, 0] = "0"; }

        Skin[FieldOfAction.GetLength(0) - 1, 0, 0] = ")";

        Skin[0, 1, 0] = "|";

        for (int i = 1; i < FieldOfAction.GetLength(0) - 1; i++)
        { Skin[i, 1, 0] = "V"; }

        Skin[FieldOfAction.GetLength(0) - 1, 1, 0] = "|";

        //  (000 ... 000)
        //  |VVV ... VVV|

        ThisObjectTag = "Enemy";

        AddTag(ref Tags);

        SetTag();

        HealthPoints = 500;

        MaxHealthPoints = HealthPoints;

        Points = 10 * HealthPoints;

        PosX = 0; // самая левая точка

        PosY = 0; // верхняя часть поля
    }

    public void Shooting(ref Dictionary<int, string> Tags, ref List<ClassEnemyPlasma> EnemyPlasmaList)
    {
        if (!Removed)
        {
            for (int i = 1; i < Skin.GetLength(0) - 1; i++)
            {
                if (Randomizer.Next(1, 100) <= 2) // шанс на выстрел 2 %
                {
                    EnemyPlasmaList.Add(new ClassEnemyPlasma(ref Tags, i, 1));
                }
            }
        }
    }

    public void WriteHP(string [,,] FieldOfAction, List<ClassBoss> BossList)
    {
        if (BossList.Count != 0)
        {
            Console.Write("|");

            if (HealthPoints / (MaxHealthPoints / 100) >= 0)
            { PercentsHealthPoints = HealthPoints / (MaxHealthPoints / 100); }
            else
            { PercentsHealthPoints = 0; }

            { Str = "WALL OF STEEL: " + PercentsHealthPoints + " %"; } 

            for (int i = 0; i < ((FieldOfAction.GetLength(0) / 2) - (Str.Length / 2)); i++)
            {
                Console.Write(" ");
            }

            Console.Write(Str);

            for (int i = (FieldOfAction.GetLength(0) / 2) - (Str.Length / 2) + Str.Length; i < FieldOfAction.GetLength(0); i++)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            Console.WriteLine();

            Console.Write('+');

            for (int i = 0; i < FieldOfAction.GetLength(0); i++)
            {
                Console.Write('-');
            }

            Console.Write('+');

            Console.WriteLine();

            for (int i = 0; i < FieldOfAction.GetLength(0); i++)
            {
                Console.Write(' ');
            }
        }
    }

    public void ScoreAndVictory(ref int Score, ref bool Victory)
    {
        if ((HealthPoints <= 0) && (!Removed))
        {
            // Увеличение счета

            Score += Points;

            Victory = true;
        }
    }
}

