using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WEB_BLOCKER
{
    public partial class FrmMain : Form
    {
        #region GUITweaks
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private const string PATTERN = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
        private const string HOSTPATH = @"C:\WINDOWS\system32\drivers\etc\hosts";

        private readonly string AppName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        private readonly string[] prefixes = new string[5]
        {
            "http://www.", "https://www.", "http://", "https://", "www."
        };

        public FrmMain()
        {
            InitializeComponent();
        }

        private bool IsValidURL(string URL)
        {
            var Rgx = new Regex(PATTERN, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(URL);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si esta es la primera vez que utiliza el programa haga una copia de seguridad para una recuperación, si se presenta el caso.",
                AppName, MessageBoxButtons.OK);

            if (File.Exists(HOSTPATH))
            {
                using (var reader = new StreamReader(HOSTPATH))
                {
                    var hostfile = reader.ReadToEnd();
                    tbHosts.Text = hostfile;

                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter(HOSTPATH))
            {
                writer.WriteLine(tbHosts.Text);
                writer.Close();
            }

            MessageBox.Show(this, "Cambios aplicados.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            var sav = new SaveFileDialog
            {
                Title = "Guardar Como",
                Filter = "Documento Texto|*.txt",
                DefaultExt = "txt"
            };

            if (sav.ShowDialog() == DialogResult.OK)
            {
                {
                    tbHosts.SaveFile(sav.FileName, RichTextBoxStreamType.UnicodePlainText);
                    Text = sav.FileName;
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            var help = new FrmHelp();
            help.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPage.Text))
            {
                MessageBox.Show(this, "Por favor ingrese una URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (!IsValidURL(tbPage.Text))
            {
                MessageBox.Show(this, "URL no valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var site = prefixes.Where(dom => tbPage.Text.StartsWith(dom)).Any() ? tbPage.Text.Replace(prefixes.Where(st => tbPage.Text.StartsWith(st)).FirstOrDefault(), string.Empty) : tbPage.Text;

            using (var writer = new StreamWriter(HOSTPATH))
            {
                writer.WriteLine(tbHosts.Text + $"\n127.0.0.1       {site}\n127.0.0.1       www.{site}");
                writer.Close();

                using (var refresh = new StreamReader(HOSTPATH))
                {
                    tbHosts.Text = refresh.ReadToEnd();
                    refresh.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
