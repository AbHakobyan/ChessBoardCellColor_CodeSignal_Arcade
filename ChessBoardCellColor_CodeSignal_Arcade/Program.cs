using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardCellColor_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cell1 = "A5";
            string cell2 = "D4";
            bool x = chessBoardCellColor(cell1, cell2);
            Console.WriteLine(x);
        }

        static bool chessBoardCellColor(string cell1, string cell2)
        {
            int black = 0;
            int white = 0;
            if (cell1 == "A1" || cell1 == "A3" || cell1 == "A5" || cell1 == "A7" ||
                cell1 == "B2" || cell1 == "B4" || cell1 == "B6" || cell1 == "B8" ||
                cell1 == "C1" || cell1 == "C3" || cell1 == "C5" || cell1 == "C7" ||
                cell1 == "D2" || cell1 == "D4" || cell1 == "D6" || cell1 == "D8" ||
                cell1 == "E1" || cell1 == "E3" || cell1 == "E5" || cell1 == "E7" ||
                cell1 == "F2" || cell1 == "F4" || cell1 == "F6" || cell1 == "F8" ||
                cell1 == "G1" || cell1 == "G3" || cell1 == "G5" || cell1 == "G7" ||
                cell1 == "H2" || cell1 == "H4" || cell1 == "H6" || cell1 == "H8")
            {
                black = 1;
            }
            else
            {
                white = 1;
            }
            if (cell2 == "A2" || cell2 == "A4" || cell2 == "A6" || cell2 == "A8" ||
                cell2 == "B1" || cell2 == "B3" || cell2 == "B5" || cell2 == "B7" ||
                cell2 == "C2" || cell2 == "C4" || cell2 == "C6" || cell2 == "C8" ||
                cell2 == "D1" || cell2 == "D3" || cell2 == "D5" || cell2 == "D7" ||
                cell2 == "E2" || cell2 == "E4" || cell2 == "E6" || cell2 == "E8" ||
                cell2 == "F1" || cell2 == "F3" || cell2 == "F5" || cell2 == "F7" ||
                cell2 == "G2" || cell2 == "G4" || cell2 == "G6" || cell2 == "G8" ||
                cell2 == "H1" || cell2 == "H3" || cell2 == "H5" || cell2 == "H7")
            {
                white = 1;
            }
            else
            {
                black = 1;
            }
            if (black == 1 && white == 1)
            {
                return false;
            }
            return true;
        }
    }
}
