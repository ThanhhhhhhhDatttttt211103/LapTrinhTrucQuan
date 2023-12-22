using System.Collections.Generic;

namespace BTTiengAnh
{
    public class BaiTapDienTu
    {
        private string deBai;
        private string dapAn;
        private List<string> dapAnTungCau;
        public BaiTapDienTu() {
       
        }
        public BaiTapDienTu(string deBai, string dapAn, List<string> dapAnTungCau)
        {
            this.deBai = deBai;
            this.dapAn = dapAn;
            this.dapAnTungCau = dapAnTungCau;
        }

        public string DeBai { get => deBai; set => deBai = value; }
        public string DapAn { get => dapAn; set => dapAn = value; }
        public List<string> DapAnTungCau { get => dapAnTungCau; set => dapAnTungCau = value; }

        
    }
}
