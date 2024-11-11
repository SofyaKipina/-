using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного ферзя");
            var blackQueenPosition = Console.ReadLine(); // СЮДА НАДО УСЛОВИЕ НЕ ПОД БОЕМ ЛИ ОНИ У ДРУГ ДРУГА

            Console.WriteLine("Введите позицию хода белой ладьи");
            var move = Console.ReadLine();

            Console.WriteLine(IsWhiteRookMoveCorrect(whiteRookPosition, move, blackQueenPosition));



            Console.ReadKey();
        }
        //static bool IsWhitePownCanStrike(string whitePawnPosition, string position)
        //{
        //    int wpRow, wpColumn, pRow, pColumn;

        //    DecodePosition(whitePawnPosition, out wpColumn, out wpRow);
        //    DecodePosition(position, out pColumn, out pRow);

        //    return wpRow == pRow - 1 && Math.Abs(wpColumn - pColumn) == 1;
        //}

        static bool IsBlackQueenCanStrike(string blackQueenPosition, string position)
        {
            int bpRow, bpColumn, pRow, pColumn;

            DecodePosition(blackQueenPosition, out bpColumn, out bpRow);
            DecodePosition(position, out pColumn, out pRow);

            return bpRow == pRow || bpColumn == pColumn || Math.Abs(bpColumn-pColumn)==Math.Abs(bpRow-pRow);
            // 1. строка и колона равны у новой позиции и черной 2. фигуры находятся на одной диагонали
        }

        static bool IsWhiteRookCanMove(string whiteRookPosition, string move, string blackQueenPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whiteRookPosition, out wc, out wr);
            DecodePosition(blackQueenPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            return IsWhiteRookMoveCorrect(whiteRookPosition, move, blackQueenPosition) &&
                !IsBlackQueenCanStrike(blackQueenPosition, move); 
        }

        static bool IsWhiteRookMoveCorrect(
            string whiteRookPosition, string move, string blackQueenPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whiteRookPosition, out wc, out wr);
            DecodePosition(blackQueenPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            return Math.Abs(wc - mc) == Math.Abs(wr - mr) && Math.Abs(wc - bc) != Math.Abs(wr - br);
            //у меня написано для ладьи и ферзя! 1. на одной диагонали с последущим кодом 2. не на одной диагональю с ферзем
        }


        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }
    }
}
