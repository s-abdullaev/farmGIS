using System;
using System.Windows.Input;

namespace smsapp
{
    public class RelayParametrisedCommand : ICommand
    {

        #region Private Members

        /// <summary>
        /// Action to run
        /// </summary>
        private Action<object> mAction;

        #endregion

        #region Public Members
        /// <summary>
        /// This event is called when <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        /// <summary>
        /// Relay command executes always so it is always true
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayParametrisedCommand(Action<object> action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods
        /// <summary>
        /// Executes a command Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction(parameter);
        }
        #endregion
    }
}
