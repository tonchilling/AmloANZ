using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO.Amlo.Master;
using DAL;
using DTO.Util;
namespace DAL.Amlo.Master
{
    public class M_CustomerDAL : AmloBase
    {
        List<M_CustomerDTO> objList = null;
        bool isCan = false;
        public M_CustomerDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public override DataTable FindByAll()
        {
            throw new NotImplementedException();
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            throw new NotImplementedException();
        }


        public List<M_CustomerDTO> FindByObjList(object data)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            objList = new List<M_CustomerDTO>();
            List<M_Customer_Account> custAccountList = null;
            List<M_Customer_Address> custAddreList = null;
            string procName = "sp_M_Customer_FindByColumn";
            try
            {
           
                adapter = new SqlDataAdapter();
                SqlConnection conn = OpenConection();
                if (data != null)
                {

                    parameterList.AddRange(GetParameters(procName, data).ToArray());
                }
                command = new SqlCommand(procName, conn);
                command.CommandType = CommandType.StoredProcedure;
                if (data != null)
                {



                    command.Parameters.AddRange(parameterList.ToArray());
                }



                using (SqlDataReader reader = command.ExecuteReader())
                {
                    objList = Converting.GetListFromDataReader<M_CustomerDTO>(reader).ToList();

                    reader.NextResult();
                    custAccountList= Converting.GetListFromDataReader<M_Customer_Account>(reader).ToList();

                    reader.NextResult();
                    custAddreList = Converting.GetListFromDataReader<M_Customer_Address>(reader).ToList();

                    foreach (M_CustomerDTO custObj in objList)
                    {
                        custObj.AccountList = custAccountList.FindAll(cus=>cus.CustomerOID== custObj.CustomerOID);
                        custObj.AddressList = custAddreList.FindAll(cus => cus.CustomerOID == custObj.CustomerOID);
                    }
                }


            }
            catch (Exception ex) { }
            finally
            {
                CloseConnection();
            }
            return objList;
        }

        public override bool Update(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public DataSet FindAccountAndAddress(DataTable dt)
        {
            isCan = false;
            DataSet dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteParamToDataSet("[sp_M_Customer_FindAccountAndAddress]", dt);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                CloseConnection();
            }
            return dtObj;
        }
    }
}
