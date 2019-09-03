/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/statica
 *
 */

using System.Threading.Tasks;
using Statica.Models;

namespace Statica.Services
{
    public interface IPageService
    {
        /// <summary>
        /// Gets the current page structure.
        /// </summary>
        PageStructure PageStructure { get; }

        /// <summary>
        /// Gets the content for the page with the given slug.
        /// </summary>
        /// <param name="slug">The slug</param>
        /// <returns>The content</returns>
        Task<string> GetPageContentAsync(string slug);
    }
}