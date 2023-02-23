using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            int result_position;
            int result_total_length;
            long result_val;
            int offset = start_bit % 8;
            int align = Convert.ToInt32(txtAlign.Text);
            long mask = (int)Math.Pow((double)2, (double)length)-1;
            string resultArray = "";

            result_position = start_bit / 8;
            result_val = (value&mask) << offset;
            result_total_length = ((result_position / 8) + 1) * 8;

            txtResPosition.Text = result_position.ToString();
            if(result_val < 0x100)
            {
                txtResValue.Text = String.Format("0x{0:X2} ({1})", result_val, result_val);

                for (int cnt = 0; cnt < result_total_length; cnt++)
                {
                    if ((cnt > 0) && ((cnt % align) == 0))
                    {
                        resultArray += "\n";
                    }
                    if (cnt == result_position)
                    {
                        resultArray += String.Format("{0,2:X2} ", result_val);
                    }
                    else
                    {
                        resultArray += "00 ";
                    }
                }
            }
            else
            {
                int array_len = (int)Math.Log((double)result_val, 16)-1;
                string value_array = "";
                for(int cnt=0; cnt<array_len; cnt++)
                {
                    value_array += String.Format("{0:X} ", (result_val>>(cnt*8))&0xFF);
                }
                txtResValue.Text = value_array;

                for (int cnt = 0; cnt < result_total_length; cnt++)
                {
                    if ((cnt > 0) && ((cnt % align) == 0))
                    {
                        resultArray += "\n";
                    }
                    if ((cnt >= result_position) &&
                        (cnt < result_position+ array_len))
                    {
                        int temp = cnt - result_position;
                        resultArray += String.Format("{0,2:X2} ", (result_val >> (temp * 8)) & 0xFF);
                    }
                    else
                    {
                        resultArray += "00 ";
                    }
                }
            }

            rtbResultArray.Text = resultArray;
        }

    }
}
