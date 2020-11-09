namespace SimpleGame
{
    partial class Game_form
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.Btn_shoot = new System.Windows.Forms.Button();
            this.PicBox_Main = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(88, 324);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 49);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(316, 324);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(75, 49);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // Btn_shoot
            // 
            this.Btn_shoot.Location = new System.Drawing.Point(500, 324);
            this.Btn_shoot.Name = "Btn_shoot";
            this.Btn_shoot.Size = new System.Drawing.Size(75, 49);
            this.Btn_shoot.TabIndex = 2;
            this.Btn_shoot.Text = "Shoot";
            this.Btn_shoot.UseVisualStyleBackColor = true;
            // 
            // PicBox_Main
            // 
            this.PicBox_Main.Location = new System.Drawing.Point(180, 63);
            this.PicBox_Main.Name = "PicBox_Main";
            this.PicBox_Main.Size = new System.Drawing.Size(386, 200);
            this.PicBox_Main.TabIndex = 3;
            this.PicBox_Main.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(640, 85);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 49);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Btn_PlayAgain
            // 
            this.Btn_PlayAgain.Location = new System.Drawing.Point(640, 195);
            this.Btn_PlayAgain.Name = "Btn_PlayAgain";
            this.Btn_PlayAgain.Size = new System.Drawing.Size(75, 49);
            this.Btn_PlayAgain.TabIndex = 5;
            this.Btn_PlayAgain.Text = "Play Again";
            this.Btn_PlayAgain.UseVisualStyleBackColor = true;
            this.Btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_PlayAgain);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.PicBox_Main);
            this.Controls.Add(this.Btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Name = "Game_form";
            this.Text = "Game Form";
            this.Load += new System.EventHandler(this.Game_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button Btn_shoot;
        private System.Windows.Forms.PictureBox PicBox_Main;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_PlayAgain;
    }
}

