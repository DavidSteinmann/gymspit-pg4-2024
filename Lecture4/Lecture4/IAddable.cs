using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4;

public interface IAddable<T>
{
    public T Add(T other);
}
