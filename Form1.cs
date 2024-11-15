using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        int MatrixSize = 0;//розмір матриці
        double[,] matrix;//вхідна матриця
        double[,] L;//нижня трикутна матриця
        double[,] U;//верхня трикутна матриця
        public Form1()
        {
            InitializeComponent();
        }
        void ReadMatrixFromGrid()
        {
            matrix = new double[MatrixSize, MatrixSize + 1];//создаем матрицу

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize + 1; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dgMatrix.Rows[i].Cells[j].Value);//запоминаем значения
                }
            }


            ShowMatrixInGrid();//показываем матрицу

        }


        void ShowMatrixInGrid()
        {
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize + 1; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();//выводим матрицу
                }
            }
        }

        void CreateMatrixTest()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            int i = 0;
            for (i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }

            dgMatrix.Columns.Add("R", "R");

            dgMatrix.Rows.Add(MatrixSize);

            i = 0;
            dgMatrix.Rows[i].Cells[0].Value = "3,51";
            dgMatrix.Rows[i].Cells[1].Value = "0,17";
            dgMatrix.Rows[i].Cells[2].Value = "3,75";
            dgMatrix.Rows[i].Cells[3].Value = "-0,28";
            dgMatrix.Rows[i].Cells[4].Value = "0,75";

            i = 1;
            dgMatrix.Rows[i].Cells[0].Value = "4,52";
            dgMatrix.Rows[i].Cells[1].Value = "2,11";
            dgMatrix.Rows[i].Cells[2].Value = "-0,11";
            dgMatrix.Rows[i].Cells[3].Value = "0,12";
            dgMatrix.Rows[i].Cells[4].Value = "1,11";

            i = 2;
            dgMatrix.Rows[i].Cells[0].Value = "-2,11";
            dgMatrix.Rows[i].Cells[1].Value = "3,17";
            dgMatrix.Rows[i].Cells[2].Value = "0,12";
            dgMatrix.Rows[i].Cells[3].Value = "-0,15";
            dgMatrix.Rows[i].Cells[4].Value = "0,21";

            i = 3;
            dgMatrix.Rows[i].Cells[0].Value = "3,17";
            dgMatrix.Rows[i].Cells[1].Value = "1,81";
            dgMatrix.Rows[i].Cells[2].Value = "-3,17";
            dgMatrix.Rows[i].Cells[3].Value = "0,22";
            dgMatrix.Rows[i].Cells[4].Value = "0,05";


        }

        void CreateMatrix2()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            //int i = 0;
            for (int i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }

            dgMatrix.Columns.Add("R", "R");

            dgMatrix.Rows.Add(MatrixSize);
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize + 1; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = "1"; // записываем значеня в соответсвующие места
                }
            }
        }

        void CreateMatrixL()//функція яка виводить матрицю L
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            //int i = 0;
            //LU();
            for (int i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }


            dgMatrix.Rows.Add(MatrixSize);
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = L[i,j]; // записываем значеня в соответсвующие места
                }
            }
        }

        void CreateMatrixU()//функція яка виводить матрицю U
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            //int i = 0;
            //LU();
            for (int i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }


            dgMatrix.Rows.Add(MatrixSize);
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = U[i, j]; // записываем значеня в соответсвующие места
                }
            }
        }
        void LU()
        {
            matrix = new double[MatrixSize, MatrixSize + 1];
            ReadMatrixFromGrid();
            double[] b = new double[MatrixSize];
            L = new double[MatrixSize, MatrixSize];
            U = new double[MatrixSize, MatrixSize];
            double[] y = new double[MatrixSize];
            double[] x = new double[MatrixSize];
            double S;
            for (int i = 0; i < MatrixSize; i++)
            {
                b[i] = matrix[i, MatrixSize];//заповнюю масив коефіцієнтами вільних членів
            }

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    if (i >= j)
                    {
                        L[i, j] = matrix[i, j];//заповнюю значення матриці L
                    }
                    else
                    {
                        L[i, j] = 0;
                    }

                    if (i < j)
                    {
                        U[i, j] = matrix[i, j];//заповнюю значення матриці U
                    }
                    else
                    {
                        if (i == j)
                        {
                            U[i, j] = 1;
                        }
                        else
                        {
                            U[i, j] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    S = 0;
                    if (i >= j)
                    {
                        for(int k = 0; k<j; k++)//-1
                        {
                            S = S + L[i, k] * U[k, j];
                        }
                        L[i, j] = matrix[i, j] - S;//рахую значення матриці L по формулам
                    }
                    else
                    {
                        for (int k = 0; k < i ; k++)
                        {
                            S = S + L[i, k] * U[k, j];
                        }
                        U[i, j] = (matrix[i, j] - S) / L[i, i]; //рахую значення матриці U по формулам
                    }
                }
            }


            for (int i = 0; i < MatrixSize; i++)
            {
                S = 0;
                for (int j = 0; j < i ; j++)//-1
                {
                    S = S + L[i, j] * y[j];
                }
                y[i] = (b[i] - S) / L[i, i];
            }

            x[MatrixSize - 1] = y[MatrixSize - 1];
            for (int i = MatrixSize - 2; i >= 0; i--) //////////
            {
                S = 0;
                for(int j = i+1; j<MatrixSize; j++)
                {
                    S = S + U[i, j] * x[j];
                }
                x[i] = y[i] - S;
            }

            for(int i = 0; i <MatrixSize; i++)
            {
                listBox1.Items.Add("x" + i.ToString() + " = " + Math.Round(x[i],4));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrixTest();
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            CreateMatrix2();
        }

        private void btnLU_Click(object sender, EventArgs e)
        {
            LU();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            CreateMatrixL();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            CreateMatrixU();
        }
    }
}
