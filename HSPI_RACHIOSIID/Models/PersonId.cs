﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HSPI_Rachio_Irrigation_Plugin.Models
{
    [DataContract]
  public class PersonId
    {
        [DataMember(Name = "id")]
        public string id { get; set; }

    }
}
