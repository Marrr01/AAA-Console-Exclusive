using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassHealthBuff : ClassGameObject
{
    private int MovementSpeed = 10;  // объект будет двигаться раз в N тиков
    private int TickCounter = new();  // счетчик тиков
 
    public ClassHealthBuff(ref Dictionary<int, string> Tags, int X, int Y)
    {
        Skin = new string[,,] { { { "+", "z" } } };   // Добавление элементов массива вниз - ось Х, вправо - ось У

        ThisObjectTag = "HealthBuff";

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
            if ((TickCounter == MovementSpeed) && (PosY != FieldOfAction.GetLength(1) - 1))
                { PosY++; TickCounter = 0; }

            if ((TickCounter == MovementSpeed) && (PosY == FieldOfAction.GetLength(1) - 1))
                { HealthPoints = 0; }

            TickCounter++;
        }
    }
}

