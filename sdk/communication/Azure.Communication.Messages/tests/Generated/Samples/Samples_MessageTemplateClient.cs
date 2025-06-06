// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.Messages.Samples
{
    public partial class Samples_MessageTemplateClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetTemplates_ShortVersion()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (BinaryData item in client.GetTemplates(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("kind").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetTemplates_ShortVersion_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (BinaryData item in client.GetTemplatesAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("kind").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetTemplates_ShortVersion_Convenience()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (MessageTemplateItem item in client.GetTemplates(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a")))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetTemplates_ShortVersion_Convenience_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (MessageTemplateItem item in client.GetTemplatesAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a")))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetTemplates_AllParameters()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (BinaryData item in client.GetTemplates(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("kind").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetTemplates_AllParameters_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (BinaryData item in client.GetTemplatesAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), 1234, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("kind").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetTemplates_AllParameters_Convenience()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (MessageTemplateItem item in client.GetTemplates(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), maxPageSize: 1234))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetTemplates_AllParameters_Convenience_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (MessageTemplateItem item in client.GetTemplatesAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), maxPageSize: 1234))
            {
            }
        }
    }
}
