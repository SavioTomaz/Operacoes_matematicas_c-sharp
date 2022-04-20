
namespace Operações_Matemáticas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAdicao = new System.Windows.Forms.Label();
            this.txtAdicao1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdicao2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultadoAdicao = new System.Windows.Forms.Label();
            this.btnCalcularAdicao = new System.Windows.Forms.Button();
            this.btnCalcularSub = new System.Windows.Forms.Button();
            this.lblResultadoSub = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.lblSubtracao = new System.Windows.Forms.Label();
            this.btnCalcularMult = new System.Windows.Forms.Button();
            this.lblResultadoMult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMul2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMult1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcularDiv = new System.Windows.Forms.Button();
            this.lblResultadoDiv = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiv2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiv1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(252, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Operações Matemáticas";
            // 
            // lblAdicao
            // 
            this.lblAdicao.AutoSize = true;
            this.lblAdicao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdicao.Location = new System.Drawing.Point(12, 112);
            this.lblAdicao.Name = "lblAdicao";
            this.lblAdicao.Size = new System.Drawing.Size(53, 19);
            this.lblAdicao.TabIndex = 1;
            this.lblAdicao.Text = "Adição";
            // 
            // txtAdicao1
            // 
            this.txtAdicao1.Location = new System.Drawing.Point(12, 134);
            this.txtAdicao1.Name = "txtAdicao1";
            this.txtAdicao1.Size = new System.Drawing.Size(100, 23);
            this.txtAdicao1.TabIndex = 2;
            this.txtAdicao1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdicao1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // txtAdicao2
            // 
            this.txtAdicao2.Location = new System.Drawing.Point(138, 134);
            this.txtAdicao2.Name = "txtAdicao2";
            this.txtAdicao2.Size = new System.Drawing.Size(100, 23);
            this.txtAdicao2.TabIndex = 4;
            this.txtAdicao2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdicao2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // lblResultadoAdicao
            // 
            this.lblResultadoAdicao.AutoSize = true;
            this.lblResultadoAdicao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoAdicao.Location = new System.Drawing.Point(264, 137);
            this.lblResultadoAdicao.Name = "lblResultadoAdicao";
            this.lblResultadoAdicao.Size = new System.Drawing.Size(69, 19);
            this.lblResultadoAdicao.TabIndex = 6;
            this.lblResultadoAdicao.Text = "Resultado";
            // 
            // btnCalcularAdicao
            // 
            this.btnCalcularAdicao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularAdicao.Location = new System.Drawing.Point(163, 163);
            this.btnCalcularAdicao.Name = "btnCalcularAdicao";
            this.btnCalcularAdicao.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularAdicao.TabIndex = 7;
            this.btnCalcularAdicao.Text = "Calcular";
            this.btnCalcularAdicao.UseVisualStyleBackColor = true;
            this.btnCalcularAdicao.Click += new System.EventHandler(this.btnCalcularAdicao_Click);
            // 
            // btnCalcularSub
            // 
            this.btnCalcularSub.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularSub.Location = new System.Drawing.Point(163, 310);
            this.btnCalcularSub.Name = "btnCalcularSub";
            this.btnCalcularSub.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularSub.TabIndex = 14;
            this.btnCalcularSub.Text = "Calcular";
            this.btnCalcularSub.UseVisualStyleBackColor = true;
            this.btnCalcularSub.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultadoSub
            // 
            this.lblResultadoSub.AutoSize = true;
            this.lblResultadoSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoSub.Location = new System.Drawing.Point(264, 284);
            this.lblResultadoSub.Name = "lblResultadoSub";
            this.lblResultadoSub.Size = new System.Drawing.Size(69, 19);
            this.lblResultadoSub.TabIndex = 13;
            this.lblResultadoSub.Text = "Resultado";
            this.lblResultadoSub.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(244, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(138, 281);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(100, 23);
            this.txtSub2.TabIndex = 11;
            this.txtSub2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSub2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSub2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(118, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(12, 281);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(100, 23);
            this.txtSub1.TabIndex = 9;
            this.txtSub1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSub1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSub1_KeyPress);
            // 
            // lblSubtracao
            // 
            this.lblSubtracao.AutoSize = true;
            this.lblSubtracao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtracao.Location = new System.Drawing.Point(12, 259);
            this.lblSubtracao.Name = "lblSubtracao";
            this.lblSubtracao.Size = new System.Drawing.Size(71, 19);
            this.lblSubtracao.TabIndex = 8;
            this.lblSubtracao.Text = "Subtração";
            this.lblSubtracao.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCalcularMult
            // 
            this.btnCalcularMult.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularMult.Location = new System.Drawing.Point(611, 163);
            this.btnCalcularMult.Name = "btnCalcularMult";
            this.btnCalcularMult.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularMult.TabIndex = 21;
            this.btnCalcularMult.Text = "Calcular";
            this.btnCalcularMult.UseVisualStyleBackColor = true;
            this.btnCalcularMult.Click += new System.EventHandler(this.btnCalcularMult_Click);
            // 
            // lblResultadoMult
            // 
            this.lblResultadoMult.AutoSize = true;
            this.lblResultadoMult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoMult.Location = new System.Drawing.Point(712, 137);
            this.lblResultadoMult.Name = "lblResultadoMult";
            this.lblResultadoMult.Size = new System.Drawing.Size(69, 19);
            this.lblResultadoMult.TabIndex = 20;
            this.lblResultadoMult.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(692, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "=";
            // 
            // txtMul2
            // 
            this.txtMul2.Location = new System.Drawing.Point(586, 134);
            this.txtMul2.Name = "txtMul2";
            this.txtMul2.Size = new System.Drawing.Size(100, 23);
            this.txtMul2.TabIndex = 18;
            this.txtMul2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMul2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(566, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // txtMult1
            // 
            this.txtMult1.Location = new System.Drawing.Point(460, 134);
            this.txtMult1.Name = "txtMult1";
            this.txtMult1.Size = new System.Drawing.Size(100, 23);
            this.txtMult1.TabIndex = 16;
            this.txtMult1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMult1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(460, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Multiplicação";
            // 
            // btnCalcularDiv
            // 
            this.btnCalcularDiv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularDiv.Location = new System.Drawing.Point(611, 310);
            this.btnCalcularDiv.Name = "btnCalcularDiv";
            this.btnCalcularDiv.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularDiv.TabIndex = 28;
            this.btnCalcularDiv.Text = "Calcular";
            this.btnCalcularDiv.UseVisualStyleBackColor = true;
            this.btnCalcularDiv.Click += new System.EventHandler(this.btnCalcularDiv_Click);
            // 
            // lblResultadoDiv
            // 
            this.lblResultadoDiv.AutoSize = true;
            this.lblResultadoDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoDiv.Location = new System.Drawing.Point(712, 284);
            this.lblResultadoDiv.Name = "lblResultadoDiv";
            this.lblResultadoDiv.Size = new System.Drawing.Size(69, 19);
            this.lblResultadoDiv.TabIndex = 27;
            this.lblResultadoDiv.Text = "Resultado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(692, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "=";
            // 
            // txtDiv2
            // 
            this.txtDiv2.Location = new System.Drawing.Point(586, 281);
            this.txtDiv2.Name = "txtDiv2";
            this.txtDiv2.Size = new System.Drawing.Size(100, 23);
            this.txtDiv2.TabIndex = 25;
            this.txtDiv2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiv2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(566, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "/";
            // 
            // txtDiv1
            // 
            this.txtDiv1.Location = new System.Drawing.Point(460, 281);
            this.txtDiv1.Name = "txtDiv1";
            this.txtDiv1.Size = new System.Drawing.Size(100, 23);
            this.txtDiv1.TabIndex = 23;
            this.txtDiv1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiv1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(460, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Divisão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularDiv);
            this.Controls.Add(this.lblResultadoDiv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiv2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiv1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcularMult);
            this.Controls.Add(this.lblResultadoMult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMul2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMult1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcularSub);
            this.Controls.Add(this.lblResultadoSub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.lblSubtracao);
            this.Controls.Add(this.btnCalcularAdicao);
            this.Controls.Add(this.lblResultadoAdicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdicao2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdicao1);
            this.Controls.Add(this.lblAdicao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Op. Matematicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAdicao;
        private System.Windows.Forms.TextBox txtAdicao1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdicao2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultadoAdicao;
        private System.Windows.Forms.Button btnCalcularAdicao;
        private System.Windows.Forms.Button btnCalcularSub;
        private System.Windows.Forms.Label lblResultadoSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.Label lblSubtracao;
        private System.Windows.Forms.Button btnCalcularMult;
        private System.Windows.Forms.Label lblResultadoMult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMul2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMult1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcularDiv;
        private System.Windows.Forms.Label lblResultadoDiv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiv2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiv1;
        private System.Windows.Forms.Label label11;
    }
}

