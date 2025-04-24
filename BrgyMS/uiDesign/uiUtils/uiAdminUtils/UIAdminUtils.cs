using BrgyMs.backend.database.repositories;
using BrgyMs.backend.services;
using BrgyMs.backend.utils;
using BrgyMS.backend.database.connection.models;
using Google.Protobuf.Compiler;
using Krypton.Toolkit;
using Microsoft.VisualBasic.Devices;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.uiUtils.uiAdminUtils {
    class UIAdminUtils {
        private readonly AuthUtils _AuthUtils = new AuthUtils();
        private AdminServices _AdminServices = new AdminServices();
        private readonly AdminRepository _admin = new AdminRepository();
        private readonly Utils utils = new Utils();
        public UIAdminUtils() {


        }
        public void setAdminDashboardTableWitdth(DataGridView dataGridView) {


            dataGridView.Columns["id"].Width = 100;
            dataGridView.Columns["colemail"].Width = 200;
            dataGridView.Columns["colrole"].Width = 100;
            dataGridView.Columns["colfullname"].Width = 200;
            dataGridView.Columns["colgender"].Width = 100;
            dataGridView.Columns["colbday"].Width = 200;
            dataGridView.Columns["colage"].Width = 50;
            dataGridView.Columns["colcontact"].Width = 150;
            dataGridView.Columns["colrtype"].Width = 150;
        }

        public void SetUserInformation(KryptonLabel lblRole,
            KryptonLabel lblusername) {
            string token = _AuthUtils.ReadTokenInFile();
            var principal = _AuthUtils.ValidateToken(token);
            if (principal != null) {
                string? username = principal.FindFirst("username")?.Value;
                string? userId = principal.FindFirst("userId")?.Value;
                string? role = principal.FindFirst(ClaimTypes.Role)?.Value;
                string? roleInit = role?.ToUpper();
                lblRole.Text = roleInit?[0] + role?.Substring(1);
                lblusername.Text = "Hi, " + username;
            }
        }
        public async void SetUserAndSecInfo(DataGridView table, int limit, string search) {
            try {


                List<GetUserInformationResult> userInfo = await _AdminServices.GetUserInformation(limit);
                var rows = new List<DataGridViewRow>();

                if (userInfo != null) {

                    table.SuspendLayout();
                    table.Rows.Clear();
                    foreach (var item in userInfo) {
                        string fullname = utils.FormatFullname(item.Firstname,
                            item.Middelanme, item.Lastname, item.Suffix);

                        string bday = utils.FormatDate(item.BirthDate);

                        string role = utils.FormatRoles(item.Role);

                        //table.Rows.Add(item.Id,
                        //    item.Email,
                        //    role,
                        //    fullname,
                        //    item.Gender,
                        //    bday,
                        //    item.Age,
                        //    item.ContactNo,
                        //    item.ResidentType);
                      
                        var row = new DataGridViewRow();
                        row.CreateCells(table, item.Id,
                            item.Email,
                            role, fullname,
                            item.Gender,
                            bday,
                            item.Age, item.ContactNo, item.ResidentType
                            );
                        rows.Add(row);
                    }
                    table.Rows.Clear();
                    table.Rows.AddRange(rows.ToArray());
                }
            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                table.ResumeLayout();
            }
        }


        public async void SearchRecords(DataGridView table, int limit, string keyword) {
            try {
                var rows = new List<DataGridViewRow>();

                List<GetUserInformationResult> userInfo = await _AdminServices.GetUserInformation(limit, keyword);
                if (userInfo != null) {
                    table.SuspendLayout();
                    table.Rows.Clear();
                    if (!string.IsNullOrEmpty(keyword)) {
                        foreach (var item in userInfo) {
                            string fullname = utils.FormatFullname(item.Firstname,
                                item.Middelanme, item.Lastname, item.Suffix);
                            string bday = utils.FormatDate(item.BirthDate);
                            string role = utils.FormatRoles(item.Role);

                            //table.Rows.Add(item.Id,
                            //    item.Email,
                            //    role,
                            //    fullname,
                            //    item.Gender,
                            //    bday,
                            //    item.Age,
                            //    item.ContactNo,
                            //    item.ResidentType);
                            var row = new DataGridViewRow();
                            row.CreateCells(table, item.Id, item.Email, role
                                , fullname,
                                item.Gender,
                                bday,
                                item.Age, item.ContactNo, item.ResidentType
                                );
                            rows.Add(row);
                        }
                        table.Rows.Clear();
                        table.Rows.AddRange(rows.ToArray());
                    }

                }
            }
            catch (System.Exception e) {
                MessageBox.Show(e.Message);
            }
            finally {
                table.ResumeLayout();
            }

        }
    }
}
