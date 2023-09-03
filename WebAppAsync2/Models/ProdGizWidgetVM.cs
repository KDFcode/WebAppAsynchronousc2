﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAsync2.Models
{
    public class ProdGizWidgetVM
    {

        public ProdGizWidgetVM(IEnumerable<Widget> wList,
               IEnumerable<Product> pList,
            IEnumerable<Gizmo> gList)
        {
            widgetList = wList;
            prodList = pList;
            gizmoList = gList;
        }
        public IEnumerable<Widget> widgetList { get; set; }
        public IEnumerable<Product> prodList { get; set; }
        public IEnumerable<Gizmo> gizmoList { get; set; }
    }
}