
namespace UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndividuos = new System.Windows.Forms.TextBox();
            this.txtMutacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objetivo";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(135, 10);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(379, 23);
            this.txtObjetivo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(723, 316);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(667, 72);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro. Individuos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tasa de mutación";
            // 
            // txtIndividuos
            // 
            this.txtIndividuos.Location = new System.Drawing.Point(136, 39);
            this.txtIndividuos.Name = "txtIndividuos";
            this.txtIndividuos.Size = new System.Drawing.Size(87, 23);
            this.txtIndividuos.TabIndex = 6;
            // 
            // txtMutacion
            // 
            this.txtMutacion.Location = new System.Drawing.Point(136, 68);
            this.txtMutacion.Name = "txtMutacion";
            this.txtMutacion.Size = new System.Drawing.Size(86, 23);
            this.txtMutacion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.txtMutacion);
            this.Controls.Add(this.txtIndividuos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Algoritmo Genético";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndividuos;
        private System.Windows.Forms.TextBox txtMutacion;
    }
}

