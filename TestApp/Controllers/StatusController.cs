using BusinessLogic;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    [Authorize]
    public class StatusController : Controller
    {
        private MainBLL mainBLL = new MainBLL();
        // GET: Status
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStatus()
        {
            try
            {
                var status = mainBLL.GetStatus();
                return Json(status, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void AddStatus(TransportStatus statusData)
        {
            try
            {
                mainBLL.AddStatus(statusData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditStatus(TransportStatus statusData)
        {
            try
            {
                mainBLL.EditStatus(statusData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteStatus(int Id)
        {
            try
            {
                mainBLL.DeleteStatus(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public JsonResult StatusDropdown()
        {
            try
            {
                var dropdown = mainBLL.StatusDropdown();
                return Json(dropdown, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}