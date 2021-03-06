using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;

namespace EmployeeServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CrossDomainService" in both code and config file together.
    public class CrossDomainService : ICrossDomainService
    {
        public Message ProvidePolicyFile()
        {
            FileStream filestream = File.Open(@"ClientAccessPolicy.xml", FileMode.Open);
            // Either specify ClientAccessPolicy.xml file path properly
            // or put that in \Bin folder of the console application
            XmlReader reader = XmlReader.Create(filestream);
            Message result = Message.CreateMessage(MessageVersion.None, "", reader);
            return result;
        }

    }
}
