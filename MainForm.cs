using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeliwareAPI;

namespace ExampleSeliwareUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Seliware.Injected += delegate
            {
                MessageBox.Show("Injected successfully!", "Seliware");
            };
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            scriptBox.Clear();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (!Seliware.IsInjected())
                MessageBox.Show("Please inject first", "Seliware");
            else 
                Seliware.Execute(scriptBox.Text);
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            string result = Seliware.Inject();
            if (result != "Success")
            {
                MessageBox.Show(result, "Seliware");
            }
        }

        private void injectionTimer_Tick(object sender, EventArgs e)
        {
            bool isInjected = Seliware.IsInjected();

            injectedLabel.Text = isInjected ? "Injected" : "Not Injected";
            injectedLabel.ForeColor = isInjected ? Color.LimeGreen : Color.Red;
        }
    }
}
