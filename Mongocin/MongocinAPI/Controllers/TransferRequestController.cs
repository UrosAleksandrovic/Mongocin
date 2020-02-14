using System.Web.Mvc;
using MongocinAPI.Models;
using MongocinAPI.Services;

namespace MongocinAPI.Controllers
{
    public class TransferRequestController : Controller
    {
        #region Attributes

        private TransferService _transferService;

        #endregion

        #region Constructors

        public TransferRequestController()
        {
            _transferService = new TransferService();
        }

        #endregion

        #region Actions

        [HttpGet]
        public ActionResult Get(string Id)
        {
            TransferRequest Result = _transferService.GetTransferRequest(Id);
            JsonResult Response = new JsonResult();
            Response.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            Response.Data = Result;
            return Response;
        }

        [HttpPost]
        public ActionResult Delete(string Id)
        {
            if (_transferService.DeleteTransfer(Id))
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        }

        [HttpPost]
        public ActionResult Create(TransferRequest TransferRequest)
        {
            if (TransferRequest.ProductList == null ||
                TransferRequest.ShopId == null ||
                TransferRequest.StorageId == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            if (_transferService.InsertTransferRequest(TransferRequest))
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            else
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult Edit(TransferRequest TransferToEdit)
        {
            if (TransferToEdit.ProductList == null ||
                TransferToEdit.ShopId == null ||
                TransferToEdit.StorageId == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            if (_transferService.UpdateTransferRequest(TransferToEdit))
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        }

        public ActionResult Index => View();

        #endregion
    }
}