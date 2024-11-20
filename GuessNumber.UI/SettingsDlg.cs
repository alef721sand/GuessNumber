using GuessNumber.Domain;

namespace GameNumber.UI
{
    public partial class SettingsDlg : Form
    {
        private GameSettings _settings;
        private string errorStr = "";

        internal GameSettings Settings
        {
            get
            { 
                return _settings; 
            }
            set
            {
                _settings = value;
                edMax.Text = _settings.MaxNumber.ToString();
                edMin.Text = _settings.MinNumber.ToString();
                edGuessCount.Text = _settings.MaxAttempts.ToString();
            }
        }

        public SettingsDlg()
        {
            InitializeComponent();
        }

        private void edGuessCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edSave_Click(object sender, System.EventArgs e)
        {
            if (CanCloseDialog())
            {
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
            else
            {
                MessageBox.Show(errorStr);
                errorStr = "";
            }
        }

        private bool CanCloseDialog()
        {
            bool rc = false;
            errorStr = "";
            if (_settings != null)
            {
                Int32.TryParse(edMax.Text, out int max_value);
                Int32.TryParse(edMin.Text, out int min_value);
                Int32.TryParse(edGuessCount.Text, out int count_value);
                if (max_value <= min_value)
                    errorStr = "Максимальное число должно быть больше минимального.";
                else if (count_value <= 0)
                    errorStr = "Число попыток долно быть больше ноля.";
                rc = string.IsNullOrEmpty(errorStr);
                if (rc)
                {
                    _settings.MinNumber= min_value;
                    _settings.MaxNumber= max_value;
                    _settings.MaxAttempts = count_value;
                }
            }
            return rc;
        }
    }
}
