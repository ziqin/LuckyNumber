using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WFApp
{
    public partial class MainWin : Form
    {
        private Random rand;
        private Timer isPlaying;
        private string lastInput;
        private int range;
        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
                lastInput = value.ToString();
                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var setting = config.AppSettings.Settings;
                    if (setting["range"] == null)
                        setting.Add("range", lastInput);
                    else
                        setting["range"].Value = lastInput;
                    config.Save(ConfigurationSaveMode.Modified);
                }
                catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error occurred while writing app setting");
                }
            }
        }

        public MainWin()
        {
            InitializeComponent();
            try
            {
                rangeInput.Text = ConfigurationManager.AppSettings["range"] ?? "50";
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error occurred while reading app setting");
            }
            rand = new Random();
            isPlaying = new Timer();
            isPlaying.Interval = 25;
            isPlaying.Tick += UpdateNum;
        }

        private void Start(object sender, EventArgs e)
        {
            if (rangeInput.Text == "")
            {
                MessageBox.Show(
                    owner: this,
                    text: "人数不能为空",
                    caption: "不对劲儿",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK
                    );
                return;
            }

            isPlaying.Enabled = !isPlaying.Enabled;
            if (isPlaying.Enabled)
            {
                startButton.Text = "停止";
                rangeInput.Enabled = false;
            }
            else
            {
                startButton.Text = "再抽";
                rangeInput.Enabled = true;
            }
        }

        private void UpdateNum(object sender, EventArgs e)
        {
            numShow.Text = rand.Next(1, Range + 1).ToString();
        }

        private void rangeInput_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(rangeInput.Text, @"^[0-9]*$"))
            {
                int inputNum;
                if (int.TryParse(rangeInput.Text, out inputNum))
                    Range = inputNum;
            }
            else
            {
                rangeInput.Text = lastInput;
                rangeInput.SelectionStart = lastInput.Length;
            }
        }
    }
}
