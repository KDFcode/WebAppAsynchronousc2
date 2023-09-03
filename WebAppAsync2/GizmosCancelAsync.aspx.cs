using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAsync2.Service;

namespace WebAppAsync2
{
    public partial class GizmosCancelAsync : System.Web.UI.Page
    {


        protected string formID;

        protected string gridID;

        protected string ahrefID;
        protected void Page_Load(object sender, EventArgs e)
        {

            this.formID = form1.ClientID.ToString();// po https://www.aspsnippets.com/Articles/Using-multiple-instances-of-same-UserControl-on-Page-with-JavaScript-in-ASPNet.aspx
            this.gridID = GizmosGridView.ClientID.ToString();
            this.ahrefID = A1.ClientID.ToString();


            RegisterAsyncTask(new PageAsyncTask(GetGizmosSvcCancelAsync));
        }

        private async Task GetGizmosSvcCancelAsync(CancellationToken cancellationToken)
        {

            var gizmoService = new GizmoService();
            var gizmoList = await gizmoService.GetGizmosAsync(cancellationToken);
            GizmosGridView.DataSource = gizmoList;
            GizmosGridView.DataBind();
        }
        private void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();

            if (exc is TimeoutException)
            {
                // Pass the error on to the Timeout Error page
                Server.Transfer("TimeoutErrorPage.aspx", true);
            }
        }
    }
}