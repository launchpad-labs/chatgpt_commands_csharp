// See https://aka.ms/new-console-template for more information

using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;

public static class Constants
{
    public const string API_KEY="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";
}

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Connected to GPT.");

            var gpt3 = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = Constants.API_KEY
            });

            string[] arguments = Environment.GetCommandLineArgs();

            var Variants = 1;
            if (arguments.Length < 2)
            {
                Console.WriteLine("Missing question argument.");
                System.Environment.Exit(0);
            }


            var Prompt = arguments[1];

            if (Prompt==null)
            {
                Prompt = "What is the capital of France?   Give me the answer as an 18th century cockney chimneysweep.";
            };

            Console.WriteLine("Q:" + Prompt);

            var completionResult = await gpt3.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                //Prompt = "What is the meaning of life?",
                //Prompt = "What is the deepest part of the ocean?",
                //Prompt = "Who won the FA cup in 1942?   Tell me the answer as an 18th century cockney chimneysweep.",
                Prompt = Prompt,
                Model = Models.TextDavinciV3,
                Temperature = 1F,
                MaxTokens = 1000,
                N = Variants
            });

            if (completionResult.Successful)
            {
                var Count = 0;
                foreach (var choice in completionResult.Choices)
                {
                    Count++;
                    Console.WriteLine(Count+":"+choice.Text.Trim());
                }
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
                Console.WriteLine($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }

        }
    }
}
