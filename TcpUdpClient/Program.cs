using TcpUdpClient;

Client client = new Client();

string udpMessage = "UDP Fungerar";
string tcpMessage = "TCP Fungerar";

Console.WriteLine("1 - Starta TCP server");
Console.WriteLine("2 - Starta UDP server");

var input = Console.ReadLine();


if (input == "1")
{
    client.SendTcpMessage(tcpMessage);
}
else if (input == "2")
{
    client.SendUdpMessage(udpMessage);
}

Console.ReadKey();
