using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;

namespace KMLib
{
    public class Style
    {
        private PolyStyle m_PolyStyle;
        public PolyStyle PolyStyle
        {
            get
            {
                return m_PolyStyle;
            }
            set
            {
                m_PolyStyle = value;
            }
        }

        private LineStyle m_LineStyle;
        public LineStyle LineStyle
        {
            get
            {
                return m_LineStyle;
            }
            set
            {
                m_LineStyle = value;
            }
        }
    }

    public class PolyStyle
    {
        public PolyStyle(Color colr)
        {
            m_Color = colr;
        }

        public PolyStyle() { }

        private string m_Id;
        [XmlAttribute("id")]
        public string Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
            }
        }

        private ColorKML m_Color;
        [XmlElement("color")]
        public ColorKML Color
        {
            get
            {
                return m_Color;
            }
            set
            {
                m_Color = value;
            }
        }
    }
    
    public class LineStyle : PolyStyle
    {
        public LineStyle(Color colr)
        {
            Color = colr;
        }
        public LineStyle(Color colr, float width)
        {
            Color = colr;
            m_Width = width;
        }

        public LineStyle() { }

        private float m_Width = 1.0f;
        public float Width
        {
            get
            {
                return m_Width;
            }
            set
            {
                m_Width = value;
            }
        }
    }
}
