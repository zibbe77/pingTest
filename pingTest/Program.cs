using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

Ping p1 = new Ping();
string data = "Die lol and play lol aaaaaaaaaaa";
byte[] buffer = Encoding.ASCII.GetBytes(data);
PingReply PR = p1.Send("10.156.8.80", 120, buffer);

System.Console.WriteLine(PR.Status);
Console.ReadLine();
