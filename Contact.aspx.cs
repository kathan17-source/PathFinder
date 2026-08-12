using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathFinder
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["ChapterValue"] = "0";
            Session["ChapterName"] = "PathFinder Solution";
        }
    }
}