using System;
using System.Collections.Generic;
using System.Text;
using Core.Xml;
using System.Xml.Serialization;

namespace KMLib.Abstract
{
    public abstract class AFeature : AObject
    {
        private string m_name;
        public string name {
            get {
                return m_name;
            }
            set {
                m_name = value;
            }
        }        

        private IntBool m_open;
        public IntBool open {
            get {
                return m_open;
            }
            set {
                m_open = value;
            }
        }

        private IntBool m_visibility;
        public IntBool visibility {
            get {
                return m_visibility;
            }
            set {
                m_visibility = value;
            }
        }

        private Snippet m_Snippet;
        public Snippet Snippet {
            get {
                return m_Snippet;
            }
            set {
                m_Snippet = value;
            }
        }

        private string m_phoneNumber;
        public string phoneNumber {
            get {
                return m_phoneNumber;
            }
            set {
                m_phoneNumber = value;
            }
        }

        private string m_description;
        public string description {
            get {
                return m_description;
            }
            set {
                m_description = value;
            }
        }

        private LookAt m_LookAt;
        public LookAt LookAt {
            get {
                return m_LookAt;
            }
            set {
                m_LookAt = value;
            }
        }

        private string m_styleUrl;
        public string styleUrl {
            get {
                return m_styleUrl;
            }
            set {
                m_styleUrl = value;
            }
        }

        private Region m_Region;
        public Region Region {
            get {
                if (!XMLSerializeManager.Serializing && m_Region == null) {
                    m_Region = new Region();
                }
                return m_Region;
            }
            set {
                m_Region = value;
            }
        }

        private Metadata m_Metadata;
        public Metadata Metadata {
            get {
                return m_Metadata;
            }
            set {
                m_Metadata = value;
            }
        }
    }    
}

/*
<name>...</name>                      <!-- string -->
<visibility>1</visibility>            <!-- boolean -->
<open>1</open>                        <!-- boolean -->
<address>...</address>                <!-- string -->
<AddressDetails xmlns="urn:oasis:names:tc:ciq:xsdschema:xAL:2.0">...
  </AddressDetails>                 <!-- string -->
<phoneNumber>...</phoneNumber>        <!-- string -->
<Snippet maxLines="2">...</Snippet>   <!-- string -->
<description>...</description>        <!-- string -->
<LookAt>...</LookAt>
<TimePrimitive>...</TimePrimitive>
<styleUrl>...</styleUrl>              <!-- anyURI -->
<StyleSelector>...</StyleSelector>
<Region>...</Region>
<Metadata>...</Metadata>
 */
