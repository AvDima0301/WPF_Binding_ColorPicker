using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Binding_ColorPicker
{
    public class UColor
    {
        private string colorCode = "";
        public string ColorCode
        {
            get => colorCode;
            set => colorCode = value;
        }
        private Brush userColor;
        public Brush UserColor
        {
            get => userColor;
            set => userColor = value;
        }
    }
}
