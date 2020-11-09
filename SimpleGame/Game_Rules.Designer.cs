namespace SimpleGame
{
    partial class Game_Rules
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
            this.lbl_rules = new System.Windows.Forms.Label();
            this.lbl_rule_1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rules
            // 
            this.lbl_rules.AutoSize = true;
            this.lbl_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rules.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_rules.Location = new System.Drawing.Point(328, 31);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(55, 20);
            this.lbl_rules.TabIndex = 0;
            this.lbl_rules.Text = "Rules";
            // 
            // lbl_rule_1
            // 
            this.lbl_rule_1.AutoSize = true;
            this.lbl_rule_1.Location = new System.Drawing.Point(139, 74);
            this.lbl_rule_1.Name = "lbl_rule_1";
            this.lbl_rule_1.Size = new System.Drawing.Size(72, 13);
            this.lbl_rule_1.TabIndex = 1;
            this.lbl_rule_1.Text = "1. Load Bullet";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(596, 349);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Game_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_rule_1);
            this.Controls.Add(this.lbl_rules);
            this.Name = "Game_Rules";
            this.Text = "Game_Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rules;
        private System.Windows.Forms.Label lbl_rule_1;
        private System.Windows.Forms.Button btn_back;
    }
}