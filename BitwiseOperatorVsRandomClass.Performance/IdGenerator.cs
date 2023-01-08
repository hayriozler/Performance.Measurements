using BenchmarkDotNet.Attributes;

namespace BitwiseOperatorVsRandomClass.Performance;

[MemoryDiagnoser(false)]
public class IdGenerator
{
    char[] _chars = "0123456789ABCDEFGHIJKLMNOPQRSTUV".ToCharArray();

    long _randomId = DateTime.Now.Ticks;

    [Benchmark]
    public void GenerateValue_BitwiseOperator()
    {
        var len = _chars.Length - 1;
        string.Create(10, _randomId, (buffer, value) =>
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
        var len = _chars.Length;
        string.Create(10, _randomId, (buffer, value) =>
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
        var len = _chars.Length;
        string.Create(10, _randomId, (buffer, value) =>
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                var randomId = new Random().Next(len);
                buffer[i] = _chars[randomId];
            }
        });

    }


}
