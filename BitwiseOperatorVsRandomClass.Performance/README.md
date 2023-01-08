### Generate Random Values

- Let's say you want to generate a random value of course you can use GUID to generate some random value but what if you want to implement your own logic. 
Bitwise operators vs Random class to generate random a value which one is faster and more efficient. 



## Benchmark Results; without output the console

|                           Method |        Mean |     Error |    StdDev | Allocated |
|--------------------------------- |------------:|----------:|----------:|----------:|
|    GenerateValue_BitwiseOperator |    91.01 ns |  1.185 ns |  1.050 ns |     144 B |
| GenerateValue_RandomClass_Shared |   153.79 ns |  2.465 ns |  2.306 ns |     144 B |
|        GenerateValue_RandomClass | 1,042.14 ns | 20.405 ns | 24.290 ns |     864 B |

- Based on the above result, using Bitwise operators to generate some random value from the same array is almost 2 times faster than the random class.
- If you look at the carefully the last two results. I used the same Random class with 2 different ways to check performance differences, as you can see the even same class may cause a huge performance penalty in your code if you don't use it properly.
Of course, all of those implementations depend on your business case but still if it is good to know how the system is behaving.


## Benchmark Results; with output the console

|                           Method |        Mean |     Error |    StdDev | Allocated |
|--------------------------------- |------------:|----------:|----------:|----------:|
|    GenerateValue_BitwiseOperator |    93.36 ns |  1.695 ns |  1.586 ns |     144 B |
| GenerateValue_RandomClass_Shared |   148.26 ns |  2.345 ns |  2.194 ns |     144 B |
|        GenerateValue_RandomClass | 1,023.89 ns | 13.122 ns | 12.274 ns |     864 B |



### Question: Why when we output results to the console, why 3 methods executing at similar times.?