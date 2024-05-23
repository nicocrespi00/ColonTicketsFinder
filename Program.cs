// See https://aka.ms/new-console-template for more information
using ColonWorker;
using Newtonsoft.Json;
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

List<string> funciones = new List<string> { "1669" };

while(true)
{
    foreach (string funcion in funciones)
    {
        string hash = "27a1da40794e2cb05d97c6e6ad5a3bf8e1100dc6";
        string url = $"https://api-ecommerce-live-gcba.entradauno.com/v1/api/v2/EspectaculoCartel/{funcion}?h={hash}";

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                using (HttpContent content = response.Content)
                {
                    string contentString = await content.ReadAsStringAsync();
                    Welcome welcome = JsonConvert.DeserializeObject<Welcome>(contentString);
                    foreach (var item in welcome.OData.OEspectaculoCartel.ListaEstablecimiento)
                    {
                        foreach (var item2 in item.ListaFuncion)
                        {
                            if (item2.NPosicionesDisponibles > 0 && item2.Sectores.Any())
                            {
                                foreach (var item3 in item2.Sectores)
                                {
                                    if (item3.CantidadDisponible > 0)
                                    {
                                        string logEntry = $"Funcion: {item2.DFuncion}\n" +
                                                                  $"Sector: {item3.IdSector}\n" +
                                                                  $"Cantidad Disponible Total: {item2.NPosicionesDisponibles}\n" +
                                                                  $"Cantidad Disponible Sector: {item3.CantidadDisponible}\n" +
                                                                  $"Precio: ${item3.Precio}\n" +
                                                                  $"Hora de Consulta: {DateTime.Now}\n" +
                                                                  "-------------------------------------------------";

                                        LogToFile(logEntry);
                                    }
                                }
                            }
                        };
                    }
                }
            }
        }

        Console.WriteLine();
    }
    await Task.Delay(60000);
}


static void LogToFile(string logEntry)
{
    string logFilePath = "C:\\Users\\Nico\\Documents\\Programacion\\Proyectos\\ColonTicketsFinder\\TextFile1.txt"; 

    using (StreamWriter writer = new StreamWriter(logFilePath, true))
    {
        writer.WriteLine(logEntry);
    }
}


