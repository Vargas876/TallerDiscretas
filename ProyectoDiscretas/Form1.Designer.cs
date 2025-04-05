// Form1.Designer.cs
namespace ProyectoDiscretas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblClock = new System.Windows.Forms.Label();
            this.panelComedor = new System.Windows.Forms.Panel();
            this.lblACTextComedor = new System.Windows.Forms.Label();
            this.lblLuzTextComedor = new System.Windows.Forms.Label();
            this.lblTempTextComedor = new System.Windows.Forms.Label();
            this.lblACComedor = new System.Windows.Forms.Label();
            this.lblLuzComedor = new System.Windows.Forms.Label();
            this.lblComedorTitle = new System.Windows.Forms.Label();
            this.numTempComedor = new System.Windows.Forms.NumericUpDown();
            this.chkPuertaComedor = new System.Windows.Forms.CheckBox();
            this.chkVentanaComedor = new System.Windows.Forms.CheckBox();
            this.chkPresenciaComedor = new System.Windows.Forms.CheckBox();
            this.panelSala = new System.Windows.Forms.Panel();
            this.lblACTextSala = new System.Windows.Forms.Label();
            this.lblLuzTextSala = new System.Windows.Forms.Label();
            this.lblTempTextSala = new System.Windows.Forms.Label();
            this.lblACSala = new System.Windows.Forms.Label();
            this.lblLuzSala = new System.Windows.Forms.Label();
            this.lblSalaTitle = new System.Windows.Forms.Label();
            this.numTempSala = new System.Windows.Forms.NumericUpDown();
            this.chkPuertaSala = new System.Windows.Forms.CheckBox();
            this.chkVentanaSala = new System.Windows.Forms.CheckBox();
            this.chkPresenciaSala = new System.Windows.Forms.CheckBox();
            this.panelCocina = new System.Windows.Forms.Panel();
            this.lblACTextCocina = new System.Windows.Forms.Label();
            this.lblLuzTextCocina = new System.Windows.Forms.Label();
            this.lblTempTextCocina = new System.Windows.Forms.Label();
            this.lblACCocina = new System.Windows.Forms.Label();
            this.lblLuzCocina = new System.Windows.Forms.Label();
            this.lblCocinaTitle = new System.Windows.Forms.Label();
            this.numTempCocina = new System.Windows.Forms.NumericUpDown();
            this.chkPuertaCocina = new System.Windows.Forms.CheckBox();
            this.chkVentanaCocina = new System.Windows.Forms.CheckBox();
            this.chkPresenciaCocina = new System.Windows.Forms.CheckBox();
            this.panelHabitacion = new System.Windows.Forms.Panel();
            this.lblACTextHabitacion = new System.Windows.Forms.Label();
            this.lblLuzTextHabitacion = new System.Windows.Forms.Label();
            this.lblTempTextHabitacion = new System.Windows.Forms.Label();
            this.lblACHabitacion = new System.Windows.Forms.Label();
            this.lblLuzHabitacion = new System.Windows.Forms.Label();
            this.lblHabitacionTitle = new System.Windows.Forms.Label();
            this.numTempHabitacion = new System.Windows.Forms.NumericUpDown();
            this.chkPuertaHabitacion = new System.Windows.Forms.CheckBox();
            this.chkVentanaHabitacion = new System.Windows.Forms.CheckBox();
            this.chkPresenciaHabitacion = new System.Windows.Forms.CheckBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.panelComedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempComedor)).BeginInit();
            this.panelSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempSala)).BeginInit();
            this.panelCocina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempCocina)).BeginInit();
            this.panelHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblClock.Location = new System.Drawing.Point(424, 12);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(62, 26);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "00:00";
            // 
            // panelComedor
            // 
            this.panelComedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelComedor.Controls.Add(this.lblACTextComedor);
            this.panelComedor.Controls.Add(this.lblLuzTextComedor);
            this.panelComedor.Controls.Add(this.lblTempTextComedor);
            this.panelComedor.Controls.Add(this.lblACComedor);
            this.panelComedor.Controls.Add(this.lblLuzComedor);
            this.panelComedor.Controls.Add(this.lblComedorTitle);
            this.panelComedor.Controls.Add(this.numTempComedor);
            this.panelComedor.Controls.Add(this.chkPuertaComedor);
            this.panelComedor.Controls.Add(this.chkVentanaComedor);
            this.panelComedor.Controls.Add(this.chkPresenciaComedor);
            this.panelComedor.Location = new System.Drawing.Point(12, 12);
            this.panelComedor.Name = "panelComedor";
            this.panelComedor.Size = new System.Drawing.Size(200, 200);
            this.panelComedor.TabIndex = 5;
            // 
            // lblACTextComedor
            // 
            this.lblACTextComedor.AutoSize = true;
            this.lblACTextComedor.Location = new System.Drawing.Point(10, 150);
            this.lblACTextComedor.Name = "lblACTextComedor";
            this.lblACTextComedor.Size = new System.Drawing.Size(29, 13);
            this.lblACTextComedor.TabIndex = 9;
            this.lblACTextComedor.Text = "A/C:";
            // 
            // lblLuzTextComedor
            // 
            this.lblLuzTextComedor.AutoSize = true;
            this.lblLuzTextComedor.Location = new System.Drawing.Point(10, 120);
            this.lblLuzTextComedor.Name = "lblLuzTextComedor";
            this.lblLuzTextComedor.Size = new System.Drawing.Size(27, 13);
            this.lblLuzTextComedor.TabIndex = 8;
            this.lblLuzTextComedor.Text = "Luz:";
            // 
            // lblTempTextComedor
            // 
            this.lblTempTextComedor.AutoSize = true;
            this.lblTempTextComedor.Location = new System.Drawing.Point(84, 65);
            this.lblTempTextComedor.Name = "lblTempTextComedor";
            this.lblTempTextComedor.Size = new System.Drawing.Size(70, 13);
            this.lblTempTextComedor.TabIndex = 7; 
            this.lblTempTextComedor.Text = "Temperatura (°C) :";
            // 
            // lblACComedor
            // 
            this.lblACComedor.AutoSize = true;
            this.lblACComedor.BackColor = System.Drawing.Color.LightGray;
            this.lblACComedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblACComedor.Location = new System.Drawing.Point(100, 150);
            this.lblACComedor.Name = "lblACComedor";
            this.lblACComedor.Size = new System.Drawing.Size(29, 15);
            this.lblACComedor.TabIndex = 0;
            this.lblACComedor.Text = "OFF";
            // 
            // lblLuzComedor
            // 
            this.lblLuzComedor.AutoSize = true;
            this.lblLuzComedor.BackColor = System.Drawing.Color.LightGray;
            this.lblLuzComedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLuzComedor.Location = new System.Drawing.Point(100, 120);
            this.lblLuzComedor.Name = "lblLuzComedor";
            this.lblLuzComedor.Size = new System.Drawing.Size(29, 15);
            this.lblLuzComedor.TabIndex = 1;
            this.lblLuzComedor.Text = "OFF";
            // 
            // lblComedorTitle
            // 
            this.lblComedorTitle.AutoSize = true;
            this.lblComedorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblComedorTitle.Location = new System.Drawing.Point(3, 3);
            this.lblComedorTitle.Name = "lblComedorTitle";
            this.lblComedorTitle.Size = new System.Drawing.Size(56, 13);
            this.lblComedorTitle.TabIndex = 2;
            this.lblComedorTitle.Text = "Comedor";
            // 
            // numTempComedor
            // 
            this.numTempComedor.Location = new System.Drawing.Point(100, 80);
            this.numTempComedor.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numTempComedor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTempComedor.Name = "numTempComedor";
            this.numTempComedor.Size = new System.Drawing.Size(60, 20);
            this.numTempComedor.TabIndex = 3;
            this.numTempComedor.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTempComedor.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // chkPuertaComedor
            // 
            this.chkPuertaComedor.AutoSize = true;
            this.chkPuertaComedor.Location = new System.Drawing.Point(10, 80);
            this.chkPuertaComedor.Name = "chkPuertaComedor";
            this.chkPuertaComedor.Size = new System.Drawing.Size(57, 17);
            this.chkPuertaComedor.TabIndex = 4;
            this.chkPuertaComedor.Text = "Puerta";
            this.chkPuertaComedor.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkVentanaComedor
            // 
            this.chkVentanaComedor.AutoSize = true;
            this.chkVentanaComedor.Location = new System.Drawing.Point(10, 50);
            this.chkVentanaComedor.Name = "chkVentanaComedor";
            this.chkVentanaComedor.Size = new System.Drawing.Size(66, 17);
            this.chkVentanaComedor.TabIndex = 5;
            this.chkVentanaComedor.Text = "Ventana";
            this.chkVentanaComedor.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkPresenciaComedor
            // 
            this.chkPresenciaComedor.AutoSize = true;
            this.chkPresenciaComedor.Location = new System.Drawing.Point(10, 20);
            this.chkPresenciaComedor.Name = "chkPresenciaComedor";
            this.chkPresenciaComedor.Size = new System.Drawing.Size(73, 17);
            this.chkPresenciaComedor.TabIndex = 6;
            this.chkPresenciaComedor.Text = "Presencia";
            this.chkPresenciaComedor.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // panelSala
            // 
            this.panelSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSala.Controls.Add(this.lblACTextSala);
            this.panelSala.Controls.Add(this.lblLuzTextSala);
            this.panelSala.Controls.Add(this.lblTempTextSala);
            this.panelSala.Controls.Add(this.lblACSala);
            this.panelSala.Controls.Add(this.lblLuzSala);
            this.panelSala.Controls.Add(this.lblSalaTitle);
            this.panelSala.Controls.Add(this.numTempSala);
            this.panelSala.Controls.Add(this.chkPuertaSala);
            this.panelSala.Controls.Add(this.chkVentanaSala);
            this.panelSala.Controls.Add(this.chkPresenciaSala);
            this.panelSala.Location = new System.Drawing.Point(218, 12);
            this.panelSala.Name = "panelSala";
            this.panelSala.Size = new System.Drawing.Size(200, 200);
            this.panelSala.TabIndex = 4;
            // 
            // lblACTextSala
            // 
            this.lblACTextSala.AutoSize = true;
            this.lblACTextSala.Location = new System.Drawing.Point(10, 150);
            this.lblACTextSala.Name = "lblACTextSala";
            this.lblACTextSala.Size = new System.Drawing.Size(29, 13);
            this.lblACTextSala.TabIndex = 12;
            this.lblACTextSala.Text = "A/C:";
            // 
            // lblLuzTextSala
            // 
            this.lblLuzTextSala.AutoSize = true;
            this.lblLuzTextSala.Location = new System.Drawing.Point(10, 120);
            this.lblLuzTextSala.Name = "lblLuzTextSala";
            this.lblLuzTextSala.Size = new System.Drawing.Size(27, 13);
            this.lblLuzTextSala.TabIndex = 11;
            this.lblLuzTextSala.Text = "Luz:";
            // 
            // lblTempTextSala
            // 
            this.lblTempTextSala.AutoSize = true;
            this.lblTempTextSala.Location = new System.Drawing.Point(84, 65);
            this.lblTempTextSala.Name = "lblTempTextSala";
            this.lblTempTextSala.Size = new System.Drawing.Size(70, 13);
            this.lblTempTextSala.TabIndex = 10;
            this.lblTempTextSala.Text = "Temperatura (°C) :";
            // 
            // lblACSala
            // 
            this.lblACSala.AutoSize = true;
            this.lblACSala.BackColor = System.Drawing.Color.LightGray;
            this.lblACSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblACSala.Location = new System.Drawing.Point(100, 150);
            this.lblACSala.Name = "lblACSala";
            this.lblACSala.Size = new System.Drawing.Size(29, 15);
            this.lblACSala.TabIndex = 0;
            this.lblACSala.Text = "OFF";
            // 
            // lblLuzSala
            // 
            this.lblLuzSala.AutoSize = true;
            this.lblLuzSala.BackColor = System.Drawing.Color.LightGray;
            this.lblLuzSala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLuzSala.Location = new System.Drawing.Point(100, 120);
            this.lblLuzSala.Name = "lblLuzSala";
            this.lblLuzSala.Size = new System.Drawing.Size(29, 15);
            this.lblLuzSala.TabIndex = 1;
            this.lblLuzSala.Text = "OFF";
            // 
            // lblSalaTitle
            // 
            this.lblSalaTitle.AutoSize = true;
            this.lblSalaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSalaTitle.Location = new System.Drawing.Point(3, 3);
            this.lblSalaTitle.Name = "lblSalaTitle";
            this.lblSalaTitle.Size = new System.Drawing.Size(32, 13);
            this.lblSalaTitle.TabIndex = 2;
            this.lblSalaTitle.Text = "Sala";
            // 
            // numTempSala
            // 
            this.numTempSala.Location = new System.Drawing.Point(100, 80);
            this.numTempSala.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numTempSala.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTempSala.Name = "numTempSala";
            this.numTempSala.Size = new System.Drawing.Size(60, 20);
            this.numTempSala.TabIndex = 3;
            this.numTempSala.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTempSala.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // chkPuertaSala
            // 
            this.chkPuertaSala.AutoSize = true;
            this.chkPuertaSala.Location = new System.Drawing.Point(10, 80);
            this.chkPuertaSala.Name = "chkPuertaSala";
            this.chkPuertaSala.Size = new System.Drawing.Size(57, 17);
            this.chkPuertaSala.TabIndex = 4;
            this.chkPuertaSala.Text = "Puerta";
            this.chkPuertaSala.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkVentanaSala
            // 
            this.chkVentanaSala.AutoSize = true;
            this.chkVentanaSala.Location = new System.Drawing.Point(10, 50);
            this.chkVentanaSala.Name = "chkVentanaSala";
            this.chkVentanaSala.Size = new System.Drawing.Size(66, 17);
            this.chkVentanaSala.TabIndex = 5;
            this.chkVentanaSala.Text = "Ventana";
            this.chkVentanaSala.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkPresenciaSala
            // 
            this.chkPresenciaSala.AutoSize = true;
            this.chkPresenciaSala.Location = new System.Drawing.Point(10, 20);
            this.chkPresenciaSala.Name = "chkPresenciaSala";
            this.chkPresenciaSala.Size = new System.Drawing.Size(73, 17);
            this.chkPresenciaSala.TabIndex = 6;
            this.chkPresenciaSala.Text = "Presencia";
            this.chkPresenciaSala.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // panelCocina
            // 
            this.panelCocina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCocina.Controls.Add(this.lblACTextCocina);
            this.panelCocina.Controls.Add(this.lblLuzTextCocina);
            this.panelCocina.Controls.Add(this.lblTempTextCocina);
            this.panelCocina.Controls.Add(this.lblACCocina);
            this.panelCocina.Controls.Add(this.lblLuzCocina);
            this.panelCocina.Controls.Add(this.lblCocinaTitle);
            this.panelCocina.Controls.Add(this.numTempCocina);
            this.panelCocina.Controls.Add(this.chkPuertaCocina);
            this.panelCocina.Controls.Add(this.chkVentanaCocina);
            this.panelCocina.Controls.Add(this.chkPresenciaCocina);
            this.panelCocina.Location = new System.Drawing.Point(12, 218);
            this.panelCocina.Name = "panelCocina";
            this.panelCocina.Size = new System.Drawing.Size(200, 200);
            this.panelCocina.TabIndex = 3;
            // 
            // lblACTextCocina
            // 
            this.lblACTextCocina.AutoSize = true;
            this.lblACTextCocina.Location = new System.Drawing.Point(10, 150);
            this.lblACTextCocina.Name = "lblACTextCocina";
            this.lblACTextCocina.Size = new System.Drawing.Size(29, 13);
            this.lblACTextCocina.TabIndex = 12;
            this.lblACTextCocina.Text = "A/C:";
            // 
            // lblLuzTextCocina
            // 
            this.lblLuzTextCocina.AutoSize = true;
            this.lblLuzTextCocina.Location = new System.Drawing.Point(10, 120);
            this.lblLuzTextCocina.Name = "lblLuzTextCocina";
            this.lblLuzTextCocina.Size = new System.Drawing.Size(27, 13);
            this.lblLuzTextCocina.TabIndex = 11;
            this.lblLuzTextCocina.Text = "Luz:";
            // 
            // lblTempTextCocina
            // 
            this.lblTempTextCocina.AutoSize = true;
            this.lblTempTextCocina.Location = new System.Drawing.Point(84, 65);
            this.lblTempTextCocina.Name = "lblTempTextCocina";
            this.lblTempTextCocina.Size = new System.Drawing.Size(70, 13);
            this.lblTempTextCocina.TabIndex = 10;
            this.lblTempTextCocina.Text = "Temperatura (°C) :";
            // 
            // lblACCocina
            // 
            this.lblACCocina.AutoSize = true;
            this.lblACCocina.BackColor = System.Drawing.Color.LightGray;
            this.lblACCocina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblACCocina.Location = new System.Drawing.Point(100, 150);
            this.lblACCocina.Name = "lblACCocina";
            this.lblACCocina.Size = new System.Drawing.Size(29, 15);
            this.lblACCocina.TabIndex = 0;
            this.lblACCocina.Text = "OFF";
            // 
            // lblLuzCocina
            // 
            this.lblLuzCocina.AutoSize = true;
            this.lblLuzCocina.BackColor = System.Drawing.Color.LightGray;
            this.lblLuzCocina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLuzCocina.Location = new System.Drawing.Point(100, 120);
            this.lblLuzCocina.Name = "lblLuzCocina";
            this.lblLuzCocina.Size = new System.Drawing.Size(29, 15);
            this.lblLuzCocina.TabIndex = 1;
            this.lblLuzCocina.Text = "OFF";
            // 
            // lblCocinaTitle
            // 
            this.lblCocinaTitle.AutoSize = true;
            this.lblCocinaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCocinaTitle.Location = new System.Drawing.Point(3, 3);
            this.lblCocinaTitle.Name = "lblCocinaTitle";
            this.lblCocinaTitle.Size = new System.Drawing.Size(46, 13);
            this.lblCocinaTitle.TabIndex = 2;
            this.lblCocinaTitle.Text = "Cocina";
            // 
            // numTempCocina
            // 
            this.numTempCocina.Location = new System.Drawing.Point(100, 80);
            this.numTempCocina.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numTempCocina.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTempCocina.Name = "numTempCocina";
            this.numTempCocina.Size = new System.Drawing.Size(60, 20);
            this.numTempCocina.TabIndex = 3;
            this.numTempCocina.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTempCocina.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // chkPuertaCocina
            // 
            this.chkPuertaCocina.AutoSize = true;
            this.chkPuertaCocina.Location = new System.Drawing.Point(10, 80);
            this.chkPuertaCocina.Name = "chkPuertaCocina";
            this.chkPuertaCocina.Size = new System.Drawing.Size(57, 17);
            this.chkPuertaCocina.TabIndex = 4;
            this.chkPuertaCocina.Text = "Puerta";
            this.chkPuertaCocina.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkVentanaCocina
            // 
            this.chkVentanaCocina.AutoSize = true;
            this.chkVentanaCocina.Location = new System.Drawing.Point(10, 50);
            this.chkVentanaCocina.Name = "chkVentanaCocina";
            this.chkVentanaCocina.Size = new System.Drawing.Size(66, 17);
            this.chkVentanaCocina.TabIndex = 5;
            this.chkVentanaCocina.Text = "Ventana";
            this.chkVentanaCocina.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkPresenciaCocina
            // 
            this.chkPresenciaCocina.AutoSize = true;
            this.chkPresenciaCocina.Location = new System.Drawing.Point(10, 20);
            this.chkPresenciaCocina.Name = "chkPresenciaCocina";
            this.chkPresenciaCocina.Size = new System.Drawing.Size(73, 17);
            this.chkPresenciaCocina.TabIndex = 6;
            this.chkPresenciaCocina.Text = "Presencia";
            this.chkPresenciaCocina.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // panelHabitacion
            // 
            this.panelHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHabitacion.Controls.Add(this.lblACTextHabitacion);
            this.panelHabitacion.Controls.Add(this.lblLuzTextHabitacion);
            this.panelHabitacion.Controls.Add(this.lblTempTextHabitacion);
            this.panelHabitacion.Controls.Add(this.lblACHabitacion);
            this.panelHabitacion.Controls.Add(this.lblLuzHabitacion);
            this.panelHabitacion.Controls.Add(this.lblHabitacionTitle);
            this.panelHabitacion.Controls.Add(this.numTempHabitacion);
            this.panelHabitacion.Controls.Add(this.chkPuertaHabitacion);
            this.panelHabitacion.Controls.Add(this.chkVentanaHabitacion);
            this.panelHabitacion.Controls.Add(this.chkPresenciaHabitacion);
            this.panelHabitacion.Location = new System.Drawing.Point(218, 218);
            this.panelHabitacion.Name = "panelHabitacion";
            this.panelHabitacion.Size = new System.Drawing.Size(200, 200);
            this.panelHabitacion.TabIndex = 2;
            // 
            // lblACTextHabitacion
            // 
            this.lblACTextHabitacion.AutoSize = true;
            this.lblACTextHabitacion.Location = new System.Drawing.Point(10, 150);
            this.lblACTextHabitacion.Name = "lblACTextHabitacion";
            this.lblACTextHabitacion.Size = new System.Drawing.Size(29, 13);
            this.lblACTextHabitacion.TabIndex = 12;
            this.lblACTextHabitacion.Text = "A/C:";
            // 
            // lblLuzTextHabitacion
            // 
            this.lblLuzTextHabitacion.AutoSize = true;
            this.lblLuzTextHabitacion.Location = new System.Drawing.Point(10, 120);
            this.lblLuzTextHabitacion.Name = "lblLuzTextHabitacion";
            this.lblLuzTextHabitacion.Size = new System.Drawing.Size(27, 13);
            this.lblLuzTextHabitacion.TabIndex = 11;
            this.lblLuzTextHabitacion.Text = "Luz:";
            // 
            // lblTempTextHabitacion
            // 
            this.lblTempTextHabitacion.AutoSize = true;
            this.lblTempTextHabitacion.Location = new System.Drawing.Point(84, 65);
            this.lblTempTextHabitacion.Name = "lblTempTextHabitacion";
            this.lblTempTextHabitacion.Size = new System.Drawing.Size(70, 13);
            this.lblTempTextHabitacion.TabIndex = 10;
            this.lblTempTextHabitacion.Text = "Temperatura (°C) :";
            // 
            // lblACHabitacion
            // 
            this.lblACHabitacion.AutoSize = true;
            this.lblACHabitacion.BackColor = System.Drawing.Color.LightGray;
            this.lblACHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblACHabitacion.Location = new System.Drawing.Point(100, 150);
            this.lblACHabitacion.Name = "lblACHabitacion";
            this.lblACHabitacion.Size = new System.Drawing.Size(29, 15);
            this.lblACHabitacion.TabIndex = 0;
            this.lblACHabitacion.Text = "OFF";
            // 
            // lblLuzHabitacion
            // 
            this.lblLuzHabitacion.AutoSize = true;
            this.lblLuzHabitacion.BackColor = System.Drawing.Color.LightGray;
            this.lblLuzHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLuzHabitacion.Location = new System.Drawing.Point(100, 120);
            this.lblLuzHabitacion.Name = "lblLuzHabitacion";
            this.lblLuzHabitacion.Size = new System.Drawing.Size(29, 15);
            this.lblLuzHabitacion.TabIndex = 1;
            this.lblLuzHabitacion.Text = "OFF";
            // 
            // lblHabitacionTitle
            // 
            this.lblHabitacionTitle.AutoSize = true;
            this.lblHabitacionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHabitacionTitle.Location = new System.Drawing.Point(3, 3);
            this.lblHabitacionTitle.Name = "lblHabitacionTitle";
            this.lblHabitacionTitle.Size = new System.Drawing.Size(68, 13);
            this.lblHabitacionTitle.TabIndex = 2;
            this.lblHabitacionTitle.Text = "Habitación";
            // 
            // numTempHabitacion
            // 
            this.numTempHabitacion.Location = new System.Drawing.Point(100, 80);
            this.numTempHabitacion.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numTempHabitacion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTempHabitacion.Name = "numTempHabitacion";
            this.numTempHabitacion.Size = new System.Drawing.Size(60, 20);
            this.numTempHabitacion.TabIndex = 3;
            this.numTempHabitacion.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTempHabitacion.ValueChanged += new System.EventHandler(this.numTemp_ValueChanged);
            // 
            // chkPuertaHabitacion
            // 
            this.chkPuertaHabitacion.AutoSize = true;
            this.chkPuertaHabitacion.Location = new System.Drawing.Point(10, 80);
            this.chkPuertaHabitacion.Name = "chkPuertaHabitacion";
            this.chkPuertaHabitacion.Size = new System.Drawing.Size(57, 17);
            this.chkPuertaHabitacion.TabIndex = 4;
            this.chkPuertaHabitacion.Text = "Puerta";
            this.chkPuertaHabitacion.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkVentanaHabitacion
            // 
            this.chkVentanaHabitacion.AutoSize = true;
            this.chkVentanaHabitacion.Location = new System.Drawing.Point(10, 50);
            this.chkVentanaHabitacion.Name = "chkVentanaHabitacion";
            this.chkVentanaHabitacion.Size = new System.Drawing.Size(66, 17);
            this.chkVentanaHabitacion.TabIndex = 5;
            this.chkVentanaHabitacion.Text = "Ventana";
            this.chkVentanaHabitacion.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // chkPresenciaHabitacion
            // 
            this.chkPresenciaHabitacion.AutoSize = true;
            this.chkPresenciaHabitacion.Location = new System.Drawing.Point(10, 20);
            this.chkPresenciaHabitacion.Name = "chkPresenciaHabitacion";
            this.chkPresenciaHabitacion.Size = new System.Drawing.Size(73, 17);
            this.chkPresenciaHabitacion.TabIndex = 6;
            this.chkPresenciaHabitacion.Text = "Presencia";
            this.chkPresenciaHabitacion.CheckedChanged += new System.EventHandler(this.chkSensor_CheckedChanged);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(424, 48);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "Hora";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstrucciones.Location = new System.Drawing.Point(427, 80);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(148, 302);
            this.lblInstrucciones.TabIndex = 6;
            this.lblInstrucciones.Text = "Instrucciones:\r\n\r\n- Marque \"Presencia\" para detectar personas en la habitación.\r\n\r" +
    "\n- Marque las casillas para ABRIR ventanas y puertas (sin marcar = cerradas).\r\n\r\n- Ajuste la temperatura " +
    "con los controles numéricos.\r\n\r\n- Las luces se encienden automáticamente entre 6PM y 6AM si hay presencia.\r\n\r\n" +
    "- El aire acondicionado se activa cuando la temperatura supera 22°C y la puerta y ventana están cerradas.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.panelHabitacion);
            this.Controls.Add(this.panelCocina);
            this.Controls.Add(this.panelSala);
            this.Controls.Add(this.panelComedor);
            this.Name = "Form1";
            this.Text = "Sistema Domótico";
            this.panelComedor.ResumeLayout(false);
            this.panelComedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempComedor)).EndInit();
            this.panelSala.ResumeLayout(false);
            this.panelSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempSala)).EndInit();
            this.panelCocina.ResumeLayout(false);
            this.panelCocina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempCocina)).EndInit();
            this.panelHabitacion.ResumeLayout(false);
            this.panelHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panelComedor;
        private System.Windows.Forms.Label lblACComedor;
        private System.Windows.Forms.Label lblLuzComedor;
        private System.Windows.Forms.Label lblComedorTitle;
        private System.Windows.Forms.NumericUpDown numTempComedor;
        private System.Windows.Forms.CheckBox chkPuertaComedor;
        private System.Windows.Forms.CheckBox chkVentanaComedor;
        private System.Windows.Forms.CheckBox chkPresenciaComedor;
        private System.Windows.Forms.Panel panelSala;
        private System.Windows.Forms.Label lblACSala;
        private System.Windows.Forms.Label lblLuzSala;
        private System.Windows.Forms.Label lblSalaTitle;
        private System.Windows.Forms.NumericUpDown numTempSala;
        private System.Windows.Forms.CheckBox chkPuertaSala;
        private System.Windows.Forms.CheckBox chkVentanaSala;
        private System.Windows.Forms.CheckBox chkPresenciaSala;
        private System.Windows.Forms.Panel panelCocina;
        private System.Windows.Forms.Label lblACCocina;
        private System.Windows.Forms.Label lblLuzCocina;
        private System.Windows.Forms.Label lblCocinaTitle;
        private System.Windows.Forms.NumericUpDown numTempCocina;
        private System.Windows.Forms.CheckBox chkPuertaCocina;
        private System.Windows.Forms.CheckBox chkVentanaCocina;
        private System.Windows.Forms.CheckBox chkPresenciaCocina;
        private System.Windows.Forms.Panel panelHabitacion;
        private System.Windows.Forms.Label lblACHabitacion;
        private System.Windows.Forms.Label lblLuzHabitacion;
        private System.Windows.Forms.Label lblHabitacionTitle;
        private System.Windows.Forms.NumericUpDown numTempHabitacion;
        private System.Windows.Forms.CheckBox chkPuertaHabitacion;
        private System.Windows.Forms.CheckBox chkVentanaHabitacion;
        private System.Windows.Forms.CheckBox chkPresenciaHabitacion;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTempTextComedor;
        private System.Windows.Forms.Label lblLuzTextComedor;
        private System.Windows.Forms.Label lblACTextComedor;
        private System.Windows.Forms.Label lblTempTextSala;
        private System.Windows.Forms.Label lblLuzTextSala;
        private System.Windows.Forms.Label lblACTextSala;
        private System.Windows.Forms.Label lblTempTextCocina;
        private System.Windows.Forms.Label lblLuzTextCocina;
        private System.Windows.Forms.Label lblACTextCocina;
        private System.Windows.Forms.Label lblTempTextHabitacion;
        private System.Windows.Forms.Label lblLuzTextHabitacion;
        private System.Windows.Forms.Label lblACTextHabitacion;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}