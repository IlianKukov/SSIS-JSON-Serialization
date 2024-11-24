using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Linq;

namespace JsonSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFileContent = File.ReadAllText(@"C:\Users\ikuko001\Desktop\SSMS GERMANY\Klarna\test.json");
            JavaScriptSerializer js = new JavaScriptSerializer();
            js.MaxJsonLength = int.MaxValue;

            List<ImportJSON> importJSONList = js.Deserialize<List<ImportJSON>>(jsonFileContent);

            foreach (ImportJSON jsn in importJSONList)
            {
                Output0Buffer.addRow();
                Output0Buffer.id = jsn.Entities_id;
                Output0Buffer.name = jsn.Entities_name;
                Output0Buffer.devisionid = jsn.Entities_devision_id;
                Output0Buffer.devisionname = jsn.Entities_devision_name;
                Output0Buffer.devisionselfuri = jsn.Entities_devision_selfuri;
                Output0Buffer.chatjaberid = jsn.Chat_jabberId;
                Output0Buffer.department = jsn.Department;
                Output0Buffer.email = jsn.Email;
                Output0Buffer.primarycontactaddress = jsn.PrimaryContactInfo_adress;
                Output0Buffer.primarycontactmediatype = jsn.PrimaryContactInfo_mediaType;
                Output0Buffer.primarycontacttype = jsn.PrimaryContactInfo_type;
                Output0Buffer.address = jsn.Addresses;
                Output0Buffer.state = jsn.State;
                Output0Buffer.title = jsn.Title;
                Output0Buffer.username = jsn.Username;
                Output0Buffer.version = jsn.Version;
                Output0Buffer.acdautoanswer = jsn.AcdAutoAnswer;
                Output0Buffer.selfuri = jsn.SelfUri;

                Console.WriteLine("Import successful");
            }
        }
    }
}
