using System;
using System.Collections.Generic;
using System.Text;

namespace Shipe.Boxes
{
    /// <summary>
    /// Base implementation of <see cref="BoxBase{T}"/>
    /// </summary>
    /// <typeparam name="T">The type of items the box will store.</typeparam>
    public class Box<T> : BoxBase<T>
    {
        /// <summary>
        /// Creates a new box
        /// </summary>
        /// <param name="boxName"></param>
        internal Box(string boxName) : base(boxName)
        {

        }
    }
}