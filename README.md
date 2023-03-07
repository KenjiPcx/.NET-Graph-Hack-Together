# .NET-Graph-Hack-Together

[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)

## App Live Here

The app has been deployed [here](https://speech2todo.azurewebsites.net/) but the Speech Recognition function is not working when deployed because Azure Speech SDK has no support for Blazor 🫠, the todo extraction still works though, I have put in some example conversations there to demo the rest of the app. 

It works locally though, here is a video for the demo.

https://user-images.githubusercontent.com/56083944/223577365-3c6ef851-ed28-40ae-89ba-ba251f92089f.mp4

Some pictures:
- Recorded some conversations
<img width="953" alt="image" src="https://user-images.githubusercontent.com/56083944/223577653-853c7926-1376-4856-944a-0e8fd4f374a4.png">

- Extracted some todos
<img width="937" alt="image" src="https://user-images.githubusercontent.com/56083944/223577805-03182ceb-305c-4323-9762-0b26dcd4b030.png">

- Crud page for projects
<img width="953" alt="image" src="https://user-images.githubusercontent.com/56083944/223578019-e76cf9be-89c1-4155-bfdb-8e9e709aafd9.png">

If you want to set it up yourself, instructions to do so are below.

## Project Details

I decided to work on the **Create personal tasks in Microsoft To-Do** scenario from the [top MS Graph scenarios list](https://github.com/microsoft/hack-together/blob/main/top-scenarios.md) but with a twist that I do it through talking about a project.

I made a Blazor Server app that lets you do personal standups on your projects, use AI to extract the tasks and add them to Microsoft To Dos, with each project being a list.

### Why I made this

I plan my day every morning, automatically adding these tasks using my voice is way easier than manually typing them down.

### Technologies used

- .NET 7
- .NET Blazor Server
- Tailwind CSS + DaisyUI
- Open AI Api
- Microsoft Graph .NET SDK
- SQLite Database

### How to run the code

After you clone the project add a applicationsettings.json file to the root of the .net project with this format

```json
{
  "SPEECH_KEY": "<SPEECH_KEY_FROM_SPEECH_SERVICE>",
  "SPEECH_REGION": "<SPEECH_REGION_FROM_SPEECH_SERVICE>",
  "OpenAIServiceOptions": {
    "ApiKey": "<OPENAI_API_KEY>",
    "Organization": "<OPENAI_ORG_KEY>"
  },
  "AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "TenantId": "common",
    "ClientId": "<CLIENT_ID>",
    "ClientSecret": "<CLIENT_SECRET>",
    "ClientCertificates": [],
    "CallbackPath": "/signin-oidc"
  },
  "DownstreamApi": {
    "BaseUrl": "https://graph.microsoft.com/v1.0",
    "Scopes": "User.Read Tasks.Read Tasks.ReadWrite"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=graphass.db"
  }
}
```

Replace them keys with your own and run ```dotnet run``` and it should be good to go
