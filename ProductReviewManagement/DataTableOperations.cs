using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{
    class DataTableOperations
    {
        DataTable table = new DataTable();
        public void CreateDataTable()
        {
            table.Columns.Add("ProductID", typeof(int));
            table.Columns.Add("UserID", typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            table.Rows.Add(1, 1, 2, "Good", true);
            table.Rows.Add(2, 1, 4, "Good", true);
            table.Rows.Add(3, 1, 5, "Good", true);
            table.Rows.Add(4, 1, 6, "Good", false);
            table.Rows.Add(5, 1, 2, "nice", true);
            table.Rows.Add(6, 1, 1, "bad", true);
            table.Rows.Add(8, 1, 1, "Good", false);
            table.Rows.Add(8, 1, 9, "nice", true);
            table.Rows.Add(2, 1, 10, "nice", true);
            table.Rows.Add(10, 1, 8, "nice", true);
            table.Rows.Add(11, 1, 3, "nice", true);
        }
        public void SelectRecordsWhereIsLikeIsTrue()
        {
            var recordedList = from product in table.AsEnumerable()
                               where product.Field<bool>("IsLike").Equals(true)
                               select product;
            foreach(var item in recordedList)
            {
                Console.WriteLine("ProductId :"+item.ItemArray[0]+"UserId :"+item.ItemArray[1]+"Rating :"+item.ItemArray[2]+"Review :"+item.ItemArray[3]+"IsLike :"+item.ItemArray[4]);
            }
        }
    }
}
