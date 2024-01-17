# BlazorBoilerplate - RenderMode Auto

***Note** The current master branch is now fixed and working with net8.0

Blazor is a web framework designed to run in the browser on a WebAssembly-based .NET runtime.

[![GitHub Stars](https://img.shields.io/github/stars/Wreit/BlazorBoilerplate.svg)](https://github.com/Wreit/BlazorBoilerplate/stargazers)
[![GitHub Issues](https://img.shields.io/github/issues/Wreit/BlazorBoilerplate.svg)](https://github.com/Wreit/BlazorBoilerplate/issues)
[![MIT](https://img.shields.io/github/license/SamProf/MatBlazor.svg)](LICENSE)
[![Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif)](https://paypal.me/wreit)
[![Gitter](https://badges.gitter.im/blazorboilerplate/community.svg)](https://app.gitter.im/#/room/%23blazorboilerplate-community:gitter.im?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

- This repository is community driven. It is not and never will be controlled by a corporation. It's success is dependent on people using it, reviewing it, offering suggestions and most importantly contributing.
- To create a boilerplate with Blazor / Razor components that includes the most common functionality to start a real world application quickly.
- Avoid many external components & libraries which can make it difficult to maintain, update, track down code, learn code and issues.
- Minimal Typescript.

## Prerequisites
Don't know what Blazor is? Read [here](https://docs.microsoft.com/en-us/aspnet/core/blazor)

Complete all Blazor dependencies.

- The latest [.Net 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Install Workloads **dotnet workload install wasm-tools**
- Install the Latest Visual Studio 2022 or Jetbrains Rider/Fleet.

### How to run
- We running app only via src/App.Server 
- App.Client isn't a startup project, is here only for caching wasm on background

### Hot-reload
Inside folder src/App.Server is possible to run **dotnet watch** for hot-reloading changes

## Contributing
Please star, watch and fork! We'd greatly appreciate any contribution you make. I am very open to updates and features, though most feature requests will be depending on how much community support exists. 

## License
This project is licensed under the terms of the [MIT license](LICENSE).

## News

### 0.1.0
- Initial release