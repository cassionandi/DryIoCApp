using System;
using AVFoundation;
using DryIocApp.iOS.Services;
using DryIocApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech_iOS))]
namespace DryIocApp.iOS.Services
{
    public class TextToSpeech_iOS : ITextToSpeech
    {
        public void Speak(string text)
        {
            var ss = new AVSpeechSynthesizer();
            var su = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f

            };

            ss.SpeakUtterance(su);

        }
    }
}
