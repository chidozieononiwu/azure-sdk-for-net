// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogLanguageChange. </summary>
    internal partial class DialogLanguageChangeInternal
    {
        /// <summary> Initializes a new instance of <see cref="DialogLanguageChangeInternal"/>. </summary>
        internal DialogLanguageChangeInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DialogLanguageChangeInternal"/>. </summary>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <param name="dialogId"> Dialog ID. </param>
        /// <param name="selectedLanguage"> Selected Language. </param>
        /// <param name="ivrContext"> Ivr Context. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        internal DialogLanguageChangeInternal(DialogInputType? dialogInputType, string dialogId, string selectedLanguage, object ivrContext, string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation)
        {
            DialogInputType = dialogInputType;
            DialogId = dialogId;
            SelectedLanguage = selectedLanguage;
            IvrContext = ivrContext;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
        }

        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Dialog ID. </summary>
        public string DialogId { get; }
        /// <summary> Selected Language. </summary>
        public string SelectedLanguage { get; }
        /// <summary> Ivr Context. </summary>
        public object IvrContext { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code, sub-code and message. </summary>
        public ResultInformation ResultInformation { get; }
    }
}
