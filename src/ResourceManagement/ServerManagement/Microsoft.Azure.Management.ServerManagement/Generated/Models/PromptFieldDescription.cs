// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Field description for the implementation of PSHostUserInterface.Prompt
    /// </summary>
    public partial class PromptFieldDescription
    {
        /// <summary>
        /// Initializes a new instance of the PromptFieldDescription class.
        /// </summary>
        public PromptFieldDescription() { }

        /// <summary>
        /// Initializes a new instance of the PromptFieldDescription class.
        /// </summary>
        public PromptFieldDescription(string name = default(string), string label = default(string), string helpMessage = default(string), bool? promptFieldTypeIsList = default(bool?), PromptFieldType? promptFieldType = default(PromptFieldType?))
        {
            Name = name;
            Label = label;
            HelpMessage = helpMessage;
            PromptFieldTypeIsList = promptFieldTypeIsList;
            PromptFieldType = promptFieldType;
        }

        /// <summary>
        /// the name of the prompt
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// the label text of the prompt
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// the help message of the prompt
        /// </summary>
        [JsonProperty(PropertyName = "helpMessage")]
        public string HelpMessage { get; set; }

        /// <summary>
        /// when set to 'true' the prompt field type is a list of values
        /// </summary>
        [JsonProperty(PropertyName = "promptFieldTypeIsList")]
        public bool? PromptFieldTypeIsList { get; set; }

        /// <summary>
        /// Possible values include: 'String', 'SecureString', 'Credential'
        /// </summary>
        [JsonProperty(PropertyName = "promptFieldType")]
        public PromptFieldType? PromptFieldType { get; set; }

    }
}
