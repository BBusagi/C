+ LINQ: 在C#中使用类似SQL的数据处理 

+ LINQ入门示例及新手常犯的错误 [URL](https://www.bilibili.com/video/BV1vP411f7XF/?spm_id_from=333.880.my_history.page.click&vd_source=8cb2266d7357d5cd081874c68b08a2bd)

## 常见错误
### 1. 满足于经典方法
1. First() Last()  

2. Sum + Count => Average()

3. Count() First() Min() Max() 可以传参

4. Max() => 输出参考数据,  Maxby() => 输出原数据

5. Default Ex. FirstOrDefault ElementAtDefault SingleOrDefault

### 2. 不考虑开销
1. ToList() 内存开销较大 尽量避免

2. Count() 遍历到最后, Any() 找到即返回

3. OrderBy => Sort/Order

4. First() 找到即返回, Single() 遍历到最后来保证唯一
 
### PS
+ Stack Overflow

+ 编程思想 => 函数式编程 (F#)