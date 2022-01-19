// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_geometry.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Polygon : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Polygon()
        {
            point = new global::System.Collections.Generic.List<global::apollo.common.PointENU>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<global::apollo.common.PointENU> point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LineSegment : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LineSegment()
        {
            point = new global::System.Collections.Generic.List<global::apollo.common.PointENU>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<global::apollo.common.PointENU> point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CurveSegment : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CurveSegment()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public LineSegment line_segment { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(7)]
        public global::apollo.common.PointENU start_position { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public double heading
        {
            get { return __pbn__heading.GetValueOrDefault(); }
            set { __pbn__heading = value; }
        }
        public bool ShouldSerializeheading()
        {
            return __pbn__heading != null;
        }
        public void Resetheading()
        {
            __pbn__heading = null;
        }
        private double? __pbn__heading;

        [global::ProtoBuf.ProtoMember(9)]
        public double length
        {
            get { return __pbn__length.GetValueOrDefault(); }
            set { __pbn__length = value; }
        }
        public bool ShouldSerializelength()
        {
            return __pbn__length != null;
        }
        public void Resetlength()
        {
            __pbn__length = null;
        }
        private double? __pbn__length;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Curve : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Curve()
        {
            segment = new global::System.Collections.Generic.List<CurveSegment>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CurveSegment> segment { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021