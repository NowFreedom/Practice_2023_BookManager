using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public class PRentList
    {
        public List<PRentInfo> ptPetRentList { get; set; }
    }

    //....Renter User Data
    public class PRentInfo
    {
        [XmlElement("Renter")]          public PRentUserInfo ptPetRentUser              { get; set; }
        [XmlArray("Add")]
        [XmlArrayItem("RentBookInof")]  public List<PCurrentRentData> ptPetRentData     { get; set; }
    }

    public class PRentUserInfo
    {
        [XmlAttribute("Name")]          public string ptPetRentUserName      { get; set; }
        [XmlAttribute("Phone")]         public string ptPetUserPhone         { get; set; }
        [XmlAttribute("RenterCode")]    public string ptPetRentUserCode      { get; set; }
        [XmlAttribute("RentCount")]     public string ptPetRentUserCount     { get; set; }
        [XmlAttribute("Code")]          public string ptPetRentUseCode       { get; set; }
    }
}
