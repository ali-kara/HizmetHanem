using Business.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class MenuItemManager : IMenuItemService
    {

        readonly IMenuItemDAL menuItemDAL;

        public MenuItemManager(IMenuItemDAL menuItemDAL)
        {
            this.menuItemDAL = menuItemDAL;
        }

        /// <summary>
        /// Kategori parametresine göre MenuItem döner
        /// </summary>
        /// <returns>List tipinde Category döner.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<MenuItem> GetByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
