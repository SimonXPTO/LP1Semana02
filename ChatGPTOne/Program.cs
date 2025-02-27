using System;
using System.Net;
using System.Runtime.InteropServices;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            while(true)
            {
                string question,response;
                Console.Write("Faz-me uma pergunta: ");
                question = Console.ReadLine();

                switch(question)
                {
                    case "Tens quantos anos?":
                        response = "Acabei de nascer!";
                        break;
                    case "Gostas de LP1?":
                        response = "Ainda não decidi sobre esse assunto";
                        break;
                    case "Que horas são?":
                        response = "Olha para o relogio!!!";
                        break;
                    case "Tens fome?":
                        response = "Tenho sempre fome";
                        break;
                    case "EXIT":
                        return;
                    default:
                        response = "Não reconheço esta pergunta";
                        break;
                }

                Console.WriteLine(response);
                }
            }
        }
    }

