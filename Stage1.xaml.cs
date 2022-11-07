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
        int checkLoad = 0;
        public Stage1()
        {
            InitializeComponent();
            double Max = 18;

            var rand = new Random();
            double sum = 0;
            double techMax = 7;
            SumTech.Content = ((Convert.ToInt32(TDataLabel1.SelectedIndex)
                            + Convert.ToInt32(TDataLabel2.SelectedIndex)
                            + Convert.ToInt32(TDataLabel3.SelectedIndex)
                            + Convert.ToInt32(TDataLabel4.SelectedIndex)
                            + Convert.ToInt32(TDataLabel5.SelectedIndex)
                            + Convert.ToInt32(TDataLabel6.SelectedIndex)
                            + Convert.ToInt32(TDataLabel7.SelectedIndex)));
            TechPercent.Content = Convert.ToInt32(SumTech.Content) / Max * 100.0;

            double costMax = 3;
            SumCost.Content = ((Convert.ToInt32(VDataLabel1.SelectedIndex)
                            + Convert.ToInt32(VDataLabel2.SelectedIndex)
                            + Convert.ToInt32(VDataLabel3.SelectedIndex)));
            CostPercent.Content = Convert.ToInt32(SumCost.Content) / Max * 100.0;

            double planMax = 3;
            SumPlan.Content = ((Convert.ToInt32(PDataLabel1.SelectedIndex)
                            + Convert.ToInt32(PDataLabel2.SelectedIndex)
                            + Convert.ToInt32(PDataLabel3.SelectedIndex)));
            PlanPercent.Content = Convert.ToInt32(SumPlan.Content) / Max * 100.0;

            double realMax = 5;
            SumReal.Content = ((Convert.ToInt32(RDataLabel1.SelectedIndex)
                            + Convert.ToInt32(RDataLabel2.SelectedIndex)
                            + Convert.ToInt32(RDataLabel3.SelectedIndex)
                            + Convert.ToInt32(RDataLabel4.SelectedIndex)
                            + Convert.ToInt32(RDataLabel5.SelectedIndex)));
            RealPercent.Content = Convert.ToInt32(SumReal.Content) / Max * 100.0;

            AllPercent.Content = (Convert.ToDouble(SumTech.Content)
                               + Convert.ToDouble(SumCost.Content)
                               + Convert.ToDouble(SumPlan.Content)
                               + Convert.ToDouble(SumReal.Content)) / Max * 100;

            //RDataLabel6.Content;

            double Max2 = 41;

            TechSum.Content = (Convert.ToInt32(TechLabel1.SelectedIndex)
                            + Convert.ToInt32(TechLabel2.SelectedIndex)
                            + Convert.ToInt32(TechLabel3.SelectedIndex)
                            + Convert.ToInt32(TechLabel4.SelectedIndex)
                            + Convert.ToInt32(TechLabel5.SelectedIndex)
                            + Convert.ToInt32(TechLabel6.SelectedIndex)
                            + Convert.ToInt32(TechLabel7.SelectedIndex)
                            + Convert.ToInt32(TechLabel8.SelectedIndex)
                            + Convert.ToInt32(TechLabel9.SelectedIndex)
                            + Convert.ToInt32(TechLabel10.SelectedIndex)
                            + Convert.ToInt32(TechLabel11.SelectedIndex));
            TechPercent1.Content = Convert.ToInt32(TechSum.Content) / Max2 * 100;


            CostSum.Content = Convert.ToInt32(CostLabel1.SelectedIndex)
                            + Convert.ToInt32(CostLabel2.SelectedIndex)
                            + Convert.ToInt32(CostLabel3.SelectedIndex)
                            + Convert.ToInt32(CostLabel4.SelectedIndex)
                            + Convert.ToInt32(CostLabel5.SelectedIndex)
                            + Convert.ToInt32(CostLabel6.SelectedIndex)
                            + Convert.ToInt32(CostLabel7.SelectedIndex);
            CostPercent1.Content = Convert.ToInt32(CostSum.Content) / Max2 * 100;

            PlanSum.Content = Convert.ToInt32(PlanLabel1.SelectedIndex)
                + Convert.ToInt32(PlanLabel2.SelectedIndex)
                + Convert.ToInt32(PlanLabel3.SelectedIndex)
                + Convert.ToInt32(PlanLabel4.SelectedIndex)
                + Convert.ToInt32(PlanLabel5.SelectedIndex)
                + Convert.ToInt32(PlanLabel6.SelectedIndex)
                + Convert.ToInt32(PlanLabel7.SelectedIndex)
                + Convert.ToInt32(PlanLabel8.SelectedIndex)
                + Convert.ToInt32(PlanLabel9.SelectedIndex);

            PlanPercent1.Content = Convert.ToInt32(PlanSum.Content) / Max2 * 100;

            RealSum.Content = Convert.ToInt32(RealLabel1.SelectedIndex)
                           + Convert.ToInt32(RealLabel2.SelectedIndex)
                           + Convert.ToInt32(RealLabel3.SelectedIndex)
                           + Convert.ToInt32(RealLabel4.SelectedIndex)
                           + Convert.ToInt32(RealLabel5.SelectedIndex)
                           + Convert.ToInt32(RealLabel6.SelectedIndex)
                           + Convert.ToInt32(RealLabel7.SelectedIndex)
                           + Convert.ToInt32(RealLabel8.SelectedIndex)
                           + Convert.ToInt32(RealLabel9.SelectedIndex)
                           + Convert.ToInt32(RealLabel10.SelectedIndex)
                           + Convert.ToInt32(RealLabel11.SelectedIndex)
                           + Convert.ToInt32(RealLabel12.SelectedIndex)
                           + Convert.ToInt32(RealLabel13.SelectedIndex)
                           + Convert.ToInt32(RealLabel14.SelectedIndex);

            RealPercent1.Content = Convert.ToInt32(RealSum.Content) / Max2 * 100;

            AllRiskPercent.Content = (Convert.ToInt32(TechSum.Content) + Convert.ToInt32(CostSum.Content)
                                   + Convert.ToInt32(PlanSum.Content) + Convert.ToInt32(RealSum.Content)) / Max2 * 100;


            //Stage3
            PathOfFight0.SelectedIndex = rand.Next(0, 4);
            PathOfFight0.SelectedIndex = rand.Next(0, 4);
            PathOfFight1.SelectedIndex = rand.Next(0, 4);
            PathOfFight2.SelectedIndex = rand.Next(0, 4);
            PathOfFight3.SelectedIndex = rand.Next(0, 4);
            PathOfFight4.SelectedIndex = rand.Next(0, 4);
            PathOfFight5.SelectedIndex = rand.Next(0, 4);
            PathOfFight6.SelectedIndex = rand.Next(0, 4);
            PathOfFight7.SelectedIndex = rand.Next(0, 4);
            PathOfFight8.SelectedIndex = rand.Next(0, 4);
            PathOfFight9.SelectedIndex = rand.Next(0, 4);
            PathOfFight10.SelectedIndex = rand.Next(0, 4);
            PathOfFight11.SelectedIndex = rand.Next(0, 4);
            PathOfFight12.SelectedIndex = rand.Next(0, 4);
            PathOfFight13.SelectedIndex = rand.Next(0, 4);
            PathOfFight14.SelectedIndex = rand.Next(0, 4);
            PathOfFight15.SelectedIndex = rand.Next(0, 4);
            PathOfFight16.SelectedIndex = rand.Next(0, 4);
            PathOfFight17.SelectedIndex = rand.Next(0, 4);
            PathOfFight18.SelectedIndex = rand.Next(0, 4);

            checkLoad = 1;
        }

        private void DataLabel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double Max = 18;

            double sum = 0;
            double techMax = 7;
            if (checkLoad == 1)
            {
                SumTech.Content = ((Convert.ToInt32(TDataLabel1.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel2.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel3.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel4.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel5.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel6.SelectedIndex)
                                            + Convert.ToInt32(TDataLabel7.SelectedIndex)));
                TechPercent.Content = Convert.ToInt32(SumTech.Content) / Max * 100.0;

                double costMax = 3;
                SumCost.Content = ((Convert.ToInt32(VDataLabel1.SelectedIndex)
                                + Convert.ToInt32(VDataLabel2.SelectedIndex)
                                + Convert.ToInt32(VDataLabel3.SelectedIndex)));
                CostPercent.Content = Convert.ToInt32(SumCost.Content) / Max * 100.0;

                double planMax = 3;
                SumPlan.Content = ((Convert.ToInt32(PDataLabel1.SelectedIndex)
                                + Convert.ToInt32(PDataLabel2.SelectedIndex)
                                + Convert.ToInt32(PDataLabel3.SelectedIndex)));
                PlanPercent.Content = Convert.ToInt32(SumPlan.Content) / Max * 100.0;

                double realMax = 5;
                SumReal.Content = ((Convert.ToInt32(RDataLabel1.SelectedIndex)
                                + Convert.ToInt32(RDataLabel2.SelectedIndex)
                                + Convert.ToInt32(RDataLabel3.SelectedIndex)
                                + Convert.ToInt32(RDataLabel4.SelectedIndex)
                                + Convert.ToInt32(RDataLabel5.SelectedIndex)));
                RealPercent.Content = Convert.ToInt32(SumReal.Content) / Max * 100.0;

                AllPercent.Content = (Convert.ToDouble(SumTech.Content)
                                   + Convert.ToDouble(SumCost.Content)
                                   + Convert.ToDouble(SumPlan.Content)
                                   + Convert.ToDouble(SumReal.Content)) / Max * 100;

                double Max2 = 41;

                TechSum.Content = (Convert.ToInt32(TechLabel1.SelectedIndex)
                                + Convert.ToInt32(TechLabel2.SelectedIndex)
                                + Convert.ToInt32(TechLabel3.SelectedIndex)
                                + Convert.ToInt32(TechLabel4.SelectedIndex)
                                + Convert.ToInt32(TechLabel5.SelectedIndex)
                                + Convert.ToInt32(TechLabel6.SelectedIndex)
                                + Convert.ToInt32(TechLabel7.SelectedIndex)
                                + Convert.ToInt32(TechLabel8.SelectedIndex)
                                + Convert.ToInt32(TechLabel9.SelectedIndex)
                                + Convert.ToInt32(TechLabel10.SelectedIndex)
                                + Convert.ToInt32(TechLabel11.SelectedIndex));
                TechPercent1.Content = Convert.ToInt32(TechSum.Content) / Max2 * 100;


                CostSum.Content = Convert.ToInt32(CostLabel1.SelectedIndex)
                                + Convert.ToInt32(CostLabel2.SelectedIndex)
                                + Convert.ToInt32(CostLabel3.SelectedIndex)
                                + Convert.ToInt32(CostLabel4.SelectedIndex)
                                + Convert.ToInt32(CostLabel5.SelectedIndex)
                                + Convert.ToInt32(CostLabel6.SelectedIndex)
                                + Convert.ToInt32(CostLabel7.SelectedIndex);
                CostPercent1.Content = Convert.ToInt32(CostSum.Content) / Max2 * 100;

                PlanSum.Content = Convert.ToInt32(PlanLabel1.SelectedIndex)
                    + Convert.ToInt32(PlanLabel2.SelectedIndex)
                    + Convert.ToInt32(PlanLabel3.SelectedIndex)
                    + Convert.ToInt32(PlanLabel4.SelectedIndex)
                    + Convert.ToInt32(PlanLabel5.SelectedIndex)
                    + Convert.ToInt32(PlanLabel6.SelectedIndex)
                    + Convert.ToInt32(PlanLabel7.SelectedIndex)
                    + Convert.ToInt32(PlanLabel8.SelectedIndex)
                    + Convert.ToInt32(PlanLabel9.SelectedIndex);

                PlanPercent1.Content = Convert.ToInt32(PlanSum.Content) / Max2 * 100;

                RealSum.Content = Convert.ToInt32(RealLabel1.SelectedIndex)
                               + Convert.ToInt32(RealLabel2.SelectedIndex)
                               + Convert.ToInt32(RealLabel3.SelectedIndex)
                               + Convert.ToInt32(RealLabel4.SelectedIndex)
                               + Convert.ToInt32(RealLabel5.SelectedIndex)
                               + Convert.ToInt32(RealLabel6.SelectedIndex)
                               + Convert.ToInt32(RealLabel7.SelectedIndex)
                               + Convert.ToInt32(RealLabel8.SelectedIndex)
                               + Convert.ToInt32(RealLabel9.SelectedIndex)
                               + Convert.ToInt32(RealLabel10.SelectedIndex)
                               + Convert.ToInt32(RealLabel11.SelectedIndex)
                               + Convert.ToInt32(RealLabel12.SelectedIndex)
                               + Convert.ToInt32(RealLabel13.SelectedIndex)
                               + Convert.ToInt32(RealLabel14.SelectedIndex);

                RealPercent1.Content = Convert.ToInt32(RealSum.Content) / Max2 * 100;

                AllRiskPercent.Content = (Convert.ToInt32(TechSum.Content) + Convert.ToInt32(CostSum.Content)
                                       + Convert.ToInt32(PlanSum.Content) + Convert.ToInt32(RealSum.Content)) / Max2 * 100;
            }
        }
    }
}
