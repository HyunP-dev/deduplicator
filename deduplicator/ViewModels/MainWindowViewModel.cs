using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace deduplicator.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _inputText;

        [ObservableProperty]
        public string _resultText;

        public MainWindowViewModel()
        {
        }

        public void Dedumplicate()
        {
            ResultText = String.Join("\n",
                InputText.Split("\n")
                .Select(s => s.Trim())
                .Where(s => !s.IsWhiteSpace())
                .Distinct()
                .ToArray());
        }

        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);

            if (args.PropertyName == nameof(InputText))
            {
                Dedumplicate();
            }
        }
    }
}
