using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Emotions.Interface
{
    public interface IEmotion : IVoice, IFace
    {
        string Status();
    }
}