//  SetNumericValueForm.cs
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
/// Max count form.
/// </summary>
namespace GUT__Tracker__TwoCat
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Max count form class.
    /// </summary>
    public class SetNumericValueForm : Form
    {
        /// <summary>
        /// The numeric value numeric up down.
        /// </summary>
        private NumericUpDown numericValueNumericUpDown;

        /// <summary>
        /// The set button.
        /// </summary>
        private Button setButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUT__Tracker__TwoCat.SetNumericValueForm"/> class.
        /// </summary>
        /// <param name="titleText">Title text.</param>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="numericValueMaximum">Numeric value maximum.</param>
        public SetNumericValueForm(string titleText, int numericValue, int numericValueMaximum)
        {
            this.setButton = new Button();
            this.numericValueNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)this.numericValueNumericUpDown).BeginInit();
            this.SuspendLayout();

            // setButton
            this.setButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.setButton.Location = new Point(27, 50);
            this.setButton.Name = "setButton";
            this.setButton.Size = new Size(120, 34);
            this.setButton.TabIndex = 0;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.DialogResult = DialogResult.OK;

            // numericValueNumericUpDown
            this.numericValueNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.numericValueNumericUpDown.Location = new Point(27, 12);
            this.numericValueNumericUpDown.Maximum = new decimal(new int[]
                {
                    numericValueMaximum,
                    0,
                    0,
                    0
                });
            this.numericValueNumericUpDown.Minimum = new decimal(new int[]
                {
                    1,
                    0,
                    0,
                    0
                });
            this.numericValueNumericUpDown.Name = "numericValueNumericUpDown";
            this.numericValueNumericUpDown.Size = new Size(120, 26);
            this.numericValueNumericUpDown.TabIndex = 1;
            this.numericValueNumericUpDown.Value = new decimal(new int[]
                {
                    numericValue,
                    0,
                    0,
                    0
                });

            // MainForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.TopMost = true;
            this.ClientSize = new Size(174, 95);
            this.ControlBox = true;
            this.Controls.Add(this.numericValueNumericUpDown);
            this.Controls.Add(this.setButton);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = titleText;
            ((System.ComponentModel.ISupportInitialize)this.numericValueNumericUpDown).EndInit();
            this.ResumeLayout(false);
        }

        /// <summary>
        /// Gets the get numeric value field.
        /// </summary>
        /// <value>The get numeric value field.</value>
        public int GetNumericValueField
        {
            get
            {
                return Convert.ToInt32(this.numericValueNumericUpDown.Value);
            }
        }

        /// <summary>
        /// Overrides ProcessCmdKey to enable closing dialog by escape key 
        /// </summary>
        /// <returns><c>true</c>, if cmd key was processed, <c>false</c> otherwise.</returns>
        /// <param name="message">Message parameter.</param>
        /// <param name="keys">Keys parameter.</param>
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            // Check for escape key
            if (keys == Keys.Escape)
            {
                // Assign cancel
                this.DialogResult = DialogResult.Cancel;

                // Close dialog
                this.Close();

                // Return true
                return true;
            }
            else if (keys == Keys.Enter)
            {
                // Assign OK
                this.DialogResult = DialogResult.OK;

                // Close dialog
                this.Close();

                // Return true
                return true;
            }

            // Not escape
            return base.ProcessCmdKey(ref message, keys);
        }
    }
}