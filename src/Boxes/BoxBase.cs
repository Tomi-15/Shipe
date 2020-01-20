using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Shipe.Boxes
{
    /// <summary>
    /// The base implementation of the <see cref="IBox"/>
    /// </summary>
    public abstract class BoxBase<T> : IBox
    {
        #region Members

        private string mName; // The name of the box
        private bool mIsOpen; // Indicates if the box is opened

        #endregion

        #region Constructors

        internal BoxBase(string boxName)
        {
            mName = boxName;
            mIsOpen = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The name of the box
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// An enumerable of items in the box
        /// </summary>
        public IEnumerable<T> Items { get; }

        /// <summary>
        /// Indicates if the box is empty or not.
        /// </summary>
        public bool IsEmpty { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Puts an item with a specific key
        /// </summary>
        /// <param name="key">The key of the item.</param>
        /// <param name="item">The item to put.</param>
        public async Task Put(string key, T item)
        {

        }

        /// <summary>
        /// Adds an item with an autoincrement key
        /// </summary>
        /// <param name="item">The item to add.</param>
        public async Task Add(T item)
        {

        }

        /// <summary>
        /// Adds a list of items to the box.
        /// </summary>
        /// <param name="items">The list of items.</param>
        public async Task AddAll(IEnumerable<T> items)
        {

        }

        /// <summary>
        /// Saves an edited item to the box.
        /// </summary>
        /// <param name="item">The item to save.</param>
        /// <exception cref="InvalidOperationException">Is thrown if the item is not in the box.</exception>
        public async Task Save(T item)
        {

        }

        /// <summary>
        /// Saves all pending operations and closes the box.
        /// This is useful when the box is no more needed.
        /// </summary>
        public async Task Close()
        {

        }

        /// <summary>
        /// Deletes an item from the box.
        /// </summary>
        /// <param name="key">The key of the item.</param>
        public async Task Delete(string key)
        {
        }

        #endregion
    }
}