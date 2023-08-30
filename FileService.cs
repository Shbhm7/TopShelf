using System.Text.Json;

namespace JsonFileService
{
    class FileService
    {
        private bool _isRunning;
        public void Start()
        {
            _isRunning = true;
            Console.WriteLine("Service started.");
        while (_isRunning)
        {
        string filePath = "C:\\Users\\Shubham.Pathania\\data.json";
        if (File.Exists(filePath))
        {
       string jsonData = File.ReadAllText(filePath);
       List<DataModel> data = JsonSerializer.Deserialize<List<DataModel>>(jsonData);
       data.Add(new DataModel { Name = "Ajay", Age = 23 });
       string updatedJsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
       File.WriteAllText(filePath, updatedJsonData);
       Console.WriteLine("Data updated and written to file.");
      _isRunning = false;

    }
   else
    {
    Console.WriteLine("JSON file does not exist.");
    _isRunning = false;
    }
    Thread.Sleep(5000); 
}
}
    public void Stop()
        {
            _isRunning = false;
            Console.WriteLine("Service stopped.");
        }
    }
}


