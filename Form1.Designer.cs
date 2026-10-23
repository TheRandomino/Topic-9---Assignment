namespace Topic_9___Assignment
{
    partial class Form1
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
            this.lblGood = new System.Windows.Forms.Label();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.lblBad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGood
            // 
            this.lblGood.BackColor = System.Drawing.Color.Transparent;
            this.lblGood.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblGood.Location = new System.Drawing.Point(293, -30);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(248, 97);
            this.lblGood.TabIndex = 0;
            this.lblGood.Text = "I\'m so joyful!";
            this.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGood.Visible = false;
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(12, 415);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 23);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.Location = new System.Drawing.Point(93, 415);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(75, 23);
            this.btnBad.TabIndex = 2;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = true;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // lblBad
            // 
            this.lblBad.BackColor = System.Drawing.Color.Transparent;
            this.lblBad.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBad.ForeColor = System.Drawing.Color.Red;
            this.lblBad.Location = new System.Drawing.Point(293, 36);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(248, 97);
            this.lblBad.TabIndex = 3;
            this.lblBad.Text = "I\'m so HATEFUL!";
            this.lblBad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Topic_9___Assignment.Properties.Resources.hell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.lblGood);
            this.Name = "Form1";
            this.Text = "MAD!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label lblBad;
    }
}

