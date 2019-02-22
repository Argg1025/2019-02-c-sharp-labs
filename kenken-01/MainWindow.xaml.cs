using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace kenken_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock[,] matrixTb;
        private Button[,] matrixButton;
        private int[,] solutionMatrix, firstMatrix, checkMatrix;
        private int[,] gridCheck;
        private int[] rowCheck;
        private int[] columnCheck;
        private List<int> numList;
        int n = 9;
        public MainWindow()
        {
            InitializeComponent();
            CreateButtons();
            Trace.WriteLine("something");
        }

        private void CreateMatrix(int[,] matrix, int n)
        {
            //if there is some columns or rows set on the grid we start by clearing them
            if (matrixGrid.ColumnDefinitions.Count > 0)
                matrixGrid.ColumnDefinitions.Clear();
            if (matrixGrid.RowDefinitions.Count > 0)
                matrixGrid.RowDefinitions.Clear();

            
            //Declare and customize your columns
            ColumnDefinition myColumn1 = new ColumnDefinition();
            myColumn1.Name = "Column1";
            matrixGrid.ColumnDefinitions.Add(myColumn1);//Add the column to your grid
            ColumnDefinition myColumn2 = new ColumnDefinition();
            myColumn1.Name = "Column2";
            matrixGrid.ColumnDefinitions.Add(myColumn2);
            ColumnDefinition myColumn3 = new ColumnDefinition();
            myColumn1.Name = "Column3";
            matrixGrid.ColumnDefinitions.Add(myColumn3);

            //Declare and customize your rows
            RowDefinition myRow1 = new RowDefinition();
            myColumn1.Name = "Row1";
            matrixGrid.RowDefinitions.Add(myRow1);
            RowDefinition myRow2 = new RowDefinition();
            myColumn1.Name = "Row2";
            matrixGrid.RowDefinitions.Add(myRow2);
            RowDefinition myRow3 = new RowDefinition();
            myColumn1.Name = "Row3";
            matrixGrid.RowDefinitions.Add(myRow3);

            if (n == 4)//if we need 4*4 matrice then add another column
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
            }
            else if (n == 5)
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
                ColumnDefinition myColumn5 = new ColumnDefinition();
                myColumn1.Name = "Column5";
                matrixGrid.ColumnDefinitions.Add(myColumn5);
                RowDefinition myRow5 = new RowDefinition();
                myRow1.Name = "Row5";
                matrixGrid.RowDefinitions.Add(myRow5);
            }
            else if (n == 6)
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
                ColumnDefinition myColumn5 = new ColumnDefinition();
                myColumn1.Name = "Column5";
                matrixGrid.ColumnDefinitions.Add(myColumn5);
                RowDefinition myRow5 = new RowDefinition();
                myRow1.Name = "Row5";
                matrixGrid.RowDefinitions.Add(myRow5);
                ColumnDefinition myColumn6 = new ColumnDefinition();
                myColumn1.Name = "Column6";
                matrixGrid.ColumnDefinitions.Add(myColumn6);
                RowDefinition myRow6 = new RowDefinition();
                myRow1.Name = "Row6";
                matrixGrid.RowDefinitions.Add(myRow6);
            }
            else if (n == 7)
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
                ColumnDefinition myColumn5 = new ColumnDefinition();
                myColumn1.Name = "Column5";
                matrixGrid.ColumnDefinitions.Add(myColumn5);
                RowDefinition myRow5 = new RowDefinition();
                myRow1.Name = "Row5";
                matrixGrid.RowDefinitions.Add(myRow5);
                ColumnDefinition myColumn6 = new ColumnDefinition();
                myColumn1.Name = "Column6";
                matrixGrid.ColumnDefinitions.Add(myColumn6);
                RowDefinition myRow6 = new RowDefinition();
                myRow1.Name = "Row6";
                matrixGrid.RowDefinitions.Add(myRow6);
                ColumnDefinition myColumn7 = new ColumnDefinition();
                myColumn1.Name = "Column7";
                matrixGrid.ColumnDefinitions.Add(myColumn7);
                RowDefinition myRow7 = new RowDefinition();
                myRow1.Name = "Row7";
                matrixGrid.RowDefinitions.Add(myRow7);
            }
            else if (n == 8)
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
                ColumnDefinition myColumn5 = new ColumnDefinition();
                myColumn1.Name = "Column5";
                matrixGrid.ColumnDefinitions.Add(myColumn5);
                RowDefinition myRow5 = new RowDefinition();
                myRow1.Name = "Row5";
                matrixGrid.RowDefinitions.Add(myRow5);
                ColumnDefinition myColumn6 = new ColumnDefinition();
                myColumn1.Name = "Column6";
                matrixGrid.ColumnDefinitions.Add(myColumn6);
                RowDefinition myRow6 = new RowDefinition();
                myRow1.Name = "Row6";
                matrixGrid.RowDefinitions.Add(myRow6);
                ColumnDefinition myColumn7 = new ColumnDefinition();
                myColumn1.Name = "Column7";
                matrixGrid.ColumnDefinitions.Add(myColumn7);
                RowDefinition myRow7 = new RowDefinition();
                myRow1.Name = "Row7";
                matrixGrid.RowDefinitions.Add(myRow7);
                ColumnDefinition myColumn8 = new ColumnDefinition();
                myColumn1.Name = "Column8";
                matrixGrid.ColumnDefinitions.Add(myColumn8);
                RowDefinition myRow8 = new RowDefinition();
                myRow1.Name = "Row8";
                matrixGrid.RowDefinitions.Add(myRow8);
            }
            else if (n == 9)
            {
                ColumnDefinition myColumn4 = new ColumnDefinition();
                myColumn1.Name = "Column4";
                matrixGrid.ColumnDefinitions.Add(myColumn4);
                RowDefinition myRow4 = new RowDefinition();
                myRow1.Name = "Row4";
                matrixGrid.RowDefinitions.Add(myRow4);
                ColumnDefinition myColumn5 = new ColumnDefinition();
                myColumn1.Name = "Column5";
                matrixGrid.ColumnDefinitions.Add(myColumn5);
                RowDefinition myRow5 = new RowDefinition();
                myRow1.Name = "Row5";
                matrixGrid.RowDefinitions.Add(myRow5);
                ColumnDefinition myColumn6 = new ColumnDefinition();
                myColumn1.Name = "Column6";
                matrixGrid.ColumnDefinitions.Add(myColumn6);
                RowDefinition myRow6 = new RowDefinition();
                myRow1.Name = "Row6";
                matrixGrid.RowDefinitions.Add(myRow6);
                ColumnDefinition myColumn7 = new ColumnDefinition();
                myColumn1.Name = "Column7";
                matrixGrid.ColumnDefinitions.Add(myColumn7);
                RowDefinition myRow7 = new RowDefinition();
                myRow1.Name = "Row7";
                matrixGrid.RowDefinitions.Add(myRow7);
                ColumnDefinition myColumn8 = new ColumnDefinition();
                myColumn1.Name = "Column8";
                matrixGrid.ColumnDefinitions.Add(myColumn8);
                RowDefinition myRow8 = new RowDefinition();
                myRow1.Name = "Row8";
                matrixGrid.RowDefinitions.Add(myRow8);
                ColumnDefinition myColumn9 = new ColumnDefinition();
                myColumn1.Name = "Column9";
                matrixGrid.ColumnDefinitions.Add(myColumn9);
                RowDefinition myRow9 = new RowDefinition();
                myRow1.Name = "Row9";
                matrixGrid.RowDefinitions.Add(myRow9);
            }

            matrixTb = new TextBlock[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixTb[i, j] = new TextBlock
                    {
                        FontSize = 50,
                        Text = matrix[i,j].ToString(),
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        TextAlignment = TextAlignment.Center,
                        Width = 70,
                        Height = 70
                };
                   
                    Grid.SetRow(matrixTb[i, j], i);
                    Grid.SetColumn(matrixTb[i, j], j);
                    matrixGrid.Children.Add(matrixTb[i, j]);
                    matrixTb[i, j].MouseDown += tb_Click;
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    if (matrixTb[k,l].Text == "0")
                    {
                        matrixTb[k, l].Text = "";
                    }
                }
            }
        }

        private void CreateButtons()
        {
            ColumnDefinition myColumn1 = new ColumnDefinition();
            myColumn1.Name = "Column1";
            buttonGrid.ColumnDefinitions.Add(myColumn1);
            ColumnDefinition myColumn2 = new ColumnDefinition();
            myColumn1.Name = "Column2";
            buttonGrid.ColumnDefinitions.Add(myColumn2);
            ColumnDefinition myColumn3 = new ColumnDefinition();
            myColumn1.Name = "Column3";
            buttonGrid.ColumnDefinitions.Add(myColumn3);

            RowDefinition myRow1 = new RowDefinition();
            myColumn1.Name = "Row1";
            buttonGrid.RowDefinitions.Add(myRow1);
            RowDefinition myRow2 = new RowDefinition();
            myColumn1.Name = "Row2";
            buttonGrid.RowDefinitions.Add(myRow2);
            RowDefinition myRow3 = new RowDefinition();
            myColumn1.Name = "Row3";
            buttonGrid.RowDefinitions.Add(myRow3);

            int counter = 1;
            matrixButton = new Button[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixButton[i, j] = new Button
                    {
                        FontSize = 10,
                        Content = counter.ToString(),
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = 50,
                        Width  = 50
                    };
                    Grid.SetRow(matrixButton[i, j], i);
                    Grid.SetColumn(matrixButton[i, j], j);
                    buttonGrid.Children.Add(matrixButton[i, j]);
                    matrixButton[i, j].Click += button_Click;
                    counter++;

                }
            }
        }

        private void SudokuGenerator()
        {
            numList = new List<int>();
            Random random = new Random();
            solutionMatrix = new int[n, n];
            gridCheck = new int[3, 3];
            rowCheck = new int[n];
            columnCheck = new int[n];
            solutionMatrix = new int[9, 9]
            {
                                {1,2,3,4,5,6,7,8,9},
                                {2,3,4,5,6,7,8,9,1},
                                {3,4,5,6,7,8,9,1,2},
                                {4,5,6,7,8,9,1,2,3},
                                {5,6,7,8,9,1,2,3,4},
                                {6,7,8,9,1,2,3,4,5},
                                {7,8,9,1,2,3,4,5,6},
                                {8,9,1,2,3,4,5,6,7},
                                {9,1,2,3,4,5,6,7,8}
            };

            bool notBored = true;
            while (notBored)
            {
                int row1 = random.Next(9);
                int row2 = random.Next(8);
                row2 += row2 >= row1 ? 1 : 0;
                solutionMatrix = SwapRowsMatrix(solutionMatrix, row1, row2);

                int col1 = random.Next(9);
                int col2 = random.Next(8);
                col2 += col2 >= col1 ? 1 : 0;
                solutionMatrix = SwapColsMatrix(solutionMatrix, col1, col2);

                notBored = !CheckValidSudoku(solutionMatrix);
            }
        }

        private void EasyMode()
        {
            solutionMatrix = new int[9, 9]{
                                {8,4,6,9,3,7,1,5,2},
                                {3,1,9,6,2,5,8,4,7},
                                {7,5,2,1,8,4,9,6,3},
                                {2,8,5,7,1,3,6,9,4},
                                {4,6,3,8,5,9,2,7,1},
                                {9,7,1,2,4,6,3,8,5},
                                {1,2,7,5,9,8,4,3,6},
                                {6,3,8,4,7,1,5,2,9},
                                {5,9,4,3,6,2,7,1,8}
                            };
            
            firstMatrix = new int[9, 9]{
                                {8,0,0,9,3,0,0,0,2},
                                {0,0,9,0,0,0,0,4,0},
                                {7,0,2,1,0,0,9,6,0},
                                {0,0,0,0,0,0,0,9,0},
                                {0,6,0,0,0,0,0,7,0},
                                {0,7,0,0,0,6,0,0,5},
                                {0,2,7,0,0,8,4,0,6},
                                {0,3,0,0,0,0,5,0,0},
                                {5,0,0,0,6,2,0,0,8}
                            };
        }

        private void EasyMode2()
        {
            solutionMatrix = new int[9, 9]{
                                {8,4,6,9,3,7,1,5,2},
                                {3,1,9,6,2,5,8,4,7},
                                {7,5,2,1,8,4,9,6,3},
                                {2,8,5,7,1,3,6,9,4},
                                {4,6,3,8,5,9,2,7,1},
                                {9,7,1,2,4,6,3,8,5},
                                {1,2,7,5,9,8,4,3,6},
                                {6,3,8,4,7,1,5,2,9},
                                {5,9,4,3,6,2,7,1,8}
                            };
            firstMatrix = new int[9, 9]{
                                {8,0,6,9,3,7,1,5,2},
                                {3,1,9,6,2,5,8,4,7},
                                {7,5,2,1,8,4,9,6,3},
                                {2,8,5,7,1,3,6,9,4},
                                {4,6,3,8,5,9,2,7,1},
                                {9,7,1,2,4,6,3,8,5},
                                {1,2,7,5,9,8,4,3,6},
                                {6,3,8,4,7,1,5,2,9},
                                {5,9,4,3,6,2,7,1,8}
                            };
           
        }

        private void tb_Click(object sender, EventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixTb[i, j].Background = Brushes.BlueViolet;
                }
            }
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixTb[i, j].Background = Brushes.White;
                }
            }
            for (int i = 6; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixTb[i, j].Background = Brushes.BlueViolet;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    matrixTb[i, j].Background = Brushes.White;
                }
            }
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    matrixTb[i, j].Background = Brushes.BlueViolet;
                }
            }
            for (int i = 6; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    matrixTb[i, j].Background = Brushes.White;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    matrixTb[i, j].Background = Brushes.BlueViolet;
                }
            }
            for (int i = 3; i < 6; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    matrixTb[i, j].Background = Brushes.White;
                }
            }
            for (int i = 6; i < 9; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    matrixTb[i, j].Background = Brushes.BlueViolet;
                }
            }
            tb.Background = Brushes.Yellow;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrixTb[i, j].Background == Brushes.Yellow)
                    {
                        matrixTb[i, j].Text = btn.Content.ToString();
                    }
                }
            }
            WinCheck();
        }

        private void WinCheck()
        {
            int winCount = 0;
            checkMatrix = new int[n, n];
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    if (matrixTb[k, l].Text == "")
                    {
                        checkMatrix[k, l] = 0;
                    }
                    else
                    {
                        checkMatrix[k, l] = Convert.ToInt32(matrixTb[k, l].Text);
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (solutionMatrix[i,j] == checkMatrix[i, j])
                    {
                        winCount++;
                    }
                }
            }
            if (winCount == 81)
            {
                WinTb.Text = "You Win!!!";
            }
        }

        private int[,] SwapRowsMatrix(int[,] matrix, int row1, int row2)
        {
            int matrixRowSize = matrix.GetLength(0);
            if (matrixRowSize >= row1 && matrixRowSize >= row2)
            {
                int tempNum = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    tempNum = matrix[row1, i];
                    matrix[row1, i] = matrix[row2, i];
                    matrix[row2, i] = tempNum;
                }
            }

            return matrix;
        }

        private int[,] SwapColsMatrix(int[,] matrix, int col1, int col2)
        {
            int matrixColSize = matrix.GetLength(1);
            if (matrixColSize >= col1 && matrixColSize >= col2)
            {
                int tempNum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    tempNum = matrix[i, col1];
                    matrix[i, col1] = matrix[i, col2];
                    matrix[i, col2] = tempNum;
                }
            }

            return matrix;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EasyMode();
            CreateMatrix(firstMatrix, n);
            Easy.Visibility = Visibility.Hidden;
            Easy2.Visibility = Visibility.Hidden;
            Random.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EasyMode2();
            CreateMatrix(firstMatrix, n);
            Easy.Visibility = Visibility.Hidden;
            Easy2.Visibility = Visibility.Hidden;
            Random.Visibility = Visibility.Hidden;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SudokuGenerator();
            CreateMatrix(solutionMatrix, n);
            Easy.Visibility = Visibility.Hidden;
            Easy2.Visibility = Visibility.Hidden;
            Random.Visibility = Visibility.Hidden;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            ClearBoard();
            Easy.Visibility = Visibility.Visible;
            Easy2.Visibility = Visibility.Visible;
            Random.Visibility = Visibility.Visible;

        }

        private void ClearBoard()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixTb[i, j].Text = "";
                }
            }

            WinTb.Text = "";
        }

        private bool CheckValidSudoku(int[,] matrix)
        {
            bool validMiniGrid = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    validMiniGrid = CheckValidMiniSudoku(matrix, i * 3, j * 3);

                    if (!validMiniGrid)
                    {
                        break;
                    }
                }

                if (!validMiniGrid)
                {
                    break;
                }
            }

            return validMiniGrid;
        }

        private bool CheckValidMiniSudoku(int[,] matrix, int startLeftIndex, int startTopIndex)
        {
            bool validMiniGrid = true;

            List<int> valuesFound = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int valueFound = matrix[i + startLeftIndex, j + startTopIndex];
                    if (valuesFound.Contains(valueFound))
                    {
                        validMiniGrid = false;
                    }
                    else
                    {
                        valuesFound.Add(valueFound);
                    }

                    if (!validMiniGrid)
                    {
                        break;
                    }
                }

                if (!validMiniGrid)
                {
                    break;
                }
            }

            return validMiniGrid;
        }



    }
}
