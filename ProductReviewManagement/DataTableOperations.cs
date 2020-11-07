using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            table.Rows.Add(12, 10, 5, "Okay", true);
            table.Rows.Add(13, 10, 8, "Nice", true);
            table.Rows.Add(11, 10, 2, "Bad", false);
            table.Rows.Add(15, 10, 9, "Nice", true);
            table.Rows.Add(1, 10, 7, "Good", true);
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
        public void AverageOfProductRatings()
        {
            var recordedList = table.AsEnumerable().GroupBy(x => x.Field<int>("ProductID")).Select(x => new { ProductID = x.Key, Average = x.Average(p => p.Field<double>("Rating")) });
            foreach (var dataItem in recordedList)
            {
                Console.WriteLine("Prod Id :"+dataItem.ProductID + " Average Rating :" + dataItem.Average);
            }
        }
        public void SelectRecordsWhereReviewIsNice()
        {
            var recordedList = from product in table.AsEnumerable()
                               where product.Field<string>("Review").Equals("nice")
                               select product;
            foreach (var item in recordedList)
            {
                Console.WriteLine("ProductId :" + item.ItemArray[0] + " UserId :" + item.ItemArray[1] + " Rating :" + item.ItemArray[2] + " Review :" + item.ItemArray[3] + " IsLike :" + item.ItemArray[4]);
            }
        }
        public void OrderByRatingOnCondition()
        {
            var recordedList = table.AsEnumerable()
                        .Where(x => x.Field<int>("UserID") == 10)
                        .OrderBy(x => x.Field<double>("Rating"));
            foreach (var item in recordedList)
            {
                Console.WriteLine("ProductId :" + item.ItemArray[0] + " UserId :" + item.ItemArray[1] + " Rating :" + item.ItemArray[2] + " Review :" + item.ItemArray[3] + " IsLike :" + item.ItemArray[4]);
            }
        }
    }
}