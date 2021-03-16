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
    public partial class GrammarEditorForm : Form
    {
              public GrammarEditorForm()
        {
            InitializeComponent();
        }


        private void GrammarEditorForm_Load(object sender, EventArgs e)
        {
            //g.LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            

            startSymbolTextBox.Text = GrammarProvider.GetGrammar().StartSymbol.ToString();
            terminalsTextBox.Text = Helper.CharListToString(GrammarProvider.GetGrammar().Terminals);
            nonterminalsTextBox.Text = Helper.CharListToString(GrammarProvider.GetGrammar().Nonterminals);

            productionsDataGridView.DataSource = GrammarProvider.GetGrammar().ProductionList;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GrammarProvider.GetGrammar().Terminals = Helper.LowerLetters(terminalsTextBox.Text);
            GrammarProvider.GetGrammar().Nonterminals = Helper.UpperLetters(nonterminalsTextBox.Text);
            GrammarProvider.GetGrammar().StartSymbol = startSymbolTextBox.Text[0];
            //GrammarProvider.GetGrammar().SaveToJson(Properties.Resources.DefaultGrammarLocation);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
