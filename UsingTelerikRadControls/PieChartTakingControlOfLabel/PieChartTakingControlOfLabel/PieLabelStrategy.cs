using System;
using System.Linq;
using Telerik.Charting;
using Telerik.UI.Xaml.Controls.Chart;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PieChartTakingControlOfLabel
{
    class PieLabelStrategy : ChartSeriesLabelStrategy
    {
        private string format = "{0}\n{1:P2}";

        public PropertyNameDataPointBinding Binding { get; set; }

        public override LabelStrategyOptions Options
        {
            get { return LabelStrategyOptions.DefaultVisual; }
        }
        public override FrameworkElement CreateDefaultVisual(DataPoint point, int labelIndex)
        {
            ChartSeries series = point.Presenter as ChartSeries;
            StackPanel stackpanel = new StackPanel();
            stackpanel.Children.Add(new TextBlock { FontSize = 16, FontWeight = FontWeights.Bold });
            stackpanel.Children.Add(new TextBlock());
            return stackpanel;
        }

        public override object GetLabelContent(DataPoint point, int labelIndex)
        {
            if (point == null || labelIndex < 0)
            {
                return base.GetLabelContent(point, labelIndex);
            }

            return string.Format(
                this.format,
                Binding.GetValue(point.DataItem), ((PieDataPoint)point).Percent / 100);
        }
        public override void SetLabelContent(DataPoint point, FrameworkElement visual, int labelIndex)
        {
            ((visual as StackPanel).Children[0] as TextBlock).Text = (point.DataItem as BudgetData).Department.ToString();
            ((visual as StackPanel).Children[1] as TextBlock).Text = point.Label.ToString();
        }
    }
}
