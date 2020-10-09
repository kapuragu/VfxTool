﻿using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LbaTool
{
    [DebuggerDisplay("x = {X}, y = {Y}, z = {Z}, w = {W}")]
    public class Vector4 : IXmlSerializable
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public static Vector4 Read(BinaryReader reader)
        {
            return new Vector4 {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle(),
                Z = reader.ReadSingle(),
                W = reader.ReadSingle()
            };
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new System.NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("x", X.ToString(CultureInfo.InvariantCulture));
            writer.WriteAttributeString("y", Y.ToString(CultureInfo.InvariantCulture));
            writer.WriteAttributeString("z", Z.ToString(CultureInfo.InvariantCulture));
            writer.WriteAttributeString("w", W.ToString(CultureInfo.InvariantCulture));
        }
    }
}