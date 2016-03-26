using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CIS.Presentation.Model.Administration.Title
{
    [DataContract]
    [KnownType(typeof(ListItemTitleViewModel))]
    public class TitleViewModel
    {
        [DataMember]
        public int Identifier { get; set; }
        [DataMember]
        public string Abbreviation { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
