using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassEnemyPlasma : ClassGameObject // снаряд, которым стреляет игрок
{
    private int MovementSpeed = 0;  // объект будет двигаться раз в N тиков
    private int TickCounter = new();  // счетчик тиков

    public ClassEnemyPlasma(ref Dictionary<int, string> Tags, int X, int Y)
    {
        Skin = new string[,,] { { { "*", "z" } } };

        ThisObjectTag = "EnemyPlasma";

        AddTag(ref Tags);

        SetTag();

        HealthPoints = 1;

        PosX = X;

        PosY = Y;
    }

    public void Movement(string[,,] FieldOfAction)
    {
        if (!Removed)
        {
            if (TickCounter == MovementSpeed & PosY != FieldOfAction.GetLength(1) - 1)
            { PosY++; }

            if (TickCounter == MovementSpeed & PosY == FieldOfAction.GetLength(1) - 1)
            { HealthPoints = 0; }

            if (TickCounter == MovementSpeed)
            { TickCounter = 0; }

            if (TickCounter < MovementSpeed)
            { TickCounter++; }
        }
    }
}


