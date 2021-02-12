using PegasoForms.Classes;
using PegasoModels.Database.Versions;
using PegasoModels.Models;
using System;
using System.Windows.Forms;

namespace PegasoForms.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.Text = Constants.SYSTEM_TITLE_SIMPLE;
            this.AcceptButton = BtnConfirm;

            FormUtils.StartDialogLayout(this, Constants.SYSTEM_ICON);
            
            StartComponents();
            StartDatabase();

            PicSystemIcon.Visible = false;
        }


        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Exit();
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    User user = User.Select(TbUsername.Text, TbPassword.Text);

                    if (user == null)
                    {
                        Messages.ShowErrorMessage(Constants.INVALID_LOGIN_MESSAGE, TbUsername);
                        return;
                    }
                    else if (!user.Active)
                    {
                        Messages.ShowErrorMessage(Constants.INACTIVE_USER_MESSAGE, TbUsername);
                        return;
                    }

                    new FormHome(user).Show();

                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                Messages.ExceptionErrorMessage(ex, TbUsername);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }
        
        private bool IsValid()
        {
            if (String.IsNullOrEmpty(TbUsername.Text)) {
                Messages.EmptyFieldMessage(LblUsername.Text, TbUsername);
                return false;
            }

            if (String.IsNullOrEmpty(TbPassword.Text))
            {
                Messages.EmptyFieldMessage(LblPassword.Text, TbPassword);
                return false;
            }

            return true;
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void StartComponents()
        {
            //IMAGES
            FormUtils.StartPictureBox(PicSystemIcon, Constants.SYSTEM_IMAGE);


            //LABELS
            FormUtils.StartLabel(LblUsername, Constants.USERNAME_LABEL);
            FormUtils.StartLabel(LblPassword, Constants.PASSWORD_LABEL);


            //TEXTBOXES
            FormUtils.StartTextBox(TbUsername, 50);
            FormUtils.StartTextBoxPassword(TbPassword, 20);


            //BUTTONS
            FormUtils.StartButton(BtnConfirm, Constants.CONFIRM_IMAGE, Constants.CONFIRM_BUTTON);
            FormUtils.StartButton(BtnCancel, Constants.CANCEL_IMAGE, Constants.CANCEL_BUTTON);
        }

        private void StartDatabase()
        {
            try
            {
                new DBVersion().UpdateVersion();
            }
            catch (Exception ex)
            {
                Messages.ExceptionErrorMessage(ex, null);
            }
        }

    }
}
