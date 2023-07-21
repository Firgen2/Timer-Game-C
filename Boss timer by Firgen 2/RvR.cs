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
    public partial class RvR : Form
    {
        public RvR()
        {
            InitializeComponent();
            Boss_Timer.Visible = true;
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
        class MyGlobalVars
        {
            public static int sMirovoi = 0;
            public static int sSindragosa = 0;
            public static int sDjim = 0;
            public static int sFilaken = 0;
            public static int sKnight = 0;
            public static int sValakas = 0;
            public static int sGoblin = 0;
            public static int sGilrik = 0;
            public static int sSoul = 0;
            public static int sMel = 0;
            public static int sOrc = 0;
            public static int sIssagir = 0;
            public static int sSoul1 = 0;
            public static int sZumonga = 0;
            public static int sMuravei = 0;
        }

        //MirovoiStart

        private void buttonMirovoiStart_Click(object sender, EventArgs e)
        {
            if (trackBarMirovoi.Value == 0) trackBarMirovoi.Value = 1;
            this.timerMirovoi.Interval = 1000;
            MyGlobalVars.sMirovoi = trackBarMirovoi.Value * 60;
            if (timerMirovoi.Enabled)
            {
                timerMirovoi.Enabled = false;
            }
            else
            {
                timerMirovoi.Enabled = true;
            }
            label1Mirovoi.Visible = false;
            label2Mirovoi.Visible = true;

            trackBarMirovoi.Visible = false;
        }

        //MirovoiStop

        private void buttonMirovoiStop_Click(object sender, EventArgs e)
        {
            trackBarMirovoi.Value = trackBarMirovoi.Maximum;
            label1Mirovoi.Text = String.Format("Текущее значение: {0}", trackBarMirovoi.Value);
            label2Mirovoi.Text = "";
            label1Mirovoi.Visible = true;
            label2Mirovoi.Visible = false;
            trackBarMirovoi.Visible = true;
            timerMirovoi.Enabled = false;
        }

        //FilakenStart

        private void buttonFilakenStart_Click(object sender, EventArgs e)
        {
            if (trackBarFilaken.Value == 0) trackBarFilaken.Value = 1;
            this.timerFilaken.Interval = 1000;
            MyGlobalVars.sFilaken = trackBarFilaken.Value * 60;
            if (timerFilaken.Enabled)
            {
                timerFilaken.Enabled = false;
            }
            else
            {
                timerFilaken.Enabled = true;
            }
            label1Filaken.Visible = false;
            label2Filaken.Visible = true;

            trackBarFilaken.Visible = false;
        }

        //FilakenStop

        private void buttonFilakenStop_Click(object sender, EventArgs e)
        {
            trackBarFilaken.Value = trackBarFilaken.Maximum;
            label1Filaken.Text = String.Format("Текущее значение: {0}", trackBarFilaken.Value);
            label2Filaken.Text = "";
            label1Filaken.Visible = true;
            label2Filaken.Visible = false;
            trackBarFilaken.Visible = true;
            timerFilaken.Enabled = false;
        }

        //SindragosaStart

        private void buttonSindragosaStart_Click(object sender, EventArgs e)
        {
            if (trackBarSindragosa.Value == 0) trackBarSindragosa.Value = 1;
            this.timerSindragosa.Interval = 1000;
            MyGlobalVars.sSindragosa = trackBarSindragosa.Value * 60;
            if (timerSindragosa.Enabled)
            {
                timerSindragosa.Enabled = false;
            }
            else
            {
                timerSindragosa.Enabled = true;
            }
            label1Sindragosa.Visible = false;
            label2Sindragosa.Visible = true;

            trackBarSindragosa.Visible = false;
        }

        //SindragosaStop

        private void buttonSindragosaStop_Click(object sender, EventArgs e)
        {
            trackBarSindragosa.Value = trackBarSindragosa.Maximum;
            label1Sindragosa.Text = String.Format("Текущее значение: {0}", trackBarSindragosa.Value);
            label2Sindragosa.Text = "";
            label1Sindragosa.Visible = true;
            label2Sindragosa.Visible = false;
            trackBarSindragosa.Visible = true;
            timerSindragosa.Enabled = false;
        }

        //DjimStart

        private void buttonDjimStart_Click(object sender, EventArgs e)
        {
            if (trackBarDjim.Value == 0) trackBarDjim.Value = 1;
            this.timerDjim.Interval = 1000;
            MyGlobalVars.sDjim = trackBarDjim.Value * 60;
            if (timerDjim.Enabled)
            {
                timerDjim.Enabled = false;
            }
            else
            {
                timerDjim.Enabled = true;
            }
            label1Djim.Visible = false;
            label2Djim.Visible = true;

            trackBarDjim.Visible = false;
        }

        //DjimStop

        private void buttonDjimStop_Click(object sender, EventArgs e)
        {
            trackBarDjim.Value = trackBarDjim.Maximum;
            label1Djim.Text = String.Format("Текущее значение: {0}", trackBarDjim.Value);
            label2Djim.Text = "";
            label1Djim.Visible = true;
            label2Djim.Visible = false;
            trackBarDjim.Visible = true;
            timerDjim.Enabled = false;
        }

        //KnightStart

        private void buttonKnightStart_Click(object sender, EventArgs e)
        {
            if (trackBarKnight.Value == 0) trackBarKnight.Value = 1;
            this.timerKnight.Interval = 1000;
            MyGlobalVars.sKnight = trackBarKnight.Value * 60;
            if (timerKnight.Enabled)
            {
                timerKnight.Enabled = false;
            }
            else
            {
                timerKnight.Enabled = true;
            }
            label1Knight.Visible = false;
            label2Knight.Visible = true;

            trackBarKnight.Visible = false;
        }

        //KnightStop

        private void buttonKnightStop_Click(object sender, EventArgs e)
        {
            trackBarKnight.Value = trackBarKnight.Maximum;
            label1Knight.Text = String.Format("Текущее значение: {0}", trackBarKnight.Value);
            label2Knight.Text = "";
            label1Knight.Visible = true;
            label2Knight.Visible = false;
            trackBarKnight.Visible = true;
            timerKnight.Enabled = false;
        }

        //ValakasStart
        private void buttonValakasStart_Click(object sender, EventArgs e)
        {
            if (trackBarValakas.Value == 0) trackBarValakas.Value = 1;
            this.timerValakas.Interval = 1000;
            MyGlobalVars.sValakas = trackBarValakas.Value * 60;
            if (timerValakas.Enabled)
            {
                timerValakas.Enabled = false;
            }
            else
            {
                timerValakas.Enabled = true;
            }
            label1Valakas.Visible = false;
            label2Valakas.Visible = true;

            trackBarValakas.Visible = false;
        }

        //ValakasStop

        private void buttonValakasStop_Click(object sender, EventArgs e)
        {
            trackBarValakas.Value = trackBarValakas.Maximum;
            label1Valakas.Text = String.Format("Текущее значение: {0}", trackBarValakas.Value);
            label2Valakas.Text = "";
            label1Valakas.Visible = true;
            label2Valakas.Visible = false;
            trackBarValakas.Visible = true;
            timerValakas.Enabled = false;
        }

        //GoblinStart

        private void buttonGoblinStart_Click(object sender, EventArgs e)
        {
            if (trackBarGoblin.Value == 0) trackBarGoblin.Value = 1;
            this.timerGoblin.Interval = 1000;
            MyGlobalVars.sGoblin = trackBarGoblin.Value * 60;
            if (timerGoblin.Enabled)
            {
                timerGoblin.Enabled = false;
            }
            else
            {
                timerGoblin.Enabled = true;
            }
            label1Goblin.Visible = false;
            label2Goblin.Visible = true;

            trackBarGoblin.Visible = false;
        }

        //GoblinStop

        private void buttonGoblinStop_Click(object sender, EventArgs e)
        {
            trackBarGoblin.Value = trackBarGoblin.Maximum;
            label1Goblin.Text = String.Format("Текущее значение: {0}", trackBarGoblin.Value);
            label2Goblin.Text = "";
            label1Goblin.Visible = true;
            label2Goblin.Visible = false;
            trackBarGoblin.Visible = true;
            timerGoblin.Enabled = false;
        }

        //GilrikStart
        private void buttonGilrikStart_Click(object sender, EventArgs e)
        {
            if (trackBarGilrik.Value == 0) trackBarGilrik.Value = 1;
            this.timerGilrik.Interval = 1000;
            MyGlobalVars.sGilrik = trackBarGilrik.Value * 60;
            if (timerGilrik.Enabled)
            {
                timerGilrik.Enabled = false;
            }
            else
            {
                timerGilrik.Enabled = true;
            }
            label1Gilrik.Visible = false;
            label2Gilrik.Visible = true;

            trackBarGilrik.Visible = false;
        }

        //GilrikStop

        private void buttonGilrikStop_Click(object sender, EventArgs e)
        {
            trackBarGilrik.Value = trackBarGilrik.Maximum;
            label1Gilrik.Text = String.Format("Текущее значение: {0}", trackBarGilrik.Value);
            label2Gilrik.Text = "";
            label1Gilrik.Visible = true;
            label2Gilrik.Visible = false;
            trackBarGilrik.Visible = true;
            timerGilrik.Enabled = false;
        }
        
        //SoulStart

        private void buttonSoulStart_Click(object sender, EventArgs e)
        {
            if (trackBarSoul.Value == 0) trackBarSoul.Value = 1;
            this.timerSoul.Interval = 1000;
            MyGlobalVars.sSoul = trackBarSoul.Value * 60;
            if (timerSoul.Enabled)
            {
                timerSoul.Enabled = false;
            }
            else
            {
                timerSoul.Enabled = true;
            }
            label1Soul.Visible = false;
            label2Soul.Visible = true;

            trackBarSoul.Visible = false;
        }

        //SoulStop

        private void buttonSoulStop_Click(object sender, EventArgs e)
        {
            trackBarSoul.Value = trackBarSoul.Maximum;
            label1Soul.Text = String.Format("Текущее значение: {0}", trackBarSoul.Value);
            label2Soul.Text = "";
            label1Soul.Visible = true;
            label2Soul.Visible = false;
            trackBarSoul.Visible = true;
            timerSoul.Enabled = false;
        }

        //MelStart
        private void buttonMelStart_Click(object sender, EventArgs e)
        {
            if (trackBarMel.Value == 0) trackBarMel.Value = 1;
            this.timerMel.Interval = 1000;
            MyGlobalVars.sMel = trackBarMel.Value * 60;
            if (timerMel.Enabled)
            {
                timerMel.Enabled = false;
            }
            else
            {
                timerMel.Enabled = true;
            }
            label1Mel.Visible = false;
            label2Mel.Visible = true;

            trackBarMel.Visible = false;
        }

        //MelStop

        private void buttonMelStop_Click(object sender, EventArgs e)
        {
            trackBarMel.Value = trackBarMel.Maximum;
            label1Mel.Text = String.Format("Текущее значение: {0}", trackBarMel.Value);
            label2Mel.Text = "";
            label1Mel.Visible = true;
            label2Mel.Visible = false;
            trackBarMel.Visible = true;
            timerMel.Enabled = false;
        }

        //OrcStart
        private void buttonStartOrc_Click(object sender, EventArgs e)
        {
            if (trackBarOrc.Value == 0) trackBarOrc.Value = 1;
            this.timerOrc.Interval = 1000;
            MyGlobalVars.sOrc = trackBarOrc.Value * 60;
            if (timerOrc.Enabled)
            {
                timerOrc.Enabled = false;
            }
            else
            {
                timerOrc.Enabled = true;
            }
            label1Orc.Visible = false;
            label2Orc.Visible = true;

            trackBarOrc.Visible = false;
        }

        //OrcStop
        private void buttonOrcStop_Click(object sender, EventArgs e)
        {
            trackBarOrc.Value = trackBarOrc.Maximum;
            label1Orc.Text = String.Format("Текущее значение: {0}", trackBarOrc.Value);
            label2Orc.Text = "";
            label1Orc.Visible = true;
            label2Orc.Visible = false;
            trackBarOrc.Visible = true;
            timerOrc.Enabled = false;
        }

        //IssagirStart
        private void buttonIssagirStart_Click(object sender, EventArgs e)
        {
            if (trackBarIssagir.Value == 0) trackBarIssagir.Value = 1;
            this.timerIssagir.Interval = 1000;
            MyGlobalVars.sIssagir = trackBarIssagir.Value * 60;
            if (timerIssagir.Enabled)
            {
                timerIssagir.Enabled = false;
            }
            else
            {
                timerIssagir.Enabled = true;
            }
            label1Issagir.Visible = false;
            label2Issagir.Visible = true;

            trackBarIssagir.Visible = false;
        }

        //IssagirStop
        private void buttonIssagirStop_Click(object sender, EventArgs e)
        {
            trackBarIssagir.Value = trackBarIssagir.Maximum;
            label1Issagir.Text = String.Format("Текущее значение: {0}", trackBarIssagir.Value);
            label2Issagir.Text = "";
            label1Issagir.Visible = true;
            label2Issagir.Visible = false;
            trackBarIssagir.Visible = true;
            timerIssagir.Enabled = false;
        }

        //Soul1Start
        private void buttonSoul1Start_Click(object sender, EventArgs e)
        {
            if (trackBarSoul1.Value == 0) trackBarSoul1.Value = 1;
            this.timerSoul1.Interval = 1000;
            MyGlobalVars.sSoul1 = trackBarSoul1.Value * 60;
            if (timerSoul1.Enabled)
            {
                timerSoul1.Enabled = false;
            }
            else
            {
                timerSoul1.Enabled = true;
            }
            label1Soul1.Visible = false;
            label2Soul1.Visible = true;

            trackBarSoul1.Visible = false;
        }

        //Soul1Stop
        private void buttonSoul1Stop_Click(object sender, EventArgs e)
        {
            trackBarSoul1.Value = trackBarSoul1.Maximum;
            label1Soul1.Text = String.Format("Текущее значение: {0}", trackBarSoul1.Value);
            label2Soul1.Text = "";
            label1Soul1.Visible = true;
            label2Soul1.Visible = false;
            trackBarSoul1.Visible = true;
            timerSoul1.Enabled = false;
        }

        //ZumongaStop
        private void buttonZumongaStart_Click(object sender, EventArgs e)
        {
            if (trackBarZumonga.Value == 0) trackBarZumonga.Value = 1;
            this.timerZumonga.Interval = 1000;
            MyGlobalVars.sZumonga = trackBarZumonga.Value * 60;
            if (timerZumonga.Enabled)
            {
                timerZumonga.Enabled = false;
            }
            else
            {
                timerZumonga.Enabled = true;
            }
            label1Zumonga.Visible = false;
            label2Zumonga.Visible = true;

            trackBarZumonga.Visible = false;
        }

        //ZumongaStop
        private void buttonZumongaStop_Click(object sender, EventArgs e)
        {
            trackBarZumonga.Value = trackBarZumonga.Maximum;
            label1Zumonga.Text = String.Format("Текущее значение: {0}", trackBarZumonga.Value);
            label2Zumonga.Text = "";
            label1Zumonga.Visible = true;
            label2Zumonga.Visible = false;
            trackBarZumonga.Visible = true;
            timerZumonga.Enabled = false;
        }

        //MuraveiStart
        private void buttonMuraveiStart_Click(object sender, EventArgs e)
        {
            if (trackBarMuravei.Value == 0) trackBarMuravei.Value = 1;
            this.timerMuravei.Interval = 1000;
            MyGlobalVars.sMuravei = trackBarMuravei.Value * 60;
            if (timerMuravei.Enabled)
            {
                timerMuravei.Enabled = false;
            }
            else
            {
                timerMuravei.Enabled = true;
            }
            label1Muravei.Visible = false;
            label2Muravei.Visible = true;

            trackBarMuravei.Visible = false;
        }

        //MuraveiStop
        private void buttonMuraveiStop_Click(object sender, EventArgs e)
        {
            trackBarMuravei.Value = trackBarMuravei.Maximum;
            label1Muravei.Text = String.Format("Текущее значение: {0}", trackBarMuravei.Value);
            label2Muravei.Text = "";
            label1Muravei.Visible = true;
            label2Muravei.Visible = false;
            trackBarMuravei.Visible = true;
            timerMuravei.Enabled = false;
        }
        //TimerMirovoi

        private void timerMirovoi_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sMirovoi;
            label2Mirovoi.Text = (MyGlobalVars.sMirovoi / 60).ToString() + ":" + (MyGlobalVars.sMirovoi % 60 >= 10 ? (object)(MyGlobalVars.sMirovoi % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sMirovoi % 60)));
            if (label2Mirovoi.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится :", "Аванпост", ToolTipIcon.Info);
            if (!(label2Mirovoi.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился аванпост", "!", ToolTipIcon.Info);
            timerMirovoi.Stop();
            label2Mirovoi.Text = "";
            trackBarMirovoi.Value = trackBarMirovoi.Maximum;
            label1Mirovoi.Text = String.Format("Текущее значение: {0}", trackBarMirovoi.Value);

            label1Mirovoi.Visible = true;
            label2Mirovoi.Visible = false;

            trackBarMirovoi.Visible = true;
            timerMirovoi.Enabled = false;
        }

        //TimerFilaken
        private void timerFilaken_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sFilaken;
            label2Filaken.Text = (MyGlobalVars.sFilaken / 60).ToString() + ":" + (MyGlobalVars.sFilaken % 60 >= 10 ? (object)(MyGlobalVars.sFilaken % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sFilaken % 60)));
            if (label2Filaken.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Молранг", ToolTipIcon.Info);
            if (!(label2Filaken.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Молранг", ToolTipIcon.Info);
            timerFilaken.Stop();
            label2Filaken.Text = "";
            trackBarFilaken.Value = trackBarFilaken.Maximum;
            label1Filaken.Text = String.Format("Текущее значение: {0}", trackBarFilaken.Value);

            label1Filaken.Visible = true;
            label2Filaken.Visible = false;

            trackBarFilaken.Visible = true;
            timerFilaken.Enabled = false;
        }

        //TimerSindragosa

        private void timerSindragosa_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSindragosa;
            label2Sindragosa.Text = (MyGlobalVars.sSindragosa / 60).ToString() + ":" + (MyGlobalVars.sSindragosa % 60 >= 10 ? (object)(MyGlobalVars.sSindragosa % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSindragosa % 60)));
            if (label2Sindragosa.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Белеф", ToolTipIcon.Info);
            if (!(label2Sindragosa.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Белеф", ToolTipIcon.Info);
            timerSindragosa.Stop();
            label2Sindragosa.Text = "";
            trackBarSindragosa.Value = trackBarSindragosa.Maximum;
            label1Sindragosa.Text = String.Format("Текущее значение: {0}", trackBarSindragosa.Value);

            label1Sindragosa.Visible = true;
            label2Sindragosa.Visible = false;

            trackBarSindragosa.Visible = true;
            timerSindragosa.Enabled = false;
        }

        //TimerDjim

        private void timerDjim_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sDjim;
            label2Djim.Text = (MyGlobalVars.sDjim / 60).ToString() + ":" + (MyGlobalVars.sDjim % 60 >= 10 ? (object)(MyGlobalVars.sDjim % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sDjim % 60)));
            if (label2Djim.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Орфен", ToolTipIcon.Info);
            if (!(label2Djim.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Орфен", ToolTipIcon.Info);
            timerDjim.Stop();
            label2Djim.Text = "";
            trackBarDjim.Value = trackBarDjim.Maximum;
            label1Djim.Text = String.Format("Текущее значение: {0}", trackBarDjim.Value);

            label1Djim.Visible = true;
            label2Djim.Visible = false;

            trackBarDjim.Visible = true;
            timerDjim.Enabled = false;
        }
        //TimerKnight
        private void timerKnight_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sKnight;
            label2Knight.Text = (MyGlobalVars.sKnight / 60).ToString() + ":" + (MyGlobalVars.sKnight % 60 >= 10 ? (object)(MyGlobalVars.sKnight % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sKnight % 60)));
            if (label2Knight.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Рыцарь смерти", ToolTipIcon.Info);
            if (!(label2Knight.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Рыцарь смерти", ToolTipIcon.Info);
            timerKnight.Stop();
            label2Knight.Text = "";
            trackBarKnight.Value = trackBarKnight.Maximum;
            label1Knight.Text = String.Format("Текущее значение: {0}", trackBarKnight.Value);

            label1Knight.Visible = true;
            label2Knight.Visible = false;

            trackBarKnight.Visible = true;
            timerKnight.Enabled = false;
        }

        //TimerValakas
        private void timerValakas_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sValakas;
            label2Valakas.Text = (MyGlobalVars.sValakas / 60).ToString() + ":" + (MyGlobalVars.sValakas % 60 >= 10 ? (object)(MyGlobalVars.sValakas % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sValakas % 60)));
            if (label2Valakas.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Валакас", ToolTipIcon.Info);
            if (!(label2Valakas.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Валакас", ToolTipIcon.Info);
            timerValakas.Stop();
            label2Valakas.Text = "";
            trackBarValakas.Value = trackBarValakas.Maximum;
            label1Valakas.Text = String.Format("Текущее значение: {0}", trackBarValakas.Value);

            label1Valakas.Visible = true;
            label2Valakas.Visible = false;

            trackBarValakas.Visible = true;
            timerValakas.Enabled = false;
        }

        //TimerGoblin

        private void timerGoblin_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGoblin;
            label2Goblin.Text = (MyGlobalVars.sGoblin / 60).ToString() + ":" + (MyGlobalVars.sGoblin % 60 >= 10 ? (object)(MyGlobalVars.sGoblin % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGoblin % 60)));
            if (label2Goblin.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Гоблин", ToolTipIcon.Info);
            if (!(label2Goblin.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Гоблин", ToolTipIcon.Info);
            timerGoblin.Stop();
            label2Goblin.Text = "";
            trackBarGoblin.Value = trackBarGoblin.Maximum;
            label1Goblin.Text = String.Format("Текущее значение: {0}", trackBarGoblin.Value);

            label1Goblin.Visible = true;
            label2Goblin.Visible = false;

            trackBarGoblin.Visible = true;
            timerValakas.Enabled = false;
        }

        //TimerGilrik

        private void timerGilrik_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sGilrik;
            label2Gilrik.Text = (MyGlobalVars.sGilrik / 60).ToString() + ":" + (MyGlobalVars.sGilrik % 60 >= 10 ? (object)(MyGlobalVars.sGilrik % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sGilrik % 60)));
            if (label2Gilrik.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Гилрик", ToolTipIcon.Info);
            if (!(label2Gilrik.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Гилрик", ToolTipIcon.Info);
            timerGilrik.Stop();
            label2Gilrik.Text = "";
            trackBarGilrik.Value = trackBarGilrik.Maximum;
            label1Gilrik.Text = String.Format("Текущее значение: {0}", trackBarGilrik.Value);

            label1Gilrik.Visible = true;
            label2Gilrik.Visible = false;

            trackBarGilrik.Visible = true;
            timerGilrik.Enabled = false;
        }

        //TimerSoul
        private void timerSoul_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSoul;
            label2Soul.Text = (MyGlobalVars.sSoul / 60).ToString() + ":" + (MyGlobalVars.sSoul % 60 >= 10 ? (object)(MyGlobalVars.sSoul % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSoul % 60)));
            if (label2Soul.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Собиратель душ", ToolTipIcon.Info);
            if (!(label2Soul.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Собиратель душ", ToolTipIcon.Info);
            timerSoul.Stop();
            label2Soul.Text = "";
            trackBarSoul.Value = trackBarSoul.Maximum;
            label1Soul.Text = String.Format("Текущее значение: {0}", trackBarSoul.Value);

            label1Soul.Visible = true;
            label2Soul.Visible = false;

            trackBarSoul.Visible = true;
            timerSoul.Enabled = false;
        }

        //TimerMel
        private void timerMel_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sMel;
            label2Mel.Text = (MyGlobalVars.sMel / 60).ToString() + ":" + (MyGlobalVars.sMel % 60 >= 10 ? (object)(MyGlobalVars.sMel % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sMel % 60)));
            if (label2Mel.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Предводитель Мэль", ToolTipIcon.Info);
            if (!(label2Mel.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Предводитель Мэль", ToolTipIcon.Info);
            timerMel.Stop();
            label2Mel.Text = "";
            trackBarMel.Value = trackBarMel.Maximum;
            label1Mel.Text = String.Format("Текущее значение: {0}", trackBarMel.Value);

            label1Mel.Visible = true;
            label2Mel.Visible = false;

            trackBarMel.Visible = true;
            timerMel.Enabled = false;
        }

        //TimerOrc
        private void timerOrc_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sOrc;
            label2Orc.Text = (MyGlobalVars.sOrc / 60).ToString() + ":" + (MyGlobalVars.sOrc % 60 >= 10 ? (object)(MyGlobalVars.sOrc % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sOrc % 60)));
            if (label2Orc.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Предводитель Орков", ToolTipIcon.Info);
            if (!(label2Orc.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Предводитель Орков", ToolTipIcon.Info);
            timerOrc.Stop();
            label2Orc.Text = "";
            trackBarOrc.Value = trackBarOrc.Maximum;
            label1Orc.Text = String.Format("Текущее значение: {0}", trackBarOrc.Value);

            label1Orc.Visible = true;
            label2Orc.Visible = false;

            trackBarOrc.Visible = true;
            timerOrc.Enabled = false;
        }

        //TimerIssagir

        private void timerIssagir_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sIssagir;
            label2Issagir.Text = (MyGlobalVars.sIssagir / 60).ToString() + ":" + (MyGlobalVars.sIssagir % 60 >= 10 ? (object)(MyGlobalVars.sIssagir % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sIssagir % 60)));
            if (label2Issagir.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Иссагир", ToolTipIcon.Info);
            if (!(label2Issagir.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Иссгаир", ToolTipIcon.Info);
            timerIssagir.Stop();
            label2Issagir.Text = "";
            trackBarIssagir.Value = trackBarIssagir.Maximum;
            label1Issagir.Text = String.Format("Текущее значение: {0}", trackBarIssagir.Value);

            label1Issagir.Visible = true;
            label2Issagir.Visible = false;

            trackBarIssagir.Visible = true;
            timerIssagir.Enabled = false;
        }

        private void timerSoul1_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sSoul1;
            label2Soul1.Text = (MyGlobalVars.sSoul1 / 60).ToString() + ":" + (MyGlobalVars.sSoul1 % 60 >= 10 ? (object)(MyGlobalVars.sSoul1 % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sSoul1 % 60)));
            if (label2Soul1.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Собиратель душ", ToolTipIcon.Info);
            if (!(label2Soul1.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Собиратель душ", ToolTipIcon.Info);
            timerSoul1.Stop();
            label2Soul1.Text = "";
            trackBarSoul1.Value = trackBarSoul1.Maximum;
            label1Soul1.Text = String.Format("Текущее значение: {0}", trackBarSoul1.Value);

            label1Soul1.Visible = true;
            label2Soul1.Visible = false;

            trackBarSoul1.Visible = true;
            timerSoul1.Enabled = false;
        }

        private void timerZumonga_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sZumonga;
            label2Zumonga.Text = (MyGlobalVars.sZumonga / 60).ToString() + ":" + (MyGlobalVars.sZumonga % 60 >= 10 ? (object)(MyGlobalVars.sZumonga % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sZumonga % 60)));
            if (label2Zumonga.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Зумонга", ToolTipIcon.Info);
            if (!(label2Zumonga.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Зумонга", ToolTipIcon.Info);
            timerZumonga.Stop();
            label2Zumonga.Text = "";
            trackBarZumonga.Value = trackBarZumonga.Maximum;
            label1Zumonga.Text = String.Format("Текущее значение: {0}", trackBarZumonga.Value);

            label1Zumonga.Visible = true;
            label2Zumonga.Visible = false;

            trackBarZumonga.Visible = true;
            timerZumonga.Enabled = false;
        }

        //TimerMuravei

        private void timerMuravei_Tick(object sender, EventArgs e)
        {
            --MyGlobalVars.sMuravei;
            label2Muravei.Text = (MyGlobalVars.sMuravei / 60).ToString() + ":" + (MyGlobalVars.sMuravei % 60 >= 10 ? (object)(MyGlobalVars.sMuravei % 60).ToString() : (object)("0" + (object)(MyGlobalVars.sMuravei % 60)));
            if (label2Muravei.Text == "5:00")
                Boss_Timer.ShowBalloonTip(2000, "Через 5 минут зареспавнится босс:", "Главарь Муравьев", ToolTipIcon.Info);
            if (!(label2Muravei.Text == "0:00"))
                return;
            Boss_Timer.ShowBalloonTip(2000, "Зареспавнился босс:", "Главарь Муравьев", ToolTipIcon.Info);
            timerMuravei.Stop();
            label2Muravei.Text = "";
            trackBarMuravei.Value = trackBarMuravei.Maximum;
            label1Muravei.Text = String.Format("Текущее значение: {0}", trackBarMuravei.Value);

            label1Muravei.Visible = true;
            label2Muravei.Visible = false;

            trackBarMuravei.Visible = true;
            timerMuravei.Enabled = false;
        }

        private void trackBarMirovoi_Scroll(object sender, EventArgs e)
        {
            label1Mirovoi.Text = String.Format("Текущее значение: {0}", trackBarMirovoi.Value);
        }
        private void trackBarFilaken_Scroll(object sender, EventArgs e)
        {
            label1Filaken.Text = String.Format("Текущее значение: {0}", trackBarFilaken.Value);
        }
        private void trackBarSindragosa_Scroll(object sender, EventArgs e)
        {
            label1Sindragosa.Text = String.Format("Текущее значение: {0}", trackBarSindragosa.Value);
        }
        private void trackBarDjim_Scroll(object sender, EventArgs e)
        {
            label1Djim.Text = String.Format("Текущее значение: {0}", trackBarDjim.Value);
        }

        private void trackBarKnight_Scroll(object sender, EventArgs e)
        {
            label1Knight.Text = String.Format("Текущее значение: {0}", trackBarKnight.Value);
        }

        private void trackBarValakas_Scroll(object sender, EventArgs e)
        {
            label1Valakas.Text = String.Format("Текущее значение: {0}", trackBarValakas.Value);
        }

        private void trackBarGoblin_Scroll(object sender, EventArgs e)
        {
            label1Goblin.Text = String.Format("Текущее значение: {0}", trackBarGoblin.Value);
        }

        private void trackBarGilrik_Scroll(object sender, EventArgs e)
        {
            label1Gilrik.Text = String.Format("Текущее значение: {0}", trackBarGilrik.Value);
        }

        private void trackBarSoul_Scroll(object sender, EventArgs e)
        {
            label1Soul.Text = String.Format("Текущее значение: {0}", trackBarSoul.Value);
        }

        private void trackBarMel_Scroll(object sender, EventArgs e)
        {
            label1Mel.Text = String.Format("Текущее значение: {0}", trackBarMel.Value);
        }

        private void trackBarOrc_Scroll(object sender, EventArgs e)
        {
            label1Orc.Text = String.Format("Текущее значение: {0}", trackBarOrc.Value);
        }

        private void trackBarIssagir_Scroll(object sender, EventArgs e)
        {
            label1Issagir.Text = String.Format("Текущее значение: {0}", trackBarIssagir.Value);
        }

        private void trackBarSoul1_Scroll(object sender, EventArgs e)
        {
            label1Soul1.Text = String.Format("Текущее значение: {0}", trackBarSoul1.Value);
        }

        private void trackBarZumonga_Scroll(object sender, EventArgs e)
        {
            label1Zumonga.Text = String.Format("Текущее значение: {0}", trackBarZumonga.Value);
        }

        private void trackBarMuravei_Scroll(object sender, EventArgs e)
        {
            label1Muravei.Text = String.Format("Текущее значение: {0}", trackBarMuravei.Value);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Novice ifrm3 = (Novice)Application.OpenForms["Novice"];
            ifrm3.Visible = true;
        }
        private void RvR_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
