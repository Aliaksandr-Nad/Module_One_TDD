using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions
{
    class FearEmotion : IEmotion
    {
        public string Status()
        {
            return "I'm Fear now!";
        }

        public string Face()
        {
            return ">_<";
        }

        public string Voice()
        {
            return "(Scared speech):";
        }
    }
}