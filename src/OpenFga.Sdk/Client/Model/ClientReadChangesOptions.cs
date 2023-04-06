//
// OpenFGA/.NET SDK for OpenFGA
//
// API version: 0.1
// Website: https://openfga.dev
// Documentation: https://openfga.dev/docs
// Support: https://discord.gg/8naAwJfWN6
// License: [Apache-2.0](https://github.com/openfga/dotnet-sdk/blob/main/LICENSE)
//
// NOTE: This file was auto generated. DO NOT EDIT.
//


namespace OpenFga.Sdk.Client.Model;

/// <summary>
///     ClientReadChangesOptions - Client Options for ReadChanges
/// </summary>
public interface IClientReadChangesOptions : ClientRequestOptions, ClientPaginationOptions {
}

/// <inheritdoc />
public class ClientReadChangesOptions : IClientReadChangesOptions {

    /// <inheritdoc />
    public int? PageSize { get; set; }

    /// <inheritdoc />
    public string? ContinuationToken { get; set; }
}