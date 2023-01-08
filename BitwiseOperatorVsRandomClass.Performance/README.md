### Bitwise operators vs Random class to generate random value which one is faster and efficent.



## Benchmark Results

|                                 Method |     Mean |    Error |   StdDev | Allocated |
|--------------------------------------- |---------:|---------:|---------:|----------:|
|          GenerateValue_BitwiseOperator | 20.32 ns | 0.360 ns | 0.301 ns |     144 B |
| GenerateValue_BitwiseOperator_WithLoop | 20.07 ns | 0.382 ns | 0.583 ns |     144 B |
|              GenerateValue_RandomClass | 76.51 ns | 1.520 ns | 1.422 ns |     112 B |


|                                 Method |     Mean |    Error |   StdDev | Allocated |
|--------------------------------------- |---------:|---------:|---------:|----------:|
|          GenerateValue_BitwiseOperator | 20.11 ns | 0.422 ns | 0.486 ns |     144 B |
| GenerateValue_BitwiseOperator_WithLoop | 20.09 ns | 0.420 ns | 0.501 ns |     144 B |
|              GenerateValue_RandomClass | 80.41 ns | 0.794 ns | 0.704 ns |     144 B |