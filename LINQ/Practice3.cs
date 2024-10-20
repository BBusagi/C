using System.Linq;

//批量下载文件

// var urls = new string[]
// {
//     "http://www.example.com/pic1.jpg",
//     "http://www.example.com/pic2.jpg",
//     "http://www.example.com/pic3.jpg",
// };

// 错误方法
// foreach (var url in urls)
// {
//     await DownloadAsync(url, url.Split('/').Last());
// }

//普通方法
// var tasks = new List<Task>();
// foreach (var url in urls)
// {
//     tasks.Add(DownloadAsync(url, url.Split('/').Last()));
// }

//chaimed
//var tasks = urls.Select(url => DownloadAsync(url, url.Split('/').Last()));

//query
// var tasks = 
//     from url in urls
//     let filename = url.Split('/').Last()
//     where filename != "pic2.jpg"        //剔除指定条件元素
//     select DownloadAsync(url, filename);
// var tasksList = tasks.ToList();          //转为ToList


// await Task.WhenAll(tasks);
// Console.WriteLine("All Files Downloaded");

// async Task DownloadAsync(string url, string Filename)
// {
//     await Task.Delay(1000);
//     Console.WriteLine(Filename +" Downloaded");
// }
