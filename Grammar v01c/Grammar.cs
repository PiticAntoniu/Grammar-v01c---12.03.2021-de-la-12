using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Grammar_v01c
{
    public class Grammar
    {
        private string originalInput;

        #region date membre
        char startSymbol;
        List<char> nonterminals = new List<char>();
        List<char> terminals = new List<char>();
        List<Production> productionList = new List<Production>();
        private object v;

        public string OriginalInput { get => originalInput; set => originalInput = value; }



        public List<char> Nonterminals { get => nonterminals; set => nonterminals = value; }
        public List<char> Terminals { get => terminals; set => terminals = value; }

        public List<Production> ProductionList { get => productionList; set => productionList = value; }
        public char StartSymbol { get => startSymbol; set => startSymbol = value; }

   
        #endregion

        #region constructors
        public Grammar()
        {
            
        }

  

        public Grammar(string originalInput)
        {
            OriginalInput = originalInput;

            StartSymbol = OriginalInput[0];

            nonterminals = Helper.UpperLetters(OriginalInput);
            terminals = Helper.LowerAndSymbolsLetters(OriginalInput);

            SetProductions();
        }

        public Grammar(Grammar v)
        {
            this.v = v;
        }
        #endregion

        internal void Parse(string originalInput)
        {
            OriginalInput = originalInput;

            StartSymbol = OriginalInput[0];

            nonterminals = Helper.UpperLetters(OriginalInput);
            terminals = Helper.LowerAndSymbolsLetters(OriginalInput);

            SetProductions();
        }
        internal string GrammarInfoAsText()
        {

            return $@"Let G be a grammar with nonterminal symbols N = {Helper.FormatAsSet(Nonterminals)},<br>
set of terminal symbols T = {Helper.FormatAsSet(Terminals)}<br>.
start symbol {StartSymbol} <br>
set of production rules P = {FormatAsSet(ProductionList)}<br>";
        }

        internal void EliminateLambdaProductions()
        {
            Grammar g = new Grammar();

            List<char> lambdaNonterminals = new List<char>();
            lambdaNonterminals = GetLambdaNonterminals();

            // schimbam S daca avea S apartine lambdaNonterminals

            // pentru fiecare productie P
            // Expandam P in toate variantele sale
            // prin inlocuirea neterminalelor din lambdaNonterminals
            // cu el insusi sau cu nimic

        }

        private List<char> GetLambdaNonterminals()
        {
            List<char> [] N = new List<char>[100];

            int i = 0;
            N[i] = new List<char>();
            foreach(var p in productionList)
            {
                if (p.Right.Equals("@"))
                {
                    N[i].Add(p.Left);
                }
            }

            do
            {
                i++;
                N[i] = new List<char>(N[i - 1]);
                foreach (var p in productionList)
                {
                    if (Helper.StringContainsOnlyCharsFromList(p.Right,N[i-1])){
                        N[i].Add(p.Left);
                    }
                }
            }
            while (N[i].Intersect(N[i-1]).Count() != N[i].Count()) ; /// !!! TODO
            return N[i];
        }

        internal string GrammarInfoAsHTML()
        {
            StringBuilder t = new StringBuilder();
            t.Append("nonterminals  N=");
            t.Append(Helper.FormatAsSet(nonterminals, Properties.Resources.NonTerminalsColor));
            t.Append("<br>terminals  T=");
            t.Append(Helper.FormatAsSet(terminals, Properties.Resources.TerminalsColor));

            return t.ToString();
        }
        private string FormatAsSet(List<Production> productionList)
        {
            // {S->Aa , A->ab }

            string result = "{"; // nu uitati ca ar trebui StringBuilder in loc de string
            foreach (Production production in ProductionList)
            {
                result += production.Left + "->" + production.Right + " , ";
            }

            result = result.Remove(result.Length - 3, 3); // sterge " , " de la sfarsit
            result += "}";

            return result;
        }
        private void SetProductions()
        {
            // "SaA$Sb$Aaa&" => S->aA  S->b  A->aa
            // OriginalInput => ProductionList

            ProductionList.Clear();

            foreach (var production in OriginalInput.Split('$', '&'))
            {
                if (production.Length > 0)
                {
                    ProductionList.Add(
                        new Production
                        {
                            Left = production[0],
                            Right = production.Remove(0, 1)
                        }
                    );
                }
            }
        }
        internal void SaveToJson(string fileName)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(fileName, json);
        }
        internal void LoadFromFile(string fileName) // de gasit solutie mai eleganta :)
        {
            string json = File.ReadAllText(fileName);
            Grammar tempGrammar = new Grammar();
            tempGrammar = JsonConvert.DeserializeObject<Grammar>(json);
            
            startSymbol = tempGrammar.startSymbol;
            nonterminals = tempGrammar.nonterminals;
            terminals = tempGrammar.terminals;
            productionList = tempGrammar.productionList;
        }
    }
}