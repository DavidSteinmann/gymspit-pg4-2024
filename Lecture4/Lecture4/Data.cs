using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4;

public class Data<T> : IAddable<Data<T>>
{
    // This should be type T, but we cannot add them...
    public int Value;

    public Data()
    {

    }

    public Data(int value)
    {
        Value = value;
    }

    public Data<T> Add(Data<T> other)
    {
        return new Data<T>(Value + other.Value);
    }
}
