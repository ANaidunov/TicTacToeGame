namespace TicTacToeGame {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.NGameBtn = new System.Windows.Forms.Button();
            this.ResBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 28);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(128, 123);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 157);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(128, 123);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 286);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(128, 123);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(146, 286);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(128, 123);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(146, 157);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(128, 123);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(146, 28);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(128, 123);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(280, 286);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(128, 123);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(280, 157);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(128, 123);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(280, 28);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(128, 123);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NGameBtn
            // 
            this.NGameBtn.Location = new System.Drawing.Point(12, 442);
            this.NGameBtn.Name = "NGameBtn";
            this.NGameBtn.Size = new System.Drawing.Size(128, 37);
            this.NGameBtn.TabIndex = 9;
            this.NGameBtn.Text = "New Game";
            this.NGameBtn.UseVisualStyleBackColor = true;
            this.NGameBtn.Click += new System.EventHandler(this.NGameBtn_Click);
            // 
            // ResBtn
            // 
            this.ResBtn.Location = new System.Drawing.Point(146, 442);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(128, 37);
            this.ResBtn.TabIndex = 10;
            this.ResBtn.Text = "Reset";
            this.ResBtn.UseVisualStyleBackColor = true;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(483, 544);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(128, 37);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(465, 81);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(126, 38);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(465, 210);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(126, 38);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(465, 339);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(126, 38);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 593);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResBtn);
            this.Controls.Add(this.NGameBtn);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button NGameBtn;
        private System.Windows.Forms.Button ResBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
    }
}

