using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class Form1 : Form, IControlView
    {
        Presenters.IControlPresenter _controlPresenter;

        public Form1()
        {
            InitializeComponent();
            _controlPresenter = new Presenters.ControlPresenter(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopButton_Click(sender, e);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _controlPresenter.start(FloorsField.Text);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            _controlPresenter.addPerson(NameField.Text,
                                        WeighField.Text,
                                        InitialFloorField.Text,
                                        DestinationFloorField.Text);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _controlPresenter.stop();
            setStopState(false);
        }
        public void displayError(string msg)
        {
            MessageBox.Show(msg,
                             "Ошибка",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
        }

        public void setStopState(bool state)    // this func and everything below called from "elevatorThread"
        {
            this.Invoke((MethodInvoker)delegate
            {
                StopButton.Enabled = state;
                StartButton.Enabled = !state;
            });
        }

        public void refreshInfoBox(string[] lines)
        {
            this.Invoke((MethodInvoker)delegate
            {
                InfoBox.Items.Clear();
                foreach (string line in lines)
                    InfoBox.Items.Insert(0, line);
            });
        }

        public void displayOverweight(bool state)
        {
            this.Invoke((MethodInvoker)delegate
            {
                OverloadLabel.Visible = state;
            });
        }
    }
}
