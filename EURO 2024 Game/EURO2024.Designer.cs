namespace EURO_2024_Game
{
    partial class EURO2024
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
            this.btnPickUser = new System.Windows.Forms.Button();
            this.btnPickResults = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.tbStandings = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPickUser
            // 
            this.btnPickUser.Location = new System.Drawing.Point(31, 337);
            this.btnPickUser.Name = "btnPickUser";
            this.btnPickUser.Size = new System.Drawing.Size(155, 43);
            this.btnPickUser.TabIndex = 0;
            this.btnPickUser.Text = "Pick user txt";
            this.btnPickUser.UseVisualStyleBackColor = true;
            this.btnPickUser.Click += new System.EventHandler(this.btnPickUser_Click);
            // 
            // btnPickResults
            // 
            this.btnPickResults.Location = new System.Drawing.Point(266, 337);
            this.btnPickResults.Name = "btnPickResults";
            this.btnPickResults.Size = new System.Drawing.Size(155, 43);
            this.btnPickResults.TabIndex = 1;
            this.btnPickResults.Text = "Pick results txt";
            this.btnPickResults.UseVisualStyleBackColor = true;
            this.btnPickResults.Click += new System.EventHandler(this.btnPickResults_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(633, 395);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(155, 43);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbUsers
            // 
            this.tbUsers.Location = new System.Drawing.Point(31, 41);
            this.tbUsers.Multiline = true;
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(155, 290);
            this.tbUsers.TabIndex = 3;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(266, 41);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(155, 290);
            this.tbResults.TabIndex = 4;
            // 
            // tbStandings
            // 
            this.tbStandings.Location = new System.Drawing.Point(633, 41);
            this.tbStandings.Multiline = true;
            this.tbStandings.Name = "tbStandings";
            this.tbStandings.Size = new System.Drawing.Size(155, 290);
            this.tbStandings.TabIndex = 5;
            // 
            // EURO2024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStandings);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnPickResults);
            this.Controls.Add(this.btnPickUser);
            this.Name = "EURO2024";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickUser;
        private System.Windows.Forms.Button btnPickResults;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbUsers;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.TextBox tbStandings;
    }
}

