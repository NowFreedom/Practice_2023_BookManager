using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public class PBreakDataList
    {
        public List<PBreakDataInfo> ptPetBreakDataList { get; set; }
    }

    //....분실 된 Data
    public class PBreakDataInfo
    {
        [XmlElement("BreakUser")]  public PRentUserInfo ptPetBreakUser          { get; set; }
        [XmlArray("Add")]
        [XmlArrayItem("BreakData")] public List<PMainDataItem> ptPetBreakData   { get; set; }
    }
}
