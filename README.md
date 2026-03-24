# Mermaker

Mermaker is a generator for Mermaid Diagrams. Our generators are written in C#.

## Developer Setup

Mermaker code will work in many integrated development environments, text editor, etc. The project creator uses Visual Studio Code for this project and Visual Studio professionally outside this project.

### Suggested VS Code Setup

The VS Code documentation is a great place to start. A good start is to read [Setting up Visual Studio Code](https://code.visualstudio.com/docs/setup/setup-overview).

The project [powershell script](/CSharp/scripts/VSCode/New-Enviroment.ps1) that will replicates an opinionated Visual Studio Code setup for working on this project.

## Running C# Unit Test Suite

```powershell Powershell: Working with dotnet CLI to run Unit Tests

# Make sure you are in the right directory for .NET CLI to work.
# Typically this is where the Solution file lives. In this case Mermaker.slnx.

cd .\CSharp\src

# Simple Quick Check
dotnet test

# Most Detailed Output
 dotnet test -l "console;verbosity=detailed"
```
