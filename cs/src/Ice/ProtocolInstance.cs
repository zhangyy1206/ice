// **********************************************************************
//
// Copyright (c) 2003-2014 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

namespace IceInternal
{

    using System.Collections.Generic;

    public class ProtocolInstance
    {
        public ProtocolInstance(Ice.Communicator communicator, short type, string protocol)
        {
            instance_ = Util.getInstance(communicator);
            traceLevel_ = instance_.traceLevels().network;
            traceCategory_ = instance_.traceLevels().networkCat;
            logger_ = instance_.initializationData().logger;
            properties_ = instance_.initializationData().properties;
            type_ = type;
            protocol_ = protocol;
        }

        public ProtocolInstance(Instance instance, short type, string protocol)
        {
            instance_ = instance;
            traceLevel_ = instance_.traceLevels().network;
            traceCategory_ = instance_.traceLevels().networkCat;
            logger_ = instance_.initializationData().logger;
            properties_ = instance_.initializationData().properties;
            type_ = type;
            protocol_ = protocol;
        }

        public int traceLevel()
        {
            return traceLevel_;
        }

        public string traceCategory()
        {
            return traceCategory_;
        }

        public Ice.Logger logger()
        {
            return logger_;
        }

        public string protocol()
        {
            return protocol_;
        }

        public short type()
        {
            return type_;
        }

        public Ice.Properties properties()
        {
            return properties_;
        }

        public bool preferIPv6()
        {
            return instance_.preferIPv6();
        }

        public int protocolSupport()
        {
            return instance_.protocolSupport();
        }

        public string defaultHost()
        {
            return instance_.defaultsAndOverrides().defaultHost;
        }

        public Ice.EncodingVersion defaultEncoding()
        {
            return instance_.defaultsAndOverrides().defaultEncoding;
        }

        public NetworkProxy networkProxy()
        {
            return instance_.networkProxy();
        }

        public int messageSizeMax()
        {
            return instance_.messageSizeMax();
        }

        public List<Connector> resolve(string host, int port, Ice.EndpointSelectionType type, IPEndpointI endpt)
        {
            return instance_.endpointHostResolver().resolve(host, port, type, endpt);
        }

        public void resolve(string host, int port, Ice.EndpointSelectionType type, IPEndpointI endpt,
                            EndpointI_connectors callback)
        {
            instance_.endpointHostResolver().resolve(host, port, type, endpt, callback);
        }

        protected Instance instance_;
        protected int traceLevel_;
        protected string traceCategory_;
        protected Ice.Logger logger_;
        protected Ice.Properties properties_;
        protected string protocol_;
        protected short type_;
    }

}