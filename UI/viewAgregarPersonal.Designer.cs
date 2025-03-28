namespace HotelGloriaDataBase
{
    partial class viewAgregarPersonal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.dBHotelGloriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBHotelGloriaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dBHotelGloriaDataSet = new HotelGloriaDataBase.DBHotelGloriaDataSet();
            this.tCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCargoTableAdapter = new HotelGloriaDataBase.DBHotelGloriaDataSetTableAdapters.TCargoTableAdapter();
            this.dBHotelGloriaDataSet1 = new HotelGloriaDataBase.DBHotelGloriaDataSet1();
            this.tSalarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSalarioTableAdapter = new HotelGloriaDataBase.DBHotelGloriaDataSet1TableAdapters.TSalarioTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dBHotelGloriaDataSet2 = new HotelGloriaDataBase.DBHotelGloriaDataSet2();
            this.tPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPersonalTableAdapter = new HotelGloriaDataBase.DBHotelGloriaDataSet2TableAdapters.TPersonalTableAdapter();
            this.iDPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSalarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contraseñaPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Documento Identidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero Documento Identidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Télefono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Nacimiento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cargo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Salario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(712, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Horario";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(257, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 222);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 82);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 26);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(257, 122);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 26);
            this.textBox4.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(521, 34);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 26);
            this.textBox6.TabIndex = 17;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(521, 84);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 26);
            this.textBox7.TabIndex = 18;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(429, 161);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 22;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonalDataGridViewTextBoxColumn,
            this.nombrePersonalDataGridViewTextBoxColumn,
            this.primerApellidoPersonalDataGridViewTextBoxColumn,
            this.segundoApellidoPersonalDataGridViewTextBoxColumn,
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn,
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn,
            this.direccionPersonalDataGridViewTextBoxColumn,
            this.telefonoPersonalDataGridViewTextBoxColumn,
            this.emailPersonalDataGridViewTextBoxColumn,
            this.iDCargoDataGridViewTextBoxColumn,
            this.iDHorarioDataGridViewTextBoxColumn,
            this.iDSalarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.contraseñaPersonalDataGridViewTextBoxColumn,
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPersonalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tCargoBindingSource;
            this.comboBox1.DisplayMember = "Nombre_Cargo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(794, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(794, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tSalarioBindingSource;
            this.comboBox3.DisplayMember = "Monto_Salario";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(794, 117);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dBHotelGloriaDataSet
            // 
            this.dBHotelGloriaDataSet.DataSetName = "DBHotelGloriaDataSet";
            this.dBHotelGloriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCargoBindingSource
            // 
            this.tCargoBindingSource.DataMember = "TCargo";
            this.tCargoBindingSource.DataSource = this.dBHotelGloriaDataSet;
            // 
            // tCargoTableAdapter
            // 
            this.tCargoTableAdapter.ClearBeforeFill = true;
            // 
            // dBHotelGloriaDataSet1
            // 
            this.dBHotelGloriaDataSet1.DataSetName = "DBHotelGloriaDataSet1";
            this.dBHotelGloriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSalarioBindingSource
            // 
            this.tSalarioBindingSource.DataMember = "TSalario";
            this.tSalarioBindingSource.DataSource = this.dBHotelGloriaDataSet1;
            // 
            // tSalarioTableAdapter
            // 
            this.tSalarioTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "CI",
            "DNI",
            "Pasaporte"});
            this.comboBox4.Location = new System.Drawing.Point(257, 173);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 28;
            // 
            // dBHotelGloriaDataSet2
            // 
            this.dBHotelGloriaDataSet2.DataSetName = "DBHotelGloriaDataSet2";
            this.dBHotelGloriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPersonalBindingSource
            // 
            this.tPersonalBindingSource.DataMember = "TPersonal";
            this.tPersonalBindingSource.DataSource = this.dBHotelGloriaDataSet2;
            // 
            // tPersonalTableAdapter
            // 
            this.tPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // iDPersonalDataGridViewTextBoxColumn
            // 
            this.iDPersonalDataGridViewTextBoxColumn.DataPropertyName = "ID_Personal";
            this.iDPersonalDataGridViewTextBoxColumn.HeaderText = "ID_Personal";
            this.iDPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPersonalDataGridViewTextBoxColumn.Name = "iDPersonalDataGridViewTextBoxColumn";
            this.iDPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombrePersonalDataGridViewTextBoxColumn
            // 
            this.nombrePersonalDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Personal";
            this.nombrePersonalDataGridViewTextBoxColumn.HeaderText = "Nombre_Personal";
            this.nombrePersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrePersonalDataGridViewTextBoxColumn.Name = "nombrePersonalDataGridViewTextBoxColumn";
            this.nombrePersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // primerApellidoPersonalDataGridViewTextBoxColumn
            // 
            this.primerApellidoPersonalDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido_Personal";
            this.primerApellidoPersonalDataGridViewTextBoxColumn.HeaderText = "PrimerApellido_Personal";
            this.primerApellidoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primerApellidoPersonalDataGridViewTextBoxColumn.Name = "primerApellidoPersonalDataGridViewTextBoxColumn";
            this.primerApellidoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // segundoApellidoPersonalDataGridViewTextBoxColumn
            // 
            this.segundoApellidoPersonalDataGridViewTextBoxColumn.DataPropertyName = "SegundoApellido_Personal";
            this.segundoApellidoPersonalDataGridViewTextBoxColumn.HeaderText = "SegundoApellido_Personal";
            this.segundoApellidoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.segundoApellidoPersonalDataGridViewTextBoxColumn.Name = "segundoApellidoPersonalDataGridViewTextBoxColumn";
            this.segundoApellidoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDocumentoPersonalDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento_Personal";
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn.HeaderText = "TipoDocumento_Personal";
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn.Name = "tipoDocumentoPersonalDataGridViewTextBoxColumn";
            this.tipoDocumentoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDocumentoPersonalDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento_Personal";
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento_Personal";
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn.Name = "numeroDocumentoPersonalDataGridViewTextBoxColumn";
            this.numeroDocumentoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionPersonalDataGridViewTextBoxColumn
            // 
            this.direccionPersonalDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Personal";
            this.direccionPersonalDataGridViewTextBoxColumn.HeaderText = "Direccion_Personal";
            this.direccionPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionPersonalDataGridViewTextBoxColumn.Name = "direccionPersonalDataGridViewTextBoxColumn";
            this.direccionPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoPersonalDataGridViewTextBoxColumn
            // 
            this.telefonoPersonalDataGridViewTextBoxColumn.DataPropertyName = "Telefono_Personal";
            this.telefonoPersonalDataGridViewTextBoxColumn.HeaderText = "Telefono_Personal";
            this.telefonoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoPersonalDataGridViewTextBoxColumn.Name = "telefonoPersonalDataGridViewTextBoxColumn";
            this.telefonoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailPersonalDataGridViewTextBoxColumn
            // 
            this.emailPersonalDataGridViewTextBoxColumn.DataPropertyName = "Email_Personal";
            this.emailPersonalDataGridViewTextBoxColumn.HeaderText = "Email_Personal";
            this.emailPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailPersonalDataGridViewTextBoxColumn.Name = "emailPersonalDataGridViewTextBoxColumn";
            this.emailPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCargoDataGridViewTextBoxColumn
            // 
            this.iDCargoDataGridViewTextBoxColumn.DataPropertyName = "ID_Cargo";
            this.iDCargoDataGridViewTextBoxColumn.HeaderText = "ID_Cargo";
            this.iDCargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCargoDataGridViewTextBoxColumn.Name = "iDCargoDataGridViewTextBoxColumn";
            this.iDCargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDHorarioDataGridViewTextBoxColumn
            // 
            this.iDHorarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Horario";
            this.iDHorarioDataGridViewTextBoxColumn.HeaderText = "ID_Horario";
            this.iDHorarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDHorarioDataGridViewTextBoxColumn.Name = "iDHorarioDataGridViewTextBoxColumn";
            this.iDHorarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDSalarioDataGridViewTextBoxColumn
            // 
            this.iDSalarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Salario";
            this.iDSalarioDataGridViewTextBoxColumn.HeaderText = "ID_Salario";
            this.iDSalarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSalarioDataGridViewTextBoxColumn.Name = "iDSalarioDataGridViewTextBoxColumn";
            this.iDSalarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // contraseñaPersonalDataGridViewTextBoxColumn
            // 
            this.contraseñaPersonalDataGridViewTextBoxColumn.DataPropertyName = "Contraseña_Personal";
            this.contraseñaPersonalDataGridViewTextBoxColumn.HeaderText = "Contraseña_Personal";
            this.contraseñaPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaPersonalDataGridViewTextBoxColumn.Name = "contraseñaPersonalDataGridViewTextBoxColumn";
            this.contraseñaPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoPersonalDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento_Personal";
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento_Personal";
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn.Name = "fechaNacimientoPersonalDataGridViewTextBoxColumn";
            this.fechaNacimientoPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewAgregarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 552);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewAgregarPersonal";
            this.Text = "0";
            this.Load += new System.EventHandler(this.viewAgregarPesonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBHotelGloriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPersonalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dBHotelGloriaDataSetBindingSource;
        private System.Windows.Forms.BindingSource dBHotelGloriaDataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tPersonalBindingSourc;
        private System.Windows.Forms.BindingSource tPersonalBindingSource1;
        private System.Windows.Forms.BindingSource tPersonalBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private DBHotelGloriaDataSet dBHotelGloriaDataSet;
        private System.Windows.Forms.BindingSource tCargoBindingSource;
        private DBHotelGloriaDataSetTableAdapters.TCargoTableAdapter tCargoTableAdapter;
        private DBHotelGloriaDataSet1 dBHotelGloriaDataSet1;
        private System.Windows.Forms.BindingSource tSalarioBindingSource;
        private DBHotelGloriaDataSet1TableAdapters.TSalarioTableAdapter tSalarioTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private DBHotelGloriaDataSet2 dBHotelGloriaDataSet2;
        private System.Windows.Forms.BindingSource tPersonalBindingSource;
        private DBHotelGloriaDataSet2TableAdapters.TPersonalTableAdapter tPersonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSalarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoPersonalDataGridViewTextBoxColumn;
    }
}