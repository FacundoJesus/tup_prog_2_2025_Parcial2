namespace Ejercicio
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImportarPaquetesPedidos = new Button();
            lsb3 = new ListBox();
            lsb2 = new ListBox();
            lsb1 = new ListBox();
            groupBox2 = new GroupBox();
            btnRetirar = new Button();
            btnAgregar = new Button();
            tbPesoAcumulado = new TextBox();
            label4 = new Label();
            btnEnviar = new Button();
            btnIniciar = new Button();
            cmbCamiones = new ComboBox();
            label6 = new Label();
            lsbCarga = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImportarPaquetesPedidos);
            groupBox1.Controls.Add(lsb3);
            groupBox1.Controls.Add(lsb2);
            groupBox1.Controls.Add(lsb1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deposito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 35);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Zona 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Zona 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Zona 1";
            // 
            // btnImportarPaquetesPedidos
            // 
            btnImportarPaquetesPedidos.Location = new Point(608, 53);
            btnImportarPaquetesPedidos.Name = "btnImportarPaquetesPedidos";
            btnImportarPaquetesPedidos.Size = new Size(149, 154);
            btnImportarPaquetesPedidos.TabIndex = 3;
            btnImportarPaquetesPedidos.Text = "Importar Paquetes Pedidos";
            btnImportarPaquetesPedidos.UseVisualStyleBackColor = true;
            btnImportarPaquetesPedidos.Click += btnImportarPaquetesPedidos_Click;
            // 
            // lsb3
            // 
            lsb3.FormattingEnabled = true;
            lsb3.ItemHeight = 15;
            lsb3.Location = new Point(396, 53);
            lsb3.Name = "lsb3";
            lsb3.Size = new Size(189, 154);
            lsb3.TabIndex = 2;
            // 
            // lsb2
            // 
            lsb2.FormattingEnabled = true;
            lsb2.ItemHeight = 15;
            lsb2.Location = new Point(201, 53);
            lsb2.Name = "lsb2";
            lsb2.Size = new Size(189, 154);
            lsb2.TabIndex = 1;
            // 
            // lsb1
            // 
            lsb1.FormattingEnabled = true;
            lsb1.ItemHeight = 15;
            lsb1.Location = new Point(6, 53);
            lsb1.Name = "lsb1";
            lsb1.Size = new Size(189, 154);
            lsb1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(tbPesoAcumulado);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnIniciar);
            groupBox2.Controls.Add(cmbCamiones);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lsbCarga);
            groupBox2.Location = new Point(12, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(763, 213);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preparar reparto";
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(608, 143);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(149, 35);
            btnRetirar.TabIndex = 11;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 35);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbPesoAcumulado
            // 
            tbPesoAcumulado.Location = new Point(110, 160);
            tbPesoAcumulado.Name = "tbPesoAcumulado";
            tbPesoAcumulado.Size = new Size(85, 23);
            tbPesoAcumulado.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Peso acumulado:";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(120, 82);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 35);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(6, 82);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 35);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // cmbCamiones
            // 
            cmbCamiones.FormattingEnabled = true;
            cmbCamiones.Location = new Point(6, 53);
            cmbCamiones.Name = "cmbCamiones";
            cmbCamiones.Size = new Size(189, 23);
            cmbCamiones.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 35);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 4;
            label6.Text = "Lista de Camiones";
            // 
            // lsbCarga
            // 
            lsbCarga.FormattingEnabled = true;
            lsbCarga.ItemHeight = 15;
            lsbCarga.Location = new Point(201, 53);
            lsbCarga.Name = "lsbCarga";
            lsbCarga.Size = new Size(384, 154);
            lsbCarga.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 465);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FeDeX 3.0";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnImportarPaquetesPedidos;
        private ListBox lsb3;
        private ListBox lsb2;
        private ListBox lsb1;
        private GroupBox groupBox2;
        private TextBox tbPesoAcumulado;
        private Label label4;
        private Button btnEnviar;
        private Button btnIniciar;
        private ComboBox cmbCamiones;
        private Label label6;
        private ListBox lsbCarga;
        private Button btnRetirar;
        private Button btnAgregar;
    }
}
