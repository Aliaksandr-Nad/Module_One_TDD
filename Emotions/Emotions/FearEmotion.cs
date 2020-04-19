using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions
{
    public class FearEmotion : IEmotion
    {
        public string FearStatus()
        {
            return "I'm Fear now!";
        }

        public string FearFace()
        {
            return null;
        }

        public string FearVoice()
        {
            return null;
        }

        public string HappyStatus()
        {
            throw new NotImplementedException();
        }

        public string HappyFace()
        {
            throw new NotImplementedException();
        }

        public string HappyVoice()
        {
            throw new NotImplementedException();
        }

        public object EvilStatus()
        {
            throw new NotImplementedException();
        }

        public object EvilFace()
        {
            throw new NotImplementedException();
        }

        public object EvilVoice()
        {
            throw new NotImplementedException();
        }
    }
}
