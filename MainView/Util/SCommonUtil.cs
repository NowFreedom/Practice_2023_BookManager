using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookManagerSystem
{
    public static class SCommonUtil
    {
        public static T fsXMLtoObject<T>(string p_sFilePath)
        {
            try
            {
                object oObject = null;

                if(File.Exists(p_sFilePath))
                {
                    using (StreamReader o_Read = new StreamReader(p_sFilePath))
                    {
                        XmlSerializer o_GetXml = new XmlSerializer(typeof(T));
                        oObject = (T)o_GetXml.Deserialize(o_Read);
                    }

                    if(oObject is T oResult)
                    {
                        return oResult;
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"SCommonUtil Class fsXMLtoObject Exception : {ex.ToString()}");
            }

            return default(T);
        }

        public static void fsObjectToXML<T>(T p_SetData, string p_sFilePath)
        {
            try
            {
                if(File.Exists(p_sFilePath))
                {
                    using (StreamWriter o_Write = new StreamWriter(p_sFilePath))
                    {
                        XmlSerializer o_SetXml = new XmlSerializer(typeof(T));
                        o_SetXml.Serialize(o_Write, p_SetData);
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"SCommonUtil Class fsObjectToXML Exception : {ex.ToString()}");
            }
        }
    }
}
