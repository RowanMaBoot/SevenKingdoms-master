using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrusaderKings2Localisation
{
    class PopUp
    {
        public string message;
        public string caption;
        public MessageBoxButtons buttons;
        public MessageBoxIcon icon;
        public MessageBoxDefaultButton defaultButtons;
        public DialogResult result;

        public void Message(string newMessage)
        {
            message = newMessage;
        }
        public void Caption(string newCaption)
        {
            caption = newCaption;
        }
        public void Buttons(MessageBoxButtons newButtons)
        {
            buttons = newButtons;
        }
        public void Icon(MessageBoxIcon newIcon)
        {
            icon = newIcon;
        }
        public void DefaultButtons(MessageBoxDefaultButton newDefaultButtons)
        {
            defaultButtons = newDefaultButtons;
        }
        public void Result(DialogResult newResult)
        {
            result = newResult;
        }
    }
}
