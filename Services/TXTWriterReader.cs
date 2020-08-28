using System;
using System.IO;

namespace RaidArmyDS
{
    static class TXTWriterReader
    {
        public static sbyte counterProxyDateCreate = -1;
        public static sbyte counterProxyDateSpam = -1;

        public static string ReadProxyCreate()
        {
            if (FormConfigs.proxies == null)
            {
                return " : ";
            }
            try
            {
                counterProxyDateCreate++;
                if (FormConfigs.isProxyChecked && FormConfigs.proxies.Length != 0)
                {
                    return FormConfigs.proxies[counterProxyDateCreate];
                }
                else
                {
                    return " : ";
                }
            }
            catch (IndexOutOfRangeException)
            {
                counterProxyDateCreate = 0;
                return FormConfigs.proxies[counterProxyDateCreate];
            }
        }

        public static string ReadProxySpam()
        {
            if (FormConfigs.proxies == null)
            {
                return string.Empty;
            }
            try
            {
                counterProxyDateSpam++;
                if (FormConfigs.isProxyChecked && FormConfigs.proxies.Length != 0)
                {
                    return FormConfigs.proxies[counterProxyDateSpam];
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (IndexOutOfRangeException)
            {
                counterProxyDateSpam = 0;
                return FormConfigs.proxies[counterProxyDateSpam];
            }
        }

        public static void WriteToken(string token)
        {
            StreamWriter tokenWriter = new StreamWriter(@"C:\Users\User\source\repos\RaidArmyDS\Data\Tokens.txt", true);
            tokenWriter.WriteLine(token);
            tokenWriter.Close();
        }

        public static string ReadToken()
        {
            using (StreamReader tokenReader = new StreamReader(@"C:\Users\User\source\repos\RaidArmyDS\Data\Tokens.txt"))
            {
                return tokenReader.ReadLine();
            }
        }
    }
}
