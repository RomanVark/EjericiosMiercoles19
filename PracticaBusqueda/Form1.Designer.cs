namespace PracticaBusqueda
{
    partial class FrmPracticaBusqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEj1 = new System.Windows.Forms.TabPage();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.btnGenerar1 = new System.Windows.Forms.Button();
            this.lstArreglo1 = new System.Windows.Forms.ListBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.tabEj2 = new System.Windows.Forms.TabPage();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.lstProceso2 = new System.Windows.Forms.ListBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.btnGenerar2 = new System.Windows.Forms.Button();
            this.lstLista2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEj3 = new System.Windows.Forms.TabPage();
            this.lblParrafo3 = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.tabEj4 = new System.Windows.Forms.TabPage();
            this.tabEj5 = new System.Windows.Forms.TabPage();
            this.tabEj6 = new System.Windows.Forms.TabPage();
            this.txtParrafo3 = new System.Windows.Forms.TextBox();
            this.lblPalabra3 = new System.Windows.Forms.Label();
            this.txtPalabra3 = new System.Windows.Forms.TextBox();
            this.btnContar3 = new System.Windows.Forms.Button();
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.dgvEstudiantes4 = new System.Windows.Forms.DataGridView();
            this.btnGenerar4 = new System.Windows.Forms.Button();
            this.lblId4 = new System.Windows.Forms.Label();
            this.txtId4 = new System.Windows.Forms.TextBox();
            this.btnBuscarId4 = new System.Windows.Forms.Button();
            this.lblNombre4 = new System.Windows.Forms.Label();
            this.txtNombre4 = new System.Windows.Forms.TextBox();
            this.btnBuscarNom4 = new System.Windows.Forms.Button();
            this.lblResultado4 = new System.Windows.Forms.Label();
            this.lblTitulo5 = new System.Windows.Forms.Label();
            this.lstLista5 = new System.Windows.Forms.ListBox();
            this.btnGenerar5 = new System.Windows.Forms.Button();
            this.btnMaxMin5 = new System.Windows.Forms.Button();
            this.lblResultado5 = new System.Windows.Forms.Label();
            this.lblTitulo6 = new System.Windows.Forms.Label();
            this.dgvMatriz6 = new System.Windows.Forms.DataGridView();
            this.btnGenerar6 = new System.Windows.Forms.Button();
            this.lblBuscar6 = new System.Windows.Forms.Label();
            this.txtBuscar6 = new System.Windows.Forms.TextBox();
            this.btnBuscar6 = new System.Windows.Forms.Button();
            this.lblResultado6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEj1.SuspendLayout();
            this.tabEj2.SuspendLayout();
            this.tabEj3.SuspendLayout();
            this.tabEj4.SuspendLayout();
            this.tabEj5.SuspendLayout();
            this.tabEj6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEj1);
            this.tabControl1.Controls.Add(this.tabEj2);
            this.tabControl1.Controls.Add(this.tabEj3);
            this.tabControl1.Controls.Add(this.tabEj4);
            this.tabControl1.Controls.Add(this.tabEj5);
            this.tabControl1.Controls.Add(this.tabEj6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEj1
            // 
            this.tabEj1.Controls.Add(this.lblResultado1);
            this.tabEj1.Controls.Add(this.btnBuscar1);
            this.tabEj1.Controls.Add(this.txtBuscar1);
            this.tabEj1.Controls.Add(this.lblBuscar1);
            this.tabEj1.Controls.Add(this.btnGenerar1);
            this.tabEj1.Controls.Add(this.lstArreglo1);
            this.tabEj1.Controls.Add(this.lblTitulo1);
            this.tabEj1.Location = new System.Drawing.Point(4, 22);
            this.tabEj1.Name = "tabEj1";
            this.tabEj1.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj1.Size = new System.Drawing.Size(876, 585);
            this.tabEj1.TabIndex = 0;
            this.tabEj1.Text = "Ejercicio 1";
            this.tabEj1.UseVisualStyleBackColor = true;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(300, 220);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(58, 13);
            this.lblResultado1.TabIndex = 6;
            this.lblResultado1.Text = "Resultado:";
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(300, 160);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar1.TabIndex = 5;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(420, 115);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar1.TabIndex = 4;
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Location = new System.Drawing.Point(300, 120);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(91, 13);
            this.lblBuscar1.TabIndex = 3;
            this.lblBuscar1.Text = "Número a buscar:";
            // 
            // btnGenerar1
            // 
            this.btnGenerar1.Location = new System.Drawing.Point(300, 60);
            this.btnGenerar1.Name = "btnGenerar1";
            this.btnGenerar1.Size = new System.Drawing.Size(150, 40);
            this.btnGenerar1.TabIndex = 2;
            this.btnGenerar1.Text = "Generar Arreglo";
            this.btnGenerar1.UseVisualStyleBackColor = true;
            this.btnGenerar1.Click += new System.EventHandler(this.btnGenerar1_Click);
            // 
            // lstArreglo1
            // 
            this.lstArreglo1.FormattingEnabled = true;
            this.lstArreglo1.Location = new System.Drawing.Point(20, 60);
            this.lstArreglo1.Name = "lstArreglo1";
            this.lstArreglo1.Size = new System.Drawing.Size(250, 394);
            this.lstArreglo1.TabIndex = 1;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(322, 21);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Arreglo de 20 números y búsqueda lineal";
            // 
            // tabEj2
            // 
            this.tabEj2.Controls.Add(this.lblResultado2);
            this.tabEj2.Controls.Add(this.lstProceso2);
            this.tabEj2.Controls.Add(this.btnBuscar2);
            this.tabEj2.Controls.Add(this.txtBuscar2);
            this.tabEj2.Controls.Add(this.lblBuscar2);
            this.tabEj2.Controls.Add(this.btnGenerar2);
            this.tabEj2.Controls.Add(this.lstLista2);
            this.tabEj2.Controls.Add(this.label1);
            this.tabEj2.Location = new System.Drawing.Point(4, 22);
            this.tabEj2.Name = "tabEj2";
            this.tabEj2.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj2.Size = new System.Drawing.Size(876, 585);
            this.tabEj2.TabIndex = 1;
            this.tabEj2.Text = "Ejercicio 2";
            this.tabEj2.UseVisualStyleBackColor = true;
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(300, 220);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(58, 13);
            this.lblResultado2.TabIndex = 7;
            this.lblResultado2.Text = "Resultado:";
            // 
            // lstProceso2
            // 
            this.lstProceso2.FormattingEnabled = true;
            this.lstProceso2.Location = new System.Drawing.Point(559, 60);
            this.lstProceso2.Name = "lstProceso2";
            this.lstProceso2.Size = new System.Drawing.Size(291, 394);
            this.lstProceso2.TabIndex = 6;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(300, 160);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(170, 40);
            this.btnBuscar2.TabIndex = 5;
            this.btnBuscar2.Text = "Buscar Binaria";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(430, 115);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar2.TabIndex = 4;
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Location = new System.Drawing.Point(300, 120);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(91, 13);
            this.lblBuscar2.TabIndex = 3;
            this.lblBuscar2.Text = "Número a buscar:";
            // 
            // btnGenerar2
            // 
            this.btnGenerar2.Location = new System.Drawing.Point(300, 60);
            this.btnGenerar2.Name = "btnGenerar2";
            this.btnGenerar2.Size = new System.Drawing.Size(170, 40);
            this.btnGenerar2.TabIndex = 2;
            this.btnGenerar2.Text = "Generar y Ordenar";
            this.btnGenerar2.UseVisualStyleBackColor = true;
            this.btnGenerar2.Click += new System.EventHandler(this.btnGenerar2_Click);
            // 
            // lstLista2
            // 
            this.lstLista2.FormattingEnabled = true;
            this.lstLista2.Location = new System.Drawing.Point(20, 60);
            this.lstLista2.Name = "lstLista2";
            this.lstLista2.Size = new System.Drawing.Size(250, 394);
            this.lstLista2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de 30 números + ordenamiento + búsqueda binaria";
            // 
            // tabEj3
            // 
            this.tabEj3.Controls.Add(this.lblResultado3);
            this.tabEj3.Controls.Add(this.btnContar3);
            this.tabEj3.Controls.Add(this.txtPalabra3);
            this.tabEj3.Controls.Add(this.lblPalabra3);
            this.tabEj3.Controls.Add(this.txtParrafo3);
            this.tabEj3.Controls.Add(this.lblParrafo3);
            this.tabEj3.Controls.Add(this.lblTitulo3);
            this.tabEj3.Location = new System.Drawing.Point(4, 22);
            this.tabEj3.Name = "tabEj3";
            this.tabEj3.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj3.Size = new System.Drawing.Size(876, 585);
            this.tabEj3.TabIndex = 2;
            this.tabEj3.Text = "Ejercicio 3";
            this.tabEj3.UseVisualStyleBackColor = true;
            this.tabEj3.Click += new System.EventHandler(this.tabEj3_Click);
            // 
            // lblParrafo3
            // 
            this.lblParrafo3.AutoSize = true;
            this.lblParrafo3.Location = new System.Drawing.Point(20, 60);
            this.lblParrafo3.Name = "lblParrafo3";
            this.lblParrafo3.Size = new System.Drawing.Size(44, 13);
            this.lblParrafo3.TabIndex = 1;
            this.lblParrafo3.Text = "Párrafo:";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(299, 21);
            this.lblTitulo3.TabIndex = 0;
            this.lblTitulo3.Text = "Búsqueda manual de palabra en texto";
            // 
            // tabEj4
            // 
            this.tabEj4.Controls.Add(this.lblResultado4);
            this.tabEj4.Controls.Add(this.btnBuscarNom4);
            this.tabEj4.Controls.Add(this.txtNombre4);
            this.tabEj4.Controls.Add(this.lblNombre4);
            this.tabEj4.Controls.Add(this.btnBuscarId4);
            this.tabEj4.Controls.Add(this.txtId4);
            this.tabEj4.Controls.Add(this.lblId4);
            this.tabEj4.Controls.Add(this.btnGenerar4);
            this.tabEj4.Controls.Add(this.dgvEstudiantes4);
            this.tabEj4.Controls.Add(this.lblTitulo4);
            this.tabEj4.Location = new System.Drawing.Point(4, 22);
            this.tabEj4.Name = "tabEj4";
            this.tabEj4.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj4.Size = new System.Drawing.Size(876, 585);
            this.tabEj4.TabIndex = 3;
            this.tabEj4.Text = "Ejercicio 4";
            this.tabEj4.UseVisualStyleBackColor = true;
            // 
            // tabEj5
            // 
            this.tabEj5.Controls.Add(this.lblResultado5);
            this.tabEj5.Controls.Add(this.btnMaxMin5);
            this.tabEj5.Controls.Add(this.btnGenerar5);
            this.tabEj5.Controls.Add(this.lstLista5);
            this.tabEj5.Controls.Add(this.lblTitulo5);
            this.tabEj5.Location = new System.Drawing.Point(4, 22);
            this.tabEj5.Name = "tabEj5";
            this.tabEj5.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj5.Size = new System.Drawing.Size(876, 585);
            this.tabEj5.TabIndex = 4;
            this.tabEj5.Text = "Ejercicio 5";
            this.tabEj5.UseVisualStyleBackColor = true;
            // 
            // tabEj6
            // 
            this.tabEj6.Controls.Add(this.lblResultado6);
            this.tabEj6.Controls.Add(this.btnBuscar6);
            this.tabEj6.Controls.Add(this.txtBuscar6);
            this.tabEj6.Controls.Add(this.lblBuscar6);
            this.tabEj6.Controls.Add(this.btnGenerar6);
            this.tabEj6.Controls.Add(this.dgvMatriz6);
            this.tabEj6.Controls.Add(this.lblTitulo6);
            this.tabEj6.Location = new System.Drawing.Point(4, 22);
            this.tabEj6.Name = "tabEj6";
            this.tabEj6.Padding = new System.Windows.Forms.Padding(3);
            this.tabEj6.Size = new System.Drawing.Size(876, 585);
            this.tabEj6.TabIndex = 5;
            this.tabEj6.Text = "Ejercicio 6";
            this.tabEj6.UseVisualStyleBackColor = true;
            // 
            // txtParrafo3
            // 
            this.txtParrafo3.Location = new System.Drawing.Point(20, 90);
            this.txtParrafo3.Multiline = true;
            this.txtParrafo3.Name = "txtParrafo3";
            this.txtParrafo3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParrafo3.Size = new System.Drawing.Size(500, 200);
            this.txtParrafo3.TabIndex = 2;
            // 
            // lblPalabra3
            // 
            this.lblPalabra3.AutoSize = true;
            this.lblPalabra3.Location = new System.Drawing.Point(20, 310);
            this.lblPalabra3.Name = "lblPalabra3";
            this.lblPalabra3.Size = new System.Drawing.Size(46, 13);
            this.lblPalabra3.TabIndex = 3;
            this.lblPalabra3.Text = "Palabra:";
            // 
            // txtPalabra3
            // 
            this.txtPalabra3.Location = new System.Drawing.Point(90, 305);
            this.txtPalabra3.Name = "txtPalabra3";
            this.txtPalabra3.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra3.TabIndex = 4;
            // 
            // btnContar3
            // 
            this.btnContar3.Location = new System.Drawing.Point(220, 300);
            this.btnContar3.Name = "btnContar3";
            this.btnContar3.Size = new System.Drawing.Size(170, 40);
            this.btnContar3.TabIndex = 5;
            this.btnContar3.Text = "Contar Apariciones";
            this.btnContar3.UseVisualStyleBackColor = true;
            this.btnContar3.Click += new System.EventHandler(this.btnContar3_Click);
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Location = new System.Drawing.Point(20, 360);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(58, 13);
            this.lblResultado3.TabIndex = 6;
            this.lblResultado3.Text = "Resultado:";
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo4.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(220, 21);
            this.lblTitulo4.TabIndex = 0;
            this.lblTitulo4.Text = "Sección lista de estudiantes";
            // 
            // dgvEstudiantes4
            // 
            this.dgvEstudiantes4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes4.Location = new System.Drawing.Point(20, 60);
            this.dgvEstudiantes4.Name = "dgvEstudiantes4";
            this.dgvEstudiantes4.ReadOnly = true;
            this.dgvEstudiantes4.Size = new System.Drawing.Size(400, 350);
            this.dgvEstudiantes4.TabIndex = 1;
            // 
            // btnGenerar4
            // 
            this.btnGenerar4.Location = new System.Drawing.Point(450, 60);
            this.btnGenerar4.Name = "btnGenerar4";
            this.btnGenerar4.Size = new System.Drawing.Size(170, 40);
            this.btnGenerar4.TabIndex = 2;
            this.btnGenerar4.Text = "Cargar Estudiantes";
            this.btnGenerar4.UseVisualStyleBackColor = true;
            this.btnGenerar4.Click += new System.EventHandler(this.btnGenerar4_Click);
            // 
            // lblId4
            // 
            this.lblId4.AutoSize = true;
            this.lblId4.Location = new System.Drawing.Point(450, 130);
            this.lblId4.Name = "lblId4";
            this.lblId4.Size = new System.Drawing.Size(57, 13);
            this.lblId4.TabIndex = 3;
            this.lblId4.Text = "Buscar ID:";
            // 
            // txtId4
            // 
            this.txtId4.Location = new System.Drawing.Point(520, 125);
            this.txtId4.Name = "txtId4";
            this.txtId4.Size = new System.Drawing.Size(100, 20);
            this.txtId4.TabIndex = 4;
            // 
            // btnBuscarId4
            // 
            this.btnBuscarId4.Location = new System.Drawing.Point(450, 160);
            this.btnBuscarId4.Name = "btnBuscarId4";
            this.btnBuscarId4.Size = new System.Drawing.Size(170, 40);
            this.btnBuscarId4.TabIndex = 5;
            this.btnBuscarId4.Text = "Buscar Lineal";
            this.btnBuscarId4.UseVisualStyleBackColor = true;
            this.btnBuscarId4.Click += new System.EventHandler(this.btnBuscarId4_Click);
            // 
            // lblNombre4
            // 
            this.lblNombre4.AutoSize = true;
            this.lblNombre4.Location = new System.Drawing.Point(450, 230);
            this.lblNombre4.Name = "lblNombre4";
            this.lblNombre4.Size = new System.Drawing.Size(83, 13);
            this.lblNombre4.TabIndex = 6;
            this.lblNombre4.Text = "Buscar Nombre:";
            // 
            // txtNombre4
            // 
            this.txtNombre4.Location = new System.Drawing.Point(560, 225);
            this.txtNombre4.Name = "txtNombre4";
            this.txtNombre4.Size = new System.Drawing.Size(100, 20);
            this.txtNombre4.TabIndex = 7;
            // 
            // btnBuscarNom4
            // 
            this.btnBuscarNom4.Location = new System.Drawing.Point(450, 260);
            this.btnBuscarNom4.Name = "btnBuscarNom4";
            this.btnBuscarNom4.Size = new System.Drawing.Size(170, 40);
            this.btnBuscarNom4.TabIndex = 8;
            this.btnBuscarNom4.Text = "Buscar Binaria";
            this.btnBuscarNom4.UseVisualStyleBackColor = true;
            this.btnBuscarNom4.Click += new System.EventHandler(this.btnBuscarNom4_Click);
            // 
            // lblResultado4
            // 
            this.lblResultado4.AutoSize = true;
            this.lblResultado4.Location = new System.Drawing.Point(450, 320);
            this.lblResultado4.Name = "lblResultado4";
            this.lblResultado4.Size = new System.Drawing.Size(58, 13);
            this.lblResultado4.TabIndex = 9;
            this.lblResultado4.Text = "Resultado:";
            // 
            // lblTitulo5
            // 
            this.lblTitulo5.AutoSize = true;
            this.lblTitulo5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo5.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo5.Name = "lblTitulo5";
            this.lblTitulo5.Size = new System.Drawing.Size(299, 21);
            this.lblTitulo5.TabIndex = 0;
            this.lblTitulo5.Text = "Máximo, mínimo y conteo iteraciones";
            // 
            // lstLista5
            // 
            this.lstLista5.FormattingEnabled = true;
            this.lstLista5.Location = new System.Drawing.Point(20, 50);
            this.lstLista5.Name = "lstLista5";
            this.lstLista5.Size = new System.Drawing.Size(250, 342);
            this.lstLista5.TabIndex = 1;
            // 
            // btnGenerar5
            // 
            this.btnGenerar5.Location = new System.Drawing.Point(300, 60);
            this.btnGenerar5.Name = "btnGenerar5";
            this.btnGenerar5.Size = new System.Drawing.Size(170, 40);
            this.btnGenerar5.TabIndex = 2;
            this.btnGenerar5.Text = "Generar Lista";
            this.btnGenerar5.UseVisualStyleBackColor = true;
            this.btnGenerar5.Click += new System.EventHandler(this.btnGenerar5_Click);
            // 
            // btnMaxMin5
            // 
            this.btnMaxMin5.Location = new System.Drawing.Point(300, 110);
            this.btnMaxMin5.Name = "btnMaxMin5";
            this.btnMaxMin5.Size = new System.Drawing.Size(170, 40);
            this.btnMaxMin5.TabIndex = 3;
            this.btnMaxMin5.Text = "Buscar Max/Min";
            this.btnMaxMin5.UseVisualStyleBackColor = true;
            this.btnMaxMin5.Click += new System.EventHandler(this.btnMaxMin5_Click);
            // 
            // lblResultado5
            // 
            this.lblResultado5.AutoSize = true;
            this.lblResultado5.Location = new System.Drawing.Point(300, 170);
            this.lblResultado5.Name = "lblResultado5";
            this.lblResultado5.Size = new System.Drawing.Size(58, 13);
            this.lblResultado5.TabIndex = 4;
            this.lblResultado5.Text = "Resultado:";
            // 
            // lblTitulo6
            // 
            this.lblTitulo6.AutoSize = true;
            this.lblTitulo6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo6.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo6.Name = "lblTitulo6";
            this.lblTitulo6.Size = new System.Drawing.Size(218, 21);
            this.lblTitulo6.TabIndex = 0;
            this.lblTitulo6.Text = "Búsqueda en Matriz 10 x 10";
            // 
            // dgvMatriz6
            // 
            this.dgvMatriz6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz6.ColumnHeadersVisible = false;
            this.dgvMatriz6.Location = new System.Drawing.Point(20, 60);
            this.dgvMatriz6.Name = "dgvMatriz6";
            this.dgvMatriz6.ReadOnly = true;
            this.dgvMatriz6.RowHeadersVisible = false;
            this.dgvMatriz6.Size = new System.Drawing.Size(500, 450);
            this.dgvMatriz6.TabIndex = 1;
            // 
            // btnGenerar6
            // 
            this.btnGenerar6.Location = new System.Drawing.Point(550, 60);
            this.btnGenerar6.Name = "btnGenerar6";
            this.btnGenerar6.Size = new System.Drawing.Size(170, 40);
            this.btnGenerar6.TabIndex = 2;
            this.btnGenerar6.Text = "Generar Matriz";
            this.btnGenerar6.UseVisualStyleBackColor = true;
            this.btnGenerar6.Click += new System.EventHandler(this.btnGenerar6_Click);
            // 
            // lblBuscar6
            // 
            this.lblBuscar6.AutoSize = true;
            this.lblBuscar6.Location = new System.Drawing.Point(550, 130);
            this.lblBuscar6.Name = "lblBuscar6";
            this.lblBuscar6.Size = new System.Drawing.Size(47, 13);
            this.lblBuscar6.TabIndex = 3;
            this.lblBuscar6.Text = "Número:";
            // 
            // txtBuscar6
            // 
            this.txtBuscar6.Location = new System.Drawing.Point(620, 125);
            this.txtBuscar6.Name = "txtBuscar6";
            this.txtBuscar6.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar6.TabIndex = 4;
            // 
            // btnBuscar6
            // 
            this.btnBuscar6.Location = new System.Drawing.Point(550, 160);
            this.btnBuscar6.Name = "btnBuscar6";
            this.btnBuscar6.Size = new System.Drawing.Size(170, 40);
            this.btnBuscar6.TabIndex = 5;
            this.btnBuscar6.Text = "Buscar en Matriz";
            this.btnBuscar6.UseVisualStyleBackColor = true;
            this.btnBuscar6.Click += new System.EventHandler(this.btnBuscar6_Click);
            // 
            // lblResultado6
            // 
            this.lblResultado6.AutoSize = true;
            this.lblResultado6.Location = new System.Drawing.Point(550, 220);
            this.lblResultado6.Name = "lblResultado6";
            this.lblResultado6.Size = new System.Drawing.Size(58, 13);
            this.lblResultado6.TabIndex = 6;
            this.lblResultado6.Text = "Resultado:";
            // 
            // FrmPracticaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPracticaBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica - Búsqueda";
            this.tabControl1.ResumeLayout(false);
            this.tabEj1.ResumeLayout(false);
            this.tabEj1.PerformLayout();
            this.tabEj2.ResumeLayout(false);
            this.tabEj2.PerformLayout();
            this.tabEj3.ResumeLayout(false);
            this.tabEj3.PerformLayout();
            this.tabEj4.ResumeLayout(false);
            this.tabEj4.PerformLayout();
            this.tabEj5.ResumeLayout(false);
            this.tabEj5.PerformLayout();
            this.tabEj6.ResumeLayout(false);
            this.tabEj6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEj1;
        private System.Windows.Forms.TabPage tabEj2;
        private System.Windows.Forms.TabPage tabEj3;
        private System.Windows.Forms.TabPage tabEj4;
        private System.Windows.Forms.TabPage tabEj5;
        private System.Windows.Forms.TabPage tabEj6;
        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.Button btnGenerar1;
        private System.Windows.Forms.ListBox lstArreglo1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.Button btnGenerar2;
        private System.Windows.Forms.ListBox lstLista2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.ListBox lstProceso2;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblParrafo3;
        private System.Windows.Forms.Button btnContar3;
        private System.Windows.Forms.TextBox txtPalabra3;
        private System.Windows.Forms.Label lblPalabra3;
        private System.Windows.Forms.TextBox txtParrafo3;
        private System.Windows.Forms.Label lblResultado3;
        private System.Windows.Forms.DataGridView dgvEstudiantes4;
        private System.Windows.Forms.Label lblTitulo4;
        private System.Windows.Forms.Label lblNombre4;
        private System.Windows.Forms.Button btnBuscarId4;
        private System.Windows.Forms.TextBox txtId4;
        private System.Windows.Forms.Label lblId4;
        private System.Windows.Forms.Button btnGenerar4;
        private System.Windows.Forms.Label lblResultado4;
        private System.Windows.Forms.Button btnBuscarNom4;
        private System.Windows.Forms.TextBox txtNombre4;
        private System.Windows.Forms.Label lblTitulo5;
        private System.Windows.Forms.Label lblResultado5;
        private System.Windows.Forms.Button btnMaxMin5;
        private System.Windows.Forms.Button btnGenerar5;
        private System.Windows.Forms.ListBox lstLista5;
        private System.Windows.Forms.DataGridView dgvMatriz6;
        private System.Windows.Forms.Label lblTitulo6;
        private System.Windows.Forms.Label lblResultado6;
        private System.Windows.Forms.Button btnBuscar6;
        private System.Windows.Forms.TextBox txtBuscar6;
        private System.Windows.Forms.Label lblBuscar6;
        private System.Windows.Forms.Button btnGenerar6;
    }
}

