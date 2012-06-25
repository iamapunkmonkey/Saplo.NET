﻿using System.Runtime.Serialization;

namespace Saplo.Core.Requests
{
    [DataContract]
    public class GroupTextCreateRequest
    {
        [DataMember(Name = "group_id")]
        public int GroupID { get; set; }

        [DataMember(Name = "collection_id")]
        public int CollectionID { get; set; }

        [DataMember(Name = "text_id")]
        public int TextID { get; set; }

        [DataMember(Name = "ext_text_id", EmitDefaultValue = false)]
        public string ExternalTextID { get; set; }
    }
}