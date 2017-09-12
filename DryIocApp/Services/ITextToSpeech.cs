using System;
namespace DryIocApp.Services
{
    public interface ITextToSpeech
    {

        void Speak(string text);
    }
}
