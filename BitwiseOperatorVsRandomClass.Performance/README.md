### Generate Random Values

- Let's say you want to generate a random value of course you can use GUID to generate some random value but what if you want to implement your own logic. 
Bitwise operators vs Random class to generate random a value which one is faster and more efficient. 



## Benchmark Results;

|                                           Method |         Mean |        Error |       StdDev | Allocated |
|------------------------------------------------- |-------------:|-------------:|-------------:|----------:|
|                    GenerateValue_BitwiseOperator |     94.32 ns |     1.480 ns |     1.384 ns |     144 B |
|                 GenerateValue_RandomClass_Shared |    163.69 ns |     1.921 ns |     1.797 ns |     144 B |
|                        GenerateValue_RandomClass |  1,011.05 ns |    16.648 ns |    14.758 ns |     864 B |
|    GenerateValue_BitwiseOperator_OutputToConsole | 89,643.77 ns | 1,622.101 ns | 1,517.315 ns |     144 B |
| GenerateValue_RandomClass_Shared_OutputToConsole | 89,607.06 ns | 1,243.186 ns | 1,616.493 ns |     144 B |
|        GenerateValue_RandomClass_OutputToConsole | 89,834.86 ns | 1,082.296 ns |   959.427 ns |     864 B |

- Based on the above result, using Bitwise operators to generate some random value from the same array is almost 2 times faster than the random class.
- If you look at the carefully last two results, I used the same Random class in 2 different ways; As you can see the even same class may cause a huge performance penalty in your code if you don't use it properly.
Of course, all of those implementations depend on your business case but still if it is good to know how the system is behaving.

# Question: When we output the results to the console, why 3 methods executing at similar times?