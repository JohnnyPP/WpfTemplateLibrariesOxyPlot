using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        #endregion

        #region Properties

        public WpfModel.Model Model { get; set; }
        public Helper.ActionCommand ButtonClick { get; set; }

        #endregion

        #region Methods

        private void ButtonClickCommand()
        {
            Model.IncrementTextBox();
        }

        #endregion
    }
}
