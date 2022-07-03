using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassEnemyUnit : ClassGameObject // базовый класс для вражеских кораблей
{
    protected int MovementSpeed    = new();  // объект будет двигаться раз в N тиков
    protected int TickCounterMove  = new();  // счетчик тиков для движения
    protected int TickCounterShoot = new();  // счетчик тиков для выстрела 
    protected int RateOfFire       = new();  // скорость стрельбы (сработает раз в N обнулений счетчика тиков движения)
    protected int BuffDropChance   = new();  // шанс выпадения баффа после смерти

    public void Movement(char[,,] FieldOfAction)
    {
        if (!Removed)
        {
            if ((PosY != FieldOfAction.GetLength(1) - Skin.GetLength(1)) & TickCounterMove == MovementSpeed)
            { PosY++; TickCounterMove = 0; TickCounterShoot++; }
            else
            { TickCounterMove++; }
        }
    }

    public void Shooting(Dictionary<int, string> Tags, List<ClassEnemyPlasma> EnemyPlasmaList)
    {
        if (!Removed)
        {
            if (TickCounterShoot == RateOfFire)
            {
                for (int i = 1; i < Skin.GetLength(0); i++)
                {
                    if (i % 2 == 0)
                    {
                        EnemyPlasmaList.Add(new ClassEnemyPlasma(Tags, PosX + i - 1, PosY + Skin.GetLength(1) - 1));
                    }
                }
                TickCounterShoot = 0;
            }
        }
    }

    public void ScoreAndLoot(Dictionary<int, string> Tags, ref int Score, List<ClassHealthBuff> HealthBuffList)
    {
        if ((HealthPoints <= 0) && (!Removed))
        {
            // Увеличение счета
            Score += Points;

            // С некоторым шансом после уничтожения врага выпадет бафф
            if (Randomizer.Next(1, 100) <= BuffDropChance) { HealthBuffList.Add(new ClassHealthBuff(Tags, PosX + (Skin.GetLength(0) / 2), PosY)); }
        }
    }
}

