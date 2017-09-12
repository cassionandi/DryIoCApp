using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using DryIocApp.Services;

namespace DryIocApp.ViewModels
{
    public class SpeakPageViewModel : BindableBase
    {

        private ITextToSpeech _textToSpeech;

        private string _textToSay = "Text to say hello prism dry ioc";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand => new DelegateCommand(Speak);

        public SpeakPageViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
        }

        private void Speak(){
            _textToSpeech.Speak(TextToSay);   
        }
    }
}
