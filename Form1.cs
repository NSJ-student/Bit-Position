using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CanTest
{
    public partial class Form1 : Form
    {
        bool txtStartBit_focused;
        bool txtLength_focused;
        bool txtValue_focused;
        public Form1()
        {
            InitializeComponent();
            txtStartBit.GotFocus += txtStartBit_GotFocus;
            txtLength.GotFocus += txtLength_GotFocus;
            txtValue.GotFocus += txtValue_GotFocus;
            txtStartBit_focused = false;
            txtLength_focused = false;
            txtValue_focused = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            doConvert();
        }

        private void txtStartBit_GotFocus(object sender, EventArgs e)
        {
            txtStartBit.SelectAll();
            txtStartBit_focused = true;
        }
        private void txtLength_GotFocus(object sender, EventArgs e)
        {
            txtLength.SelectAll();
            txtLength_focused = true;
        }
        private void txtValue_GotFocus(object sender, EventArgs e)
        {
            txtValue.SelectAll();
            txtValue_focused = true;
        }

        private void txtStartBit_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                doConvert();
            }
        }

        private void txtLength_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doConvert();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtStartBit.Focus();
            }
        }

        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doConvert();
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtStartBit.Focus();
            }
        }

        private void txtStartBit_Click(object sender, EventArgs e)
        {
            if (txtStartBit_focused)
            {
                txtStartBit.SelectAll();
                txtStartBit_focused = false;
            }
        }

        private void txtLength_Click(object sender, EventArgs e)
        {
            if (txtLength_focused)
            {
                txtLength.SelectAll();
                txtLength_focused = false;
            }
        }

        private void txtValue_Click(object sender, EventArgs e)
        {
            if (txtValue_focused)
            {
                txtValue.SelectAll();
                txtValue_focused = false;
            }
        }

        private void doConvert()
        {
            if (txtStartBit.TextLength == 0)
            {
                return;
            }
            if (txtLength.TextLength == 0)
            {
                return;
            }
            if (txtValue.TextLength == 0)
            {
                return;
            }
            int start_bit = Convert.ToInt32(txtStartBit.Text);
            int length = Convert.ToInt32(txtLength.Text);
            long value = Convert.ToInt64(txtValue.Text);

            int offset = start_bit % 8;
            int align = Convert.ToInt32(txtAlign.Text);
            long mask = (int)Math.Pow((double)2, (double)length)-1;
            string resultArray = "";

            int result_position = start_bit / 8;
            long result_val = (value&mask) << start_bit;
            long result_val_partial = (value & mask) << offset;
            int result_total_length = ((result_position / 8) + 1) * 8;

            txtResPosition.Text = result_position.ToString();

            int array_len = (int)Math.Log((double)mask, 256)+1;
            string value_array = "";
            for (int cnt = 0; cnt < array_len; cnt++)
            {
                value_array += String.Format("{0,2:X2} ", (result_val_partial >> (cnt * 8)) & 0xFF);
            }
            txtResValue.Text = value_array;

            for (int cnt = 0; cnt < result_total_length; cnt++)
            {
                if ((cnt > 0) && ((cnt % align) == 0))
                {
                    resultArray += "\n";
                }

                resultArray += String.Format("{0,2:X2} ", (result_val >> (cnt * 8)) & 0xFF);
            }

            rtbResultArray.Text = resultArray;
        }

        private void btnConvertValue_Click(object sender, EventArgs e)
        {
            if (txtRefArray.TextLength == 0)
            {
                return;
            }
            if (txtStartBit.TextLength == 0)
            {
                return;
            }
            if (txtLength.TextLength == 0)
            {
                return;
            }
            string hexValues = txtRefArray.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
            if(hexValuesSplit.Length == 0)
            {
                return;
            }
            byte[] hexArray = new byte[hexValuesSplit.Length];
            int index = 0;
            foreach (String hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer.
                int converted = Convert.ToInt32(hex, 16);
                hexArray[index] = (byte)converted;
                index++;
            }

            int start_bit = Convert.ToInt32(txtStartBit.Text);
            int length = Convert.ToInt32(txtLength.Text);

            int result_total_length = length / 8;
            if (length % 8 > 0) { result_total_length++; }

            long result_val = 0;
            for (int cnt = 0; cnt < hexArray.Length; cnt++)
            {
                result_val |= (long)hexArray[ cnt] << (8 * cnt);
            }

            long mask = (int)Math.Pow((double)2, (double)length) - 1;
            result_val = (result_val>> start_bit) & mask;

            rtbResultArray.Text = result_val.ToString();
        }

    }
}
