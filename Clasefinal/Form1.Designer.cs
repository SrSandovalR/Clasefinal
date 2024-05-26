namespace Clasefinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1Fabricantes = new System.Windows.Forms.ComboBox();
            this.button2cargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1actualizar = new System.Windows.Forms.Button();
            this.button1eliminar = new System.Windows.Forms.Button();
            this.textBox1compania = new System.Windows.Forms.TextBox();
            this.textBox2nombre = new System.Windows.Forms.TextBox();
            this.textBox3gen = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1crear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1Fabricantes
            // 
            this.comboBox1Fabricantes.FormattingEnabled = true;
            this.comboBox1Fabricantes.Location = new System.Drawing.Point(112, 41);
            this.comboBox1Fabricantes.Name = "comboBox1Fabricantes";
            this.comboBox1Fabricantes.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Fabricantes.TabIndex = 0;
            // 
            // button2cargar
            // 
            this.button2cargar.Location = new System.Drawing.Point(12, 31);
            this.button2cargar.Name = "button2cargar";
            this.button2cargar.Size = new System.Drawing.Size(75, 39);
            this.button2cargar.TabIndex = 1;
            this.button2cargar.Text = "Cargar";
            this.button2cargar.UseVisualStyleBackColor = true;
            this.button2cargar.Click += new System.EventHandler(this.button2cargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bryan Humberto Sandoval Retana \r\nCarnet: 10305\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fabricantes de consolas";
            // 
            // button1actualizar
            // 
            this.button1actualizar.Location = new System.Drawing.Point(12, 121);
            this.button1actualizar.Name = "button1actualizar";
            this.button1actualizar.Size = new System.Drawing.Size(75, 39);
            this.button1actualizar.TabIndex = 8;
            this.button1actualizar.Text = "Actualizar";
            this.button1actualizar.UseVisualStyleBackColor = true;
            this.button1actualizar.Click += new System.EventHandler(this.button1actualizar_Click);
            // 
            // button1eliminar
            // 
            this.button1eliminar.Location = new System.Drawing.Point(12, 166);
            this.button1eliminar.Name = "button1eliminar";
            this.button1eliminar.Size = new System.Drawing.Size(75, 39);
            this.button1eliminar.TabIndex = 9;
            this.button1eliminar.Text = "Eliminar";
            this.button1eliminar.UseVisualStyleBackColor = true;
            this.button1eliminar.Click += new System.EventHandler(this.button1eliminar_Click);
            // 
            // textBox1compania
            // 
            this.textBox1compania.Location = new System.Drawing.Point(454, 140);
            this.textBox1compania.Name = "textBox1compania";
            this.textBox1compania.Size = new System.Drawing.Size(200, 20);
            this.textBox1compania.TabIndex = 10;
            // 
            // textBox2nombre
            // 
            this.textBox2nombre.Location = new System.Drawing.Point(454, 67);
            this.textBox2nombre.Name = "textBox2nombre";
            this.textBox2nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox2nombre.TabIndex = 11;
            // 
            // textBox3gen
            // 
            this.textBox3gen.Location = new System.Drawing.Point(454, 297);
            this.textBox3gen.Name = "textBox3gen";
            this.textBox3gen.Size = new System.Drawing.Size(200, 20);
            this.textBox3gen.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Generacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre Consola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anio de Lanzamiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Compania";
            // 
            // button1crear
            // 
            this.button1crear.Location = new System.Drawing.Point(12, 76);
            this.button1crear.Name = "button1crear";
            this.button1crear.Size = new System.Drawing.Size(75, 39);
            this.button1crear.TabIndex = 7;
            this.button1crear.Text = "Crear";
            this.button1crear.UseVisualStyleBackColor = true;
            this.button1crear.Click += new System.EventHandler(this.button1crear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 304);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(454, 374);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 20);
            this.textBoxID.TabIndex = 19;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(710, 642);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3gen);
            this.Controls.Add(this.textBox2nombre);
            this.Controls.Add(this.textBox1compania);
            this.Controls.Add(this.button1eliminar);
            this.Controls.Add(this.button1actualizar);
            this.Controls.Add(this.button1crear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2cargar);
            this.Controls.Add(this.comboBox1Fabricantes);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button buttonconecar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncargar;
        private System.Windows.Forms.DataGridView dataGridViewconsola;
        private System.Windows.Forms.ComboBox comboBoxFabricantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1Fabricantes;
        private System.Windows.Forms.Button button2cargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1actualizar;
        private System.Windows.Forms.Button button1eliminar;
        private System.Windows.Forms.TextBox textBox1compania;
        private System.Windows.Forms.TextBox textBox2nombre;
        private System.Windows.Forms.TextBox textBox3gen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1crear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label9;
    }
}

