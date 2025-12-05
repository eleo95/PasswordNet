using PasswordNet.Services;

namespace PasswordNet
{
    public partial class Form1 : Form
    {

        private readonly ICharactersTypePicker _charactersTypePicker;
        private readonly IPasswordGenerator _passwordGenerator;
        public Form1()
        {
            InitializeComponent();

            _charactersTypePicker = new CharactersTypePicker();
            _passwordGenerator = new PasswordGenerator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var characterSet = _charactersTypePicker.GetCharacters(
                    checkLower.Checked,
                    checkUpper.Checked,
                    checkNumbers.Checked,
                    checkSymbols.Checked
                );

                int length = (int) inputSize.Value;

                string password = _passwordGenerator.Generate(length, characterSet);

                textResult.Text = password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
