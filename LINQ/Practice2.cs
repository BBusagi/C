using System.Linq;

//统计字母出现概率

//var names = new string[] { "Bob", "Alice", "Charlie", "Jane", "Michael", "Isabella" };
// var res = 
//     from name in names
//     from n in name
//     let lowerChar = char.ToLower(n)     //不区分大小写
//     group lowerChar by lowerChar into g
//     select new {g.Key, count = g.Count()} into list
//     orderby list.count descending       //降序排序
//     select list;

// var res = names
//     .SelectMany(x => x)
//     .GroupBy(x => x)
//     .Select(g => new {g.Key, Count = g.Count() } )
//     .OrderByDescending(g => g.Count);

// foreach (var item in res)    Console.WriteLine(item);