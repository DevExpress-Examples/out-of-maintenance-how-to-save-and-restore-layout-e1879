using System;

namespace SaveAndRestoreLayout {
    public partial class _Default : System.Web.UI.Page {
        protected void ASPxButton1_Click(object sender, EventArgs e) {
            Session["Layout"] = ASPxPivotGrid1.SaveLayout();
        }
        protected void ASPxButton2_Click(object sender, EventArgs e) {
            string layout = (string)Session["Layout"];
            if (layout == null) {
                return;
            }
            ASPxPivotGrid1.LoadLayout(layout);
        }
    }
}
