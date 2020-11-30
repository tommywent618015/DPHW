using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_2
{
    public interface IStack
    {
        int Count { get; }
        bool IsEmpty { get; }

        void Push(int value);

        int Pop();

        bool Contains(int value);
    }
}
