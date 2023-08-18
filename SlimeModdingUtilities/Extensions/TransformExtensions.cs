using UnityEngine;

namespace SMU.Extensions
{
    /// <summary>
    /// Extension class for Transforms
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Recursively search through a Transform's children to find one with a given name
        /// </summary>
        /// <param name="transform">The root Transform to begin searching.</param>
        /// <param name="transformName">The name of the Transform to search for.</param>
        /// <returns>The found Transform, or null if no Transform with the given name was found.</returns>
        public static Transform FindRecursive(this Transform transform, string transformName)
        {
            if (transform.name == transformName)
                return transform;

            for (var i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i).FindRecursive(transformName);

                if (child != null)
                    return child;
            }

            return null;
        }
    }
}
