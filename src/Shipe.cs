using Shipe.Boxes;
using Shipe.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Shipe
{
    /// <summary>
    /// Main class used to manage boxes
    /// </summary>
    public static class Shipe
    {
        #region Members

        private static string mRootPath;
        private static bool mInitialized;
        private static IDictionary<string, IBox> mOpenBoxes;

        #endregion

        #region Methods

        /// <summary>
        /// Initializes <see cref="Shipe"/> in a folder
        /// </summary>
        /// <param name="rootPath">The folder where Shipe will be initialized.</param>
        public static void Init(string rootPath)
        {
            if (mInitialized) throw new ShipeAlreadyInitializedException();
            if (string.IsNullOrWhiteSpace(rootPath)) throw new ArgumentNullException(nameof(rootPath));
            if (File.Exists(rootPath)) throw new Exception("Root path must not be a file.");

            Directory.CreateDirectory(rootPath);
            mRootPath = rootPath;
            mOpenBoxes = new Dictionary<string, IBox>();

            mInitialized = true;
        }

        /// <summary>
        /// Opens a new box and loads all its content into memory.
        /// If the box is already opened, an instance of it is returned.
        /// </summary>
        /// <param name="boxName">The name of the box to create.</param>
        public static Box<object> OpenBox(string boxName)
        {
            if (string.IsNullOrWhiteSpace(boxName)) throw new ArgumentNullException(nameof(boxName));

            // If the box is already opened, return its instace
            if (mOpenBoxes.ContainsKey(boxName))
                return (Box<object>)mOpenBoxes[boxName];
        }

        #endregion
    }
}