// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Runtime.Serialization;

namespace Microsoft.ServiceFabric.ReliableCollectionBackup.UserType
{
    /// <summary>
    /// User type used in creating and validating backups in tests and rest server.
    /// </summary>
    [DataContract(Name = "User", Namespace = "http://www.rcbackupparser.com")]
    public class User : IExtensibleDataObject
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        public string Name { get; internal set ; }

        /// <summary>
        /// Age
        /// </summary>
        [DataMember]
        public uint Age { get; internal set; }
        /// <summary>
        /// Address
        /// </summary>
        [DataMember]
        public Address Address { get; internal set; }

        /// <summary>
        /// ExtensionData
        /// </summary>
        public ExtensionDataObject ExtensionData { get => extensionData_Value; set => extensionData_Value = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        public User()
        {
            this.Name = "Pandit Gangadhar Vidyadhar Mayadhar Omkarnath Shastri";
            this.Age = 31;
            this.Address = new Address();
        }

        private ExtensionDataObject extensionData_Value;
    }
}
