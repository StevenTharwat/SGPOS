using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilities
{
    public static class POSData
    {
        public static DataRow getCustomerRowById(int id, StringBuilder sb)
        {
            DataRow row = null;
            try
            {
                row = connection.sqlReturnTable($"select * from customers where id = {id}").Rows[0];
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            return row;
        }
        /// <summary>
        /// delete item by update the flag
        /// </summary>
        /// <param name="id">the id of the item</param>
        /// <param name="flage">[1 => delete, 2 => hide, ...]></param>
        /// <returns></returns>
        public static int deleteItem(int id, int flage)
        {
            int res = -1;
            try
            {
                connection.sqlStatment($"update items set visible = {flage},f = '{DateTime.Now}' where id = {id};");
                res = 0;
            }
            catch (Exception)
            {
                res = -1;
            }
            return res;
        }

        /// <summary>
        /// delete Customer by update the flag
        /// </summary>
        /// <param name="id">the id of the Customer</param>
        /// <param name="flage">[1 => delete, 2 => hide, ...]></param>
        /// <returns></returns>
        public static int deleteCustomer(int id, int flage)
        {
            int res = -1;
            try
            {
                connection.sqlStatment($"update Customers set visible = {flage},deleted_Date = '{DateTime.Now}' where id = {id};");
                res = 0;
            }
            catch (Exception)
            {
                res = -1;
            }
            return res;
        }

        public static int deleteInv(int id, int flage)
        {
            int res = -1;
            try
            {
                connection.sqlStatment($"update inv_head set visible = {flage},deleted_Date = '{DateTime.Now}' where id = {id};");
                res = 0;
            }
            catch (Exception)
            {
                res = -1;
            }
            return res;
        }

        public static bool isCustomerCodeUniqe(string code,StringBuilder sb)
        {
            bool uniqe = false;
            try
            {
                string rowsCount = connection.sqlReturnValue($"select count(id) from Customers where code = '{code}' and visible = 0");
                if (rowsCount == "0") uniqe = true;
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            return uniqe;
        }

        public static void insertNewCustomer(Dictionary<string, string> map)
        {
            if (!map.ContainsKey("createdDate")) map["createdDate"] = DateTime.Now.ToString() ;

            connection.sqlStatment($"insert into Customers (code,name,Gender,type,dirty_Updated,visible,created_Date,cat,number,address,note_a,note_b) Values(N'{map["code"]}',N'{map["name"]}',N'{map["gender"]}',N'{map["type"]}','{DateTime.Now}',0,'{map["createdDate"]}',N'{map["cat"]}',N'{map["phone"]}',N'{map["address"]}',N'{map["noteA"]}',N'{map["noteB"]}');");
        }

        public static void updateCustomer(Dictionary<string, string> map)
        {
            string id = map["id"];
            connection.sqlStatment($"update Customers set visible = 100 where id = {id};");
            map["createdDate"] = connection.sqlReturnValue($"select created_Date from Customers where id = {id};") ;
            insertNewCustomer(map);
        }
        
        public static DataTable getCustomerTable()
        {
            DateTime min = DateTime.MinValue;
            DateTime now = DateTime.Now;
            return getCustomerTable(min, now);
        }
        
        public static DataTable getCustomerTable(DateTime from, DateTime to)
        {
            return connection.sqlReturnTable($@"exec getCustomerTable '{from}','{to}'");
        }
        
        public static Dictionary<string,string> getCustomerDic()
        {
            Dictionary<string, string> customersDic = new Dictionary<string, string>();
            DataTable dt = connection.sqlReturnTable("select code, name from customers where visible = 0 ;");
            foreach (DataRow row in dt.Rows)
            {
                customersDic[row["name"].ToString()] = row["code"].ToString();
            }
            return customersDic;
        }

        public static Dictionary<string, string> getItemsDic()
        {
            Dictionary<string, string> customersDic = new Dictionary<string, string>();
            DataTable dt = connection.sqlReturnTable("select code, name from Items where visible = 0 ;");
            foreach (DataRow row in dt.Rows)
            {
                customersDic[row["code"].ToString()] = row["name"].ToString();
            }
            return customersDic;
        }

        public static bool isItemCodeUniqe(string code,StringBuilder sb)
        {
            bool uniqe = false;
            try
            {
                string rowsCount = connection.sqlReturnValue($"select count(id) from items where code = '{code}' and visible = 0");
                if (rowsCount == "0") uniqe = true;
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            return uniqe;
        }

        public static void insertNewItem(Dictionary<string, string> map)
        {
            if (!map.ContainsKey("createdDate")) map["createdDate"] = DateTime.Now.ToString() ;
            connection.sqlStatment($"insert into items (code,name,sell_def_Price,buy_def_Price,dirty_Updated,visible,created_Date,cat,seller_code,note_a,note_b) Values(N'{map["code"]}',N'{map["name"]}',{map["sell_def_Price"]},{map["buy_def_Price"]},'{DateTime.Now}',0,'{map["createdDate"]}',N'{map["cat"]}',N'{map["seller_code"]}',N'{map["noteA"]}',N'{map["noteB"]}');");
        }

        public static void updateItem(Dictionary<string, string> map)
        {
            string id = map["id"];
            connection.sqlStatment($"update items set visible = 100 where id = {id};");
            map["createdDate"] = connection.sqlReturnValue($"select created_Date from items where id = {id};") ;
            insertNewItem(map);
        }
        
        public static DataTable getItemTable()
        {
            DateTime min = DateTime.MinValue;
            DateTime now = DateTime.Now;
            return getCustomerTable(min, now);
        }

        public static DataTable getItemTable(DateTime from, DateTime to)
        {
            return connection.sqlReturnTable($@"exec getItemTable '{from}','{to}'");
        }

        public static DataTable getBInvsTable()
        {
            DateTime min = DateTime.MinValue;
            DateTime now = DateTime.Now;
            return getBInvsTable(min, now);
        }

        public static DataTable getBInvsTable(DateTime from, DateTime to)
        {
//            string qry = $@"select h.id as 'رقم تسلسلي',h.code_str as 'كود الفاتورة',c.name as 'المورد',h.created_Date as 'تاريخ الانشاء',
//h.dis_amount as 'اجمالي الخصم',h.note_a as 'ملاحظة 1',h.note_b as 'ملاحظة 2' 
//from inv_head h join Customers c on h.customer_code = c.code
//where h.visible = 0 and c.visible = 0 and h.type = 'b' and 
//            (( CONVERT(date, h.created_Date, 111) >= '{from}' and  CONVERT(date, h.created_Date, 111) <= '{to}')) order by h.created_Date;";
            string qry = $@"exec getInvsTable '{from}','{to}','b'";
            return connection.sqlReturnTable(qry);
        }

        public static DataTable getSInvsTable(DateTime from, DateTime to)
        {
            string qry = $@"exec getInvsTable '{from}','{to}','s'";
            return connection.sqlReturnTable(qry);
        }

        public static DataTable getRBInvsTable(DateTime from, DateTime to)
        {
            //            string qry = $@"select h.id as 'رقم تسلسلي',h.code_str as 'كود الفاتورة',c.name as 'العميل',h.created_Date as 'تاريخ الانشاء',
            //h.dis_amount as 'اجمالي الخصم',h.note_a as 'ملاحظة 1',h.note_b as 'ملاحظة 2' 
            //from inv_head h join Customers c on h.customer_code = c.code
            //where h.visible = 0 and c.visible = 0 and h.type = 'rb' and 
            //            (( CONVERT(date, h.created_Date, 111) >= '{from}' and  CONVERT(date, h.created_Date, 111) <= '{to}')) order by h.created_Date;";
            string qry = $@"exec getInvsTable '{from}','{to}','rb'";
            return connection.sqlReturnTable(qry);
        }

        public static DataTable getItemsReport(DateTime from, DateTime to)
        {
            string qry = $@"exec itemsInfo";
            return connection.sqlReturnTable(qry);
        }

        public static DataTable getRSInvsTable(DateTime from, DateTime to)
        {
//            string qry = $@"select h.id as 'رقم تسلسلي',h.code_str as 'كود الفاتورة',c.name as 'العميل',h.created_Date as 'تاريخ الانشاء',
//h.dis_amount as 'اجمالي الخصم',h.note_a as 'ملاحظة 1',h.note_b as 'ملاحظة 2' 
//from inv_head h join Customers c on h.customer_code = c.code
//where h.visible = 0 and c.visible = 0 and h.type = 'rs' and 
//            (( CONVERT(date, h.created_Date, 111) >= '{from}' and  CONVERT(date, h.created_Date, 111) <= '{to}')) order by h.created_Date;";
            string qry = $@"exec getInvsTable '{from}','{to}','rs'";
            return connection.sqlReturnTable(qry);
        }

        public static DataTable getSInvsTable()
        {
            DateTime min = DateTime.MinValue;
            DateTime now = DateTime.Now;
            return getSInvsTable(min, now);
        }
        public static bool isInvCodeUniqe(string invCode, StringBuilder errrors)
        {
            bool uniqe = false;
            try
            {
                string rowsCount = connection.sqlReturnValue($"select count(id) from inv_head where code_str = '{invCode}' and visible = 0");
                if (rowsCount == "0") uniqe = true;
            }
            catch (Exception ex)
            {
                errrors.AppendLine(ex.Message);
            }
            return uniqe;
        }

        public static void updateInvoice(Dictionary<string, string> map, List<items> itemsList)
        {
            string id = map["id"];
            connection.sqlStatment($"update inv_head set visible = 100 where id = {id};");
            map["createdDate"] = connection.sqlReturnValue($"select created_Date from inv_head where id = {id};");
            insertNewInvoice(map,itemsList);
        }

        public static void insertNewInvoice(Dictionary<string, string> map, List<items> itemsList)
        {
            if (!map.ContainsKey("createdDate")) map["createdDate"] = DateTime.Now.ToString();
            string NewID = connection.sqlReturnValue($"insert into inv_head (code_str,total,visible,dirty_updated,created_Date,type,customer_code,note_a,note_b,dis_pre,dis_amount,dis_global_pre) OUTPUT Inserted.id Values(N'{map["invCode"]}',{map["totalbeforeDisc"]},0,'{DateTime.Now}','{map["createdDate"]}','{map["type"]}',{map["customerCode"]},N'{map["NoteA"]}',N'{map["NoteB"]}',{map["nudTotoalDiscPre"]},{map["dis_amount"]},{map["dis_global_pre"]});");
            string itemsQry = string.Empty;
            foreach (items item in itemsList)
            {
                itemsQry += $"\n insert into inv_Details(inv_id,item_code,item_qty,item_price,dis_row_pre,dis_row_amount,dis_item_pre,dis_item_amount,row_total_after_dis,row_total_befor_dis)" +
                    $" Values({NewID},{item.itemCode},{item.qty},{item.price},{item.rowDisPre},{item.price*item.qty*item.rowDisPre/100},{item.itemDisPre},{item.price*item.itemDisPre},{item.price * item.qty * item.rowDisPre / 100},{item.price*item.qty}) ;";
            }
            connection.sqlStatment(itemsQry);
        }

        public static DataRow getItemRowById(int id, StringBuilder sb)
        {
            DataRow row = null;
            try
            {
                row = connection.sqlReturnTable($"select * from items where id = {id}").Rows[0];
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
            return row;
        }

        public static Dictionary<DataRow, DataTable> getInvRowByIdDic(int id, StringBuilder errors)
        {
            Dictionary<DataRow, DataTable> Dic = new Dictionary<DataRow, DataTable>();
            string headerQry = $"select * from inv_head where id = {id} and visible = 0";
            string detailQry = $"select * from inv_Details where inv_id = {id}";
            Dic[connection.sqlReturnTable(headerQry).Rows[0]] = connection.sqlReturnTable(detailQry);
            return Dic;
        }
    }
}

/*
 
 important queries 

------------- customer history ------------- 
select code as 'كود الفاتورة',

CASE
    WHEN count(id) = 1 THEN '0'
    WHEN count(id) > 1 THEN count(id)
END as 'عدد مرات التعديل'

from Customers
group by code
having count(id) > 0 
-------------------------------------------- 
-------- get changes in one customer -------
select * from Customers where code = '{code}' order by dirty_Updated
--------------------------------------------
 
 
 
 */
