using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassGameObject
{
    protected string[,,] Skin = new string[,,] { { { " ", "z" } } };
    protected int PosX;
    protected int PosY;
    private int TagNum;   // Порядковый номер объекта
    protected string ThisObjectTag = string.Empty;  // Тэг побъекта
    private string InteractedObjectTag = string.Empty; // Тэг объекта с которым произошло столкновение
    public int HealthPoints;
    protected int Points = new(); // Количество очков, которые будут даваться после уничтожения этого объекта
    public bool Removed = false;
    protected Random Randomizer = new Random();

    protected void AddTag(ref Dictionary<int, string> Tags)
    {
        if (Tags.Count == 0)
        {
            TagNum = Tags.Count;
            Tags.Add(Tags.Count, ThisObjectTag);
        }
        else
        {
            for (int i = 0; i < Tags.Count; i++)
            {
                if (Tags[i] == ThisObjectTag)
                {
                    TagNum = i;
                    break;
                }
                if ((i == Tags.Count - 1) & (Tags[i] != ThisObjectTag)) // for дошел до конца словаря и не нашел тэг
                {
                    TagNum = Tags.Count;
                    Tags.Add(Tags.Count, ThisObjectTag);
                }
            }
        }
    }   // Добавление экземпляра игрового объекта в словарь тэгов 
    protected void SetTag()
    {
        for (int i = 0; i < Skin.GetLength(0); i++)
        {
            for (int j = 0; j < Skin.GetLength(1); j++)
            {
                Skin[i, j, 1] = TagNum.ToString();
            }
        }
    }   // Запись порядкового номера объекта в третье измерение

    public void Draw(ref string[,,] FieldOfAction)
    {   if (!Removed)
        {
            for (int i = 0; i < Skin.GetLength(2); i++)
            {
                for (int j = 0; j < Skin.GetLength(1); j++)
                {
                    for (int k = 0; k < Skin.GetLength(0); k++)
                    {
                        FieldOfAction[PosX + k, PosY + j, i] = Skin[k, j, i];
                    }
                }
            }
        }
    }   // Отрисовка объекта в игровом поле

    public void InteractionCheck(ref string[,,] FieldOfAction, Dictionary<int, string> Tags, ref bool GameOver)
    {
        if (!Removed)
        {
            for (int i = 0; i < Skin.GetLength(0); i++)
            {
                for (int j = 0; j < Skin.GetLength(1); j++)
                {
                    if ((FieldOfAction[PosX + i, PosY + j, 1] != Skin[i, j, 1]) & // если тэг объекта пересекся с другим
                        (FieldOfAction[PosX + i, PosY + j, 1] != " ") & // и это не "пустое" пространство
                        !Removed) // и этот объект живой
                    {
                        InteractedObjectTag = GetTag(Tags, FieldOfAction, PosX + i, PosY + j);

                        // если столкнулись враг и нижняя граница поля
                        if (((ThisObjectTag == "Border") && (InteractedObjectTag == "Enemy" )) ||
                            ((ThisObjectTag == "Enemy" ) && (InteractedObjectTag == "Border")))
                        {
                            GameOver = true;
                        }

                        // если столкнулись игрок и враг
                        if (((ThisObjectTag == "Player") && (InteractedObjectTag == "Enemy")) ||
                            ((ThisObjectTag == "Enemy") && (InteractedObjectTag == "Player")))
                        {
                            FieldOfAction[PosX + i, PosY + j, 0] = "Ж";
                            InteractedObjectTag = string.Empty;
                        }

                        // если столкнулись игрок и бафф
                        if ((ThisObjectTag == "Player") && (InteractedObjectTag == "HealthBuff"))
                        {
                            FieldOfAction[PosX + i, PosY + j, 0] = "@";
                            InteractedObjectTag = string.Empty;
                        }

                        if ((ThisObjectTag == "HealthBuff") && (InteractedObjectTag == "Player"))
                        {
                            FieldOfAction[PosX + i, PosY + j, 0] = "@";
                            InteractedObjectTag = string.Empty;
                        }

                        // если столкнулись враг и снаряд игрока
                        if (((ThisObjectTag == "Enemy"           ) && (InteractedObjectTag == "PlayerProjectile")) ||
                            ((ThisObjectTag == "PlayerProjectile") && (InteractedObjectTag == "Enemy"           )))
                        {
                            FieldOfAction[PosX + i, PosY + j, 0] = "Ж";
                            InteractedObjectTag = string.Empty;
                        }

                        // если столкнулись враг и ракета игрока
                        if (((ThisObjectTag == "Enemy") && (InteractedObjectTag == "PlayerRocket")) ||
                            ((ThisObjectTag == "PlayerRocket") && (InteractedObjectTag == "Enemy")))
                        {
                            // ЖЖЖ
                            //ЖЖЖЖЖ
                            // ЖЖЖ

                            try { FieldOfAction[PosX + i - 1, PosY + j - 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i    , PosY + j - 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i + 1, PosY + j - 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }

                            try { FieldOfAction[PosX + i - 2, PosY + j    , 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i - 1, PosY + j    , 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i    , PosY + j    , 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i + 1, PosY + j    , 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i + 2, PosY + j    , 0] = "Ж"; } catch (IndexOutOfRangeException) { }

                            try { FieldOfAction[PosX + i - 1, PosY + j + 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i    , PosY + j + 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }
                            try { FieldOfAction[PosX + i + 1, PosY + j + 1, 0] = "Ж"; } catch (IndexOutOfRangeException) { }

                            InteractedObjectTag = string.Empty;
                        }

                        // если столкнулись игрок и снаряд врага
                        if (((ThisObjectTag == "Player") && (InteractedObjectTag == "EnemyPlasma")) ||
                            ((ThisObjectTag == "EnemyPlasma") && (InteractedObjectTag == "Player")))
                        {
                            FieldOfAction[PosX + i, PosY + j, 0] = "Ж";
                            InteractedObjectTag = string.Empty;
                        }
                    }

                    if ((FieldOfAction[PosX + i, PosY + j, 0] == "Ж") && // если на скине появился эффект повреждения
                        (ThisObjectTag != "HealthBuff")) // и этот объект не является баффом
                    {
                        HealthPoints--;
                    }

                    if ((FieldOfAction[PosX + i, PosY + j, 0] == "@") && // если на скине появился эффект лечения
                        (ThisObjectTag == "Player") && // и этот объект является игроком
                        !(HealthPoints >= 10)) // и здоровье уже максимальное
                    {
                        HealthPoints++;
                    }

                    if ((FieldOfAction[PosX + i, PosY + j, 0] == "@") && // если на скине появился эффект лечения
                        (ThisObjectTag == "HealthBuff")) // и этот объект является баффом
                    {
                        HealthPoints--;
                    }
                }
            }
        }
    }
    public void HealthPointsCheck()
    {
        if (!Removed)
        {
            if (HealthPoints <= 0)
            {
                for (int i = 0; i < Skin.GetLength(2); i++)
                {
                    for (int j = 0; j < Skin.GetLength(1); j++)
                    {
                        for (int k = 0; k < Skin.GetLength(0); k++)
                        {
                            Skin[k, j, i] = " ";
                        }
                    }
                }
                Removed = true;
            }
        }
    }

    private string GetTag(Dictionary<int, string> Tags, string[,,] FieldOfAction, int X, int Y)
    {
        return Tags[int.Parse(FieldOfAction[X, Y, 1])];
    }
}