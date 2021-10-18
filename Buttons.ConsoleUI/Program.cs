using System;
using Buttons.Core.Controllers;
using Buttons.Core.Repositories;
using Buttons.Core.Services;
using Buttons.Core.Views;

namespace Buttons.ConsoleUI
{
    public class ConsoleUI : IView
    {
        public string Text 
        { 
            set => Console.WriteLine(value); 
        }

        public void ButtonClick()
        {
            OnButtonClick?.Invoke(Console.ReadLine());
        }

        public event IView.QueryHandler OnButtonClick;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var consoleUI = new ConsoleUI();

            var controller = new ApplicationController
                (
                    consoleUI,
                    new EntityService(new EntityRepository())
                );

            controller.Start();

            //симулируем нажатие на кнопку
            consoleUI.ButtonClick();
        }
    }
}
