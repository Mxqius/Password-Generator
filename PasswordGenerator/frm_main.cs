using System;
using PasswordGenerator.Generator;
using System.Windows.Forms;
using static PasswordGenerator.Generator.Password;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;

namespace PasswordGenerator
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            lowercaseCheckBox.Checked = true;
        }

        private async void makePassword()
        {
            await Task.Run(() =>
            {
                int length = Convert.ToInt32(tb_length.Value);
                bool includeUppercase = uppercaseCheckBox.Checked;
                bool includeLowercase = lowercaseCheckBox.Checked;
                bool includeNumbers = numbersCheckBox.Checked;
                bool includeSymbols = symbolsCheckBox.Checked;
                bool excludeDuplicate = excludeDuplicateCheckBox.Checked;
                bool includeSpaces = includeSpacesCheckBox.Checked;

                string chars = "";

                if (includeUppercase)
                    chars += Password.UppercaseChars;
                if (includeLowercase)
                    chars += Password.LowercaseChars;
                if (includeNumbers)
                    chars += Password.NumberChars;
                if (includeSymbols)
                    chars += Password.SymbolChars;
                if (includeSpaces)
                    chars += " ";

                if (string.IsNullOrEmpty(chars))
                {
                    MessageBox.Show("Please select at least one character type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string password = Password.GenerateRandomPassword(length, chars, excludeDuplicate);
                this.Invoke((MethodInvoker)delegate
                {
                    txt_password.Text = password;
                });
            });
        }
        private  void btn_generate_Click(object sender, EventArgs e)
        {
            makePassword();
        }

        private async void tb_length_Scroll(object sender, ScrollEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lbl_valueLength.Text = tb_length.Value.ToString();
                });
                makePassword();
            });
        }

        private void btn_copyPassword_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != string.Empty)
            {
                Clipboard.SetText(txt_password.Text);
                btn_copyPassword.Image = Properties.Resources.tick;
                Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    btn_copyPassword.Image = Properties.Resources.clipboard;
                });
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            // Assuming you have generated the password and stored it in a variable called 'password'
            PasswordStrength strength = Password.CheckPasswordStrength(txt_password.Text);

            switch (strength)
            {
                case PasswordStrength.VeryWeak:
                    lineVeryWeek.FillColor = Color.FromArgb(242, 76, 61);
                    lineWeek.FillColor = Color.FromArgb(193, 200, 207);
                    lineStrong.FillColor = Color.FromArgb(193, 200, 207);
                    break;
                case PasswordStrength.Weak:
                    lineVeryWeek.FillColor = Color.FromArgb(242, 190, 34);
                    lineWeek.FillColor = Color.FromArgb(242, 190, 34);
                    lineStrong.FillColor = Color.FromArgb(193, 200, 207);
                    break;
                case PasswordStrength.Strong:
                    lineVeryWeek.FillColor = Color.FromArgb(34, 166, 153);
                    lineWeek.FillColor = Color.FromArgb(34, 166, 153);
                    lineStrong.FillColor = Color.FromArgb(34, 166, 153);
                    break;
                default:
                    break;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            makePassword();
        }
    }
}
