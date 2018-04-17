namespace Eventos
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtClick = new System.Windows.Forms.TextBox();
            this.cbxChange = new System.Windows.Forms.ComboBox();
            this.txtLostFocus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyPress = new System.Windows.Forms.TextBox();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuscarClick);
            // 
            // txtClick
            // 
            this.txtClick.Location = new System.Drawing.Point(35, 52);
            this.txtClick.Name = "txtClick";
            this.txtClick.Size = new System.Drawing.Size(120, 20);
            this.txtClick.TabIndex = 1;
            // 
            // cbxChange
            // 
            this.cbxChange.FormattingEnabled = true;
            this.cbxChange.Items.AddRange(new object[] {
            "Gerardo",
            "Francisco",
            "Matias",
            "Ignacio",
            "Felipe",
            "Chirstofher",
            "Bastian",
            "Sebastian",
            "Claudio",
            "Andrés"});
            this.cbxChange.Location = new System.Drawing.Point(35, 101);
            this.cbxChange.Name = "cbxChange";
            this.cbxChange.Size = new System.Drawing.Size(120, 21);
            this.cbxChange.TabIndex = 2;
            this.cbxChange.SelectedIndexChanged += new System.EventHandler(this.CambiaSeleccion);
            // 
            // txtLostFocus
            // 
            this.txtLostFocus.Location = new System.Drawing.Point(35, 164);
            this.txtLostFocus.Name = "txtLostFocus";
            this.txtLostFocus.Size = new System.Drawing.Size(120, 20);
            this.txtLostFocus.TabIndex = 3;
            this.txtLostFocus.Validated += new System.EventHandler(this.buscarLostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evento Click";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Evento SelectedChange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Evento LostFocus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evento KeyPress";
            // 
            // txtKeyPress
            // 
            this.txtKeyPress.Location = new System.Drawing.Point(35, 218);
            this.txtKeyPress.Name = "txtKeyPress";
            this.txtKeyPress.Size = new System.Drawing.Size(120, 20);
            this.txtKeyPress.TabIndex = 7;
            this.txtKeyPress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarKeyUp);
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.txtResultado);
            this.grbResultado.Controls.Add(this.label5);
            this.grbResultado.Location = new System.Drawing.Point(281, 40);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(249, 272);
            this.grbResultado.TabIndex = 9;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado de Busqueda";
            this.grbResultado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(17, 61);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 22);
            this.txtResultado.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar Busqueda ...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeyPress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLostFocus);
            this.Controls.Add(this.cbxChange);
            this.Controls.Add(this.txtClick);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Saludame);
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtClick;
        private System.Windows.Forms.ComboBox cbxChange;
        private System.Windows.Forms.TextBox txtLostFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyPress;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

