using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FußballProjekt.Lib;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;


namespace FußballProjekt.Core.ViewModels
{
    public partial class MainViewModel(IRepository repository) : ObservableObject
    {
        [ObservableProperty]
        public string _teamname = string.Empty;

        [ObservableProperty]
        public string _liga = string.Empty;

        [ObservableProperty]
        public string _stadion = string.Empty;

        [ObservableProperty]
        public string _spieler = string.Empty;

    }
}
