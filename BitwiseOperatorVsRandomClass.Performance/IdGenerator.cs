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

             buffer[0] = _chars[(value >> 0) & len];
             buffer[1] = _chars[(value >> 2) & len];
             buffer[2] = _chars[(value >> 4) & len];
             buffer[3] = _chars[(value >> 8) & len];
             buffer[4] = _chars[(value >> 16) & len];
             buffer[5] = _chars[(value >> 32) & len];
             buffer[6] = _chars[(value >> 64) & len];
             buffer[7] = _chars[(value >> 128) & len];
             buffer[8] = _chars[(value >> 256) & len];
             buffer[9] = _chars[(value >> 512) & len];
         });
    }
    [Benchmark]
    public void GenerateValue_BitwiseOperator_WithLoop()
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
    public void GenerateValue_RandomClass()
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


}
