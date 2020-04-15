using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public abstract class BigDataLoader
    {
        public void ETL()
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
