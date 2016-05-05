using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace WpfViewModel
{
    public class ViewModel
    {
        #region Fields

        #endregion

        #region Constructors

        public ViewModel()
        {
            Model = new WpfModel.Model();
            ButtonClick = new Helper.ActionCommand(ButtonClickCommand);
            PlotData();
        }

        #endregion

        #region Properties

        public WpfModel.Model Model { get; set; }
        public Helper.ActionCommand ButtonClick { get; set; }
        public PlotModel OxyPlotModel { get; private set; }

        #endregion

        #region Methods

        private void ButtonClickCommand()
        {
            Model.IncrementTextBox();
        }

        private void PlotData()
        {
            // Create the plot model
            var plotModel = new PlotModel { Title = "Simple example", Subtitle = "using OxyPlot" };
            //var dateTimeAxis = new DateTimeAxis();
            //dateTimeAxis.IntervalType = DateTimeIntervalType.Auto;
            var xAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd MM yyyy",
                Title = "Date",
                //IntervalLength = 75,
                MinorIntervalType = DateTimeIntervalType.Days,
                IntervalType = DateTimeIntervalType.Days,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.None,
            };
            plotModel.Axes.Add(xAxis);
            var linearAxis = new LinearAxis();
            plotModel.Axes.Add(linearAxis);

            // Add the series to the plot model
            plotModel.Series.Add(Model.ModelPlotData()[0]);
            plotModel.Series.Add(Model.ModelPlotData()[1]);

            // Axes are created automatically if they are not defined
            // Set the Model property, the INotifyPropertyChanged event will make the WPF Plot control update its content
            this.OxyPlotModel = plotModel;
        }

        #endregion
    }
}
