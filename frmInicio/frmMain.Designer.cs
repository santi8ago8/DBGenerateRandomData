namespace frmInicio
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.checkbKey = new System.Windows.Forms.CheckBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnGuardarSQL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 504);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(255, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(52, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // checkbKey
            // 
            this.checkbKey.AutoSize = true;
            this.checkbKey.Location = new System.Drawing.Point(212, 30);
            this.checkbKey.Name = "checkbKey";
            this.checkbKey.Size = new System.Drawing.Size(44, 17);
            this.checkbKey.TabIndex = 3;
            this.checkbKey.Text = "Key";
            this.checkbKey.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Numeric",
            "Char"});
            this.cbTipo.Location = new System.Drawing.Point(118, 29);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(85, 21);
            this.cbTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre atributo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(307, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.nudCant);
            this.groupBox1.Controls.Add(this.tbTableName);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.btnGuardarSQL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(364, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportación";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(236, 17);
            this.nudCant.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(72, 20);
            this.nudCant.TabIndex = 1;
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(93, 16);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(100, 20);
            this.tbTableName.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(315, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(55, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardarSQL
            // 
            this.btnGuardarSQL.Location = new System.Drawing.Point(376, 15);
            this.btnGuardarSQL.Name = "btnGuardarSQL";
            this.btnGuardarSQL.Size = new System.Drawing.Size(95, 23);
            this.btnGuardarSQL.TabIndex = 3;
            this.btnGuardarSQL.Text = "Guardar .sql file";
            this.btnGuardarSQL.UseVisualStyleBackColor = true;
            this.btnGuardarSQL.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre tabla:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo sqp|*.sql";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset todo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 572);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.checkbKey);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "DB Generate data random -->diseñado y programado por: Santiago Nahuel Córdoba san" +
    "ti8ago8@gmail.com";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox checkbKey;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnGuardarSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnReset;




    }
}

