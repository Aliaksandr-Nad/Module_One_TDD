using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions.Interface
{
    public interface IEmotion
    {
        string HappyStatus();
        string HappyFace();
        string HappyVoice();

        object EvilStatus();
        object EvilFace();
        object EvilVoice();

        string FearStatus();
        string FearFace();
        string FearVoice();
    }
}