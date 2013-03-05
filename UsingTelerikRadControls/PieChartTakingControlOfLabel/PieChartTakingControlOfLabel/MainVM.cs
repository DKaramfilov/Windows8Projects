using System;
using System.Collections.ObjectModel;
using System.Linq;

using Telerik.UI.Xaml.Controls.Chart;

namespace PieChartTakingControlOfLabel
{
    class MainVM
    {
        public ObservableCollection<BudgetData> Data { get; private set; }

        public ChartPalette DefaultLightPalette
        {
            get { return ChartPalettes.DefaultLight; }
        }

        public MainVM()
        {
            PopulateData();
        }

        private void PopulateData()
        {
            Data = new ObservableCollection<BudgetData>();
            Data.Add(new BudgetData() { Millions = 43, Department = "Education" });
            Data.Add(new BudgetData() { Millions = 27, Department = "Roads" });
            Data.Add(new BudgetData() { Millions = 16, Department = "Social Programs" });
            Data.Add(new BudgetData() { Millions = 13, Department = "Biz Incent" });
            Data.Add(new BudgetData() { Millions = 12, Department = "Town Personnel" });
            Data.Add(new BudgetData() { Millions = 5, Department = "Planning" });

        }
    }
}
