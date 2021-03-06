using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grammar_v01c
{
    public partial class grammarInfoForm : Form
    {
        public grammarInfoForm()
        {
            InitializeComponent();
        }

        private void parseButton_Click(object sender, EventArgs e)
        {

            GrammarProvider.GetGrammar().Parse(inputTextBox.Text);

            grammarInfoWebBrowser.DocumentText = GrammarProvider.GetGrammar().GrammarInfoAsText();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().SaveToJson(Properties.Resources.DefaultGrammarLocation);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            grammarInfoWebBrowser.DocumentText = GrammarProvider.GetGrammar().GrammarInfoAsHTML();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var t = new GrammarEditorForm();
            t.ShowDialog();
            //GrammarProvider.GetGrammar().LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            grammarInfoWebBrowser.DocumentText = GrammarProvider.GetGrammar().GrammarInfoAsHTML();
        }

        private void grammarInfoForm_Load(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            grammarInfoWebBrowser.DocumentText = GrammarProvider.GetGrammar().GrammarInfoAsHTML();
        }

        private void noLambdaProductionsButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().EliminateLambdaProductions();
            grammarInfoWebBrowser.DocumentText = GrammarProvider.GetGrammar().GrammarInfoAsHTML();
        }
    }
}
