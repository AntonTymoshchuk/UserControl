﻿using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControl
{
    /// <summary>
    /// Логика взаимодействия для VolumeControl.xaml
    /// </summary>
    public partial class VolumeControl : UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            CoreAudioController coreAudioConteroller = new CoreAudioController();
            App.CoreAudioDevice = coreAudioConteroller.GetDefaultDevice(AudioSwitcher.AudioApi.DeviceType.Playback, AudioSwitcher.AudioApi.Role.Multimedia);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
        }
    }
}
