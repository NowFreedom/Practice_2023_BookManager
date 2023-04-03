using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerSystem
{
    public abstract class AManager
    {
        public abstract bool fnCreateData();
        public abstract bool fnGetFindByKey(string p_sKey, out object p_oGetData);      //Key 값으로 해당 object 가지고 오기
        public abstract bool fnGetFindByValue(string p_sVal, out object p_oGetData);    //Value 값으로 object 가지고 오기
    }
}
