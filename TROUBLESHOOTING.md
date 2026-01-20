# C# Troubleshooting Cheat Sheet

## Check .NET Version
dotnet --version
dotnet --list-sdks

## Restore Packages
dotnet restore

## Clean and Rebuild
dotnet clean
dotnet build

## Delete bin/obj Folders
Right-click on bin and obj folders in VS Code and choose Delete, then run:
dotnet build

## Stop a Running Web Server
Press Ctrl+C in the Terminal

## Port Already in Use
- Press Ctrl+C to stop the server
- Click PORTS tab, right-click the port, choose "Stop Forwarding Port"
- Run dotnet run again

## Common Error Messages

"The type or namespace name could not be found"
- Missing using statement or package reference
- Run dotnet restore

"The current .NET SDK does not support targeting .NET X"
- Version mismatch between SDK and project
- Check dotnet --version

"Address already in use"
- Port conflict
- Stop previous instance with Ctrl+C or stop port forwarding

## Getting Help
- Office hours: Check the syllabus for drop-in sessions and link to make an appointment
- Email or call me
- Make an appointment in Navigate for tutoring 