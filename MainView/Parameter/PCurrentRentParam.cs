using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public class PCurrentRentList
    {
        public List<PCurrentRentInfo> ptPetCurrentRentList { get; set; }
    }

    //....Rent Book Data
    public class PCurrentRentInfo
    {
        [XmlArray("RentBook")]
        [XmlArrayItem("Add")]           public List<PCurrentRentData> ptPetRentData { get; set; }
    }

    public class PCurrentRentData
    {
        [XmlAttribute("Name")]          public string ptPetName         { get; set; }
        [XmlAttribute("Code")]          public string ptPetCode         { get; set; }
        [XmlAttribute("Category")]      public string ptPetCategory     { get; set; }
        [XmlAttribute("Price")]         public string ptPetPrice        { get; set; }
        [XmlAttribute("RentDate")]      public string ptPetRentDate     { get; set; }
        [XmlAttribute("ReturnDate")]    public string ptPetReturnDate   { get; set; }
    }
}
