using System.Data.SqlClient;
namespace Project_ADT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.BurlyWood;
            radioButton3.ForeColor = System.Drawing.Color.Blue;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Wingspan");
            cmb_items.Items.Add("Dominion");
            cmb_items.Items.Add("Scrabble");
            cmb_items.Items.Add("Catan");
            cmb_items.Items.Add("Axis & Allies");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Crimson;
            radioButton2.ForeColor = System.Drawing.Color.Blue;
            radioButton3.ForeColor = System.Drawing.Color.CornflowerBlue;


            cmb_items.Items.Clear();
            cmb_items.Items.Add("Warhammer");
            cmb_items.Items.Add("Mage Knight");
            cmb_items.Items.Add("Dreamblade");
            cmb_items.Items.Add("HorrorClix");
            cmb_items.Items.Add("Attacktix");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Orange;
            radioButton2.ForeColor = System.Drawing.Color.Pink;
            radioButton3.ForeColor = System.Drawing.Color.Violet;


            cmb_items.Items.Clear();
            cmb_items.Items.Add("Poker");
            cmb_items.Items.Add("Rummy");
            cmb_items.Items.Add("Cribbage");
            cmb_items.Items.Add("Patience");
            cmb_items.Items.Add("Blackjack");
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Wingspan")
            {
                txt_price.Text = "50";
            }

            else if (cmb_items.SelectedItem.ToString() == "Dominion")
            {
                txt_price.Text = "100";
            }

            else if (cmb_items.SelectedItem.ToString() == "Scrabble")
            {
                txt_price.Text = "150";
            }
            else if (cmb_items.SelectedItem.ToString() == "Catan")
            {
                txt_price.Text = "200";
            }
            else if (cmb_items.SelectedItem.ToString() == "Axis & Allies")
            {
                txt_price.Text = "250";
            }
            else if (cmb_items.SelectedItem.ToString() == "Warhammer")
            {
                txt_price.Text = "300";
            }
            else if (cmb_items.SelectedItem.ToString() == "Mage Knight")
            {
                txt_price.Text = "350";
            }
            else if (cmb_items.SelectedItem.ToString() == "Dreamblade")
            {
                txt_price.Text = "400";
            }
            else if (cmb_items.SelectedItem.ToString() == "HorrorClix")
            {
                txt_price.Text = "450";
            }
            else if (cmb_items.SelectedItem.ToString() == "Attacktix")
            {
                txt_price.Text = "500";
            }
            else if (cmb_items.SelectedItem.ToString() == "Poker")
            {
                txt_price.Text = "550";
            }
            else if (cmb_items.SelectedItem.ToString() == "Rummy")
            {
                txt_price.Text = "600";
            }
            else if (cmb_items.SelectedItem.ToString() == "Cribbage")
            {
                txt_price.Text = "650";
            }
            else if (cmb_items.SelectedItem.ToString() == "Patience")
            {
                txt_price.Text = "700";
            }
            else if (cmb_items.SelectedItem.ToString() == "Blackjack")
            {
                txt_price.Text = "750";
            }

            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
            txt_subtotal.Text = (Convert.ToInt32(txt_subtotal.Text) + Convert.ToInt32(txt_total.Text)).ToString();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt32(txt_subtotal.Text) - Convert.ToInt32(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt32(txt_net.Text) - Convert.ToInt32(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_subtotal.Text = (Convert.ToInt32(txt_subtotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }
    }
}