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
        Grammar g = new Grammar();
        public GrammarEditorForm()
        {
            InitializeComponent();
        }

        public GrammarEditorForm(Grammar g)
        {
            this.g = g;
            InitializeComponent();
        }

        private void GrammarEditorForm_Load(object sender, EventArgs e)
        {
            //g.LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            
            startSymbolTextBox.Text = g.StartSymbol.ToString();
            terminalsTextBox.Text = Helper.CharListToString(g.Terminals);
            nonterminalsTextBox.Text = Helper.CharListToString(g.Nonterminals);

            productionsDataGridView.DataSource = g.ProductionList;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            g.Terminals = Helper.LowerLetters(terminalsTextBox.Text);
            g.Nonterminals = Helper.UpperLetters(nonterminalsTextBox.Text);
            g.StartSymbol = startSymbolTextBox.Text[0];
            g.SaveToJson(Properties.Resources.DefaultGrammarLocation);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
