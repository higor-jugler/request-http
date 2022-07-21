using System.Net;
using Newtonsoft.Json;
using RequstHTTP;

var req = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
req.Method = "GET";

using(var resp = req.GetResponse())
{
    var stream = resp.GetResponseStream();
    StreamReader leitor = new StreamReader(stream);
    object dados = leitor.ReadToEnd();

    //Console.WriteLine(dados.ToString());

    List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

    //Console.WriteLine(tarefas);

    foreach(Tarefa tarefa in tarefas)
    {
        tarefa.Exibir();
    }

    stream.Close();
    resp.Close();
}

Console.ReadLine();
