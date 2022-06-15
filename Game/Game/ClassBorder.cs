using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassBorder : ClassGameObject
{
    public ClassBorder(ref Dictionary<int, string> Tags, string[,,] FieldOfAction)
    {
        Skin = new string[FieldOfAction.GetLength(0), 1, 2];

        for (int i = 0; i < FieldOfAction.GetLength(0); i++)
        { Skin[i, 0, 0] = " "; }

        ThisObjectTag = "Border";

        AddTag(ref Tags);

        SetTag();

        HealthPoints = 1;

        PosX = 0; // самая левая точка

        PosY = FieldOfAction.GetLength(1) - 1; // нижняя часть поля
    }
}

