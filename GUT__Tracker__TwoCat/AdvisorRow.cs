//  AdvisorRow.cs
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
/// Advisor row.
/// </summary>
namespace GUT__Tracker__TwoCat
{
    // Directives
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Advisor row class.
    /// </summary>
    public class AdvisorRow
    {
        /// <summary>
        /// The crossing field.
        /// </summary>
        private string crossingField;

        /// <summary>
        /// The numbers field.
        /// </summary>
        private string numbersField;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUT__Tracker__TwoCat.AdvisorRow"/> class.
        /// </summary>
        /// <param name="crossing">Crossing parameter.</param>
        /// <param name="numbers">Numbers parameter.</param>
        public AdvisorRow(string crossing, List<string> numbers)
        {
            // Set crossing
            this.crossingField = crossing;

            // Set numbers
            this.numbersField = string.Join(",", numbers.ToArray());
        }

        /// <summary>
        /// Gets or sets the crossing.
        /// </summary>
        /// <value>The crossing.</value>
        public string Crossing
        {
            get { return this.crossingField; }
            set { this.crossingField = value; }
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