using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace KH_GuiTK
{
    public partial class FormTimKiem : Form
    {
        private List<NguoiGui> list = new List<NguoiGui>();
        private NguoiGui nguoiguii;

        public FormTimKiem()
        {
            InitializeComponent();
        }
       public FormTimKiem(NguoiGui nguoiguii)
        {
            InitializeComponent();
            this.nguoiguii = nguoiguii;
        }
        public FormTimKiem(object list)
        {
            InitializeComponent();
            this.list = (List<NguoiGui>)list;
        }
        private void btnTimKiem_Click(object sender, System.EventArgs e)
        {
            foreach (NguoiGui gui in list)
            {
                if(gui.maKh.Equals(txtMa.Text))
                {
                    txtThongBao.Text = "* Người gửi có mà khách hàng " + gui.maKh + ": \n Có tiền lãi: " + gui.tienLai;
                    break;
                }
                else
                {
                    txtThongBao.Text = "* Không có Khách hàng nào có mã: " + gui.maKh;
                }
            }
        }
    }
}
