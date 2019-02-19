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
using BAL.Amlo.Trans;
using BAL.Amlo.Importing;
using DTO.Amlo.Importing;
using DevExpress.XtraEditors;
using DevExpress.Xpf.Core;
using DevExpress.XtraSplashScreen;
using DTO.Amlo.Export;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmImportDataDaily : DevExpress.XtraEditors.XtraForm
    {
        public static string ReportSourceID = "";
        public static string KeyWord = "";

        SourceFile_MappingHeaderBAL bal = null;
        DataSet ds = null;
        DataView dvFilter = null;
        DataTable dtH, dtDetail, dtDetail_Col, dtDetailList;

        private void frmImportDataDaily_Load(object sender, EventArgs e)
        {
            InitialData();
        }

       
        public frmImportDataDaily()
        {
            InitializeComponent();
        }

        void InitialData()
        {
            bal = new SourceFile_MappingHeaderBAL();


            ds = bal.FindHeaderAndDetailPK(ReportSourceID);

            if (ds != null)
            {
                dtH = ds.Tables[0];
                dtDetail = ds.Tables[1];
                dtDetail_Col = ds.Tables[2];


            }
            else
            {
                dtH = null;
                dtDetail = null;
                dtDetail_Col = null;
            }

            if (dtDetail != null)
            {
                dvFilter = new DataView(dtDetail);
                dvFilter.RowFilter = string.Format("KeyWord='{0}'", KeyWord);

                if (dvFilter != null && dvFilter.Count > 0)
                {
                    txtSourceFile.Text = dvFilter[0]["SourceFileRefName"].ToString();
                    txtImport.Text = string.Format("{0},{1}", dvFilter[0]["StartRow"].ToString(), dvFilter[0]["StartColumn"].ToString());
                   txtKeyWord.Text = dvFilter[0]["KeyWord"].ToString();
                   // txtRemark.Text = "";
                  //  txtFileNameConditon.Text = dvFilter[0]["KeyWord"].ToString();
                }
            }

        }
        private void btnView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}