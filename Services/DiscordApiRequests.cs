using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace RaidArmyDS
{
    class DiscordApiRequests
    {
        private RestClient client;
        private IRestRequest request;
        private IRestResponse response;

        private static string guildId;
        private string token;

        public DiscordApiRequests(string token)
        {
            client = new RestClient();
            request = new RestRequest().AddHeader("Authorization", token);
            this.token = token;

            string[] proxyData = TXTWriterReader.ReadProxySpam().Split(new char[] { '@', ':' });
            if (proxyData.Length == 4)
            {
                client.Proxy = new WebProxy(proxyData[0], Convert.ToInt32(proxyData[1])) { UseDefaultCredentials = false, Credentials = new NetworkCredential(proxyData[2], proxyData[3]) };
            }
            else if (proxyData.Length == 2)
            {
                client.Proxy = new WebProxy(proxyData[0], Convert.ToInt32(proxyData[1]));
            }
        }

        public async void JoinChannel(byte jsonCounterInvite)
        {
            request.Resource = $"https://discord.com/api/v6/invite/{FormSpam.inviteLink}";
            response = await client.ExecuteAsync(request, Method.POST);
            while (jsonCounterInvite < 1)
            {
                dynamic json = JsonConvert.DeserializeObject(response.Content);
                try
                {
                    guildId = json.guild.id;
                    jsonCounterInvite++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Inviting is Successful");
            }
        }

        public async void LeaveChannel()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me/guilds/{guildId}";
            response = await client.ExecuteAsync(request, Method.DELETE);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Leaving is Successful");
            }
        }

        public async void FriendRequest()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me/relationships";
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"username\": \"" + FormSpam.tag[0] + "\"" + ", \"discriminator\": " + FormSpam.tag[1] + "}", ParameterType.RequestBody);
            response = await client.ExecuteAsync(request, Method.POST);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Friend Requesting is Successful");
            }
        }

        public async void ChangeAvatar()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me";
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"avatar\": \"" + FormProfile.base64Avatar + "\"" + "}", ParameterType.RequestBody);
            response = await client.ExecuteAsync(request, Method.PATCH);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Avatar Changing is Successful");
            }
        }

        public async void ChangeUsername()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me";
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"username\": \"" + FormProfile.username + "\", " + "\"password\": \"" + FormProfile.password + "\"" + "}", ParameterType.RequestBody);
            response = await client.ExecuteAsync(request, Method.PATCH);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Username Changing is Successful");
            }
        }

        public async void SpamChannel()
        {
            request.Resource = $"https://discord.com/api/v6/channels/{FormSpam.spamId}/messages";
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"content\": \"" + FormSpam.spamMessage + "\"}", ParameterType.RequestBody);
            response = await client.ExecuteAsync(request, Method.POST);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Spam Channel is Successful");
            }
        }

        public async void SpamDirect()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me/channels";
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"recipients\": [\"" + FormSpam.spamId + "\"]}", ParameterType.RequestBody);
            response = client.Execute(request, Method.POST);
            dynamic json = JsonConvert.DeserializeObject(response.Content);

            request = new RestRequest().AddHeader("Authorization", token);
            request.Resource = $"https://discord.com/api/v6/channels/{json.id}/messages";
            request.AddParameter("application/json", "{\"content\": \"" + FormSpam.spamMessage + "\"}", ParameterType.RequestBody);
            response = await client.ExecuteAsync(request, Method.POST);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("Spam Direct is Successful");
            }
        }

        public async void CheatReactionChannel()
        {
            request.Resource = $"https://discord.com/api/v6/channels/{FormSpam.cheatId}/messages/{FormSpam.cheatMessageId}/reactions/{FormSpam.cheatEmoji}/@me";
            response = await client.ExecuteAsync(request, Method.PUT);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Something Broke");
            }
            else
            {
                Program.formMain.Console("React Channel is Successful");
            }
        }

        public bool IsTokenValid()
        {
            request.Resource = $"https://discord.com/api/v6/users/@me/affinities/guilds";
            response = client.Execute(request, Method.GET);
            if (!response.IsSuccessful)
            {
                Program.formMain.Console("Token is Invalid");
                return false;
            }
            else
            {
                Program.formMain.Console("Token is Valid");
                return true;
            }
        }
    }
}