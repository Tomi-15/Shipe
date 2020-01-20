using System.Threading.Tasks;

namespace Shipe.Boxes
{
    /// <summary>
    /// Represents the very base box type
    /// </summary>
    public interface IBox
    {
        /// <summary>
        /// The name of the box
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Saves all the pending operations and closes the box
        /// </summary>
        Task Close();

        /// <summary>
        /// Deletes an item from the box
        /// </summary>
        /// <param name="key">The key of the item to delete.</param>
        Task Delete(string key);
    }
}