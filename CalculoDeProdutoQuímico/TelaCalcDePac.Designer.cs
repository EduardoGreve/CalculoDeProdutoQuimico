
namespace CalculoDeProdutoQuímico
{
    partial class TelaCalcDePac
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCalcDePac));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBomba1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtConcPac = new System.Windows.Forms.TextBox();
            this.txtResultadoVolume = new System.Windows.Forms.TextBox();
            this.btnCalcularVolume = new System.Windows.Forms.Button();
            this.cbxCalc2Bombas = new System.Windows.Forms.CheckBox();
            this.lblCalcDoSinal = new System.Windows.Forms.Label();
            this.lblSinalAnterior = new System.Windows.Forms.Label();
            this.lblNovoVol = new System.Windows.Forms.Label();
            this.lblVolAnterior = new System.Windows.Forms.Label();
            this.lblResultadoSinal = new System.Windows.Forms.Label();
            this.txtSinalAnt = new System.Windows.Forms.TextBox();
            this.txtNovoVol = new System.Windows.Forms.TextBox();
            this.txtVolumeAnt = new System.Windows.Forms.TextBox();
            this.txtResultadoSinal = new System.Windows.Forms.TextBox();
            this.btnCalcularSinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do volume";
            // 
            // lblBomba1
            // 
            this.lblBomba1.AutoSize = true;
            this.lblBomba1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomba1.Location = new System.Drawing.Point(12, 34);
            this.lblBomba1.Name = "lblBomba1";
            this.lblBomba1.Size = new System.Drawing.Size(138, 11);
            this.lblBomba1.TabIndex = 1;
            this.lblBomba1.Text = "Concentração de PAC";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(165, 34);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 11);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtConcPac
            // 
            this.txtConcPac.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcPac.Location = new System.Drawing.Point(12, 48);
            this.txtConcPac.Name = "txtConcPac";
            this.txtConcPac.Size = new System.Drawing.Size(138, 18);
            this.txtConcPac.TabIndex = 3;
            // 
            // txtResultadoVolume
            // 
            this.txtResultadoVolume.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoVolume.Location = new System.Drawing.Point(167, 48);
            this.txtResultadoVolume.Name = "txtResultadoVolume";
            this.txtResultadoVolume.ReadOnly = true;
            this.txtResultadoVolume.Size = new System.Drawing.Size(138, 18);
            this.txtResultadoVolume.TabIndex = 4;
            // 
            // btnCalcularVolume
            // 
            this.btnCalcularVolume.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularVolume.Location = new System.Drawing.Point(12, 72);
            this.btnCalcularVolume.Name = "btnCalcularVolume";
            this.btnCalcularVolume.Size = new System.Drawing.Size(138, 23);
            this.btnCalcularVolume.TabIndex = 5;
            this.btnCalcularVolume.Text = "Calcular";
            this.btnCalcularVolume.UseVisualStyleBackColor = true;
            this.btnCalcularVolume.Click += new System.EventHandler(this.btnCalcularVolume_Click);
            // 
            // cbxCalc2Bombas
            // 
            this.cbxCalc2Bombas.AutoSize = true;
            this.cbxCalc2Bombas.Font = new System.Drawing.Font("Lucida Console", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCalc2Bombas.Location = new System.Drawing.Point(167, 77);
            this.cbxCalc2Bombas.Name = "cbxCalc2Bombas";
            this.cbxCalc2Bombas.Size = new System.Drawing.Size(134, 14);
            this.cbxCalc2Bombas.TabIndex = 6;
            this.cbxCalc2Bombas.Text = "Calcular duas bombas ?";
            this.cbxCalc2Bombas.UseVisualStyleBackColor = true;
            this.cbxCalc2Bombas.CheckedChanged += new System.EventHandler(this.cbxCalc2Bombas_CheckedChanged);
            // 
            // lblCalcDoSinal
            // 
            this.lblCalcDoSinal.AutoSize = true;
            this.lblCalcDoSinal.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcDoSinal.Location = new System.Drawing.Point(9, 137);
            this.lblCalcDoSinal.Name = "lblCalcDoSinal";
            this.lblCalcDoSinal.Size = new System.Drawing.Size(151, 15);
            this.lblCalcDoSinal.TabIndex = 7;
            this.lblCalcDoSinal.Text = "Calculo do sinal";
            // 
            // lblSinalAnterior
            // 
            this.lblSinalAnterior.AutoSize = true;
            this.lblSinalAnterior.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinalAnterior.Location = new System.Drawing.Point(13, 166);
            this.lblSinalAnterior.Name = "lblSinalAnterior";
            this.lblSinalAnterior.Size = new System.Drawing.Size(103, 11);
            this.lblSinalAnterior.TabIndex = 8;
            this.lblSinalAnterior.Text = "Sinal anterior";
            // 
            // lblNovoVol
            // 
            this.lblNovoVol.AutoSize = true;
            this.lblNovoVol.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoVol.Location = new System.Drawing.Point(165, 166);
            this.lblNovoVol.Name = "lblNovoVol";
            this.lblNovoVol.Size = new System.Drawing.Size(82, 11);
            this.lblNovoVol.TabIndex = 9;
            this.lblNovoVol.Text = "Novo volume";
            // 
            // lblVolAnterior
            // 
            this.lblVolAnterior.AutoSize = true;
            this.lblVolAnterior.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolAnterior.Location = new System.Drawing.Point(12, 212);
            this.lblVolAnterior.Name = "lblVolAnterior";
            this.lblVolAnterior.Size = new System.Drawing.Size(110, 11);
            this.lblVolAnterior.TabIndex = 10;
            this.lblVolAnterior.Text = "Volume anterior";
            // 
            // lblResultadoSinal
            // 
            this.lblResultadoSinal.AutoSize = true;
            this.lblResultadoSinal.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSinal.Location = new System.Drawing.Point(165, 212);
            this.lblResultadoSinal.Name = "lblResultadoSinal";
            this.lblResultadoSinal.Size = new System.Drawing.Size(68, 11);
            this.lblResultadoSinal.TabIndex = 11;
            this.lblResultadoSinal.Text = "Resultado";
            // 
            // txtSinalAnt
            // 
            this.txtSinalAnt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinalAnt.Location = new System.Drawing.Point(12, 180);
            this.txtSinalAnt.Name = "txtSinalAnt";
            this.txtSinalAnt.Size = new System.Drawing.Size(138, 18);
            this.txtSinalAnt.TabIndex = 12;
            // 
            // txtNovoVol
            // 
            this.txtNovoVol.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoVol.Location = new System.Drawing.Point(156, 180);
            this.txtNovoVol.Name = "txtNovoVol";
            this.txtNovoVol.Size = new System.Drawing.Size(138, 18);
            this.txtNovoVol.TabIndex = 13;
            // 
            // txtVolumeAnt
            // 
            this.txtVolumeAnt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeAnt.Location = new System.Drawing.Point(12, 226);
            this.txtVolumeAnt.Name = "txtVolumeAnt";
            this.txtVolumeAnt.Size = new System.Drawing.Size(138, 18);
            this.txtVolumeAnt.TabIndex = 14;
            // 
            // txtResultadoSinal
            // 
            this.txtResultadoSinal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoSinal.Location = new System.Drawing.Point(158, 226);
            this.txtResultadoSinal.Name = "txtResultadoSinal";
            this.txtResultadoSinal.ReadOnly = true;
            this.txtResultadoSinal.Size = new System.Drawing.Size(138, 18);
            this.txtResultadoSinal.TabIndex = 15;
            // 
            // btnCalcularSinal
            // 
            this.btnCalcularSinal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSinal.Location = new System.Drawing.Point(12, 250);
            this.btnCalcularSinal.Name = "btnCalcularSinal";
            this.btnCalcularSinal.Size = new System.Drawing.Size(138, 23);
            this.btnCalcularSinal.TabIndex = 16;
            this.btnCalcularSinal.Text = "Calcular";
            this.btnCalcularSinal.UseVisualStyleBackColor = true;
            this.btnCalcularSinal.Click += new System.EventHandler(this.btnCalcularSinal_Click);
            // 
            // TelaCalcDePac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 311);
            this.Controls.Add(this.btnCalcularSinal);
            this.Controls.Add(this.txtResultadoSinal);
            this.Controls.Add(this.txtVolumeAnt);
            this.Controls.Add(this.txtNovoVol);
            this.Controls.Add(this.txtSinalAnt);
            this.Controls.Add(this.lblResultadoSinal);
            this.Controls.Add(this.lblVolAnterior);
            this.Controls.Add(this.lblNovoVol);
            this.Controls.Add(this.lblSinalAnterior);
            this.Controls.Add(this.lblCalcDoSinal);
            this.Controls.Add(this.cbxCalc2Bombas);
            this.Controls.Add(this.btnCalcularVolume);
            this.Controls.Add(this.txtResultadoVolume);
            this.Controls.Add(this.txtConcPac);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblBomba1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCalcDePac";
            this.Text = "Calculo de PAC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBomba1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtConcPac;
        private System.Windows.Forms.TextBox txtResultadoVolume;
        private System.Windows.Forms.Button btnCalcularVolume;
        private System.Windows.Forms.CheckBox cbxCalc2Bombas;
        private System.Windows.Forms.Label lblCalcDoSinal;
        private System.Windows.Forms.Label lblSinalAnterior;
        private System.Windows.Forms.Label lblNovoVol;
        private System.Windows.Forms.Label lblVolAnterior;
        private System.Windows.Forms.Label lblResultadoSinal;
        private System.Windows.Forms.TextBox txtSinalAnt;
        private System.Windows.Forms.TextBox txtNovoVol;
        private System.Windows.Forms.TextBox txtVolumeAnt;
        private System.Windows.Forms.TextBox txtResultadoSinal;
        private System.Windows.Forms.Button btnCalcularSinal;
    }
}

