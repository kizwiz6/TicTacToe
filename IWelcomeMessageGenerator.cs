using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Interface for the WelcomeMessageGenerator to adhere to the Single Responsibility Principle (SRP)
    /// </summary>
    public interface IWelcomeMessageGenerator
    {
        string GenerateWelcomeMessage();
    }
}
