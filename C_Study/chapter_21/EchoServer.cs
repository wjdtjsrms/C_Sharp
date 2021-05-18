using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

/// <summary>
/// page 764 echo server
/// .Net이 TCP/IP 통신을 위해 제공하는 TcpListener, TcpClient 클래스를 이용한다.
/// TcpListener 클래스는 서버에 사용되며 클라이언트의 연결 요청을 기다리는 역활을 한다.
/// TcpClient는 서버, 클라이언트 양쪽에서 사용된다.
/// 클라이언트가 TcpClient를 이용하여 서버에 연결 요청을 하면 서버에서는 요청을 수락 후 
/// 클라이언트와의 통신에 사용할 수 있는 TcpClient의 인스턴스가 반환된다.
/// TcpClient는 GetStraem()를 가지고 있다. 양쪽은 이 메소드가 반환하는 NetworkStream 객체를 통해 데이터를 주고 받는다.
/// </summary>


namespace C_Study.chapter_21
{
    class EchoServer
    {
        static void Main(string[] args)
        {

            if(args.Length < 1)
            {
                Console.WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Bind IP>");
                return;
            }

            string bindIP = args[0];
            const int bindPort = 5425;
            TcpListener server = null;

            try
            {
                // IP 통신에 필요한 IP 주소와 출입구를 나타냅니다.
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIP), bindPort);
                server = new TcpListener(localAddress);

                server.Start(); // 서버 객체는 클라이언트가 TcpClient.Connect()를 호출하여 연결 요청해오기를 기다리기 시작.

                Console.WriteLine("Echo Server Start...");

                while(true)
                {
                    TcpClient client = server.AcceptTcpClient(); // 클라이언트의 연결 요청을 수락합니다. 이 메소드는 TcpClient 객체를 반환합니다.
                    Console.WriteLine($"Client connect : {((IPEndPoint)client.Client.RemoteEndPoint).ToString()}");

                    // TcpClient 객체의 NetworkStream 객체를 통해 데이터를 주고 받는다.
                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];

                    // Read 메소드는 상대방이 보내온 데이터를 읽어들인다.
                    // 상대와의 연결이 끊어지면 이 메소드를 0을 반환한다. 즉 연결이 끊기기 전까지 계속된다.
                    while ((length = stream.Read(bytes,0,bytes.Length)) != 0)
                    {
                        // String형으로 변환해 데이터를 받는다. 
                        data = Encoding.Default.GetString(bytes, 0, length);
                        Console.WriteLine(String.Format($"Reception : {data}"));

                        // Byte형으로 변환해 받은 데이터를 그대로 되돌려 준다.(Echo 한다)
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // Write 메소드를 통해 상대방에게 메시지를 전송한다.
                        Console.WriteLine(String.Format($"Send : {data}"));
                    }

                    stream.Close();
                    client.Close();

                }
            }
            catch(SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop(); // 연결 요청 수신 대기를 종료합니다.
            }

            Console.WriteLine("Shut down the server");
        }
        
    }
}
