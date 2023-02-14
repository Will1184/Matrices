using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia7Ejercicio16
{
    internal class Matriz
    {
        public Matriz() { }

        public void Matrices(Label labelVector1, Label labelVector2, DataGridView dataGridMatriz)
        {
            //CREACION DE VARIBALES
            int sumaVector2 = 0;
            int sumaVector1 = 0;
            int numero = 0;

            int[] vector1 = new int[625];
            int[] vector2 = new int[625];
            //CREACION DE MATRIZ
            int[,] matrices = new int[25, 25];
            //CREACION DE OBJETO DE TIPO RANDOM PARA QUE ESTE DIGITE LOS NUMEROS EN LA MATRIZ
            Random r = new Random();
            //CANTIDAD DE COLUMNAS Y FILAS DEL DATAGRID
            dataGridMatriz.ColumnCount = 25;
            dataGridMatriz.RowCount = 25;
         
           //CICLO QUE GUARDA LOS VALORES LOS NUMEROS RANDOM EN EL INDEX  LA MATRIZ
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    numero = r.Next(1, 100);
                    matrices[i, j] =numero ;
                }
            }
            //CICLOS QUE RECORRE LA MATRIZ
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                for (int j = 0; j < matrices.GetLength(1); j++)
                {
                    //CONDICIONAL QUE GUARDA LOS NUMEROS PAR EN EL VECTOR 1 Y LOS SUMA
                    if ((matrices[i, j] % 2) == 0)
                    {

                        vector1[i] = matrices[i, j];
                        sumaVector1 = sumaVector1 + vector1[i];
                        labelVector1.Text = sumaVector1.ToString();

                    }
                    //SI LA CONDICION ANTERIOR ES FALSA ENTONCES EL NUMERO ES IMPAR POR
                    //LO QUE SE GUARDA EN EL VECTOR2 Y SE CUENTA LA CANTIDAD DE ELEMENTOS EN EL VECTOR
                    else
                    {
                        vector2[i] = matrices[i, j];
                        ++sumaVector2;
                        labelVector2.Text = sumaVector2.ToString();
                    }

                    //SE INGRESA LOS DATOS DE LA MATRIZ EN EL DATAGRID
                    dataGridMatriz.Rows[i].Cells[j].Value = matrices[i, j].ToString();
                }

            }
        }
    }
}
