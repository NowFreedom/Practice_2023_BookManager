using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public class PMainList
    {
        public List<PMainInfo> ptPetMainList { get; set; }
    }

    //....Toatal Book Data
    public class PMainInfo
    {
        [XmlElement("BookStoreInfo")]   public PMainDataInfo PMainStore            { get; set; }

        [XmlArray("Add")]
        [XmlArrayItem("BookData")]      public List<PMainDataItem> ptPetListDataItem { get; set; }
    }

    public class PMainDataInfo
    {
        [XmlArrayItem("StoreName")]     public string ptPetStoreName    { get; set; }
        [XmlArrayItem("Master")]        public string ptPetStoreMaster  { get; set; }
        [XmlArrayItem("Code")]          public string ptPetStoreCode    { get; set; }
    }

    public class PMainDataItem
    {
        [XmlAttribute("Name")]          public string ptPetName         { get; set; }
        [XmlAttribute("Code")]          public string ptPetCode         { get; set; }
        [XmlAttribute("Writer")]        public string ptPetWriter       { get; set; }
        [XmlAttribute("Category")]      public string ptPetCategory     { get; set; }
        [XmlAttribute("Price")]         public string ptPetPrice        { get; set; }
        [XmlAttribute("CreatDate")]     public string ptPetCreatDate    { get; set; }
        [XmlAttribute("GetDate")]       public string ptPetGetDate      { get; set; }
        [XmlAttribute("Register")]      public string ptPetRegister     { get; set; }
        [XmlAttribute("Count")]         public string ptPetCount        { get; set; }
    }
}
