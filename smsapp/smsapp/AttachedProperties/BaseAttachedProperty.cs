using System;
using System.Windows;

namespace smsapp
{
    /// <summary>
    /// Base attached property to replace the vanilla WPF attached property                        
    /// </summary>
    /// <typeparam name="Parent">Parent class to attached property</typeparam>
    /// <typeparam name="Property">Type of attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : new()
    {

        #region Private members

        private static Parent mInstance;

        private static bool IsFirst = true;

        #endregion 

        #region Parent
        /// <summary>
        /// Singleton instance of parent class
        /// </summary>
        public static Parent Instance { get { return IsFirst ? new Parent() : mInstance; } private set { mInstance = value; IsFirst = !IsFirst; } }
        #endregion

        #region Public Events

        /// <summary>
        /// Fired when value changed
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        /// <summary>
        /// Fired when value changed
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = (sender, e) => { };

        #endregion

        #region Default constructor

        #endregion

        #region Attached Property Definitions

        /// <summary>
        /// Attached property for this class
        /// </summary>
        protected static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachedProperty<Parent, Property>),
            new UIPropertyMetadata(
                default(Property),
                new PropertyChangedCallback(OnValuePropertyChanged),
                new CoerceValueCallback(OnValuePropertyUpdated)));

        /// <summary>
        /// The callback event when <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had its property changed</param>
        /// <param name="e">The argument for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent event
            (Instance as BaseAttachedProperty<Parent, Property>).OnValueChanged(d, e);

            // Call event listeners
            (Instance as BaseAttachedProperty<Parent, Property>).ValueChanged(d, e);
        }

        /// <summary>
        /// The callback event when <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had its property changed</param>
        /// <param name="e">The argument for the event</param>
        private static object OnValuePropertyUpdated(DependencyObject d, object e)
        {
            (Instance as BaseAttachedProperty<Parent, Property>).OnValueUpdated(d, e);
            (Instance as BaseAttachedProperty<Parent, Property>).ValueUpdated(d, e);
            return e;
        }

        /// <summary>
        /// Get the value of attached property
        /// </summary>
        /// <param name="d">Element to get value from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) { return (Property)d.GetValue(ValueProperty); }

        /// <summary>
        /// Set the value of attached property
        /// </summary>
        /// <param name="d">Element to set value to</param>
        /// <param name="value">Value to set</param>
        public static void SetValue(DependencyObject d, Property value) { d.SetValue(ValueProperty, value); }
        #endregion

        #region Event Methods

        /// <summary>
        /// The method is called when any attached propety of this type changed
        /// </summary>
        /// <param name="sender">UI element property changed for</param>
        /// <param name="e">The argument for this event</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        /// <summary>
        /// This method called when any bool attached property changed
        /// </summary>
        /// <param name="sender">UI element property changed for</param>
        /// <param name="e">The argument for this event</param>
        public virtual void OnValueUpdated(DependencyObject sender, object e) { }

        #endregion

    }
}
