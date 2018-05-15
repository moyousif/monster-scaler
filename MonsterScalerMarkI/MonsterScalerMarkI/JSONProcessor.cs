using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace MonsterScalerMarkI
{
    class JSONProcessor
    {
        JsonReader jreader;
        public void Read(string filename)
        {
            bool b = false;
            if (b)
            {
                
                jreader.Read();
            }
            else
            {
                filename = "Failure";
            }
        }
    }
}
