using MyLibrary;
using System.Diagnostics;

// Объявление переменных для чтения настроек
SettingsEditor SE = new SettingsEditor();
List <string> ReadSettingsErrorDiscription = new List <string> ();
bool ReadSettingsError = false;

// Объявление переменных, которые будут настроены и установка значений по умолчанию
string GameMode = "WithBoss";
int FieldLenght = 50;
int FieldHeight = 30;
int InterframeDelay = 75;
bool ShowSpawnChance = false;
bool Debug = false; // Продублировать игровое поле, но с номерами тэгов объектов

// Режим игры
try
{
    if (SE.ReadSetting(SE.NUM_GAME_MODE) == "0") { GameMode = "WithBoss"; }
    else                                         { GameMode = "Endless"; }
}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Режим игры'. Установлено значение по умолчанию: " + GameMode);
}

// Длина игрового поля
try
{
    if (int.Parse(SE.ReadSetting(SE.NUM_FIELD_LENGHT)) < SE.MIN_FIELD_LENGHT)
    {
        FieldLenght = SE.MIN_FIELD_LENGHT;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Длина игрового поля' меньше допустимого. Установлено минимальное значение: " + FieldLenght);
    }
    if (int.Parse(SE.ReadSetting(SE.NUM_FIELD_LENGHT)) > SE.MAX_FIELD_LENGHT)
    {
        FieldLenght = SE.MAX_FIELD_LENGHT;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Длина игрового поля' больше допустимого. Установлено максимальное значение: " + FieldLenght);
    }
    if ((SE.MIN_FIELD_LENGHT <= int.Parse(SE.ReadSetting(SE.NUM_FIELD_LENGHT))) && (int.Parse(SE.ReadSetting(SE.NUM_FIELD_LENGHT)) <= SE.MAX_FIELD_LENGHT))
    {
        FieldLenght = int.Parse(SE.ReadSetting(SE.NUM_FIELD_LENGHT));
    }
}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Длина игрового поля'. Установлено значение по умолчанию: " + FieldLenght);
}

// Высота игрового поля
try
{
    if (int.Parse(SE.ReadSetting(SE.NUM_FIELD_HEIGHT)) < SE.MIN_FIELD_HEIGHT)
    {
        FieldHeight = SE.MIN_FIELD_HEIGHT;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Высота игрового поля' меньше допустимого. Установлено минимальное значение: " + FieldHeight);
    }
    if (int.Parse(SE.ReadSetting(SE.NUM_FIELD_HEIGHT)) > SE.MAX_FIELD_HEIGHT)
    {
        FieldHeight = SE.MAX_FIELD_HEIGHT;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Высота игрового поля' больше допустимого. Установлено максимальное значение: " + FieldHeight);
    }
    if ((SE.MIN_FIELD_HEIGHT <= int.Parse(SE.ReadSetting(SE.NUM_FIELD_HEIGHT))) && (int.Parse(SE.ReadSetting(SE.NUM_FIELD_HEIGHT)) <= SE.MAX_FIELD_HEIGHT))
    {
        FieldHeight = int.Parse(SE.ReadSetting(SE.NUM_FIELD_HEIGHT));
    }
}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Высота игрового поля'. Установлено значение по умолчанию: " + FieldHeight);
}

// Задержка между кадрами
try
{
    InterframeDelay = int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY));

    if (int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY)) < SE.MIN_INTERFRAME_DELAY)
    {
        InterframeDelay = SE.MIN_INTERFRAME_DELAY;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Задержка между кадрами' меньше допустимого. Установлено минимальное значение: " + InterframeDelay);
    }
    if (int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY)) > SE.MAX_INTERFRAME_DELAY)
    {
        InterframeDelay = SE.MAX_INTERFRAME_DELAY;
        ReadSettingsError = true;
        ReadSettingsErrorDiscription.Add("Значение параметра 'Задержка между кадрами' больше допустимого. Установлено максимальное значение: " + InterframeDelay);
    }
    if ((SE.MIN_INTERFRAME_DELAY <= int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY))) && (int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY)) <= SE.MAX_INTERFRAME_DELAY))
    {
        InterframeDelay = int.Parse(SE.ReadSetting(SE.NUM_INTERFRAME_DELAY));
    }

}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Задержка между кадрами'. Установлено значение по умолчанию: " + InterframeDelay);
}

// Показывать шанс появления врагов
try
{
    if (SE.ReadSetting(SE.NUM_SHOW_SPAWN_CHANCE) == "0") { ShowSpawnChance = false; }
    else                                                 { ShowSpawnChance = true ; }
}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Показывать шанс появления врагов'. Установлено значение по умолчанию: " + ShowSpawnChance);
}

// Продублировать игровое поле, но с номерами тэгов объектов
try
{
    if (SE.ReadSetting(SE.NUM_DEBUG) == "0") { Debug = false; }
    else                                     { Debug = true ; }
}
catch (Exception)
{
    ReadSettingsError = true;
    ReadSettingsErrorDiscription.Add("Не удалось прочитать параметр 'Режим отладки'. Установлено значение по умолчанию: " + Debug);
}

Console.CursorVisible = false;

// Вывод окна с описанием ошибок, если они есть
if (ReadSettingsError)
{
    Console.SetWindowSize(115,25);
    Console.WriteLine();
    for (int i = 0; i < ReadSettingsErrorDiscription.Count; i++)
    { 
        Console.WriteLine(" # " + ReadSettingsErrorDiscription[i]);
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(" Нажмите любую клавишу, чтобы продолжить");
    Console.ReadKey();
    Console.Clear();
}

// Вывод приветственного окна
Console.SetWindowSize(115, 25);
Console.WriteLine();
Console.WriteLine(" Управление:");
Console.WriteLine();
Console.WriteLine(" # Стрелки - задать вектор движения");
Console.WriteLine();
Console.WriteLine(" # Пробел  - остановиться");
Console.WriteLine();
Console.WriteLine(" # Esc     - вернуться в меню");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Игра:");
Console.WriteLine();
Console.WriteLine(" # Не дайте пришельцам добраться до края игрового поля");
Console.WriteLine();
Console.WriteLine(" # Собирайте баффы (+), чтобы увеличить очки здоровья (HP)");
Console.WriteLine();
Console.WriteLine(" # Используемое оружие зависит от количества очков здоровья");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Нажмите любую клавишу, чтобы начать!");
Console.ReadKey();
Console.Clear();

// Объявление переменных
const string PATH_TO_MENU_EXE = "Menu.exe";
Dictionary <int, string> Tags = new(); // Создание словаря тэгов игровых объектов, где ключ - порядковый номер, значение - тэг
char [,,] FieldOfAction = new char[FieldLenght, FieldHeight, 2]; // Создание игрового поля в виде массива строк
int  Score    = new int(); // Подсчет очков
bool GameOver = false; // Враг пересек нижнюю границу
bool Victory  = false; // Босс был убит
List<ClassPlayerProjectile> PlayerProjectileList    = new List<ClassPlayerProjectile>();
List<ClassPlayerRocket>     PlayerRocketList        = new List<ClassPlayerRocket>();
List<ClassEnemySmall>       EnemySmallList          = new List<ClassEnemySmall>();
List<ClassEnemyMedium>      EnemyMediumList         = new List<ClassEnemyMedium>();
List<ClassEnemyLarge>       EnemyLargeList          = new List<ClassEnemyLarge>();
List<ClassHealthBuff>       HealthBuffList          = new List<ClassHealthBuff> ();
List<ClassEnemyPlasma>      ElemyPlasmaList         = new List<ClassEnemyPlasma>();
List<ClassBoss>             BossList                = new List<ClassBoss>();
var                         Player                  = new ClassPlayer(Tags, FieldOfAction);
var                         Border                  = new ClassBorder(Tags, FieldOfAction);

// Вспомогательные функции
static void ClearFOA(char[,,] FieldOfAction)
{
    for (int i = 0; i < FieldOfAction.GetLength(0); i++)
    {
        for (int j = 0; j < FieldOfAction.GetLength(1); j++)
        {
            for (int k = 0; k < FieldOfAction.GetLength(2); k++)
            {
                FieldOfAction[i, j, k] = ' ';
            }
        }
    }
}   // заполнение игрового поля символом "пробел"
static void FrameDrawing(char[,,] FieldOfAction, int Score, ClassPlayer Player, bool Debug)
{
    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++) { Console.Write('-'); }
    Console.Write('+');
    Console.WriteLine();

    // ХУД
    Console.Write("|");
    string StrScore = "Score: " + Score;
    string StrHP = "HP: " + Player.HealthPoints + "/10";
    Console.Write(StrScore);
    for (int i = 0; i < (FieldOfAction.GetLength(0) - StrScore.Length - StrHP.Length); i++) { Console.Write(' '); }
    Console.Write(StrHP);
    Console.Write("|");
    Console.WriteLine();

    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++) { Console.Write('-'); }
    Console.Write('+');
    Console.WriteLine();

    // вывод игрового поля в виде массива строк
    for (int i = 0; i < FieldOfAction.GetLength(1); i++)
    {
        Console.Write('|');
        for (int j = 0; j < FieldOfAction.GetLength(0); j++) { Console.Write(FieldOfAction[j, i, 0]); }
        Console.Write('|');
        Console.WriteLine();
    }

    // горизонтальная прямая
    Console.Write('+');
    for (int i = 0; i < FieldOfAction.GetLength(0); i++) { Console.Write('-'); }
    Console.Write('+');
    Console.WriteLine();

    if (Debug)  // отображение порядкового номера тэгов объектов
    {
        // вывод игрового поля в виде массива строк
        for (int i = 0; i < FieldOfAction.GetLength(1); i++)
        {
            Console.Write('|');
            for (int j = 0; j < FieldOfAction.GetLength(0); j++) { Console.Write(FieldOfAction[j, i, 1]); }
            Console.Write('|');
            Console.WriteLine();
        }

        // горизонтальная прямая
        Console.Write('+');
        for (int i = 0; i < FieldOfAction.GetLength(0); i++) { Console.Write('-'); }
        Console.Write('+');
        Console.WriteLine();
    }
}   // отрисовка кадра
static void EnemySpawn(string GameMode, bool ShowSpawnChance, int Score, Dictionary<int, string> Tags, char[,,] FieldOfAction, List<ClassEnemySmall> EnemySmallList, List<ClassEnemyMedium> EnemyMediumList, List<ClassEnemyLarge> EnemyLargeList, List<ClassBoss> BossList)
{
    if (GameMode == "WithBoss")
    {
        if (Score < 3000)
        {
            // EnemySmall

            if (ShowSpawnChance) { Console.Write("EnemySmall  spawn chance: "); }

            if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score, 3, 3)))
            { EnemySmallList.Add(new ClassEnemySmall(Tags, FieldOfAction)); }

            // EnemyMedium

            if (ShowSpawnChance)
            { Console.Write("EnemyMedium spawn chance: "); }

            if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score, -4, 2)))
            { EnemyMediumList.Add(new ClassEnemyMedium(Tags, FieldOfAction)); }

            // EnemyLarge

            if (ShowSpawnChance)
            { Console.Write("EnemyLarge  spawn chance: "); }

            if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score, -9, 1)))
            { EnemyLargeList.Add(new ClassEnemyLarge(Tags, FieldOfAction)); }
        }
        else
        {
            // Boss

            if (BossList.Count == 0)
            { BossList.Add(new ClassBoss(Tags, FieldOfAction)); }
        }
    }

    if (GameMode == "Endless")
    {
        // EnemySmall

        if (ShowSpawnChance) { Console.Write("EnemySmall  spawn chance: "); }

        if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score / 10, 3, 9)))
        { EnemySmallList.Add(new ClassEnemySmall(Tags, FieldOfAction)); }

        // EnemyMedium

        if (ShowSpawnChance)
        { Console.Write("EnemyMedium spawn chance: "); }

        if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score / 10, 0, 6)))
        { EnemyMediumList.Add(new ClassEnemyMedium(Tags, FieldOfAction)); }

        // EnemyLarge

        if (ShowSpawnChance)
        { Console.Write("EnemyLarge  spawn chance: "); }

        if (SpawnItNow(ShowSpawnChance, GetSpawnChance(Score / 10, -3, 3)))
        { EnemyLargeList.Add(new ClassEnemyLarge(Tags, FieldOfAction)); }
    }
}
static bool SpawnItNow(bool ShowSpawnChance, int SpawnChance)
{
    Random ChanceRandomizer = new Random();

    if (ShowSpawnChance) { Console.Write(SpawnChance + " %"); Console.WriteLine(); }

    if (ChanceRandomizer.Next(1, 100) <= SpawnChance) { return true; }

    return false;
}
static int  GetSpawnChance(int Score, int StartSpawnChance, int MaxSpawnChance)
{
    if (Score / 100 + StartSpawnChance <= 0) { return 0; }

    if ((Score / 100 + StartSpawnChance) >= MaxSpawnChance) { return MaxSpawnChance; }

    return Score / 100 + StartSpawnChance;
}

// Выбор размера окна консоли
if ( Debug &&  ShowSpawnChance) { Console.SetWindowSize(FieldOfAction.GetLength(0) + 3, 2 * FieldOfAction.GetLength(1) + 9); }
if ( Debug && !ShowSpawnChance) { Console.SetWindowSize(FieldOfAction.GetLength(0) + 3, 2 * FieldOfAction.GetLength(1) + 9); }
if (!Debug &&  ShowSpawnChance) { Console.SetWindowSize(FieldOfAction.GetLength(0) + 3, FieldOfAction.GetLength(1) + 9); }
if (!Debug && !ShowSpawnChance) { Console.SetWindowSize(FieldOfAction.GetLength(0) + 3, FieldOfAction.GetLength(1) + 6); }

// выполнение отрисовки кадра с задержкой
while (!Player.Removed && !GameOver && !Victory)
{
    ClearFOA(FieldOfAction);
    Console.CursorVisible = false;

    // Выстрелы
    for (int i = 0; i < BossList            .Count; i++) { if (BossList       		[i] != null) {BossList             [i].Shooting(Tags, ElemyPlasmaList); }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList 		[i] != null) {EnemySmallList       [i].Shooting(Tags, ElemyPlasmaList); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList		[i] != null) {EnemyMediumList      [i].Shooting(Tags, ElemyPlasmaList); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList 		[i] != null) {EnemyLargeList       [i].Shooting(Tags, ElemyPlasmaList); }}
                                                           if (Player         		    != null) {Player                  .Shooting(Tags, PlayerProjectileList, PlayerRocketList);}

    // Перемещение объектов
    for (int i = 0; i < PlayerProjectileList.Count; i++) { if (PlayerProjectileList [i] != null) {PlayerProjectileList [i].Movement(); 				}}
    for (int i = 0; i < PlayerRocketList    .Count; i++) { if (PlayerRocketList     [i] != null) {PlayerRocketList     [i].Movement(); 				}}
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { if (ElemyPlasmaList      [i] != null) {ElemyPlasmaList      [i].Movement(FieldOfAction); }}
    for (int i = 0; i < HealthBuffList      .Count; i++) { if (HealthBuffList       [i] != null) {HealthBuffList       [i].Movement(FieldOfAction); }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null) {EnemySmallList       [i].Movement(FieldOfAction); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null) {EnemyMediumList      [i].Movement(FieldOfAction); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null) {EnemyLargeList       [i].Movement(FieldOfAction); }}

    // Управление
    if  (Player != null) { Player.Control(FieldOfAction, PATH_TO_MENU_EXE); }

    // Отрисовка объектов
                                                           if (Border                   != null) {Border                  .Draw(FieldOfAction);  }
    for (int i = 0; i < PlayerProjectileList.Count; i++) { if (PlayerProjectileList [i] != null) {PlayerProjectileList [i].Draw(FieldOfAction); }}
    for (int i = 0; i < PlayerRocketList    .Count; i++) { if (PlayerRocketList     [i] != null) {PlayerRocketList     [i].Draw(FieldOfAction); }}
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { if (ElemyPlasmaList      [i] != null) {ElemyPlasmaList      [i].Draw(FieldOfAction); }}
    for (int i = 0; i < HealthBuffList      .Count; i++) { if (HealthBuffList       [i] != null) {HealthBuffList       [i].Draw(FieldOfAction); }}
    for (int i = 0; i < BossList            .Count; i++) { if (BossList             [i] != null) {BossList             [i].Draw(FieldOfAction); }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null) {EnemySmallList       [i].Draw(FieldOfAction); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null) {EnemyMediumList      [i].Draw(FieldOfAction); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null) {EnemyLargeList       [i].Draw(FieldOfAction); }}
                                                           if (Player                   != null) {Player                  .Draw(FieldOfAction);  }

    // Обработка взаимодействий объектов
                                                           if (Border                   != null) {Border                  .InteractionCheck(FieldOfAction, Tags, ref GameOver);  }
    for (int i = 0; i < PlayerProjectileList.Count; i++) { if (PlayerProjectileList [i] != null) {PlayerProjectileList [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < PlayerRocketList    .Count; i++) { if (PlayerRocketList     [i] != null) {PlayerRocketList     [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { if (ElemyPlasmaList      [i] != null) {ElemyPlasmaList      [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < HealthBuffList      .Count; i++) { if (HealthBuffList       [i] != null) {HealthBuffList       [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < BossList            .Count; i++) { if (BossList             [i] != null) {BossList             [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null) {EnemySmallList       [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null) {EnemyMediumList      [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null) {EnemyLargeList       [i].InteractionCheck(FieldOfAction, Tags, ref GameOver); }}
                                                           if (Player                   != null) {Player                  .InteractionCheck(FieldOfAction, Tags, ref GameOver);  }

    // Отображение ХП босса
    for (int i = 0; i < BossList            .Count; i++) { BossList                                                    [i].WriteHP(FieldOfAction, BossList); }

    // Добавление очков в счет и спавн баффов после смерти врагов
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null) {EnemySmallList       [i].ScoreAndLoot(Tags, ref Score, HealthBuffList); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null) {EnemyMediumList      [i].ScoreAndLoot(Tags, ref Score, HealthBuffList); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null) {EnemyLargeList       [i].ScoreAndLoot(Tags, ref Score, HealthBuffList); }}

    // Обработка смерти босса
    for (int i = 0; i < BossList            .Count; i++) { BossList                                                    [i].ScoreAndVictory(ref Score, ref Victory); }

    // Удаление лишних объектов
    for (int i = 0; i < PlayerProjectileList.Count; i++) { if (PlayerProjectileList [i] != null) {PlayerProjectileList [i].HealthPointsCheck(); }}
    for (int i = 0; i < PlayerRocketList    .Count; i++) { if (PlayerRocketList     [i] != null) {PlayerRocketList     [i].HealthPointsCheck(); }}
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { if (ElemyPlasmaList      [i] != null) {ElemyPlasmaList      [i].HealthPointsCheck(); }}
    for (int i = 0; i < HealthBuffList      .Count; i++) { if (HealthBuffList       [i] != null) {HealthBuffList       [i].HealthPointsCheck(); }}
    for (int i = 0; i < BossList            .Count; i++) { if (BossList             [i] != null) {BossList             [i].HealthPointsCheck(); }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null) {EnemySmallList       [i].HealthPointsCheck(); }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null) {EnemyMediumList      [i].HealthPointsCheck(); }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null) {EnemyLargeList       [i].HealthPointsCheck(); }}
                                                           if (Player                   != null) {Player                  .HealthPointsCheck();  }
	
	// Удаление ссылок на неиспользуемые экземпляры классов, чтобы в куче их съел сборщик мусора
	for (int i = 0; i < PlayerProjectileList.Count; i++) { if (PlayerProjectileList [i] != null && PlayerProjectileList[i].Removed) {PlayerProjectileList [i] = null; }}
    for (int i = 0; i < PlayerRocketList    .Count; i++) { if (PlayerRocketList     [i] != null && PlayerRocketList    [i].Removed) {PlayerRocketList     [i] = null; }}
    for (int i = 0; i < ElemyPlasmaList     .Count; i++) { if (ElemyPlasmaList      [i] != null && ElemyPlasmaList     [i].Removed) {ElemyPlasmaList      [i] = null; }}
    for (int i = 0; i < HealthBuffList      .Count; i++) { if (HealthBuffList       [i] != null && HealthBuffList      [i].Removed) {HealthBuffList       [i] = null; }}
  //for (int i = 0; i < BossList            .Count; i++) { if (BossList             [i] != null && BossList            [i].Removed) {BossList             [i] = null; }}
    for (int i = 0; i < EnemySmallList      .Count; i++) { if (EnemySmallList       [i] != null && EnemySmallList      [i].Removed) {EnemySmallList       [i] = null; }}
    for (int i = 0; i < EnemyMediumList     .Count; i++) { if (EnemyMediumList      [i] != null && EnemyMediumList     [i].Removed) {EnemyMediumList      [i] = null; }}
    for (int i = 0; i < EnemyLargeList      .Count; i++) { if (EnemyLargeList       [i] != null && EnemyLargeList      [i].Removed) {EnemyLargeList       [i] = null; }}

    // Отрисовка кадра
    Console.SetCursorPosition(0, 0);
    FrameDrawing(FieldOfAction, Score, Player, Debug);

    // Спавн новых врагов
    EnemySpawn(GameMode, ShowSpawnChance, Score, Tags, FieldOfAction, EnemySmallList, EnemyMediumList, EnemyLargeList, BossList);

    Thread.Sleep(InterframeDelay);
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

Process.Start(PATH_TO_MENU_EXE);