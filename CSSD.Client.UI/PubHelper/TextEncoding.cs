using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSSD.Client.UI.PubHelper
{
    public class TextEncoding
    {
        private XmlNode rootNode;

        public TextEncoding()
        {
            XmlDocument document = new XmlDocument();
            document.Load(System.Windows.Forms.Application.StartupPath + @"\TextEncoding.xml");
            this.rootNode = document.DocumentElement;

        }

        public string GetEncoding(string text, EncodingType encodingType)
        {
            if ((text == null) || (text.Trim() == ""))
            {
                return "";
            }
            string res = "";
            string attName = (encodingType == EncodingType.Spelling) ? "Spelling" : "WBCode";
            new List<char>(text.ToUpper().ToCharArray()).ForEach(delegate(char T)
            {
                int num = T;
                if ((num >= 0x41) && (num <= 90))
                {
                    res = res + T.ToString();
                }
                else if ((num >= 0x4e00) && (num <= 0x9fff))
                {
                    res = res + this.GetSpell(T.ToString(), attName);
                }
            });
            return res.ToUpper();
        }

        private string GetSpell(string chr, string attName)
        {
            XmlNode node = this.rootNode.SelectSingleNode(chr.ToString());
            if (node != null)
            {
                XmlAttributeCollection attributes = node.Attributes;
                foreach (XmlAttribute attribute in attributes)
                {
                    if (attribute.Name.Equals(attName, StringComparison.OrdinalIgnoreCase))
                    {
                        return attribute.Value;
                    }
                }
            }
            return "";
        }

        public enum EncodingType
        {
            Spelling,
            WBCode
        }
    }
}
