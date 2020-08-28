using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace RaidArmyDS
{
    public partial class FormMain : Form
    {
        private static IconButton iconButton;
        private static Panel panel = new Panel();
        private static Size size = new Size(3, 60);
        private static ToolTip toolTip = new ToolTip();
        public FormSpam formSpam = new FormSpam();
        public FormProfile formProfile = new FormProfile();
        public FormCreate formCreate = new FormCreate();
        public FormConfigs formConfigs = new FormConfigs();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormMain()
        {
            InitializeComponent();
            panelMenu.Controls.Add(panel);
            panel.Size = size;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                iconButton = (IconButton)senderButton;
                iconButton.BackColor = Color.FromArgb(57, 60, 66);
                iconButton.ForeColor = color;
                iconButton.TextAlign = ContentAlignment.MiddleLeft;
                iconButton.IconColor = color;
                iconButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                panel.BackColor = color;
                panel.Location = new Point(0, iconButton.Location.Y);
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (iconButton != null)
            {
                iconButton.BackColor = Color.FromArgb(47, 49, 54);
                iconButton.ForeColor = Color.FromArgb(104, 105, 108);
                iconButton.TextAlign = ContentAlignment.MiddleLeft;
                iconButton.IconColor = Color.FromArgb(104, 105, 108);
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconButton.ImageAlign = ContentAlignment.MiddleLeft;

                panel.Visible = false;

                iconConsole.Text = "Console";
            }
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            iconConsole.Text = childForm.Text;
        }

        private void iconSpam_Click(object sender, EventArgs e)
        {
            OpenChildForm(formSpam);
            ActivateButton(sender, Color.FromArgb(0, 174, 219));
        }

        private void iconProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(formProfile);
            ActivateButton(sender, Color.FromArgb(243, 119, 53));
        }

        private void iconDiscord_Click(object sender, EventArgs e)
        {
            OpenChildForm(formCreate);
            ActivateButton(sender, Color.FromArgb(255, 0, 148));
        }

        private void iconSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(formConfigs);
            ActivateButton(sender, Color.FromArgb(0, 177, 89));
        }


        private void iconConsole_Click(object sender, EventArgs e)
        {
            DisableButton();
            iconConsole.Text = "Console";
            formSpam.Close();
            formProfile.Close();
            formCreate.Close();
            formConfigs.Close();
            formSpam = new FormSpam();
            formProfile = new FormProfile();
            formCreate = new FormCreate();
            formConfigs = new FormConfigs();
        }

        private void pictureLogoGif_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void panelShadow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void iconConsole_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Clear All", iconConsole, 707, 17, 800);
        }

        private void linkGetOwnToken_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=tI1lzqzLQCs");
        }

        public void Console(string text)
        {
            iconConsole.Text = text;
        }
    }
}
