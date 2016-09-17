using System.Collections.Generic;
using System.Windows.Forms;

namespace C16_Ex01_FacebookAPI
{
    public partial class FacebookForm
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
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.m_PostTextBox = new System.Windows.Forms.TextBox();
            this.m_PostLabel = new System.Windows.Forms.Label();
            this.m_PostButton = new System.Windows.Forms.Button();
            this.m_EventsLabel = new System.Windows.Forms.Label();
            this.m_EventLog = new System.Diagnostics.EventLog();
            this.m_PostsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_PostsListBox = new System.Windows.Forms.ListBox();
            this.m_LyricsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_LyricsErrorLabel = new System.Windows.Forms.Label();
            this.m_SongPostButton = new System.Windows.Forms.Button();
            this.m_SongUrlLabel = new System.Windows.Forms.Label();
            this.m_SongTitleLabel = new System.Windows.Forms.Label();
            this.m_ArtistLabel = new System.Windows.Forms.Label();
            this.m_SongUrl = new System.Windows.Forms.TextBox();
            this.m_SongNameTextBox = new System.Windows.Forms.TextBox();
            this.m_ArtistTextBox = new System.Windows.Forms.TextBox();
            this.m_PictureStatGroupBox = new System.Windows.Forms.GroupBox();
            this.m_MostCommentedPictureLabel = new System.Windows.Forms.Label();
            this.m_MostLikedPictureLabel = new System.Windows.Forms.Label();
            this.m_MostCommentedPictureBox = new System.Windows.Forms.PictureBox();
            this.m_MostLikedPictureBox = new System.Windows.Forms.PictureBox();
            this.m_EventsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.m_LoadingLabelLike = new System.Windows.Forms.Label();
            this.m_LoadingLabelComment = new System.Windows.Forms.Label();
            this.m_QuotesGroupBox = new System.Windows.Forms.GroupBox();
            this.m_MotivationalRadio = new System.Windows.Forms.RadioButton();
            this.m_PhilosophicalRadio = new System.Windows.Forms.RadioButton();
            this.m_FunnyRadio = new System.Windows.Forms.RadioButton();
            this.m_QuoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EventLog)).BeginInit();
            this.m_PostsGroupBox.SuspendLayout();
            this.m_LyricsGroupBox.SuspendLayout();
            this.m_PictureStatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MostCommentedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MostLikedPictureBox)).BeginInit();
            this.m_QuotesGroupBox.SuspendLayout();
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
            // m_ProfilePicture
            // 
            this.m_ProfilePicture.Location = new System.Drawing.Point(29, 122);
            this.m_ProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ProfilePicture.Name = "m_ProfilePicture";
            this.m_ProfilePicture.Size = new System.Drawing.Size(133, 126);
            this.m_ProfilePicture.TabIndex = 2;
            this.m_ProfilePicture.TabStop = false;
            // 
            // m_RememberMeCheckBox
            // 
            this.m_RememberMeCheckBox.AutoSize = true;
            this.m_RememberMeCheckBox.Location = new System.Drawing.Point(372, 92);
            this.m_RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_RememberMeCheckBox.Name = "m_RememberMeCheckBox";
            this.m_RememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.m_RememberMeCheckBox.TabIndex = 3;
            this.m_RememberMeCheckBox.Text = "Remember me";
            this.m_RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_PostTextBox
            // 
            this.m_PostTextBox.Location = new System.Drawing.Point(263, 206);
            this.m_PostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PostTextBox.Name = "m_PostTextBox";
            this.m_PostTextBox.Size = new System.Drawing.Size(255, 22);
            this.m_PostTextBox.TabIndex = 4;
            // 
            // m_PostLabel
            // 
            this.m_PostLabel.AutoSize = true;
            this.m_PostLabel.Location = new System.Drawing.Point(212, 209);
            this.m_PostLabel.Name = "m_PostLabel";
            this.m_PostLabel.Size = new System.Drawing.Size(48, 17);
            this.m_PostLabel.TabIndex = 5;
            this.m_PostLabel.Text = "Status";
            // 
            // m_PostButton
            // 
            this.m_PostButton.Enabled = false;
            this.m_PostButton.Location = new System.Drawing.Point(523, 206);
            this.m_PostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PostButton.Name = "m_PostButton";
            this.m_PostButton.Size = new System.Drawing.Size(75, 30);
            this.m_PostButton.TabIndex = 6;
            this.m_PostButton.Text = "Post!";
            this.m_PostButton.UseVisualStyleBackColor = true;
            this.m_PostButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // m_EventsLabel
            // 
            this.m_EventsLabel.AutoSize = true;
            this.m_EventsLabel.Location = new System.Drawing.Point(389, 505);
            this.m_EventsLabel.Name = "m_EventsLabel";
            this.m_EventsLabel.Size = new System.Drawing.Size(118, 17);
            this.m_EventsLabel.TabIndex = 25;
            this.m_EventsLabel.Text = "Upcoming Events";
            // 
            // m_EventLog
            // 
            this.m_EventLog.SynchronizingObject = this;
            // 
            // m_PostsGroupBox
            // 
            this.m_PostsGroupBox.Controls.Add(this.m_PostsListBox);
            this.m_PostsGroupBox.Location = new System.Drawing.Point(12, 254);
            this.m_PostsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PostsGroupBox.Name = "m_PostsGroupBox";
            this.m_PostsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PostsGroupBox.Size = new System.Drawing.Size(230, 165);
            this.m_PostsGroupBox.TabIndex = 26;
            this.m_PostsGroupBox.TabStop = false;
            this.m_PostsGroupBox.Text = "Posts";
            // 
            // m_PostsListBox
            // 
            this.m_PostsListBox.FormattingEnabled = true;
            this.m_PostsListBox.ItemHeight = 16;
            this.m_PostsListBox.Location = new System.Drawing.Point(3, 21);
            this.m_PostsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PostsListBox.Name = "m_PostsListBox";
            this.m_PostsListBox.Size = new System.Drawing.Size(221, 132);
            this.m_PostsListBox.TabIndex = 27;
            // 
            // m_LyricsGroupBox
            // 
            this.m_LyricsGroupBox.Controls.Add(this.m_LyricsErrorLabel);
            this.m_LyricsGroupBox.Controls.Add(this.m_SongPostButton);
            this.m_LyricsGroupBox.Controls.Add(this.m_SongUrlLabel);
            this.m_LyricsGroupBox.Controls.Add(this.m_SongTitleLabel);
            this.m_LyricsGroupBox.Controls.Add(this.m_ArtistLabel);
            this.m_LyricsGroupBox.Controls.Add(this.m_SongUrl);
            this.m_LyricsGroupBox.Controls.Add(this.m_SongNameTextBox);
            this.m_LyricsGroupBox.Controls.Add(this.m_ArtistTextBox);
            this.m_LyricsGroupBox.Location = new System.Drawing.Point(627, 209);
            this.m_LyricsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_LyricsGroupBox.Name = "m_LyricsGroupBox";
            this.m_LyricsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_LyricsGroupBox.Size = new System.Drawing.Size(237, 310);
            this.m_LyricsGroupBox.TabIndex = 27;
            this.m_LyricsGroupBox.TabStop = false;
            this.m_LyricsGroupBox.Text = "Post Song + Lyrics!";
            // 
            // m_LyricsErrorLabel
            // 
            this.m_LyricsErrorLabel.AutoSize = true;
            this.m_LyricsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.m_LyricsErrorLabel.Location = new System.Drawing.Point(44, 281);
            this.m_LyricsErrorLabel.Name = "m_LyricsErrorLabel";
            this.m_LyricsErrorLabel.Size = new System.Drawing.Size(171, 17);
            this.m_LyricsErrorLabel.TabIndex = 29;
            this.m_LyricsErrorLabel.Text = "Error: Could not find lyrics";
            this.m_LyricsErrorLabel.Visible = false;
            // 
            // m_SongPostButton
            // 
            this.m_SongPostButton.Enabled = false;
            this.m_SongPostButton.Location = new System.Drawing.Point(44, 231);
            this.m_SongPostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_SongPostButton.Name = "m_SongPostButton";
            this.m_SongPostButton.Size = new System.Drawing.Size(171, 39);
            this.m_SongPostButton.TabIndex = 28;
            this.m_SongPostButton.Text = "Post!";
            this.m_SongPostButton.UseVisualStyleBackColor = true;
            this.m_SongPostButton.Click += new System.EventHandler(this.songPostButton_Click);
            // 
            // m_SongUrlLabel
            // 
            this.m_SongUrlLabel.AutoSize = true;
            this.m_SongUrlLabel.Location = new System.Drawing.Point(39, 160);
            this.m_SongUrlLabel.Name = "m_SongUrlLabel";
            this.m_SongUrlLabel.Size = new System.Drawing.Size(36, 17);
            this.m_SongUrlLabel.TabIndex = 5;
            this.m_SongUrlLabel.Text = "URL";
            // 
            // m_SongTitleLabel
            // 
            this.m_SongTitleLabel.AutoSize = true;
            this.m_SongTitleLabel.Location = new System.Drawing.Point(39, 101);
            this.m_SongTitleLabel.Name = "m_SongTitleLabel";
            this.m_SongTitleLabel.Size = new System.Drawing.Size(72, 17);
            this.m_SongTitleLabel.TabIndex = 4;
            this.m_SongTitleLabel.Text = "Song Title";
            // 
            // m_ArtistLabel
            // 
            this.m_ArtistLabel.AutoSize = true;
            this.m_ArtistLabel.Location = new System.Drawing.Point(39, 43);
            this.m_ArtistLabel.Name = "m_ArtistLabel";
            this.m_ArtistLabel.Size = new System.Drawing.Size(81, 17);
            this.m_ArtistLabel.TabIndex = 3;
            this.m_ArtistLabel.Text = "Artist Name";
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
            // 
            // m_ArtistTextBox
            // 
            this.m_ArtistTextBox.Location = new System.Drawing.Point(39, 66);
            this.m_ArtistTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ArtistTextBox.Name = "m_ArtistTextBox";
            this.m_ArtistTextBox.Size = new System.Drawing.Size(181, 22);
            this.m_ArtistTextBox.TabIndex = 0;
            // 
            // m_PictureStatGroupBox
            // 
            this.m_PictureStatGroupBox.Controls.Add(this.m_LoadingLabelComment);
            this.m_PictureStatGroupBox.Controls.Add(this.m_LoadingLabelLike);
            this.m_PictureStatGroupBox.Controls.Add(this.m_MostCommentedPictureLabel);
            this.m_PictureStatGroupBox.Controls.Add(this.m_MostLikedPictureLabel);
            this.m_PictureStatGroupBox.Controls.Add(this.m_MostCommentedPictureBox);
            this.m_PictureStatGroupBox.Controls.Add(this.m_MostLikedPictureBox);
            this.m_PictureStatGroupBox.Location = new System.Drawing.Point(248, 254);
            this.m_PictureStatGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PictureStatGroupBox.Name = "m_PictureStatGroupBox";
            this.m_PictureStatGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_PictureStatGroupBox.Size = new System.Drawing.Size(373, 238);
            this.m_PictureStatGroupBox.TabIndex = 28;
            this.m_PictureStatGroupBox.TabStop = false;
            this.m_PictureStatGroupBox.Text = "Picture Statistics";
            // 
            // m_MostCommentedPictureLabel
            // 
            this.m_MostCommentedPictureLabel.AutoSize = true;
            this.m_MostCommentedPictureLabel.Location = new System.Drawing.Point(213, 208);
            this.m_MostCommentedPictureLabel.Name = "m_MostCommentedPictureLabel";
            this.m_MostCommentedPictureLabel.Size = new System.Drawing.Size(117, 17);
            this.m_MostCommentedPictureLabel.TabIndex = 33;
            this.m_MostCommentedPictureLabel.Text = "Most Commented";
            // 
            // m_MostLikedPictureLabel
            // 
            this.m_MostLikedPictureLabel.AutoSize = true;
            this.m_MostLikedPictureLabel.Location = new System.Drawing.Point(51, 210);
            this.m_MostLikedPictureLabel.Name = "m_MostLikedPictureLabel";
            this.m_MostLikedPictureLabel.Size = new System.Drawing.Size(76, 17);
            this.m_MostLikedPictureLabel.TabIndex = 32;
            this.m_MostLikedPictureLabel.Text = "Most Liked";
            // 
            // m_MostCommentedPictureBox
            // 
            this.m_MostCommentedPictureBox.Location = new System.Drawing.Point(192, 56);
            this.m_MostCommentedPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_MostCommentedPictureBox.Name = "m_MostCommentedPictureBox";
            this.m_MostCommentedPictureBox.Size = new System.Drawing.Size(149, 139);
            this.m_MostCommentedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_MostCommentedPictureBox.TabIndex = 30;
            this.m_MostCommentedPictureBox.TabStop = false;
            // 
            // m_MostLikedPictureBox
            // 
            this.m_MostLikedPictureBox.Location = new System.Drawing.Point(15, 55);
            this.m_MostLikedPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_MostLikedPictureBox.Name = "m_MostLikedPictureBox";
            this.m_MostLikedPictureBox.Size = new System.Drawing.Size(155, 138);
            this.m_MostLikedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_MostLikedPictureBox.TabIndex = 29;
            this.m_MostLikedPictureBox.TabStop = false;
            // 
            // m_EventsLayout
            // 
            this.m_EventsLayout.AutoScroll = true;
            this.m_EventsLayout.Location = new System.Drawing.Point(12, 545);
            this.m_EventsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.m_EventsLayout.Name = "m_EventsLayout";
            this.m_EventsLayout.Size = new System.Drawing.Size(848, 175);
            this.m_EventsLayout.TabIndex = 29;
            // 
            // m_LoadingLabelLike
            // 
            this.m_LoadingLabelLike.AutoSize = true;
            this.m_LoadingLabelLike.Location = new System.Drawing.Point(56, 115);
            this.m_LoadingLabelLike.Name = "m_LoadingLabelLike";
            this.m_LoadingLabelLike.Size = new System.Drawing.Size(71, 17);
            this.m_LoadingLabelLike.TabIndex = 34;
            this.m_LoadingLabelLike.Text = "Loading...";
            this.m_LoadingLabelLike.Visible = false;
            // 
            // m_LoadingLabelComment
            // 
            this.m_LoadingLabelComment.AutoSize = true;
            this.m_LoadingLabelComment.Location = new System.Drawing.Point(249, 115);
            this.m_LoadingLabelComment.Name = "m_LoadingLabelComment";
            this.m_LoadingLabelComment.Size = new System.Drawing.Size(71, 17);
            this.m_LoadingLabelComment.TabIndex = 35;
            this.m_LoadingLabelComment.Text = "Loading...";
            this.m_LoadingLabelComment.Visible = false;
            // 
            // m_QuotesGroupBox
            // 
            this.m_QuotesGroupBox.Controls.Add(this.m_QuoteButton);
            this.m_QuotesGroupBox.Controls.Add(this.m_FunnyRadio);
            this.m_QuotesGroupBox.Controls.Add(this.m_PhilosophicalRadio);
            this.m_QuotesGroupBox.Controls.Add(this.m_MotivationalRadio);
            this.m_QuotesGroupBox.Location = new System.Drawing.Point(18, 419);
            this.m_QuotesGroupBox.Name = "m_QuotesGroupBox";
            this.m_QuotesGroupBox.Size = new System.Drawing.Size(218, 100);
            this.m_QuotesGroupBox.TabIndex = 30;
            this.m_QuotesGroupBox.TabStop = false;
            this.m_QuotesGroupBox.Text = "Choose Your Qoute";
            this.m_QuotesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // m_MotivationalRadio
            // 
            this.m_MotivationalRadio.AutoSize = true;
            this.m_MotivationalRadio.Location = new System.Drawing.Point(7, 22);
            this.m_MotivationalRadio.Name = "m_MotivationalRadio";
            this.m_MotivationalRadio.Size = new System.Drawing.Size(104, 21);
            this.m_MotivationalRadio.TabIndex = 0;
            this.m_MotivationalRadio.TabStop = true;
            this.m_MotivationalRadio.Text = "Motivational";
            this.m_MotivationalRadio.UseVisualStyleBackColor = true;
            // 
            // m_PhilosophicalRadio
            // 
            this.m_PhilosophicalRadio.AutoSize = true;
            this.m_PhilosophicalRadio.Location = new System.Drawing.Point(7, 52);
            this.m_PhilosophicalRadio.Name = "m_PhilosophicalRadio";
            this.m_PhilosophicalRadio.Size = new System.Drawing.Size(112, 21);
            this.m_PhilosophicalRadio.TabIndex = 1;
            this.m_PhilosophicalRadio.TabStop = true;
            this.m_PhilosophicalRadio.Text = "Philosophical";
            this.m_PhilosophicalRadio.UseVisualStyleBackColor = true;
            // 
            // m_FunnyRadio
            // 
            this.m_FunnyRadio.AutoSize = true;
            this.m_FunnyRadio.Location = new System.Drawing.Point(6, 79);
            this.m_FunnyRadio.Name = "m_FunnyRadio";
            this.m_FunnyRadio.Size = new System.Drawing.Size(68, 21);
            this.m_FunnyRadio.TabIndex = 2;
            this.m_FunnyRadio.TabStop = true;
            this.m_FunnyRadio.Text = "Funny";
            this.m_FunnyRadio.UseVisualStyleBackColor = true;
            // 
            // m_QuoteButton
            // 
            this.m_QuoteButton.Enabled = false;
            this.m_QuoteButton.Location = new System.Drawing.Point(135, 45);
            this.m_QuoteButton.Name = "m_QuoteButton";
            this.m_QuoteButton.Size = new System.Drawing.Size(77, 23);
            this.m_QuoteButton.TabIndex = 3;
            this.m_QuoteButton.Text = "Post";
            this.m_QuoteButton.UseVisualStyleBackColor = true;
            this.m_QuoteButton.Click += new System.EventHandler(this.m_QuoteButton_Click);
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 722);
            this.Controls.Add(this.m_QuotesGroupBox);
            this.Controls.Add(this.m_EventsLayout);
            this.Controls.Add(this.m_PictureStatGroupBox);
            this.Controls.Add(this.m_LyricsGroupBox);
            this.Controls.Add(this.m_PostsGroupBox);
            this.Controls.Add(this.m_EventsLabel);
            this.Controls.Add(this.m_PostButton);
            this.Controls.Add(this.m_PostLabel);
            this.Controls.Add(this.m_PostTextBox);
            this.Controls.Add(this.m_RememberMeCheckBox);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_ButtonLogin);
            this.Controls.Add(this.m_CoverPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FacebookForm";
            this.Text = "dw";
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EventLog)).EndInit();
            this.m_PostsGroupBox.ResumeLayout(false);
            this.m_LyricsGroupBox.ResumeLayout(false);
            this.m_LyricsGroupBox.PerformLayout();
            this.m_PictureStatGroupBox.ResumeLayout(false);
            this.m_PictureStatGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MostCommentedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MostLikedPictureBox)).EndInit();
            this.m_QuotesGroupBox.ResumeLayout(false);
            this.m_QuotesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_ButtonLogin;
        private System.Windows.Forms.PictureBox m_CoverPicture;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.CheckBox m_RememberMeCheckBox;
        private System.Windows.Forms.TextBox m_PostTextBox;
        private System.Windows.Forms.Label m_PostLabel;
        private System.Windows.Forms.Button m_PostButton;
        private System.Windows.Forms.Label m_EventsLabel;
        private System.Diagnostics.EventLog m_EventLog;
        private System.Windows.Forms.GroupBox m_PostsGroupBox;
        private System.Windows.Forms.ListBox m_PostsListBox;
        private System.Windows.Forms.GroupBox m_LyricsGroupBox;
        private System.Windows.Forms.Label m_ArtistLabel;
        private System.Windows.Forms.TextBox m_SongUrl;
        private System.Windows.Forms.TextBox m_ArtistTextBox;
        private System.Windows.Forms.GroupBox m_PictureStatGroupBox;
        private System.Windows.Forms.PictureBox m_MostLikedPictureBox;
        private System.Windows.Forms.Button m_SongPostButton;
        private System.Windows.Forms.Label m_SongUrlLabel;
        private System.Windows.Forms.Label m_SongTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel m_EventsLayout;
        private List<Button> m_ButtonsList;
        private TextBox m_SongNameTextBox;
        private Label m_MostCommentedPictureLabel;
        private Label m_MostLikedPictureLabel;
        private PictureBox m_MostCommentedPictureBox;
        private Label m_LyricsErrorLabel;
        private Label m_LoadingLabelComment;
        private Label m_LoadingLabelLike;
        private GroupBox m_QuotesGroupBox;
        private RadioButton m_MotivationalRadio;
        private Button m_QuoteButton;
        private RadioButton m_FunnyRadio;
        private RadioButton m_PhilosophicalRadio;
    }
}
