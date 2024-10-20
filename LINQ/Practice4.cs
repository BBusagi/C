using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

//寻找派生类

var types = Assembly
    .GetAssembly(typeof(Exception))!
    .GetTypes()
    ;

//惰性执行只有在使用时使用定义，之后的操作不保存
// var typesSelect = types
//     .Where(t => t.IsAssignableTo(typeof(Exception)))
//     .Select(t => t.Name)
//     .Where(t => t.Contains("Not"))
//     .OrderBy(t => t.Length)
//     ;
//foreach (var type in typesSelect) Console.WriteLine(type);

//利用正则表达式区分大小写
var wordSplitter = new Regex(@"[A-Z][a-z]*");

//在派生类中找到带有NOT的类型，并按照单词个数进行排序
var typesSelect =
    from t in types
    where t.IsAssignableTo(typeof(Exception)) && t.Name.Contains("Not")
    let wordCount = wordSplitter.Matches(t.Name).Count
    group t.Name by wordCount into wordGroup
    orderby wordGroup.Key
    select wordGroup;
;

//当Grouping中嵌套了Grouping时候的输出方式
foreach (var group in typesSelect)
{
    Console.WriteLine(group.Key);
    foreach (var type in group)
    {
        Console.WriteLine(type);
    }
    Console.WriteLine();
}