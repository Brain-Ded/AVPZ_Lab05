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

            //Stage2
            TechValue1.Content = TechLabel1.SelectedIndex;
            TechValue2.Content = TechLabel2.SelectedIndex;
            TechValue3.Content = TechLabel3.SelectedIndex;
            TechValue4.Content = TechLabel4.SelectedIndex;
            TechValue5.Content = TechLabel5.SelectedIndex;
            TechValue6.Content = TechLabel6.SelectedIndex;
            TechValue7.Content = TechLabel7.SelectedIndex;
            TechValue8.Content = TechLabel8.SelectedIndex;
            TechValue9.Content = TechLabel9.SelectedIndex;
            TechValue10.Content = TechLabel10.SelectedIndex;
            TechValue11.Content = TechLabel11.SelectedIndex;

            R0C3Label.Content = rand.NextDouble();
            R0C4Label.Content = rand.NextDouble();
            R0C5Label.Content = rand.NextDouble();
            R0C6Label.Content = rand.NextDouble();
            R0C7Label.Content = rand.NextDouble();
            R0C8Label.Content = rand.NextDouble();
            R0C9Label.Content = rand.NextDouble();
            R0C10Label.Content = rand.NextDouble();
            R0C11Label.Content = rand.NextDouble();
            R0C12Label.Content = rand.NextDouble();

            R1C3Label.Content = rand.NextDouble();
            R1C4Label.Content = rand.NextDouble();
            R1C5Label.Content = rand.NextDouble();
            R1C6Label.Content = rand.NextDouble();
            R1C7Label.Content = rand.NextDouble();
            R1C8Label.Content = rand.NextDouble();
            R1C9Label.Content = rand.NextDouble();
            R1C10Label.Content = rand.NextDouble();
            R1C11Label.Content = rand.NextDouble();
            R1C12Label.Content = rand.NextDouble();

            R2C3Label.Content = rand.NextDouble();
            R2C4Label.Content = rand.NextDouble();
            R2C5Label.Content = rand.NextDouble();
            R2C6Label.Content = rand.NextDouble();
            R2C7Label.Content = rand.NextDouble();
            R2C8Label.Content = rand.NextDouble();
            R2C9Label.Content = rand.NextDouble();
            R2C10Label.Content = rand.NextDouble();
            R2C11Label.Content = rand.NextDouble();
            R2C12Label.Content = rand.NextDouble();

            R3C3Label.Content = rand.NextDouble();
            R3C4Label.Content = rand.NextDouble();
            R3C5Label.Content = rand.NextDouble();
            R3C6Label.Content = rand.NextDouble();
            R3C7Label.Content = rand.NextDouble();
            R3C8Label.Content = rand.NextDouble();
            R3C9Label.Content = rand.NextDouble();
            R3C10Label.Content = rand.NextDouble();
            R3C11Label.Content = rand.NextDouble();
            R3C12Label.Content = rand.NextDouble();

            R4C3Label.Content = rand.NextDouble();
            R4C4Label.Content = rand.NextDouble();
            R4C5Label.Content = rand.NextDouble();
            R4C6Label.Content = rand.NextDouble();
            R4C7Label.Content = rand.NextDouble();
            R4C8Label.Content = rand.NextDouble();
            R4C9Label.Content = rand.NextDouble();
            R4C10Label.Content = rand.NextDouble();
            R4C11Label.Content = rand.NextDouble();
            R4C12Label.Content = rand.NextDouble();

            R5C3Label.Content = rand.NextDouble();
            R5C4Label.Content = rand.NextDouble();
            R5C5Label.Content = rand.NextDouble();
            R5C6Label.Content = rand.NextDouble();
            R5C7Label.Content = rand.NextDouble();
            R5C8Label.Content = rand.NextDouble();
            R5C9Label.Content = rand.NextDouble();
            R5C10Label.Content = rand.NextDouble();
            R5C11Label.Content = rand.NextDouble();
            R5C12Label.Content = rand.NextDouble();

            R6C3Label.Content = rand.NextDouble();
            R6C4Label.Content = rand.NextDouble();
            R6C5Label.Content = rand.NextDouble();
            R6C6Label.Content = rand.NextDouble();
            R6C7Label.Content = rand.NextDouble();
            R6C8Label.Content = rand.NextDouble();
            R6C9Label.Content = rand.NextDouble();
            R6C10Label.Content = rand.NextDouble();
            R6C11Label.Content = rand.NextDouble();
            R6C12Label.Content = rand.NextDouble();

            R7C3Label.Content = rand.NextDouble();
            R7C4Label.Content = rand.NextDouble();
            R7C5Label.Content = rand.NextDouble();
            R7C6Label.Content = rand.NextDouble();
            R7C7Label.Content = rand.NextDouble();
            R7C8Label.Content = rand.NextDouble();
            R7C9Label.Content = rand.NextDouble();
            R7C10Label.Content = rand.NextDouble();
            R7C11Label.Content = rand.NextDouble();
            R7C12Label.Content = rand.NextDouble();

            R8C3Label.Content = rand.NextDouble();
            R8C4Label.Content = rand.NextDouble();
            R8C5Label.Content = rand.NextDouble();
            R8C6Label.Content = rand.NextDouble();
            R8C7Label.Content = rand.NextDouble();
            R8C8Label.Content = rand.NextDouble();
            R8C9Label.Content = rand.NextDouble();
            R8C10Label.Content = rand.NextDouble();
            R8C11Label.Content = rand.NextDouble();
            R8C12Label.Content = rand.NextDouble();

            R9C3Label.Content = rand.NextDouble();
            R9C4Label.Content = rand.NextDouble();
            R9C5Label.Content = rand.NextDouble();
            R9C6Label.Content = rand.NextDouble();
            R9C7Label.Content = rand.NextDouble();
            R9C8Label.Content = rand.NextDouble();
            R9C9Label.Content = rand.NextDouble();
            R9C10Label.Content = rand.NextDouble();
            R9C11Label.Content = rand.NextDouble();
            R9C12Label.Content = rand.NextDouble();

            R10C3Label.Content = rand.NextDouble();
            R10C4Label.Content = rand.NextDouble();
            R10C5Label.Content = rand.NextDouble();
            R10C6Label.Content = rand.NextDouble();
            R10C7Label.Content = rand.NextDouble();
            R10C8Label.Content = rand.NextDouble();
            R10C9Label.Content = rand.NextDouble();
            R10C10Label.Content = rand.NextDouble();
            R10C11Label.Content = rand.NextDouble();
            R10C12Label.Content = rand.NextDouble();

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

                //Stage2
                TechValue1.Content = TechLabel1.SelectedIndex;
                TechValue2.Content = TechLabel2.SelectedIndex;
                TechValue3.Content = TechLabel3.SelectedIndex;
                TechValue4.Content = TechLabel4.SelectedIndex;
                TechValue5.Content = TechLabel5.SelectedIndex;
                TechValue6.Content = TechLabel6.SelectedIndex;
                TechValue7.Content = TechLabel7.SelectedIndex;
                TechValue8.Content = TechLabel8.SelectedIndex;
                TechValue9.Content = TechLabel9.SelectedIndex;
                TechValue10.Content = TechLabel10.SelectedIndex;
                TechValue11.Content = TechLabel11.SelectedIndex;
            }
        }
    }
}
