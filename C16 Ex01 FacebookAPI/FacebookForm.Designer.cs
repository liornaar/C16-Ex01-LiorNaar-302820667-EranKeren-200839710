using System.Collections.Generic;
using System.Windows.Forms;

namespace C16_Ex01_FacebookAPI
{
    partial class FacebookForm
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
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.m_CoverPicture = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.songPostButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_SongUrl = new System.Windows.Forms.TextBox();
            this.m_SongNameTextBox = new System.Windows.Forms.TextBox();
            this.m_ArtistTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mutualFriendPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutualFriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ButtonLogin
            // 
            this.m_ButtonLogin.Location = new System.Drawing.Point(372, 46);
            this.m_ButtonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(171, 39);
            this.m_ButtonLogin.TabIndex = 0;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = true;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_CoverPicture
            // 
            this.m_CoverPicture.Location = new System.Drawing.Point(0, 1);
            this.m_CoverPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CoverPicture.Name = "m_CoverPicture";
            this.m_CoverPicture.Size = new System.Drawing.Size(877, 190);
            this.m_CoverPicture.TabIndex = 1;
            this.m_CoverPicture.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(29, 122);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(133, 126);
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(372, 92);
            this.rememberMeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.rememberMeCheckBox.TabIndex = 3;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 206);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 4;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.Location = new System.Drawing.Point(212, 209);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(48, 17);
            this.postLabel.TabIndex = 5;
            this.postLabel.Text = "Status";
            // 
            // postButton
            // 
            this.postButton.Enabled = false;
            this.postButton.Location = new System.Drawing.Point(523, 206);
            this.postButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 30);
            this.postButton.TabIndex = 6;
            this.postButton.Text = "Post!";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Upcoming Events";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(248, 268);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posts";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 244);
            this.listBox1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.songPostButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.m_SongUrl);
            this.groupBox2.Controls.Add(this.m_SongNameTextBox);
            this.groupBox2.Controls.Add(this.m_ArtistTextBox);
            this.groupBox2.Location = new System.Drawing.Point(627, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(237, 310);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post Song + Lyrics!";
            // 
            // songPostButton
            // 
            this.songPostButton.Enabled = false;
            this.songPostButton.Location = new System.Drawing.Point(44, 231);
            this.songPostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songPostButton.Name = "songPostButton";
            this.songPostButton.Size = new System.Drawing.Size(171, 39);
            this.songPostButton.TabIndex = 28;
            this.songPostButton.Text = "Post!";
            this.songPostButton.UseVisualStyleBackColor = true;
            this.songPostButton.Click += new System.EventHandler(this.songPostButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Song Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Artist Name";
            // 
            // m_SongUrl
            // 
            this.m_SongUrl.Location = new System.Drawing.Point(39, 180);
            this.m_SongUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_SongUrl.Name = "m_SongUrl";
            this.m_SongUrl.Size = new System.Drawing.Size(181, 22);
            this.m_SongUrl.TabIndex = 2;
            // 
            // m_SongNameTextBox
            // 
            this.m_SongNameTextBox.Location = new System.Drawing.Point(39, 121);
            this.m_SongNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_SongNameTextBox.Name = "m_SongNameTextBox";
            this.m_SongNameTextBox.Size = new System.Drawing.Size(181, 22);
            this.m_SongNameTextBox.TabIndex = 1;
            this.m_SongNameTextBox.TextChanged += new System.EventHandler(this.songName_TextChanged);
            // 
            // m_ArtistTextBox
            // 
            this.m_ArtistTextBox.Location = new System.Drawing.Point(39, 66);
            this.m_ArtistTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ArtistTextBox.Name = "m_ArtistTextBox";
            this.m_ArtistTextBox.Size = new System.Drawing.Size(181, 22);
            this.m_ArtistTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mutualFriendPictureBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(293, 254);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(304, 238);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mutual Friend";
            // 
            // mutualFriendPictureBox
            // 
            this.mutualFriendPictureBox.Location = new System.Drawing.Point(81, 55);
            this.mutualFriendPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutualFriendPictureBox.Name = "mutualFriendPictureBox";
            this.mutualFriendPictureBox.Size = new System.Drawing.Size(133, 126);
            this.mutualFriendPictureBox.TabIndex = 29;
            this.mutualFriendPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(91, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tell me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Who is my friend with most mutual friends?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 545);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(848, 175);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 722);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.m_ButtonLogin);
            this.Controls.Add(this.m_CoverPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FacebookForm";
            this.Text = "dw";
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutualFriendPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_ButtonLogin;
        private System.Windows.Forms.PictureBox m_CoverPicture;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Label label5;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_SongUrl;
        private System.Windows.Forms.TextBox m_ArtistTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox mutualFriendPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button songPostButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private List<Button> m_ButtonsList;
        private TextBox m_SongNameTextBox;
    }
}

