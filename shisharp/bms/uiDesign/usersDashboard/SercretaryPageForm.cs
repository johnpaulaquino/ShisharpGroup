using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.uiDesign.usersDashboard.user_controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using Google.Protobuf.Reflection;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMs.backend.models.base_model;

namespace BrgyMS.uiDesign.usersDashboard {
    public partial class SercretaryPageForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private BaseRepository _BaseRepo = new BaseRepository();
        private ResidentAccountSetting accountcontrol;
        private ResidentDashboardControls dashboard;
        private SecretaryApprovalDocumentsControls docs;
        private SecretaryLogsControl logsControl;
        private SecretaryBlotterControl blotter;
        private SecretaryOfficialsControl officialsControl;
        private string userId = "";
        private Utils utils = new Utils();
        private bool isSlide;


        private BaseServices _BaseServices = new BaseServices();
        public SercretaryPageForm() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);
            userId = user.UserId;

        }


        private void picOfficials_Click_1(object sender, EventArgs e) {
            if (officialsControl == null) {
                officialsControl = new SecretaryOfficialsControl();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(officialsControl);
            officialsControl.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picApprovalDocs_Click_1(object sender, EventArgs e) {
            blotter = new SecretaryBlotterControl();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(blotter);
            blotter.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;

        }

        private void picUserRequestDocs_Click_1(object sender, EventArgs e) {

            if (docs == null) {
                docs = new SecretaryApprovalDocumentsControls();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(docs);
            docs.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserLogs_Click_1(object sender, EventArgs e) {
            if (logsControl == null) {
                logsControl = new SecretaryLogsControl();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(logsControl);
            logsControl.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picUserAccountManagement_Click_1(object sender, EventArgs e) {
            if (accountcontrol == null) {
                accountcontrol = new ResidentAccountSetting();
            }
            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;

        }

        private void picUserDashboardIcon_Click_1(object sender, EventArgs e) {

            AdminDashboardControl control = new AdminDashboardControl();

            Cursor = Cursors.WaitCursor;
            pnlMainContentHolder.Controls.Clear();
            pnlMainContentHolder.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            Cursor = Cursors.Default;
        }

        private void picLogout_Click_1(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Are you sure you want to logout?", "Logout",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {
                this.Hide();
                _AuthUtils.DeleteTokeAfterLogoutOrCloseTheFrom();
                LoginForm login = new LoginForm();
                login.Owner = this;
                login.Show();
            }
        }

        private async void SercretaryPageForm_FormClosing(object sender, FormClosingEventArgs e) {
            var option = MessageBox.Show("Are you sure you wan to logout?", "Logout",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {

                string logsId = await _BaseServices.GenerateLogsId();

                Logs logs = new Logs(logsId, userId, "Logout")
                {
                    DatePerformed = DateTime.Now,
                    Details = $"Logout user."
                };

                await Task.Run(async () =>
                {
                    await _BaseServices.LogUserActions(logs);

                });
                _AuthUtils.DeleteTokeAfterLogoutOrCloseTheFrom();
                LoginForm login = new LoginForm();

                login.Show();
                this.FormClosing -= SercretaryPageForm_FormClosing;

                this.Close(); // Now close safely
            }

            else {
                e.Cancel = true;
            }
        }

        private void SercretaryPageForm_Load(object sender, EventArgs e) {

            Invoke(new Action(() =>
            {
                string token = _AuthUtils.ReadTokenInFile();
                User user = _AuthUtils.ValidateToken(token);

                string role = utils.FormatRoles(user.Role);

                lblRole.Text = role;
                lblUsername.Text = "Hi, " + user.Username;

                AdminDashboardControl control = new AdminDashboardControl();

                Cursor = Cursors.WaitCursor;
                pnlMainContentHolder.Controls.Clear();
                pnlMainContentHolder.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                Cursor = Cursors.Default;
            }));
        }

        private void picMenuButton_MouseHover(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\\Users\\ADMIN\\Desktop\\shisharpmain\\shisharp\\bms\\img\\menuIconHover.png");

        }

        private void picMenuButton_MouseLeave(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\menuIcon.png");

        }


        private void picUserLogs_MouseHover_1(object sender, EventArgs e) {
            picUserLogs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\logsHoverIcon.png");

        }

        private void picUserLogs_MouseLeave_1(object sender, EventArgs e) {
            picUserLogs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\logsIcon.png");

        }

        private void picUserRequestDocs_MouseHover_1(object sender, EventArgs e) {
            picUserRequestDocs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\RequestDocsIconHover.png");

        }

        private void picUserRequestDocs_MouseLeave_1(object sender, EventArgs e) {
            picUserRequestDocs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\RequestDocsIcon.png");

        }

        private void picApprovalDocs_MouseHover(object sender, EventArgs e) {
            picApprovalDocs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\blotterIconHover.png");

        }

        private void picApprovalDocs_DragLeave(object sender, EventArgs e) {

        }

        private void picApprovalDocs_MouseLeave(object sender, EventArgs e) {
            picApprovalDocs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\blotterIcon.png");

        }

        private void picOfficials_MouseHover(object sender, EventArgs e) {
            picOfficials.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\OfficialsIvonHover.png");

        }

        private void picOfficials_MouseLeave(object sender, EventArgs e) {
            picOfficials.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\OfficialsIcon.png");

        }

        private void picUserDashboardIcon_MouseHover_1(object sender, EventArgs e) {
            picUserDashboardIcon.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\DashboardIconHover.png");
        }

        private void picUserDashboardIcon_MouseLeave_1(object sender, EventArgs e) {
            picUserDashboardIcon.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\DashboardIcon.png");


        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (isSlide) {
                pnlSidebar.Width -= 157;
                if (pnlSidebar.Width == pnlSidebar.MinimumSize.Width) {
                    isSlide = false;
                    timer1.Stop();
                }

            }
            else {
                pnlSidebar.Width += 157;
                if (pnlSidebar.Width == pnlSidebar.MaximumSize.Width) {
                    isSlide = true;
                    timer1.Stop();

                }
            }
        }

        private void picMenuButton_Click(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}

