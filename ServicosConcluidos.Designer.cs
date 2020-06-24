namespace PIC6
{
    partial class ServicosConcluidos
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
            this.dataGridView_Concluidos = new System.Windows.Forms.DataGridView();
            this.button_ConcluidosEditar = new System.Windows.Forms.Button();
            this.button_ConcluidosDeletar = new System.Windows.Forms.Button();
            this.button_ConcluidosSair = new System.Windows.Forms.Button();
            this.dateTimePicker_Conclusao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.textBox_Obs = new System.Windows.Forms.TextBox();
            this.textBox_Sexo = new System.Windows.Forms.TextBox();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.textBox_NomeAnimal = new System.Windows.Forms.TextBox();
            this.textBox_NomeDono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Concluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Concluidos
            // 
            this.dataGridView_Concluidos.AllowUserToAddRows = false;
            this.dataGridView_Concluidos.AllowUserToDeleteRows = false;
            this.dataGridView_Concluidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Concluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Concluidos.Location = new System.Drawing.Point(523, 39);
            this.dataGridView_Concluidos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Concluidos.Name = "dataGridView_Concluidos";
            this.dataGridView_Concluidos.ReadOnly = true;
            this.dataGridView_Concluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Concluidos.Size = new System.Drawing.Size(1370, 529);
            this.dataGridView_Concluidos.TabIndex = 0;
            this.dataGridView_Concluidos.TabStop = false;
            this.dataGridView_Concluidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Concluidos_CellClick);
            // 
            // button_ConcluidosEditar
            // 
            this.button_ConcluidosEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ConcluidosEditar.Location = new System.Drawing.Point(848, 575);
            this.button_ConcluidosEditar.Name = "button_ConcluidosEditar";
            this.button_ConcluidosEditar.Size = new System.Drawing.Size(103, 53);
            this.button_ConcluidosEditar.TabIndex = 8;
            this.button_ConcluidosEditar.Text = "Editar";
            this.button_ConcluidosEditar.UseVisualStyleBackColor = true;
            this.button_ConcluidosEditar.Click += new System.EventHandler(this.button_ConcluidosEditar_Click);
            // 
            // button_ConcluidosDeletar
            // 
            this.button_ConcluidosDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ConcluidosDeletar.Location = new System.Drawing.Point(957, 575);
            this.button_ConcluidosDeletar.Name = "button_ConcluidosDeletar";
            this.button_ConcluidosDeletar.Size = new System.Drawing.Size(103, 53);
            this.button_ConcluidosDeletar.TabIndex = 9;
            this.button_ConcluidosDeletar.Text = "Deletar";
            this.button_ConcluidosDeletar.UseVisualStyleBackColor = true;
            this.button_ConcluidosDeletar.Click += new System.EventHandler(this.button_ConcluidosDeletar_Click);
            // 
            // button_ConcluidosSair
            // 
            this.button_ConcluidosSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ConcluidosSair.Location = new System.Drawing.Point(1066, 575);
            this.button_ConcluidosSair.Name = "button_ConcluidosSair";
            this.button_ConcluidosSair.Size = new System.Drawing.Size(103, 53);
            this.button_ConcluidosSair.TabIndex = 10;
            this.button_ConcluidosSair.Text = "Sair";
            this.button_ConcluidosSair.UseVisualStyleBackColor = true;
            this.button_ConcluidosSair.Click += new System.EventHandler(this.button_ConcluidosSair_Click);
            // 
            // dateTimePicker_Conclusao
            // 
            this.dateTimePicker_Conclusao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_Conclusao.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Conclusao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Conclusao.Location = new System.Drawing.Point(136, 390);
            this.dateTimePicker_Conclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Conclusao.Name = "dateTimePicker_Conclusao";
            this.dateTimePicker_Conclusao.Size = new System.Drawing.Size(308, 22);
            this.dateTimePicker_Conclusao.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Data de conclusão";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Id.Location = new System.Drawing.Point(136, 39);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(73, 22);
            this.textBox_Id.TabIndex = 0;
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker_Inicio.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(136, 340);
            this.dateTimePicker_Inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(308, 22);
            this.dateTimePicker_Inicio.TabIndex = 5;
            // 
            // textBox_Obs
            // 
            this.textBox_Obs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Obs.Location = new System.Drawing.Point(136, 440);
            this.textBox_Obs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Obs.Multiline = true;
            this.textBox_Obs.Name = "textBox_Obs";
            this.textBox_Obs.Size = new System.Drawing.Size(311, 128);
            this.textBox_Obs.TabIndex = 7;
            // 
            // textBox_Sexo
            // 
            this.textBox_Sexo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Sexo.Location = new System.Drawing.Point(136, 280);
            this.textBox_Sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Sexo.Name = "textBox_Sexo";
            this.textBox_Sexo.Size = new System.Drawing.Size(311, 22);
            this.textBox_Sexo.TabIndex = 4;
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Tel.Location = new System.Drawing.Point(136, 220);
            this.textBox_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(311, 22);
            this.textBox_Tel.TabIndex = 3;
            // 
            // textBox_NomeAnimal
            // 
            this.textBox_NomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_NomeAnimal.Location = new System.Drawing.Point(136, 99);
            this.textBox_NomeAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NomeAnimal.Name = "textBox_NomeAnimal";
            this.textBox_NomeAnimal.Size = new System.Drawing.Size(311, 22);
            this.textBox_NomeAnimal.TabIndex = 1;
            // 
            // textBox_NomeDono
            // 
            this.textBox_NomeDono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_NomeDono.Location = new System.Drawing.Point(136, 159);
            this.textBox_NomeDono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NomeDono.Name = "textBox_NomeDono";
            this.textBox_NomeDono.Size = new System.Drawing.Size(311, 22);
            this.textBox_NomeDono.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Observações";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data de Inicio";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome do Dono";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do Animal";
            // 
            // ServicosConcluidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 653);
            this.Controls.Add(this.dateTimePicker_Conclusao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.dateTimePicker_Inicio);
            this.Controls.Add(this.textBox_Obs);
            this.Controls.Add(this.textBox_Sexo);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_NomeAnimal);
            this.Controls.Add(this.textBox_NomeDono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ConcluidosSair);
            this.Controls.Add(this.button_ConcluidosDeletar);
            this.Controls.Add(this.button_ConcluidosEditar);
            this.Controls.Add(this.dataGridView_Concluidos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicosConcluidos";
            this.Text = "ServicosConcluidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Concluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Concluidos;
        private System.Windows.Forms.Button button_ConcluidosEditar;
        private System.Windows.Forms.Button button_ConcluidosDeletar;
        private System.Windows.Forms.Button button_ConcluidosSair;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Conclusao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.TextBox textBox_Obs;
        private System.Windows.Forms.TextBox textBox_Sexo;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.TextBox textBox_NomeAnimal;
        private System.Windows.Forms.TextBox textBox_NomeDono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}