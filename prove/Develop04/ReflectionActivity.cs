using System;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);
        Random rand = new Random();
        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);

            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                
            };

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000);
            }
        }
        End();
    }
}

