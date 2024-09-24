using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4;

public class DynamicArrayWithData<ValueType> where ValueType :
    IAddable<ValueType>, new()
{
    private ValueType[] values;
    private int size;


    public DynamicArrayWithData(int numItems)
    {
        values = new ValueType[numItems];
    }

    public ValueType GetSum()
    {
        ValueType sum = new ValueType();
        for (int i = 0; i < size; i++)
        {
            ValueType element = values[i];
            sum.Add(element);
        }

        return sum;
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
