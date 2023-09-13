using TcpUdpClient;

Client client = new Client();

string udpMsg = "UDP Fungerar";
string tcpMsg = "TCP Fungerar";

Console.WriteLine("1 - Starta TCP message");
Console.WriteLine("2 - Starta UDP message");

var input = Console.ReadLine();


if (input == "1")
{
    client.SendTcpMessage(tcpMsg);
}
else if (input == "2")
{
    client.SendUdpMessage(udpMsg);
}

Console.ReadKey();