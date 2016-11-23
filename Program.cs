using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace labki2111
{
  class Program
  {
    static void Main(string[] args)
    {
      var json = File.ReadAllText("data.json");
      var JsonArray = JArray.Parse(json);

      //var people = JsonArray.Select(x => new RootObject
      //{
      //  _id = (string)x["_id"],
      //  age = (int)x["age"],
      //  tags = x["tags"].ToObject<List<string>>(),
      //  friends = x["friends"].ToObject<List<Friend>>()
        
      //});

     // var people = JsonArray.ToObject<List<RootObject>>();

      var people = JsonConvert.DeserializeObject<List<RootObject>>(json);

      foreach (var item in people)
      {
        Console.WriteLine($"{item._id} {item.age} ");
        Console.WriteLine("tagi: ");
        foreach (var item1 in item.tags)
        {

          Console.Write($"{item1} ");
        }
        Console.WriteLine();
        foreach (var item1 in item.friends)
        {

          Console.Write($"{item1.name} ");
        }
        Console.WriteLine();
      }
      
    }
  }
}
