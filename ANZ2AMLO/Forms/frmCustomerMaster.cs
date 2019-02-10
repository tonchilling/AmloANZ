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
using ANZ2AMLO.Forms;
using BAL.Amlo.Master;
using DTO.Amlo.Master;
namespace ANZ1AMLO.Forms
{
    public partial class frmCustomerMaster : DevExpress.XtraEditors.XtraForm
    {
        M_CustomerBAL bal = null;
        List<M_CustomerDTO> customerObjList = null;
        M_CustomerDTO objSearh = null;
        public frmCustomerMaster()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCustomerMasterDetail frmCusDetail = new frmCustomerMasterDetail();
            frmCusDetail.ShowDialog(this);
        }

        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {

            #region old
            /* List<Customer> cus = new List<Customer>();
             cus.Add(new Customer()
             {
                 colNo = "1",
                 colCustomerID = "CusID001",
                 colCutomerNo = "CusNo001",
                 colCutomerAC = "AC001",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID001",
                 colDID = "",
                 colHID = "",
                 colTelNo = "01-000-0001",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type001",
                 colDefaultAddress = "Address 001",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "2",
                 colCustomerID = "CusID002",
                 colCutomerNo = "CusNo002",
                 colCutomerAC = "AC002",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID002",
                 colDID = "",
                 colHID = "",
                 colTelNo = "02-000-0002",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type002",
                 colDefaultAddress = "Address 002",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "13",
                 colCustomerID = "CusID0055",
                 colCutomerNo = "CusNo0065",
                 colCutomerAC = "AC0055",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });*/
            #endregion

            LoadData();


        }


        void LoadData()
        {
           // splashScreenManager1.ShowWaitForm();
            System.Threading.Thread.Sleep(1000);
            bal = new M_CustomerBAL();

            objSearh = new M_CustomerDTO();
            customerObjList = bal.FindByObjList(objSearh);
            this.gridView1.GridControl.DataSource = customerObjList;

            gridView1.MasterRowGetRelationName += (s, e) => {
                switch (e.RelationIndex)
                {
                    case 0:
                        e.RelationName = "Order Detail";
                        break;
                    case 1:
                        e.RelationName = "Customer Details";
                        break;
                    case 2:
                        e.RelationName = "Employee Details";
                        break;
                }
            };


            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                item.MaxWidth = 0;
            }
            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            System.Threading.Thread.Sleep(1000);
            //splashScreenManager1.CloseWaitForm();
         
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string oid= gridView1.GetFocusedRowCellValue("CustomerOID").ToString();
            txtCustomerID.Text = gridView1.GetFocusedRowCellValue("CustomerID").ToString();
            txtCustomerName.Text= gridView1.GetFocusedRowCellValue("CustomerName").ToString();
            txtCustomerNO.Text = gridView1.GetFocusedRowCellValue("CustomerNo").ToString();
            txtJuristicIDNo.Text = gridView1.GetFocusedRowCellValue("JuristicIDNo").ToString();
            txtRegBusinessName.Text = gridView1.GetFocusedRowCellValue("RegBusinessName").ToString();
            txtRegBusinessNameTH.Text = gridView1.GetFocusedRowCellValue("RegBusinessNameTH").ToString();
            txtPrimaryBusinessType.Text = gridView1.GetFocusedRowCellValue("PrimaryBusinessTypeCode").ToString();
            txtRegisterDate.Text = gridView1.GetFocusedRowCellValue("RegisterDate").ToString();

            DataSet ds = bal.FindAccountAndAddress(oid);
            DataTable dtAccount = ds.Tables[0];
            DataTable dtAddress = ds.Tables[1];

            gdAccount.DataSource = dtAccount;
            gdAddress.DataSource = dtAddress;
            //txtTaxID.Text = gridView1.GetFocusedRowCellValue("RegTAXID").ToString();
            //txtTel.Text = gridView1.GetFocusedRowCellValue("ContactTelNumber")!=null?gridView1.GetFocusedRowCellValue("ContactTelNumber").ToString():"";
            //txtRegisterDate.Text = gridView1.GetFocusedRowCellValue("RegisterDate").ToString();
            //txtAddress.Text = gridView1.GetFocusedRowCellValue("DefaultAddress").ToString();
            popupContainerControl1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            popupContainerControl1.Hide();
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ANZ2AMLO.BAL.Util.XGenerate.CustomerToExcel(customerObjList, @"D:\ANZ\Output");
            System.Threading.Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Export files completely!!", "EXPORTING", MessageBoxButtons.OK);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\ANZ\Output");
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView masterView = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DevExpress.XtraGrid.Views.Grid.GridView detailView = masterView.GetDetailView(e.RowHandle, e.RelationIndex) as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RelationIndex == 0)
            {


        detailView.Columns["CustomerOID"].Visible = false;
              //  detailView.Columns[1].Visible = false;
                detailView.Columns["CREATE_BY"].Visible = false;
                detailView.Columns["CREATE_DATE"].Visible = false;
                detailView.Columns["UPDATE_BY"].Visible = false;
                detailView.Columns["UPDATE_DATE"].Visible = false;
                detailView.Columns["ROW_STATE"].Visible = false;
                detailView.Columns["ImportID"].Visible = false;
            }
            else if (e.RelationIndex == 1)
            {


        detailView.Columns["AddressOID"].Visible = false;
                detailView.Columns["RelateCustomerKYCID"].Visible = false;
                detailView.Columns["CustomerOID"].Visible = false;
                detailView.Columns["CREATE_BY"].Visible = false;
                detailView.Columns["CREATE_DATE"].Visible = false;
                detailView.Columns["UPDATE_BY"].Visible = false;
                detailView.Columns["UPDATE_DATE"].Visible = false;
                detailView.Columns["ROW_STATE"].Visible = false;
                detailView.Columns["ImportID"].Visible = false;
            }
        }
    }
  
}