using System;
using System.Windows.Forms;

namespace SimpleTimer
{
    public partial class SimpleTimer : Form
    {
        readonly static int LAST_MIN_VAL = 59, LAST_SEC_VAL = 59;
        readonly static int FIRST_MIN_VAL = -1, FIRST_SEC_VAL = -1;

        int hh, mm, ss;
        int idJob = 0;
        int loopCount = 1;

        /// TODO : New Feature  => Edit data in list view
        /// TODO : New Feature  => Multiple selected in list view (to play countdown)
        /// TODO : Refactor     => Break the function
        /// TODO : Optional   => Remove extention File path
        public SimpleTimer()
        {
            InitializeComponent();
        }

        private void SimpleTimer_Load(object sender, EventArgs e)
        {
            Timer.Stop();
            SetDefaultStartApp();
        }

        private void SetDefaultStartApp()
        {
            InitiateInputListSet();
            SetButtonPlayGroup(false, false, false);
            SetLoopInput(false, false);
            Clock.Start();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (TimerListView.Items.Count == 0) return;
            Timer.Start();
            SetStartTimeGroup(SetDifferentTimeLabel(StartTimePicker.Value, DateTime.Now), false, true);
            SetButtonPlayGroup(false, true, true);
            SetButtonAddGroup(false, false, false);
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            SetButtonPlayGroup(true, false, true);
            SetButtonAddGroup(true, true, true);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            ResetValue();
            SetStartTimeGroup(SetClockLabel(0, 0, 0), true, false);
            SetButtonPlayGroup(true, false, true);
            SetButtonAddGroup(true, true, true);
        }

        private void AddTimerBtn_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateTimerValue((int)HHUpDown.Value, (int)MMUpDown.Value, (int)SSUpDown.Value)) return;

            AddNewTimerToListView();
            if(TimerListView.Items.Count == 1) SetClockTimerByListId(0);
            SetButtonPlayGroup(true, false, true);
        }

        private void RemoveTimerBtn_Click(object sender, EventArgs e)
        {
            RemoveSelectedItemList();

            // still left timer list
            if (TimerListView.Items.Count > 0)
            {
                SetClockTimerByListId(0);
            }
            else
            {
                SetTimerLabelToDefault();
                SetButtonPlayGroup(false, false, false);
            }
        }

        private void ClearListBtn_Click(object sender, EventArgs e)
        {
            TimerListView.Items.Clear();
            SetTimerLabel(0, 0, 0);
            SetButtonPlayGroup(false, false, false);
        }

        private void LoopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LoopCheckBox.Checked) LoopUpDown.Enabled = true;
            else LoopUpDown.Enabled = false;
        }

        private void LoopUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LoopCheckBox.Checked) loopCount = Convert.ToInt32(LoopUpDown.Value);
            else loopCount = 1;
        }

        private void StartTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StartTimePicker.Enabled = StartTimeCheckBox.Checked;
            DateTime now = DateTime.Now;
            this.StartTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            ClockLable.Text = SetClockLabel(now.Hour, now.Minute, now.Second);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime startTimePicker = StartTimePicker.Value;
            if (!StartTimeCheckBox.Checked || IsSameTime(startTimePicker, now))
            {
                PlayTimer();
            }
            else
            {
                StartTimeLabel.Text = now > startTimePicker ? SetClockLabel(0, 0, 0) : SetDifferentTimeLabel(startTimePicker, now);
            }
        }

        private string SetDifferentTimeLabel(DateTime mainTime, DateTime subtractTime)
        {
            TimeSpan timeDifferent = mainTime - subtractTime;
            int hh = timeDifferent.Hours;
            int mm = timeDifferent.Minutes;
            int ss = timeDifferent.Seconds;
            return SetClockLabel(hh, mm, ss);
        }

        private string SetClockLabel(int hh, int mm, int ss)
        {
            return hh.ToString("00") + " : " + mm.ToString("00") + " : " + ss.ToString("00");
        }

        private void PlayTimer()
        {
            if (hh == 0 && mm == 0 && ss == FIRST_SEC_VAL)
            {
                new BeepSoundService().PlayHighBeep();
                if (IsLastJob())
                {
                    idJob = 0;
                    if (loopCount == 1)
                    {
                        Timer.Stop();
                        ResetValue();
                        SetButtonPlayGroup(true, false, true);
                        SetButtonAddGroup(true, true, true);
                        return;
                    }
                    else
                    {
                        loopCount--;
                    }
                }
                else
                {
                    idJob++;
                }
                SetTimerToListId(idJob);
            }
            else if (hh > 0 && mm == FIRST_MIN_VAL && ss == FIRST_SEC_VAL) SetClockTimer(--hh, LAST_MIN_VAL, LAST_SEC_VAL);
            else if (mm > 0 && ss == FIRST_SEC_VAL) SetClockTimer(hh, --mm, LAST_SEC_VAL);

            LoopCountLabel.Text = "Loop left : " + loopCount.ToString();
            SetTimerLabel(hh, mm, ss--);
            new BeepSoundService().PlayCountDownSecond(hh, mm, ss, 3);
        }

        private bool IsSameTime(DateTime dateTimePicker, DateTime dateTimeNow)
        {

            return StartTimeCheckBox.Checked && dateTimePicker.Hour <= dateTimeNow.Hour && dateTimePicker.Minute <= dateTimeNow.Minute && dateTimePicker.Second <= dateTimeNow.Second;
        }

        private bool IsLastJob()
        {
            return TimerListView.Items.Count - 1 == idJob;
        }

        private void ResetValue()
        {
            idJob = 0;
            SetClockTimerByListId(0);
            SetLoopCountByInput(LoopCheckBox.Checked);
            SetStartTimeGroup(SetClockLabel(0, 0, 0), false, false);
        }

        private void AddNewTimerToListView()
        {
            ListViewItem timerListView = new ListViewItem(JobNameBox.Text);
            timerListView.SubItems.Add(HHUpDown.Value.ToString());
            timerListView.SubItems.Add(MMUpDown.Value.ToString());
            timerListView.SubItems.Add(SSUpDown.Value.ToString());
            TimerListView.Items.Add(timerListView);
        }

        private void RemoveSelectedItemList()
        {
            try
            { 
                TimerListView.Items.Remove(TimerListView.SelectedItems[0]); 
            }
            catch { }
        }

        private void SetClockTimerByListId(int idList)
        {
            SetTimerToListId(idList);
            SetTimerLabel(hh, mm, ss);
        }

        private void SetTimerLabelToDefault()
        {
            SetClockTimer(0, 0, 0);
            SetTimerLabel(hh, mm, ss);
        }

        private void SetTimerLabel(int hh, int mm, int ss)
        {
            TimerLabel.Text = String.Format("{0} : {1} : {2}", hh.ToString("00"), mm.ToString("00"), ss.ToString("00"));
        }

        private void SetTimerToListId(int id)
        {
            ListViewItem timerListView = TimerListView.Items[id];
            JobLabel.Text = timerListView.SubItems[0].Text;
            SetClockTimer(Convert.ToInt32(timerListView.SubItems[1].Text), Convert.ToInt32(timerListView.SubItems[2].Text), Convert.ToInt32(timerListView.SubItems[3].Text));
        }

        private void SetClockTimer(int hour, int minute, int second)
        {
            ss = second;
            mm = minute;
            hh = hour;
        }

        private void InitiateInputListSet()
        {
            JobNameBox.Text = "Job";
            HHUpDown.Value = 0;
            MMUpDown.Value = 0;
            SSUpDown.Value = 0;
        }

        private void SetStartTimeGroup(string startTimeLeft, bool startTimePickerEnable, bool startTimeCheckBoxEnable)
        {
            StartTimeLabel.Text = startTimeLeft;
            StartTimeCheckBox.Checked = startTimeCheckBoxEnable;
            StartTimePicker.Enabled = startTimePickerEnable;
        }

        private void SetButtonPlayGroup(bool startEnable, bool pauseEnable, bool resetEnable)
        {
            StartBtn.Enabled = startEnable;
            PauseBtn.Enabled = pauseEnable;
            ResetBtn.Enabled = resetEnable;
        }

        private void SetButtonAddGroup(bool addEnable, bool removeEnable, bool clearEnable)
        {
            AddTimerBtn.Enabled = addEnable;
            RemoveListBtn.Enabled = removeEnable;
            ClearListBtn.Enabled = clearEnable;
        }

        private void SetLoopCountByInput(bool loopCheckBox)
        {
            loopCount = loopCheckBox ? Convert.ToInt32(LoopUpDown.Value) : 1;
            LoopCountLabel.Text = "Loop left :" + loopCount.ToString();
        }

        private void SetLoopInput(bool checkBoxEnable, bool inputValueEnable)
        {
            LoopCheckBox.Checked = checkBoxEnable;
            LoopUpDown.Enabled = inputValueEnable;
            LoopCountLabel.Text = "Loop left : 1";
        }

    }
}
