using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Binding_ColorPicker
{
    public class AddColor : ICommand
    {
        public event EventHandler CanExecuteChanged;

        ColorPicker cp = null;
        public AddColor(ColorPicker _cp)
        {
            cp = _cp;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cp.InkPod.Add(new UColor() { ColorCode = cp.CastomColor.ToString(), UserColor = cp.CastomColor});
        }
    }
}
