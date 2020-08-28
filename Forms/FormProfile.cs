using System;
using System.Windows.Forms;

namespace RaidArmyDS
{
    public partial class FormProfile : MetroFramework.Forms.MetroForm
    {
        public static string username;
        public static string password;
        public static string base64Avatar;

        private static OpenFileDialog openAvatarDialog = new OpenFileDialog();

        public FormProfile()
        {
            InitializeComponent();
        }

        private void buttonChangingAvatarUploadImage_Click(object sender, EventArgs e)
        {
            openAvatarDialog.Filter = "Image Files(*.JPG;*.JPEG;*.PNG;*.GIF)|*.JPG;*.JPEG;*.PNG;*.GIF";
            if (openAvatarDialog.ShowDialog() == DialogResult.OK)
            {
                base64Avatar = $"data:image/{openAvatarDialog.FileName.Substring(openAvatarDialog.FileName.IndexOf('.') + 1)};base64," + Convert.ToBase64String(System.IO.File.ReadAllBytes(openAvatarDialog.FileName));
            }
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).ChangeAvatar();
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void textBoxChangingUsernameUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxChangingUsernameUsername.Text;
        }

        private void buttonChangingUsernameChange_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).ChangeUsername();
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void textBoxChangingUsernamePassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxChangingUsernamePassword.Text;
        }
    }
}
