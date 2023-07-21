  private void timerUsop_Tick(object sender, EventArgs e)
    {
      --Form1.Usop;
      this.labelUsop.Text = (Form1.Usop / 60).ToString() + ":" + (Form1.Usop % 60 >= 10 ? (object) (Form1.Usop % 60).ToString() : (object) ("0" + (object) (Form1.Usop % 60)));
      if (this.labelUsop.Text == "2:00")
        this.notifyIcon1.ShowBalloonTip(5000, "Через 2 минуты зареспавнится босс:", "Командир усопших", ToolTipIcon.Info);
      if (!(this.labelUsop.Text == "0:00"))
        return;
      this.timerUsop.Stop();
      this.btnUsop.Enabled = true;
      this.btnUsopStop.Enabled = false;
      this.labelUsop.ForeColor = Color.Black;
      this.labelUsop.Text = "7:00";
      this.notifyIcon1.ShowBalloonTip(2000, "Зареспавнился босс:", "Командир усопших", ToolTipIcon.Info);
      this.listBoxBossLog.Items.Add((object) (DateTime.Now.ToString("HH:mm:ss") + " Зареспавнился: Командир усопших"));
    }
	
	private void btnUsop_Click(object sender, EventArgs e)
    {
      this.timerUsop = new System.Windows.Forms.Timer();
      this.timerUsop.Tick += new EventHandler(this.timerUsop_Tick);
      this.timerUsop.Start();
      this.timerUsop.Interval = 1000;
      this.btnUsop.Enabled = false;
      this.btnUsopStop.Enabled = true;
      Form1.Usop = 420;
      this.labelUsop.ForeColor = Color.DarkRed;
      this.listBoxBossLog.Items.Add((object) (DateTime.Now.ToString("HH:mm:ss") + " Поставлен таймер: Командир усопших"));
      this.listBoxBossLog.SelectedIndex = this.listBoxBossLog.Items.Count - 1;
      this.listBoxBossLog.SelectedIndex = -1;
    }

    private void btnUsopStop_Click(object sender, EventArgs e)
    {
      this.timerUsop.Stop();
      this.btnUsop.Enabled = true;
      this.btnUsopStop.Enabled = false;
      this.labelUsop.Text = "7:00";
      this.labelUsop.ForeColor = Color.Black;