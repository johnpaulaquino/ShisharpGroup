using BrgyMs.backend.services;
using BrgyMS.backend.services;
using Krypton.Toolkit;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.uiUtils.ui_residents_utils {
    class UIResidentUtils {
        private BaseServices _BaseServices;
        private ResidentServices _ResidentServices;
        public UIResidentUtils() {

        }
        //Get the bytes from picture box
        public byte[] GetBytesFromPictureBox(KryptonPictureBox picture) {
            byte[] bytes = null;
            if (picture != null && picture.Image != null) {
                using (MemoryStream ms = new MemoryStream()) {
                    picture.Image.Save(ms, ImageFormat.Png);
                    bytes = ms.ToArray();
                }

            }
            return bytes;
        }

        public void SetWidthToUsersLogsTable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 50;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 250;
        }

        //users logs
        public async Task SetUserLogsToTable(DataGridView table, string userId) {
            try {

                _ResidentServices = new ResidentServices();

                var dt = new DataTable();

                using (var adapter = await Task.Run(() =>
                {
                    return _ResidentServices.GetUsersLogs(userId);
                }))

                    adapter.Fill(dt);
                table.Columns.Clear();

                table.DataSource = dt;


                SetWidthToUsersLogsTable(table);

                {
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {

            }
        } // end of function


        //set width to the request docs table
        public void SetWidthToRequestDocumentsTable(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 150;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 50;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 150;
        }
        //Set the data int table
        public async Task SetRequestDocumentsControlsTable(DataGridView table,
string userId) {
            try {

                _ResidentServices = new ResidentServices();
                var dt = new DataTable();

                using (var adapter = await Task.Run(() =>
                {
                    return _ResidentServices.GetRequestDocuments(userId);
                })) {
                    adapter.Fill(dt);
                    table.Columns.Clear();

                    table.DataSource = dt;
                }
                SetWidthToRequestDocumentsTable(table);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally {

            }
        } // 

    }
}
