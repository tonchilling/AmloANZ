using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO.Amlo.Trans;
using BAL.Amlo.Master;
namespace ANZ2AMLO.Forms
{
    public partial class frmTransactionMaster : DevExpress.XtraEditors.XtraForm
    {
        PaymentBAL bal = null;
        List<TransactionANZ> tranObjList = null;
        public frmTransactionMaster()
        {
            InitializeComponent();
        }

        private void frmTransactionMaster_Load(object sender, EventArgs e)
        {

            InitialData();
          /*  cus.Add(new TransactionANZ()
            {
                colNo = "1",
                GroupName = "G01",
                Status = "Compleated",
                ANZCustomerInstrumentId = "CusID01",
                ANZCustomerBANKAccountNumber = "Number01",
                TransactionDate=DateTime.Now,
                TranxSendReceive="Send",
                TranxAmountTHB="750,000.01",
                TranxAmountCurrency="THB"


            });
            cus.Add(new TransactionANZ()
            {
                colNo = "2",
                GroupName = "G02",
                Status = "Reject",
                ANZCustomerInstrumentId = "CusID02",
                ANZCustomerBANKAccountNumber = "Number02",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Receive",
                TranxAmountTHB = "750,000.01",
                TranxAmountCurrency = "USD"
            });
            cus.Add(new TransactionANZ()
            {
                colNo = "3",
                GroupName = "G03",
                Status = "Pending",
                ANZCustomerInstrumentId = "CusID03",
                ANZCustomerBANKAccountNumber = "Number03",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Send",
                TranxAmountTHB = "2,850,000.01",
                TranxAmountCurrency = "THB"
            });
            cus.Add(new TransactionANZ()
            {
                colNo = "4",
                GroupName = "G04",
                Status = "Compleated",
                ANZCustomerInstrumentId = "CusID04",
                ANZCustomerBANKAccountNumber = "Number04",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Send",
                TranxAmountTHB = "90,000.01",
                TranxAmountCurrency = "THB"
            });

    */

        }


        void InitialData()
        {
            bal = new PaymentBAL();

           
            tranObjList = bal.FindByObjList(new TransactionANZ());

            this.gridView1.GridControl.DataSource = tranObjList;
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                item.MaxWidth = 0;
            }
            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();

        }

        private void gdView_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            splashScreenManager1.ShowWaitForm();
            ANZ2AMLO.BAL.Util.XGenerate.TransactionToExcel(tranObjList, @"D:\ANZ\Output");
            System.Threading.Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Export files completely!!", "EXPORTING", MessageBoxButtons.OK);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\ANZ\Output");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ANZ2AMLO.BAL.Util.XGenerate.TransactionToExcel(tranObjList, @"D:\ANZ\Output");
            System.Threading.Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Export files completely!!", "EXPORTING", MessageBoxButtons.OK);
        }
    }
   

}