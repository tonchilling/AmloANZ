using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using DTO.Amlo.Importing;
using DAL;
using DTO.Amlo.Trans;

namespace DAL.Amlo.Trans
{
    /// <summary>
    /// Summary description for XCustomerDAO
    /// </summary>
    public class SourceFile_MappingHeaderDAL : AmloBase
    {
        bool isCan = false;
        public SourceFile_MappingHeaderDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }


        public  bool ImportAll(List<ImportDTO> dataList)
        {
            isCan = false;
            DataTable dtDetail = null;
            try
            {
                string createBy = "";
                OpenConection();
                ExcecuteNoneQueryObj("sp_Temp_ClearAll",null);
                isCan = true;
                CloseConnection();

                OpenConection();
                string ImportID = Guid.NewGuid().ToString();
                foreach (ImportDTO dto in dataList)
                {
                    createBy = dto.CREATE_BY!=null ? dto.CREATE_BY:"";
                    dto.Data.Tables[1].Columns.Add("ImportID");
                        
                    foreach (DataRow dr in dto.Data.Tables[1].Rows)
                    {
                        dr["ImportID"] = ImportID;

                    }
                   
                    if (dto.Data != null && dto.Data.Tables.Count > 1)
                    {
                        ExcecuteNoneQuery(string.Format("sp_Temp_{0}_Insert"
                            , dto.Data.Tables[0].Rows[0]["KeyWord"].ToString())
                            , dto.Data.Tables[1]);
                    }
                }

                ImportDTO tempDTO = new ImportDTO();
                tempDTO.ImportID = ImportID;
                tempDTO.CREATE_BY = createBy;
                ExcecuteNoneQueryObj("sp_Importing_TempToCustomer", tempDTO);
                
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }


        public override bool Update(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Update", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public override bool Delete(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Delete", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public override DataTable FindByAll()
        {

            isCan = false;
            DataTable dtObj = null;
            try
            {
                DataTable dt = SourceFile_MappingHeaderDto.Data();
                DataRow dr = dt.NewRow();
                dr["ROW_STATE"] = "1";
                dt.Rows.Add(dr);

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindAll", dt);
                
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindByColumn", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }


        public  DataTable FindByPK(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindByPK", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }


        public DataTable FindByKeyWord(string tbName)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable(string.Format("sp_{0}_FindByPK", tbName), null);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public DataSet  FindHeaderAndDetailPK(DataTable dt)
        {
            isCan = false;
            DataSet dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteParamToDataSet("[sp_SourceFile_MappingHeader_FindByPK]", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;

            //ExcecuteParamToDataSet

        }

     

        
    }
}
