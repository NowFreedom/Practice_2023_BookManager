using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public class PManagerList
    {
        public List<PManagerInfo> ptPetManagerList { get; set; }
    }

    //....Manager
    public class PManagerInfo
    {
        [XmlArray("ManagerInfo")]
        [XmlArrayItem("Info")]  public PManagerItem ptPetManagerItem { get; set; }
    }

    public class PManagerItem
    {
        [XmlAttribute("Name")]      public string ptPetManagerName  { get; set; }
        [XmlAttribute("ID")]        public string ptPetID           { get; set; }
        [XmlAttribute("Password")]  public string ptPetPassword     { get; set; }
        [XmlAttribute("Code")]      public string ptPetCode         { get; set; }
        [XmlAttribute("Level")]     public string ptPetLevel        { get; set; }
        [XmlAttribute("Phone")]     public string ptPetPhone        { get; set; }
        [XmlAttribute("StartDate")] public string ptPetStartDate    { get; set; }
        [XmlAttribute("EndDate")]   public string ptPetEndDate      { get; set; }

    }


}
