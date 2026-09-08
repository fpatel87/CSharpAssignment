using System;

namespace Parse_Url
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();

            string protocol = "";
            string server = "";
            string resource = "";

            int protocolEnd = url.IndexOf("://");

            if (protocolEnd >= 0)
            {
                protocol = url.Substring(0, protocolEnd);

                
                url = url.Substring(protocolEnd + 3);
            }

            int resourceStart = url.IndexOf('/');

            if (resourceStart >= 0)
            {
                server = url.Substring(0, resourceStart);
                resource = url.Substring(resourceStart + 1);
            }
            else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}