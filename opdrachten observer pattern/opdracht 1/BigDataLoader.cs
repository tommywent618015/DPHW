using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    public abstract class BigDataLoader
    {
        public void DataLoader()
        {
            Extract();
            Transform();
            Load();
        }

        public abstract void Extract();

        public abstract void Transform();

        public abstract void Load();
    }
}
