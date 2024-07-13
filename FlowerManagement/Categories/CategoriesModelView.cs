//using BusinessObjects;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FlowerManagement.Categories
//{
//    public class CategoriesModelView
//    {
//        public int CategoryID { get; set; }

//        public string? CategoryName { get; set; }

//        public string? CategoryDescription { get; set; }

//        public string? CategoryNote { get; set; }
//    }

//    public class CategoryMapper
//    {
//        public static CategoriesModelView MapToViewModel(Category category)
//        {
//            return new CategoriesModelView
//            {
//                CategoryID = category.CategoryID,
//                CategoryName = category.CategoryName,
//                CategoryDescription = category.CategoryDescription,
//                CategoryNote = category.CategoryNote
//            };
//        }
//    }
//}
