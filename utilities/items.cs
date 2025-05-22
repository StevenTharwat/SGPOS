using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilities
{
    public class items
    {
        public items(string _itemCode, double _qty, double _price)
        {
            this.id = ++staticItemClass.idI;
            this.itemCode = _itemCode;
            staticItemClass.getItemsDic();
            this.itemName = staticItemClass.ItemsDic[itemCode];
            this.qty = _qty;
            this.price = _price;
        }
        public items(string _itemCode, double _qty, double _price, double _rowDisPre)
        {
            this.id = ++staticItemClass.idI;
            this.itemCode = _itemCode;
            staticItemClass.getItemsDic();
            this.itemName = staticItemClass.ItemsDic[itemCode];
            this.qty = _qty;
            this.rowDisPre = _rowDisPre;
            this.price = _price;
        }

        public int id { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public double qty { get; set; }
        public double price { get; set; }
        public double rowDisPre { get; set; }
        public double itemDisPre { get; set; } = 0;
    }

    public static class staticItemClass
    {
        public static int idI { get; set; } = 0;
        public static Dictionary<string, string> ItemsDic = new Dictionary<string, string> ();

        public static void getItemsDic()
        {
            ItemsDic = POSData.getItemsDic();
        }
    }
}
