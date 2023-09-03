using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAsync2.Service;


namespace WebAppAsync2
{
    public partial class Gizmos : System.Web.UI.Page
    {

        protected string formID;

        protected string gridID;

        protected string ahrefID;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.formID=form1.ClientID.ToString();// po https://www.aspsnippets.com/Articles/Using-multiple-instances-of-same-UserControl-on-Page-with-JavaScript-in-ASPNet.aspx
            this.gridID = GizmoGridView.ClientID.ToString();
            this.ahrefID =A1.ClientID.ToString();

            var gizmoService = new GizmoService();
            GizmoGridView.DataSource = gizmoService.GetGizmos();
            GizmoGridView.DataBind(); //sto mi ovo ne prepoznaje iz .aspx fajla?
            //jer sam bio lupio html deo van asp content taga pa ga nije prepoznavao jelte


        }
    }
}