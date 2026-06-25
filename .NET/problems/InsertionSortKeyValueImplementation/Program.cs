using Newtonsoft.Json;
Console.WriteLine("Hello, World!");

var solution = new Solution();
var result = solution.InsertionSort(new List<Pair> { new Pair(3, "cat"), new Pair(3, "bird"), new Pair(2, "dog") });
var json = JsonConvert.SerializeObject(result);
Console.WriteLine(json);
