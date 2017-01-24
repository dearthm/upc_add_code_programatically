using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace AddCode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Control ctrToFind = this.FindControl("theBody"); //Find the body element for later use
            if (ctrToFind != null)
            {
                //Get ctr parent
                Control ctr2 = ctrToFind.Parent;
                Response.Write("Parent of the 'Body' is : " + ctr2.ID);
            }
            else
            {
                Response.Write("Parent not found");
            }

            //HtmlControl ctrDiv = new HtmlGenericControl("div");
            //ctrDiv.Attributes.Add("id", "myDiv");
            //ctrToFind.Controls.Add(ctrDiv); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            


        }
    }


    }
