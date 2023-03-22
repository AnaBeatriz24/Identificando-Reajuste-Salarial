
namespace Identificando_Reajuste_Salarial
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
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnCalouro = new System.Windows.Forms.RadioButton();
            this.rbnVeterano = new System.Windows.Forms.RadioButton();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbnMatutino = new System.Windows.Forms.RadioButton();
            this.rbnVespertino = new System.Windows.Forms.RadioButton();
            this.rbnNoturno = new System.Windows.Forms.RadioButton();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxResumo
            // 
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 15;
            this.lbxResumo.Location = new System.Drawing.Point(40, 206);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(607, 124);
            this.lbxResumo.TabIndex = 0;
            this.lbxResumo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas Trabalhadas";
            // 
            // rbnCalouro
            // 
            this.rbnCalouro.AutoSize = true;
            this.rbnCalouro.Location = new System.Drawing.Point(6, 45);
            this.rbnCalouro.Name = "rbnCalouro";
            this.rbnCalouro.Size = new System.Drawing.Size(67, 19);
            this.rbnCalouro.TabIndex = 3;
            this.rbnCalouro.TabStop = true;
            this.rbnCalouro.Text = "Calouro";
            this.rbnCalouro.UseVisualStyleBackColor = true;
            this.rbnCalouro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnVeterano
            // 
            this.rbnVeterano.AutoSize = true;
            this.rbnVeterano.Location = new System.Drawing.Point(137, 45);
            this.rbnVeterano.Name = "rbnVeterano";
            this.rbnVeterano.Size = new System.Drawing.Size(71, 19);
            this.rbnVeterano.TabIndex = 4;
            this.rbnVeterano.TabStop = true;
            this.rbnVeterano.Text = "Veterano";
            this.rbnVeterano.UseVisualStyleBackColor = true;
            this.rbnVeterano.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbnCalouro);
            this.gbxCategoria.Controls.Add(this.rbnVeterano);
            this.gbxCategoria.Location = new System.Drawing.Point(40, 99);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(243, 82);
            this.gbxCategoria.TabIndex = 5;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbnNoturno);
            this.gbxTurno.Controls.Add(this.rbnVespertino);
            this.gbxTurno.Controls.Add(this.rbnMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(447, 35);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(200, 100);
            this.gbxTurno.TabIndex = 6;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbnMatutino
            // 
            this.rbnMatutino.AutoSize = true;
            this.rbnMatutino.Location = new System.Drawing.Point(24, 23);
            this.rbnMatutino.Name = "rbnMatutino";
            this.rbnMatutino.Size = new System.Drawing.Size(74, 19);
            this.rbnMatutino.TabIndex = 0;
            this.rbnMatutino.TabStop = true;
            this.rbnMatutino.Text = "Matutino";
            this.rbnMatutino.UseVisualStyleBackColor = true;
            // 
            // rbnVespertino
            // 
            this.rbnVespertino.AutoSize = true;
            this.rbnVespertino.Location = new System.Drawing.Point(24, 49);
            this.rbnVespertino.Name = "rbnVespertino";
            this.rbnVespertino.Size = new System.Drawing.Size(80, 19);
            this.rbnVespertino.TabIndex = 1;
            this.rbnVespertino.TabStop = true;
            this.rbnVespertino.Text = "Vespertino";
            this.rbnVespertino.UseVisualStyleBackColor = true;
            this.rbnVespertino.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbnNoturno
            // 
            this.rbnNoturno.AutoSize = true;
            this.rbnNoturno.Location = new System.Drawing.Point(24, 75);
            this.rbnNoturno.Name = "rbnNoturno";
            this.rbnNoturno.Size = new System.Drawing.Size(70, 19);
            this.rbnNoturno.TabIndex = 2;
            this.rbnNoturno.TabStop = true;
            this.rbnNoturno.Text = "Noturno";
            this.rbnNoturno.UseVisualStyleBackColor = true;
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(40, 402);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(354, 23);
            this.txtSituacaoEstagiario.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(158, 21);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtSalarioMinimo.TabIndex = 9;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(158, 50);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 23);
            this.txtHorasTrabalhadas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxResumo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnCalouro;
        private System.Windows.Forms.RadioButton rbnVeterano;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbnNoturno;
        private System.Windows.Forms.RadioButton rbnVespertino;
        private System.Windows.Forms.RadioButton rbnMatutino;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
    }
}

