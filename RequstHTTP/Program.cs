using System.Net;

var req = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
req.Method = "GET";

using(var resp = req.GetResponse())
{
    var stream = resp.GetResponseStream();
    StreamReader leitor = new StreamReader(stream);
    object dados = leitor.ReadToEnd();

    Console.WriteLine(dados.ToString());

    stream.Close();
    resp.Close();
}

Console.ReadLine();
