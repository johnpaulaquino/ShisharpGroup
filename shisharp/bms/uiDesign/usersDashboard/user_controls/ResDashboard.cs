using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.models;
using BrgyMS.backend.services;
using BrgyMS.uiDesign.adminDashboard.modals;
using BrgyMS.uiDesign.adminDashboard.modals.modals_controls;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions;


namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    public partial class ResDashboard : UserControl {
        private string userId = "";
        private Utils utils = new Utils();
        private AccountSettingsDataHolderController data;
        private ResidentServices _Services = new ResidentServices();
        public ResDashboard() {
            InitializeComponent();
            userId = utils.ReadIdInFile();


        }
        private async void ResDashboard_Load(object sender, EventArgs e) {
            await SetAnnouncementsData();
            await SetOfficialsDataInTable();
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

        } // end
        public async Task SetAnnouncementsData() {
            try {
                List<AnnouncementsModel> data = await _Services.GetAnnouncement();
                Cursor = Cursors.WaitCursor;

                await Task.Run(async () =>
                {
                    foreach (AnnouncementsModel item in data) {
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
                });
            }
            catch (Exception ex) {
                throw;

            }
            finally {
                Cursor = Cursors.Default;
            }

        }
    }
}
