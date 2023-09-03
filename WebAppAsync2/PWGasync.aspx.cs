using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAsync2.Models;
using WebAppAsync2.Service;

namespace WebAppAsync2
{
    public partial class PWGasync : System.Web.UI.Page
    {


        protected string formID;

        protected string GizmoGridID;


        protected string WidgetGridID;


        protected string ProductGridID;

        protected string ahrefID;
        protected void Page_Load(object sender, EventArgs e)
        {

            this.formID = form1.ClientID.ToString();// po https://www.aspsnippets.com/Articles/Using-multiple-instances-of-same-UserControl-on-Page-with-JavaScript-in-ASPNet.aspx
            this.GizmoGridID = GizmoGridView.ClientID.ToString();
            this.WidgetGridID = WidgetGridView.ClientID.ToString();
            this.ProductGridID = ProductGridView.ClientID.ToString();
            this.ahrefID = A1.ClientID.ToString();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            RegisterAsyncTask(new PageAsyncTask(GetPWGsrvAsync));
            stopWatch.Stop();
            ElapsedTimeLabel.Text = String.Format("Elapsed time: {0}", stopWatch.Elapsed.Milliseconds / 1000.0);
            //sto ovo zeza?ne bi trebalo da bude ikakav problem jer je ovbo deo  System.Web.UI.WebControls price koji je vec ubacen?
            //jer nije bilo lepo instancirano tamo u samom .aspx fajlu
        }

        private async Task GetPWGsrvAsync()
        {
            var widgetService = new WidgetService();
            var prodService = new ProductService();
            var gizmoService = new GizmoService();

            var widgetTask = widgetService.GetWidgetsAsync();
            var prodTask = prodService.GetProductsAsync();
            var gizmoTask = gizmoService.GetGizmosAsync();

            await Task.WhenAll(widgetTask, prodTask, gizmoTask);

            var pwgVM = new ProdGizWidgetVM(
               widgetTask.Result,
               prodTask.Result,
               gizmoTask.Result
               );

            WidgetGridView.DataSource = pwgVM.widgetList;
            WidgetGridView.DataBind();
            ProductGridView.DataSource = pwgVM.prodList;
            ProductGridView.DataBind();
            GizmoGridView.DataSource = pwgVM.gizmoList;
            GizmoGridView.DataBind();
        }
    }
}