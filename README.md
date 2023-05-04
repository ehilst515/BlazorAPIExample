# BlazorAPIExample
A simple example of how to use Blazor to consume an API using the openweathermap.org `/weather` endpoint.

## Structure
 - *Contracts* contains the `WeatherData` object used as a contract to map responses from the HTTP requests
 - *Pages* contains 'Weather.razor', where the input form to take a zip code form is displayed. The page updates with data on okay replies.
 - *Services* contains `WeatherService.cs`, where the HTTP calls are made

## Important Note!
You shouldn't pass your API keys on a client (browser) side GET request in a hosted app. That would expose your API key and allow others to steal it and charge calls on your account. This app does that, and is intended to be an example only.

___

# How to Clone and Run the Blazor WebAssembly Weather App

This guide will walk you through the steps to clone and run the Blazor WebAssembly Weather App on your local machine.

## Prerequisites

Before you begin, you should have the following installed on your machine:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Git](https://git-scm.com/downloads)

## Clone the Repository

1. Open a command prompt or terminal window.
2. Change the current working directory to the location where you want to clone the repository.
3. Clone the repository by running the following command:

```
git clone https://github.com/ehilst515/BlazorAPIExample.git
```

## Edit the App in VisualStudio

1. Install [VisualStudio](https://visualstudio.microsoft.com/downloads/)
2. Change the current working directory to the `BlazorAPIExample` directory.
3. Start the solution by running the following command:

```
start BlazorAPIExample.sln
```

4. Update the line `string apiKey = "<Your API Key Here>";` in `Services.WeatherService` with [your own API key from openweathermap](https://openweathermap.org/api)

## Run the App

1. Open a command prompt or terminal window.
2. Change the current working directory to the `BlazorAPIExample` directory.
3. Run the app by running the following command:

```
dotnet run
```

4. Open a web browser and navigate to `https://localhost:7076/weather`.

You should see the Weather App running in your browser. Enter a zip code and click the "Get Weather" button to retrieve and display the current weather information.

