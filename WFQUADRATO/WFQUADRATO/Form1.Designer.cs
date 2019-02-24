namespace WFQUADRATO
{
    partial class Form_Menu
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
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_X = new System.Windows.Forms.TextBox();
            this.TB_Y = new System.Windows.Forms.TextBox();
            this.B_X = new System.Windows.Forms.Button();
            this.B_Y = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_L = new System.Windows.Forms.TextBox();
            this.B_L = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Q = new System.Windows.Forms.Button();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.LB_P = new System.Windows.Forms.Label();
            this.TB_P = new System.Windows.Forms.TextBox();
            this.BT_A = new System.Windows.Forms.Button();
            this.BT_P = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Panel();
            this.BT_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb.Font = new System.Drawing.Font("Miriam Libre", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(13, 13);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(364, 35);
            this.lb.TabIndex = 0;
            this.lb.Text = "GESTIONE CLASSE QUADRATO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_X
            // 
            this.TB_X.Location = new System.Drawing.Point(36, 61);
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(100, 20);
            this.TB_X.TabIndex = 3;
            // 
            // TB_Y
            // 
            this.TB_Y.Location = new System.Drawing.Point(36, 88);
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Size = new System.Drawing.Size(100, 20);
            this.TB_Y.TabIndex = 4;
            // 
            // B_X
            // 
            this.B_X.Location = new System.Drawing.Point(143, 57);
            this.B_X.Name = "B_X";
            this.B_X.Size = new System.Drawing.Size(75, 23);
            this.B_X.TabIndex = 5;
            this.B_X.Text = "Cambia X";
            this.B_X.UseVisualStyleBackColor = true;
            this.B_X.Click += new System.EventHandler(this.B_X_Click);
            // 
            // B_Y
            // 
            this.B_Y.Location = new System.Drawing.Point(142, 86);
            this.B_Y.Name = "B_Y";
            this.B_Y.Size = new System.Drawing.Size(75, 23);
            this.B_Y.TabIndex = 6;
            this.B_Y.Text = "Cambia Y";
            this.B_Y.UseVisualStyleBackColor = true;
            this.B_Y.Click += new System.EventHandler(this.B_Y_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "L";
            // 
            // TB_L
            // 
            this.TB_L.Location = new System.Drawing.Point(36, 114);
            this.TB_L.Name = "TB_L";
            this.TB_L.Size = new System.Drawing.Size(100, 20);
            this.TB_L.TabIndex = 8;
            // 
            // B_L
            // 
            this.B_L.Location = new System.Drawing.Point(142, 113);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(75, 23);
            this.B_L.TabIndex = 9;
            this.B_L.Text = "Cambia L";
            this.B_L.UseVisualStyleBackColor = true;
            this.B_L.Click += new System.EventHandler(this.B_L_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AREA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // B_Q
            // 
            this.B_Q.Location = new System.Drawing.Point(233, 63);
            this.B_Q.Name = "B_Q";
            this.B_Q.Size = new System.Drawing.Size(102, 47);
            this.B_Q.TabIndex = 11;
            this.B_Q.Text = "CREA QUADRATO";
            this.B_Q.UseVisualStyleBackColor = true;
            this.B_Q.Click += new System.EventHandler(this.B_Q_Click);
            // 
            // TB_A
            // 
            this.TB_A.Location = new System.Drawing.Point(418, 62);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(100, 20);
            this.TB_A.TabIndex = 12;
            // 
            // LB_P
            // 
            this.LB_P.AutoSize = true;
            this.LB_P.Location = new System.Drawing.Point(341, 93);
            this.LB_P.Name = "LB_P";
            this.LB_P.Size = new System.Drawing.Size(71, 13);
            this.LB_P.TabIndex = 13;
            this.LB_P.Text = "PERIMETRO";
            // 
            // TB_P
            // 
            this.TB_P.Location = new System.Drawing.Point(418, 90);
            this.TB_P.Name = "TB_P";
            this.TB_P.Size = new System.Drawing.Size(100, 20);
            this.TB_P.TabIndex = 14;
            // 
            // BT_A
            // 
            this.BT_A.Location = new System.Drawing.Point(524, 57);
            this.BT_A.Name = "BT_A";
            this.BT_A.Size = new System.Drawing.Size(75, 23);
            this.BT_A.TabIndex = 15;
            this.BT_A.Text = "Calcola";
            this.BT_A.UseVisualStyleBackColor = true;
            this.BT_A.Click += new System.EventHandler(this.BT_A_Click);
            // 
            // BT_P
            // 
            this.BT_P.Location = new System.Drawing.Point(524, 87);
            this.BT_P.Name = "BT_P";
            this.BT_P.Size = new System.Drawing.Size(75, 23);
            this.BT_P.TabIndex = 16;
            this.BT_P.Text = "Calcola";
            this.BT_P.UseVisualStyleBackColor = true;
            this.BT_P.Click += new System.EventHandler(this.BT_P_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(12, 155);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(776, 283);
            this.P.TabIndex = 17;
            this.P.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Paint);
            // 
            // BT_C
            // 
            this.BT_C.Location = new System.Drawing.Point(233, 112);
            this.BT_C.Name = "BT_C";
            this.BT_C.Size = new System.Drawing.Size(102, 23);
            this.BT_C.TabIndex = 18;
            this.BT_C.Text = "CREA";
            this.BT_C.UseVisualStyleBackColor = true;
            this.BT_C.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_C);
            this.Controls.Add(this.P);
            this.Controls.Add(this.BT_P);
            this.Controls.Add(this.BT_A);
            this.Controls.Add(this.TB_P);
            this.Controls.Add(this.LB_P);
            this.Controls.Add(this.TB_A);
            this.Controls.Add(this.B_Q);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.TB_L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_Y);
            this.Controls.Add(this.B_X);
            this.Controls.Add(this.TB_Y);
            this.Controls.Add(this.TB_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb);
            this.Name = "Form_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_X;
        private System.Windows.Forms.TextBox TB_Y;
        private System.Windows.Forms.Button B_X;
        private System.Windows.Forms.Button B_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_L;
        private System.Windows.Forms.Button B_L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Q;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.Label LB_P;
        private System.Windows.Forms.TextBox TB_P;
        private System.Windows.Forms.Button BT_A;
        private System.Windows.Forms.Button BT_P;
        private System.Windows.Forms.Panel P;
        private System.Windows.Forms.Button BT_C;
    }
}

