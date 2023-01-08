using BenchmarkDotNet.Attributes;

namespace BitwiseOperatorVsRandomClass.Performance;

[MemoryDiagnoser(false)]
public class IdGenerator
{
    char[] _chars = "0123456789ABCDEFGHIJKLMNOPQRSTUV".ToCharArray();


    [Benchmark]
    public void GenerateValue_BitwiseOperator()
    {
        long _randomId = DateTime.Now.Ticks;
        var len = _chars.Length - 1;
        var s = string.Create(10, _randomId, (buffer, value) =>
           {
               for (int i = 0; i < buffer.Length; i++)
               {
                   buffer[i] = _chars[(value >> (i * 2)) & len];
               }
           });
    }
    [Benchmark]
    public void GenerateValue_RandomClass_Shared()
    {
        long _randomId = DateTime.Now.Ticks;
        var len = _chars.Length;
        var s = string.Create(10, _randomId, (buffer, value) =>
         {
             for (int i = 0; i < buffer.Length; i++)
             {
                 var randomId = Random.Shared.Next(len);
                 buffer[i] = _chars[randomId];
             }
         });
    }
    [Benchmark]
    public void GenerateValue_RandomClass()
    {
        long _randomId = DateTime.Now.Ticks;
        var len = _chars.Length;
        var s = string.Create(10, _randomId, (buffer, value) =>
         {
             for (int i = 0; i < buffer.Length; i++)
             {
                 var randomId = new Random().Next(len);
                 buffer[i] = _chars[randomId];
             }
         });
    }
}
