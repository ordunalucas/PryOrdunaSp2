namespace PryOrdunaSp2
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
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(553, 38);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(200, 20);
            this.dTP.TabIndex = 0;
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(107, 53);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(120, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // cmbBox
            // 
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(106, 88);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 2;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(107, 130);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Enviar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(106, 186);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(120, 95);
            this.cmb.TabIndex = 4;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de ticket";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.dTP);
            this.Name = "Form1";
            this.Text = "venta de tikets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

