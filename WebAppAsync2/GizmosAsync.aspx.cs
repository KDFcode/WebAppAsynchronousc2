using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAsync2.Service;

namespace WebAppAsync2
{
    public partial class GizmosAsync : System.Web.UI.Page
    {

        protected string formID;

        protected string gridID;

        protected string ahrefID;
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetGizmosSvcAsync));
           // this.formID = form1.ClientID.ToString();// po https://www.aspsnippets.com/Articles/Using-multiple-instances-of-same-UserControl-on-Page-with-JavaScript-in-ASPNet.aspx
            this.gridID = GizmosGridView.ClientID.ToString();
           // this.ahrefID = A1.ClientID.ToString();
        }

        private async Task GetGizmosSvcAsync()
        {
            var gizmoService = new GizmoService();
            GizmosGridView.DataSource = await gizmoService.GetGizmosAsync();
            GizmosGridView.DataBind();  //sto mi ovo ne prepoznaje iz .aspx fajla?
                                        //jer sam bio lupio html deo van asp content taga pa ga nije prepoznavao jelte
        }
    }
}