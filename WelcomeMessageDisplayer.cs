using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Class responsible for displaying the welcome message
    /// </summary>
    public class WelcomeMessageDisplayer
    {
        private readonly IWelcomeMessageGenerator welcomeMessageGenerator;

        public WelcomeMessageDisplayer(IWelcomeMessageGenerator welcomeMessageGenerator)
        {
            this.welcomeMessageGenerator = welcomeMessageGenerator;
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine(welcomeMessageGenerator.GenerateWelcomeMessage());
        }

    }
}
