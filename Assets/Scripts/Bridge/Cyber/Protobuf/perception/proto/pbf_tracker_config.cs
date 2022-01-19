// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: pbf_tracker_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.fusion
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PbfTrackerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PbfTrackerConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"DstTypeFusion")]
        public string type_fusion_method
        {
            get { return __pbn__type_fusion_method ?? @"DstTypeFusion"; }
            set { __pbn__type_fusion_method = value; }
        }
        public bool ShouldSerializetype_fusion_method()
        {
            return __pbn__type_fusion_method != null;
        }
        public void Resettype_fusion_method()
        {
            __pbn__type_fusion_method = null;
        }
        private string __pbn__type_fusion_method;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"KalmanMotionFusion")]
        public string motion_fusion_method
        {
            get { return __pbn__motion_fusion_method ?? @"KalmanMotionFusion"; }
            set { __pbn__motion_fusion_method = value; }
        }
        public bool ShouldSerializemotion_fusion_method()
        {
            return __pbn__motion_fusion_method != null;
        }
        public void Resetmotion_fusion_method()
        {
            __pbn__motion_fusion_method = null;
        }
        private string __pbn__motion_fusion_method;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"PbfShapeFusion")]
        public string shape_fusion_method
        {
            get { return __pbn__shape_fusion_method ?? @"PbfShapeFusion"; }
            set { __pbn__shape_fusion_method = value; }
        }
        public bool ShouldSerializeshape_fusion_method()
        {
            return __pbn__shape_fusion_method != null;
        }
        public void Resetshape_fusion_method()
        {
            __pbn__shape_fusion_method = null;
        }
        private string __pbn__shape_fusion_method;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"DstExistanceFusion")]
        public string existance_fusion_method
        {
            get { return __pbn__existance_fusion_method ?? @"DstExistanceFusion"; }
            set { __pbn__existance_fusion_method = value; }
        }
        public bool ShouldSerializeexistance_fusion_method()
        {
            return __pbn__existance_fusion_method != null;
        }
        public void Resetexistance_fusion_method()
        {
            __pbn__existance_fusion_method = null;
        }
        private string __pbn__existance_fusion_method;

    }

}

#pragma warning restore 0612, 1591, 3021
