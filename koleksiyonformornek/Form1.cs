using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koleksiyonformornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        ArrayList ogrenciler = new ArrayList()
        {
            "Mikail","Yunus","Elif","Sena","Furkan"
        };
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                uyariLbl.ForeColor = Color.DarkRed;
                uyariLbl.Text = "Alanlar boş geçilemez!";
            }
            else if (!listBox1.Items.Contains(textBox1.Text))
            {
                uyariLbl.ForeColor = Color.DarkRed;
                uyariLbl.Text = "Listede böyle bir kişi yok!";
            }
            else
            {
                string girilenIsim = textBox1.Text;
                ArrayList arr = new ArrayList();
                arr.Add(textBox2.Text);
                int index = ogrenciler.IndexOf(girilenIsim);
                ogrenciler.SetRange(index, arr);
                uyariLbl.ForeColor = Color.Lime;
                uyariLbl.Text = "Başarıyla değiştirildi!";
                listBox1.Items.Clear();
                foreach (var item in ogrenciler)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in ogrenciler)
            {
                listBox1.Items.Add(item);
            }
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                uyariLbl.Text = "";
                uyari2Lbl.Text = "";
                uyari3Lbl.Text = "";
                uyari4Lbl.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                uyari2Lbl.ForeColor = Color.DarkRed;
                uyari2Lbl.Text = "Alanlar boş geçilemez!";
            }
            else
            {
                if (listBox1.Items.Contains(textBox4.Text))
                {
                    uyari2Lbl.ForeColor = Color.Lime;
                    uyari2Lbl.Text = $"{textBox4.Text} adlı kişi {ogrenciler.IndexOf(textBox4.Text)}.indekste bulunuyor!";
                }
                else
                {
                    uyari2Lbl.ForeColor = Color.DarkRed;
                    uyari2Lbl.Text = $"{textBox4.Text} adlı kişi listede yok!";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                uyariLbl.Text = "";
                uyari2Lbl.Text = "";
                uyari3Lbl.Text = "";
                uyari4Lbl.Text = "";
                textBox4.Text = "";
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Text = "";
                textBox5.Enabled = false;
                textBox5.BackColor = Color.Gray;
            }
            else
            {
                textBox5.Enabled = true;
                textBox5.BackColor = Color.White;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            uyariLbl.Text = "";
            uyari2Lbl.Text = "";
            uyari3Lbl.Text = "";
            uyari4Lbl.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox3.Text == "")
                {
                    uyari3Lbl.ForeColor = Color.DarkRed;
                    uyari3Lbl.Text = "İsim alanı boş geçilemez!";
                }
                else
                {
                    string girilenIsim = textBox3.Text;
                    ogrenciler.Add(girilenIsim);
                    uyari3Lbl.ForeColor = Color.Lime;
                    uyari3Lbl.Text = "Başarıyla sona eklendi!";
                    listBox1.Items.Clear();
                    foreach (var item in ogrenciler)
                    {
                        listBox1.Items.Add(item);
                    }

                }
            }

            else
            {
                if (textBox3.Text == "" || textBox5.Text == "")
                {
                    uyari3Lbl.ForeColor = Color.DarkRed;
                    uyari3Lbl.Text = "Alanlar boş geçilemez!";
                }
                else
                {
                    if (!Int32.TryParse(textBox5.Text, out int val))
                    {
                        uyari3Lbl.ForeColor = Color.DarkRed;
                        uyari3Lbl.Text = "Geçerli bir indeks girilmelidir!";
                    }
                    else if (val > ogrenciler.Count)
                    {
                        uyari3Lbl.ForeColor = Color.DarkRed;
                        uyari3Lbl.Text = "Geçerli bir indeks girilmelidir!";
                    }
                    else
                    {
                        string girilenIsim = textBox3.Text;
                        ArrayList arr = new ArrayList();
                        arr.Add(girilenIsim);
                        ogrenciler.InsertRange(val, arr);
                        uyari3Lbl.ForeColor = Color.Lime;
                        uyari3Lbl.Text = $"Başarıyla {val}. indekse eklendi!";
                        listBox1.Items.Clear();
                        foreach (var item in ogrenciler)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox7.Text = "";
                label14.Text = "Öğrencinin Adını Giriniz";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox7.Text = "";
                label14.Text = "Öğrencinin İndeksini Giriniz";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                if (textBox7.Text == "")
                {
                    uyari4Lbl.ForeColor = Color.DarkRed;
                    uyari4Lbl.Text = "Alan boş geçilemez!";
                }
                else if (!listBox1.Items.Contains(textBox7.Text))
                {
                    uyari4Lbl.ForeColor = Color.DarkRed;
                    uyari4Lbl.Text = "Listede olmayan birini silemezsiniz!";
                }
                else
                {
                    string girilenIsim = textBox7.Text;
                    ogrenciler.Remove(girilenIsim);
                    uyari4Lbl.ForeColor = Color.Lime;
                    uyari4Lbl.Text = $"{girilenIsim} adlı kişi başarıyla silindi!";
                    listBox1.Items.Clear();
                    foreach (var item in ogrenciler)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButton5.Checked)
            {
                if (!Int32.TryParse(textBox7.Text, out int val))
                {
                    uyari4Lbl.ForeColor = Color.DarkRed;
                    uyari4Lbl.Text = "Geçerli bir indeks girilmelidir!";
                }
                else if (val > ogrenciler.Count-1)
                {
                    uyari4Lbl.ForeColor = Color.DarkRed;
                    uyari4Lbl.Text = "Geçerli bir indeks girilmelidir!";
                }
                else if (listBox1.Items.Count == 0)
                {
                    uyari4Lbl.ForeColor = Color.DarkRed;
                    uyari4Lbl.Text = "Listede silinecek öğrenci kalmadı!";
                }
                else
                {
                    uyari4Lbl.ForeColor = Color.Lime;
                    uyari4Lbl.Text = $"{val}. indeksteki {ogrenciler[val]} adlı öğrenci başarıyla silindi!";
                    ogrenciler.RemoveAt(val);
                    listBox1.Items.Clear();
                    foreach (var item in ogrenciler)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            uyariLbl.Text = "";
            uyari2Lbl.Text = "";
            uyari3Lbl.Text = "";
            uyari4Lbl.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }
    }
}

