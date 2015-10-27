using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hashing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String hash()
        {
            String input = tb1.Text;
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                tb2.Text = sb.ToString();
                return sb.ToString();
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            hash();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tb2.Text == tbHash.Text)
            {
                MessageBox.Show("Data integrity valid, hash value are the same..!");
            }
            else
            {
                MessageBox.Show("Data integrity is not valid. Hash value has been changed...!");
            }

            
        }

    }
}
