//  NumberCount.cs
//
//  Author:
//       Victor L. Senior (VLS) <betselection(&)gmail.com>
//
//  Web: 
//       http://betselection.cc/betsoftware/
//
//  Sources:
//       http://github.com/betselection/
//
//  Copyright (c) 2014 Victor L. Senior
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

/// <summary>
/// Number count.
/// </summary>
namespace GUT__Tracker__TwoCat
{
    // Directives
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Number count class.
    /// </summary>
    public class NumberCount
    {
        /// <summary>
        /// The shows field.
        /// </summary>
        private string showsField;

        /// <summary>
        /// The count field.
        /// </summary>
        private int countField;

        /// <summary>
        /// The numbers field.
        /// </summary>
        private string numbersField;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUT__Tracker__TwoCat.NumberCount"/> class.
        /// </summary>
        /// <param name="shows">Shows parameter.</param>
        /// <param name="count">Count parameter.</param>
        /// <param name="numbers">Numbers parameter.</param>
        public NumberCount(string shows, int count, List<int> numbers)
        {
            // Set shows
            this.showsField = shows;

            // Set count
            this.countField = count;

            // Intermediate list
            List<string> numList = new List<string>();

            // Populate list
            foreach (int n in numbers)
            {
                // Add current one (37 => 00)
                numList.Add(n == 37 ? "00" : n.ToString());
            }

            // Set numbers field
            this.numbersField = string.Join(",", numList.ToArray());
        }

        /// <summary>
        /// Gets or sets the shows.
        /// </summary>
        /// <value>The shows.</value>
        public string Shows
        {
            get { return this.showsField; }
            set { this.showsField = value; }
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get { return this.countField; }
            set { this.countField = value; }
        }

        /// <summary>
        /// Gets the numbers.
        /// </summary>
        /// <value>The numbers.</value>
        public string Numbers
        {
            get
            {
                return this.numbersField;
            }
        }
    }
}