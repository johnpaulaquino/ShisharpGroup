using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using shisharp.bms.uiDesign.usersDashboard.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class ResidentDashboardControls : UserControl {
        private ResidentServices _Services = new ResidentServices();
        private Utils utils = new Utils();
        private AuthUtils _AuthUtils = new AuthUtils();
        List<AnnouncementsModel> data = new List<AnnouncementsModel>();
        private int index = 0;
        public ResidentDashboardControls() {
            InitializeComponent();
        }
        public async Task SetAnnouncementsData() {

            data = await _Services.GetAnnouncement();
            timerAnnouncementsContent.Enabled = true;
        }

        private async void ResidentDashboardControls_Load(object sender, EventArgs e) {


            await SetAnnouncementsData();
            await SetOfficialsDataInTable();


        }

        private void timerAnnouncementLabel_Tick(object sender, EventArgs e) {

        }

        public async Task SetOfficialsDataInTable() {
            try {
                Cursor = Cursors.WaitCursor;

                var dt = await Task.Run(async () =>
                {
                    return await _Services.GetOFficialsInfo();
                });

                dataGridResidentDash.Columns.Clear();
                dataGridResidentDash.DataSource = dt;

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                Cursor = Cursors.Default;
            }

        }

        private void viewOfficialToolStripMenuItem_Click(object sender, EventArgs e) {
            OfficialsInfoModal modal = new OfficialsInfoModal();

            modal.ShowDialog();

        }
        private void dataGridResidentDash_MouseDown_1(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                var hit = dataGridResidentDash.HitTest(e.X, e.Y); // get the location where clicked
                if (hit.RowIndex > 0) {


                    dataGridResidentDash.ClearSelection();
                    dataGridResidentDash.Rows[hit.RowIndex].Selected = true; // set selection where the mouse clicked

                    string userId = dataGridResidentDash.Rows[hit.RowIndex].Cells[0].Value?.ToString();
                    try {
                        utils.PutIdOnFile(userId);

                        //show the context
                        ctxOFficialsInfo.Show(dataGridResidentDash, dataGridResidentDash.PointToScreen(e.Location));

                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void timerAnnouncementsContent_Tick(object sender, EventArgs e) {

            AnnouncementsModel item = (AnnouncementsModel)data[index];
            if (index >= data.Count - 1) {
                index = 0;
            }
            else {
                index += 1;
            }
            string dateInDB = item.DatePost.ToString("dddd, MMMM dd-yyyy hh:mm:ss tt");
            string dt = dateInDB.Split('-')[0].ToString();
            string tim = dateInDB.Split('-')[1].ToString();
            string dateFormtted = $"Posted on \n{dt} \nat {tim}.";
            lblTitle.Text = item.Title;
            lblDetails.Text = item.Details;
            lblDatePost.Text = dateFormtted;
            using (MemoryStream stream = new MemoryStream(item.Attachments)) {
                picAttachements.Image = new Bitmap(stream);

            }

        }
    }
}
