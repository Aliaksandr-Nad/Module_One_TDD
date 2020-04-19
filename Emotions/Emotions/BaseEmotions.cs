using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions
{
    public class BaseEmotions : IEmotion
    {
        public string HappyStatus()
        {
            return "I'm Happy now!";
        }

        public string HappyFace()
        {
            return "^_^";
        }

        public string HappyVoice()
        {
            return "(Happy speech):";
        }

        public object EvilStatus()
        {
            return "I'm Evil now!";
        }

        public object EvilFace()
        {
            return "*~*";
        }

        public object EvilVoice()
        {
            return "(Evil speech):";
        }

        public string FearStatus()
        {
            return "I'm Fear now!";
        }

        public string FearFace()
        {
            return ">_<";
        }

        public string FearVoice()
        {
            return "(Scared speech):";
        }
    }
}