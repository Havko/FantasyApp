namespace fantasyapp
{
    partial class MyFantasyApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateLineup = new System.Windows.Forms.Button();
            this.qb = new System.Windows.Forms.Label();
            this.qbUpdate = new System.Windows.Forms.TextBox();
            this.confirmUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Fantasy Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "QB";
            // 
            // updateLineup
            // 
            this.updateLineup.Location = new System.Drawing.Point(557, 26);
            this.updateLineup.Name = "updateLineup";
            this.updateLineup.Size = new System.Drawing.Size(128, 23);
            this.updateLineup.TabIndex = 9;
            this.updateLineup.Text = "Update Lineup";
            this.updateLineup.UseVisualStyleBackColor = true;
            this.updateLineup.Click += new System.EventHandler(this.updateLineup_Click);
            // 
            // qb
            // 
            this.qb.AutoSize = true;
            this.qb.Location = new System.Drawing.Point(259, 97);
            this.qb.Name = "qb";
            this.qb.Size = new System.Drawing.Size(53, 13);
            this.qb.TabIndex = 10;
            this.qb.Text = "No Player";
            // 
            // qbUpdate
            // 
            this.qbUpdate.Location = new System.Drawing.Point(249, 113);
            this.qbUpdate.Name = "qbUpdate";
            this.qbUpdate.Size = new System.Drawing.Size(173, 20);
            this.qbUpdate.TabIndex = 11;
            this.qbUpdate.Visible = false;
          
            // 
            // confirmUpdate
            // 
            this.confirmUpdate.Location = new System.Drawing.Point(449, 92);
            this.confirmUpdate.Name = "confirmUpdate";
            this.confirmUpdate.Size = new System.Drawing.Size(75, 23);
            this.confirmUpdate.TabIndex = 12;
            this.confirmUpdate.Text = "Confirm";
            this.confirmUpdate.UseVisualStyleBackColor = true;
            this.confirmUpdate.Visible = false;
            this.confirmUpdate.Click += new System.EventHandler(this.confirmUpdate_Click);
            // 
            // MyFantasyApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(925, 620);
            this.Controls.Add(this.confirmUpdate);
            this.Controls.Add(this.qbUpdate);
            this.Controls.Add(this.qb);
            this.Controls.Add(this.updateLineup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyFantasyApp";
            this.Text = "My Fantasy App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateLineup;
        private System.Windows.Forms.Label qb;
        private System.Windows.Forms.TextBox qbUpdate;
        private System.Windows.Forms.Button confirmUpdate;
    }
}

