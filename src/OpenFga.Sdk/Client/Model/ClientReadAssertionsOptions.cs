//
// OpenFGA/.NET SDK for OpenFGA
//
// API version: 1.x
// Website: https://openfga.dev
// Documentation: https://openfga.dev/docs
// Support: https://openfga.dev/community
// License: [Apache-2.0](https://github.com/openfga/dotnet-sdk/blob/main/LICENSE)
//
// NOTE: This file was auto generated. DO NOT EDIT.
//


namespace OpenFga.Sdk.Client.Model;

/// <summary>
///     ClientReadAssertionsOptions - Client Options for ReadAssertions
/// </summary>
public interface IClientReadAssertionsOptions : IClientRequestOptionsWithStoreId, AuthorizationModelIdOptions {
}

/// <inheritdoc />
public class ClientReadAssertionsOptions : IClientReadAssertionsOptions {
    /// <inheritdoc />
    public string? StoreId { get; set; }

    /// <inheritdoc />
    public string? AuthorizationModelId { get; set; }
}