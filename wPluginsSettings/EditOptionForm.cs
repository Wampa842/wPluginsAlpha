using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wPluginsSettings
{
    public partial class EditOptionForm : Form
    {
        public enum OptionType { Text, TextNotEmpty, Decimal, Integer, Boolean};
        public string ReturnString { get; private set; }
        OptionType optionType;
        string optionName;

        public EditOptionForm()
        {
            InitializeComponent();
        }
        public DialogResult EditString(string name, string value, OptionType type)
        {
            string optionTypeString;
            switch (type)
            {
                case OptionType.Text:
                    {
                        optionTypeString = "text";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                case OptionType.Decimal:
                    {
                        optionTypeString = "decimal";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                case OptionType.Integer:
                    {
                        optionTypeString = "integer";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                case OptionType.Boolean:
                    {
                        optionTypeString = "true or false";
                        optionCheck.Enabled = true;
                        optionText.Enabled = false;
                        try
                        {
                            optionCheck.Checked = bool.Parse(value);
                        }
                        catch (FormatException)
                        {
                            optionCheck.Checked = false;
                        }
                    }
                    break;
                default:
                    {
                        optionTypeString = "you shouldn't be here...";
                    }
                    break;
            }
            optionName = name;
            optionNameLabel.Text = name + "(" + optionTypeString + "):";

            return base.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            switch (optionType)
            {
                case OptionType.Text:
                    {
                        ReturnString = optionText.Text;
                    }
                    break;
                case OptionType.TextNotEmpty:
                    {
                        if (string.IsNullOrWhiteSpace(optionText.Text))
                        {
                            MessageBox.Show(optionName + "must not be empty. Set it to zero if that's what you want.");
                            return;
                        }
                        ReturnString = optionText.Text;
                    }
                    break;
                case OptionType.Decimal:
                    {
                        char decimalPoint = Convert.ToChar(System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
                        string regexString = System.Text.RegularExpressions.Regex.Escape(@"\d+(" + decimalPoint + @"\d*)?");
                        if (!System.Text.RegularExpressions.Regex.IsMatch(optionText.Text, regexString))
                        {
                            MessageBox.Show(optionName + " must be a decimal number.");
                            return;
                        }
                        else if (string.IsNullOrWhiteSpace(optionText.Text))
                        {
                            MessageBox.Show(optionName + " must not be empty. Set it to zero if that's what you want.");
                            return;
                        }
                        else
                        {
                            ReturnString = optionText.Text;
                        }
                    }
                    break;
                case OptionType.Integer:
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(optionText.Text, System.Text.RegularExpressions.Regex.Escape("\\d")))
                        {
                            MessageBox.Show(optionName + " must be an integer.");
                            return;
                        }
                        else if (string.IsNullOrWhiteSpace(optionText.Text))
                        {
                            MessageBox.Show(optionName + "must not be empty. Set it to zero if that's what you want.");
                            return;
                        }
                        else
                        {
                            ReturnString = optionText.Text;
                        }
                    }
                    break;
                case OptionType.Boolean:
                    {
                        ReturnString = optionCheck.Checked.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
