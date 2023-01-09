using BenchmarkDotNet.Attributes;

namespace EnumParse.Performance;

[MemoryDiagnoser(false)]
public class EnumParser
{
    private enum Months
    {
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12,
    }
    private string[] MonthsStr = new string[]
    {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec",
    };

    [Benchmark]
    public void GetName_Enum()
    {
        for (int i = 0; i < 12; i++)
        {
            var a = Enum.Parse(typeof(Months), MonthsStr[i]);
        }
    }

    [Benchmark]
    public void User_String()
    {
        for (int i = 0; i < 12; i++)
        {
            var a = MonthsStr[i];
        }
    }
}