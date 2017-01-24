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

            //HtmlGenericControl my_js = new HtmlGenericControl("script");
            //my_js.Attributes["async"] = "async";
            //my_js.Attributes["type"] = "text/javascript";
            //my_js.Attributes["src"] = "http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js";
            //Page.Header.Controls.Add(my_js);

            //HtmlGenericControl my_div = new HtmlGenericControl("div");
            //my_div.Attributes["id"] = "mike";
            //Page.Header.Controls.Add(my_div);
            // my_div.InnerText = "Mike";//Over written by lower statement, this is straight text, below enters actual HTML
            //my_div.Attributes.Add("class", "container");
            ////Add content
            //my_div.InnerHtml = "<h1>Hello <b>World</b></h1>";

            //*************************************************************************
            //Add divs and controls programatically
            //Find the body element for later use
            //The element to be searched must have the runat="server" attribute included
            Control ctrToFind = this.FindControl("theTitle"); 
            if (ctrToFind != null)
            {
                //Get ctr parent
                Control ctr2 = ctrToFind.Parent;
                Response.Write("Parent of the 'thebody' is : " + ctr2.ID);
            }
            else
            {
                Response.Write("Parent not found");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Used to find a control and it's parent
            //Control ctr = FindControl("Button1");
            //if (ctr!= null)
            //{
            //    //Get ctr parent
            //    Control ctr2 = ctr.Parent;
            //    Response.Write("Parent of the 'Button1' is : " + ctr2.ID);
            //}
            //else
            //{
            //    Response.Write("Parent not found");
            //}

            Control ctrToFind = this.FindControl("theBody"); //Find the body element for later use
            if (ctrToFind != null)
            {
                //Get ctr parent
                Control ctr2 = ctrToFind.Parent;
                Response.Write("Parent of the 'Button1' is : " + ctr2.ID);
            }
            else
            {
                Response.Write("Parent not found");
            }

            //HtmlControl ctrDiv = new HtmlGenericControl("div");
            //ctrDiv.Attributes.Add("id", "myDiv");
            //ctrToFind.Controls.Add(ctrDiv);


        }
    }


    }
