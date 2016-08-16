using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PokemonGoBot.GUI.GUI
{
    public class TextBoxStreamWriter : TextWriter
    {
        private readonly TextBox _output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            MethodInvoker action = delegate { _output.AppendText(value.ToString()); };
            _output.BeginInvoke(action);
        }

        public override Encoding Encoding => System.Text.Encoding.UTF8;
    }
}
