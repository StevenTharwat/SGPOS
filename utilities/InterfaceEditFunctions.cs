using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilities
{
    public static class InterfaceEditFunctions
    {
        public static bool isEmpty(this string str)
        {
            bool isEmptyOrNull;
            isEmptyOrNull = string.IsNullOrEmpty(str);
            isEmptyOrNull = string.IsNullOrEmpty(str.Trim());
            return isEmptyOrNull;
        }

        public static List<string> getKeys(this Dictionary<string, string> dic)
        {
            List<string> values = new List<string>();
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                values.Add(kvp.Key);
            }
            return values;
        }

        public static List<string> getValues(this Dictionary<string, string> dic)
        {
            List<string> values = new List<string>();
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                values.Add(kvp.Value);
            }
            return values;
        }

        public static List<items> convertItemsTable(this DataTable itemsTable)
        {
            List<items> items = new List<items>();
            foreach (DataRow row in itemsTable.Rows)
            {
                items.Add(new items(row["item_code"].ToString(), Convert.ToDouble(row["item_qty"]), Convert.ToDouble(row["item_price"]) , Convert.ToDouble(row["dis_row_pre"])));
            }
            return items;
        }
    }
}
