
Console.CursorVisible = false;

Dictionary<int, string> Tags = new();

string[,,] FieldOfAction = new string[45, 30, 2]; // создание игрового поля в виде массива строк

int Score = new(); // подсчет очков

bool GameOver = false;

bool Victory = false;

const bool Debug = false; // снизу будет дополнительно отрисовано игровое поле с номерами тэгов объектов и выведен шанс спавна врагов

List<ClassPlayerProjectile> PlayerProjectileList    = new List<ClassPlayerProjectile>();

List<ClassPlayerRocket>     PlayerRocketList        = new List<ClassPlayerRocket>();

List<ClassEnemySmall>       EnemySmallList          = new List<ClassEnemySmall>();

List<ClassEnemyMedium>      EnemyMediumList         = new List<ClassEnemyMedium>();

List<ClassEnemyLarge>       EnemyLargeList          = new List<ClassEnemyLarge>();

List<ClassHealthBuff>       HealthBuffList          = new List<ClassHealthBuff> ();

List<ClassEnemyPlasma>      ElemyPlasmaList         = new List<ClassEnemyPlasma>();

List<ClassBoss>             BossList                = new List<ClassBoss>();

var                         Player                  = new ClassPlayer(ref Tags, FieldOfAction);

var                         Border                  = new ClassBorder(ref Tags, FieldOfAction);

static void ClearFOA(string[,,] FieldOfAction)
{
    for (int i = 0; i < FieldOfAction.GetLength(0); i++)
    {
        for (int j = 0; j < FieldOfAction.GetLength(1); j++)
        {
            for (int k = 0; k < FieldOfAction.GetLength(2); k++)
            {
                FieldOfAction[i, j, k] = " ";
            }
        }
    }
}   // заполнение игрового поля символом "пробел"

static void FrameDrawing(string[,,] FieldOfAction, int Score, ClassPlayer Player, bool Debug)
{
    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++)
    {
        Console.Write('-');
    }
    Console.Write('+');
    Console.WriteLine();

    // ХУД
    Console.Write("|");
    string StrScore = "Score: " + Score;
    string StrHP = "HP: " + Player.HealthPoints + "/10";
    Console.Write(StrScore);
    for (int i = 0; i < (FieldOfAction.GetLength(0) - StrScore.Length - StrHP.Length); i++)
    {
        Console.Write(' ');
    }
    Console.Write(StrHP);
    Console.Write("|");
    Console.WriteLine();

    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++)
    {
        Console.Write('-');
    }
    Console.Write('+');
    Console.WriteLine();

    // вывод игрового поля в виде массива строк
    for (int i = 0; i < FieldOfAction.GetLength(1); i++)
    {
        Console.Write('|');
        for (int j = 0; j < FieldOfAction.GetLength(0); j++)
        {
            Console.Write(FieldOfAction[j, i, 0]);
        }
        Console.Write('|');
        Console.WriteLine();
    }

    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++)
    {
        Console.Write('-');
    }
    Console.Write('+');
    Console.WriteLine();

    if (Debug)  // отображение порядкового номера объекта
    {
        // вывод игрового поля в виде массива строк
        for (int i = 0; i < FieldOfAction.GetLength(1); i++)
        {
            Console.Write('|');
            for (int j = 0; j < FieldOfAction.GetLength(0); j++)
            {
                Console.Write(FieldOfAction[j, i, 1]);
            }
            Console.Write('|');
            Console.WriteLine();
        }

        // горизонтальная прямая
        Console.Write('+');
        for (int i = 0; i < FieldOfAction.GetLength(0); i++)
        {
            Console.Write('-');
        }
        Console.Write('+');
        Console.WriteLine();
    }
}   // отрисовка кадра

static void EnemySpawn(bool Debug, int Score, ref Dictionary<int, string> Tags, string[,,] FieldOfAction, ref List<ClassEnemySmall> EnemySmallList, ref List<ClassEnemyMedium> EnemyMediumList, ref List<ClassEnemyLarge> EnemyLargeList, ref List<ClassBoss> BossList)
{
    if (Score < 3000)
    {
        // EnemySmall

        if (Debug) { Console.Write("EnemySmall spawn chance:  "); }

        if (SpawnItNow(Debug, GetSpawnChance(Score, 3, 3)))
        { EnemySmallList.Add(new ClassEnemySmall(ref Tags, FieldOfAction)); }

        // EnemyMedium

        if (Debug)
        { Console.Write("EnemyMedium spawn chance: "); }

        if (SpawnItNow(Debug, GetSpawnChance(Score, -4, 2)))
        { EnemyMediumList.Add(new ClassEnemyMedium(ref Tags, FieldOfAction)); }

        // EnemyLarge

        if (Debug)
        { Console.Write("EnemyLarge spawn chance:  "); }

        if (SpawnItNow(Debug, GetSpawnChance(Score, -9, 1)))
        { EnemyLargeList.Add(new ClassEnemyLarge(ref Tags, FieldOfAction)); }
    }
    else
    {
        // Boss

        if (BossList.Count == 0)
        { BossList.Add(new ClassBoss(ref Tags, FieldOfAction)); }
    }
}

static bool SpawnItNow(bool Debug, int SpawnChance)
{
    Random ChanceRandomizer = new Random();

    if (Debug) { Console.Write(SpawnChance + " %"); Console.WriteLine(); }

    if (ChanceRandomizer.Next(1, 100) <= SpawnChance) { return true; }

    return false;
}

static int GetSpawnChance(int Score, int StartSpawnChance, int MaxSpawnChance)
{
    if (Score / 100 + StartSpawnChance <= 0) { return 0; }

    if ((Score / 100 + StartSpawnChance) >= MaxSpawnChance) { return MaxSpawnChance; }

    return Score / 100 + StartSpawnChance;
}

if (Debug) { Console.SetWindowSize(FieldOfAction.GetLength(0) + 2, 2 * FieldOfAction.GetLength(1) + 8); }
else       { Console.SetWindowSize(FieldOfAction.GetLength(0) + 2,     FieldOfAction.GetLength(1) + 6); }
Console.WriteLine();
Console.WriteLine(" Управление:");
Console.WriteLine();
Console.WriteLine(" # Стрелки - задать вектор движения");
Console.WriteLine();
Console.WriteLine(" # Пробел  - остановиться");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Игра:");
Console.WriteLine();
Console.WriteLine(" # Не дайте пришельцам добраться");
Console.WriteLine("   до края игрового поля");
Console.WriteLine();
Console.WriteLine(" # Собирайте баффы (+), чтобы");
Console.WriteLine("   увеличить очки здоровья (HP)");
Console.WriteLine();
Console.WriteLine(" # Используемое оружие зависит");
Console.WriteLine("   от количества очков здоровья");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Нажмите любую клавишу, чтобы начать!");
Console.ReadKey();
Console.Clear();

// выполнение отрисовки кадра с задержкой
while (!Player.Removed && !GameOver && !Victory)
{
    ClearFOA(FieldOfAction);
    Console.CursorVisible = false;

    // Выстрелы
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].Shooting(ref Tags, ref ElemyPlasmaList); }
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].Shooting(ref Tags, ref ElemyPlasmaList); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].Shooting(ref Tags, ref ElemyPlasmaList); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].Shooting(ref Tags, ref ElemyPlasmaList); }
                                                           Player                  .Shooting(ref Tags, ref PlayerProjectileList, ref PlayerRocketList);

    // Перемещение объектов
    for (int i = 0; i < PlayerProjectileList.Count; i++) { PlayerProjectileList [i].Movement(); }
    for (int i = 0; i < PlayerRocketList    .Count; i++) { PlayerRocketList     [i].Movement(); }
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { ElemyPlasmaList      [i].Movement(FieldOfAction); }
    for (int i = 0; i < HealthBuffList      .Count; i++) { HealthBuffList       [i].Movement(FieldOfAction); }
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].Movement(FieldOfAction); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].Movement(FieldOfAction); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].Movement(FieldOfAction); }
                                                           Player                  .Movement(FieldOfAction);

    // Отрисовка объектов
                                                           Border                  .Draw(ref FieldOfAction);
    for (int i = 0; i < PlayerProjectileList.Count; i++) { PlayerProjectileList [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < PlayerRocketList    .Count; i++) { PlayerRocketList     [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { ElemyPlasmaList      [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < HealthBuffList      .Count; i++) { HealthBuffList       [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].Draw(ref FieldOfAction); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].Draw(ref FieldOfAction); }
                                                           Player                  .Draw(ref FieldOfAction);

    // Обработка взаимодействий объектов
                                                           Border                  .InteractionCheck(ref FieldOfAction, Tags, ref GameOver);
    for (int i = 0; i < PlayerProjectileList.Count; i++) { PlayerProjectileList [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < PlayerRocketList    .Count; i++) { PlayerRocketList     [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { ElemyPlasmaList      [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < HealthBuffList      .Count; i++) { HealthBuffList       [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].InteractionCheck(ref FieldOfAction, Tags, ref GameOver); }
                                                           Player                  .InteractionCheck(ref FieldOfAction, Tags, ref GameOver);

    // Отображение ХП босса
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].WriteHP(FieldOfAction, BossList); }

    // Добавление очков в счет и спавн баффов после смерти врагов
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].ScoreAndLoot(ref Tags, ref Score, ref HealthBuffList); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].ScoreAndLoot(ref Tags, ref Score, ref HealthBuffList); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].ScoreAndLoot(ref Tags, ref Score, ref HealthBuffList); }

    // Обработка смерти босса
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].ScoreAndVictory(ref Score, ref Victory); }

    // Удаление лишних объектов
    for (int i = 0; i < PlayerProjectileList.Count; i++) { PlayerProjectileList [i].HealthPointsCheck(); }
    for (int i = 0; i < PlayerRocketList    .Count; i++) { PlayerRocketList     [i].HealthPointsCheck(); }
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { ElemyPlasmaList      [i].HealthPointsCheck(); }
    for (int i = 0; i < HealthBuffList      .Count; i++) { HealthBuffList       [i].HealthPointsCheck(); }
    for (int i = 0; i < BossList            .Count; i++) { BossList             [i].HealthPointsCheck(); }
    for (int i = 0; i < EnemySmallList      .Count; i++) { EnemySmallList       [i].HealthPointsCheck(); }
    for (int i = 0; i < EnemyMediumList     .Count; i++) { EnemyMediumList      [i].HealthPointsCheck(); }
    for (int i = 0; i < EnemyLargeList      .Count; i++) { EnemyLargeList       [i].HealthPointsCheck(); }
                                                           Player                  .HealthPointsCheck();

    // Спавн новых врагов
    EnemySpawn(Debug, Score, ref Tags, FieldOfAction, ref EnemySmallList, ref EnemyMediumList, ref EnemyLargeList, ref BossList);

    // Отрисовка кадра
    Console.SetCursorPosition(0, 0);
    FrameDrawing(FieldOfAction, Score, Player, Debug);
    Thread.Sleep(100);
}

Console.ReadKey();
Console.Clear();
Console.WriteLine();
if (Player.Removed) { Console.WriteLine(" Ваш космический корабль взорвали!"); }
if (GameOver)       { Console.WriteLine(" Ваша оборону прорвали!"           ); }
if (Victory)        { Console.WriteLine(" Вы остановили вторжение!"         ); }
Console.WriteLine();
Console.WriteLine(" Cчет: " + Score + " очков");
Console.ReadKey();