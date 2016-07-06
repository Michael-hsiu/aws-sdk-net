﻿/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using Amazon.Runtime;

using Amazon.Runtime.SharedInterfaces;

using Amazon.SQS;
using Amazon.SQS.Model;

namespace Amazon.SQS
{
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
        async Task<Dictionary<string, string>> ICoreAmazonSQS.GetAttributesAsync(string queueUrl)
        {
            var response = await this.GetQueueAttributesAsync(new GetQueueAttributesRequest
            {
                AttributeNames = new List<string>() { "All" },
                QueueUrl = queueUrl
            }).ConfigureAwait(false);

            return response.Attributes;
        }

        Task ICoreAmazonSQS.SetAttributesAsync(string queueUrl, Dictionary<string, string> attributes)
        {
            return this.SetQueueAttributesAsync(new SetQueueAttributesRequest()
            {
                QueueUrl = queueUrl,
                Attributes = attributes
            });
        }
    }
}