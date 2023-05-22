using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Http;

namespace WeatherWear_Project.UDP
{
    public class UDP_Receiver
    {
        private static readonly IPAddress IpAddress = IPAddress.Parse("127.0.0.1");
        static async Task MainTask()
        {
            int port = 7000;

            UdpClient udpClient = new UdpClient(port);

            try
            {
                while (true)
                {
                    IPEndPoint remoteEP = null;
                    byte[] data = udpClient.Receive(ref remoteEP);

                    string receivingData = Encoding.ASCII.GetString(data);

                    using (HttpClient httpClient = new HttpClient())
                    {
                        string api = "";
                        var content = new StringContent(receivingData, Encoding.UTF8, "application/json");
                        await httpClient.PostAsync(api, content);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                udpClient.Close();
            }
        }
    }
}
