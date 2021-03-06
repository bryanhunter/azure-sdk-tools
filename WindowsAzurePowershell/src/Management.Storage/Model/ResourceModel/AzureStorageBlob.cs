﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ---------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Storage.Model.ResourceModel
{
    using System;
    using Microsoft.WindowsAzure.Storage.Blob;

    public class AzureStorageBlob : AzureStorageBase
    {
        public ICloudBlob ICloudBlob { get; private set; }
        public BlobType BlobType { get; private set; }
        public long Length { get; private set; }
        public string ContentType { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
        public DateTimeOffset? SnapshotTime  { get; private set; }

        public AzureStorageBlob(ICloudBlob blob)
        {
            Name = blob.Name;
            ICloudBlob = blob;
            BlobType = blob.BlobType;
            Length = blob.Properties.Length;
            ContentType = blob.Properties.ContentType;
            LastModified = blob.Properties.LastModified;
            SnapshotTime = blob.SnapshotTime;
        }
    }
}
