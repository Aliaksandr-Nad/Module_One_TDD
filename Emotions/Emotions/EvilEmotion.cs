using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions
{
    public class EvilEmotion : IEmotion
    {
        public string Status()
        {
            return "I'm Evil now!";
        }

        public string Face()
        {
            return "*~*";
        }

        public string Voice()
        {
            return "(Evil speech):";
        }
    }
}