using Emotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions
{
    public class Human
    {
        private IEmotion _emotion;

        public Human(IEmotion emotion)
        {
            _emotion = emotion;
        }

        public string Hello()
        {
            return $"{_emotion.Voice()}\tHello\t\t\t\t\t{_emotion.Face()}";
        }

        public string Feeling()
        {
            return $"{_emotion.Voice()}\t{_emotion.Status()} and u?\t{_emotion.Face()}";
        }
    }
}
