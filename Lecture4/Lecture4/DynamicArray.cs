using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4;

public class DynamicArray<ValueType>
{
    private ValueType[] values;
    private int size;


    public DynamicArray(int numItems)
    {
        values = new ValueType[numItems];
    }

    public void Add(ValueType value)
    {
        if (size == values.Length)
        {
            ValueType[] newArray = new ValueType[size * 2];
            for (int i = 0; i < values.Length; i++)
            {
                newArray[i] = values[i];
            }
            values = newArray;
        }
        values[size] = value;
        size++;
    }

    public ValueType Get(int index)
    {
        return values[index];
    }

    public void Set(int index, ValueType value)
    {
        values[index] = value;
    }
}
