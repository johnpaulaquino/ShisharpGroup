using BrgyMs.backend.database.repositories;
using BrgyMs.backend.utils;
using BrgyMs.uiDesign;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using BrgyMS.uiDesign.usersDashboard.modals;
using BrgyMS.uiDesign.usersDashboard.secretary_controls;
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


namespace BrgyMS.uiDesign.adminDashboard {
    public partial class AdminDashboardForm : Form {
        private UIAdminUtils uiadmin = new UIAdminUtils();
        private AuthUtils _AuthUtils = new AuthUtils();
        private bool isSlide;

        private BaseServices _BaseServices = new BaseServices();
        private string userId = "";



        public AdminDashboardForm() {
            InitializeComponent();
            string token = _AuthUtils.ReadTokenInFile();
            var user = _AuthUtils.ValidateToken(token);
            userId = user.UserId;
        }



        private void picAccountVerification_Click_1(object sender, EventArgs e) {
            AdminAccountVerification verificationcontrol = new AdminAccountVerification();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(verificationcontrol);
            verificationcontrol.Dock = DockStyle.Fill;
        }

        private void picAccountManagement_Click_1(object sender, EventArgs e) {
            AdminAccountManagementControl accountcontrol = new AdminAccountManagementControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(accountcontrol);
            accountcontrol.Dock = DockStyle.Fill;
        }

        private void picBlotter_Click(object sender, EventArgs e) {
            AdminBlotterControl control = new AdminBlotterControl();

            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(control);

            control.Dock = DockStyle.Fill;
        }
        private void AdminDashboardForm_Load_1(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            uiadmin.SetUserLabel(lblRole, lblUsername);
            pnlMainContentHolder1.Controls.Clear();

            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;


        }

        private void picAnnouncements_Click(object sender, EventArgs e) {
            AdminAnnouncementsControl acnnoucnecontrol = new AdminAnnouncementsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(acnnoucnecontrol);
            acnnoucnecontrol.Dock = DockStyle.Fill;
        }

        private void picOfficials_Click(object sender, EventArgs e) {
            AdminOfficialsManagementControl officialsControl = new AdminOfficialsManagementControl();
            try {
                Cursor = Cursors.WaitCursor;
                pnlMainContentHolder1.Controls.Clear();

                pnlMainContentHolder1.Controls.Add(officialsControl);

                officialsControl.Dock = DockStyle.Fill;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor = Cursors.Default;



            }
        }

        private void picLogs_Click_1(object sender, EventArgs e) {
            AdminUserLogsControl logscontrol = new AdminUserLogsControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(logscontrol);
            logscontrol.Dock = DockStyle.Fill;

        }

        private void picDashboardIcon_Click_1(object sender, EventArgs e) {
            AdminDashboardControl dashcontrol = new AdminDashboardControl();
            pnlMainContentHolder1.Controls.Clear();
            pnlMainContentHolder1.Controls.Add(dashcontrol);
            dashcontrol.Dock = DockStyle.Fill;
        }



        private async void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e) {
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
                this.FormClosing -= AdminDashboardForm_FormClosing;

                this.Close(); // Now close safely
            }
            else {
                e.Cancel = true;
            }
        }

        private void picDashboardIcon_MouseHover(object sender, EventArgs e) {
            picDashboardIcon.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\DashboardIconHover.png");

        }


        private void picMenuButton_MouseHover(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\\Users\\ADMIN\\Desktop\\shisharpmain\\shisharp\\bms\\img\\menuIconHover.png");
        }

        private void picMenuButton_MouseLeave(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\menuIcon.png");

        }


        private void picDashboardIcon_MouseLeave(object sender, EventArgs e) {
            picDashboardIcon.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\DashboardIcon.png");

        }

        private void picAccountManagement_MouseHover(object sender, EventArgs e) {
            picAccountManagement.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\AccManagementIconHover.png");

        }

        private void picAccountManagement_MouseLeave(object sender, EventArgs e) {
            picAccountManagement.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\AccManagementIcon.png");

        }

        private void picLogs_MouseHover(object sender, EventArgs e) {
            picLogs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\logsHoverIcon.png");

        }

        private void picLogs_MouseLeave(object sender, EventArgs e) {
            picLogs.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\logsIcon.png");

        }

        private void picMenuButton_MouseHover_1(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\menuIconHover.png");

        }

        private void picMenuButton_MouseLeave_1(object sender, EventArgs e) {
            picMenuButton.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\menuIcon.png");

        }

        private void picAnnouncements_MouseHover(object sender, EventArgs e) {
            picAnnouncements.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\announcementsHoverIcon.png");

        }

        private void picAnnouncements_MouseLeave(object sender, EventArgs e) {
            picAnnouncements.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\announcementsIcon.png");

        }

        private void picBlotter_MouseHover(object sender, EventArgs e) {
            picBlotter.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\blotterIconHover.png");

        }

        private void picBlotter_MouseLeave(object sender, EventArgs e) {
            picBlotter.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\blotterIcon.png");
        }

        private void picAccountVerification_MouseHover(object sender, EventArgs e) {
            picAccountVerification.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\announcementsHoverIcon.png");
        }

        private void picAccountVerification_MouseLeave(object sender, EventArgs e) {
            picAccountVerification.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\accountVerificationIcon.png");

        }

        private void picOfficials_MouseHover(object sender, EventArgs e) {
            picOfficials.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\OfficialsIvonHover.png");

        }

        private void picOfficials_MouseLeave(object sender, EventArgs e) {
            picOfficials.Image = new Bitmap(@"C:\Users\ADMIN\Desktop\shisharpmain\shisharp\bms\img\OfficialsIcon.png");

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
