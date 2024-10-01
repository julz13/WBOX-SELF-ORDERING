using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WBOX_SELF_ORDERING.Helpers;
using WBOX_SELF_ORDERING.User_Control;

namespace WBOX_SELF_ORDERING.Models
{
    public class GlobalVar
    {
        public static SettingsWriter _settings = new SettingsWriter(Path.Combine(Application.StartupPath, "Settings"), false);
        public static Configuration _systemConfig = new Configuration();
        static string server, database, uname, pword, request, wbox, wpass, location, connectionString = null;
        public static void InitializeConfiguration()
        {
            _systemConfig = _settings.Read<Configuration>("Configuration");
            if (_systemConfig != null)
            {
                server = _systemConfig.server.Trim().ToString();
                database = _systemConfig.database.Trim().ToString();
                uname = _systemConfig.username.Trim().ToString();
                pword = _systemConfig.password.Trim().ToString();
                request = _systemConfig.Request.Trim().ToString();
                wbox = _systemConfig.WBOX.Trim().ToString();
                wpass = _systemConfig.Wpass.Trim().ToString();

                connectionString = $"server={server};database={database};uid={uname};pwd={pword};";
            }
        }

        public static string Connect { get => connectionString; set => connectionString = value.ToString(); }
        public static string Server { get => server; set => server = value.ToString(); }
        public static string Database { get => database; set => database = value.ToString(); }
        public static string Username { get => uname; set => uname = value.ToString(); }
        public static string Password { get => pword; set => pword = value.ToString(); }
        public static string Data { get => wbox; set => wbox = value.ToString(); }
        public static string wPass { get => wpass; set => value.ToString(); }
        public static string Request { get => request; set => request = value.ToString(); }
        public static string Location { get => location; set => location = value.ToString(); }

        // button clear
        public static void ModalClearAll() {
            Form formbackground = new Form();
            try
            {
                using (FrmClearAll clearAll = new FrmClearAll())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .50d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = new Point(0, 0);
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    clearAll.Owner = formbackground;
                    clearAll.ShowDialog();

                    formbackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbackground.Dispose();
            }
        }
        public static void DisplayOrders()
        {
            Form formbackground = new Form();
            try
            {
                using (FrmOrderList clearAll = new FrmOrderList())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .50d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = new Point(0, 0);
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    clearAll.Owner = formbackground;
                    clearAll.ShowDialog();

                    formbackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbackground.Dispose();
            }
        }

        public static void NoitemClear() {
            Form formbackground = new Form();
            try {
                using (FrmNoItem clearAll = new FrmNoItem()) {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .50d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = new Point(0, 0);
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    clearAll.Owner = formbackground;
                    clearAll.ShowDialog();

                    formbackground.Dispose();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                formbackground.Dispose();
            }
        }
    }
}
