### Generate Random Values

- Let's say you want to generate a random value of course you can use GUID to generate some random value but what if you want to implement your own logic. 
Bitwise operators vs Random class to generate random a value which one is faster and more efficient. 



## Benchmark Results

|                           Method |      Mean |    Error |   StdDev | Allocated |
|--------------------------------- |----------:|---------:|---------:|----------:|
|    GenerateValue_BitwiseOperator |  27.32 ns | 0.540 ns | 0.478 ns |     144 B |
| GenerateValue_RandomClass_Shared |  84.87 ns | 0.682 ns | 0.638 ns |     144 B |
|        GenerateValue_RandomClass | 958.57 ns | 8.063 ns | 7.148 ns |     864 B |

- Based on the above result, using Bitwise operators to generate some random value from the same array is 4 times faster than Random class
- If you look carefully last 2 results. I used the same Random class with 2 different ways to check performance differences, as you can see the even same class may cause a huge performance penalty in your code if you don't use it properly.
Of course, all of those implementations depends on your business case but still if it is good to know how the system is behaving.