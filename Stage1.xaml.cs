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
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Stage1_2 stage1_2 = new Stage1_2();
            stage1_2.Show();
        }
    }
}
