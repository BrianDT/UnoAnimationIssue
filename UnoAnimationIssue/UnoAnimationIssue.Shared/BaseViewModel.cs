// <copyright file="BaseViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2019-2020 All rights reserved</copyright>

namespace Vssl.Samples.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// A base class for all view models
    /// Cut down version with no dispatcher
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel" /> class.
        /// </summary>
        public BaseViewModel()
        {
        }

        #region [ INotifyPropertyChanged Events ]

        /// <summary>
        ///  Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        /// <summary>
        /// Called when a property value has changed
        /// </summary>
        /// <param name="propertyName">The name of the property that changed</param>
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
