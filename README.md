## Introduction 

Human friendly talking clock shows time in human readable format.
It is implemented using Microsoft .net core framework & C# as programming language.
This solution consist nuget package, application, service & test cases.  

The source code have following implementations:

1- Nuget package : A nuget package "HumanFriendlyClock", which is published at www.nuget.org (https://www.nuget.org/packages/HumanFriendlyClock). This nuget package converts time in human readable format. Test functionalities are written using nunit framework. 

2- Application : A .net core console application showing human friendly time. It uses "HumanFriendlyClock" nuget package. Unit test cases are written to test functionality.

3- Rest service : The rest service is implemented using Microsoft ASP.NET Core Web API. It uses "HumanFriendlyClock" nuget package and return in json format. Unit test cases are written using nunit framework. 

Functionalities and features:-
* Application - It uses user input time and return human friendly time.
* Service - The service return in json format based on user's input.

## Getting Started

1.	Software dependencies / pre-requisites 
    * P.S. - Please skip software installation if already installed
    * Git Client (TortoiseGit, Git etc)
    * Visual Studio 2019
    * NUnit 3.13.x
    * Please refer packages.config for additional dependencies, however it will be installed on VS Build from Nuget

2.	Installation process
    * Install VS 2019
    * Git Clone Repo

3.	Git Source
    * Go to [Talking Clock](https://github.com/varvinp/TalkingClock) for the default branch.

## Build, Test and Debug

* Git Clone Repo in Local Development Workspace
* Open the Solution using Visual Studio 2019
* Build Solution
* Run Unit Tests
* Debug asusual

## Contribute

Please update the Readme file as and when required.