﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Education
{
    public class EducationList:ViewComponent
    {
        EducationManager educationManager = new EducationManager(new EfEducationDal());
        public IViewComponentResult Invoke()
        {
            var values = educationManager.TGetList();
            return View(values);
        }
    }
}
