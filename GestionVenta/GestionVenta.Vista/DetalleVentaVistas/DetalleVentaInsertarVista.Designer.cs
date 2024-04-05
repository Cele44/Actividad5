namespace GestionVenta.Vista.DetalleVentaVistas
{
    partial class DetalleVentaInsertarVista
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
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(289, 403);
            button2.Name = "button2";
            button2.Size = new Size(111, 37);
            button2.TabIndex = 54;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(107, 403);
            button1.Name = "button1";
            button1.Size = new Size(111, 37);
            button1.TabIndex = 53;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 315);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 52;
            label5.Text = "TOTAL DETALLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 249);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 51;
            label4.Text = "PRECIO UNITARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 169);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 50;
            label3.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 102);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 49;
            label2.Text = "ID PRODUCTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 48;
            label1.Text = "ID VENTA";
            // 
            // button6
            // 
            button6.Location = new Point(352, 91);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(135, 31);
            button6.TabIndex = 47;
            button6.Text = "SELECCIONAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(352, 29);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(135, 31);
            button5.TabIndex = 46;
            button5.Text = "SELECCIONAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(172, 308);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 45;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 242);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 27);
            textBox4.TabIndex = 44;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 162);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 99);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 31);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(29, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 375);
            panel1.TabIndex = 55;
            // 
            // DetalleVentaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(569, 481);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "DetalleVentaInsertarVista";
            Text = "DetalleVentaInsertarVista";
            Load += DetalleVentaInsertarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel1;
    }
}