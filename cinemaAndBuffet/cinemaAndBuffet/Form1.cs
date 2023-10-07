using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cinemaAndBuffet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;    // sayac mant�g�na gore burada yazmam gerekiyor her sayac art�s�nd kasa tutar�nda arrtmas� icin .


        private void button1_Click(object sender, EventArgs e)
        {
            int egypt, water, tea, ticket, total;  // misir, su, �ay, bilet
                                                   // degerleri string'e cevirirek textlere yazd�rd�k 
            egypt = Convert.ToInt16(textEgypt.Text);
            water = Convert.ToInt16(textWater.Text);
            tea = Convert.ToInt16(textTea.Text);
            ticket = Convert.ToInt16(textTicket.Text);

            //menudeki urunlerin fiyatlar� 
            total = egypt * 10 + tea * 10 + water * 5 + ticket * 30;
            LblTotal.Text = total.ToString() + " TL";

            // her defas�nda kasa degiskenine ekleyelim 
            kasatutar = kasatutar + total;
            LblVault.Text = kasatutar.ToString() + " TL";
        }

        // bu button temizlemek s�f�rlamak icin kullan�l�r 
        private void button2_Click(object sender, EventArgs e)
        {
            textTicket.Text = "";
            textTea.Text = "";
            textWater.Text = "";
            textEgypt.Focus();
        }
    }
}