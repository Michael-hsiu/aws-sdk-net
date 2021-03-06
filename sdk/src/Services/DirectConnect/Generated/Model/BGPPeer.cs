/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// A structure containing information about a BGP peer.
    /// </summary>
    public partial class BGPPeer
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private int? _asn;
        private string _authKey;
        private string _awsDeviceV2;
        private BGPPeerState _bgpPeerState;
        private BGPStatus _bgpStatus;
        private string _customerAddress;

        /// <summary>
        /// Gets and sets the property AddressFamily.
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonAddress.
        /// </summary>
        public string AmazonAddress
        {
            get { return this._amazonAddress; }
            set { this._amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this._amazonAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Asn.
        /// </summary>
        public int Asn
        {
            get { return this._asn.GetValueOrDefault(); }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthKey.
        /// </summary>
        public string AuthKey
        {
            get { return this._authKey; }
            set { this._authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this._authKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connection endpoint which the BGP peer terminates on.
        /// </para>
        /// </summary>
        public string AwsDeviceV2
        {
            get { return this._awsDeviceV2; }
            set { this._awsDeviceV2 = value; }
        }

        // Check to see if AwsDeviceV2 property is set
        internal bool IsSetAwsDeviceV2()
        {
            return this._awsDeviceV2 != null;
        }

        /// <summary>
        /// Gets and sets the property BgpPeerState.
        /// </summary>
        public BGPPeerState BgpPeerState
        {
            get { return this._bgpPeerState; }
            set { this._bgpPeerState = value; }
        }

        // Check to see if BgpPeerState property is set
        internal bool IsSetBgpPeerState()
        {
            return this._bgpPeerState != null;
        }

        /// <summary>
        /// Gets and sets the property BgpStatus.
        /// </summary>
        public BGPStatus BgpStatus
        {
            get { return this._bgpStatus; }
            set { this._bgpStatus = value; }
        }

        // Check to see if BgpStatus property is set
        internal bool IsSetBgpStatus()
        {
            return this._bgpStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAddress.
        /// </summary>
        public string CustomerAddress
        {
            get { return this._customerAddress; }
            set { this._customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this._customerAddress != null;
        }

    }
}