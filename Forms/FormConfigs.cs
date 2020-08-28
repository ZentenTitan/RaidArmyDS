using System;

namespace RaidArmyDS
{
    public partial class FormConfigs : MetroFramework.Forms.MetroForm
    {
        public static string ruCaptchaApiKey;
        public static string smsActivateApiKey;
        public static string[] proxies;
        public static string[] tokens;
        public static bool isCaptchaServiceChecked;
        public static bool isSmsServiceChecked;
        public static bool isProxyChecked;

        private static string[] splitter = { "\r\n" };

        public FormConfigs()
        {
            InitializeComponent();
        }

        private void textBoxConfigsSettingRuCaptchaApiKey_TextChanged(object sender, EventArgs e)
        {
            if (isCaptchaServiceChecked)
            {
                ruCaptchaApiKey = textBoxConfigsSettingRuCaptchaApiKey.Text;
            }
        }

        private void textBoxConfigsSettingSmsActivateApiKey_TextChanged(object sender, EventArgs e)
        {
            if (isSmsServiceChecked)
            {
                smsActivateApiKey = textBoxConfigsSettingSmsActivateApiKey.Text;
            }
        }

        private void textBoxConfigsSettingProxies_TextChanged(object sender, EventArgs e)
        {
            if (isProxyChecked)
            {
                proxies = textBoxConfigsSettingProxies.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private void textBoxConfigsSettingTokens_TextChanged(object sender, EventArgs e)
        {
            tokens = textBoxConfigsSettingTokens.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
        }

        private void checkBoxConfigsSettingCaptchaService_CheckedChanged(object sender, EventArgs e)
        {
            isCaptchaServiceChecked = checkBoxConfigsSettingCaptchaService.Checked;
            textBoxConfigsSettingRuCaptchaApiKey_TextChanged(sender, e);
        }

        private void checkBoxConfigsSettingSmsService_CheckedChanged(object sender, EventArgs e)
        {
            isSmsServiceChecked = checkBoxConfigsSettingSmsService.Checked;
            textBoxConfigsSettingSmsActivateApiKey_TextChanged(sender, e);
        }

        private void checkBoxConfigsSettingProxy_CheckedChanged(object sender, EventArgs e)
        {
            isProxyChecked = checkBoxConfigsSettingProxy.Checked;
            textBoxConfigsSettingProxies_TextChanged(sender, e);
        }

        public void WriteToken(string token)
        {
            textBoxConfigsSettingTokens.Text += $"\r\n{token}";
            textBoxConfigsSettingTokens_TextChanged(this, null);
        }

        private void buttonConfigsSettingCheckValidityOfTokens_Click(object sender, EventArgs e)
        {
            foreach (string token in tokens)
            {
                if (!new DiscordApiRequests(token).IsTokenValid())
                {
                    textBoxConfigsSettingTokens.Text = textBoxConfigsSettingTokens.Text.Replace($"\r\n{token}", "");
                }
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }
    }
}
