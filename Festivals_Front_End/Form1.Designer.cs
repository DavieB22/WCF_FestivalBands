namespace Festivals_Front_End
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComBoxFestivals = new System.Windows.Forms.ComboBox();
            this.listBoxBands = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Festivals And Bands";
            // 
            // ComBoxFestivals
            // 
            this.ComBoxFestivals.FormattingEnabled = true;
            this.ComBoxFestivals.Items.AddRange(new object[] {
            "Boomtown Fair",
            "Green Man Festival",
            "Download Festival",
            "Leeds Festival",
            "Parlife Festival"});
            this.ComBoxFestivals.Location = new System.Drawing.Point(22, 195);
            this.ComBoxFestivals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ComBoxFestivals.Name = "ComBoxFestivals";
            this.ComBoxFestivals.Size = new System.Drawing.Size(199, 26);
            this.ComBoxFestivals.TabIndex = 1;
            this.ComBoxFestivals.SelectedIndexChanged += new System.EventHandler(this.comBoxFestivals_SelectedIndexChanged);
            // 
            // listBoxBands
            // 
            this.listBoxBands.FormattingEnabled = true;
            this.listBoxBands.ItemHeight = 18;
            this.listBoxBands.Location = new System.Drawing.Point(22, 324);
            this.listBoxBands.Name = "listBoxBands";
            this.listBoxBands.Size = new System.Drawing.Size(276, 238);
            this.listBoxBands.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 585);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(463, 582);
            this.Controls.Add(this.listBoxBands);
            this.Controls.Add(this.ComBoxFestivals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Festival_Front_End";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBoxFestivals;
        private System.Windows.Forms.ListBox listBoxBands;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

