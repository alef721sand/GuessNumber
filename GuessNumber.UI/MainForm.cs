using System.Text;
using GuessNumber.App;
using GuessNumber.Interface;


namespace GameNumber.UI
{
    public partial class frMain : Form
    {
        IGameConfig ganeConfig;
        IGameService gameService;

        public frMain()
        {
            InitializeComponent();
            InitApp();
            btnSend.Enabled = false;
            edDigit.Enabled = false;
            btnStop.Enabled = false;
        }

        private void InitApp()
        {
            GameConfig gameConfig = new GameConfig();
            RandomNumberGenerator numberGenerator = new RandomNumberGenerator();
            WinInputOutput consoleIo = new WinInputOutput();
            consoleIo.RegisterHandler(new WinInputOutput.WriteMessage(WriteToOutput), new WinInputOutput.ReadMessage(ReadFromInput));
            gameService = new GameService(numberGenerator, gameConfig,  consoleIo);
            ganeConfig = gameService.GameConfig;
            EnableButtons();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            if (gameService != null && gameService.IsGameFinished)
            {
                gameService.StartNewGame();
                edDigit.Focus();
            }
            EnableButtons();
        }
        private string ReadFromInput()
        {
            return edDigit.Text;
        }
        private void WriteToOutput(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(mLog.Text);
            sb.AppendLine(message);
            mLog.Text = sb.ToString();
            mLog.SelectionStart = 0;
            mLog.SelectionLength = 0;
        }
        private void btSettings_Click(object sender, EventArgs e)
        {
            ChangeSettings();
        }

        private void ChangeSettings()
        {
            SettingsDlg form = new SettingsDlg() { Settings = ganeConfig.Load() };
            if (form.ShowDialog() == DialogResult.OK)
            {
                ganeConfig.Save(form.Settings);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MakeGuess();
        }

        private void MakeGuess()
        {
            gameService.MakeGuess();
            EnableButtons();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void StopGame()
        {
            gameService.StopGame();
            EnableButtons();
        }

        private void EnableButtons()
        {
            var _isfinished = true;
            if (gameService != null)
            {
                _isfinished = gameService.IsGameFinished;
            }

            btnStop.Enabled = !_isfinished;
            btnSend.Enabled = !_isfinished;
            btSettings.Enabled = _isfinished;
            btnStart.Enabled = _isfinished;
            edDigit.Enabled = !_isfinished;
            if (!_isfinished)
            {
                edDigit.Focus();
            }

        }

        private void edDigit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(edDigit.Text))
                {
                    MakeGuess();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    edDigit.Text = "";
                }
                else
                {
                    e.Handled = false;
                }
            }
        }
    }
}
