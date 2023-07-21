using System;
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
    public partial class Print : Form
    {
        class MyGlobalVars
        {
            // +2 печать
            public static int sGrun = 0;
            public static int sVaroten = 0;
            public static int sPerotarn = 0;
            public static int sGlashatai = 0;
            public static int sFen = 0;
            public static int sSolarian = 0;
            // +3 печать
            public static int sRomog = 0;
            public static int sVolrak = 0;
            public static int sAzshara = 0;
            public static int sKeltas = 0;
            public static int sDrobitel = 0;
            public static int sBeilrok = 0;
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

            if (timerBeilrok.Enabled == true) buttonBeilrokStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonBeilrokStart.ForeColor = Color.Black;
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
            if (timerGlashatai.Enabled == true) buttonGlashataiStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonGlashataiStart.ForeColor = Color.Black;
            if (timerSolarian.Enabled == true) buttonSolarianStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonSolarianStart.ForeColor = Color.Black;
            if (timerKeltas.Enabled == true) buttonKeltasStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonKeltasStart.ForeColor = Color.Black;
            if (timerFen.Enabled == true) buttonFenStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonFenStart.ForeColor = Color.Black;
            if (timerDrobitel.Enabled == true) buttonDrobitelStart.ForeColor = Color.FromArgb(mixR, mixG, mixB);
            else buttonDrobitelStart.ForeColor = Color.Black;

            step += 0.03f;
            Random rand = new Random();
            int n = 11;
            char[] A = new char[11];

            for (int i = 0; i < n; i++)
            {
                A[i] = (char)rand.Next(0x16A0, 0x16C0);
            }
        }
        public Print()
        {
            InitializeComponent();
            timer1.Interval = 20;
            timer1.Enabled = true;
            Boss_Timer.Visible = true;
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);
            label1Grun.Text = String.Format("Текущее значение: {0}", trackBarGrun.Value);
            label1Varoten.Text = String.Format("Текущее значение: {0}", trackBarVaroten.Value);
            label1Perotarn.Text = String.Format("Текущее значение: {0}", trackBarPerotarn.Value);
            label1Romog.Text = String.Format("Текущее значение: {0}", trackBarRomog.Value);
            label1Volrak.Text = String.Format("Текущее значение: {0}", trackBarVolrak.Value);
            label1Azshara.Text = String.Format("Текущее значение: {0}", trackBarAzshara.Value);
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string a = getHWID();
            if (!(a == "325B91DD")) return;
        }
        static string getHWID()
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            string id = dsk["VolumeSerialNumber"].ToString();
            return id;
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

        private void trackBarFen_Scroll(object sender, EventArgs e)
        {
            label1Fen.Text = String.Format("Текущее значение: {0}", trackBarFen.Value);
        }

        private void trackBarGlashatai_Scroll(object sender, EventArgs e)
        {
            label1Glashatai.Text = String.Format("Текущее значение: {0}", trackBarGlashatai.Value);
        }

        private void trackBarSolarian_Scroll(object sender, EventArgs e)
        {
            label1Solarian.Text = String.Format("Текущее значение: {0}", trackBarSolarian.Value);
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

        private void trackBarBeilrok_Scroll(object sender, EventArgs e)
        {
            label1Beilrok.Text = String.Format("Текущее значение: {0}", trackBarBeilrok.Value);
        }

        private void trackBarKeltas_Scroll(object sender, EventArgs e)
        {
            label1Keltas.Text = String.Format("Текущее значение: {0}", trackBarKeltas.Value);
        }

        private void trackBarDrobitel_Scroll(object sender, EventArgs e)
        {
            label1Drobitel.Text = String.Format("Текущее значение: {0}", trackBarDrobitel.Value);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Novice ifrm = (Novice)Application.OpenForms["Novice"];
            ifrm.Visible = true;
        }
        private void Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
