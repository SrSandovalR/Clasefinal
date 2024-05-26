using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clasefinal.Data.DataAcces;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Clasefinal
{
    public partial class Form1 : Form
    {
        Consolas consola;
        model usr = new model();
       
        public Form1()
        {
            
            InitializeComponent();
            consola = new Consolas();
            InicializarComboBox();
        }
        
        private void button2cargar_Click(object sender, EventArgs e)
        {


            DataTable dt = consola.Leerconsolas();
            dataGridView1.DataSource = dt;
        }
        private void label3_Click(object sender, EventArgs e)
                {
                    //Bryan Humberto Sandoval Retana
                    //Carnet 21-10305
            
                }

        


        private void InicializarComboBox()
        {
            comboBox1Fabricantes.Items.Add("Atari");
            comboBox1Fabricantes.Items.Add("Coleco");
            comboBox1Fabricantes.Items.Add("Mattel");
            comboBox1Fabricantes.Items.Add("Microsoft");
            comboBox1Fabricantes.Items.Add("Nintendo");
            comboBox1Fabricantes.Items.Add("Ouya Inc.");
            comboBox1Fabricantes.Items.Add("Sega");
            comboBox1Fabricantes.Items.Add("Sony");
        }
    
    

        private void button1crear_Click(object sender, EventArgs e)
        {
            usr.nombre_consola_= textBox2nombre.Text;
            usr.compania_ = textBox1compania.Text;
            usr.generacion_= int.Parse(textBox3gen.Text);
            usr.anio_lanzamiento_ = dateTimePicker1.Value;
            consola.Insertar(usr);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1actualizar_Click(object sender, EventArgs e)
        {
            usr.nombre_consola_ = textBox2nombre.Text;
            usr.compania_ = textBox1compania.Text;
            usr.generacion_ = int.Parse(textBox3gen.Text);
            usr.anio_lanzamiento_ = dateTimePicker1.Value;
            consola.Actualizar(usr);

        }

        private void button1eliminar_Click(object sender, EventArgs e)
        {
            consola.EliminarRegistroPorId(int.Parse(textBoxID.Text));
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
