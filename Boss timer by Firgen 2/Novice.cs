using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace Boss_timer_by_Firgen_2
{

    public partial class Novice : Form
    {
        public Novice()
        {
            string b = "223D7F40", //Sarleon
                   c = "325B91DD", //Firgen
                   d = "9209F1CF", //Vanda6
                   e = "425FF4C2"; //Fantom666


            string a = getHWID();
            if (!(a == b | a == c | a == d | a == e))return;
             

            InitializeComponent();
            Print newfrm = new Print();
            newfrm.Show();
            newfrm.Hide();
            RvR newfrm3 = new RvR();
            newfrm3.Show();
            newfrm3.Hide();
            Boss_Timer.Visible = true;
            timer1.Interval = 100;
            timer1.Enabled = true;
            label1Riolit.Text = String.Format("Текущее значение: {0}", trackBarRiolit.Value);
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);
            label1Adarog.Text = String.Format("Текущее значение: {0}", trackBarAdarog.Value);
            label1Karantal.Text = String.Format("Текущее значение: {0}", trackBarKarantal.Value);
            label1Bruhoshlak.Text = String.Format("Текущее значение: {0}", trackBarBruhoshlak.Value);
            label1Gordot.Text = String.Format("Текущее значение: {0}", trackBarGordot.Value);           
            label1Venoksis.Text = String.Format("Текущее значение: {0}", trackBarVenoksis.Value);
            label1Mandokir.Text = String.Format("Текущее значение: {0}", trackBarMandokir.Value);
            label1Zanzil.Text = String.Format("Текущее значение: {0}", trackBarZanzil.Value);
            label1Xairi.Text = String.Format("Текущее значение: {0}", trackBarXairi.Value);
            label1Djindo.Text = String.Format("Текущее значение: {0}", trackBarDjindo.Value);
            label1Vodjaka.Text = String.Format("Текущее значение: {0}", trackBarVodjaka.Value);
            label1Grun.Text = String.Format("Текущее значение: {0}", trackBarGrun.Value);
            label1Varoten.Text = String.Format("Текущее значение: {0}", trackBarVaroten.Value);
            label1Perotarn.Text = String.Format("Текущее значение: {0}", trackBarPerotarn.Value);
            label1Romog.Text = String.Format("Текущее значение: {0}", trackBarRomog.Value);
            label1Volrak.Text = String.Format("Текущее значение: {0}", trackBarVolrak.Value);
            label1Azshara.Text = String.Format("Текущее значение: {0}", trackBarAzshara.Value);
            label1Karsh.Text = String.Format("Текущее значение: {0}", trackBarKarsh.Value);
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);
            label1Arkurion.Text = String.Format("Текущее значение: {0}", trackBarArkurion.Value);
            label1Husan.Text = String.Format("Текущее значение: {0}", trackBarHusan.Value);
            label1Gilton.Text = String.Format("Текущее значение: {0}", trackBarGilton.Value);
            label1Alakir.Text = String.Format("Текущее значение: {0}", trackBarAlakir.Value);
            label1Setesh.Text = String.Format("Текущее значение: {0}", trackBarSetesh.Value);
            label1Kaktuar.Text = String.Format("Текущее значение: {0}", trackBarKaktuar.Value);
            label1Serdce.Text = String.Format("Текущее значение: {0}", trackBarSerdce.Value);
            label1Tenelov.Text = String.Format("Текущее значение: {0}", trackBarTenelov.Value);
            label1Kodo.Text = String.Format("Текущее значение: {0}", trackBarKodo.Value);
            label1Atroks.Text = String.Format("Текущее значение: {0}", trackBarAtroks.Value);
            label1Dven.Text = String.Format("Текущее значение: {0}", trackBarDven.Value);
            label1Illuzionist.Text = String.Format("Текущее значение: {0}", trackBarIlluzionist.Value);
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);
            label1Eranikus.Text = String.Format("Текущее значение: {0}", trackBarEranikus.Value);
            label1Nafra.Text = String.Format("Текущее значение: {0}", trackBarNafra.Value);
            label1Tarilzun.Text = String.Format("Текущее значение: {0}", trackBarTarilzun.Value);
            label1Doan.Text = String.Format("Текущее значение: {0}", trackBarDoan.Value);
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);
            label1Skorpez.Text = String.Format("Текущее значение: {0}", trackBarSkorpez.Value);
            label1Bengor.Text = String.Format("Текущее значение: {0}", trackBarBengor.Value);
            label1Hros.Text = String.Format("Текущее значение: {0}", trackBarHros.Value);
            label1Xitxi.Text = String.Format("Текущее значение: {0}", trackBarXitxi.Value);
            label1Idju.Text = String.Format("Текущее значение: {0}", trackBarIdju.Value);
            label1Istreb.Text = String.Format("Текущее значение: {0}", trackBarIstreb.Value);
            label1Edros.Text = String.Format("Текущее значение: {0}", trackBarEdros.Value);
            label1Damian.Text = String.Format("Текущее значение: {0}", trackBarDamian.Value);
            label1Izonomia.Text = String.Format("Текущее значение: {0}", trackBarIzonomia.Value);
            label1Orakl.Text = String.Format("Текущее значение: {0}", trackBarOrakl.Value);
            label1Zania.Text = String.Format("Текущее значение: {0}", trackBarZania.Value);
        }
        static string getHWID()
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            string id = dsk["VolumeSerialNumber"].ToString();
            return id;
        }
        class MyGlobalVars
        {
            //Огненная пропасть
            public static int sAdarogg = 0;
            public static int sKarantal = 0;
            public static int sBruho = 0;
            public static int sGordot = 0;
            public static int sBeilrok = 0;
            public static int sRiolit = 0;
            //Тернистая долина
            public static int sMaizot = 0;
            public static int sTetis = 0;
            public static int sVenoksis = 0;
            public static int sZanzil = 0;
            public static int sMandokir = 0;
            public static int sXairi = 0;
            public static int sDjindo = 0;
            public static int sVodjaka = 0;
            //Ульдум
            public static int sHusan = 0;
            public static int sGilton = 0;
            public static int sAlakir = 0;
            public static int sSetesh = 0;
            public static int sKaktuar = 0;
            public static int sSerdce = 0;
            // Эльдивианский лес
            public static int sGrun = 0;
            public static int sVaroten = 0;
            public static int sPerotarn = 0;
            public static int sRomog = 0;
            public static int sVolrak = 0;
            public static int sAzshara = 0;
            public static int sKarsh = 0;
            public static int sGlashatai = 0;
            // Храм нафры
            public static int sFen = 0;
            public static int sEranikus = 0;
            public static int sNafra = 0;
            //New
            public static int sSkorpez = 0;
            public static int sXitxi = 0;
            public static int sIdju = 0;
            public static int sIstreb = 0;
            public static int sEdros = 0;
            public static int sDamian = 0;
            public static int sIzonomia = 0;
            public static int sOrakl = 0;
            public static int sHros = 0;
            public static int sBengor = 0;
            public static int sZania = 0;
            // Урберфурт
            public static int sTenelov = 0;
            public static int sKodo = 0;
            public static int sAtroks = 0;
            public static int sDven = 0;
            public static int sIlluzionist = 0;
            //Лёд
            public static int sArkurion = 0;
            //Красногорье
            public static int sTarilzun = 0;
            public static int sDoan = 0;
            public static int sDrobitel = 0;
            //Воздух
            public static int sSolarian = 0;
            public static int sKeltas = 0;
        }
        float step = 0;

        Color currentColor = Color.DarkGreen;
        Color targetColor = Color.LightBlue;
        Random rnd = new Random();



        public void timer1_Tick(object sender, EventArgs e)
        {
            if (step >= 1f)
            {
                step = 0;

                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                currentColor = targetColor;
                targetColor = Color.FromArgb(R, G, B);
            }
            int mixR = (int)(currentColor.R * (1f - step) + targetColor.R * step);
            int mixG = (int)(currentColor.G * (1f - step) + targetColor.G * step);
            int mixB = (int)(currentColor.B * (1f - step) + targetColor.B * step);

            if (timerSkorpez.Enabled == true) buttonSkorpezStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonSkorpezStart.ForeColor = Color.Black;
            if (timerXitxi.Enabled == true) buttonXitxiStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonXitxiStart.ForeColor = Color.Black;
            if (timerIdju.Enabled == true) buttonIdjuStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonIdjuStart.ForeColor = Color.Black;
            if (timerIstreb.Enabled == true) buttonIstrebStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonIstrebStart.ForeColor = Color.Black;
            if (timerEdros.Enabled == true) buttonEdrosStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonEdrosStart.ForeColor = Color.Black;
            if (timerDamian.Enabled == true) buttonDamianStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDamianStart.ForeColor = Color.Black;
            if (timerIzonomia.Enabled == true) buttonIzonomiaStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonIzonomiaStart.ForeColor = Color.Black;
            if (timerOrakl.Enabled == true) buttonOraklStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonOraklStart.ForeColor = Color.Black;
            if (timerHros.Enabled == true) buttonHrosStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonHrosStart.ForeColor = Color.Black;
            if (timerBengor.Enabled == true) buttonBengorStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonBengorStart.ForeColor = Color.Black;
           
            if (timerZania.Enabled == true) buttonZaniaStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonZaniaStart.ForeColor = Color.Black;


            if (timerAdarog.Enabled == true) button1Adarog.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else button1Adarog.ForeColor = Color.Black;
            if (timerKarantal.Enabled == true) buttonKarantalStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKarantalStart.ForeColor = Color.Black;
            if (timerBruhoshlak.Enabled == true) button1.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else button1.ForeColor = Color.Black;
            if (timerGordot.Enabled == true) buttonGordotStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonGordotStart.ForeColor = Color.Black;
            if (timerBeilrok.Enabled == true) buttonBeilrokStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonBeilrokStart.ForeColor = Color.Black;
            if (timerRiolit.Enabled == true) buttonRiolitStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonRiolitStart.ForeColor = Color.Black;
            if (timerVenoksis.Enabled == true) buttonVenoksisStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonVenoksisStart.ForeColor = Color.Black;
            if (timerMandokir.Enabled == true) buttonMandokirStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonMandokirStart.ForeColor = Color.Black;
            if (timerXairi.Enabled == true) buttonXairiStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonXairiStart.ForeColor = Color.Black;
            if (timerZanzil.Enabled == true) buttonZanzilStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonZanzilStart.ForeColor = Color.Black;
            if (timerDjindo.Enabled == true) buttonDjindoStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDjindoStart.ForeColor = Color.Black;
            if (timerVodjaka.Enabled == true) buttonVodjakaStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonVodjakaStart.ForeColor = Color.Black;
            if (timerGrun.Enabled == true) buttonGrunStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonGrunStart.ForeColor = Color.Black;
            if (timerVaroten.Enabled == true) buttonVarotenStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonVarotenStart.ForeColor = Color.Black;
            if (timerPerotarn.Enabled == true) buttonPerotarnStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonPerotarnStart.ForeColor = Color.Black;
            if (timerRomog.Enabled == true) buttonRomogStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonRomogStart.ForeColor = Color.Black;
            if (timerVolrak.Enabled == true) buttonVolrakStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonVolrakStart.ForeColor = Color.Black;
            if (timerAzshara.Enabled == true) buttonAzsharaStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonAzsharaStart.ForeColor = Color.Black;
            if (timerKarsh.Enabled == true) buttonKarshStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKarshStart.ForeColor = Color.Black;
            if (timerGlashatai.Enabled == true) buttonGlashataiStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonGlashataiStart.ForeColor = Color.Black;
            if (timerArkurion.Enabled == true) buttonArkurionStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonArkurionStart.ForeColor = Color.Black;
            if (timerHusan.Enabled == true) buttonHusanStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonHusanStart.ForeColor = Color.Black;
            if (timerGilton.Enabled == true) buttonGiltonStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonGiltonStart.ForeColor = Color.Black;
            if (timerSetesh.Enabled == true) buttonSeteshStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonSeteshStart.ForeColor = Color.Black;
            if (timerAlakir.Enabled == true) buttonAlakirStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonAlakirStart.ForeColor = Color.Black;
            if (timerAlakir.Enabled == true) buttonAlakirStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonAlakirStart.ForeColor = Color.Black;
            if (timerKaktuar.Enabled == true) buttonKaktuarStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKaktuarStart.ForeColor = Color.Black;
            if (timerSerdce.Enabled == true) buttonSerdceStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonSerdceStart.ForeColor = Color.Black;
            if (timerTenelov.Enabled == true) buttonTenelovStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonTenelovStart.ForeColor = Color.Black;
            if (timerKodo.Enabled == true) buttonKodoStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKodoStart.ForeColor = Color.Black;
            if (timerAtroks.Enabled == true) buttonAtroksStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonAtroksStart.ForeColor = Color.Black;
            if (timerDven.Enabled == true) buttonDvenStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDvenStart.ForeColor = Color.Black;
            if (timerIlluzionist.Enabled == true) buttonIlluzionistStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonIlluzionistStart.ForeColor = Color.Black;
            if (timerSolarian.Enabled == true) buttonSolarianStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonSolarianStart.ForeColor = Color.Black;
            if (timerKeltas.Enabled == true) buttonKeltasStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKeltasStart.ForeColor = Color.Black;
            if (timerFen.Enabled == true) buttonFenStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonFenStart.ForeColor = Color.Black;
            if (timerEranikus.Enabled == true) buttonEranikusStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonEranikusStart.ForeColor = Color.Black;
            if (timerNafra.Enabled == true) buttonNafraStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonNafraStart.ForeColor = Color.Black;
            if (timerTarilzun.Enabled == true) buttonTarilzunStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonTarilzunStart.ForeColor = Color.Black;
            if (timerDoan.Enabled == true) buttonDoanStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDoanStart.ForeColor = Color.Black;
            if (timerDrobitel.Enabled == true) buttonDrobitelStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDrobitelStart.ForeColor = Color.Black;
        


            /*labelogon.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelterna.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelles.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelled.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labeluldum.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelurberfut.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelvozdux.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelnafra.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            labelkrasno.ForeColor = Color.FromArgb(mixR, mixG, mixB);*/
            step += 0.03f;
            Random rand = new Random();
            int n = 11;
            char[] A = new char[11];

            for (int i = 0; i < n; i++)
            {
                A[i] = (char)rand.Next(0x16A0, 0x16C0);
            }

           /*label1Bogi.Text = new string((char)A[0], 1);
             label2Bogi.Text = new string((char)A[1], 1);
             label3Bogi.Text = new string((char)A[2], 1);
             label4Bogi.Text = new string((char)A[3], 1);
             label5Bogi.Text = new string((char)A[4], 1);
             label6Bogi.Text = new string((char)A[5], 1);
             label7Bogi.Text = new string((char)A[6], 1);
             label8Bogi.Text = new string((char)A[7], 1);
             label9Bogi.Text = new string((char)A[8], 1);
             label10Bogi.Text = new string((char)A[9], 1);
             label11Bogi.Text = new string((char)A[10], 1);*/
        }

        //AdarogStart

        private void button1AdarogStart(object sender, EventArgs e)
        {
            if (trackBarAdarog.Value == 0) trackBarAdarog.Value = 1;
            this.timerAdarog.Interval = 1000;
            MyGlobalVars.sAdarogg = trackBarAdarog.Value * 60;
            if (timerAdarog.Enabled)
            {
                timerAdarog.Enabled = false;
            }
            else
            {
                timerAdarog.Enabled = true;
            }
            label1Adarog.Visible = false;
            label2Adarog.Visible = true;

            trackBarAdarog.Visible = false;
        }

        //AdarogStop

        private void buttonStopAdarog_Click(object sender, EventArgs e)
        {
            trackBarAdarog.Value = trackBarAdarog.Maximum;
            label1Adarog.Text = String.Format("Текущее значение: {0}", trackBarAdarog.Value);
            label2Adarog.Text = "";
            label1Adarog.Visible = true;
            label2Adarog.Visible = false;

            trackBarAdarog.Visible = true;
            timerAdarog.Enabled = false;
        }
        

        //KarantalStart
        private void buttonKarantalStart_Click(object sender, EventArgs e)
        {
            if (trackBarKarantal.Value == 0) trackBarKarantal.Value = 1;
            this.timerKarantal.Interval = 1000;
            MyGlobalVars.sKarantal = trackBarKarantal.Value * 60;
            if (timerKarantal.Enabled)
            {
                timerKarantal.Enabled = false;
            }
            else
            {
                timerKarantal.Enabled = true;
            }
            label1Karantal.Visible = false;
            label2Karantal.Visible = true;

            trackBarKarantal.Visible = false;

        }

        //KarantalStop

        private void buttonKarantalStop_Click(object sender, EventArgs e)
        {
            trackBarKarantal.Value = trackBarKarantal.Maximum;
            label1Karantal.Text = String.Format("Текущее значение: {0}", trackBarKarantal.Value);
            label2Karantal.Text = "";
            label1Karantal.Visible = true;
            label2Karantal.Visible = false;

            trackBarKarantal.Visible = true;
            timerKarantal.Enabled = false;
        }

        //BruhoshlakStart

        private void buttonBruhoshlakStart(object sender, EventArgs e)
        {
            if (trackBarBruhoshlak.Value == 0) trackBarBruhoshlak.Value = 1;
            this.timerBruhoshlak.Interval = 1000;
            MyGlobalVars.sBruho = trackBarBruhoshlak.Value * 60;
            if (timerBruhoshlak.Enabled)
            {
                timerBruhoshlak.Enabled = false;
            }
            else
            {
                timerBruhoshlak.Enabled = true;
            }
            label1Bruhoshlak.Visible = false;
            label2Bruhoshlak.Visible = true;

            trackBarBruhoshlak.Visible = false;
        }

        //BruhoshlakStop

        private void buttonBruhoshlakStop(object sender, EventArgs e)
        {
            trackBarBruhoshlak.Value = trackBarBruhoshlak.Maximum;
            label1Bruhoshlak.Text = String.Format("Текущее значение: {0}", trackBarBruhoshlak.Value);
            label2Bruhoshlak.Text = "";
            label1Bruhoshlak.Visible = true;
            label2Bruhoshlak.Visible = false;

            trackBarBruhoshlak.Visible = true;
            timerBruhoshlak.Enabled = false;
        }

        //GordotStart
        private void buttonGordotStart_Click(object sender, EventArgs e)
        {
            if (trackBarGordot.Value == 0) trackBarGordot.Value = 1;
            this.timerGordot.Interval = 1000;
            MyGlobalVars.sGordot = trackBarGordot.Value * 60;
            if (timerGordot.Enabled)
            {
                timerGordot.Enabled = false;
            }
            else
            {
                timerGordot.Enabled = true;
            }
            label1Gordot.Visible = false;
            label2Gordot.Visible = true;

            trackBarGordot.Visible = false;
        }

        //GordotStop

        private void buttonGordotStop_Click(object sender, EventArgs e)
        {
            trackBarGordot.Value = trackBarGordot.Maximum;
            label1Gordot.Text = String.Format("Текущее значение: {0}", trackBarGordot.Value);
            label2Gordot.Text = "";
            label1Gordot.Visible = true;
            label2Gordot.Visible = false;

            trackBarGordot.Visible = true;
            timerGordot.Enabled = false;
        }


        //BeilrokStart

        private void buttonBeilrokStart_Click(object sender, EventArgs e)
        {
            if (trackBarBeilrok.Value == 0) trackBarBeilrok.Value = 1;
            this.timerBeilrok.Interval = 1000;
            MyGlobalVars.sBeilrok = trackBarBeilrok.Value * 60;
            if (timerBeilrok.Enabled)
            {
                timerBeilrok.Enabled = false;
            }
            else
            {
                timerBeilrok.Enabled = true;
            }
            label1Beilrok.Visible = false;
            label2Beilrok.Visible = true;

            trackBarBeilrok.Visible = false;

        }
        //BeilrokStop

        private void buttonBeilrokStop_Click(object sender, EventArgs e)
        {
            trackBarBeilrok.Value = trackBarBeilrok.Maximum;
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);
            label2Beilrok.Text = "";
            label1Beilrok.Visible = true;
            label2Beilrok.Visible = false;

            trackBarBeilrok.Visible = true;
            timerBeilrok.Enabled = false;
        }
        //RiolitStart

        private void button3_Click(object sender, EventArgs e)
        {
            if (trackBarRiolit.Value == 0) trackBarRiolit.Value = 1;
            this.timerRiolit.Interval = 1000;
            MyGlobalVars.sRiolit = trackBarRiolit.Value * 60;
            if (timerRiolit.Enabled)
            {
                timerRiolit.Enabled = false;
            }
            else
            {
                timerRiolit.Enabled = true;
            }
            label1Riolit.Visible = false;
            label2Riolit.Visible = true;

            trackBarRiolit.Visible = false;
        }

        //RiolitStop

        private void button2_Click(object sender, EventArgs e)
        {
            trackBarRiolit.Value = trackBarRiolit.Maximum;
            label1Riolit.Text = String.Format("Текущее значение: {0}", trackBarRiolit.Value);
            label2Riolit.Text = "";
            label1Riolit.Visible = true;
            label2Riolit.Visible = false;
            trackBarRiolit.Visible = true;
            timerRiolit.Enabled = false;
        }

        //AdarogTimer

        private void timerAdarog_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sAdarogg;
            label2Adarog.Text = (MyGlobalVars.sAdarogg / 60).ToString() + ":" + (MyGlobalVars.sAdarogg % 60 >= 10 ? (object)(MyGlobalVars.sAdarogg % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sAdarogg % 60)));
            if (label2Adarog.Text == "5:00")
            Boss_Timer.ShowBalloonTip(2000,"Через 5 минут зареспавнится босс: ", "Адарогг",ToolTipIcon.Info);
            if (!(label2Adarog.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Адарогг", ToolTipIcon.Info);
            timerAdarog.Stop();
            label2Adarog.Text = "";
            trackBarAdarog.Value = trackBarAdarog.Maximum;
            label1Adarog.Text = String.Format("Текущее значение: {0}", trackBarAdarog.Value);

            label1Adarog.Visible = true;
            label2Adarog.Visible = false;

            trackBarAdarog.Visible = true;
            timerAdarog.Enabled = false;
        }

        //KarantalTimer

        private void timerKarantal_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKarantal;
            label2Karantal.Text = (MyGlobalVars.sKarantal / 60).ToString() + ":" + (MyGlobalVars.sKarantal % 60 >= 10 ? (object)(MyGlobalVars.sKarantal % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKarantal % 60)));
            if (label2Karantal.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Карантал", ToolTipIcon.Info);
            if (!(label2Karantal.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Карантал", ToolTipIcon.Info);
            timerKarantal.Stop();
            label2Karantal.Text = "";
            trackBarKarantal.Value = trackBarKarantal.Maximum;
            label1Karantal.Text = String.Format("Текущее значение: {0}", trackBarKarantal.Value);

            label1Karantal.Visible = true;
            label2Karantal.Visible = false;

            trackBarKarantal.Visible = true;
            timerKarantal.Enabled = false;
        }

        //BruhoshlakTimer

        private void timerBruhoshlak_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sBruho;
            label2Bruhoshlak.Text = (MyGlobalVars.sBruho / 60).ToString() + ":" + (MyGlobalVars.sBruho % 60 >= 10 ? (object)(MyGlobalVars.sBruho % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sBruho % 60)));
            if (label2Bruhoshlak.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Брюхошлак", ToolTipIcon.Info);
            if (!(label2Bruhoshlak.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Брюхошлак", ToolTipIcon.Info);
            timerBruhoshlak.Stop();
            label2Bruhoshlak.Text = "";
            trackBarBruhoshlak.Value = trackBarBruhoshlak.Maximum;
            label1Bruhoshlak.Text = String.Format("Текущее значение: {0}", trackBarBruhoshlak.Value);

            label1Bruhoshlak.Visible = true;
            label2Bruhoshlak.Visible = false;

            trackBarBruhoshlak.Visible = true;
            timerBruhoshlak.Enabled = false;
        }

        //GordotTimer

        private void timerGordot_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGordot;
            label2Gordot.Text = (MyGlobalVars.sGordot / 60).ToString() + ":" + (MyGlobalVars.sGordot % 60 >= 10 ? (object)(MyGlobalVars.sGordot % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGordot % 60)));
            if (label2Gordot.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Гордот", ToolTipIcon.Info);
            if (!(label2Gordot.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Городот", ToolTipIcon.Info);
            timerGordot.Stop();
            label2Gordot.Text = "";
            trackBarGordot.Value = trackBarGordot.Maximum;
            label1Gordot.Text = String.Format("Текущее значение: {0}", trackBarGordot.Value);

            label1Gordot.Visible = true;
            label2Gordot.Visible = false;

            trackBarGordot.Visible = true;
            timerGordot.Enabled = false;
        }


        //BeilrokTimer

        private void timerBeilrok_Tick(object sender, EventArgs e)
        {
                --MyGlobalVars.sBeilrok;
            label2Beilrok.Text = (MyGlobalVars.sBeilrok / 60).ToString() + ":" + (MyGlobalVars.sBeilrok % 60 >= 10 ? (object)(MyGlobalVars.sBeilrok % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sBeilrok % 60)));
            if (label2Beilrok.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Бейлрок", ToolTipIcon.Info);
            if (!(label2Beilrok.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Бейлрок", ToolTipIcon.Info);
            timerBeilrok.Stop();
            label2Beilrok.Text = "";
            trackBarBeilrok.Value = trackBarBeilrok.Maximum;
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);

            label1Beilrok.Visible = true;
            label2Beilrok.Visible = false;

            trackBarBeilrok.Visible = true;
            timerBeilrok.Enabled = false;            
        }

        //RiolitTimer

             private void timerRiolit_Tick(object sender, EventArgs e)
            {
            --MyGlobalVars.sRiolit;
            label2Riolit.Text = (MyGlobalVars.sRiolit / 60).ToString() + ":" + (MyGlobalVars.sRiolit % 60 >= 10 ? (object)(MyGlobalVars.sRiolit % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sRiolit % 60)));
            if (label2Riolit.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Риолит", ToolTipIcon.Info);
            if (!(label2Riolit.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Риолит", ToolTipIcon.Info);
            timerRiolit.Stop();
            label2Riolit.Text = "";
            trackBarRiolit.Value = trackBarRiolit.Maximum;
            label1Riolit.Text = String.Format("Текущее значение: {0}", trackBarRiolit.Value);

            label1Riolit.Visible = true;
            label2Riolit.Visible = false;

            trackBarRiolit.Visible = true;
            timerRiolit.Enabled = false;            
        }

        //Skorpez




        //VenoksisStart

        private void buttonVenoksisStart_Click(object sender, EventArgs e)
        {
            if (trackBarVenoksis.Value == 0) trackBarVenoksis.Value = 1;
            this.timerVenoksis.Interval = 1000;
            MyGlobalVars.sVenoksis = trackBarVenoksis.Value * 60;
            if (timerVenoksis.Enabled)
            {
                timerVenoksis.Enabled = false;
            }
            else
            {
                timerVenoksis.Enabled = true;
            }
            label1Venoksis.Visible = false;
            label2Venoksis.Visible = true;

            trackBarVenoksis.Visible = false;
        }

        //VenoksisStop

        private void buttonVenoksisStop_Click(object sender, EventArgs e)
        {
            trackBarVenoksis.Value = trackBarVenoksis.Maximum;
            label1Venoksis.Text = String.Format("Текущее значение: {0}", trackBarVenoksis.Value);
            label2Venoksis.Text = "";
            label1Venoksis.Visible = true;
            label2Venoksis.Visible = false;
            trackBarVenoksis.Visible = true;
            timerVenoksis.Enabled = false;
        }

        //MandokirStart

        private void buttonMandokirStart_Click(object sender, EventArgs e)
        {
            if (trackBarMandokir.Value == 0) trackBarMandokir.Value = 1;
            this.timerMandokir.Interval = 1000;
            MyGlobalVars.sMandokir = trackBarMandokir.Value * 60;
            if (timerMandokir.Enabled)
            {
                timerMandokir.Enabled = false;
            }
            else
            {
                timerMandokir.Enabled = true;
            }
            label1Mandokir.Visible = false;
            label2Mandokir.Visible = true;

            trackBarMandokir.Visible = false;
        }

        //MandokirStop

        private void buttonMandokirStop_Click(object sender, EventArgs e)
        {
            trackBarMandokir.Value = trackBarMandokir.Maximum;
            label1Mandokir.Text = String.Format("Текущее значение: {0}", trackBarMandokir.Value);
            label2Mandokir.Text = "";
            label1Mandokir.Visible = true;
            label2Mandokir.Visible = false;
            trackBarMandokir.Visible = true;
            timerMandokir.Enabled = false;
        }

        //ZanzilStart

        private void buttonZanzilStart_Click(object sender, EventArgs e)
        {
            if (trackBarZanzil.Value == 0) trackBarZanzil.Value = 1;
            this.timerZanzil.Interval = 1000;
            MyGlobalVars.sZanzil = trackBarZanzil.Value * 60;
            if (timerZanzil.Enabled)
            {
                timerZanzil.Enabled = false;
            }
            else
            {
                timerZanzil.Enabled = true;
            }
            label1Zanzil.Visible = false;
            label2Zanzil.Visible = true;

            trackBarZanzil.Visible = false;
        }

        //ZanzilStop

        private void buttonZanzilStop_Click(object sender, EventArgs e)
        {
            trackBarZanzil.Value = trackBarZanzil.Maximum;
            label1Zanzil.Text = String.Format("Текущее значение: {0}", trackBarZanzil.Value);
            label2Zanzil.Text = "";
            label1Zanzil.Visible = true;
            label2Zanzil.Visible = false;
            trackBarZanzil.Visible = true;
            timerZanzil.Enabled = false;
        }

        //XairiStart

        private void buttonXairiStart_Click(object sender, EventArgs e)
        {
            if (trackBarXairi.Value == 0) trackBarXairi.Value = 1;
            this.timerXairi.Interval = 1000;
            MyGlobalVars.sXairi = trackBarXairi.Value * 60;
            if (timerXairi.Enabled)
            {
                timerXairi.Enabled = false;
            }
            else
            {
                timerXairi.Enabled = true;
            }
            label1Xairi.Visible = false;
            label2Xairi.Visible = true;

            trackBarXairi.Visible = false;
        }

        //XairiStop

        private void buttonXairiStop_Click(object sender, EventArgs e)
        {
            trackBarXairi.Value = trackBarXairi.Maximum;
            label1Xairi.Text = String.Format("Текущее значение: {0}", trackBarXairi.Value);
            label2Xairi.Text = "";
            label1Xairi.Visible = true;
            label2Xairi.Visible = false;
            trackBarXairi.Visible = true;
            timerXairi.Enabled = false;
        }

        //DjindoStart

        private void buttonDjindoStart_Click(object sender, EventArgs e)
        {
            if (trackBarDjindo.Value == 0) trackBarDjindo.Value = 1;
            this.timerDjindo.Interval = 1000;
            MyGlobalVars.sDjindo = trackBarDjindo.Value * 60;
            if (timerDjindo.Enabled)
            {
                timerDjindo.Enabled = false;
            }
            else
            {
                timerDjindo.Enabled = true;
            }
            label1Djindo.Visible = false;
            label2Djindo.Visible = true;

            trackBarDjindo.Visible = false;
        }

        //DjindoStop

        private void buttonDjindoStop_Click(object sender, EventArgs e)
        {
            trackBarDjindo.Value = trackBarDjindo.Maximum;
            label1Djindo.Text = String.Format("Текущее значение: {0}", trackBarDjindo.Value);
            label2Djindo.Text = "";
            label1Djindo.Visible = true;
            label2Djindo.Visible = false;
            trackBarDjindo.Visible = true;
            timerDjindo.Enabled = false;
        }

        //VodjakaStart

        private void buttonVodjakaStart_Click(object sender, EventArgs e)
        {
            if (trackBarVodjaka.Value == 0) trackBarVodjaka.Value = 1;
            this.timerVodjaka.Interval = 1000;
            MyGlobalVars.sVodjaka = trackBarVodjaka.Value * 60;
            if (timerVodjaka.Enabled)
            {
                timerVodjaka.Enabled = false;
            }
            else
            {
                timerVodjaka.Enabled = true;
            }
            label1Vodjaka.Visible = false;
            label2Vodjaka.Visible = true;

            trackBarVodjaka.Visible = false;
        }

        //VodjakaStop

        private void buttonVodjakaStop_Click(object sender, EventArgs e)
        {
            trackBarVodjaka.Value = trackBarVodjaka.Maximum;
            label1Vodjaka.Text = String.Format("Текущее значение: {0}", trackBarVodjaka.Value);
            label2Vodjaka.Text = "";
            label1Vodjaka.Visible = true;
            label2Vodjaka.Visible = false;
            trackBarVodjaka.Visible = true;
            timerVodjaka.Enabled = false;
        }

        //TimerVenoksis

        private void timerVenoksis_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sVenoksis;
            label2Venoksis.Text = (MyGlobalVars.sVenoksis / 60).ToString() + ":" + (MyGlobalVars.sVenoksis % 60 >= 10 ? (object)(MyGlobalVars.sVenoksis % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sVenoksis % 60)));
            if (label2Venoksis.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Веноксис", ToolTipIcon.Info);
            if (!(label2Venoksis.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Веноксис", ToolTipIcon.Info);
            timerVenoksis.Stop();
            label2Venoksis.Text = "";
            trackBarVenoksis.Value = trackBarVenoksis.Maximum;
            label1Venoksis.Text = String.Format("Текущее значение: {0}", trackBarVenoksis.Value);

            label1Venoksis.Visible = true;
            label2Venoksis.Visible = false;

            trackBarVenoksis.Visible = true;
            timerVenoksis.Enabled = false;
        }

        //TimerMandokir

        private void timerMandokir_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sMandokir;
            label2Mandokir.Text = (MyGlobalVars.sMandokir / 60).ToString() + ":" + (MyGlobalVars.sMandokir % 60 >= 10 ? (object)(MyGlobalVars.sMandokir % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sMandokir % 60)));
            if (label2Mandokir.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Мандокир", ToolTipIcon.Info);
            if (!(label2Mandokir.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Мандокир", ToolTipIcon.Info);
            timerMandokir.Stop();
            label2Mandokir.Text = "";
            trackBarMandokir.Value = trackBarMandokir.Maximum;
            label1Mandokir.Text = String.Format("Текущее значение: {0}", trackBarMandokir.Value);

            label1Mandokir.Visible = true;
            label2Mandokir.Visible = false;

            trackBarMandokir.Visible = true;
            timerMandokir.Enabled = false;
        }

        //TimerZanzil

        private void timerZanzil_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sZanzil;
            label2Zanzil.Text = (MyGlobalVars.sZanzil / 60).ToString() + ":" + (MyGlobalVars.sZanzil % 60 >= 10 ? (object)(MyGlobalVars.sZanzil % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sZanzil % 60)));
            if (label2Zanzil.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Занзил", ToolTipIcon.Info);
            if (!(label2Zanzil.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Занзил", ToolTipIcon.Info);
            timerZanzil.Stop();
            label2Zanzil.Text = "";
            trackBarZanzil.Value = trackBarZanzil.Maximum;
            label1Zanzil.Text = String.Format("Текущее значение: {0}", trackBarZanzil.Value);

            label1Zanzil.Visible = true;
            label2Zanzil.Visible = false;

            trackBarZanzil.Visible = true;
            timerZanzil.Enabled = false;
        }

        //TimerXairi

        private void timerXairi_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sXairi;
            label2Xairi.Text = (MyGlobalVars.sXairi / 60).ToString() + ":" + (MyGlobalVars.sXairi % 60 >= 10 ? (object)(MyGlobalVars.sXairi % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sXairi % 60)));
            if (label2Xairi.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Хайрри", ToolTipIcon.Info);
            if (!(label2Xairi.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Хайрри", ToolTipIcon.Info);
            timerXairi.Stop();
            label2Xairi.Text = "";
            trackBarXairi.Value = trackBarXairi.Maximum;
            label1Xairi.Text = String.Format("Текущее значение: {0}", trackBarXairi.Value);

            label1Xairi.Visible = true;
            label2Xairi.Visible = false;

            trackBarXairi.Visible = true;
            timerXairi.Enabled = false;
        }

        //TimerDjindo

        private void timerDjindo_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDjindo;
            label2Djindo.Text = (MyGlobalVars.sDjindo / 60).ToString() + ":" + (MyGlobalVars.sDjindo % 60 >= 10 ? (object)(MyGlobalVars.sDjindo % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDjindo % 60)));
            if (label2Djindo.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Джиндо", ToolTipIcon.Info);
            if (!(label2Djindo.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Джиндо", ToolTipIcon.Info);
            timerDjindo.Stop();
            label2Djindo.Text = "";
            trackBarDjindo.Value = trackBarDjindo.Maximum;
            label1Djindo.Text = String.Format("Текущее значение: {0}", trackBarDjindo.Value);

            label1Djindo.Visible = true;
            label2Djindo.Visible = false;

            trackBarDjindo.Visible = true;
            timerDjindo.Enabled = false;
        }

        //TimerVodjaka
        private void timerVodjaka_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sVodjaka;
            label2Vodjaka.Text = (MyGlobalVars.sVodjaka / 60).ToString() + ":" + (MyGlobalVars.sVodjaka % 60 >= 10 ? (object)(MyGlobalVars.sVodjaka % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sVodjaka % 60)));
            if (label2Vodjaka.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Воджакка", ToolTipIcon.Info);
            if (!(label2Vodjaka.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Воджакка", ToolTipIcon.Info);
            timerVodjaka.Stop();
            label2Vodjaka.Text = "";
            trackBarVodjaka.Value = trackBarVodjaka.Maximum;
            label1Vodjaka.Text = String.Format("Текущее значение: {0}", trackBarVodjaka.Value);

            label1Vodjaka.Visible = true;
            label2Vodjaka.Visible = false;

            trackBarVodjaka.Visible = true;
            timerVodjaka.Enabled = false;
        }

        //GrunStart

        private void buttonGrunStart_Click(object sender, EventArgs e)
        {
            if (trackBarGrun.Value == 0) trackBarGrun.Value = 1;
            this.timerGrun.Interval = 1000;
            MyGlobalVars.sGrun = trackBarGrun.Value * 60;
            if (timerGrun.Enabled)
            {
                timerGrun.Enabled = false;
            }
            else
            {
                timerGrun.Enabled = true;
            }
            label1Grun.Visible = false;
            label2Grun.Visible = true;

            trackBarGrun.Visible = false;
        }

        //GrunStop

        private void buttonGrunStop_Click(object sender, EventArgs e)
        {
            trackBarGrun.Value = trackBarGrun.Maximum;
            label1Grun.Text = String.Format("Текущее значение: {0}", trackBarGrun.Value);
            label2Grun.Text = "";
            label1Grun.Visible = true;
            label2Grun.Visible = false;
            trackBarGrun.Visible = true;
            timerGrun.Enabled = false;
        }

        //VarotenStart

        private void buttonVarotenStart_Click(object sender, EventArgs e)
        {
            if (trackBarVaroten.Value == 0) trackBarVaroten.Value = 1;
            this.timerVaroten.Interval = 1000;
            MyGlobalVars.sVaroten = trackBarVaroten.Value * 60;
            if (timerVaroten.Enabled)
            {
                timerVaroten.Enabled = false;
            }
            else
            {
                timerVaroten.Enabled = true;
            }
            label1Varoten.Visible = false;
            label2Varoten.Visible = true;

            trackBarVaroten.Visible = false;
        }

        //VarotenStop

        private void buttonVarotenStop_Click(object sender, EventArgs e)
        {
            trackBarVaroten.Value = trackBarVaroten.Maximum;
            label1Varoten.Text = String.Format("Текущее значение: {0}", trackBarVaroten.Value);
            label2Varoten.Text = "";
            label1Varoten.Visible = true;
            label2Varoten.Visible = false;
            trackBarVaroten.Visible = true;
            timerVaroten.Enabled = false;
        }

        //PerotarnStart

        private void buttonPerotarnStart_Click(object sender, EventArgs e)
        {
            if (trackBarPerotarn.Value == 0) trackBarPerotarn.Value = 1;
            this.timerPerotarn.Interval = 1000;
            MyGlobalVars.sPerotarn = trackBarPerotarn.Value * 60;
            if (timerPerotarn.Enabled)
            {
                timerPerotarn.Enabled = false;
            }
            else
            {
                timerPerotarn.Enabled = true;
            }
            label1Perotarn.Visible = false;
            label2Perotarn.Visible = true;

            trackBarPerotarn.Visible = false;
        }

        //PerotarnStop

        private void buttonPerotarnStop_Click(object sender, EventArgs e)
        {
            trackBarPerotarn.Value = trackBarPerotarn.Maximum;
            label1Perotarn.Text = String.Format("Текущее значение: {0}", trackBarPerotarn.Value);
            label2Perotarn.Text = "";
            label1Perotarn.Visible = true;
            label2Perotarn.Visible = false;
            trackBarPerotarn.Visible = true;
            timerPerotarn.Enabled = false;
        }

        //RomogStart

        private void buttonRomogStart_Click(object sender, EventArgs e)
        {
            if (trackBarRomog.Value == 0) trackBarRomog.Value = 1;
            this.timerRomog.Interval = 1000;
            MyGlobalVars.sRomog = trackBarRomog.Value * 60;
            if (timerRomog.Enabled)
            {
                timerRomog.Enabled = false;
            }
            else
            {
                timerRomog.Enabled = true;
            }
            label1Romog.Visible = false;
            label2Romog.Visible = true;

            trackBarRomog.Visible = false;
        }

        //RomogStop

        private void buttonRomogStop_Click(object sender, EventArgs e)
        {
            trackBarRomog.Value = trackBarRomog.Maximum;
            label1Romog.Text = String.Format("Текущее значение: {0}", trackBarRomog.Value);
            label2Romog.Text = "";
            label1Romog.Visible = true;
            label2Romog.Visible = false;
            trackBarRomog.Visible = true;
            timerRomog.Enabled = false;
        }

        //VolrakStart

        private void buttonVolrakStart_Click(object sender, EventArgs e)
        {
            if (trackBarVolrak.Value == 0) trackBarVolrak.Value = 1;
            this.timerVolrak.Interval = 1000;
            MyGlobalVars.sVolrak = trackBarVolrak.Value * 60;
            if (timerVolrak.Enabled)
            {
                timerVolrak.Enabled = false;
            }
            else
            {
                timerVolrak.Enabled = true;
            }
            label1Volrak.Visible = false;
            label2Volrak.Visible = true;

            trackBarVolrak.Visible = false;
        }

        //VolrakStop

        private void buttonVolrakStop_Click(object sender, EventArgs e)
        {
            trackBarVolrak.Value = trackBarVolrak.Maximum;
            label1Volrak.Text = String.Format("Текущее значение: {0}", trackBarVolrak.Value);
            label2Volrak.Text = "";
            label1Volrak.Visible = true;
            label2Volrak.Visible = false;
            trackBarVolrak.Visible = true;
            timerVolrak.Enabled = false;
        }

        //AzsharaStart

        private void buttonAzsharaStart_Click(object sender, EventArgs e)
        {
            if (trackBarAzshara.Value == 0) trackBarAzshara.Value = 1;
            this.timerAzshara.Interval = 1000;
            MyGlobalVars.sAzshara = trackBarAzshara.Value * 60;
            if (timerAzshara.Enabled)
            {
                timerAzshara.Enabled = false;
            }
            else
            {
                timerAzshara.Enabled = true;
            }
            label1Azshara.Visible = false;
            label2Azshara.Visible = true;

            trackBarAzshara.Visible = false;
        }

        //AzsharaStop

        private void buttonAzsharaStop_Click(object sender, EventArgs e)
        {
            trackBarAzshara.Value = trackBarAzshara.Maximum;
            label1Azshara.Text = String.Format("Текущее значение: {0}", trackBarAzshara.Value);
            label2Azshara.Text = "";
            label1Azshara.Visible = true;
            label2Azshara.Visible = false;
            trackBarAzshara.Visible = true;
            timerAzshara.Enabled = false;
        }

        //GlashataiStart

        private void buttonGlashataiStart_Click(object sender, EventArgs e)
        {
            if (trackBarGlashatai.Value == 0) trackBarGlashatai.Value = 1;
            this.timerGlashatai.Interval = 1000;
            MyGlobalVars.sGlashatai = trackBarGlashatai.Value * 60;
            if (timerGlashatai.Enabled)
            {
                timerGlashatai.Enabled = false;
            }
            else
            {
                timerGlashatai.Enabled = true;
            }
            label1Glashatai.Visible = false;
            label2Glashatai.Visible = true;

            trackBarGlashatai.Visible = false;
        }

        //GlashataiStop

        private void buttonGlashataiStop_Click(object sender, EventArgs e)
        {
            trackBarGlashatai.Value = trackBarGlashatai.Maximum;
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);
            label2Glashatai.Text = "";
            label1Glashatai.Visible = true;
            label2Glashatai.Visible = false;
            trackBarGlashatai.Visible = true;
            timerGlashatai.Enabled = false;
        }

        //KarshStart

        private void buttonKarshStart_Click(object sender, EventArgs e)
        {
            if (trackBarKarsh.Value == 0) trackBarKarsh.Value = 1;
            this.timerKarsh.Interval = 1000;
            MyGlobalVars.sKarsh = trackBarKarsh.Value * 60;
            if (timerKarsh.Enabled)
            {
                timerKarsh.Enabled = false;
            }
            else
            {
                timerKarsh.Enabled = true;
            }
            label1Karsh.Visible = false;
            label2Karsh.Visible = true;

            trackBarKarsh.Visible = false;
        }

        //KarshStart

        private void buttonKarshStop_Click(object sender, EventArgs e)
        {
            trackBarKarsh.Value = trackBarKarsh.Maximum;
            label1Karsh.Text = String.Format("Текущее значение: {0}", trackBarKarsh.Value);
            label2Karsh.Text = "";
            label1Karsh.Visible = true;
            label2Karsh.Visible = false;
            trackBarKarsh.Visible = true;
            timerKarsh.Enabled = false;
        }

        //TimerGrun

        private void timerGrun_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGrun;
            label2Grun.Text = (MyGlobalVars.sGrun / 60).ToString() + ":" + (MyGlobalVars.sGrun % 60 >= 10 ? (object)(MyGlobalVars.sGrun % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGrun % 60)));
            if (label2Grun.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Грун", ToolTipIcon.Info);
            if (!(label2Grun.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Грун", ToolTipIcon.Info);
            timerGrun.Stop();
            label2Grun.Text = "";
            trackBarGrun.Value = trackBarGrun.Maximum;
            label1Grun.Text = String.Format("Текущее значение: {0}", trackBarGrun.Value);

            label1Grun.Visible = true;
            label2Grun.Visible = false;

            trackBarGrun.Visible = true;
            timerGrun.Enabled = false;
        }

        //TimerVaroten

        private void timerVaroten_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sVaroten;
            label2Varoten.Text = (MyGlobalVars.sVaroten / 60).ToString() + ":" + (MyGlobalVars.sVaroten % 60 >= 10 ? (object)(MyGlobalVars.sVaroten % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sVaroten % 60)));
            if (label2Varoten.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Варотен", ToolTipIcon.Info);
            if (!(label2Varoten.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Варотен", ToolTipIcon.Info);
            timerVaroten.Stop();
            label2Varoten.Text = "";
            trackBarVaroten.Value = trackBarVaroten.Maximum;
            label1Varoten.Text = String.Format("Текущее значение: {0}", trackBarVaroten.Value);

            label1Varoten.Visible = true;
            label2Varoten.Visible = false;

            trackBarVaroten.Visible = true;
            timerVaroten.Enabled = false;
        }

        //TimerPerotarn

        private void timerPerotarn_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sPerotarn;
            label2Perotarn.Text = (MyGlobalVars.sPerotarn / 60).ToString() + ":" + (MyGlobalVars.sPerotarn % 60 >= 10 ? (object)(MyGlobalVars.sPerotarn % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sPerotarn % 60)));
            if (label2Perotarn.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Перотарн", ToolTipIcon.Info);
            if (!(label2Perotarn.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Перотарн", ToolTipIcon.Info);
            timerPerotarn.Stop();
            label2Perotarn.Text = "";
            trackBarPerotarn.Value = trackBarPerotarn.Maximum;
            label1Perotarn.Text = String.Format("Текущее значение: {0}", trackBarPerotarn.Value);

            label1Perotarn.Visible = true;
            label2Perotarn.Visible = false;

            trackBarPerotarn.Visible = true;
            timerPerotarn.Enabled = false;
        }

        //TimerRomog

        private void timerRomog_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sRomog;
            label2Romog.Text = (MyGlobalVars.sRomog / 60).ToString() + ":" + (MyGlobalVars.sRomog % 60 >= 10 ? (object)(MyGlobalVars.sRomog % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sRomog % 60)));
            if (label2Romog.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Ромогг", ToolTipIcon.Info);
            if (!(label2Romog.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Ромогг", ToolTipIcon.Info);
            timerRomog.Stop();
            label2Romog.Text = "";
            trackBarRomog.Value = trackBarRomog.Maximum;
            label1Romog.Text = String.Format("Текущее значение: {0}", trackBarRomog.Value);

            label1Romog.Visible = true;
            label2Romog.Visible = false;

            trackBarRomog.Visible = true;
            timerRomog.Enabled = false;
        }

        //TimerVolrak

        private void timerVolrak_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sVolrak;
            label2Volrak.Text = (MyGlobalVars.sVolrak / 60).ToString() + ":" + (MyGlobalVars.sVolrak % 60 >= 10 ? (object)(MyGlobalVars.sVolrak % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sVolrak % 60)));
            if (label2Volrak.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Волрак", ToolTipIcon.Info);
            if (!(label2Volrak.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Волрак", ToolTipIcon.Info);
            timerVolrak.Stop();
            label2Volrak.Text = "";
            trackBarVolrak.Value = trackBarVolrak.Maximum;
            label1Volrak.Text = String.Format("Текущее значение: {0}", trackBarVolrak.Value);

            label1Volrak.Visible = true;
            label2Volrak.Visible = false;

            trackBarVolrak.Visible = true;
            timerVolrak.Enabled = false;
        }

        //TimerAzshara

        private void timerAzshara_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sAzshara;
            label2Azshara.Text = (MyGlobalVars.sAzshara / 60).ToString() + ":" + (MyGlobalVars.sAzshara % 60 >= 10 ? (object)(MyGlobalVars.sAzshara % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sAzshara % 60)));
            if (label2Azshara.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Азшара", ToolTipIcon.Info);
            if (!(label2Azshara.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Азшара", ToolTipIcon.Info);
            timerAzshara.Stop();
            label2Azshara.Text = "";
            trackBarAzshara.Value = trackBarAzshara.Maximum;
            label1Azshara.Text = String.Format("Текущее значение: {0}", trackBarAzshara.Value);

            label1Azshara.Visible = true;
            label2Azshara.Visible = false;

            trackBarAzshara.Visible = true;
            timerAzshara.Enabled = false;
        }

        //TimerGlashatai

        private void timerGlashatai_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGlashatai;
            label2Glashatai.Text = (MyGlobalVars.sGlashatai / 60).ToString() + ":" + (MyGlobalVars.sGlashatai % 60 >= 10 ? (object)(MyGlobalVars.sGlashatai % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGlashatai % 60)));
            if (label2Glashatai.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Глашатай", ToolTipIcon.Info);
            if (!(label2Glashatai.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Глашатай", ToolTipIcon.Info);
            timerGlashatai.Stop();
            label2Glashatai.Text = "";
            trackBarGlashatai.Value = trackBarGlashatai.Maximum;
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);

            label1Glashatai.Visible = true;
            label2Glashatai.Visible = false;

            trackBarGlashatai.Visible = true;
            timerGlashatai.Enabled = false;
        }

        //TimerKarsh

        private void timerKarsh_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKarsh;
            label2Karsh.Text = (MyGlobalVars.sKarsh / 60).ToString() + ":" + (MyGlobalVars.sKarsh % 60 >= 10 ? (object)(MyGlobalVars.sKarsh % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKarsh % 60)));
            if (label2Karsh.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Карш", ToolTipIcon.Info);
            if (!(label2Karsh.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Карш", ToolTipIcon.Info);
            timerKarsh.Stop();
            label2Karsh.Text = "";
            trackBarKarsh.Value = trackBarKarsh.Maximum;
            label1Karsh.Text = String.Format("Текущее значение: {0}", trackBarKarsh.Value);

            label1Karsh.Visible = true;
            label2Karsh.Visible = false;

            trackBarKarsh.Visible = true;
            timerKarsh.Enabled = false;
        }

        //ArkurionStart

        private void buttonArkurionStart_Click(object sender, EventArgs e)
        {
            if (trackBarArkurion.Value == 0) trackBarArkurion.Value = 1;
            this.timerArkurion.Interval = 1000;
            MyGlobalVars.sArkurion = trackBarArkurion.Value * 60;
            if (timerArkurion.Enabled)
            {
                timerArkurion.Enabled = false;
            }
            else
            {
                timerArkurion.Enabled = true;
            }
            label1Arkurion.Visible = false;
            label2Arkurion.Visible = true;

            trackBarArkurion.Visible = false;
        }

        //ArkurionStop

        private void buttonArkurionStop_Click(object sender, EventArgs e)
        {
            trackBarArkurion.Value = trackBarArkurion.Maximum;
            label1Arkurion.Text = String.Format("Текущее значение: {0}", trackBarArkurion.Value);
            label2Arkurion.Text = "";
            label1Arkurion.Visible = true;
            label2Arkurion.Visible = false;
            trackBarArkurion.Visible = true;
            timerArkurion.Enabled = false;
        }

        //TimerArkurion
        
        private void timerArkurion_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sArkurion;
            label2Arkurion.Text = (MyGlobalVars.sArkurion / 60).ToString() + ":" + (MyGlobalVars.sArkurion % 60 >= 10 ? (object)(MyGlobalVars.sArkurion % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sArkurion % 60)));
            if (label2Arkurion.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Аркурион", ToolTipIcon.Info);
            if (!(label2Arkurion.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Аркурион", ToolTipIcon.Info);
            timerArkurion.Stop();
            label2Arkurion.Text = "";
            trackBarArkurion.Value = trackBarArkurion.Maximum;
            label1Arkurion.Text = String.Format("Текущее значение: {0}", trackBarArkurion.Value);

            label1Arkurion.Visible = true;
            label2Arkurion.Visible = false;

            trackBarArkurion.Visible = true;
            timerArkurion.Enabled = false;
        }

        //HusanStart

        private void buttonHusanStart_Click(object sender, EventArgs e)
        {
            if (trackBarHusan.Value == 0) trackBarHusan.Value = 1;
            this.timerHusan.Interval = 1000;
            MyGlobalVars.sHusan = trackBarHusan.Value * 60;
            if (timerHusan.Enabled)
            {
                timerHusan.Enabled = false;
            }
            else
            {
                timerHusan.Enabled = true;
            }
            label1Husan.Visible = false;
            label2Husan.Visible = true;

            trackBarHusan.Visible = false;
        }

        //HusanStop

        private void buttonHusanStop_Click(object sender, EventArgs e)
        {
            trackBarHusan.Value = trackBarHusan.Maximum;
            label1Husan.Text = String.Format("Текущее значение: {0}", trackBarHusan.Value);
            label2Husan.Text = "";
            label1Husan.Visible = true;
            label2Husan.Visible = false;
            trackBarHusan.Visible = true;
            timerHusan.Enabled = false;
        }

        //GiltonStart

        private void buttonGiltonStart_Click(object sender, EventArgs e)
        {
            if (trackBarGilton.Value == 0) trackBarGilton.Value = 1;
            this.timerGilton.Interval = 1000;
            MyGlobalVars.sGilton = trackBarGilton.Value * 60;
            if (timerGilton.Enabled)
            {
                timerGilton.Enabled = false;
            }
            else
            {
                timerGilton.Enabled = true;
            }
            label1Gilton.Visible = false;
            label2Gilton.Visible = true;

            trackBarGilton.Visible = false;
        }

        //GiltonStop

        private void buttonGiltonStop_Click(object sender, EventArgs e)
        {
            trackBarGilton.Value = trackBarGilton.Maximum;
            label1Gilton.Text = String.Format("Текущее значение: {0}", trackBarGilton.Value);
            label2Gilton.Text = "";
            label1Gilton.Visible = true;
            label2Gilton.Visible = false;
            trackBarGilton.Visible = true;
            timerGilton.Enabled = false;
        }

        //AlakirStart

        private void buttonAlakirStart_Click(object sender, EventArgs e)
        {
            if (trackBarAlakir.Value == 0) trackBarAlakir.Value = 1;
            this.timerAlakir.Interval = 1000;
            MyGlobalVars.sAlakir = trackBarAlakir.Value * 60;
            if (timerAlakir.Enabled)
            {
                timerAlakir.Enabled = false;
            }
            else
            {
                timerAlakir.Enabled = true;
            }
            label1Alakir.Visible = false;
            label2Alakir.Visible = true;

            trackBarAlakir.Visible = false;
        }

        //AlakirStop

        private void buttonAlakirStop_Click(object sender, EventArgs e)
        {
            trackBarAlakir.Value = trackBarAlakir.Maximum;
            label1Alakir.Text = String.Format("Текущее значение: {0}", trackBarAlakir.Value);
            label2Alakir.Text = "";
            label1Alakir.Visible = true;
            label2Alakir.Visible = false;
            trackBarAlakir.Visible = true;
            timerAlakir.Enabled = false;
        }

        //SeteshStart

        private void buttonSeteshStart_Click(object sender, EventArgs e)
        {
            if (trackBarSetesh.Value == 0) trackBarSetesh.Value = 1;
            this.timerSetesh.Interval = 1000;
            MyGlobalVars.sSetesh = trackBarSetesh.Value * 60;
            if (timerSetesh.Enabled)
            {
                timerSetesh.Enabled = false;
            }
            else
            {
                timerSetesh.Enabled = true;
            }
            label1Setesh.Visible = false;
            label2Setesh.Visible = true;

            trackBarSetesh.Visible = false;
        }

        //SeteshStop

        private void buttonSeteshStop_Click(object sender, EventArgs e)
        {
            trackBarSetesh.Value = trackBarSetesh.Maximum;
            label1Setesh.Text = String.Format("Текущее значение: {0}", trackBarSetesh.Value);
            label2Setesh.Text = "";
            label1Setesh.Visible = true;
            label2Setesh.Visible = false;
            trackBarSetesh.Visible = true;
            timerSetesh.Enabled = false;
        }

        //KaktuarStart

        private void buttonKaktuarStart_Click(object sender, EventArgs e)
        {
            if (trackBarKaktuar.Value == 0) trackBarKaktuar.Value = 1;
            this.timerKaktuar.Interval = 1000;
            MyGlobalVars.sKaktuar = trackBarKaktuar.Value * 60;
            if (timerKaktuar.Enabled)
            {
                timerKaktuar.Enabled = false;
            }
            else
            {
                timerKaktuar.Enabled = true;
            }
            label1Kaktuar.Visible = false;
            label2Kaktuar.Visible = true;

            trackBarKaktuar.Visible = false;
        }

        //KaktuarStop

        private void buttonKaktuarStop_Click(object sender, EventArgs e)
        {
            trackBarKaktuar.Value = trackBarKaktuar.Maximum;
            label1Kaktuar.Text = String.Format("Текущее значение: {0}", trackBarKaktuar.Value);
            label2Kaktuar.Text = "";
            label1Kaktuar.Visible = true;
            label2Kaktuar.Visible = false;
            trackBarKaktuar.Visible = true;
            timerKaktuar.Enabled = false;
        }

        //SerdceStart

        private void buttonSerdceStart_Click(object sender, EventArgs e)
        {
            if (trackBarSerdce.Value == 0) trackBarSerdce.Value = 1;
            this.timerSerdce.Interval = 1000;
            MyGlobalVars.sSerdce = trackBarSerdce.Value * 60;
            if (timerSerdce.Enabled)
            {
                timerSerdce.Enabled = false;
            }
            else
            {
                timerSerdce.Enabled = true;
            }
            label1Serdce.Visible = false;
            label2Serdce.Visible = true;

            trackBarSerdce.Visible = false;
        }

        //SerdceStop

        private void buttonSerdceStop_Click(object sender, EventArgs e)
        {
            trackBarSerdce.Value = trackBarSerdce.Maximum;
            label1Serdce.Text = String.Format("Текущее значение: {0}", trackBarSerdce.Value);
            label2Serdce.Text = "";
            label1Serdce.Visible = true;
            label2Serdce.Visible = false;
            trackBarSerdce.Visible = true;
            timerSerdce.Enabled = false;
        }
        //TimerHusan

        private void timerHusan_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sHusan;
            label2Husan.Text = (MyGlobalVars.sHusan / 60).ToString() + ":" + (MyGlobalVars.sHusan % 60 >= 10 ? (object)(MyGlobalVars.sHusan % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sHusan % 60)));
            if (label2Husan.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Хусан", ToolTipIcon.Info);
            if (!(label2Husan.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Хусан", ToolTipIcon.Info);
            timerHusan.Stop();
            label2Husan.Text = "";
            trackBarHusan.Value = trackBarHusan.Maximum;
            label1Husan.Text = String.Format("Текущее значение: {0}", trackBarHusan.Value);

            label1Husan.Visible = true;
            label2Husan.Visible = false;

            trackBarHusan.Visible = true;
            timerHusan.Enabled = false;
        }

        //TimerGilton

        private void timerGilton_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGilton;
            label2Gilton.Text = (MyGlobalVars.sGilton / 60).ToString() + ":" + (MyGlobalVars.sGilton % 60 >= 10 ? (object)(MyGlobalVars.sGilton % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGilton % 60)));
            if (label2Gilton.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Гилтон", ToolTipIcon.Info);
            if (!(label2Gilton.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Гилтон", ToolTipIcon.Info);
            timerGilton.Stop();
            label2Gilton.Text = "";
            trackBarGilton.Value = trackBarGilton.Maximum;
            label1Gilton.Text = String.Format("Текущее значение: {0}", trackBarGilton.Value);

            label1Gilton.Visible = true;
            label2Gilton.Visible = false;

            trackBarGilton.Visible = true;
            timerGilton.Enabled = false;
        }

        //TimerAlakir

        private void timerAlakir_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sAlakir;
            label2Alakir.Text = (MyGlobalVars.sAlakir / 60).ToString() + ":" + (MyGlobalVars.sAlakir % 60 >= 10 ? (object)(MyGlobalVars.sAlakir % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sAlakir % 60)));
            if (label2Alakir.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Алакир", ToolTipIcon.Info);
            if (!(label2Alakir.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Алакир", ToolTipIcon.Info);
            timerAlakir.Stop();
            label2Alakir.Text = "";
            trackBarAlakir.Value = trackBarAlakir.Maximum;
            label1Alakir.Text = String.Format("Текущее значение: {0}", trackBarAlakir.Value);

            label1Alakir.Visible = true;
            label2Alakir.Visible = false;

            trackBarAlakir.Visible = true;
            timerAlakir.Enabled = false;
        }

        //TimerSetesh

        private void timerSetesh_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSetesh;
            label2Setesh.Text = (MyGlobalVars.sSetesh / 60).ToString() + ":" + (MyGlobalVars.sSetesh % 60 >= 10 ? (object)(MyGlobalVars.sSetesh % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSetesh % 60)));
            if (label2Setesh.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Сетеш", ToolTipIcon.Info);
            if (!(label2Setesh.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Сетеш", ToolTipIcon.Info);
            timerSetesh.Stop();
            label2Setesh.Text = "";
            trackBarSetesh.Value = trackBarSetesh.Maximum;
            label1Setesh.Text = String.Format("Текущее значение: {0}", trackBarSetesh.Value);

            label1Setesh.Visible = true;
            label2Setesh.Visible = false;

            trackBarSetesh.Visible = true;
            timerSetesh.Enabled = false;
        }

        //TimerKaktuar

        private void timerKaktuar_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKaktuar;
            label2Kaktuar.Text = (MyGlobalVars.sKaktuar / 60).ToString() + ":" + (MyGlobalVars.sKaktuar % 60 >= 10 ? (object)(MyGlobalVars.sKaktuar % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKaktuar % 60)));
            if (label2Kaktuar.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Аммунаэ", ToolTipIcon.Info);
            if (!(label2Kaktuar.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Аммунаэ", ToolTipIcon.Info);
            timerKaktuar.Stop();
            label2Kaktuar.Text = "";
            trackBarKaktuar.Value = trackBarKaktuar.Maximum;
            label1Kaktuar.Text = String.Format("Текущее значение: {0}", trackBarKaktuar.Value);

            label1Kaktuar.Visible = true;
            label2Kaktuar.Visible = false;

            trackBarKaktuar.Visible = true;
            timerKaktuar.Enabled = false;
        }


        //TimerSerdce
        private void timerSerdce_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSerdce;
            label2Serdce.Text = (MyGlobalVars.sSerdce / 60).ToString() + ":" + (MyGlobalVars.sSerdce % 60 >= 10 ? (object)(MyGlobalVars.sSerdce % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSerdce % 60)));
            if (label2Serdce.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Сердце магии", ToolTipIcon.Info);
            if (!(label2Serdce.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Сердце магии", ToolTipIcon.Info);
            timerSerdce.Stop();
            label2Serdce.Text = "";
            trackBarSerdce.Value = trackBarSerdce.Maximum;
            label1Serdce.Text = String.Format("Текущее значение: {0}", trackBarSerdce.Value);

            label1Serdce.Visible = true;
            label2Serdce.Visible = false;

            trackBarSerdce.Visible = true;
            timerSerdce.Enabled = false;
        }

        //TenelovStart

        private void buttonTenelovStart_Click(object sender, EventArgs e)
        {
            if (trackBarTenelov.Value == 0) trackBarTenelov.Value = 1;
            this.timerTenelov.Interval = 1000;
            MyGlobalVars.sTenelov = trackBarTenelov.Value * 60;
            if (timerTenelov.Enabled)
            {
                timerTenelov.Enabled = false;
            }
            else
            {
                timerTenelov.Enabled = true;
            }
            label1Tenelov.Visible = false;
            label2Tenelov.Visible = true;

            trackBarTenelov.Visible = false;
        }

        //TenelovStop

        private void buttonTenelovStop_Click(object sender, EventArgs e)
        {
            trackBarTenelov.Value = trackBarTenelov.Maximum;
            label1Tenelov.Text = String.Format("Текущее значение: {0}", trackBarTenelov.Value);
            label2Tenelov.Text = "";
            label1Tenelov.Visible = true;
            label2Tenelov.Visible = false;
            trackBarTenelov.Visible = true;
            timerTenelov.Enabled = false;
        }

        //KodoStart

        private void buttonKodoStart_Click(object sender, EventArgs e)
        {
            if (trackBarKodo.Value == 0) trackBarKodo.Value = 1;
            this.timerKodo.Interval = 1000;
            MyGlobalVars.sKodo = trackBarKodo.Value * 60;
            if (timerKodo.Enabled)
            {
                timerKodo.Enabled = false;
            }
            else
            {
                timerKodo.Enabled = true;
            }
            label1Kodo.Visible = false;
            label2Kodo.Visible = true;

            trackBarKodo.Visible = false;
        }

        //KodoStop

        private void buttonKodoStop_Click(object sender, EventArgs e)
        {
            trackBarKodo.Value = trackBarKodo.Maximum;
            label1Kodo.Text = String.Format("Текущее значение: {0}", trackBarKodo.Value);
            label2Kodo.Text = "";
            label1Kodo.Visible = true;
            label2Kodo.Visible = false;
            trackBarKodo.Visible = true;
            timerKodo.Enabled = false;
        }

        //AtroksStart

        private void buttonAtroksStart_Click(object sender, EventArgs e)
        {
            if (trackBarAtroks.Value == 0) trackBarAtroks.Value = 1;
            this.timerAtroks.Interval = 1000;
            MyGlobalVars.sAtroks = trackBarAtroks.Value * 60;
            if (timerAtroks.Enabled)
            {
                timerAtroks.Enabled = false;
            }
            else
            {
                timerAtroks.Enabled = true;
            }
            label1Atroks.Visible = false;
            label2Atroks.Visible = true;

            trackBarAtroks.Visible = false;
        }

        //AtroksStop

        private void buttonAtroksStop_Click(object sender, EventArgs e)
        {
            trackBarAtroks.Value = trackBarAtroks.Maximum;
            label1Atroks.Text = String.Format("Текущее значение: {0}", trackBarAtroks.Value);
            label2Atroks.Text = "";
            label1Atroks.Visible = true;
            label2Atroks.Visible = false;
            trackBarAtroks.Visible = true;
            timerAtroks.Enabled = false;
        }

        //DvenStart

        private void buttonDvenStart_Click(object sender, EventArgs e)
        {
            if (trackBarDven.Value == 0) trackBarDven.Value = 1;
            this.timerDven.Interval = 1000;
            MyGlobalVars.sDven = trackBarDven.Value * 60;
            if (timerDven.Enabled)
            {
                timerDven.Enabled = false;
            }
            else
            {
                timerDven.Enabled = true;
            }
            label1Dven.Visible = false;
            label2Dven.Visible = true;

            trackBarDven.Visible = false;
        }

        //DvenStop

        private void buttonDvenStop_Click(object sender, EventArgs e)
        {
            trackBarDven.Value = trackBarDven.Maximum;
            label1Dven.Text = String.Format("Текущее значение: {0}", trackBarDven.Value);
            label2Dven.Text = "";
            label1Dven.Visible = true;
            label2Dven.Visible = false;
            trackBarDven.Visible = true;
            timerDven.Enabled = false;
        }

        //IlluzionistStart

        private void buttonIlluzionistStart_Click(object sender, EventArgs e)
        {
            if (trackBarIlluzionist.Value == 0) trackBarIlluzionist.Value = 1;
            this.timerIlluzionist.Interval = 1000;
            MyGlobalVars.sIlluzionist = trackBarIlluzionist.Value * 60;
            if (timerIlluzionist.Enabled)
            {
                timerIlluzionist.Enabled = false;
            }
            else
            {
                timerIlluzionist.Enabled = true;
            }
            label1Illuzionist.Visible = false;
            label2Illuzionist.Visible = true;

            trackBarIlluzionist.Visible = false;
        }

        //IlluzionistStop

        private void buttonIlluzionistStop_Click(object sender, EventArgs e)
        {
            trackBarIlluzionist.Value = trackBarIlluzionist.Maximum;
            label1Illuzionist.Text = String.Format("Текущее значение: {0}", trackBarIlluzionist.Value);
            label2Illuzionist.Text = "";
            label1Illuzionist.Visible = true;
            label2Illuzionist.Visible = false;
            trackBarIlluzionist.Visible = true;
            timerIlluzionist.Enabled = false;
        }


        //TimerTenelov

        private void timerTenelov_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sTenelov;
            label2Tenelov.Text = (MyGlobalVars.sTenelov / 60).ToString() + ":" + (MyGlobalVars.sTenelov % 60 >= 10 ? (object)(MyGlobalVars.sTenelov % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sTenelov % 60)));
            if (label2Tenelov.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Тенелов", ToolTipIcon.Info);
            if (!(label2Tenelov.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Тенелов", ToolTipIcon.Info);
            timerTenelov.Stop();
            label2Tenelov.Text = "";
            trackBarTenelov.Value = trackBarTenelov.Maximum;
            label1Tenelov.Text = String.Format("Текущее значение: {0}", trackBarTenelov.Value);

            label1Tenelov.Visible = true;
            label2Tenelov.Visible = false;

            trackBarTenelov.Visible = true;
            timerTenelov.Enabled = false;
        }

        //TimerKodo

        private void timerKodo_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKodo;
            label2Kodo.Text = (MyGlobalVars.sKodo / 60).ToString() + ":" + (MyGlobalVars.sKodo % 60 >= 10 ? (object)(MyGlobalVars.sKodo % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKodo % 60)));
            if (label2Kodo.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Кодо", ToolTipIcon.Info);
            if (!(label2Kodo.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Кодо", ToolTipIcon.Info);
            timerKodo.Stop();
            label2Kodo.Text = "";
            trackBarKodo.Value = trackBarKodo.Maximum;
            label1Kodo.Text = String.Format("Текущее значение: {0}", trackBarKodo.Value);

            label1Kodo.Visible = true;
            label2Kodo.Visible = false;

            trackBarKodo.Visible = true;
            timerKodo.Enabled = false;
        }

        //TimerAtroks

        private void timerAtroks_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sAtroks;
            label2Atroks.Text = (MyGlobalVars.sAtroks / 60).ToString() + ":" + (MyGlobalVars.sAtroks % 60 >= 10 ? (object)(MyGlobalVars.sAtroks % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sAtroks % 60)));
            if (label2Atroks.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Атрокс", ToolTipIcon.Info);
            if (!(label2Atroks.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Атрокс", ToolTipIcon.Info);
            timerAtroks.Stop();
            label2Atroks.Text = "";
            trackBarAtroks.Value = trackBarAtroks.Maximum;
            label1Atroks.Text = String.Format("Текущее значение: {0}", trackBarAtroks.Value);

            label1Atroks.Visible = true;
            label2Atroks.Visible = false;

            trackBarAtroks.Visible = true;
            timerAtroks.Enabled = false;
        }

        //TimerDven

        private void timerDven_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDven;
            label2Dven.Text = (MyGlobalVars.sDven / 60).ToString() + ":" + (MyGlobalVars.sDven % 60 >= 10 ? (object)(MyGlobalVars.sDven % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDven % 60)));
            if (label2Dven.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Двен", ToolTipIcon.Info);
            if (!(label2Dven.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Двен", ToolTipIcon.Info);
            timerDven.Stop();
            label2Dven.Text = "";
            trackBarDven.Value = trackBarDven.Maximum;
            label1Dven.Text = String.Format("Текущее значение: {0}", trackBarDven.Value);

            label1Dven.Visible = true;
            label2Dven.Visible = false;

            trackBarDven.Visible = true;
            timerDven.Enabled = false;
        }

        //TimerIlluzionist

        private void timerIlluzionist_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sIlluzionist;
            label2Illuzionist.Text = (MyGlobalVars.sIlluzionist / 60).ToString() + ":" + (MyGlobalVars.sIlluzionist % 60 >= 10 ? (object)(MyGlobalVars.sIlluzionist % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sIlluzionist % 60)));
            if (label2Illuzionist.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Иллюзионист", ToolTipIcon.Info);
            if (!(label2Illuzionist.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Иллюзионист", ToolTipIcon.Info);
            timerIlluzionist.Stop();
            label2Illuzionist.Text = "";
            trackBarIlluzionist.Value = trackBarIlluzionist.Maximum;
            label1Illuzionist.Text = String.Format("Текущее значение: {0}", trackBarIlluzionist.Value);

            label1Illuzionist.Visible = true;
            label2Illuzionist.Visible = false;

            trackBarIlluzionist.Visible = true;
            timerIlluzionist.Enabled = false;
        }

        //SolarianStart

        private void buttonSolarianStart_Click(object sender, EventArgs e)
        {
            if (trackBarSolarian.Value == 0) trackBarSolarian.Value = 1;
            this.timerSolarian.Interval = 1000;
            MyGlobalVars.sSolarian = trackBarSolarian.Value * 60;
            if (timerSolarian.Enabled)
            {
                timerSolarian.Enabled = false;
            }
            else
            {
                timerSolarian.Enabled = true;
            }
            label1Solarian.Visible = false;
            label2Solarian.Visible = true;

            trackBarSolarian.Visible = false;
        }

        //SolarianStop

        private void buttonSolarianStop_Click(object sender, EventArgs e)
        {
            trackBarSolarian.Value = trackBarSolarian.Maximum;
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);
            label2Solarian.Text = "";
            label1Solarian.Visible = true;
            label2Solarian.Visible = false;
            trackBarSolarian.Visible = true;
            timerSolarian.Enabled = false;
        }

        //KeltasStart

        private void buttonKeltasStart_Click(object sender, EventArgs e)
        {
            if (trackBarKeltas.Value == 0) trackBarKeltas.Value = 1;
            this.timerKeltas.Interval = 1000;
            MyGlobalVars.sKeltas = trackBarKeltas.Value * 60;
            if (timerKeltas.Enabled)
            {
                timerKeltas.Enabled = false;
            }
            else
            {
                timerKeltas.Enabled = true;
            }
            label1Keltas.Visible = false;
            label2Keltas.Visible = true;

            trackBarKeltas.Visible = false;
        }

        //KeltasStop

        private void buttonKeltasStop_Click(object sender, EventArgs e)
        {
            trackBarKeltas.Value = trackBarKeltas.Maximum;
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);
            label2Keltas.Text = "";
            label1Keltas.Visible = true;
            label2Keltas.Visible = false;
            trackBarKeltas.Visible = true;
            timerKeltas.Enabled = false;
        }

        //TimerSolarian

        private void timerSolarian_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSolarian;
            label2Solarian.Text = (MyGlobalVars.sSolarian / 60).ToString() + ":" + (MyGlobalVars.sSolarian % 60 >= 10 ? (object)(MyGlobalVars.sSolarian % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSolarian % 60)));
            if (label2Solarian.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Солариан", ToolTipIcon.Info);
            if (!(label2Solarian.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Солариан", ToolTipIcon.Info);
            timerSolarian.Stop();
            label2Solarian.Text = "";
            trackBarSolarian.Value = trackBarSolarian.Maximum;
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);

            label1Solarian.Visible = true;
            label2Solarian.Visible = false;

            trackBarSolarian.Visible = true;
            timerSolarian.Enabled = false;
        }

        //TimerKeltas

        private void timerKeltas_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKeltas;
            label2Keltas.Text = (MyGlobalVars.sKeltas / 60).ToString() + ":" + (MyGlobalVars.sKeltas % 60 >= 10 ? (object)(MyGlobalVars.sKeltas % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKeltas % 60)));
            if (label2Keltas.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Кельтас", ToolTipIcon.Info);
            if (!(label2Keltas.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Кельтас", ToolTipIcon.Info);
            timerKeltas.Stop();
            label2Keltas.Text = "";
            trackBarKeltas.Value = trackBarKeltas.Maximum;
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);

            label1Keltas.Visible = true;
            label2Keltas.Visible = false;

            trackBarKeltas.Visible = true;
            timerKeltas.Enabled = false;
        }

        //FenStart

        private void buttonFenStart_Click(object sender, EventArgs e)
        {
            if (trackBarFen.Value == 0) trackBarFen.Value = 1;
            this.timerFen.Interval = 1000;
            MyGlobalVars.sFen = trackBarFen.Value * 60;
            if (timerFen.Enabled)
            {
                timerFen.Enabled = false;
            }
            else
            {
                timerFen.Enabled = true;
            }
            label1Fen.Visible = false;
            label2Fen.Visible = true;

            trackBarFen.Visible = false;
        }

        //FenStop
        
        private void buttonFenStop_Click(object sender, EventArgs e)
        {
            trackBarFen.Value = trackBarFen.Maximum;
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);
            label2Fen.Text = "";
            label1Fen.Visible = true;
            label2Fen.Visible = false;
            trackBarFen.Visible = true;
            timerFen.Enabled = false;
        }

        //EranikusStart

        private void buttonEranikusStart_Click(object sender, EventArgs e)
        {
            if (trackBarEranikus.Value == 0) trackBarEranikus.Value = 1;
            this.timerEranikus.Interval = 1000;
            MyGlobalVars.sEranikus = trackBarEranikus.Value * 60;
            if (timerEranikus.Enabled)
            {
                timerEranikus.Enabled = false;
            }
            else
            {
                timerEranikus.Enabled = true;
            }
            label1Eranikus.Visible = false;
            label2Eranikus.Visible = true;

            trackBarEranikus.Visible = false;
        }

        //EranikusStop

        private void buttonEranikusStop_Click(object sender, EventArgs e)
        {
            trackBarEranikus.Value = trackBarEranikus.Maximum;
            label1Eranikus.Text = String.Format("Текущее значение: {0}", trackBarEranikus.Value);
            label2Eranikus.Text = "";
            label1Eranikus.Visible = true;
            label2Eranikus.Visible = false;
            trackBarEranikus.Visible = true;
            timerEranikus.Enabled = false;
        }

        //NafraStart

        private void buttonNafraStart_Click(object sender, EventArgs e)
        {
            if (trackBarNafra.Value == 0) trackBarNafra.Value = 1;
            this.timerNafra.Interval = 1000;
            MyGlobalVars.sNafra = trackBarNafra.Value * 60;
            if (timerNafra.Enabled)
            {
                timerNafra.Enabled = false;
            }
            else
            {
                timerNafra.Enabled = true;
            }
            label1Nafra.Visible = false;
            label2Nafra.Visible = true;

            trackBarNafra.Visible = false;
        }

        //NafraStop

        private void buttonNafraStop_Click(object sender, EventArgs e)
        {
            trackBarNafra.Value = trackBarNafra.Maximum;
            label1Nafra.Text = String.Format("Текущее значение: {0}", trackBarNafra.Value);
            label2Nafra.Text = "";
            label1Nafra.Visible = true;
            label2Nafra.Visible = false;
            trackBarNafra.Visible = true;
            timerNafra.Enabled = false;
        }

        //TimerFen

        private void timerFen_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sFen;
            label2Fen.Text = (MyGlobalVars.sFen / 60).ToString() + ":" + (MyGlobalVars.sFen % 60 >= 10 ? (object)(MyGlobalVars.sFen % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sFen % 60)));
            if (label2Fen.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Фен", ToolTipIcon.Info);
            if (!(label2Fen.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Фен", ToolTipIcon.Info);
            timerFen.Stop();
            label2Fen.Text = "";
            trackBarFen.Value = trackBarFen.Maximum;
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);

            label1Fen.Visible = true;
            label2Fen.Visible = false;

            trackBarFen.Visible = true;
            timerFen.Enabled = false;
        }

        //TimerEranikus

        private void timerEranikus_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sEranikus;
            label2Eranikus.Text = (MyGlobalVars.sEranikus / 60).ToString() + ":" + (MyGlobalVars.sEranikus % 60 >= 10 ? (object)(MyGlobalVars.sEranikus % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sEranikus % 60)));
            if (label2Eranikus.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Эраникус", ToolTipIcon.Info);
            if (!(label2Eranikus.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Эраникус", ToolTipIcon.Info);
            timerEranikus.Stop();
            label2Eranikus.Text = "";
            trackBarEranikus.Value = trackBarEranikus.Maximum;
            label1Eranikus.Text = String.Format("Текущее значение: {0}", trackBarEranikus.Value);
            
            label1Eranikus.Visible = true;
            label2Eranikus.Visible = false;

            trackBarEranikus.Visible = true;
            timerEranikus.Enabled = false;
        }

        //TimerNafra

        private void timerNafra_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sNafra;
            label2Nafra.Text = (MyGlobalVars.sNafra / 60).ToString() + ":" + (MyGlobalVars.sNafra % 60 >= 10 ? (object)(MyGlobalVars.sNafra % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sNafra % 60)));
            if (label2Nafra.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Нафра", ToolTipIcon.Info);
            if (!(label2Nafra.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Нафра", ToolTipIcon.Info);
            timerNafra.Stop();
            label2Nafra.Text = "";
            trackBarNafra.Value = trackBarNafra.Maximum;
            label1Nafra.Text = String.Format("Текущее значение: {0}", trackBarNafra.Value);

            label1Nafra.Visible = true;
            label2Nafra.Visible = false;

            trackBarNafra.Visible = true;
            timerNafra.Enabled = false;
        }

        //TarilzunStart

        private void buttonTarilzunStart_Click(object sender, EventArgs e)
        {
            if (trackBarTarilzun.Value == 0) trackBarTarilzun.Value = 1;
            this.timerTarilzun.Interval = 1000;
            MyGlobalVars.sTarilzun = trackBarTarilzun.Value * 60;
            if (timerTarilzun.Enabled)
            {
                timerTarilzun.Enabled = false;
            }
            else
            {
                timerTarilzun.Enabled = true;
            }
            label1Tarilzun.Visible = false;
            label2Tarilzun.Visible = true;

            trackBarTarilzun.Visible = false;
        }

        //TarilzunStop

        private void buttonTarilzunStop_Click(object sender, EventArgs e)
        {
            trackBarTarilzun.Value = trackBarTarilzun.Maximum;
            label1Tarilzun.Text = String.Format("Текущее значение: {0}", trackBarTarilzun.Value);
            label2Tarilzun.Text = "";
            label1Tarilzun.Visible = true;
            label2Tarilzun.Visible = false;
            trackBarTarilzun.Visible = true;
            timerTarilzun.Enabled = false;
        }

        //DoanStart

        private void buttonDoanStart_Click(object sender, EventArgs e)
        {
            if (trackBarDoan.Value == 0) trackBarDoan.Value = 1;
            this.timerDoan.Interval = 1000;
            MyGlobalVars.sDoan = trackBarDoan.Value * 60;
            if (timerDoan.Enabled)
            {
                timerDoan.Enabled = false;
            }
            else
            {
                timerDoan.Enabled = true;
            }
            label1Doan.Visible = false;
            label2Doan.Visible = true;

            trackBarDoan.Visible = false;
        }

        //DoanStop

        private void buttonDoanStop_Click(object sender, EventArgs e)
        {
            trackBarDoan.Value = trackBarDoan.Maximum;
            label1Doan.Text = String.Format("Текущее значение: {0}", trackBarDoan.Value);
            label2Doan.Text = "";
            label1Doan.Visible = true;
            label2Doan.Visible = false;
            trackBarDoan.Visible = true;
            timerDoan.Enabled = false;
        }

        //DrobitelStart

        private void buttonDrobitelStart_Click(object sender, EventArgs e)
        {
            if (trackBarDrobitel.Value == 0) trackBarDrobitel.Value = 1;
            this.timerDrobitel.Interval = 1000;
            MyGlobalVars.sDrobitel = trackBarDrobitel.Value * 60;
            if (timerDrobitel.Enabled)
            {
                timerDrobitel.Enabled = false;
            }
            else
            {
                timerDrobitel.Enabled = true;
            }
            label1Drobitel.Visible = false;
            label2Drobitel.Visible = true;

            trackBarDrobitel.Visible = false;
        }

        //DrobitelStop

        private void buttonDrobitelStop_Click(object sender, EventArgs e)
        {
            trackBarDrobitel.Value = trackBarDrobitel.Maximum;
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);
            label2Drobitel.Text = "";
            label1Drobitel.Visible = true;
            label2Drobitel.Visible = false;
            trackBarDrobitel.Visible = true;
            timerDrobitel.Enabled = false;
        }

        //TimerTarilzun

        private void timerTarilzun_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sTarilzun;
            label2Tarilzun.Text = (MyGlobalVars.sTarilzun / 60).ToString() + ":" + (MyGlobalVars.sTarilzun % 60 >= 10 ? (object)(MyGlobalVars.sTarilzun % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sTarilzun % 60)));
            if (label2Tarilzun.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Тарилзун", ToolTipIcon.Info);
            if (!(label2Tarilzun.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Тарилзун", ToolTipIcon.Info);
            timerTarilzun.Stop();
            label2Tarilzun.Text = "";
            trackBarTarilzun.Value = trackBarTarilzun.Maximum;
            label1Tarilzun.Text = String.Format("Текущее значение: {0}", trackBarTarilzun.Value);

            label1Tarilzun.Visible = true;
            label2Tarilzun.Visible = false;

            trackBarTarilzun.Visible = true;
            timerTarilzun.Enabled = false;
        }

        //TimerDoan

        private void timerDoan_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDoan;
            label2Doan.Text = (MyGlobalVars.sDoan / 60).ToString() + ":" + (MyGlobalVars.sDoan % 60 >= 10 ? (object)(MyGlobalVars.sDoan % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDoan % 60)));
            if (label2Doan.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Доанн", ToolTipIcon.Info);
            if (!(label2Doan.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Доанн", ToolTipIcon.Info);
            timerDoan.Stop();
            label2Doan.Text = "";
            trackBarDoan.Value = trackBarDoan.Maximum;
            label1Doan.Text = String.Format("Текущее значение: {0}", trackBarDoan.Value);

            label1Doan.Visible = true;
            label2Doan.Visible = false;

            trackBarDoan.Visible = true;
            timerDoan.Enabled = false;
        }

        //TimerDrobitel

        private void timerDrobitel_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDrobitel;
            label2Drobitel.Text = (MyGlobalVars.sDrobitel / 60).ToString() + ":" + (MyGlobalVars.sDrobitel % 60 >= 10 ? (object)(MyGlobalVars.sDrobitel % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDrobitel % 60)));
            if (label2Drobitel.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Дробитель", ToolTipIcon.Info);
            if (!(label2Drobitel.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Дробитель", ToolTipIcon.Info);
            timerDrobitel.Stop();
            label2Drobitel.Text = "";
            trackBarDrobitel.Value = trackBarDrobitel.Maximum;
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);

            label1Drobitel.Visible = true;
            label2Drobitel.Visible = false;

            trackBarDrobitel.Visible = true;
            timerDrobitel.Enabled = false;
        }

        //Skorpez

        private void buttonSkorpezStart_Click(object sender, EventArgs e)
        {
            if (trackBarSkorpez.Value == 0) trackBarSkorpez.Value = 1;
            this.timerSkorpez.Interval = 1000;
            MyGlobalVars.sSkorpez = trackBarSkorpez.Value * 60;
            if (timerSkorpez.Enabled)
            {
                timerSkorpez.Enabled = false;
            }
            else
            {
                timerSkorpez.Enabled = true;
            }
            label1Skorpez.Visible = false;
            label2Skorpez.Visible = true;

            trackBarSkorpez.Visible = false;
        }

        private void buttonSkorpezStop_Click(object sender, EventArgs e)
        {
            trackBarSkorpez.Value = trackBarSkorpez.Maximum;
            label1Skorpez.Text = String.Format("Текущее значение: {0}", trackBarSkorpez.Value);
            label2Skorpez.Text = "";
            label1Skorpez.Visible = true;
            label2Skorpez.Visible = false;
            trackBarSkorpez.Visible = true;
            timerSkorpez.Enabled = false;
        }

        private void timerSkorpez_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSkorpez;
            label2Skorpez.Text = (MyGlobalVars.sSkorpez / 60).ToString() + ":" + (MyGlobalVars.sSkorpez % 60 >= 10 ? (object)(MyGlobalVars.sSkorpez % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSkorpez % 60)));
            if (label2Skorpez.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Скорпез", ToolTipIcon.Info);
            if (!(label2Skorpez.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Скорпез", ToolTipIcon.Info);
            timerSkorpez.Stop();
            label2Skorpez.Text = "";
            trackBarSkorpez.Value = trackBarSkorpez.Maximum;
            label1Skorpez.Text = String.Format("Текущее значение: {0}", trackBarSkorpez.Value);

            label1Skorpez.Visible = true;
            label2Skorpez.Visible = false;

            trackBarSkorpez.Visible = true;
            timerSkorpez.Enabled = false;
        }

        //Bengor

        private void buttonBengorStart_Click(object sender, EventArgs e)
        {
            if (trackBarBengor.Value == 0) trackBarBengor.Value = 1;
            this.timerBengor.Interval = 1000;
            MyGlobalVars.sBengor = trackBarBengor.Value * 60;
            if (timerBengor.Enabled)
            {
                timerBengor.Enabled = false;
            }
            else
            {
                timerBengor.Enabled = true;
            }
            label1Bengor.Visible = false;
            label2Bengor.Visible = true;

            trackBarBengor.Visible = false;
        }

        private void buttonBengorStop_Click(object sender, EventArgs e)
        {
            trackBarBengor.Value = trackBarBengor.Maximum;
            label1Bengor.Text = String.Format("Текущее значение: {0}", trackBarBengor.Value);
            label2Bengor.Text = "";
            label1Bengor.Visible = true;
            label2Bengor.Visible = false;
            trackBarBengor.Visible = true;
            timerBengor.Enabled = false;
        }
        private void timerBengor_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sBengor;
            label2Bengor.Text = (MyGlobalVars.sBengor / 60).ToString() + ":" + (MyGlobalVars.sBengor % 60 >= 10 ? (object)(MyGlobalVars.sBengor % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sBengor % 60)));
            if (label2Bengor.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Бенгор", ToolTipIcon.Info);
            if (!(label2Bengor.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Бенгор", ToolTipIcon.Info);
            timerBengor.Stop();
            label2Bengor.Text = "";
            trackBarBengor.Value = trackBarBengor.Maximum;
            label1Bengor.Text = String.Format("Текущее значение: {0}", trackBarBengor.Value);

            label1Bengor.Visible = true;
            label2Bengor.Visible = false;

            trackBarBengor.Visible = true;
            timerBengor.Enabled = false;
        }

        //Hros

        private void buttonHrosStart_Click(object sender, EventArgs e)
        {
            if (trackBarHros.Value == 0) trackBarHros.Value = 1;
            this.timerHros.Interval = 1000;
            MyGlobalVars.sHros = trackBarHros.Value * 60;
            if (timerHros.Enabled)
            {
                timerHros.Enabled = false;
            }
            else
            {
                timerHros.Enabled = true;
            }
            label1Hros.Visible = false;
            label2Hros.Visible = true;

            trackBarHros.Visible = false;
        }

        private void buttonHrosStop_Click(object sender, EventArgs e)
        {
            trackBarHros.Value = trackBarHros.Maximum;
            label1Hros.Text = String.Format("Текущее значение: {0}", trackBarHros.Value);
            label2Hros.Text = "";
            label1Hros.Visible = true;
            label2Hros.Visible = false;
            trackBarHros.Visible = true;
            timerHros.Enabled = false;
        }

        private void timerHros_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sHros;
            label2Hros.Text = (MyGlobalVars.sHros / 60).ToString() + ":" + (MyGlobalVars.sHros % 60 >= 10 ? (object)(MyGlobalVars.sHros % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sHros % 60)));
            if (label2Hros.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Хрос", ToolTipIcon.Info);
            if (!(label2Hros.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Хрос", ToolTipIcon.Info);
            timerHros.Stop();
            label2Hros.Text = "";
            trackBarHros.Value = trackBarHros.Maximum;
            label1Hros.Text = String.Format("Текущее значение: {0}", trackBarHros.Value);

            label1Hros.Visible = true;
            label2Hros.Visible = false;

            trackBarHros.Visible = true;
            timerHros.Enabled = false;
        }

        //Xitxi

        private void buttonXitxiStart_Click(object sender, EventArgs e)
        {
            if (trackBarXitxi.Value == 0) trackBarXitxi.Value = 1;
            this.timerXitxi.Interval = 1000;
            MyGlobalVars.sXitxi = trackBarXitxi.Value * 60;
            if (timerXitxi.Enabled)
            {
                timerXitxi.Enabled = false;
            }
            else
            {
                timerXitxi.Enabled = true;
            }
            label1Xitxi.Visible = false;
            label2Xitxi.Visible = true;

            trackBarXitxi.Visible = false;
        }

        private void buttonXitxiStop_Click(object sender, EventArgs e)
        {
            trackBarXitxi.Value = trackBarXitxi.Maximum;
            label1Xitxi.Text = String.Format("Текущее значение: {0}", trackBarXitxi.Value);
            label2Xitxi.Text = "";
            label1Xitxi.Visible = true;
            label2Xitxi.Visible = false;
            trackBarXitxi.Visible = true;
            timerXitxi.Enabled = false;
        }

        private void timerXitxi_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sXitxi;
            label2Xitxi.Text = (MyGlobalVars.sXitxi / 60).ToString() + ":" + (MyGlobalVars.sXitxi % 60 >= 10 ? (object)(MyGlobalVars.sXitxi % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sXitxi % 60)));
            if (label2Xitxi.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Хитхи", ToolTipIcon.Info);
            if (!(label2Xitxi.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Хитхи", ToolTipIcon.Info);
            timerXitxi.Stop();
            label2Xitxi.Text = "";
            trackBarXitxi.Value = trackBarXitxi.Maximum;
            label1Xitxi.Text = String.Format("Текущее значение: {0}", trackBarXitxi.Value);

            label1Xitxi.Visible = true;
            label2Xitxi.Visible = false;

            trackBarXitxi.Visible = true;
            timerXitxi.Enabled = false;
        }

        //Idju

        private void buttonIdjuStart_Click(object sender, EventArgs e)
        {
            if (trackBarIdju.Value == 0) trackBarIdju.Value = 1;
            this.timerIdju.Interval = 1000;
            MyGlobalVars.sIdju = trackBarIdju.Value * 60;
            if (timerIdju.Enabled)
            {
                timerIdju.Enabled = false;
            }
            else
            {
                timerIdju.Enabled = true;
            }
            label1Idju.Visible = false;
            label2Idju.Visible = true;

            trackBarIdju.Visible = false;
        }

        private void buttonIdjuStop_Click(object sender, EventArgs e)
        {
            trackBarIdju.Value = trackBarIdju.Maximum;
            label1Idju.Text = String.Format("Текущее значение: {0}", trackBarIdju.Value);
            label2Idju.Text = "";
            label1Idju.Visible = true;
            label2Idju.Visible = false;
            trackBarIdju.Visible = true;
            timerIdju.Enabled = false;
        }

        private void timerIdju_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sIdju;
            label2Idju.Text = (MyGlobalVars.sIdju / 60).ToString() + ":" + (MyGlobalVars.sIdju % 60 >= 10 ? (object)(MyGlobalVars.sIdju % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sIdju % 60)));
            if (label2Idju.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Иджу", ToolTipIcon.Info);
            if (!(label2Idju.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Иджу", ToolTipIcon.Info);
            timerIdju.Stop();
            label2Idju.Text = "";
            trackBarIdju.Value = trackBarIdju.Maximum;
            label1Idju.Text = String.Format("Текущее значение: {0}", trackBarIdju.Value);

            label1Idju.Visible = true;
            label2Idju.Visible = false;

            trackBarIdju.Visible = true;
            timerIdju.Enabled = false;
        }

        //Istreb

        private void buttonIstrebStart_Click(object sender, EventArgs e)
        {
            if (trackBarIstreb.Value == 0) trackBarIstreb.Value = 1;
            this.timerIstreb.Interval = 1000;
            MyGlobalVars.sIstreb = trackBarIstreb.Value * 60;
            if (timerIstreb.Enabled)
            {
                timerIstreb.Enabled = false;
            }
            else
            {
                timerIstreb.Enabled = true;
            }
            label1Istreb.Visible = false;
            label2Istreb.Visible = true;

            trackBarIstreb.Visible = false;
        }

        private void buttonIstrebStop_Click(object sender, EventArgs e)
        {
            trackBarIstreb.Value = trackBarIstreb.Maximum;
            label1Istreb.Text = String.Format("Текущее значение: {0}", trackBarIstreb.Value);
            label2Istreb.Text = "";
            label1Istreb.Visible = true;
            label2Istreb.Visible = false;
            trackBarIstreb.Visible = true;
            timerIstreb.Enabled = false;
        }

        private void timerIstreb_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sIstreb;
            label2Istreb.Text = (MyGlobalVars.sIstreb / 60).ToString() + ":" + (MyGlobalVars.sIstreb % 60 >= 10 ? (object)(MyGlobalVars.sIstreb % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sIstreb % 60)));
            if (label2Istreb.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Истребитель", ToolTipIcon.Info);
            if (!(label2Istreb.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Истребитель", ToolTipIcon.Info);
            timerIstreb.Stop();
            label2Istreb.Text = "";
            trackBarIstreb.Value = trackBarIstreb.Maximum;
            label1Istreb.Text = String.Format("Текущее значение: {0}", trackBarIstreb.Value);

            label1Istreb.Visible = true;
            label2Istreb.Visible = false;

            trackBarIstreb.Visible = true;
            timerIstreb.Enabled = false;
        }

        //Edros

        private void buttonEdrosStart_Click(object sender, EventArgs e)
        {
            if (trackBarEdros.Value == 0) trackBarEdros.Value = 1;
            this.timerEdros.Interval = 1000;
            MyGlobalVars.sEdros = trackBarEdros.Value * 60;
            if (timerEdros.Enabled)
            {
                timerEdros.Enabled = false;
            }
            else
            {
                timerEdros.Enabled = true;
            }
            label1Edros.Visible = false;
            label2Edros.Visible = true;

            trackBarEdros.Visible = false;
        }

        private void buttonEdrosStop_Click(object sender, EventArgs e)
        {
            trackBarEdros.Value = trackBarEdros.Maximum;
            label1Edros.Text = String.Format("Текущее значение: {0}", trackBarEdros.Value);
            label2Edros.Text = "";
            label1Edros.Visible = true;
            label2Edros.Visible = false;
            trackBarEdros.Visible = true;
            timerEdros.Enabled = false;
        }

        private void timerEdros_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sEdros;
            label2Edros.Text = (MyGlobalVars.sEdros / 60).ToString() + ":" + (MyGlobalVars.sEdros % 60 >= 10 ? (object)(MyGlobalVars.sEdros % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sEdros % 60)));
            if (label2Edros.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Эдрос", ToolTipIcon.Info);
            if (!(label2Edros.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Эдрос", ToolTipIcon.Info);
            timerEdros.Stop();
            label2Edros.Text = "";
            trackBarEdros.Value = trackBarEdros.Maximum;
            label1Edros.Text = String.Format("Текущее значение: {0}", trackBarEdros.Value);

            label1Edros.Visible = true;
            label2Edros.Visible = false;

            trackBarEdros.Visible = true;
            timerEdros.Enabled = false;
        }

        //Damian

        private void buttonDamianStart_Click(object sender, EventArgs e)
        {
            if (trackBarDamian.Value == 0) trackBarDamian.Value = 1;
            this.timerDamian.Interval = 1000;
            MyGlobalVars.sDamian = trackBarDamian.Value * 60;
            if (timerDamian.Enabled)
            {
                timerDamian.Enabled = false;
            }
            else
            {
                timerDamian.Enabled = true;
            }
            label1Damian.Visible = false;
            label2Damian.Visible = true;

            trackBarDamian.Visible = false;
        }

        private void buttonDamianStop_Click(object sender, EventArgs e)
        {
            trackBarDamian.Value = trackBarDamian.Maximum;
            label1Damian.Text = String.Format("Текущее значение: {0}", trackBarDamian.Value);
            label2Damian.Text = "";
            label1Damian.Visible = true;
            label2Damian.Visible = false;
            trackBarDamian.Visible = true;
            timerDamian.Enabled = false;
        }

        private void timerDamian_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDamian;
            label2Damian.Text = (MyGlobalVars.sDamian / 60).ToString() + ":" + (MyGlobalVars.sDamian % 60 >= 10 ? (object)(MyGlobalVars.sDamian % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDamian % 60)));
            if (label2Damian.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Дамиан", ToolTipIcon.Info);
            if (!(label2Damian.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Дамиан", ToolTipIcon.Info);
            timerDamian.Stop();
            label2Damian.Text = "";
            trackBarDamian.Value = trackBarDamian.Maximum;
            label1Damian.Text = String.Format("Текущее значение: {0}", trackBarDamian.Value);

            label1Damian.Visible = true;
            label2Damian.Visible = false;

            trackBarDamian.Visible = true;
            timerDamian.Enabled = false;
        }

        //Izonomia

        private void buttonIzonomiaStart_Click(object sender, EventArgs e)
        {
            if (trackBarIzonomia.Value == 0) trackBarIzonomia.Value = 1;
            this.timerIzonomia.Interval = 1000;
            MyGlobalVars.sIzonomia = trackBarIzonomia.Value * 60;
            if (timerIzonomia.Enabled)
            {
                timerIzonomia.Enabled = false;
            }
            else
            {
                timerIzonomia.Enabled = true;
            }
            label1Izonomia.Visible = false;
            label2Izonomia.Visible = true;

            trackBarIzonomia.Visible = false;
        }

        private void buttonIzonomiaStop_Click(object sender, EventArgs e)
        {
            trackBarIzonomia.Value = trackBarIzonomia.Maximum;
            label1Izonomia.Text = String.Format("Текущее значение: {0}", trackBarIzonomia.Value);
            label2Izonomia.Text = "";
            label1Izonomia.Visible = true;
            label2Izonomia.Visible = false;
            trackBarIzonomia.Visible = true;
            timerIzonomia.Enabled = false;
        }

        private void timerIzonomia_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sIzonomia;
            label2Izonomia.Text = (MyGlobalVars.sIzonomia / 60).ToString() + ":" + (MyGlobalVars.sIzonomia % 60 >= 10 ? (object)(MyGlobalVars.sIzonomia % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sIzonomia % 60)));
            if (label2Izonomia.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Изономия", ToolTipIcon.Info);
            if (!(label2Izonomia.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Изономия", ToolTipIcon.Info);
            timerIzonomia.Stop();
            label2Izonomia.Text = "";
            trackBarIzonomia.Value = trackBarIzonomia.Maximum;
            label1Izonomia.Text = String.Format("Текущее значение: {0}", trackBarIzonomia.Value);

            label1Izonomia.Visible = true;
            label2Izonomia.Visible = false;

            trackBarIzonomia.Visible = true;
            timerIzonomia.Enabled = false;
        }

        //Orakl

        private void buttonOraklStart_Click(object sender, EventArgs e)
        {
            if (trackBarOrakl.Value == 0) trackBarOrakl.Value = 1;
            this.timerOrakl.Interval = 1000;
            MyGlobalVars.sOrakl = trackBarOrakl.Value * 60;
            if (timerOrakl.Enabled)
            {
                timerOrakl.Enabled = false;
            }
            else
            {
                timerOrakl.Enabled = true;
            }
            label1Orakl.Visible = false;
            label2Orakl.Visible = true;

            trackBarOrakl.Visible = false;
        }

        private void buttonOraklStop_Click(object sender, EventArgs e)
        {
            trackBarOrakl.Value = trackBarOrakl.Maximum;
            label1Orakl.Text = String.Format("Текущее значение: {0}", trackBarOrakl.Value);
            label2Orakl.Text = "";
            label1Orakl.Visible = true;
            label2Orakl.Visible = false;
            trackBarOrakl.Visible = true;
            timerOrakl.Enabled = false;
        }

        private void timerOrakl_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sOrakl;
            label2Orakl.Text = (MyGlobalVars.sOrakl / 60).ToString() + ":" + (MyGlobalVars.sOrakl % 60 >= 10 ? (object)(MyGlobalVars.sOrakl % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sOrakl % 60)));
            if (label2Orakl.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Оракл", ToolTipIcon.Info);
            if (!(label2Orakl.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Оракл", ToolTipIcon.Info);
            timerOrakl.Stop();
            label2Orakl.Text = "";
            trackBarOrakl.Value = trackBarOrakl.Maximum;
            label1Orakl.Text = String.Format("Текущее значение: {0}", trackBarOrakl.Value);

            label1Orakl.Visible = true;
            label2Orakl.Visible = false;

            trackBarOrakl.Visible = true;
            timerOrakl.Enabled = false;
        }

        //Zania

        private void buttonZaniaStart_Click(object sender, EventArgs e)
        {
            if (trackBarZania.Value == 0) trackBarZania.Value = 1;
            this.timerZania.Interval = 1000;
            MyGlobalVars.sZania = trackBarZania.Value * 60;
            if (timerZania.Enabled)
            {
                timerZania.Enabled = false;
            }
            else
            {
                timerZania.Enabled = true;
            }
            label1Zania.Visible = false;
            label2Zania.Visible = true;

            trackBarZania.Visible = false;
        }

        private void buttonZaniaStop_Click(object sender, EventArgs e)
        {
            trackBarZania.Value = trackBarZania.Maximum;
            label1Zania.Text = String.Format("Текущее значение: {0}", trackBarZania.Value);
            label2Zania.Text = "";
            label1Zania.Visible = true;
            label2Zania.Visible = false;
            trackBarZania.Visible = true;
            timerZania.Enabled = false;
        }
        private void timerZania_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sZania;
            label2Zania.Text = (MyGlobalVars.sZania / 60).ToString() + ":" + (MyGlobalVars.sZania % 60 >= 10 ? (object)(MyGlobalVars.sZania % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sZania % 60)));
            if (label2Zania.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Зания", ToolTipIcon.Info);
            if (!(label2Zania.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Зания", ToolTipIcon.Info);
            timerZania.Stop();
            label2Zania.Text = "";
            trackBarZania.Value = trackBarZania.Maximum;
            label1Zania.Text = String.Format("Текущее значение: {0}", trackBarZania.Value);

            label1Zania.Visible = true;
            label2Zania.Visible = false;

            trackBarZania.Visible = true;
            timerZania.Enabled = false;
        }
        private void trackBarBeilrok_Scroll(object sender, EventArgs e)
        {
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1Riolit.Text = String.Format("Текущее значение: {0}", trackBarRiolit.Value);
        }
        private void trackBarAdarog_Scroll(object sender, EventArgs e)
        {
            label1Adarog.Text = String.Format("Текущее значение: {0}", trackBarAdarog.Value);
        }
        private void trackBarKarantal_Scroll(object sender, EventArgs e)
        {
            label1Karantal.Text = String.Format("Текущее значение: {0}", trackBarKarantal.Value);
        }
        private void trackBarBruhoshlak_Scroll(object sender, EventArgs e)
        {
            label1Bruhoshlak.Text = String.Format("Текущее значение: {0}", trackBarBruhoshlak.Value);
        }
        private void trackBarGordot_Scroll(object sender, EventArgs e)
        {
            label1Gordot.Text = String.Format("Текущее значение: {0}", trackBarGordot.Value);
        }
        private void trackBarVenoksis_Scroll(object sender, EventArgs e)
        {
            label1Venoksis.Text = String.Format("Текущее значение: {0}", trackBarVenoksis.Value);
        }
        private void trackBarMandokir_Scroll(object sender, EventArgs e)
        {
            label1Mandokir.Text = String.Format("Текущее значение: {0}", trackBarMandokir.Value);
        }
        private void trackBarZanzil_Scroll(object sender, EventArgs e)
        {
            label1Zanzil.Text = String.Format("Текущее значение: {0}", trackBarZanzil.Value);
        }
        private void trackBarXairi_Scroll(object sender, EventArgs e)
        {
            label1Xairi.Text = String.Format("Текущее значение: {0}", trackBarXairi.Value);
        }
        private void trackBarDjindo_Scroll(object sender, EventArgs e)
        {
            label1Djindo.Text = String.Format("Текущее значение: {0}", trackBarDjindo.Value);
        }
        private void trackBarVodjaka_Scroll(object sender, EventArgs e)
        {
            label1Vodjaka.Text = String.Format("Текущее значение: {0}", trackBarVodjaka.Value);
        }
        private void trackBarGrun_Scroll(object sender, EventArgs e)
        {
            label1Grun.Text = String.Format("Текущее значение: {0}", trackBarGrun.Value);
        }
        private void trackBarVaroten_Scroll(object sender, EventArgs e)
        {
            label1Varoten.Text = String.Format("Текущее значение: {0}", trackBarVaroten.Value);
        }
        private void trackBarPerotarn_Scroll(object sender, EventArgs e)
        {
            label1Perotarn.Text = String.Format("Текущее значение: {0}", trackBarPerotarn.Value);
        }
        private void trackBarRomog_Scroll(object sender, EventArgs e)
        {
            label1Romog.Text = String.Format("Текущее значение: {0}", trackBarRomog.Value);
        }
        private void trackBarVolrak_Scroll(object sender, EventArgs e)
        {
            label1Volrak.Text = String.Format("Текущее значение: {0}", trackBarVolrak.Value);
        }
        private void trackBarAzshara_Scroll(object sender, EventArgs e)
        {
            label1Azshara.Text = String.Format("Текущее значение: {0}", trackBarAzshara.Value);
        }
        private void trackBarKarsh_Scroll(object sender, EventArgs e)
        {
            label1Karsh.Text = String.Format("Текущее значение: {0}", trackBarKarsh.Value);
        }
        private void trackBarGlashatai_Scroll(object sender, EventArgs e)
        {
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);
        }
        private void trackBarArkurion_Scroll(object sender, EventArgs e)
        {
            label1Arkurion.Text = String.Format("Текущее значение: {0}", trackBarArkurion.Value);
        }

        private void trackBarHusan_Scroll(object sender, EventArgs e)
        {
            label1Husan.Text = String.Format("Текущее значение: {0}", trackBarHusan.Value);
        }

        private void trackBarGilton_Scroll(object sender, EventArgs e)
        {
            label1Gilton.Text = String.Format("Текущее значение: {0}", trackBarGilton.Value);
        }

        private void trackBarAlakir_Scroll(object sender, EventArgs e)
        {
            label1Alakir.Text = String.Format("Текущее значение: {0}", trackBarAlakir.Value);
        }

        private void trackBarSetesh_Scroll(object sender, EventArgs e)
        {
            label1Setesh.Text = String.Format("Текущее значение: {0}", trackBarSetesh.Value);
        }

        private void trackBarKaktuar_Scroll(object sender, EventArgs e)
        {
            label1Kaktuar.Text = String.Format("Текущее значение: {0}", trackBarKaktuar.Value);
        }

        private void trackBarSerdce_Scroll(object sender, EventArgs e)
        {
            label1Serdce.Text = String.Format("Текущее значение: {0}", trackBarSerdce.Value);
        }

        private void trackBarTenelov_Scroll(object sender, EventArgs e)
        {
            label1Tenelov.Text = String.Format("Текущее значение: {0}", trackBarTenelov.Value);
        }

        private void trackBarKodo_Scroll(object sender, EventArgs e)
        {
            label1Kodo.Text = String.Format("Текущее значение: {0}", trackBarKodo.Value);
        }

        private void trackBarAtroks_Scroll(object sender, EventArgs e)
        {
            label1Atroks.Text = String.Format("Текущее значение: {0}", trackBarAtroks.Value);
        }

        private void trackBarDven_Scroll(object sender, EventArgs e)
        {
            label1Dven.Text = String.Format("Текущее значение: {0}", trackBarDven.Value);
        }

        private void trackBarIlluzionist_Scroll(object sender, EventArgs e)
        {
            label1Illuzionist.Text = String.Format("Текущее значение: {0}", trackBarIlluzionist.Value);
        }

        private void trackBarSolarian_Scroll(object sender, EventArgs e)
        {
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);
        }

        private void trackBarKeltas_Scroll(object sender, EventArgs e)
        {
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);
        }

        private void trackBarFen_Scroll(object sender, EventArgs e)
        {
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);
        }

        private void trackBarEranikus_Scroll(object sender, EventArgs e)
        {
            label1Eranikus.Text = String.Format("Текущее значение: {0}", trackBarEranikus.Value);
        }

        private void trackBarNafra_Scroll(object sender, EventArgs e)
        {
            label1Nafra.Text = String.Format("Текущее значение: {0}", trackBarNafra.Value);
        }

        private void trackBarTarilzun_Scroll(object sender, EventArgs e)
        {
            label1Tarilzun.Text = String.Format("Текущее значение: {0}", trackBarTarilzun.Value);
        }

        private void trackBarDoan_Scroll(object sender, EventArgs e)
        {
            label1Doan.Text = String.Format("Текущее значение: {0}", trackBarDoan.Value);
        }

        private void trackBarDrobitel_Scroll(object sender, EventArgs e)
        {
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);
        }


        private void trackBarSkorpez_Scroll(object sender, EventArgs e)
        {
            label1Skorpez.Text = String.Format("Текущее значение: {0}", trackBarSkorpez.Value);
        }


        private void trackBarBengor_Scroll(object sender, EventArgs e)
        {
            label1Bengor.Text = String.Format("Текущее значение: {0}", trackBarBengor.Value);
        }


        private void trackBarHros_Scroll(object sender, EventArgs e)
        {
            label1Hros.Text = String.Format("Текущее значение: {0}", trackBarHros.Value);
        }

        private void trackBarXitxi_Scroll(object sender, EventArgs e)
        {
            label1Xitxi.Text = String.Format("Текущее значение: {0}", trackBarXitxi.Value);
        }


        private void trackBarIdju_Scroll(object sender, EventArgs e)
        {
            label1Idju.Text = String.Format("Текущее значение: {0}", trackBarIdju.Value);
        }


        private void trackBarIstreb_Scroll(object sender, EventArgs e)
        {
            label1Istreb.Text = String.Format("Текущее значение: {0}", trackBarIstreb.Value);
        }


        private void trackBarEdros_Scroll(object sender, EventArgs e)
        {
            label1Edros.Text = String.Format("Текущее значение: {0}", trackBarEdros.Value);
        }


        private void trackBarDamian_Scroll(object sender, EventArgs e)
        {
            label1Damian.Text = String.Format("Текущее значение: {0}", trackBarDamian.Value);
        }


        private void trackBarIzonomia_Scroll(object sender, EventArgs e)
        {
            label1Izonomia.Text = String.Format("Текущее значение: {0}", trackBarIzonomia.Value);
        }


        private void trackBarOrakl_Scroll(object sender, EventArgs e)
        {
            label1Orakl.Text = String.Format("Текущее значение: {0}", trackBarOrakl.Value);
        }


        private void trackBarZania_Scroll(object sender, EventArgs e)
        {
            label1Zania.Text = String.Format("Текущее значение: {0}", trackBarZania.Value);
        }
        private void buttonNewVersion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Print newfrm = (Print)Application.OpenForms["Print"];
            newfrm.Show();
        }

        private void buttonRvR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RvR newfrm3 = (RvR)Application.OpenForms["RvR"];
            newfrm3.Show();
        }
    }
}
