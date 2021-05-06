using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Binding_ColorPicker 
{
    public class ColorPicker : INotifyPropertyChanged
    {
        private byte red = 0;
        public byte Red
        {
            get => red;
            set
            {
                red = value;
                OnPropertyChanged();
            }
        }
        private byte blue = 0;
        public byte Blue
        {
            get => blue;
            set
            {
                blue = value;
                OnPropertyChanged();
            }
        }
        private byte green = 0;
        public byte Green
        {
            get => green;
            set
            {
                green = value;
                OnPropertyChanged();
            }

        }

        private SolidColorBrush color = new SolidColorBrush();       

        public Brush ColorUser
        {
            get => (Brush)color;
           
            //set
            //{
            //    color = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
            //    OnPropertyChanged();
            //}

        }

        //public ColorPicker(byte red = 0, byte blue = 0, byte green = 0)
        //{
        //    Red = red;
        //    Blue = blue;
        //    Green = green;
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
