using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public AddColor AddColor { get; set; }
        public ColorPicker()
        {
            AddColor = new AddColor(this);
            //InkPod = new ObservableCollection<UColor>();
            //red = 0;
            //blue = 0;
            //green = 0;
            //color = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private byte red; 
        public byte Red
        {
            get => red;
            set
            {
                red = value;
                CastomColor = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
                OnPropertyChanged();
            }
        }
        private byte blue;
        public byte Blue
        {
            get => blue;
            set
            {
                blue = value;
                CastomColor = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
                OnPropertyChanged();
            }
        }
        private byte green;
        public byte Green
        {
            get => green;
            set
            {
                green = value;
                CastomColor = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
                OnPropertyChanged();
            }

        }

        private SolidColorBrush color;        

        public Brush CastomColor
        {
            get => (Brush)color;

            set
            {
                color = (SolidColorBrush)value;
                OnPropertyChanged();
            }

        }

        public ObservableCollection<UColor> InkPod { get; set; } = new ObservableCollection<UColor>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
