using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _category;
        public InMemoryCategoryDal()
        {
            _category = new List<Category> { new Category { CategoryId=1,CategoryName="Oturma Grupları",BrandId=1,Declaration="İstikbal Oturma Takımları" },
                new Category { CategoryId=2,CategoryName="Yemek Odası Takımları",BrandId=1,Declaration="İstikbal Yemek  Takımları" },
                new Category { CategoryId=3,CategoryName="Yatak Odası Grupları",BrandId=2,Declaration="Bellona Yatak Takımları" },
                new Category { CategoryId=4,CategoryName="Genç ve Bebek Odası Grupları",BrandId=2,Declaration="Bellona Genç ve Bebek Takımları" }

            };
        }
        public void Add(Category category)
        {
            Category categoryToAdd = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _category.Add(categoryToAdd);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId && c.BrandId == category.BrandId);
            _category.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _category;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryId  = category.CategoryId;
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.BrandId = category.BrandId;
        }
    }
}
