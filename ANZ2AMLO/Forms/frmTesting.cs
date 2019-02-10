using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Amlo.Export;
namespace ANZ2AMLO.Forms
{
    public partial class frmTesting : Form
    {
       
        public frmTesting()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            txtResult.Text = ConvertObjectToXmlStr();
        }


        string ConvertObjectToXmlStr()
        {
         List<AmloToCustomer> customerResultList = null;
         AmloToCustomer customerData = null;


            customerData = new AmloToCustomer();
            List<reportingdetail> reportingDetailList = new List<reportingdetail>();
            List<report> reportList = new List<report>();
            reportingdetail reportingdetailData = null;

            List<person> personList = new List<person>();
            person personData = null;


            List<contact> contactList = new List<contact>();
            contact contactData = null;
            address addressData = null;

            // #1
            report report = null; 

            //<reportingdetail orgid="0107557000420" orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)"/>
            reportingdetailData = new reportingdetail() {  orgid="0107557000420",  orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)" };

            reportingDetailList.Add(reportingdetailData);



            customerData.reportingdetail = reportingDetailList;


            //<report>
            report = new report();

            //<reportorgdetail branchcode="00000" orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)" telno="022639700"/>
            report.reportingdetail= new reportingdetail() { branchcode = "00000", orgname = "ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)" , telno = "022639700" };
           
            //<dcn value="09-00107557000420-00000-255912-000084" doctype="1-05-9" revision="" date="" refdocno="" refdoctype=""/>
            report.dcn = new dcn() { value= "09-00107557000420-00000-255912-000084",doctype= "1-05-9", revision="", date="", refdocno="", refdoctype="" };

            //<reporttype value="2"/>
            report.reportType = new reportType() {value="2" };



            //--------------------------------------------------- ส่วนที่ 1 --------------------------------------------//
            //<person anothermethod="TRUE" am_transactionmethod="DOCUMENT" am_customeraccno="100032" value="TRANSACTING-PERSON" relationship="SELF" relationshipdesc="">

            personData = new person() { anothermethod= "TRUE",
                                       am_transactionmethod = "DOCUMENT",
                                        value= "TRANSACTING-PERSON",
                                       relationship= "SELF",
                                       relationshipdesc="" };

            //<name type="LEGAL" title="" firstname="[NAV]" middlename="" lastname="" dateofbirth="" nationality="STATELESS" legalpersonid="[NAV]"/>
            personData.personName = new personName() { type= "LEGAL",
                                                       title ="",
                                                        firstname = "[NAV]",
                                                         middlename="",
                                                         lastname="",
                                                         dateofbirth = "",
                                                            nationality = "STATELESS",
                                                        legalpersonid = "[NAV]"
                                                         };

            //<occupation companyname="" businesstype="" businesstype_desc="" occ_type="99" occ_desc="[NAV]"/>
            personData.occupation = new occupation() { companyname = "", businesstype = "", businesstype_desc = "", occ_type = "99", occ_desc = "[NAV]", };

           
           

            addressData = new address() { no = "[NAV]",
                                           moo = "",
                                        building = "",
                                        soi = "",
                                      road = "",
                                     subdistrict = "[NAV]",
                                    address1 = "",
                                    address2 = "",
                                 district = "[NAV]",
                                   province = "[NAV]",
                                   zipcode = "[NAV]",
                                 countrycode = "TH" };

            contactData = new contact() { type= "ADDR",address= addressData };

            contactList.Add(contactData);

            contactData = new contact() { type = "COMPANY-ADDR", noinfo= "TRUE" };
            contactList.Add(contactData);
            contactData = new contact() { type = "CONTACT-ADDR", noinfo = "TRUE" };
            contactList.Add(contactData);

            personData.contact = contactList;

            personList.Add(personData);

            //--------------------------------------------------- ส่วนที่ 2 --------------------------------------------//

            //<person value="RELATED-PERSON" relationship="DELEGATOR" relationshipdesc="">
            personData = new person()
            {
                value = "RELATED-PERSON",
                relationship = "DELEGATOR",
                relationshipdesc = ""
            };

            //<name type="LEGAL" title="" firstname="MINOR INTERNATIONAL PUBLIC CO LTD" middlename="" lastname="" dateofbirth="" nationality="TH" legalpersonid="0107536000919"/>
            //< occupation companyname = "" businesstype = "" businesstype_desc = "" occ_type = "0" occ_desc = "" />
            personData.personName = new personName()
            {
                type = "LEGAL",
                title = "",
                firstname = "MINOR INTERNATIONAL PUBLIC CO LTD",
                middlename = "",
                lastname = "",
                dateofbirth = "",
                nationality = "TH",
                legalpersonid = "0107536000919"
            };

            //<occupation companyname="" businesstype="" businesstype_desc="" occ_type="0" occ_desc=""/>
            personData.occupation = new occupation() { companyname = "", businesstype = "", businesstype_desc = "", occ_type = "0", occ_desc = "", };



            /*<contact type="ADDR">
          <address no="99" moo="" building="BERLI JUCKER BUILDING 16TH FLOOR" soi="SOI RUBIA" road="SUKHUMVIT 42" subdistrict="PRAKANONG" address1="" address2="" district="KLONGTOEY" province="BANGKOK" zipcode="10110" countrycode="TH"/>
              </contact>*/
            addressData = new address()
            {
                no = "99",
                moo = "",
                building = "BERLI JUCKER BUILDING 16TH FLOOR",
                soi = "SOI RUBIA",
                road = "SUKHUMVIT 42",
                subdistrict = "PRAKANONG",
                address1 = "",
                address2 = "",
                district = "KLONGTOEY",
                province = "BANGKOK",
                zipcode = "10110",
                countrycode = "TH"
            };

            contactData = new contact() { type = "ADDR", address = addressData };

            contactList.Add(contactData);

            contactData = new contact() { type = "COMPANY-ADDR", noinfo = "TRUE" };
            contactList.Add(contactData);
            contactData = new contact() { type = "CONTACT-ADDR", noinfo = "TRUE" };
            contactList.Add(contactData);

            personData.contact = contactList;


            personData.iddoc = new iddoc() { type = "99", typedesc = "[NAV]", idno = "[NAV]", issueby = "[NAV]", issuedate = "[NAV]", expiredate = "[NAV]" };

            personList.Add(personData);
            //--------------------------------------------------- ส่วนที่ 3 --------------------------------------------//






            report.person = personList;

            reportList.Add(report);
            customerData.report = reportList;


            /*<ersreport version="1.0">
<reportingdetail orgid="0107557000420" orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)"/>
<report>
<reportorgdetail branchcode="00000" orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)" telno="022639700"/>
<dcn value="09-00107557000420-00000-255912-000084" doctype="1-05-9" revision="" date="" refdocno="" refdoctype=""/>
<reporttype value="2"/>
 <!--  ข้อมูลผู้ทำธุรกรรม  -->
 <!--  ส่วนที่ 1  -->
﻿
<person anothermethod="TRUE" am_transactionmethod="DOCUMENT" am_customeraccno="100032" value="TRANSACTING-PERSON" relationship="SELF" relationshipdesc="">
<name type="LEGAL" title="" firstname="[NAV]" middlename="" lastname="" dateofbirth="" nationality="STATELESS" legalpersonid="[NAV]"/>
<occupation companyname="" businesstype="" businesstype_desc="" occ_type="99" occ_desc="[NAV]"/>
﻿
<contact type="ADDR">
<address no="[NAV]" moo="" building="" soi="" road="" subdistrict="[NAV]" address1="" address2="" district="[NAV]" province="[NAV]" zipcode="[NAV]" countrycode="TH"/>
</contact>
<contact type="COMPANY-ADDR" noinfo="TRUE"/>
<contact type="CONTACT-ADDR" noinfo="TRUE"/>
<iddoc type="99" typedesc="[NAV]" idno="[NAV]" issueby="[NAV]" issuedate="[NAV]" expiredate="[NAV]"/>
</person>
 <!--
 ส่วนที่ 2 ข้อมูลผู้ร่วมทำธุรกรรม,ผู้มอบหมาย,ผู้มอบอำนาจ 
-->
﻿
<person value="RELATED-PERSON" relationship="DELEGATOR" relationshipdesc="">
<name type="LEGAL" title="" firstname="MINOR INTERNATIONAL PUBLIC CO LTD" middlename="" lastname="" dateofbirth="" nationality="TH" legalpersonid="0107536000919"/>
<occupation companyname="" businesstype="" businesstype_desc="" occ_type="0" occ_desc=""/>
﻿
<contact type="ADDR">
<address no="99" moo="" building="BERLI JUCKER BUILDING 16TH FLOOR" soi="SOI RUBIA" road="SUKHUMVIT 42" subdistrict="PRAKANONG" address1="" address2="" district="KLONGTOEY" province="BANGKOK" zipcode="10110" countrycode="TH"/>
</contact>
﻿
<contact type="COMPANY-ADDR">
<address no="99" moo="" building="BERLI JUCKER BUILDING 16TH FLOOR" soi="SOI RUBIA" road="SUKHUMVIT 42" subdistrict="PRAKANONG" address1="" address2="" district="KLONGTOEY" province="BANGKOK" zipcode="10110" countrycode="TH"/>
</contact>
﻿
<contact type="CONTACT-ADDR">
<address no="99" moo="" building="BERLI JUCKER BUILDING 16TH FLOOR" soi="SOI RUBIA" road="SUKHUMVIT 42" subdistrict="PRAKANONG" address1="" address2="" district="KLONGTOEY" province="BANGKOK" zipcode="10110" countrycode="TH"/>
</contact>
<iddoc type="99" typedesc="AFFIDAVIT" idno="0107536000919" issueby="MINISTRY OF COMMERCE" issuedate="2559-10-13" expiredate="[NOEXP]"/>
</person>
 <!--  ส่วนที่ 3 ข้อเท็จจริงเกี่ยวกับการทำธุรกรรม  -->
﻿
<tsc date="2559-12-22">
<tscentry>
<typeoftsc transtype="DOMESTIC" type="SEND" desc=""/>
<transferdetail type="SEND" accountno="100032" refno="FTB1612220002" org="ANZ BANK (THAI) PUBLIC CO LTD" orgcountry="TH">
<td fullname="MINOR INTERNATIONAL PUBLIC CO LTD" address="99 BERLI JUCKER BUILDING 16TH FLOOR SOI RUBIA" contactaddress="SUKHUMVIT 42 PRAKANONG KLONGTOEY BANGKOK 10110" idtype="OTHER" idtypedesc="AFFIDAVIT" idno="0107536000919" idissuer="MINISTRY OF COMMERCE" idexpiredate="" dateofbirth="" placeofbirth=""/>
</transferdetail>
<transferdetail type="REC" accountno="0126321007" refno="FTB1612220002" org="CITIBANK N.A." orgcountry="TH">
<td fullname="MINOR INTERNATIONAL PUBLIC CO LTD" address="BANGKOK" contactaddress="" idtype="OTHER" idtypedesc="AFFIDAVIT" idno="0107536000919" idissuer="MINISTRY OF COMMERCE" idexpiredate="" dateofbirth="" placeofbirth=""/>
</transferdetail>
<amount valueinbaht="199999850.00" valueinbahttxt="หนึ่งร้อยเก้าสิบเก้าล้านเก้าแสนเก้าหมื่นเก้าพันแปดร้อยห้าสิบบาทถ้วน"/>
</tscentry>
<totalamount valueinbaht="199999850.00" valueinbahttxt="หนึ่งร้อยเก้าสิบเก้าล้านเก้าแสนเก้าหมื่นเก้าพันแปดร้อยห้าสิบบาทถ้วน"/>
 <!--  Data From Head  -->
<benfperson firstname="[NAV]" middlename="" lastname=""/>
<objective type=""> NEW LOAN DRAWDOWN ON 22 DECEMBER 2016. </objective>
 <!--  ส่วนที่ 4  -->
</tsc>
<record date="2559-12-22"/>
</report>*/


            //   customerResultList.Add(customerData);
            string data = string.Format("{0}", DTO.Util.XmlSerializerHelper.SerializeObjectToString(customerData));

            return data;
        }
    }
}
