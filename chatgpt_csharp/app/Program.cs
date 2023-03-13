﻿// See https://aka.ms/new-console-template for more information

using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;


namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Connected");

            var apiKey = "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";

            var gpt3 = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });

            string[] arguments = Environment.GetCommandLineArgs();

            var Variants = 1;

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
                    Console.WriteLine(Count+":"+choice.Text);
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
