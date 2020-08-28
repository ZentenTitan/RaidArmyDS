using System;

namespace RaidArmyDS
{
    public partial class FormSpam : MetroFramework.Forms.MetroForm
    {
        public static string inviteLink;
        public static string[] tag;
        public static string spamId;
        public static string spamMessage;
        public static int timeout;
        public static string cheatId;
        public static string cheatMessageId;
        public static string cheatEmoji;

        public FormSpam()
        {
            InitializeComponent();
        }

        private void textBoxInvitingChannelInviteLink_TextChanged(object sender, EventArgs e)
        {
            inviteLink = textBoxInvitingChannelInviteLink.Text.Replace("https://discord.gg/", "");
        }

        private void buttonInvitingChannelInvite_Click(object sender, EventArgs e)
        {
            byte jsonCounterInvite = 0;
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).JoinChannel(jsonCounterInvite);
                jsonCounterInvite++;
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void buttonInvitingChannelLeave_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).LeaveChannel();
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void textBoxRequestingDirectTag_TextChanged(object sender, EventArgs e)
        {
            tag = textBoxRequestingDirectTag.Text.Split('#');
        }

        private void buttonRequestingDirectRequest_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).FriendRequest();
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }
        
        private void textBoxSpamChannelDirectChannelRecipientId_TextChanged(object sender, EventArgs e)
        {
            spamId = textBoxSpamChannelDirectChannelRecipientId.Text;
        }

        private void textBoxSpamChannelDirectMessage_TextChanged(object sender, EventArgs e)
        {
            spamMessage = textBoxSpamChannelDirectMessage.Text;
        }

        private void textBoxSpamChannelDirectRate_TextChanged(object sender, EventArgs e)
        {
            timeout = Convert.ToInt32(textBoxSpamChannelDirectRate.Text);
        }

        private void buttonSpamChannelDirectChannel_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).SpamChannel();
                System.Threading.Thread.Sleep(timeout);
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void buttonSpamChannelDirectDirect_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).SpamDirect();
                System.Threading.Thread.Sleep(timeout);
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }

        private void textBoxReactionChannelChannelId_TextChanged(object sender, EventArgs e)
        {
            cheatId = textBoxReactionChannelChannelId.Text;
        }

        private void textBoxReactionChannelMessageId_TextChanged(object sender, EventArgs e)
        {
            cheatMessageId = textBoxReactionChannelMessageId.Text;
        }

        private void textBoxReactionChannelEmoji_TextChanged(object sender, EventArgs e)
        {
            cheatEmoji = System.Web.HttpUtility.UrlEncode(textBoxReactionChannelEmoji.Text);
        }

        private void linkReactionChannelFindEmoji_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://getemoji.com");
        }

        private void buttonReactionChannelReact_Click(object sender, EventArgs e)
        {
            foreach (string token in FormConfigs.tokens)
            {
                new DiscordApiRequests(token).CheatReactionChannel();
                System.Threading.Thread.Sleep(timeout);
            }
            TXTWriterReader.counterProxyDateSpam = -1;
        }
    }
}
