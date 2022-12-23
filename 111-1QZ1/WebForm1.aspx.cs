using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Mlndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for(int i_Col = 0; i_Col < 10; i_Col++)
                {
                    ia_Map[i_Row, i_Col] = '0';
                }
            }
            for (int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                int i Row = ia Mlndex[i Ct] / 10;
                int i_Col = ia MIndex[i _Ct] % 10;
                ia_Map[i _Row, i_Col] = *;
            }
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for(int i_Col = 0; i_Col < 10; i_Col++)
                {
                    Response.Write(ia_Map[i_Row, i_Col]);
                }
                Response.Write("<br>");
            }
    }
}