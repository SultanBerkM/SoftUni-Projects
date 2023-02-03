using System;
using System.Collections.Generic;

namespace _07._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[n, n];

            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for (
                    int k = 0; k < chessBoard.GetLength(1); k++)
                {
                    chessBoard[i, k] = input[k];
                }
            }
            //while attackingKnigh == 0 ! !
            int attackKinigh = 0;
            int rowMostAttacking = 0;
            int colMostAttacking = 0;
            int mostAttackingOne = 0;

            int cnt = 0;

            while (true)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (chessBoard[row, col] == 'K')
                        {
                            if (LeftUp(row, col, n))
                            {
                                if (chessBoard[row - 1, col - 2] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }
                            if (LeftDown(row, col, n))
                            {
                                if (chessBoard[row + 1, col - 2] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }


                            if (DownLeft(row, col, n))
                            {
                                if (chessBoard[row + 2, col - 1] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }
                            if (DownRight(row, col, n))
                            {
                                if (chessBoard[row + 2, col + 1] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }


                            if (RightUp(row, col, n))
                            {
                                if (chessBoard[row - 1, col + 2] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }
                            if (RightDown(row, col, n))
                            {
                                if (chessBoard[row + 1, col + 2] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }

                            if (UpRight(row, col, n))
                            {
                                if (chessBoard[row - 2, col + 1] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }
                            if (UpLeft(row, col, n))
                            {
                                if (chessBoard[row - 2, col - 1] == 'K')
                                {
                                    attackKinigh++;
                                }
                            }

                        }
                        if (attackKinigh > mostAttackingOne)
                        {
                            mostAttackingOne = attackKinigh;
                            rowMostAttacking = row;
                            colMostAttacking = col;
                        }
                        attackKinigh = 0;
                    }
           
                }
                if (mostAttackingOne == 0)
                {
                    Console.WriteLine(cnt);
                    return;
                }
                else
                {
                    cnt++;
                    mostAttackingOne = 0;
                    chessBoard[rowMostAttacking, colMostAttacking] = '0';
                }
            }


        }
        static bool UpLeft(int row, int col, int size)
        {
            if (col - 1 < 0 || row - 2 < 0 || col - 1 >= size || row - 2 >= size)
            {
                return false;
            }
            return true;
        }
        static bool UpRight(int row, int col, int size)
        {
            if (col + 1 < 0 || row - 2 < 0 || col + 1 >= size || row - 2 >= size)
            {
                return false;
            }
            return true;
        }
        static bool RightDown(int row, int col, int size)
        {
            if (col + 2 < 0 || row + 1 < 0 || col + 2 >= size || row + 1 >= size)
            {
                return false;
            }
            return true;
        }

        static bool RightUp(int row, int col, int size)
        {
            if (col + 2 < 0 || row - 1 < 0 || col + 2 >= size || row - 1 >= size)
            {
                return false;
            }
            return true;
        }
        static bool DownRight(int row, int col, int size)
        {
            if (col + 1 < 0 || row + 2 < 0 || col + 1 >= size || row + 2 >= size)
            {
                return false;
            }
            return true;
        }
        static bool DownLeft(int row, int col, int size)
        {
            if (col - 1 < 0 || row + 2 < 0 || col - 1 >= size || row + 2 >= size)
            {
                return false;
            }
            return true;
        }

        static bool LeftUp(int row, int col, int size)
        {
            //moving left up
            if (col - 2 < 0 || row - 1 < 0 || col - 2 >= size || row - 1 >= size)
            {
                return false;
            }
            return true;
        }
        static bool LeftDown(int row, int col, int size)
        {
            //moving left down
            if (col - 2 < 0 || row + 1 < 0 || col - 2 >= size || row + 1 >= size)
            {
                return false;
            }
            return true;
        }

    }
}
