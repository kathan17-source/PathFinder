using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathFinder
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Session["ChapterValue"]!=null)
            {
                drpChapter.SelectedItem.Value = Convert.ToString(Session["ChapterValue"]);
                drpChapter.SelectedItem.Text = Convert.ToString(Session["ChapterName"]);
            }
        }

        protected void drpChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ChapterValue"] = drpChapter.SelectedItem.Value;
            if (drpChapter.SelectedItem.Value == "1")
            {
                Session["ChapterName"] = "01 Kinematics of Translational Motion";
                Response.Redirect("01_kinematics.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "2")
            {
                Session["ChapterName"] = "02 Newton's Laws of Motion";
                Response.Redirect("02_LawsOfMotion.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "3")
            {
                drpChapter.SelectedItem.Text = "03 Methods of Work and Energy";
                Response.Redirect("03_WorkEnergyAndPower.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "4")
            {
                Session["ChapterName"] = "04 Centre Of Mass";
                Response.Redirect("04_CentreOfMass.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "5")
            {
                Session["ChapterName"] = "05 Rotational Motion";
                Response.Redirect("05_Rotation.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "6")
            {
                Session["ChapterName"] = "06 Gravitation";
                Response.Redirect("06_Gravitation.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "7")
            {
                Session["ChapterName"] = "07 Fluid Mechanics";
                Response.Redirect("07_Fluids.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "8")
            {
                Session["ChapterName"] = "08 Thermal Physics";
                Response.Redirect("08_ThermalPhysics.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "9")
            {
                Session["ChapterName"] = "09 Properties of Matter";
                Response.Redirect("09_PropertiesOfMatter.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "10")
            {
                Session["ChapterName"] = "10 Waves and Oscillations";
                Response.Redirect("10_WavesAndOscillations.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "11")
            {
                Session["ChapterName"] = "11 Ray and Wave Optics";
                Response.Redirect("11_Optics.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "12")
            {
                Session["ChapterName"] = "12 Electrostatics";
                Response.Redirect("12_Electrostatics.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "13")
            {
                Session["ChapterName"] = "13 Electric Current";
                Response.Redirect("13_ElectricCurrent.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "14")
            {
                Session["ChapterName"] = "14 Magnetic Effects of Electric Current";
                Response.Redirect("14_MagneticEffectsOfCurrent.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "15")
            {
                Session["ChapterName"] = "15 Electromagnetic Induction";
                Response.Redirect("15_ElectromagneticInduction.aspx");
            }
            else if (drpChapter.SelectedItem.Value == "16")
            {
                Session["ChapterName"] = "16 Modern Physics";
                Response.Redirect("16_ModernPhysics.aspx");
            }
        }
    }
}