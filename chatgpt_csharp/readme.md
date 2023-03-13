ChatGPT commandline access
==========================

## Requirements
* [.NET Framework 7](https://dotnet.microsoft.com/en-us/download/dotnet-framework) or higher
* [VSCode 2020 or higher](https://code.visualstudio.com/)

This repository contains a ChatGPT commandline utility written in the C# programming language 
and intended to run on the .NET 7 platform. All the programs have been coded using 
VSCode integrated development environment.

## Installation
1. Make sure you have .NET 7 and VSCode properly installed.
2. Download the project from GitHub onto your local machine.
3. Unzip the project into your preferred location.
4. Open VSCode and click the "Clone or Download" button to clone the project from GitHub.
5. In VSCode, click on the View tab and then the Terminal window. 
6. In the Terminal type "dotnet restore" to download the necessary NuGet packages and dependencies.        

## Usage
1. To run a program within VSCode, open Program.cs from the project folder, then click the View tab, then the Run option and then Start Debugging.
2. Query ChatGPT by running:
dotnet run "What is the capital of Brunei?"
3. The ChatGPT will be query basically the collective wisdom of the human race and return an answer to your specific question.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push the changes to the feature branch
5. Create a Pull Request

## License

This project is available under the MIT license. See the LICENSE file for more information.

## Contact
If you have any questions or feedback, please don't hesitate to contact me at <alex.mccombie@lspacelabs.com>.

Commandline usage examples:
---------------------------

dotnet run "What is the capital of France?"  
dotnet run "Who put the bomp in the bompabompabomp?"  
dotnet run "Explain the basics of the theory of relativity, in the voice of an 18th century cockney chimneysweep"  
dotnet run "What is the capital of Brunei and what does that name literally translate as?"  
dotnet run "Write a good example of a standard C# readme file that includes instructions for how to install the application and run it."  
