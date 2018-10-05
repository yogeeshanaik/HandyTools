

using AssociatePayroll.BAL.Master;
using AssociatePayroll.Core.Models.Master;
using System;
using System.Linq;
using System.Web.Mvc;

namespace AssociatePayroll.Web.Controllers
{
    public class GstMasterController : BaseController
    {
  
        #region properties
        public int UserId
        {
            get
            {
                //store the object in session if not already stored
                if (Session["UserId"] == null)
                    Session["UserId"] = 0;

                //return the object from session
                return (int)Session["UserId"];
            }
        }
        

        private GstMasterBusiness _service;
        public GstMasterBusiness GstMasterService
        {
            get
            {
                //store the object in session if not already stored
                if (_service == null)
                    _service = new GstMasterBusiness();

                //return the object from session
                return _service;
            }
        }
        #endregion

    
    
		private static Lazy<MultiSelectList> _tbl_stateList = new Lazy<MultiSelectList>(() => Gettbl_StateList());
		public static MultiSelectList tbl_StateList{get { return _tbl_state.Value; }}
		
		private static MultiSelectList Gettbl_StateList() { var list = new BusinessBase().Gettbl_StateList(); return new MultiSelectList(list, "State_Id", "State_Name"); }
		
		
		private static Lazy<MultiSelectList> _tbl_userList = new Lazy<MultiSelectList>(() => Gettbl_UserList());
		public static MultiSelectList tbl_UserList{get { return _tbl_user.Value; }}
		
		private static MultiSelectList Gettbl_UserList() { var list = new BusinessBase().Gettbl_UserList(); return new MultiSelectList(list, "User_Id", "UserName"); }
		
		
    
        public ActionResult Index(int? page, int? pageSize, int id = 0)
        {
            int pageno = 0;
            pageno = page == null ? 1 : int.Parse(page.ToString());

            var model = new GstMaster()
            {
                Action = "Get",
                UserId = UserId,
                PageNo = pageno,
                PageSize = pageSize ?? 10
            };

            return View(GetData(model));
        }

        public ActionResult Search(GstMaster model)
        {
            return View("Index",GetData(model));
        }

        Pager<GstMaster> GetData(GstMaster model)
        {
            int totalCount = 0;

            model.Action = "Get";
            model.UserId = UserId;

            var list = GstMasterService.ManageGstMaster(model);

            if (model != null && list.Count() > 0)
                totalCount = list.First().TotalCount;

            Pager<GstMaster> pagedList = new Pager<GstMaster>(list.ToList().AsQueryable(), model.PageNo, model.PageSize, totalCount);
            return pagedList;
        }

        public ActionResult Details(int? id)
        {
            var model = new GstMaster()
            {
                Action = "Get",
                UserId = UserId,
                GstMasterId = Convert.ToInt32(id)
            };
            model = GstMasterService.ManageGstMaster(model).FirstOrDefault();

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new GstMaster();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GstMaster model)
        {
            if (ModelState.IsValid)
            {
                model.Action = "Add";
                model.UserId = UserId;
                model.GstMasterId = GstMasterService.ManageGstMaster(model).FirstOrDefault().GstMasterId;
                Success(string.Format("GstMaster '{0}' created successfully.", model.GstNumber), true);
                return RedirectToAction("Details", new { id = model.GstMasterId });
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = new GstMaster()
            {
                Action = "Get",
                UserId = UserId,
                GstMasterId = id,
            };
            model = GstMasterService.ManageGstMaster(model).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GstMaster model, string SelctedPermissionIds)
        {
            if (ModelState.IsValid)
            {
                model.Action = "Edit";
                model.UserId = UserId;
                GstMasterService.ManageGstMaster(model);
                Success(string.Format("GstMaster '{0}' updated successfully.", model.GstNumber), true);
                return RedirectToAction("Details", new { id = model.GstMasterId });
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = new GstMaster()
            {
                Action = "Get",
                UserId = UserId,
                GstMasterId = id
            };
            model = GstMasterService.ManageGstMaster(model).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(GstMaster model)
        {
            model.Action = "Delete";
            model.UserId = UserId;

            GstMasterService.ManageGstMaster(model);
            Success("GstMaster deleted successfully.", true);
            return RedirectToAction("Index", new { id = model.GstMasterId });
        }

    }
}
