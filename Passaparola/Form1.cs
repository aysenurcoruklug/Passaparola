using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;


        //herhangi bir tuşa tıklandığında ne olsun
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                switch (soruno)
                {
                    case 1:
                        if(textBox1.Text == "Aşk ve gurur")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                           
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if ( textBox1.Text == "Bilinçaltının gücü")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Çanlar kimin için çalıyor")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Doğunun limanları" )
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Eski dünya seyahatnamesi" )
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Fareler ve insanlar")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Genç werther'in acıları")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Hayvan çiftliği")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "İki şehrin hikayesi")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "Jane eyre")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Kürk mantolu madonna")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Morgue sokağı cinayetleri")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Notre dame'in kamburu")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Oz büyücüsü")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Pinokyo")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Rüzgar gibi geçti")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Suç ve ceza")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Uğultulu tepeler")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Vadideki zambak")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Yeraltından notlar")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();
            textBox1.Clear();

            if (soruno == 1) //aşk ve gurur
            {
                richTextBox1.Text = "Taşralı bir beyefendinin kızı olan Elizabeth Bennett ile varlıklı ve soylu toprak sahibi Fitzwilliam Darcy arasındaki çatışmayı anlatan kitabın adı?";
                button4.BackColor = Color.Yellow;
                button25.Text = button4.Text;

                
            }
            if (soruno == 2) //bilinçaltının gücü
            {
                richTextBox1.Text = "Yazarın ilk olarak 1963 yılında yayımladığı kitabı, insan zihnine dair en çok merak edilen soruları yanıtlıyor.Kişilerin bilinçaltını doğru şekilde kullanarak maddi ve manevi anlamda neler başarabileceğini şaşırtıcı örneklerle ortaya koyuyor.";
                button5.BackColor = Color.Yellow;
                button25.Text = button5.Text;
            }
            if (soruno == 3) //çanlar kimin için çalıyor
            {
                richTextBox1.Text = "Hemingway’in 1940 yılında yayımlanan bu eserinde,bir gazeteci ve yazar olarak katıldığı İspanya iç savaşında bizzat kendi gözlemlerini anlattığı bu roman, savaşın anlamsızlığını ve kaybettirdiklerini de gözler önüne seriyor.";
                button6.BackColor = Color.Yellow;
                button25.Text = button6.Text;
            }
            if (soruno == 4) //doğunun limanları
            {
                richTextBox1.Text = "Amin Maalouf, Osmanlı İmparatorluğu'nu, etnik çatışma ve çözülmeyi, Avrupa'yla Doğu'nun, dillerin ve dinlerin tanışma noktasını bu eserinde anlatmıştır.";
                button7.BackColor = Color.Yellow;
                button25.Text = button7.Text;
            }
            if (soruno == 5) //eski dünya seyahatnamesi
            {
                richTextBox1.Text = "İlber Ortaylı'nın gezi izlenim-seyahatname türündeki kitabıdır. Aşina Kitaplar Yayınları tarafından Mart 2007'de basılmıştır.";
                button8.BackColor = Color.Yellow;
                button25.Text = button8.Text;
            }
            if (soruno == 6) //fareler ve insanlar
            {
                richTextBox1.Text = "John Steinbeck tarafından yazılmış bir roman. İlk defa 1937 yılında yayınlanan eser, iki gezgin çiftlik işçisi olan George Milton ve Lennie Small'un büyük bunalım sırasında Kaliforniya'da yaşadıkları trajik olayları anlatır.";
                button9.BackColor = Color.Yellow;
                button25.Text = button9.Text;
            }
            if (soruno == 7) //genç werther in acıları
            {
                richTextBox1.Text = "Johann Wolfgang von Goethe (1749 - 1832) tarafından 1774 yılında ve iki haftada yazılmış mektup romandır. Goethe, bu romanı yazdığında 25 yaşındaydı.";
                button10.BackColor = Color.Yellow;
                button25.Text = button10.Text;
            }
            if (soruno == 8) //hayvan çiftliği
            {
                richTextBox1.Text = "George Orwell'in mecazi bir dille yazılmış, fabl tarzındaki siyasi hiciv romanı. Roman ilk olarak 1945'te Birleşik Krallık'ta yayımlandı.";
                button11.BackColor = Color.Yellow;
                button25.Text = button11.Text;
            }
            if (soruno == 9) //iki şehrin hikayesi
            {
                richTextBox1.Text = "Charles Dickens'ın 1859 yılında gazetelerde tefrika edilmek üzere yazdığı, konusu Fransız Devrimi esnasında ve öncesinde Paris ve Londra'da geçen romandır. 200 milyonun üzerindeki satışı ile tüm zamanların en meşhur edebiyat eserleri arasındadır.";
                button13.BackColor = Color.Yellow;
                button25.Text = button13.Text;
            }
            if (soruno == 10) //jane eyre
            {
                richTextBox1.Text = "Charlotte Brontë'ın 1847'de yayımladığı romandır.Victoria dönemi İngilteresinde farklı sınıftan iki kişi arasındaki bir aşkı anlatan roman, toplumda yaşanan dini baskıyı, sınıf ayrımını ve erkek üstünlüğünü gerçekçi bir biçimde yansıtır.";
                button14.BackColor = Color.Yellow;
                button25.Text = button14.Text;
            }
            if (soruno == 11) //kürk mantolu madonna
            {
                richTextBox1.Text = "Sabahattin Ali'nin 1943 yılında yayımladığı bir romanıdır. Kitapta dokunaklı bir aşk hikâyesi anlatılmaktadır.";
                button15.BackColor = Color.Yellow;
                button25.Text = button15.Text;
            }
            if (soruno == 12) //morque sokağı cinayetleri
            {
                richTextBox1.Text = "Edgar Allan Poe tarafından yazılan ve ilk defa 1841'de Graham's Magazine'de yayımlanan öykü. İlk dedektiflik öyküsü olarak kabul ediliyor.";
                button17.BackColor = Color.Yellow;
                button25.Text = button17.Text;
            }
            if (soruno == 13) //notre dame'in kamburu
            {
                richTextBox1.Text = "Victor Hugo'nun 1831 yılında yayınlanan ve Fransa’da krallık döneminin karanlık günlerinden kesitler sunan romanıdır. Okunması gereken, evrenselleşmiş ve dünya klasiklerinin başyapıtlardandır.";
                button18.BackColor = Color.Yellow;
                button25.Text = button18.Text;
            }
            if (soruno == 14) //oz büyücüsü
            {
                richTextBox1.Text = "L. Frank Baum tarafından yazılıp W. W. Denslow tarafından resimlendirilen bir çocuk romanı. ";
                button19.BackColor = Color.Yellow;
                button25.Text = button19.Text;
            }
            if (soruno == 15) //pinokyo
            {
                richTextBox1.Text = "İtalyan yazar Carlo Collodi'nin yazdığı çocuk romanı.Dünya çocuk edebiyatının başyapıtlarından birisidir.Carlo Collodi’nin 1881 yılında yazdığı ve bir çocuk gazetesinde tefrika olarak yayımladığı eserdir.";
                button20.BackColor = Color.Yellow;
                button25.Text = button20.Text;
            }
            if (soruno == 16) //rüzgar gibi geçti
            {
                richTextBox1.Text = " Amerikalı yazar Margaret Mitchell'ın 1936 tarihinde ilk basımı yapılmış Batı edebiyatının dünyaca ünlü tarihi roman kitabıdır. Amerikan İç Savaşı dönemini ele alıyor.";
                button21.BackColor = Color.Yellow;
                button25.Text = button21.Text;
            }
            if (soruno == 17) //suç ve ceza
            {
                richTextBox1.Text = "Rus yazar Fyodor Dostoyevski tarafından yazılan psikolojik ve dram türündeki romandır.Dostoyevski'nin beş yıl süren Sibirya sürgününün dönüşünde yazdığı tam uzunluktaki ikinci romanıdır.";
                button22.BackColor = Color.Yellow;
                button25.Text = button22.Text;
            }
            if (soruno == 18) //uğultulu tepeler
            {
                richTextBox1.Text = " Emily Brontë'nin tek romanı. İlk kez 1847 yılında Ellis Bell mahlası ile yayımlanmıştır. Emily öldükten sonra kız kardeşi Charlotte eseri yayıma hazırlayıp, Emily'nin gerçek ismi ile eserin ikinci bir baskısını yayımlamıştır.";
                button24.BackColor = Color.Yellow;
                button25.Text = button24.Text;
            }
            if (soruno == 19) //vadideki zambak
            {
                richTextBox1.Text = "Fransız yazar Honoré de Balzac'ın romanıdır. 1835'te yayımlanan ve yazarın en bilinen kitaplarından biridir.";
                button1.BackColor = Color.Yellow;
                button25.Text = button1.Text;
            }
            if (soruno == 20) //yeraltından notlar
            {
                richTextBox1.Text = "Dostoyevski'nin, Camus dahil olmak üzere birçok Batılı düşünürü varoluşçu anlamda etkilemiş bir klasik olarak kabul edilen kısa romanıdır.Gerçek dünyadan kendini soyutlamış veya buna zorunlu kalmış bir kişinin iç çatışmalarını ve hezeyanlarını ana eksen olarak belirler.";
                button2.BackColor = Color.Yellow;
                button25.Text = button2.Text;
            }

        }
    }
}