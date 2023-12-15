using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess100;

class Rook
{
    /// <summary>
    /// Chekcks if Rook can go from first coordinate to 2nd coordinate
    /// </summary>
    /// <param name="column1"> 1st coordinates column</param>
    /// <param name="row1">1st coordinates row</param>
    /// <param name="column2">2nd coordinates column</param>
    /// <param name="row2">2nd coordinates row</param>
    /// <returns></returns>
    public bool CheckRookCoord(char column1, int row1, char column2, int row2)
    {
        int rowDifference = Math.Abs(row2 - row1);
        int columnDifference = Math.Abs(column2 - column1);

        return (rowDifference == 0 && columnDifference != 0) || (rowDifference != 0 && columnDifference == 0);
    }
}