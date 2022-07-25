using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    class MainClass
    {
        public static void isEmpty(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        public static void onlyNumeric(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return;
            }
            else
            {
                string valid = "^([0-9]+([.][0-9]*)?|[.][0-9]+)$";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("Enter Number Only");
                    string s = t.Text;
                    if (s.Length > 1)
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                    else
                    {
                        s = "";
                    }
                    t.Text = s;
                    t.SelectAll();
                }
            }


        }

        
        public static void onlyAlphabet(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return;
            }
            else
            {
                string valid = @"^[a-zA-Z\s]+$";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("Enter Alphabets Only");
                    string s = t.Text;
                    if (s.Length > 1)
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                    else
                    {
                        s = "";
                    }
                    t.Text = s;
                    t.SelectAll();
                }
            }
        }


        public static void AlphaNumeric(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return;
            }
            else
            {
                string valid = @"^([A-Za-z0-9&\s])*$";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("Symbols are not Allowed");
                    string s = t.Text;
                    if (s.Length > 1)
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                    else
                    {
                        s = "";
                    }
                    t.Text = s;
                    t.SelectAll();
                }
            }


        }

        public static void mobileNo(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return;
            }
            else
            {
                string valid = @"^((\+92)?(0092)?(92)?(0)?)(3)([0-9]{9})$";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("Enter valid Mobile Number");
                    t.Text = "";
                }
            }


        }

        public static void checkEmail(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return ;
            }
            else
            {
                string valid = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("Enter valid Email");
                    t.Text = "";
                }
            }
        }

        public static void alphaNumericSpecial(TextBox t, ErrorProvider error)
        {
            if (t.Text.Length == 0)
            {
                error.Clear();
                return;
            }
            else
            {
                string valid = @"^[A-Za-z0-9\s!@#$%^&*()_+=-`~\\\]\[{}|';:/.,?><]*$";
                if (Regex.IsMatch(t.Text, valid))
                {
                    error.Clear();
                }
                else
                {
                    error.SetError(t, "");
                    MessageBox.Show("That entry is not allowed");
                    string s = t.Text;
                    if (s.Length > 1)
                    {
                        s = s.Substring(0, s.Length - 1);
                    }
                    else
                    {
                        s = "";
                    }
                    t.Text = s;
                    t.SelectAll();
                }
            }
        }
    }
}
