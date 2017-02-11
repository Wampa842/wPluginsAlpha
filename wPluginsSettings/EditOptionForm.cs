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
        public string ReturnString { get; private set; }
        //OptionType _optionType;
        string _optionType;
        string optionName;

        public EditOptionForm()
        {
            InitializeComponent();
        }
        public DialogResult EditString(string name, string value, string type)
        {
            _optionType = type;
            string optionTypeString;
            switch (_optionType)
            {
                //case OptionType.Text:
                case "text":
                    {
                        optionTypeString = "text";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                case "text-required":
                    {
                        optionTypeString = "required text";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                //case OptionType.Decimal:
                case "decimal":
                    {
                        optionTypeString = "decimal";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                //case OptionType.Integer:
                case "integer":
                    {
                        optionTypeString = "integer";
                        optionText.Enabled = true;
                        optionCheck.Enabled = false;
                        optionText.Text = value;
                    }
                    break;
                //case OptionType.Boolean:
                case "boolean":
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
                        MessageBox.Show(_optionType);
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
            switch (_optionType)
            {
                //case OptionType.Text:
                case "text":
                    {
                        ReturnString = optionText.Text;
                    }
                    break;
                //case OptionType.TextNotEmpty:
                case "text-required":
                    {
                        if (string.IsNullOrWhiteSpace(optionText.Text))
                        {
                            MessageBox.Show(optionName + "must not be empty. Set it to zero if that's what you want.");
                            return;
                        }
                        ReturnString = optionText.Text;
                    }
                    break;
                //case OptionType.Decimal:
                case "decimal":
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
                //case OptionType.Integer:
                case "integer":
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
                //case OptionType.Boolean:
                case "boolean":
                    {
                        ReturnString = optionCheck.Checked.ToString();
                    }
                    break;
                default:
                    break;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
