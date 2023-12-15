using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess100;

struct Coordinates
{
    public string? coord;
    /// <summary>
    /// Imput coordinate
    /// </summary>
    /// <param name="inputCoordinates"></param>
    public Coordinates(string? inputCoordinates)
    {
        coord = inputCoordinates;
        coord = coord.ToUpper();
    }
    /// <summary>
    /// Returns Letter/column of Coordinate
    /// </summary>
    /// <returns>letterCoord</returns>
    public char ReturnsLetterCoordinate()
    {
        char.TryParse(coord[0].ToString(), out char letterCoord);
        return letterCoord;
    }
    /// <summary>
    /// Returns Number/row of Coordinate
    /// </summary>
    /// <returns>numberCoord</returns>
    public int ReturnsNumberCoordinate()
    {
        int.TryParse(coord[1].ToString(), out int numberCoord);
        return numberCoord;
    }
}
