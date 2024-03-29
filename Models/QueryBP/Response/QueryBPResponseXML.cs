﻿using System.Xml.Serialization;

namespace WSGYG.Models.QueryBP.Response
{

    [XmlRoot(ElementName = "properties")]
    public class QueryBPResponseXML
    {
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "NumberId")]
        public string NumberId { get; set; }

        [XmlElement(ElementName = "Bpartner")]
        public string Bpartner { get; set; }

        [XmlElement(ElementName = "NameFirst")]
        public string NameFirst { get; set; }

        [XmlElement(ElementName = "NameSecond")]
        public string NameSecond { get; set; }

        [XmlElement(ElementName = "FirstLastname")]
        public string FirstLastname { get; set; }

        [XmlElement(ElementName = "SecondLastname")]
        public string SecondLastname { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "Region")]
        public string Region { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "District")]
        public string District { get; set; }

        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }

        [XmlElement(ElementName = "Genero")]
        public string Genero { get; set; }

        [XmlElement(ElementName = "Birthdate")]
        public string Birthdate { get; set; }

        [XmlElement(ElementName = "CivilSt")]
        public string CivilSt { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "TelNumber")]
        public string TelNumber { get; set; }

        [XmlElement(ElementName = "MobilePhone")]
        public string MobilePhone { get; set; }

        [XmlElement(ElementName = "MENSAJE")]
        public string MENSAJE { get; set; }
    }
}
