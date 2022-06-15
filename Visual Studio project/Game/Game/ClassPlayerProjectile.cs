using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassPlayerProjectile : ClassGameObject // снаряд, которым стреляет игрок
{
    private int MovementSpeed = 0;  // объект будет двигаться раз в N тиков
    private int TickCounter = new();  // счетчик тиков

    public ClassPlayerProjectile(ref Dictionary<int, string> Tags, int X, int Y)
    {
        Skin = new string[,,] { { { "|", "z" } } };

        ThisObjectTag = "PlayerProjectile";

        AddTag(ref Tags);

        SetTag();

        HealthPoints = 1;

        PosX = X;

        PosY = Y;
    }

    public void Movement()
    {
        if (!Removed)
        {
            if (TickCounter == MovementSpeed & PosY != 0)
                { PosY--;}
            
            if (TickCounter == MovementSpeed & PosY == 0)
                { HealthPoints = 0; }

            if (TickCounter == MovementSpeed)
                { TickCounter = 0; }

            if (TickCounter < MovementSpeed)
                { TickCounter++; }
        }
    }
}
