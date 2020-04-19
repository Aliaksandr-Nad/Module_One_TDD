using Emotions.Emotions;

namespace Emotions
{
    public class Human
    {
        private BaseEmotions _emotion;
        private FearEmotion _fearEmotion;

        public Human(BaseEmotions emotion)
        {
            _emotion = emotion;
        }

        public Human(FearEmotion fearEmotion)
        {
            _fearEmotion = fearEmotion;
        }

        public string HappyHello()
        {
            return $"{_emotion.HappyVoice()}\tHello\t\t\t\t\t{_emotion.HappyFace()}";
        }

        public string HappyFeeling()
        {
            return $"{_emotion.HappyVoice()}\t{_emotion.HappyStatus()} and u?\t{_emotion.HappyFace()}";
        }

        public string EvilHello()
        {
            return $"{_emotion.EvilVoice()}\tHello\t\t\t\t\t{_emotion.EvilFace()}";
        }

        public string EvilFeeling()
        {
            return $"{_emotion.EvilVoice()}\t{_emotion.EvilStatus()} and u?\t{_emotion.EvilFace()}";
        }

        public string FearFeeling()
        {
            return $"{_emotion.HappyStatus()} and u?";
        }
    }
}
