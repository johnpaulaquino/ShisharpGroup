using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrgyMS.uiDesign.uiUtils.uiAdminUtils {
    class UIAdminUtils {

        public UIAdminUtils() {

        }
        public void setAdminDashboardTableWitdth(DataGridView dataGridView) {
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 200;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 200;
            dataGridView.Columns[7].Width = 100;
            dataGridView.Columns[8].Width = 200;
            dataGridView.Columns[9].Width = 200;
        }

    }
}
