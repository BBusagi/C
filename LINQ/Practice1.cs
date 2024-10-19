using System.Linq;

//展平
// var mat = new int[][]{
//     new [] {1,2,3,4},
//     new [] {5,6,7,8},
//     new [] {9,10,11,12},
// };

// var res = 
//     from row in mat
//     from n in row
//     select n;

// var res = mat.SelectMany(x => x);

//笛卡尔积
// var arr = 
//     from i in Enumerable.Range(0,5)
//     from j in Enumerable.Range(0,5)
//     from k in Enumerable.Range(0,5)
//     select $"{i},{j},{k}";

// foreach (var item in arr)    Console.WriteLine(item);