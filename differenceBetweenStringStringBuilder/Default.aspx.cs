using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace differenceBetweenStringStringBuilder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void stringButton_Click(object sender, EventArgs e)
        {
            string result = "This is a simple string.";
            result = result + " And this is actually a new string!";
            resultLabel.Text = result;
        }

        protected void stringBuilderButton_Click(object sender, EventArgs e)
        {
            StringBuilder _sb = new StringBuilder();
            _sb.Append("This ");
            _sb.Append("is ");
            _sb.Append("a ");
            _sb.Append("string ");
            _sb.Append("made ");
            _sb.Append("with ");
            _sb.Append("StringBuilder!");
            resultLabel.Text = _sb.ToString();
        }

        
    }
}