﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Text.Json.Serialization;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.CodeAnalysis.Razor.Protocol.Formatting;

internal class RazorDocumentOnTypeFormattingParams : DocumentOnTypeFormattingParams
{
    [JsonPropertyName("hostDocumentVersion")]
    public int HostDocumentVersion { get; init; }
}
