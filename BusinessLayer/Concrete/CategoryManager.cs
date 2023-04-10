using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //EfCategoryRepository EfCategoryRepository; //Bağımlılık oluşturuyor
        ICategoryDal _categoryDal;
        //public CategoryManager()
        //{
        //    EfCategoryRepository = new EfCategoryRepository();  
        //}

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //CategoryRepository categoryRepository = new CategoryRepository();
        //----------------------2-------------------------------------------
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public void CategoryAdd(Category category)
        //{
        //    //if (category.CategoryName!=""&&category.CategoryDescription!=""&&
        //    //    category.CategoryName.Length>=5&& category.CategoryStatus==true)
        //    //{
        //    //    categoryRepository.AddCategory(category);
        //    //}
        //    //else
        //    //{
        //    //    //Hata Mesajı 
        //    //}
        //    //categoryRepository.AddCategory(category);
        //    //------------------2--------------------------
        //    //EfCategoryRepository.Insert(category);
        //    _categoryDal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    //if (category.CategoryId != 0) {
        //    //    repo.Delete(category);
        //    //}
        //    //EfCategoryRepository.Delete(category);
        //    _categoryDal.Delete(category);
        //}

        //public void CategoryUpdate(Category category)
        //{
        //    //EfCategoryRepository.Update(category);
        //    _categoryDal.Update(category);

        //}

        public Category TGetById(int id)
        {
            //return EfCategoryRepository.GetById(id);
            return _categoryDal.GetById(id);

        }

        public List<Category> GetList()
        {
            //return EfCategoryRepository.GetListAll();
            return _categoryDal.GetListAll();

        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
