﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestDemo.Models
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name = "loation")]
        public string Location { get; set; }

        [DataMember(Name = "degree")]
        public float Degree { get; set; }

        [DataMember(Name = "dateTime")]
        public DateTime DateTime { get; set; }
    }
}