using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webบันทึกการใช้รถบริการ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

         // Variable of Mile start ////////////////////////////////////////////////////////////////////////////
            int ns1 = Convert.ToInt32(TStart1.Text);
            int ns2 = Convert.ToInt32(TStart2.Text);
            int ns3 = Convert.ToInt32(TStart3.Text);
            int ns4 = Convert.ToInt32(TStart4.Text);
            int ns5 = Convert.ToInt32(TStart5.Text);
            int ns6 = Convert.ToInt32(TStart6.Text);
            int ns7 = Convert.ToInt32(TStart7.Text);
            int ns8 = Convert.ToInt32(TStart8.Text);
            int ns9 = Convert.ToInt32(TStart9.Text);
            int ns10 = Convert.ToInt32(TStart10.Text);
            int ns11 = Convert.ToInt32(TStart11.Text);
            int ns12 = Convert.ToInt32(TStart12.Text);
            int ns13 = Convert.ToInt32(TStart13.Text);
            int ns14 = Convert.ToInt32(TStart14.Text);
            int ns15 = Convert.ToInt32(TStart15.Text);
            int ns16 = Convert.ToInt32(TStart16.Text);
            int ns17 = Convert.ToInt32(TStart17.Text);
            int ns18 = Convert.ToInt32(TStart18.Text);
            int ns19 = Convert.ToInt32(TStart19.Text);
            int ns20 = Convert.ToInt32(TStart20.Text);
            int ns21 = Convert.ToInt32(TStart21.Text);
            int ns22 = Convert.ToInt32(TStart22.Text);
            int ns23 = Convert.ToInt32(TStart23.Text);
            int ns24 = Convert.ToInt32(TStart24.Text);
            int ns25 = Convert.ToInt32(TStart25.Text);
            int ns26 = Convert.ToInt32(TStart26.Text);
            int ns27 = Convert.ToInt32(TStart27.Text);
            int ns28 = Convert.ToInt32(TStart28.Text);
            int ns29 = Convert.ToInt32(TStart29.Text);
            int ns30 = Convert.ToInt32(TStart30.Text);
            int ns31 = Convert.ToInt32(TStart31.Text);

            // Variable of Mile end///////////////////////////////////////////////////////////////////////////
            int ne1 = Convert.ToInt32(TEnd1.Text);
            int ne2 = Convert.ToInt32(TEnd2.Text);
            int ne3 = Convert.ToInt32(TEnd3.Text);
            int ne4 = Convert.ToInt32(TEnd4.Text);
            int ne5 = Convert.ToInt32(TEnd5.Text);
            int ne6 = Convert.ToInt32(TEnd6.Text);
            int ne7 = Convert.ToInt32(TEnd7.Text);
            int ne8 = Convert.ToInt32(TEnd8.Text);
            int ne9 = Convert.ToInt32(TEnd9.Text);
            int ne10 = Convert.ToInt32(TEnd10.Text);
            int ne11 = Convert.ToInt32(TEnd11.Text);
            int ne12 = Convert.ToInt32(TEnd12.Text);
            int ne13 = Convert.ToInt32(TEnd13.Text);
            int ne14 = Convert.ToInt32(TEnd14.Text);
            int ne15 = Convert.ToInt32(TEnd15.Text);
            int ne16 = Convert.ToInt32(TEnd16.Text);
            int ne17 = Convert.ToInt32(TEnd17.Text);
            int ne18 = Convert.ToInt32(TEnd18.Text);
            int ne19 = Convert.ToInt32(TEnd19.Text);
            int ne20 = Convert.ToInt32(TEnd20.Text);
            int ne21 = Convert.ToInt32(TEnd21.Text);
            int ne22 = Convert.ToInt32(TEnd22.Text);
            int ne23 = Convert.ToInt32(TEnd23.Text);
            int ne24 = Convert.ToInt32(TEnd24.Text);
            int ne25 = Convert.ToInt32(TEnd25.Text);
            int ne26 = Convert.ToInt32(TEnd26.Text);
            int ne27 = Convert.ToInt32(TEnd27.Text);
            int ne28 = Convert.ToInt32(TEnd28.Text);
            int ne29 = Convert.ToInt32(TEnd29.Text);
            int ne30 = Convert.ToInt32(TEnd30.Text);
            int ne31 = Convert.ToInt32(TEnd31.Text);

            // Variable of Total///////////////////////////////////////////////////////////////////////////
            int nt1 = Convert.ToInt32(TextTotal1.Text);
            int nt2 = Convert.ToInt32(TextTotal2.Text);
            int nt3 = Convert.ToInt32(TextTotal3.Text);
            int nt4 = Convert.ToInt32(TextTotal4.Text);
            int nt5 = Convert.ToInt32(TextTotal5.Text);
            int nt6 = Convert.ToInt32(TextTotal6.Text);
            int nt7 = Convert.ToInt32(TextTotal7.Text);
            int nt8 = Convert.ToInt32(TextTotal8.Text);
            int nt9 = Convert.ToInt32(TextTotal9.Text);
            int nt10 = Convert.ToInt32(TextTotal10.Text);
            int nt11 = Convert.ToInt32(TextTotal11.Text);
            int nt12 = Convert.ToInt32(TextTotal12.Text);
            int nt13 = Convert.ToInt32(TextTotal13.Text);
            int nt14 = Convert.ToInt32(TextTotal14.Text);
            int nt15 = Convert.ToInt32(TextTotal15.Text);
            int nt16 = Convert.ToInt32(TextTotal16.Text);
            int nt17 = Convert.ToInt32(TextTotal17.Text);
            int nt18 = Convert.ToInt32(TextTotal18.Text);
            int nt19 = Convert.ToInt32(TextTotal19.Text);
            int nt20 = Convert.ToInt32(TextTotal20.Text);
            int nt21 = Convert.ToInt32(TextTotal21.Text);
            int nt22 = Convert.ToInt32(TextTotal22.Text);
            int nt23 = Convert.ToInt32(TextTotal23.Text);
            int nt24 = Convert.ToInt32(TextTotal24.Text);
            int nt25 = Convert.ToInt32(TextTotal25.Text);
            int nt26 = Convert.ToInt32(TextTotal26.Text);
            int nt27 = Convert.ToInt32(TextTotal27.Text);
            int nt28 = Convert.ToInt32(TextTotal28.Text);
            int nt29 = Convert.ToInt32(TextTotal29.Text);
            int nt30 = Convert.ToInt32(TextTotal30.Text);
            int nt31 = Convert.ToInt32(TextTotal31.Text);
            int sumnt = (nt1+nt2+nt3+nt4+nt5+nt6+nt7+nt8+nt9+nt10+nt11+nt12+nt13+nt14+nt15+nt16+nt17+nt18+nt19+nt20+nt21+nt22+nt23
                        +nt24+nt25+nt26+nt27+nt28+nt29+nt30+nt31);

            TextTotal1.Text = Convert.ToString(ns2-ns1);
            TextTotalAll.Text = Convert.ToString(sumnt);


        }
    }
}
