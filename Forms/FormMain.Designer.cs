namespace RaidArmyDS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconSettings = new FontAwesome.Sharp.IconButton();
            this.iconDiscord = new FontAwesome.Sharp.IconButton();
            this.iconProfile = new FontAwesome.Sharp.IconButton();
            this.iconSpam = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureLogoGif = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkGetOwnToken = new MetroFramework.Controls.MetroLink();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.iconConsole = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoGif)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.iconSettings);
            this.panelMenu.Controls.Add(this.iconDiscord);
            this.panelMenu.Controls.Add(this.iconProfile);
            this.panelMenu.Controls.Add(this.iconSpam);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 361);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Resize += new System.EventHandler(this.panelMenu_Resize);
            // 
            // iconSettings
            // 
            this.iconSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconSettings.FlatAppearance.BorderSize = 0;
            this.iconSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSettings.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconSettings.IconSize = 32;
            this.iconSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.Location = new System.Drawing.Point(0, 300);
            this.iconSettings.Name = "iconSettings";
            this.iconSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconSettings.Rotation = 0D;
            this.iconSettings.Size = new System.Drawing.Size(220, 60);
            this.iconSettings.TabIndex = 0;
            this.iconSettings.Text = "Configs";
            this.iconSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSettings.UseVisualStyleBackColor = true;
            this.iconSettings.Click += new System.EventHandler(this.iconSettings_Click);
            // 
            // iconDiscord
            // 
            this.iconDiscord.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDiscord.FlatAppearance.BorderSize = 0;
            this.iconDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDiscord.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconDiscord.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconDiscord.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.iconDiscord.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconDiscord.IconSize = 32;
            this.iconDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDiscord.Location = new System.Drawing.Point(0, 240);
            this.iconDiscord.Name = "iconDiscord";
            this.iconDiscord.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconDiscord.Rotation = 0D;
            this.iconDiscord.Size = new System.Drawing.Size(220, 60);
            this.iconDiscord.TabIndex = 0;
            this.iconDiscord.Text = "Create";
            this.iconDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDiscord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDiscord.UseVisualStyleBackColor = true;
            this.iconDiscord.Click += new System.EventHandler(this.iconDiscord_Click);
            // 
            // iconProfile
            // 
            this.iconProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconProfile.FlatAppearance.BorderSize = 0;
            this.iconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconProfile.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconProfile.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconProfile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconProfile.IconSize = 32;
            this.iconProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.Location = new System.Drawing.Point(0, 180);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconProfile.Rotation = 0D;
            this.iconProfile.Size = new System.Drawing.Size(220, 60);
            this.iconProfile.TabIndex = 0;
            this.iconProfile.Text = "Profile";
            this.iconProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconProfile.UseVisualStyleBackColor = true;
            this.iconProfile.Click += new System.EventHandler(this.iconProfile_Click);
            // 
            // iconSpam
            // 
            this.iconSpam.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconSpam.FlatAppearance.BorderSize = 0;
            this.iconSpam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSpam.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSpam.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconSpam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconSpam.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconSpam.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconSpam.IconSize = 32;
            this.iconSpam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSpam.Location = new System.Drawing.Point(0, 120);
            this.iconSpam.Name = "iconSpam";
            this.iconSpam.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconSpam.Rotation = 0D;
            this.iconSpam.Size = new System.Drawing.Size(220, 60);
            this.iconSpam.TabIndex = 0;
            this.iconSpam.Text = "Spam";
            this.iconSpam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSpam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSpam.UseVisualStyleBackColor = true;
            this.iconSpam.Click += new System.EventHandler(this.iconSpam_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Controls.Add(this.pictureLogoGif);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(98, 26);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(111, 61);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureLogo_MouseDown);
            // 
            // pictureLogoGif
            // 
            this.pictureLogoGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogoGif.Image")));
            this.pictureLogoGif.Location = new System.Drawing.Point(-142, -10);
            this.pictureLogoGif.Name = "pictureLogoGif";
            this.pictureLogoGif.Size = new System.Drawing.Size(414, 145);
            this.pictureLogoGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogoGif.TabIndex = 0;
            this.pictureLogoGif.TabStop = false;
            this.pictureLogoGif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureLogoGif_MouseDown);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShadow.Location = new System.Drawing.Point(220, 316);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(764, 10);
            this.panelShadow.TabIndex = 0;
            this.panelShadow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShadow_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.linkGetOwnToken);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(764, 316);
            this.panelMain.TabIndex = 0;
            // 
            // linkGetOwnToken
            // 
            this.linkGetOwnToken.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.linkGetOwnToken.Location = new System.Drawing.Point(22, 70);
            this.linkGetOwnToken.Name = "linkGetOwnToken";
            this.linkGetOwnToken.Size = new System.Drawing.Size(88, 17);
            this.linkGetOwnToken.Style = MetroFramework.MetroColorStyle.Green;
            this.linkGetOwnToken.TabIndex = 0;
            this.linkGetOwnToken.Text = "Get Own Token";
            this.linkGetOwnToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkGetOwnToken.UseSelectable = true;
            this.linkGetOwnToken.UseStyleColors = true;
            this.linkGetOwnToken.Click += new System.EventHandler(this.linkGetOwnToken_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.panelDisplay.Controls.Add(this.iconConsole);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDisplay.Location = new System.Drawing.Point(220, 326);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(764, 35);
            this.panelDisplay.TabIndex = 0;
            // 
            // iconConsole
            // 
            this.iconConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconConsole.FlatAppearance.BorderSize = 0;
            this.iconConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconConsole.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconConsole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconConsole.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.iconConsole.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(105)))), ((int)(((byte)(108)))));
            this.iconConsole.IconSize = 32;
            this.iconConsole.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconConsole.Location = new System.Drawing.Point(0, -2);
            this.iconConsole.Name = "iconConsole";
            this.iconConsole.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconConsole.Rotation = 0D;
            this.iconConsole.Size = new System.Drawing.Size(764, 37);
            this.iconConsole.TabIndex = 0;
            this.iconConsole.Text = "Console";
            this.iconConsole.UseVisualStyleBackColor = true;
            this.iconConsole.Click += new System.EventHandler(this.iconConsole_Click);
            this.iconConsole.MouseHover += new System.EventHandler(this.iconConsole_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaidArmyDS";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoGif)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconSettings;
        private FontAwesome.Sharp.IconButton iconDiscord;
        private FontAwesome.Sharp.IconButton iconProfile;
        private FontAwesome.Sharp.IconButton iconSpam;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox pictureLogoGif;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDisplay;
        private FontAwesome.Sharp.IconButton iconConsole;
        private MetroFramework.Controls.MetroLink linkGetOwnToken;
    }
}

