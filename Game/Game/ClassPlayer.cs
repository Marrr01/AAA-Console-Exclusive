using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

internal class ClassPlayer : ClassGameObject
{
    private string MovementVector = "Stay still";
    private int RateOfFire = new(); // Скорость стрельбы
    private int TickCounter = new();

    public ClassPlayer(ref Dictionary<int, string> Tags, string[,,] FieldOfAction)
    {
        Skin = new string[,,] { { { "|", "z"}, { "(", "z"} },   // Добавление элементов массива вниз - ось Х, вправо - ось У
                                { { "m", "z"}, { "o", "z"} },
                                { { "|", "z"}, { ")", "z"} } };

        //  |m|
        //  (o)

        ThisObjectTag = "Player";

        AddTag(ref Tags);

        SetTag();

        HealthPoints = 3;

        PosX = (FieldOfAction.GetLength(0) - Skin.GetLength(0)) / 2; // центр по горизонтали

        PosY = FieldOfAction.GetLength(1) - Skin.GetLength(1); // нижняя часть поля
    }
    public void Movement(string[,,] FieldOfAction)
    {
        if (!Removed)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey Key = Console.ReadKey(true).Key;
                switch (Key)
                {
                    case ConsoleKey.LeftArrow:
                        MovementVector = "Left";
                        break;
                    case ConsoleKey.RightArrow:
                        MovementVector = "Right";
                        break;
                    case ConsoleKey.UpArrow:
                        MovementVector = "Forward";
                        break;
                    case ConsoleKey.DownArrow:
                        MovementVector = "Backward";
                        break;
                    case ConsoleKey.Spacebar:
                        MovementVector = "Stay still";
                        break;
                }
            }
            switch (MovementVector)
            {
                case "Left":
                    if (PosX != 0)
                    { PosX--; break; }
                    else
                    { MovementVector = "Stay still"; break; }

                case "Right":
                    if (PosX != FieldOfAction.GetLength(0) - Skin.GetLength(0))
                    { PosX++; break; }
                    else
                    { MovementVector = "Stay still"; break; }

                case "Forward":
                    if (PosY != 0)
                    { PosY--; break; }
                    else
                    { MovementVector = "Stay still"; break; }

                case "Backward":
                    if (PosY != FieldOfAction.GetLength(1) - Skin.GetLength(1))
                    { PosY++; break; }
                    else
                    { MovementVector = "Stay still"; break; }

                case "Stay still":
                    break;
            }
        }
    }

    public void Shooting(ref Dictionary<int, string> Tags, ref List<ClassPlayerProjectile> PlayerProjectileList, ref List<ClassPlayerRocket> PlayerRocketList)
    {
        if (!Removed)
        {
            if (HealthPoints <= 3)
            {
                RateOfFire = 2;

                if (TickCounter >= RateOfFire)
                {
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX + 1, PosY));
                    TickCounter = 0;
                }

                if (TickCounter < RateOfFire)
                {
                    TickCounter++;
                }
            }

            if ((HealthPoints > 3) & (HealthPoints <= 6))
            {
                RateOfFire = 3;

                if (TickCounter >= RateOfFire)
                {
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX, PosY));
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX + 2, PosY));
                    TickCounter = 0;
                }

                if (TickCounter < RateOfFire)
                {
                    TickCounter++;
                }
            }

            if ((HealthPoints > 6) & (HealthPoints <= 9))
            {
                RateOfFire = 4;

                if (TickCounter >= RateOfFire)
                {
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX, PosY));
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX + 1, PosY));
                    PlayerProjectileList.Add(new ClassPlayerProjectile(ref Tags, PosX + 2, PosY));
                    TickCounter = 0;
                }

                if (TickCounter < RateOfFire)
                {
                    TickCounter++;
                }
            }

            if (HealthPoints >= 10)
            {
                RateOfFire = 5;

                if (TickCounter == RateOfFire)
                {
                    PlayerRocketList.Add(new ClassPlayerRocket(ref Tags, PosX + 1, PosY));
                    TickCounter = 0;
                }

                if (TickCounter < RateOfFire)
                {
                    TickCounter++;
                }
            }
        }
    }
}