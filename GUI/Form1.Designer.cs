namespace GUI
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
            clienteTextBox = new TextBox();
            label2 = new Label();
            IdTextBox = new TextBox();
            label3 = new Label();
            DescTextBox = new TextBox();
            PrecioTextBox = new TextBox();
            label4 = new Label();
            cantidadTextBox = new TextBox();
            label5 = new Label();
            agregarBtn = new Button();
            detalleDataGridView = new DataGridView();
            pagarBtn = new Button();
            asignarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // clienteTextBox
            // 
            clienteTextBox.Location = new Point(92, 24);
            clienteTextBox.Name = "clienteTextBox";
            clienteTextBox.Size = new Size(405, 23);
            clienteTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(92, 54);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(80, 23);
            IdTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 62);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(260, 54);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(478, 23);
            DescTextBox.TabIndex = 5;
            // 
            // PrecioTextBox
            // 
            PrecioTextBox.Location = new Point(92, 83);
            PrecioTextBox.Name = "PrecioTextBox";
            PrecioTextBox.Size = new Size(80, 23);
            PrecioTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 91);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(260, 83);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(80, 23);
            cantidadTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 91);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad:";
            // 
            // agregarBtn
            // 
            agregarBtn.Location = new Point(27, 136);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(350, 37);
            agregarBtn.TabIndex = 10;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = true;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // detalleDataGridView
            // 
            detalleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleDataGridView.Location = new Point(31, 179);
            detalleDataGridView.Name = "detalleDataGridView";
            detalleDataGridView.Size = new Size(732, 235);
            detalleDataGridView.TabIndex = 11;
            // 
            // pagarBtn
            // 
            pagarBtn.Location = new Point(383, 136);
            pagarBtn.Name = "pagarBtn";
            pagarBtn.Size = new Size(355, 37);
            pagarBtn.TabIndex = 12;
            pagarBtn.Text = "Pagar";
            pagarBtn.UseVisualStyleBackColor = true;
            pagarBtn.Click += pagarBtn_Click;
            // 
            // asignarButton
            // 
            asignarButton.Location = new Point(513, 24);
            asignarButton.Name = "asignarButton";
            asignarButton.Size = new Size(208, 23);
            asignarButton.TabIndex = 13;
            asignarButton.Text = "Asignar";
            asignarButton.UseVisualStyleBackColor = true;
            asignarButton.Click += asignarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(794, 450);
            Controls.Add(asignarButton);
            Controls.Add(pagarBtn);
            Controls.Add(detalleDataGridView);
            Controls.Add(agregarBtn);
            Controls.Add(cantidadTextBox);
            Controls.Add(label5);
            Controls.Add(PrecioTextBox);
            Controls.Add(label4);
            Controls.Add(DescTextBox);
            Controls.Add(label3);
            Controls.Add(IdTextBox);
            Controls.Add(label2);
            Controls.Add(clienteTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox clienteTextBox;
        private Label label2;
        private TextBox IdTextBox;
        private Label label3;
        private TextBox DescTextBox;
        private TextBox PrecioTextBox;
        private Label label4;
        private TextBox cantidadTextBox;
        private Label label5;
        private Button agregarBtn;
        private DataGridView detalleDataGridView;
        private Button pagarBtn;
        private Button asignarButton;
    }
}
