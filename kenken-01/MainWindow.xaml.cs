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



namespace kenken_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock[,] matrixTb;
        private Button[,] matrixButton;
        private int[,] solutionMatrix;
        int n = 6;
        public MainWindow()
        {
            InitializeComponent();
            CreateMatrix(n);
            CreateButtons();
        }

        private void CreateMatrix(int n)
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
            // stuff
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
                        Text = "",
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
            solutionMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                }
            }
        }

        private void tb_Click(object sender, EventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixTb[i, j].Background = Brushes.White;
                    
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
            
            
        }






    }
}
