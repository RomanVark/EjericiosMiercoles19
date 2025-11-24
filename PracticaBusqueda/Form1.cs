using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBusqueda
{
    public partial class FrmPracticaBusqueda : Form
    {
        public FrmPracticaBusqueda()
        {
            InitializeComponent();
        }

        int[] arreglo1 = new int[20];
        Random rnd = new Random();
        private void btnGenerar1_Click(object sender, EventArgs e)
        {
            lstArreglo1.Items.Clear();
            for (int i = 0; i < arreglo1.Length; i++)
            {
                arreglo1[i] = rnd.Next(1, 101);
                lstArreglo1.Items.Add($"Pos {i}: {arreglo1[i]}");
            }
            lblResultado1.Text = "Resultado:";
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar1.Text, out int buscado))
            {
                MessageBox.Show("Ingresa un número válido.");
                return;
            }

            int pos = -1;
            for (int i = 0; i < arreglo1.Length; i++)
            {
                if (arreglo1[i] == buscado)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
                lblResultado1.Text = $"Resultado: Sí existe en posición {pos}.";
            else
                lblResultado1.Text = "Resultado: No existe en el arreglo.";
        }

        List<int> lista2 = new List<int>();

        private void btnGenerar2_Click(object sender, EventArgs e)
        {
            lista2.Clear();
            lstLista2.Items.Clear();
            lstProceso2.Items.Clear();

            for (int i = 0; i < 30; i++)
                lista2.Add(rnd.Next(1, 101));

            lista2.Sort();

            for (int i = 0; i < lista2.Count; i++)
                lstLista2.Items.Add($"Pos {i}: {lista2[i]}");

            lblResultado2.Text = "Resultado: .";
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            lstProceso2.Items.Clear();

            if (!int.TryParse(txtBuscar2.Text, out int buscado))
            {
                MessageBox.Show("Ingresa un número válido.");
                return;
            }

            int ini = 0, fin = lista2.Count - 1;
            int pos = -1;

            while (ini <= fin)
            {
                int mid = (ini + fin) / 2;

                lstProceso2.Items.Add($"INI={ini}, FIN={fin}, MID={mid}, VAL={lista2[mid]}");

                if (lista2[mid] == buscado)
                {
                    pos = mid;
                    break;
                }
                else if (buscado < lista2[mid])
                    fin = mid - 1;
                else
                    ini = mid + 1;
            }

            if (pos != -1)
                lblResultado2.Text = $"Resultado: encontrado en posición {pos}.";
            else
                lblResultado2.Text = "Resultado: No encontrado.";
        }

        private void tabEj3_Click(object sender, EventArgs e)
        {

        }

        /// //////////////////////////////////////////////
        /// 
        private void btnContar3_Click(object sender, EventArgs e)
        {
            string parrafo = txtParrafo3.Text.ToLower();
            string palabra = txtPalabra3.Text.ToLower();

            if (string.IsNullOrWhiteSpace(parrafo) || string.IsNullOrWhiteSpace(palabra))
            {
                MessageBox.Show("Completa párrafo y palabra.");
                return;
            }

            int count = 0;
            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) count++;
            }

            lblResultado3.Text = $"Resultado: aparece {count} veces.";
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        class Estudiante
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        List<Estudiante> estudiantes4 = new List<Estudiante>();


        private void btnGenerar4_Click(object sender, EventArgs e)
        {
            estudiantes4.Clear();
            string[] nombres = { "Ana", "Luis", "Carlos", "Maria", "Jose", "Elena", "Pedro", "Sofia", "Juan", "Diana" };

            for (int i = 0; i < 10; i++)
                estudiantes4.Add(new Estudiante { Id = i + 1, Nombre = nombres[i] });

            dgvEstudiantes4.DataSource = null;
            dgvEstudiantes4.DataSource = estudiantes4;

            lblResultado4.Text = "Resultado: ";
        }

        private void btnBuscarId4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId4.Text, out int idBuscado))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Estudiante encontrado = null;
            foreach (var est in estudiantes4)
            {
                if (est.Id == idBuscado)
                {
                    encontrado = est;
                    break;
                }
            }

            lblResultado4.Text = (encontrado != null)
                ? $"Resultado: {encontrado.Nombre} (ID {encontrado.Id})"
                : "Resultado: no encontrado.";
        }

        private void btnBuscarNom4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId4.Text, out int idBuscado))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Estudiante encontrado = null;
            foreach (var est in estudiantes4)
            {
                if (est.Id == idBuscado)
                {
                    encontrado = est;
                    break;
                }
            }

            lblResultado4.Text = (encontrado != null)
                ? $"Resultado: {encontrado.Nombre} (ID {encontrado.Id})"
                : "Resultado: no encontrado.";
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        int[,] matriz6 = new int[10, 10];

        private void btnGenerar6_Click(object sender, EventArgs e)
        {
            dgvMatriz6.Columns.Clear();
            dgvMatriz6.Rows.Clear();

            for (int c = 0; c < 10; c++)
                dgvMatriz6.Columns.Add("", "");

            dgvMatriz6.Rows.Add(10);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz6[i, j] = rnd.Next(1, 101);
                    dgvMatriz6[j, i].Value = matriz6[i, j];
                }
            }

            lblResultado6.Text = "Resultado: ";
        }

        private void btnBuscar6_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar6.Text, out int buscado))
            {
                MessageBox.Show("Número inválido.");
                return;
            }

            bool encontrado = false;
            int fila = -1, col = -1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz6[i, j] == buscado)
                    {
                        encontrado = true;
                        fila = i; col = j;
                        break;
                    }
                }
                if (encontrado) break;
            }

            if (encontrado)
                lblResultado6.Text = $"Resultado: encontrado en [{fila},{col}].";
            else
                lblResultado6.Text = "Resultado: no encontrado en la matriz.";

        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        List<int> lista5 = new List<int>();

        private void btnGenerar5_Click(object sender, EventArgs e)
        {
            lista5.Clear();
            lstLista5.Items.Clear();

            for (int i = 0; i < 25; i++)
                lista5.Add(rnd.Next(1, 101));

            for (int i = 0; i < lista5.Count; i++)
                lstLista5.Items.Add(lista5[i]);

            lblResultado5.Text = "Resultado: lista generada.";
        }

        private void btnMaxMin5_Click(object sender, EventArgs e)
        {
            if (lista5.Count == 0)
            {
                MessageBox.Show("Primero genera la lista.");
                return;
            }

            int max = lista5[0];
            int min = lista5[0];
            int iter = 0;

            foreach (int n in lista5)
            {
                iter++;
                if (n > max) max = n;
                if (n < min) min = n;
            }

            lblResultado5.Text =
                $"Máximo: {max}\nMínimo: {min}\nIteraciones: {iter}";
        }
    }
}