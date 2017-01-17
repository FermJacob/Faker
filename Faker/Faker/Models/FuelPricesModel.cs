﻿//-----------------------------------------------------------------------
// <copyright file="FuelPricesModel.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Faker.Models
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    [SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    [Serializable]
    [XmlRoot("fuelPrices")]
    public class FuelPricesModel
    {
        [XmlElement("cng")]
        public double CompressedNaturalGas { get; set; }

        [XmlElement("diesel")]
        public double Diesel { get; set; }

        [XmlElement("e85")]
        public double E85 { get; set; }

        [XmlElement("electric")]
        public double Electric { get; set; }

        [XmlElement("lpg")]
        public double LPG { get; set; }
        [XmlElement("midgrade")]
        public double Midgrade { get; set; }

        [XmlElement("premium")]
        public double Premium { get; set; }

        [XmlElement("regular")]
        public double Regular { get; set; }
    }
}
