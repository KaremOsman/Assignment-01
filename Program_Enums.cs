using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{

    #region Q_1
    public enum WeekDays
    {
        Saturday,
        sunday,
        Monday,
        Tuesday,
        Wednesday,
        Friday
    }
    #endregion

    #region Q_2
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Q_3

    [Flags]
    public enum Permissions : byte
    {
        Read = 1,
        Write= 2,
        Delete = 4,
        Execute = 8,
    }

    #endregion

    #region Q_4
    public enum Colors‎
    {
        Red,
        Green,
        Blue
    } 
    #endregion

}
