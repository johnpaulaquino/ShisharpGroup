using BrgyMs.backend.database.repositories;
using BrgyMs.backend.models.base_model;
using BrgyMs.backend.models.bo_model;
using BrgyMs.backend.utils;
using BrgyMS.uiDesign.uiUtils.uiAdminUtils;
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

namespace shisharp.bms.uiDesign.usersDashboard.user_controls {
    public partial class OfficialsInfoModal : Form {
        private BaseRepository _BaseRepository = new BaseRepository();
        private Utils utils = new Utils();
        private UIAdminUtils uiadmin = new UIAdminUtils();
        public OfficialsInfoModal() {
            InitializeComponent();
        }

        private async void OfficialsInfoModal_Load(object sender, EventArgs e) {
            try {
                string userid = utils.ReadIdInFile();
                List<object> data = await _BaseRepository.GetOfficiaslInformation(userid);


                User user = (User)data[0];
                PersonalInformation personal = (PersonalInformation)data[1];

                AdditionalInfo addInfo = (AdditionalInfo)data[2];

                Address address = (Address)data[3];
                OfficialsInfo officialsIn = (OfficialsInfo)data[4];


                string fullname = utils.FormatFullname(personal.Firstname, personal.Middlename, personal.Lastname, personal.Suffix);

                string addres = utils.FormatAddress(address);

                txtAddress.Text = addres;
                txtEmail.Text = user.Email;
                txtPosition.Text = officialsIn.Position;
                txtxFullname.Text = fullname;
                using (MemoryStream memory = new MemoryStream(addInfo.ProfileImage)) {
                    picProfile.Image = new Bitmap(memory);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e) {

        }
    }
}
