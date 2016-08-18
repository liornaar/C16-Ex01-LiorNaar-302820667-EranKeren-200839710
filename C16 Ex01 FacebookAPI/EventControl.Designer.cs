namespace C16_Ex01_FacebookAPI
{
    partial class EventControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLocation1 = new System.Windows.Forms.Label();
            this.inLabel1 = new System.Windows.Forms.Label();
            this.eventPicture1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLocation1
            // 
            this.eventLocation1.AutoSize = true;
            this.eventLocation1.Location = new System.Drawing.Point(39, 100);
            this.eventLocation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventLocation1.Name = "eventLocation1";
            this.eventLocation1.Size = new System.Drawing.Size(57, 13);
            this.eventLocation1.TabIndex = 23;
            this.eventLocation1.Text = "eventCity1";
            // 
            // inLabel1
            // 
            this.inLabel1.AutoSize = true;
            this.inLabel1.Location = new System.Drawing.Point(17, 100);
            this.inLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inLabel1.Name = "inLabel1";
            this.inLabel1.Size = new System.Drawing.Size(20, 13);
            this.inLabel1.TabIndex = 22;
            this.inLabel1.Text = "At:";
            // 
            // eventPicture1
            // 
            this.eventPicture1.Location = new System.Drawing.Point(16, 13);
            this.eventPicture1.Margin = new System.Windows.Forms.Padding(2);
            this.eventPicture1.Name = "eventPicture1";
            this.eventPicture1.Size = new System.Drawing.Size(102, 79);
            this.eventPicture1.TabIndex = 21;
            this.eventPicture1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 79);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "name";
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.eventLocation1);
            this.Controls.Add(this.inLabel1);
            this.Controls.Add(this.eventPicture1);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(133, 130);
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventLocation1;
        private System.Windows.Forms.Label inLabel1;
        private System.Windows.Forms.PictureBox eventPicture1;
        private System.Windows.Forms.Label labelName;
    }
}
