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
    /// Interaction logic for Stage1_2.xaml
    /// </summary>
    public partial class Stage1_2 : Window
    {
        public Stage1_2()
        {
            InitializeComponent();
            double Max = 41;

            var rand = new Random();

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
            TechPercent.Content = Convert.ToInt32(TechSum.Content)  / Max * 100;

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
            CostPercent.Content = Convert.ToInt32(CostSum.Content) / Max * 100;

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

            PlanPercent.Content = Convert.ToInt32(PlanSum.Content) / Max * 100;

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

            RealPercent.Content = Convert.ToInt32(RealSum.Content) / Max * 100;

            AllRiskPercent.Content = (Convert.ToInt32(TechSum.Content) + Convert.ToInt32(CostSum.Content)
                                   + Convert.ToInt32(PlanSum.Content) + Convert.ToInt32(RealSum.Content)) / Max * 100;
        }
    }
}
