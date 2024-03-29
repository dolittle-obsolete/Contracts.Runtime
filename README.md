# TimeSeries Runtime Contracts

[![Build Status](https://dev.azure.com/dolittle/Dolittle%20open-source%20repositories/_apis/build/status/dolittle-timeseries.Contracts.Runtime?branchName=master)](https://dev.azure.com/dolittle/Dolittle%20open-source%20repositories/_build/latest?definitionId=33&branchName=master)

This repository holds the [Protobuf](https://developers.google.com/protocol-buffers/)
and [gRPC](https://grpc.io) API contracts for what is exposed from our TimeSeries Runtime.

It is language agnostic and supports generated code (proxies) for multiple languages.

## Cloning

This repository has sub modules, clone it with:

```text
$ git clone --recursive <repository url>
```

If you've already cloned it, you can get the submodules by doing the following:

```text
$ git submodule update --init --recursive
```
<>