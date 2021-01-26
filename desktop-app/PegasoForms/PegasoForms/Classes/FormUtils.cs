using System.Drawing;
using System.Windows.Forms;

namespace PegasoForms.Classes
{
    public class FormUtils
    {
        public static void StartButton(Button button, Image image, string text)
        {
            button.Text = text;
            button.Image = (Image)(new Bitmap(image, new Size(16, 16))); ;
            button.Size = new Size(100, 25);
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public static void StartDialogLayout(Form form, Icon icon)
        {
            StartLayout(form, icon);

            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
        
        public static void StartLabel(Label label, string text)
        {
            label.Text = text;
        }

        public static void StartLayout(Form form, Icon icon)
        {
            form.Icon = icon;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
        }
        
        public static void StartMenuItem(ToolStripMenuItem menuItem, Image image, string title)
        {
            menuItem.Text = title;
            menuItem.Image = image;
        }
        
        public static void StartPictureBox(PictureBox pictureBox, Image image)
        {
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static void StartTextBox(TextBox textBox, int maxLength)
        {
            textBox.MaxLength = maxLength;
        }

        public static void StartTextBoxPassword(TextBox textBox, int maxLength)
        {
            StartTextBox(textBox, maxLength);
            
            textBox.UseSystemPasswordChar = true;
        }
    }
}
