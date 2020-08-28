using System;
using System.Threading;

namespace RaidArmyDS
{
    public partial class FormCreate : MetroFramework.Forms.MetroForm
    {
        public static string username;
        public static string password;

        private static byte amount;
        private static byte amountCurrent;

        public FormCreate()
        {
            InitializeComponent();
        }

        private void textBoxCreatingAccountUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxCreatingAccountUsername.Text;
        }

        private void textBoxCreatingAccountPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxCreatingAccountPassword.Text;
        }

        private void textBoxCreatingAccountAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToByte(textBoxCreatingAccountAmount.Text);
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void buttonCreatingAccountCreate_Click(object sender, EventArgs e)
        {
            amountCurrent = 0;
            while (amountCurrent < amount)
            {
                var webDriverInterations = new WebDriverInteractions();
                webDriverInterations.CreateDiscordAccount();
                Thread.Sleep(10000);
                webDriverInterations.VerifyDiscord();
                webDriverInterations.GetDiscordToken();
                amountCurrent++;
            }
            TXTWriterReader.counterProxyDateCreate = -1;
        }
    }
}
