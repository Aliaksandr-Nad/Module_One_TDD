using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions
{
    public class HappyEmotion : IEmotion
    {
        public string Status()
        {
            return "I'm Happy now!";
        }

        public string Face()
        {
            return "^_^";
        }

        public string Voice()
        {
            return "(Happy speech):";
        }
    }
}