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
            this.btn_su = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_giu = new System.Windows.Forms.Button();
            this.btn_destra = new System.Windows.Forms.Button();
            this.lbl_punteggio1 = new System.Windows.Forms.Label();
            this.lbl_punteggiop = new System.Windows.Forms.Label();
            this.lbl_punteggiog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            this.pnl_campo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_campo
            // 
            this.pnl_campo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(89)))));
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
            this.pnl_gargamella.BackgroundImage = global::CampoAddestramentoPuffi.Properties.Resources.Gargamella;
            this.pnl_gargamella.Location = new System.Drawing.Point(520, 400);
            this.pnl_gargamella.Name = "pnl_gargamella";
            this.pnl_gargamella.Size = new System.Drawing.Size(40, 40);
            this.pnl_gargamella.TabIndex = 2;
            // 
            // pnl_casa
            // 
            this.pnl_casa.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_casa.BackgroundImage = global::CampoAddestramentoPuffi.Properties.Resources.casa;
            this.pnl_casa.Location = new System.Drawing.Point(458, 30);
            this.pnl_casa.Name = "pnl_casa";
            this.pnl_casa.Size = new System.Drawing.Size(40, 40);
            this.pnl_casa.TabIndex = 1;
            // 
            // pnl_player
            // 
            this.pnl_player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_player.BackgroundImage = global::CampoAddestramentoPuffi.Properties.Resources.puffo;
            this.pnl_player.Location = new System.Drawing.Point(0, 0);
            this.pnl_player.Name = "pnl_player";
            this.pnl_player.Size = new System.Drawing.Size(40, 40);
            this.pnl_player.TabIndex = 0;
            // 
            // btn_sinistra
            // 
            this.btn_sinistra.BackColor = System.Drawing.Color.Transparent;
            this.btn_sinistra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinistra.Image = global::CampoAddestramentoPuffi.Properties.Resources.sinstra;
            this.btn_sinistra.Location = new System.Drawing.Point(3, 3);
            this.btn_sinistra.Name = "btn_sinistra";
            this.tableLayoutPanel1.SetRowSpan(this.btn_sinistra, 2);
            this.btn_sinistra.Size = new System.Drawing.Size(67, 151);
            this.btn_sinistra.TabIndex = 2;
            this.btn_sinistra.UseVisualStyleBackColor = false;
            this.btn_sinistra.Click += new System.EventHandler(this.btn_sinistra_Click);
            // 
            // btn_su
            // 
            this.btn_su.BackColor = System.Drawing.Color.Transparent;
            this.btn_su.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_su.Image = global::CampoAddestramentoPuffi.Properties.Resources.su;
            this.btn_su.Location = new System.Drawing.Point(76, 3);
            this.btn_su.Name = "btn_su";
            this.btn_su.Size = new System.Drawing.Size(67, 72);
            this.btn_su.TabIndex = 0;
            this.btn_su.UseVisualStyleBackColor = false;
            this.btn_su.Click += new System.EventHandler(this.btn_su_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn_giu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_sinistra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_destra, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_su, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(586, 297);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_giu
            // 
            this.btn_giu.BackColor = System.Drawing.Color.Transparent;
            this.btn_giu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giu.Image = global::CampoAddestramentoPuffi.Properties.Resources.giu;
            this.btn_giu.Location = new System.Drawing.Point(76, 81);
            this.btn_giu.Name = "btn_giu";
            this.btn_giu.Size = new System.Drawing.Size(67, 73);
            this.btn_giu.TabIndex = 1;
            this.btn_giu.UseVisualStyleBackColor = false;
            this.btn_giu.Click += new System.EventHandler(this.btn_giu_Click);
            // 
            // btn_destra
            // 
            this.btn_destra.BackColor = System.Drawing.Color.White;
            this.btn_destra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_destra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_destra.ForeColor = System.Drawing.Color.Transparent;
            this.btn_destra.Image = global::CampoAddestramentoPuffi.Properties.Resources.destra;
            this.btn_destra.Location = new System.Drawing.Point(149, 3);
            this.btn_destra.Name = "btn_destra";
            this.tableLayoutPanel1.SetRowSpan(this.btn_destra, 2);
            this.btn_destra.Size = new System.Drawing.Size(68, 151);
            this.btn_destra.TabIndex = 3;
            this.btn_destra.UseVisualStyleBackColor = false;
            this.btn_destra.Click += new System.EventHandler(this.btn_destra_Click);
            // 
            // lbl_punteggio1
            // 
            this.lbl_punteggio1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_punteggio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punteggio1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punteggio1.Location = new System.Drawing.Point(5, 0);
            this.lbl_punteggio1.Name = "lbl_punteggio1";
            this.lbl_punteggio1.Size = new System.Drawing.Size(100, 41);
            this.lbl_punteggio1.TabIndex = 1;
            this.lbl_punteggio1.Text = "PUNTEGGIO PUFFO\r\n";
            // 
            // lbl_punteggiop
            // 
            this.lbl_punteggiop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_punteggiop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punteggiop.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punteggiop.Location = new System.Drawing.Point(5, 41);
            this.lbl_punteggiop.Name = "lbl_punteggiop";
            this.lbl_punteggiop.Size = new System.Drawing.Size(100, 47);
            this.lbl_punteggiop.TabIndex = 2;
            this.lbl_punteggiop.Text = "0";
            // 
            // lbl_punteggiog
            // 
            this.lbl_punteggiog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_punteggiog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punteggiog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punteggiog.Location = new System.Drawing.Point(115, 41);
            this.lbl_punteggiog.Name = "lbl_punteggiog";
            this.lbl_punteggiog.Size = new System.Drawing.Size(100, 47);
            this.lbl_punteggiog.TabIndex = 4;
            this.lbl_punteggiog.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUNTEGGIO GARGAMELLA";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_punteggio1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_punteggiop, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_punteggiog, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(594, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.45378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.54622F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 119);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_turno, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(594, 142);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 105);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TURNO DI:";
            // 
            // lbl_turno
            // 
            this.lbl_turno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_turno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_turno.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno.Location = new System.Drawing.Point(3, 40);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(214, 47);
            this.lbl_turno.TabIndex = 2;
            this.lbl_turno.Text = "Puffo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 466);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_campo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_campo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_turno;
    }
}

