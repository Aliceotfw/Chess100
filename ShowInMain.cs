using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess100;

class ShowInMain
{
    public void ShowInConsole()
    {

        Board chess = new Board();
        Knight knight = new Knight();
        Rook rook = new Rook();
        King king = new King();
        Bishop bishop = new Bishop();
        Queen queen = new Queen();


        Console.Write("Enter Figure name: ");
        string figureName = Console.ReadLine();
        figureName = figureName.ToUpper();
        Console.Write("Enter coordinate1: ");
        Coordinates coord1 = new Coordinates(Console.ReadLine());

        Console.Write("Enter coordinate2: ");
        Coordinates coord2 = new Coordinates(Console.ReadLine());

        char column1 = coord1.ReturnsLetterCoordinate();
        int row1 = coord1.ReturnsNumberCoordinate();
        char column2 = coord2.ReturnsLetterCoordinate();
        int row2 = coord2.ReturnsNumberCoordinate();

        chess.PrintBoard(column1, row1, figureName);
        Console.WriteLine();

        switch (figureName)
        {
            case "ROOK":
                Console.WriteLine(rook.CheckRookCoord(column1, row1, column2, row2));
                if (rook.CheckRookCoord(column1, row1, column2, row2))
                    chess.PrintBoard(column2, row2, figureName);
                break;
            case "KNIGHT":
                Console.WriteLine(knight.CheckKnightCoord(column1, row1, column2, row2));
                if (knight.CheckKnightCoord(column1, row1, column2, row2))
                    chess.PrintBoard(column2, row2, figureName);
                break;
            case "BISHOP":
                Console.WriteLine(bishop.CheckBishopCoord(column1, row1, column2, row2));
                if (bishop.CheckBishopCoord(column1, row1, column2, row2))
                    chess.PrintBoard(column2, row2, figureName);
                break;
            case "QUEEN":
                Console.WriteLine(queen.CheckQueenCoord(column1, row1, column2, row2));
                if (queen.CheckQueenCoord(column1, row1, column2, row2))
                    chess.PrintBoard(column2, row2, figureName);
                break;
            case "KING":
                Console.WriteLine(king.CheckKingCoord(column1, row1, column2, row2));
                if (king.CheckKingCoord(column1, row1, column2, row2))
                    chess.PrintBoard(column2, row2, figureName);
                break;
        }
    }
}
}
