using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

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
            var tmp = new PlotModel { Title = "Simple example", Subtitle = "using OxyPlot" };

            // Add the series to the plot model
            tmp.Series.Add(Model.ModelPlotData()[0]);
            tmp.Series.Add(Model.ModelPlotData()[1]);

            // Axes are created automatically if they are not defined
            // Set the Model property, the INotifyPropertyChanged event will make the WPF Plot control update its content
            this.OxyPlotModel = tmp;
        }

        #endregion
    }
}
