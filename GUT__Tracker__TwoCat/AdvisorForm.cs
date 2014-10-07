//  AdvisorForm.cs
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
/// Advisor form.
/// </summary>
namespace GUT__Tracker__TwoCat
{
    // Directives
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Advisor form class.
    /// </summary>
    public class AdvisorForm : Form
    {
        /// <summary>
        /// The advisor data grid view.
        /// </summary>
        private DataGridView advisorDataGridView;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUT__Tracker__TwoCat.AdvisorForm"/> class.
        /// </summary>
        public AdvisorForm()
        {
            // Set advisor data grid view.
            this.advisorDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.advisorDataGridView).BeginInit();
            this.SuspendLayout();

            // advisorDataGridView
            this.advisorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorDataGridView.Dock = DockStyle.Fill;
            this.advisorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.advisorDataGridView.Name = "advisorDataGridView";
            this.advisorDataGridView.ReadOnly = true;
            this.advisorDataGridView.RowHeadersVisible = false;
            this.advisorDataGridView.RowHeadersWidth = 30;
            this.advisorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.advisorDataGridView.Size = new System.Drawing.Size(284, 262);
            this.advisorDataGridView.TabIndex = 2;
            /*//            this.advisorDataGridView.CellClick += new DataGridViewCellEventHandler(this.advisorDataGridView_CellClick);
//            this.advisorDataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.advisorDataGridView_CellDoubleClick);
//            this.advisorDataGridView.CellMouseDown += new DataGridViewCellMouseEventHandler(this.advisorDataGridView_CellMouseDown);
//            this.advisorDataGridView.CellMouseLeave += new DataGridViewCellEventHandler(this.advisorDataGridView_CellMouseLeave);
//            this.advisorDataGridView.CellMouseUp += new DataGridViewCellMouseEventHandler(this.advisorDataGridView_CellMouseUp);
//            this.advisorDataGridView.SelectionChanged += new System.EventHandler(this.advisorDataGridView_SelectionChanged);*/

            // AdvisorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.advisorDataGridView);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvisorForm";
            this.Text = "GUT Tracker TwoCat - Advisor";
            ((System.ComponentModel.ISupportInitialize)this.advisorDataGridView).EndInit();
            this.ResumeLayout(false);

            // Alternating background
            this.advisorDataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.advisorDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Prevent automatic generation of columns
            this.advisorDataGridView.AutoGenerateColumns = false;

            // Prevent resize
            this.advisorDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.advisorDataGridView.AllowUserToResizeRows = false;

            // Add Crossing column
            DataGridViewTextBoxColumn crossingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            crossingDataGridViewTextBoxColumn.DataPropertyName = "Crossing";
            crossingDataGridViewTextBoxColumn.HeaderText = "Crossing";
            crossingDataGridViewTextBoxColumn.Width = 55;
            crossingDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /* crossingDataGridViewTextBoxColumn.DefaultCellStyle.Font = new Font(crossingDataGridViewTextBoxColumn.DefaultCellStyle.Font, crossingDataGridViewTextBoxColumn.DefaultCellStyle.Font.Style ^ FontStyle.Italic); */
            this.advisorDataGridView.Columns.Add(crossingDataGridViewTextBoxColumn);

            // Add numbers column
            DataGridViewTextBoxColumn numbersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numbersDataGridViewTextBoxColumn.DataPropertyName = "Numbers";
            numbersDataGridViewTextBoxColumn.HeaderText = "Numbers";
            numbersDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /* numbersDataGridViewTextBoxColumn.DefaultCellStyle.Font = new Font(numbersDataGridViewTextBoxColumn.DefaultCellStyle.Font, numbersDataGridViewTextBoxColumn.DefaultCellStyle.Font.Style ^ FontStyle.Italic); */
            numbersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.advisorDataGridView.Columns.Add(numbersDataGridViewTextBoxColumn);

            // Clear first selection
            if (this.advisorDataGridView.Rows.Count > 1 && this.advisorDataGridView.Rows[0].Selected)
            {
                this.advisorDataGridView.Rows[0].Selected = false;
            }
        }

        /// <summary>
        /// Sets the advisor data source.
        /// </summary>
        /// <param name="advisor">Advisor reference.</param>
        public void SetAdvisorDataSource(ref BindingList<AdvisorRow> advisor)
        {
            // Assign data source
            this.advisorDataGridView.DataSource = advisor;
        }
    }
}