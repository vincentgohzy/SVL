// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: system_status.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.monitor
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ComponentStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ComponentStatus()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Status.Unknown)]
        public Status status
        {
            get { return __pbn__status ?? Status.Unknown; }
            set { __pbn__status = value; }
        }
        public bool ShouldSerializestatus()
        {
            return __pbn__status != null;
        }
        public void Resetstatus()
        {
            __pbn__status = null;
        }
        private Status? __pbn__status;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return __pbn__message ?? ""; }
            set { __pbn__message = value; }
        }
        public bool ShouldSerializemessage()
        {
            return __pbn__message != null;
        }
        public void Resetmessage()
        {
            __pbn__message = null;
        }
        private string __pbn__message;

        [global::ProtoBuf.ProtoContract()]
        public enum Status
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"OK")]
            Ok = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"WARN")]
            Warn = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"ERROR")]
            Error = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"FATAL")]
            Fatal = 4,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Component : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Component()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public ComponentStatus summary { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public ComponentStatus process_status { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public ComponentStatus channel_status { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public ComponentStatus resource_status { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public ComponentStatus other_status { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SystemStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SystemStatus()
        {
            hmi_modules = new global::System.Collections.Generic.Dictionary<string, ComponentStatus>();
            components = new global::System.Collections.Generic.Dictionary<string, Component>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, ComponentStatus> hmi_modules { get; private set; }

        [global::ProtoBuf.ProtoMember(8)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, Component> components { get; private set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string passenger_msg
        {
            get { return __pbn__passenger_msg ?? ""; }
            set { __pbn__passenger_msg = value; }
        }
        public bool ShouldSerializepassenger_msg()
        {
            return __pbn__passenger_msg != null;
        }
        public void Resetpassenger_msg()
        {
            __pbn__passenger_msg = null;
        }
        private string __pbn__passenger_msg;

        [global::ProtoBuf.ProtoMember(5)]
        public double safety_mode_trigger_time
        {
            get { return __pbn__safety_mode_trigger_time.GetValueOrDefault(); }
            set { __pbn__safety_mode_trigger_time = value; }
        }
        public bool ShouldSerializesafety_mode_trigger_time()
        {
            return __pbn__safety_mode_trigger_time != null;
        }
        public void Resetsafety_mode_trigger_time()
        {
            __pbn__safety_mode_trigger_time = null;
        }
        private double? __pbn__safety_mode_trigger_time;

        [global::ProtoBuf.ProtoMember(6)]
        public bool require_emergency_stop
        {
            get { return __pbn__require_emergency_stop.GetValueOrDefault(); }
            set { __pbn__require_emergency_stop = value; }
        }
        public bool ShouldSerializerequire_emergency_stop()
        {
            return __pbn__require_emergency_stop != null;
        }
        public void Resetrequire_emergency_stop()
        {
            __pbn__require_emergency_stop = null;
        }
        private bool? __pbn__require_emergency_stop;

        [global::ProtoBuf.ProtoMember(9)]
        public bool is_realtime_in_simulation
        {
            get { return __pbn__is_realtime_in_simulation.GetValueOrDefault(); }
            set { __pbn__is_realtime_in_simulation = value; }
        }
        public bool ShouldSerializeis_realtime_in_simulation()
        {
            return __pbn__is_realtime_in_simulation != null;
        }
        public void Resetis_realtime_in_simulation()
        {
            __pbn__is_realtime_in_simulation = null;
        }
        private bool? __pbn__is_realtime_in_simulation;

    }

}

#pragma warning restore 0612, 1591, 3021
