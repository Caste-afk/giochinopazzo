namespace CampoAddestramentoPuffi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_campo = new System.Windows.Forms.Panel();
            this.pnl_gargamella = new System.Windows.Forms.Panel();
            this.pnl_casa = new System.Windows.Forms.Panel();
            this.pnl_player = new System.Windows.Forms.Panel();
            this.btn_sinistra = new System.Windows.Forms.Button();
            this.btn_giu = new System.Windows.Forms.Button();
            this.btn_su = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_destra = new System.Windows.Forms.Button();
            this.lbl_punteggio1 = new System.Windows.Forms.Label();
            this.lbl_punteggiop = new System.Windows.Forms.Label();
            this.lbl_punteggiog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_campo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_campo
            // 
            this.pnl_campo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_campo.Controls.Add(this.pnl_gargamella);
            this.pnl_campo.Controls.Add(this.pnl_casa);
            this.pnl_campo.Controls.Add(this.pnl_player);
            this.pnl_campo.Location = new System.Drawing.Point(12, 12);
            this.pnl_campo.Name = "pnl_campo";
            this.pnl_campo.Size = new System.Drawing.Size(560, 440);
            this.pnl_campo.TabIndex = 0;
            // 
            // pnl_gargamella
            // 
            this.pnl_gargamella.BackColor = System.Drawing.Color.Black;
            this.pnl_gargamella.Location = new System.Drawing.Point(520, 400);
            this.pnl_gargamella.Name = "pnl_gargamella";
            this.pnl_gargamella.Size = new System.Drawing.Size(40, 40);
            this.pnl_gargamella.TabIndex = 2;
            // 
            // pnl_casa
            // 
            this.pnl_casa.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_casa.Location = new System.Drawing.Point(458, 30);
            this.pnl_casa.Name = "pnl_casa";
            this.pnl_casa.Size = new System.Drawing.Size(40, 40);
            this.pnl_casa.TabIndex = 1;
            // 
            // pnl_player
            // 
            this.pnl_player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_player.Location = new System.Drawing.Point(0, 0);
            this.pnl_player.Name = "pnl_player";
            this.pnl_player.Size = new System.Drawing.Size(40, 40);
            this.pnl_player.TabIndex = 0;
            // 
            // btn_sinistra
            // 
            this.btn_sinistra.Location = new System.Drawing.Point(3, 3);
            this.btn_sinistra.Name = "btn_sinistra";
            this.tableLayoutPanel1.SetRowSpan(this.btn_sinistra, 2);
            this.btn_sinistra.Size = new System.Drawing.Size(67, 151);
            this.btn_sinistra.TabIndex = 2;
            this.btn_sinistra.Text = "sinistra";
            this.btn_sinistra.UseVisualStyleBackColor = true;
            this.btn_sinistra.Click += new System.EventHandler(this.btn_sinistra_Click);
            // 
            // btn_giu
            // 
            this.btn_giu.Location = new System.Drawing.Point(76, 81);
            this.btn_giu.Name = "btn_giu";
            this.btn_giu.Size = new System.Drawing.Size(67, 73);
            this.btn_giu.TabIndex = 1;
            this.btn_giu.Text = "giu";
            this.btn_giu.UseVisualStyleBackColor = true;
            this.btn_giu.Click += new System.EventHandler(this.btn_giu_Click);
            // 
            // btn_su
            // 
            this.btn_su.Location = new System.Drawing.Point(76, 3);
            this.btn_su.Name = "btn_su";
            this.btn_su.Size = new System.Drawing.Size(67, 72);
            this.btn_su.TabIndex = 0;
            this.btn_su.Text = "su";
            this.btn_su.UseVisualStyleBackColor = true;
            this.btn_su.Click += new System.EventHandler(this.btn_su_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn_giu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_sinistra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_destra, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_su, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(586, 297);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_destra
            // 
            this.btn_destra.Location = new System.Drawing.Point(149, 3);
            this.btn_destra.Name = "btn_destra";
            this.tableLayoutPanel1.SetRowSpan(this.btn_destra, 2);
            this.btn_destra.Size = new System.Drawing.Size(68, 151);
            this.btn_destra.TabIndex = 3;
            this.btn_destra.Text = "destra";
            this.btn_destra.UseVisualStyleBackColor = true;
            this.btn_destra.Click += new System.EventHandler(this.btn_destra_Click);
            // 
            // lbl_punteggio1
            // 
            this.lbl_punteggio1.Location = new System.Drawing.Point(589, 14);
            this.lbl_punteggio1.Name = "lbl_punteggio1";
            this.lbl_punteggio1.Size = new System.Drawing.Size(203, 40);
            this.lbl_punteggio1.TabIndex = 1;
            this.lbl_punteggio1.Text = "PUNTEGGIO PUFFO\r\n";
            // 
            // lbl_punteggiop
            // 
            this.lbl_punteggiop.Location = new System.Drawing.Point(589, 44);
            this.lbl_punteggiop.Name = "lbl_punteggiop";
            this.lbl_punteggiop.Size = new System.Drawing.Size(203, 40);
            this.lbl_punteggiop.TabIndex = 2;
            this.lbl_punteggiop.Text = "0";
            // 
            // lbl_punteggiog
            // 
            this.lbl_punteggiog.Location = new System.Drawing.Point(589, 114);
            this.lbl_punteggiog.Name = "lbl_punteggiog";
            this.lbl_punteggiog.Size = new System.Drawing.Size(203, 40);
            this.lbl_punteggiog.TabIndex = 4;
            this.lbl_punteggiog.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(589, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUNTEGGIO GARGAMELLA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 466);
            this.Controls.Add(this.lbl_punteggiog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_punteggiop);
            this.Controls.Add(this.lbl_punteggio1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_campo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_campo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_campo;
        private System.Windows.Forms.Button btn_sinistra;
        private System.Windows.Forms.Button btn_giu;
        private System.Windows.Forms.Button btn_su;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_destra;
        private System.Windows.Forms.Panel pnl_player;
        private System.Windows.Forms.Panel pnl_casa;
        private System.Windows.Forms.Label lbl_punteggio1;
        private System.Windows.Forms.Label lbl_punteggiop;
        private System.Windows.Forms.Panel pnl_gargamella;
        private System.Windows.Forms.Label lbl_punteggiog;
        private System.Windows.Forms.Label label2;
    }
}

