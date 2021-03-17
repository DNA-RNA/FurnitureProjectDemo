using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryColorDal : IColorDal
    {

        List<Color> _color;
        public InMemoryColorDal()
        {
            _color = new List<Color> { 
            new Color{ ColorId= 1 , ColorName= "Siyah" },
            new Color { ColorId = 2 , ColorName="Beyaz" },
            new Color {ColorId= 3 , ColorName = "Mavi" } };
        }
        public void Add(Color color)
        {
            Color colorToAdd = _color.SingleOrDefault(c=> c.ColorId == color.ColorId);
            _color.Add(colorToAdd);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _color.SingleOrDefault(c => c.ColorId == color.ColorId && c.ColorName == color.ColorName);
            _color.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _color;
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _color.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorId = color.ColorId;
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
