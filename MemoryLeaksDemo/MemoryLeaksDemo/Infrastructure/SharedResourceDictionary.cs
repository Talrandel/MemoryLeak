using System;
using System.Collections.Generic;
using System.Windows;

namespace MemoryLeaksDemo.Infrastructure
{
    public class SharedResourceDictionary : ResourceDictionary
    {
        /// <summary>
        /// Внутренний кэш загруженных словарей.
        /// </summary>
        private static readonly Dictionary<Uri, ResourceDictionary> SHARED_DICTIONARIES = new Dictionary<Uri, ResourceDictionary>();
        
        private Uri _sourceUri;

        /// <summary>
        /// Исходный URI для загрузки ресурса.
        /// </summary>
        public new Uri Source
        {
            get { return _sourceUri; }
            set
            {
                _sourceUri = value;

                if (!SHARED_DICTIONARIES.ContainsKey(value))
                {
                    // Если словарь еще не загружен, то загрузить его, используя текущий URI и свойство Source базового класса
                    base.Source = value;
                    // Добавить словарь в кэш
                    SHARED_DICTIONARIES.Add(value, this);
                }
                else
                {
                    // Если словарь уже есть в кэше - загрузить из кэша
                    MergedDictionaries.Add(SHARED_DICTIONARIES[value]);
                }
            }
        }
    }
}