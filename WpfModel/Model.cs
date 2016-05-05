using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace WpfModel
{
    public class Model : INotifyPropertyChanged
    {
        #region Properties

        private int _click;

        public int Click
        {
            get { return _click; }
            set
            {
                _click = value;
                OnPropertyChanged("Click");
            }
        }

        #endregion

        #region Constructors

        public Model()
        {
            _click = 0;
        }

        #endregion

        #region Methods

        public void IncrementTextBox()
        {
            Click++;
        }

        public List<LineSeries> ModelPlotData()
        {
            var lineSeriesList = new List<LineSeries>();

            // Create two line series (markers are hidden by default)
            var series1 = new LineSeries { Title = "Series 1", MarkerType = MarkerType.Circle };
            var time0 = new DateTime(2013, 5, 6, 3, 24, 0);
            var time1 = new DateTime(2013, 5, 6, 3, 28, 0);
            var time2 = new DateTime(2015, 05, 23);

            series1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 01, 23)), 0));
            series1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 03, 23)), 18));
            series1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 07, 23)), 12));
            series1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 09, 23)), 8));
            series1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 12, 23)), 15));

            var series2 = new LineSeries { Title = "Series 2", MarkerType = MarkerType.Square };
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 01, 23)), 4));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 03, 23)), 12));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 07, 23)), 16));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 09, 23)), 25));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2015, 12, 23)), 5));

            lineSeriesList.Add(series1);
            lineSeriesList.Add(series2);

            return lineSeriesList; 
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
