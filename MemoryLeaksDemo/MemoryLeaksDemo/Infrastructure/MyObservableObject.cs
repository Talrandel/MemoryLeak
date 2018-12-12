using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MemoryLeaksDemo.Infrastructure
{
    /// <summary>
    /// Базовый класс сущности, реализующей интерфейс <see cref="INotifyPropertyChanged" /> (для поддержки взаимодействия с представлением).
    /// </summary>
    [Serializable]
    public class MyObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// This must agree with Binding.IndexerName.  It is declared separately
        /// here so as to avoid a dependency on PresentationFramework.dll.
        /// </summary>
        protected const string INDEXER_NAME = "Item[]";

        internal const string SET_METHOD_NAME = nameof(Set);
        
        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged" />
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event if needed.
        /// </summary>
        /// <remarks>If the propertyName parameter
        /// does not correspond to an existing property on the current class, an
        /// exception is thrown in DEBUG configuration only.</remarks>
        /// <param name="propertyName">(optional) The name of the property that
        /// changed.</param>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Assigns a new value to the property. Then, raises the
        /// PropertyChanged event if needed. 
        /// </summary>
        /// <typeparam name="T">The type of the property that
        /// changed.</typeparam>
        /// <param name="field">The field storing the property's value.</param>
        /// <param name="newValue">The property's value after the change
        /// occurred.</param>
        /// <param name="propertyName">(optional) The name of the property that
        /// changed.</param>
        /// <returns>True if the PropertyChanged event has been raised,
        /// false otherwise. The event is not raised if the old
        /// value is equal to the new value.</returns>
        protected virtual bool Set<T>(
            ref T field, T newValue,
            [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
                return false;

            field = newValue;            
            RaisePropertyChanged(propertyName);

            return true;
        }


        /// <summary>
        /// Assigns a new value to the property. Then, raises the
        /// PropertyChanged event if needed, and than do Action
        /// </summary>
        /// <typeparam name="T">The type of the property that
        /// changed.</typeparam>
        /// <param name="field">The field storing the property's value.</param>
        /// <param name="newValue">The property's value after the change
        /// occurred.</param>
        /// <param name="action"></param>
        /// <param name="propertyName">(optional) The name of the property that
        /// changed.</param>
        /// <returns>True if the PropertyChanged event has been raised,
        /// false otherwise. The event is not raised if the old
        /// value is equal to the new value.</returns>
        protected void Set<T>(
            ref T field, T newValue,
            Action<T> action,
            [CallerMemberName] string propertyName = null)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            if (Set(ref field, newValue, propertyName))
                action(newValue);
        }
    }
}