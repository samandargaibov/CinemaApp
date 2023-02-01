using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Services.Contracts;
using CinemaApp.Utils;

namespace CinemaApp.Services
{
    internal class CinemaManager : ICrudService<Cinema>,IPrintService
    {
        public void Add(Cinema cinema)
        {
            DataContext.Cinemas.Add(cinema);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cinema Get(int id)
        {
            int index = FindHelper.FindCinemaIndex(id);

            if (index == -1)
            {
                return null;
            }

            return DataContext.Cinemas[index];
        }

        public List<Cinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (var item in DataContext.Cinemas)
            {
                Console.WriteLine(item);
                Console.WriteLine("-".PadRight(20, '-'));
            }
        }

        public void Update(int id, Cinema entity)
        {
            throw new NotImplementedException();
        }
    }
}
