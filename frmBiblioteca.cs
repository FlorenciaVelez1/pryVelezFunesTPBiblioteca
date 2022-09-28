using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace pryVelezFunesTPBiblioteca
{
    public partial class frmBiblioteca : Form
    {
        //Declaracion de variables globales
        public string[,] MatrizLibro = new string[20, 5];
        int IndiceRecorrido = 0;
        char Separador = Convert.ToChar(",");
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            int i = 0;
            StreamReader LectorLibro = new StreamReader("./LIBRO.txt");
            while (!LectorLibro.EndOfStream)
            {
                //Separo los datos dentro del vector
                string[] VectorLibro = LectorLibro.ReadLine().Split(Separador);
                if (i < 20)
                {
                    //Cargar matriz
                    MatrizLibro[i, 0] = VectorLibro[0];
                    MatrizLibro[i, 1] = VectorLibro[1];
                    MatrizLibro[i, 2] = VectorLibro[2];
                    MatrizLibro[i, 3] = VectorLibro[3];
                    MatrizLibro[i, 4] = VectorLibro[4];
                    //Se llaman los procedimientos para cambiar los datos
                    BuscarEditorial(i);
                    BuscarDistribuidora(i);
                    i++;
                }
            }
            LectorLibro.Close();
            txtCodigoLibro.Text = MatrizLibro[0, 0];
            txtNombreLibro.Text = MatrizLibro[0, 1];
            txtEditorial.Text = MatrizLibro[0, 2];
            txtCodigoAutor.Text = MatrizLibro[0, 3];
            txtDistribuidor.Text = MatrizLibro[0, 4];
            cmdAnterior.Enabled = false;
        }
        private void BuscarDistribuidora(int IndiceDistribuidor)
        {
            StreamReader LectorDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");
            while (!LectorDistribuidora.EndOfStream)
            {
                //Se compara los codigos del distribuidor
                string[] vectorDistribuidor = LectorDistribuidora.ReadLine().Split(Separador);
                //Se cambia el codigo por el nombre correspondiente al distribuidor
                if (vectorDistribuidor[0] == MatrizLibro[IndiceDistribuidor, 4])
                {
                    MatrizLibro[IndiceDistribuidor, 4] = vectorDistribuidor[1];
                }
            }
            LectorDistribuidora.Close();
        }
        private void BuscarEditorial(int IndiceEditorial)
        {
            StreamReader LectorEditorial = new StreamReader("./EDITORIAL.txt");
            while (!LectorEditorial.EndOfStream)
            {
                //Se comparan los codigos del editorial
                string[] vectorEditorial = LectorEditorial.ReadLine().Split(Separador);
                if (vectorEditorial[0] == MatrizLibro[IndiceEditorial, 2])
                {
                    MatrizLibro[IndiceEditorial, 2] = vectorEditorial[1];
                }
            }
            LectorEditorial.Close();
        }
        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            IndiceRecorrido++;
            txtCodigoLibro.Text = MatrizLibro[IndiceRecorrido, 0];
            txtNombreLibro.Text = MatrizLibro[IndiceRecorrido, 1];
            txtEditorial.Text = MatrizLibro[IndiceRecorrido, 2];
            txtCodigoAutor.Text = MatrizLibro[IndiceRecorrido, 3];
            txtDistribuidor.Text = MatrizLibro[IndiceRecorrido, 4];
            cmdAnterior.Enabled = true;
            if (IndiceRecorrido == MatrizLibro.GetLength(0) - 1)
            {
                cmdSiguiente.Enabled = false;
            }
        }
        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            //Resta 1 al indice
            IndiceRecorrido--;
            //Si es mayor o igual resta 1
            if (IndiceRecorrido >= 0) 
            {

                txtCodigoLibro.Text = MatrizLibro[IndiceRecorrido, 0];
                txtNombreLibro.Text = MatrizLibro[IndiceRecorrido, 1];
                txtEditorial.Text = MatrizLibro[IndiceRecorrido, 2];
                txtCodigoAutor.Text = MatrizLibro[IndiceRecorrido, 3];
                txtDistribuidor.Text = MatrizLibro[IndiceRecorrido, 4];
                if (IndiceRecorrido == 0)
                {
                    cmdAnterior.Enabled = false;
                }
            }
            else
            {
                cmdAnterior.Enabled = false;
            }
        }
    }   
}
