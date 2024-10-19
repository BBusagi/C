using System.Linq;

// Example 1
// var list = new List<int> {4, 9, 2, 1, 0, 5, 7, 3, 8, 7, 10, 6};

// Query Expression
// var res = 
//     from n in list
//     where n % 2 == 0 && n >= 4
//     orderby n
//     select n; 

// Chained Expression
// var res = list
//     .Where(x => x % 2 == 0 && x >= 4)
//     .OrderBy(x => x);

// Example 2
// var arr1 = new[] { 1, 2, 3, 4, 5, 6};
// var arr2 = new[] { 4, 5, 6, 7, 8, 9};
// var res = arr1.Intersect(arr2);

// Example 3
// var rnd = new Random(8888);
// var arr = Enumerable.Range(0, 200).Select(i => rnd.Next(20));
// var dic = new Dictionary<int, int>();

// foreach (var n in arr)
// {
//     if (dic.TryGetValue(n, out int count)) dic[n] = count + 1;
//     else dic[n] = 1;
// }

// var res = from x in arr
//           group x by x into g
//           select new { g.Key, count = g.Count() };

//var res = arr.GroupBy(x => x).Select(g => new{ g.Key, count = g.Count() } );
//var res = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

//Pallel
// var arr = Enumerable.Range(0, 10)
//     .ToArray()
//     .AsParallel()       //切换到多线程
//     .AsOrdered() 
//     .Select(x =>
//         {
//             Thread.Sleep(500);
//             return x * x;
//         } 
//     ).AsSequential();   //切换到单线程

// foreach (var item in arr)
// {
//     Console.WriteLine(item);
// };