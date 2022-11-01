using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AVPZ_Lab05
{
    /// <summary>
    /// Interaction logic for Stage1.xaml
    /// </summary>
    public partial class Stage1 : Window
    {
        public Stage1()
        {
            InitializeComponent();
            double Max = 18;

            var rand = new Random();
            double sum = 0;
            double techMax = 7;
            TDataLabel1.Content = rand.Next(0, 2);
            TDataLabel2.Content = rand.Next(0, 2);
            TDataLabel3.Content = rand.Next(0, 2);
            TDataLabel4.Content = rand.Next(0, 2);
            TDataLabel5.Content = rand.Next(0, 2);
            TDataLabel6.Content = rand.Next(0, 2);
            TDataLabel7.Content = rand.Next(0, 2);
            SumTech.Content = ((Convert.ToInt32(TDataLabel1.Content)
                            + Convert.ToInt32(TDataLabel2.Content)
                            + Convert.ToInt32(TDataLabel3.Content)
                            + Convert.ToInt32(TDataLabel4.Content)
                            + Convert.ToInt32(TDataLabel5.Content)
                            + Convert.ToInt32(TDataLabel6.Content)
                            + Convert.ToInt32(TDataLabel7.Content)));
            TechPercent.Content = Convert.ToInt32(SumTech.Content) / Max * 100.0;

            double costMax = 3;
            VDataLabel1.Content = rand.Next(0, 2);
            VDataLabel2.Content = rand.Next(0, 2);
            VDataLabel3.Content = rand.Next(0, 2);
            SumCost.Content = ((Convert.ToInt32(VDataLabel1.Content)
                            + Convert.ToInt32(VDataLabel2.Content)
                            + Convert.ToInt32(VDataLabel3.Content)));
            CostPercent.Content = Convert.ToInt32(SumCost.Content) / Max * 100.0;

            double planMax = 3;
            PDataLabel1.Content = rand.Next(0, 2);
            PDataLabel2.Content = rand.Next(0, 2);
            PDataLabel3.Content = rand.Next(0, 2);
            SumPlan.Content = ((Convert.ToInt32(TDataLabel1.Content)
                            + Convert.ToInt32(TDataLabel2.Content)
                            + Convert.ToInt32(TDataLabel3.Content)
                            + Convert.ToInt32(TDataLabel4.Content)));
            PlanPercent.Content = Convert.ToInt32(SumPlan.Content) / Max * 100.0;

            double realMax = 5;
            RDataLabel1.Content = rand.Next(0, 2);
            RDataLabel2.Content = rand.Next(0, 2);
            RDataLabel3.Content = rand.Next(0, 2);
            RDataLabel4.Content = rand.Next(0, 2);
            RDataLabel5.Content = rand.Next(0, 2);
            SumReal.Content = ((Convert.ToInt32(TDataLabel1.Content)
                            + Convert.ToInt32(TDataLabel2.Content)
                            + Convert.ToInt32(TDataLabel3.Content)
                            + Convert.ToInt32(TDataLabel4.Content)
                            + Convert.ToInt32(TDataLabel5.Content)));
            RealPercent.Content = Convert.ToInt32(SumReal.Content) / Max * 100.0;

            AllPercent.Content = (Convert.ToDouble(SumTech.Content)
                               + Convert.ToDouble(SumCost.Content)
                               + Convert.ToDouble(SumPlan.Content)
                               + Convert.ToDouble(SumReal.Content)) / Max * 100;

            //RDataLabel6.Content;



            InitializeComponent();
            double Max2 = 41;

            TechLabel1.Content = rand.Next(0, 2);
            TechLabel2.Content = rand.Next(0, 2);
            TechLabel3.Content = rand.Next(0, 2);
            TechLabel4.Content = rand.Next(0, 2);
            TechLabel5.Content = rand.Next(0, 2);
            TechLabel6.Content = rand.Next(0, 2);
            TechLabel7.Content = rand.Next(0, 2);
            TechLabel8.Content = rand.Next(0, 2);
            TechLabel9.Content = rand.Next(0, 2);
            TechLabel10.Content = rand.Next(0, 2);
            TechLabel11.Content = rand.Next(0, 2);

            TechSum.Content = (Convert.ToInt32(TechLabel1.Content)
                            + Convert.ToInt32(TechLabel2.Content)
                            + Convert.ToInt32(TechLabel3.Content)
                            + Convert.ToInt32(TechLabel4.Content)
                            + Convert.ToInt32(TechLabel5.Content)
                            + Convert.ToInt32(TechLabel6.Content)
                            + Convert.ToInt32(TechLabel7.Content)
                            + Convert.ToInt32(TechLabel8.Content)
                            + Convert.ToInt32(TechLabel9.Content)
                            + Convert.ToInt32(TechLabel10.Content)
                            + Convert.ToInt32(TechLabel11.Content));
            TechPercent1.Content = Convert.ToInt32(TechSum.Content) / Max2 * 100;

            CostLabel1.Content = rand.Next(0, 2);
            CostLabel2.Content = rand.Next(0, 2);
            CostLabel3.Content = rand.Next(0, 2);
            CostLabel4.Content = rand.Next(0, 2);
            CostLabel5.Content = rand.Next(0, 2);
            CostLabel6.Content = rand.Next(0, 2);
            CostLabel7.Content = rand.Next(0, 2);

            CostSum.Content = Convert.ToInt32(CostLabel1.Content)
                            + Convert.ToInt32(CostLabel2.Content)
                            + Convert.ToInt32(CostLabel3.Content)
                            + Convert.ToInt32(CostLabel4.Content)
                            + Convert.ToInt32(CostLabel5.Content)
                            + Convert.ToInt32(CostLabel6.Content)
                            + Convert.ToInt32(CostLabel7.Content);
            CostPercent1.Content = Convert.ToInt32(CostSum.Content) / Max2 * 100;

            PlanLabel1.Content = rand.Next(0, 2);
            PlanLabel2.Content = rand.Next(0, 2);
            PlanLabel3.Content = rand.Next(0, 2);
            PlanLabel4.Content = rand.Next(0, 2);
            PlanLabel5.Content = rand.Next(0, 2);
            PlanLabel6.Content = rand.Next(0, 2);
            PlanLabel7.Content = rand.Next(0, 2);
            PlanLabel8.Content = rand.Next(0, 2);
            PlanLabel9.Content = rand.Next(0, 2);

            PlanSum.Content = Convert.ToInt32(PlanLabel1.Content)
                + Convert.ToInt32(PlanLabel2.Content)
                + Convert.ToInt32(PlanLabel3.Content)
                + Convert.ToInt32(PlanLabel4.Content)
                + Convert.ToInt32(PlanLabel5.Content)
                + Convert.ToInt32(PlanLabel6.Content)
                + Convert.ToInt32(PlanLabel7.Content)
                + Convert.ToInt32(PlanLabel8.Content)
                + Convert.ToInt32(PlanLabel9.Content);

            PlanPercent1.Content = Convert.ToInt32(PlanSum.Content) / Max2 * 100;

            RealLabel1.Content = rand.Next(0, 2);
            RealLabel2.Content = rand.Next(0, 2);
            RealLabel3.Content = rand.Next(0, 2);
            RealLabel4.Content = rand.Next(0, 2);
            RealLabel5.Content = rand.Next(0, 2);
            RealLabel6.Content = rand.Next(0, 2);
            RealLabel7.Content = rand.Next(0, 2);
            RealLabel8.Content = rand.Next(0, 2);
            RealLabel9.Content = rand.Next(0, 2);
            RealLabel10.Content = rand.Next(0, 2);
            RealLabel11.Content = rand.Next(0, 2);
            RealLabel12.Content = rand.Next(0, 2);
            RealLabel13.Content = rand.Next(0, 2);
            RealLabel14.Content = rand.Next(0, 2);

            RealSum.Content = Convert.ToInt32(RealLabel1.Content)
                           + Convert.ToInt32(RealLabel2.Content)
                           + Convert.ToInt32(RealLabel3.Content)
                           + Convert.ToInt32(RealLabel4.Content)
                           + Convert.ToInt32(RealLabel5.Content)
                           + Convert.ToInt32(RealLabel6.Content)
                           + Convert.ToInt32(RealLabel7.Content)
                           + Convert.ToInt32(RealLabel8.Content)
                           + Convert.ToInt32(RealLabel9.Content)
                           + Convert.ToInt32(RealLabel10.Content)
                           + Convert.ToInt32(RealLabel11.Content)
                           + Convert.ToInt32(RealLabel12.Content)
                           + Convert.ToInt32(RealLabel13.Content)
                           + Convert.ToInt32(RealLabel14.Content);

            RealPercent1.Content = Convert.ToInt32(RealSum.Content) / Max2 * 100;

            AllRiskPercent.Content = (Convert.ToInt32(TechSum.Content) + Convert.ToInt32(CostSum.Content)
                                   + Convert.ToInt32(PlanSum.Content) + Convert.ToInt32(RealSum.Content)) / Max2 * 100;
        }
    }
}
