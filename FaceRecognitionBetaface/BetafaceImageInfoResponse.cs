﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 

namespace FaceRecognitionBetaface
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("BetafaceImageInfoResponse", Namespace = "", IsNullable = false)]
    public partial class BetafaceImageInfoResponseType
    {

        private sbyte int_responseField;

        private string string_responseField;

        private string checksumField;

        private facesType facesField;

        private string uidField;

        /// <remarks/>
        public sbyte int_response
        {
            get
            {
                return this.int_responseField;
            }
            set
            {
                this.int_responseField = value;
            }
        }

        /// <remarks/>
        public string string_response
        {
            get
            {
                return this.string_responseField;
            }
            set
            {
                this.string_responseField = value;
            }
        }

        /// <remarks/>
        public string checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        public facesType faces
        {
            get
            {
                return this.facesField;
            }
            set
            {
                this.facesField = value;
            }
        }

        /// <remarks/>
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class facesType
    {

        private FaceInfoType faceInfoField;

        /// <remarks/>
        public FaceInfoType FaceInfo
        {
            get
            {
                return this.faceInfoField;
            }
            set
            {
                this.faceInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FaceInfoType
    {

        private float angleField;

        private float heightField;

        private string image_uidField;

        private PointInfoType[] pointsField;

        private float scoreField;

        private TagInfoType[] tagsField;

        private string uidField;

        private string user_pointsField;

        private float widthField;

        private float xField;

        private float yField;

        /// <remarks/>
        public float angle
        {
            get
            {
                return this.angleField;
            }
            set
            {
                this.angleField = value;
            }
        }

        /// <remarks/>
        public float height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public string image_uid
        {
            get
            {
                return this.image_uidField;
            }
            set
            {
                this.image_uidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PointInfo", IsNullable = false)]
        public PointInfoType[] points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        public float score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TagInfo", IsNullable = false)]
        public TagInfoType[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string user_points
        {
            get
            {
                return this.user_pointsField;
            }
            set
            {
                this.user_pointsField = value;
            }
        }

        /// <remarks/>
        public float width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PointInfoType
    {

        private string nameField;

        private short typeField;

        private float xField;

        private float yField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public short type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public float x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public float y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TagInfoType
    {

        private float confidenceField;

        private string nameField;

        private string valueField;

        /// <remarks/>
        public float confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}