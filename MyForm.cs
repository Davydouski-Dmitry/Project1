using System;
using System.Windows.Forms;


namespace Project1
{
    class MyForm : Form
    {
        TextBox textBox;
        ExtButton extButton;

        public MyForm()
        {
            this.Text = "Form with Buttons";

            Button btn = new Button();
            btn.Text = "Button 1";
            btn.AutoSize = true;
            int left;
            int top;
            left = (this.ClientSize.Width
                - btn.Width) / 2;
            top = 50;

            btn.Click += ButtonOnClick;
            btn.Location = new System.Drawing.Point(left, top);

            btn.Parent = this;
            //this.Controls.Add(btn);
            top += btn.Height + 20;

            btn = new Button();
            btn.Text = "Button 2";
            btn.Location = new System.Drawing.Point(left, top);
            btn.Click += ButtonOnClick;
            btn.Parent = this;
            btn.Enabled = false;

            btn = null;

            textBox = new TextBox();
            textBox.Parent = this;
            textBox.Text = "Button";
            textBox.Width = 150;
            left = (this.ClientSize.Height - textBox.Width) / 2;
            top += 50;
            textBox.Location = new System.Drawing.Point(left, top);
            textBox.Focus();
            textBox.TextChanged += txtbox_TextChanged;

            extButton = new ExtButton();
            extButton.StrTextBox = textBox.Text;
            extButton.AutoSize = true;
            left = (this.ClientSize.Width - textBox.Width) / 2;
            top += textBox.Height + 20;
            extButton.Location = new System.Drawing.Point(left, top);
            extButton.Parent = this;

            extButton.Click += ButtonOnClickShades;



        }

        private bool enableButton1 = true;
        void ButtonOnClick(object sender, EventArgs e)
        {
            if (enableButton1)
                MessageBox.Show("First Button Clicked");
            else
                MessageBox.Show("Second Button Clicked");

            foreach (Control ctrl in this.Controls)
                ctrl.Enabled = !ctrl.Enabled;

            enableButton1 = !enableButton1;
        }

        void txtbox_TextChanged(object sender, EventArgs e)
        {
            extButton.StrTextBox = textBox.Text;
        }

        void ButtonOnClickShades(object sender, EventArgs e)
        {
            ModalDialogBox dlg = new ModalDialogBox();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Random rnd = new Random();
                int iShade = rnd.Next(255);
                if (dlg.GrayShades)
                {
                    this.BackColor = System.Drawing.Color.FromArgb(iShade,
                        iShade, iShade);
                }
                else
                {
                    this.BackColor = System.Drawing.Color.FromArgb(iShade,
                        rnd.Next(255), rnd.Next(255));
                }
            }
        }
    }
}