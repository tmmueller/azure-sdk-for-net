﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Avro.Generic;

namespace Azure.Storage.Blobs.ChangeFeed.Models
{
    internal class BlobChangeFeedEventPage : Page<BlobChangeFeedEvent>
    {
        public override IReadOnlyList<BlobChangeFeedEvent> Values { get; }
        public override string ContinuationToken { get; }
        public override Response GetRawResponse() => _raw;
        private Response _raw;

        public BlobChangeFeedEventPage() { }

        public BlobChangeFeedEventPage(List<BlobChangeFeedEvent> events, string continuationToken)
        {
            Values = events;
            ContinuationToken = continuationToken;
        }

        public BlobChangeFeedEventPage(Response raw, List<GenericRecord> data)
        {
            _raw = raw;
            ContinuationToken = null;
            var changes = new List<BlobChangeFeedEvent>();
            foreach (GenericRecord value in data)
            {
                changes.Add(new BlobChangeFeedEvent(value));
            }
            Values = changes;
        }
    }
}
