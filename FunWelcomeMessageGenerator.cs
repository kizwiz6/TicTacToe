using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Implementation of the WelcomeMessageGenerator
    /// </summary>
    public class FunWelcomeMessageGenerator : IWelcomeMessageGenerator
    {
        public string GenerateWelcomeMessage()
        {
            return @"
  1 | 2 | 3
  ---------
  4 | 5 | 6
  ---------
  7 | 8 | 9                                             
";
        }
    }
}
