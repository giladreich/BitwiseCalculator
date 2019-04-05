using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BitwiseCalculator
{
    public partial class MainWindow : Form
    {
        private readonly string REGEX_EXPR = "\\||\\&|\\^|>>|<<|%|\\+|-|/|\\*";

        public MainWindow()
        {
            InitializeComponent();
            tbxExpression.TextChanged += delegate
            {
                if (cbxAutoCalc.Checked)
                    Calculate();
            };
            btnCalc.Click += delegate { Calculate(); };
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Return)
                Calculate();
        }

        private void Calculate()
        {
            if (tbxExpression.Text == String.Empty)
            {
                tbxDec.Text = tbxHex.Text = tbxBin.Text = "";
                return;
            }

            // 0x002 | 0x010 & 0x040 | 0x200 << 3 >> 6 | 0x518 ^ 2048
            string expression = tbxExpression.Text;

            List<string> operatorsMatches = Regex.Matches(expression, REGEX_EXPR).Cast<Match>()
                .Select(m => m.Value.Trim()).ToList();

            List<string> valuesMatches = Regex.Split(expression, REGEX_EXPR)
                .Select(v => v.Trim()).ToList();

            List<int> values = new List<int>(valuesMatches.Count);

            bool bValidInput = true;
            foreach (string valueMatch in valuesMatches)
            {
                int valueBase = valueMatch.StartsWith("0x") ? 16 : 10;
                try {
                    values.Add(Convert.ToInt32(valueMatch, valueBase));
                }
                catch {
                    bValidInput = false;
                    break;
                }
            }

            if (!bValidInput || (operatorsMatches.Count != valuesMatches.Count - 1) || values.Count < 1)
            {
                tbxDec.Text = tbxHex.Text = tbxBin.Text = "Invalid input.";
                return;
            }

            int result = values[0];
            for (int i = 0; i < operatorsMatches.Count; i++)
            {
                int value = values[i + 1];
                switch (operatorsMatches[i])
                {
                    case "|" : result |=  value; break;
                    case "&" : result &=  value; break;
                    case "^" : result ^=  value; break;
                    case ">>": result >>= value; break;
                    case "<<": result <<= value; break;
                    case "%" : result %=  value; break;
                    case "+" : result +=  value; break;
                    case "-" : result -=  value; break;
                    case "/" : result /=  value; break;
                    case "*" : result *=  value; break;
                    default:
                        tbxDec.Text = tbxHex.Text = tbxBin.Text = $"Invalid Operator: {operatorsMatches[i]}";
                        return;
                }
            }

            tbxDec.Text = result.ToString();
            tbxHex.Text = result.ToString("X");
            tbxBin.Text = result.ToBinary(' ', 4);
        }

    }
}

public static class Utility
{
    public static string ToBinary(this int src, char delimiter, int block)
    {
        int bits = 0;
        string str = Convert.ToString(src, 2);
        for (int i = str.Length - 1; i >= 0; bits += block, i -= block);

        return String.Join(delimiter.ToString(), Regex.Split(str.PadLeft(bits, '0'), $"(?<=\\G.{{{block}}})")).TrimEnd(delimiter);
    }
}