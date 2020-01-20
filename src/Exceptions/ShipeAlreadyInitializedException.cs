using System;

namespace Shipe.Exceptions
{
    /// <summary>
    /// Exception thrown when is tried to initialize <see cref="Shipe"/>
    /// when its ready to use.
    /// </summary>
    public class ShipeAlreadyInitializedException : Exception
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShipeAlreadyInitializedException"/>
        /// </summary>
        public ShipeAlreadyInitializedException() : base("Shipe already initialized.") {}
    }
}