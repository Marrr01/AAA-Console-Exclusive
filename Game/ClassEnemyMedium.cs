using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassEnemyMedium : ClassEnemyUnit
{
    public ClassEnemyMedium(Dictionary<int, string> Tags, char[,,] FieldOfAction)
    {
        Skin = new char[,,] { { { '(', 'z'}, { '|', 'z'} },   // Добавление элементов массива вниз - ось Х, вправо - ось У
                              { { '0', 'z'}, { 'V', 'z'} },
                              { { '-', 'z'}, { '-', 'z'} },
                              { { '0', 'z'}, { 'V', 'z'} },
                              { { ')', 'z'}, { '|', 'z'} } };

        //  (0-0)
        //  |V-V|

        ThisObjectTag = "Enemy";

        AddTag(Tags);

        SetTag();

        HealthPoints = 9;

        Points = 10 * HealthPoints;

        PosX = Randomizer.Next(0, FieldOfAction.GetLength(0) - Skin.GetLength(0)); // центр по горизонтали

        PosY = 0; // верхняя часть поля

        MovementSpeed = 15;

        RateOfFire = 2;

        BuffDropChance = 40;
    }
}

