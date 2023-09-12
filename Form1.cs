using System.Text;

namespace AppConversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos CSV e TXT|*.csv;*.txt|Arquivos CSV|*.csv|Arquivos de Texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }


        private void Gerar_Click(object sender, EventArgs e)
        {
            string inputFilePath = textBox1.Text;

            if (string.IsNullOrEmpty(inputFilePath) || !File.Exists(inputFilePath))
            {
                MessageBox.Show("Selecione um arquivo de texto válido antes de iniciar a conversão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               string inputText = File.ReadAllText(inputFilePath, Encoding.GetEncoding("ISO-8859-1"));


                // Separe as credenciais e os funcionários
                string credenciaisText = SepararCredenciais(inputText);
                string funcionariosText = SepararFuncionarios(inputText);

                // Obtenha o caminho da área de trabalho
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Defina o nome dos arquivos de saída para serem salvos na área de trabalho
                string outputCredenciaisPath = Path.Combine(desktopPath, "credenciais.ALL");
                string outputFuncionariosPath = Path.Combine(desktopPath, "funcionarios.ALL");


                // Salve os textos em arquivos separados
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "ALL Files|*.ALL";
                saveDialog.Title = "Salvar Credenciais";
                saveDialog.FileName = "credenciais.ALL";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, credenciaisText);
                }

                saveDialog.Title = "Salvar Funcionários";
                saveDialog.FileName = "funcionarios.ALL";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, funcionariosText);
                }


                // Adicione o conteúdo aos TextBoxes
                textBox2.Text = outputCredenciaisPath;
                File.WriteAllText(saveDialog.FileName, funcionariosText, Encoding.GetEncoding("ISO-8859-1"));
                textBox3.Text = saveDialog.FileName;



                MessageBox.Show("Conversão concluída e separação realizada.", "Conversão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a conversão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SepararCredenciais(string inputText)
        {
            if (string.IsNullOrWhiteSpace(inputText))
            {
                return string.Empty;
            }

            string[] lines = inputText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> credenciais = new List<string>();

            foreach (string line in lines)
            {
                try
                {
                    // Preencher da coluna 1 até a coluna 15 com 0
                    string prefix = new string('0', 14);

                    // Pegar matrícula da coluna 1 até a coluna 6
                    string matricula = line.Substring(0, 6);

                    // Na coluna 7, colocar um 0
                    string zeroCol7 = "0";

                    // Pegar credenciais da coluna 21 até a coluna 32
                    string credencialPart = line.Substring(20, 12);

                    // Concatenar tudo e finalizar com 00
                    string credencial = prefix + matricula + zeroCol7 + credencialPart + "0";

                    credenciais.Add(credencial);
                }
                catch (ArgumentOutOfRangeException)
                {
                    continue;
                }
            }

            // Ajuste no formato das credenciais
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " 005");
            sb.AppendLine("0");





            foreach (var credencial in credenciais)
            {
                sb.AppendLine(credencial);
            }

            return sb.ToString();
        }

        private string SepararFuncionarios(string inputText)
        {
            if (string.IsNullOrWhiteSpace(inputText))
            {
                return string.Empty;
            }

            string[] lines = inputText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> funcionarios = new List<string>();

            foreach (string line in lines)
            {
                if (line.Length > 20)
                {
                    string firstSegment = line.Substring(20, 17); // de 20 até 36 (17 caracteres)
                    string secondSegment = "";
                    string thirdSegment = "";

                    if (line.Length > 45) // Se houver caracteres após a coluna 45
                    {
                        secondSegment = line.Substring(45, Math.Min(50, line.Length - 45)); // de 46 até 96 (máximo de 51 caracteres)
                    }

                    if (line.Length > 125) // Se houver caracteres após a coluna 122
                    {
                        thirdSegment = line.Substring(125); // de 123 até o final
                    }

                    string funcionario = "0" + (firstSegment + secondSegment + thirdSegment).TrimEnd();
                    funcionarios.Add(funcionario);

                }
            }



            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " 002");




            foreach (var funcionario in funcionarios)
            {
                sb.AppendLine(funcionario);
            }

            return sb.ToString();
        }





    }
}
