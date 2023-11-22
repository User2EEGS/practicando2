namespace practica3_1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtTelegrama = new RichTextBox();
            button1 = new Button();
            txtPrecio = new TextBox();
            ordinario = new RadioButton();
            urgente = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 235);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Coste:";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(45, 59);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(389, 96);
            txtTelegrama.TabIndex = 2;
            txtTelegrama.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(296, 220);
            button1.Name = "button1";
            button1.Size = new Size(138, 35);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(102, 232);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 23);
            txtPrecio.TabIndex = 5;
            // 
            // ordinario
            // 
            ordinario.AutoSize = true;
            ordinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordinario.Location = new Point(45, 170);
            ordinario.Name = "ordinario";
            ordinario.Size = new Size(85, 23);
            ordinario.TabIndex = 6;
            ordinario.TabStop = true;
            ordinario.Text = "Ordinario";
            ordinario.UseVisualStyleBackColor = true;
            ordinario.CheckedChanged += ordinario_CheckedChanged;
            // 
            // urgente
            // 
            urgente.AutoSize = true;
            urgente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            urgente.Location = new Point(139, 170);
            urgente.Name = "urgente";
            urgente.Size = new Size(77, 23);
            urgente.TabIndex = 7;
            urgente.TabStop = true;
            urgente.Text = "Urgente";
            urgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 294);
            Controls.Add(urgente);
            Controls.Add(ordinario);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(txtTelegrama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox txtTelegrama;
        private Button button1;
        private TextBox txtPrecio;
        private RadioButton ordinario;
        private RadioButton urgente;
    }
}