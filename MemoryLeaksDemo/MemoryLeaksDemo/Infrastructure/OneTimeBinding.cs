using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace MemoryLeaksDemo.Infrastructure
{
    /// <summary>
    /// <see cref="Binding"/> с проставленными по умолчанию режимом OneTime.
    /// </summary>
    [MarkupExtensionReturnType(typeof(object))]
    public class OneTimeBinding : BindingDecoratorBase
    {
        /// <summary>
        /// Создание экземпляра класса-декоратора.
        /// </summary>
        public OneTimeBinding()
        {
            Mode = BindingMode.OneTime;
        }

        /// <summary>
        /// Создание экземпляра <see cref="Binding"/>.
        /// </summary>
        /// <param name="path">The path to the binding source property.</param>
        public OneTimeBinding(PropertyPath path) : this()
        {
            Path = path;
        }
    }
}