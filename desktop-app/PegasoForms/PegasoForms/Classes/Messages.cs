using System.Windows.Forms;

namespace PegasoForms.Classes
{
    public class Messages
    {
        public static void EmptyFieldMessage(string fieldName, Control controlToFocus)
        {
            string message = $"O preenchimento do campo '{fieldName}' é obrigatório!";

            ShowInformationMessage(message, controlToFocus);
        }

        private static void ShowInformationMessage(string message, Control controlToFocus)
        {
            MessageBox.Show(message, Constants.SYSTEM_TITLE_SIMPLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (controlToFocus != null) controlToFocus.Focus();
        }

    }
}
