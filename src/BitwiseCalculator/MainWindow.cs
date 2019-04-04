using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BitwiseCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (tbxExpression.Text == "") return;

            // 0x002 | 0x010 & 0x040 | 0x200 << 3 >> 6 | 0x518 ^ 2048
            string expression = tbxExpression.Text;
            MatchCollection operators = Regex.Matches(expression, "\\||\\&|\\^|>>|<<");
            List<string> valuesStr  = Regex.Split(expression, "\\||\\&|\\^|>>|<<").Select(value => value.Trim()).ToList();

            List<int> values = new List<int>(operators.Count + 1);
            foreach (string valueStr in valuesStr)
            {
                int valueBase = valueStr.StartsWith("0x") ? 16 : 10;
                values.Add(Convert.ToInt32(valueStr, valueBase));
            }
            if (values.Count == 0 || operators.Count == 0) return;

            int result = values[0];
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i].Value)
                {
                    case "|":
                        result |= values[i + 1];
                        break;
                    case "&":
                        result &= values[i + 1];
                        break;
                    case "^":
                        result ^= values[i + 1];
                        break;
                    case ">>":
                        result >>= values[i + 1];
                        break;
                    case "<<":
                        result <<= values[i + 1];
                        break;
                    default:
                        tbxExpression.Text = $"Invalid Operator: {operators[i].Value}";
                        return;
                }
            }

            tbxDec.Text = result.ToString();
            tbxHex.Text = result.ToString("X");
            tbxBin.Text = Convert.ToString(result, 2);
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;
            switch (key)
            {
                case Keys.Return:
                    btnCalc.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
