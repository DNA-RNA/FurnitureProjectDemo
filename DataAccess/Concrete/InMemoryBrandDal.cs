using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryBrandDal : IBrandDal
    {

        List<Brand> _brand;

        public InMemoryBrandDal()
        {
            _brand = new List<Brand> { 
            new Brand { BrandId=1 , BrandName= "İstikbal" },
            new Brand { BrandId=2 , BrandName= "Bellona" } };
        }

        public void Add(Brand brand)
        {
            Brand brandToAdd = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brand.Add(brandToAdd);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brand.SingleOrDefault(b => b.BrandId == brand.BrandId && b.BrandName == brand.BrandName);
            _brand.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brand;
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brand.SingleOrDefault(b=> b.BrandId == brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
