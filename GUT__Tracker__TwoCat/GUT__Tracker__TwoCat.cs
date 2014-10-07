//  GUT__Tracker__TwoCat.cs
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
/// GUT Tracker TwoCat.
/// </summary>
namespace GUT__Tracker__TwoCat
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// GUT Tracker TwoCat class.
    /// </summary>
    public class GUT__Tracker__TwoCat : Form
    {
        /// <summary>
        /// The marshal object.
        /// </summary>
        private object marshal = null;

        /// <summary>
        /// The counter binding list.
        /// </summary>
        private BindingList<NumberCount> counterBindingList = new BindingList<NumberCount>();

        /// <summary>
        /// The advisor binding list.
        /// </summary>
        private BindingList<AdvisorRow> advisorBindingList = new BindingList<AdvisorRow>();

        /// <summary>
        /// The max count.
        /// </summary>
        private int maxCount = 10;

        /// <summary>
        /// The max count maximum.
        /// </summary>
        private int maxCountMaximum = 37;

        /// <summary>
        /// The jump back amount.
        /// </summary>
        private int jumpBackValue = 20;

        /// <summary>
        /// The numbers list.
        /// </summary>
        private List<int> numbersList = new List<int>();

        /// <summary>
        /// The type of the wheel. 0 = No zero, 1 = European, 2 = American.
        /// </summary>
        private int wheelType = 1;

        /// <summary>
        /// The bet mode. 0 = One click. 1 = Double-click. 2 = Every crossing.
        /// </summary>
        private int betMode = 2;

        /// <summary>
        /// All crosings tool strip menu item.
        /// </summary>
        private ToolStripMenuItem allCrosingsToolStripMenuItem;

        /// <summary>
        /// The double click tool strip menu item.
        /// </summary>
        private ToolStripMenuItem doubleClickToolStripMenuItem;

        /// <summary>
        /// The single click tool strip menu item.
        /// </summary>
        private ToolStripMenuItem singleClickToolStripMenuItem;

        /// <summary>
        /// The advisor betting tool strip menu item.
        /// </summary>
        private ToolStripMenuItem advisorBettingToolStripMenuItem;

        /// <summary>
        /// The no zero tool strip menu item.
        /// </summary>
        private ToolStripMenuItem noZeroToolStripMenuItem;

        /// <summary>
        /// The american tool strip menu item.
        /// </summary>
        private ToolStripMenuItem americanToolStripMenuItem;

        /// <summary>
        /// The european tool strip menu item.
        /// </summary>
        private ToolStripMenuItem europeanToolStripMenuItem;

        /// <summary>
        /// The layout type tool strip menu item.
        /// </summary>
        private ToolStripMenuItem layoutTypeToolStripMenuItem;

        /// <summary>
        /// The setmax shows tool strip menu item.
        /// </summary>
        private ToolStripMenuItem setmaxShowsToolStripMenuItem;

        /// <summary>
        /// The set jump back spins tool strip menu item.
        /// </summary>
        private ToolStripMenuItem setJumpBackSpinsToolStripMenuItem;

        /// <summary>
        /// The count data grid view.
        /// </summary>
        private DataGridView countDataGridView;

        /// <summary>
        /// The options tool strip menu item.
        /// </summary>
        private ToolStripMenuItem optionsToolStripMenuItem;

        /// <summary>
        /// The jump back tool strip menu item.
        /// </summary>
        private ToolStripMenuItem jumpBackToolStripMenuItem;

        /// <summary>
        /// The history stack.
        /// </summary>
        private Stack<int> historyStack = new Stack<int>();

        /// <summary>
        /// The cycle list.
        /// </summary>
        private List<int> cycleList = new List<int>();

        /// <summary>
        /// The menu strip.
        /// </summary>
        private MenuStrip menuStrip;

        /// <summary>
        /// The advisor form.
        /// </summary>
        private AdvisorForm advisorForm = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUT__Tracker__TwoCat.GUT__Tracker__TwoCat"/> class.
        /// </summary>
        public GUT__Tracker__TwoCat()
        {
            this.menuStrip = new MenuStrip();
            this.jumpBackToolStripMenuItem = new ToolStripMenuItem();
            this.optionsToolStripMenuItem = new ToolStripMenuItem();
            this.setJumpBackSpinsToolStripMenuItem = new ToolStripMenuItem();
            this.setmaxShowsToolStripMenuItem = new ToolStripMenuItem();
            this.layoutTypeToolStripMenuItem = new ToolStripMenuItem();
            this.europeanToolStripMenuItem = new ToolStripMenuItem();
            this.americanToolStripMenuItem = new ToolStripMenuItem();
            this.noZeroToolStripMenuItem = new ToolStripMenuItem();
            this.advisorBettingToolStripMenuItem = new ToolStripMenuItem();
            this.singleClickToolStripMenuItem = new ToolStripMenuItem();
            this.doubleClickToolStripMenuItem = new ToolStripMenuItem();
            this.allCrosingsToolStripMenuItem = new ToolStripMenuItem();
            this.countDataGridView = new DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.countDataGridView).BeginInit();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new ToolStripItem[]
                {
                    this.jumpBackToolStripMenuItem,
                    this.optionsToolStripMenuItem
                });
            this.menuStrip.Location = new Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new Size(292, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // jumpBackToolStripMenuItem
            this.jumpBackToolStripMenuItem.Name = "jumpBackToolStripMenuItem";
            this.jumpBackToolStripMenuItem.Font = new Font(this.jumpBackToolStripMenuItem.Font, FontStyle.Bold);
            this.jumpBackToolStripMenuItem.Size = new Size(69, 20);
            this.jumpBackToolStripMenuItem.Text = "&Jump back";
            this.jumpBackToolStripMenuItem.Click += new System.EventHandler(this.JumpBackToolStripMenuItemClick);

            // optionsToolStripMenuItem
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
                {
                    this.setJumpBackSpinsToolStripMenuItem,
                    this.setmaxShowsToolStripMenuItem,
                    this.layoutTypeToolStripMenuItem,
                    /*this.advisorBettingToolStripMenuItem*/
                });
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);

            // setJumpBackSpinsToolStripMenuItem
            this.setJumpBackSpinsToolStripMenuItem.Name = "setJumpBackSpinsToolStripMenuItem";
            this.setJumpBackSpinsToolStripMenuItem.Size = new Size(179, 22);
            this.setJumpBackSpinsToolStripMenuItem.Text = "&Set jump back spins";
            this.setJumpBackSpinsToolStripMenuItem.Click += new System.EventHandler(this.SetJumpBackSpinsToolStripMenuItemClick);

            // setmaxShowsToolStripMenuItem
            this.setmaxShowsToolStripMenuItem.Name = "setmaxShowsToolStripMenuItem";
            this.setmaxShowsToolStripMenuItem.Size = new Size(179, 22);
            this.setmaxShowsToolStripMenuItem.Text = "Set &max. shows";
            this.setmaxShowsToolStripMenuItem.Click += new System.EventHandler(this.SetMaxShowsToolStripMenuItemClick);

            // layoutTypeToolStripMenuItem
            this.layoutTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
                {
                    this.europeanToolStripMenuItem,
                    this.americanToolStripMenuItem,
                    this.noZeroToolStripMenuItem
                });
            this.layoutTypeToolStripMenuItem.Name = "layoutTypeToolStripMenuItem";
            this.layoutTypeToolStripMenuItem.Size = new Size(179, 22);
            this.layoutTypeToolStripMenuItem.Text = "&Layout type";

            // europeanToolStripMenuItem
            this.europeanToolStripMenuItem.Checked = true;
            this.europeanToolStripMenuItem.CheckState = CheckState.Checked;
            this.europeanToolStripMenuItem.Name = "europeanToolStripMenuItem";
            this.europeanToolStripMenuItem.Size = new Size(131, 22);
            this.europeanToolStripMenuItem.Text = "&European";
            this.europeanToolStripMenuItem.Click += new System.EventHandler(this.EuropeanToolStripMenuItemClick);

            // americanToolStripMenuItem
            this.americanToolStripMenuItem.Name = "americanToolStripMenuItem";
            this.americanToolStripMenuItem.Size = new Size(131, 22);
            this.americanToolStripMenuItem.Text = "&American";
            this.americanToolStripMenuItem.Click += new System.EventHandler(this.AmericanToolStripMenuItemClick);

            // noZeroToolStripMenuItem
            this.noZeroToolStripMenuItem.Name = "noZeroToolStripMenuItem";
            this.noZeroToolStripMenuItem.Size = new Size(131, 22);
            this.noZeroToolStripMenuItem.Text = "&No zero";
            this.noZeroToolStripMenuItem.Click += new System.EventHandler(this.NoZeroToolStripMenuItemClick);

            // advisorBettingToolStripMenuItem
            this.advisorBettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
                {
                    this.singleClickToolStripMenuItem,
                    this.doubleClickToolStripMenuItem,
                    this.allCrosingsToolStripMenuItem
                });
            this.advisorBettingToolStripMenuItem.Name = "advisorBettingToolStripMenuItem";
            this.advisorBettingToolStripMenuItem.Size = new Size(179, 22);
            this.advisorBettingToolStripMenuItem.Text = "&Advisor betting";

            // singleClickToolStripMenuItem
            this.singleClickToolStripMenuItem.Name = "singleClickToolStripMenuItem";
            this.singleClickToolStripMenuItem.Size = new Size(152, 22);
            this.singleClickToolStripMenuItem.Text = "&Single click";
            this.singleClickToolStripMenuItem.Click += new System.EventHandler(this.SingleClickToolStripMenuItemClick);

            // doubleClickToolStripMenuItem
            this.doubleClickToolStripMenuItem.Checked = true;
            this.doubleClickToolStripMenuItem.CheckState = CheckState.Checked;
            this.doubleClickToolStripMenuItem.Name = "doubleClickToolStripMenuItem";
            this.doubleClickToolStripMenuItem.Size = new Size(152, 22);
            this.doubleClickToolStripMenuItem.Text = "&Double click";
            this.doubleClickToolStripMenuItem.Click += new System.EventHandler(this.DoubleClickToolStripMenuItemClick);

            // allCrosingsToolStripMenuItem
            this.allCrosingsToolStripMenuItem.Name = "allCrosingsToolStripMenuItem";
            this.allCrosingsToolStripMenuItem.Size = new Size(152, 22);
            this.allCrosingsToolStripMenuItem.Text = "&All crosings";
            this.allCrosingsToolStripMenuItem.Click += new System.EventHandler(this.AllCrosingsToolStripMenuItemClick);

            // countDataGridView
            this.countDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countDataGridView.Dock = DockStyle.Fill;
            this.countDataGridView.Location = new Point(0, 24);
            this.countDataGridView.Name = "countDataGridView";
            /*this.countDataGridView.Size = new System.Drawing.Size(284, 262);*/
            this.countDataGridView.TabIndex = 1;
            this.countDataGridView.ReadOnly = true;
            this.countDataGridView.RowHeadersVisible = false;
            this.countDataGridView.RowHeadersWidth = 30;
            this.countDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            // MainForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(284, 262);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Controls.Add(this.countDataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.Name = "MainForm";
            this.Text = "GUT Tracker TwoCat";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.countDataGridView).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            /* countDataGridView */

            // Alternating background
            this.countDataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.countDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Prevent automatic generation of columns
            this.countDataGridView.AutoGenerateColumns = false;

            // Prevent resize
            this.countDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.countDataGridView.AllowUserToResizeRows = false;

            // Add shows column
            DataGridViewTextBoxColumn showsColumn = new DataGridViewTextBoxColumn();
            showsColumn.DataPropertyName = "Shows";
            showsColumn.HeaderText = "Shows";
            showsColumn.Width = 50;
            showsColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            showsColumn.DefaultCellStyle.Font = new Font(this.optionsToolStripMenuItem.Font, this.optionsToolStripMenuItem.Font.Style ^ FontStyle.Italic);
            this.countDataGridView.Columns.Add(showsColumn);

            // Add count column
            DataGridViewTextBoxColumn countColumn = new DataGridViewTextBoxColumn();
            countColumn.DataPropertyName = "Count";
            countColumn.HeaderText = "Count";
            countColumn.Width = 50;
            countColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /* countColumn.DefaultCellStyle.Font = new Font(countColumn.DefaultCellStyle.Font, countColumn.DefaultCellStyle.Font.Style ^ FontStyle.Italic); */
            this.countDataGridView.Columns.Add(countColumn);

            // Add numbers column
            DataGridViewTextBoxColumn numbersColumn = new DataGridViewTextBoxColumn();
            numbersColumn.DataPropertyName = "Numbers";
            numbersColumn.HeaderText = "Numbers";
            showsColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numbersColumn.DefaultCellStyle.Font = new Font(this.optionsToolStripMenuItem.Font, this.optionsToolStripMenuItem.Font.Style ^ FontStyle.Italic);
            numbersColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.countDataGridView.Columns.Add(numbersColumn);

            // Set countDataGridView DataSource
            this.countDataGridView.DataSource = this.counterBindingList;
        }

        /// <summary>
        /// Init the specified passedMarshal.
        /// </summary>
        /// <param name="passedMarshal">Passed marshal.</param>
        public void Init(object passedMarshal)
        {
            // Set marshal 
            this.marshal = passedMarshal;

            // Set icon
            this.Icon = (Icon)this.marshal.GetType().GetProperty("Icon").GetValue(this.marshal, null);

            // Show this form
            this.Show();

            // Set advisor form
            this.advisorForm = new AdvisorForm();

            // Set datasource
            this.advisorForm.SetAdvisorDataSource(ref this.advisorBindingList);

            // Set advisor form icon
            this.advisorForm.Icon = this.Icon;

            // Show advisor form
            this.advisorForm.Visible = true;
        }

        /// <summary>
        /// Processes input.
        /// </summary>
        public void Input()
        {
            // Get last from marshal
            string last = (string)this.marshal.GetType().GetProperty("Last").GetValue(this.marshal, null);

            // Declare last int
            int lastInt = -1;

            // Check for undo
            if (last == "-U")
            {
                // Half if there's nothing
                if (this.historyStack.Count == 0)
                {
                    // Halt flow
                    return;
                }

                /* One item in history */

                // Check if there's only one element
                if (this.historyStack.Count == 1)
                {
                    // Clear everything
                    this.advisorBindingList.Clear();
                    this.counterBindingList.Clear();
                    this.historyStack.Clear();
                    this.cycleList.Clear();

                    // Halt flow
                    return;
                }

                /* One item in cycle */
                if (this.cycleList.Count < 2)
                {
                    // Remove one from history
                    this.historyStack.Pop();

                    // Clear binding lists
                    this.advisorBindingList.Clear();
                    this.counterBindingList.Clear();
                    
                    // Check there's something in cycle
                    if (this.cycleList.Count > 0)
                    {
                        // Clear cycle list
                        this.cycleList.Clear();
                    }

                    // Halt flow
                    return;
                }

                /* Two or more */

                // Remove one from history
                this.historyStack.Pop();

                // Set last int to prev number + remove another one from history
                lastInt = this.historyStack.Pop();

                // Remove two numbers from cycle list
                this.cycleList.RemoveRange(this.cycleList.Count - 2, 2);
            }
            else
            {
                // Set Last int
                lastInt = Convert.ToInt32(last);
            }
                            
            // Add current number to history stack
            this.historyStack.Push(lastInt);

            // Add current number to cycle list
            this.cycleList.Add(lastInt);

            // Update
            this.UpdateRoutine();

            // Clear advisor
            this.advisorBindingList.Clear();

            // Variable to hold bets
            List<int> betNumbers = new List<int>();

            // Select bets here
            for (int i = 0; i < this.counterBindingList.Count; i++)
            {
                // Check there's something in shows for i
                if (this.counterBindingList[i].Shows.Length > 0)
                {
                    // Check it's a whole number
                    if (!this.counterBindingList[i].Shows.StartsWith(">"))
                    {
                        // Browse for the next whole number
                        for (int j = i + 1; j < this.counterBindingList.Count; j++)
                        {
                            // Check there's something valid in shows for j
                            if (this.counterBindingList[j].Shows.Length > 0 && !this.counterBindingList[j].Shows.StartsWith(">"))
                            {
                                // Check it's the next whole number 
                                if (Convert.ToInt32(this.counterBindingList[i].Shows) == Convert.ToInt32(this.counterBindingList[j].Shows) - 1)
                                {
                                    // Check for eligible counts
                                    if (this.counterBindingList[i].Count == this.counterBindingList[j].Count || this.counterBindingList[i].Count == this.counterBindingList[j].Count + 1)
                                    {
                                        // Populate betNumbers list
                                        foreach (string number in this.counterBindingList[i].Numbers.Split(','))
                                        {
                                            // Current number (00 => 37)
                                            string currentNumber = number == "00" ? "37" : number;

                                            // Add current one
                                            betNumbers.Add(Convert.ToInt32(currentNumber));
                                        }
                                            
                                        // Add advisor row
                                        this.advisorBindingList.Add(new AdvisorRow(this.counterBindingList[i].Shows + " vs " + this.counterBindingList[j].Shows, new List<string>(this.counterBindingList[i].Numbers.Split(','))));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // TODO Check if must bet everything (Canonical tracker)

            // Send bets to marshal object
            for (int n = 0; n < 38; n++)
            {
                // Check if present
                if (betNumbers.Contains(n))
                {
                    // Add current bet
                    this.marshal.GetType().InvokeMember("AddBet", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, this.marshal, new object[] { "1@" + n.ToString() });
                }
            }            
        }

        /// <summary>
        /// Update procedure.
        /// </summary>
        private void UpdateRoutine()
        {
            // Declare and populate shows dictionary
            Dictionary<int, List<int>> showsDic = this.GetShowsDic();

            // Clear counter
            this.counterBindingList.Clear();

            // Place shows, count, numbers in counter
            for (int i = 0; i <= this.maxCount; i++)
            {
                // Check there's something
                if (showsDic[i].Count > 0)
                {
                    // Insert current row
                    this.counterBindingList.Add(new NumberCount(i.ToString(), showsDic[i].Count, showsDic[i]));

                    /* Insert "more than" row */

                    // Collected numbers list
                    List<int> collectedNumbers = new List<int>();

                    // Get greater than current 
                    for (int gt = i + 1; gt < showsDic.Count; gt++)
                    {
                        // Check there's something
                        if (showsDic[gt].Count > 0)
                        {
                            // Add to collected
                            collectedNumbers.AddRange(showsDic[gt]);
                        }
                    }
                    
                    // Check there's something collected
                    if (collectedNumbers.Count > 0)
                    {
                        // Sorted numbers list
                        List<int> sortedNumbers = new List<int>();

                        // Sort collected
                        for (int n = 0; n < 38; n++)
                        {
                            // Check it's present
                            if (collectedNumbers.Contains(n))
                            {
                                sortedNumbers.Add(n); 
                            }
                        }

                        // Add "more than" row
                        this.counterBindingList.Add(new NumberCount("> " + i.ToString(), sortedNumbers.Count, sortedNumbers));
                    }
                }
            }
        }

        /// <summary>
        /// Gets the shows dictionary.
        /// </summary>
        /// <returns>The shows dictionary.</returns>
        private Dictionary<int, List<int>> GetShowsDic()
        {
            // Array shows
            int[] showsArray = new int[38];
             
            // Walk cycle list
            foreach (int numberSpun in this.cycleList)
            {
                // Rise in shows array
                showsArray[numberSpun]++;
            }

            // Times dictionary
            Dictionary<int, List<int>> timesDic = new Dictionary<int, List<int>>();

            // Add all keys at once to ease further key lookup
            for (int i = 0; i < 38; i++)
            {
                // Add current key
                timesDic.Add(i, new List<int>());
            }

            // Walk array shows
            for (int i = 0; i < 38; i++)
            {
                // Trim proper amount from numbers for no zero, European
                if ((this.wheelType == 0 && (i == 0 || i == 37)) || (this.wheelType == 1 && i == 37))
                {
                    // Go to next iteration
                    continue;
                }

                // Check there's something
                if (showsArray[i] > 0)
                {
                    // Add current shows
                    timesDic[showsArray[i]].Add(i);
                }
                else
                {
                    // Add it to zero
                    timesDic[0].Add(i);
                }
            }

            // Return populated dictionary
            return timesDic;
        }

        /// <summary>
        /// Sets the number list.
        /// </summary>
        private void SetNumberList()
        {
            // Limit number
            int limit = 0;

            // Set based on current wheel
            switch (this.wheelType)
            {
            // No zero
                case 0:

                    // 36 numbers
                    limit = 36;

                    break;

            // European
                case 1:

                    // 37 numbers
                    limit = 37;

                    break;

            // American
                case 2:

                    // 38 numbers
                    limit = 38;

                    break;
            }

            // Clear numbers list
            this.numbersList.Clear();

            // Populate orderly
            for (int i = 0; i < limit; i++)
            {
                // Skip zero as required
                if (this.wheelType == 0)
                {
                    // Go to next iteration
                    continue;
                }

                // Add number to list
                this.numbersList.Add(i);
            }
        }

        /// <summary>
        /// Jump back tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void JumpBackToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check we have elements
            if (this.historyStack.Count == 0)
            {
                // Halt flow
                return;
            }

            // Check if we must proceed
            if (this.cycleList.Count > this.jumpBackValue)
            {
                // Set cycle list
                this.cycleList = this.cycleList.GetRange(this.cycleList.Count - this.jumpBackValue, this.jumpBackValue);

                // Get last number
                int lastNumber = this.historyStack.Peek();

                // Remove one from history
                this.historyStack.Pop();

                // Remove one from cycle
                this.cycleList.RemoveAt(this.cycleList.Count - 1);

                // Set last in marshal
                this.marshal.GetType().GetProperty("Last").SetValue(this.marshal, Convert.ChangeType(lastNumber, this.marshal.GetType().GetProperty("Last").PropertyType), null);

                // Invoke input
                this.Input();
            }
        }

        /// <summary>
        /// Options tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OptionsToolStripMenuItemClick(object sender, EventArgs e)
        {
            /* TODO Consider event handler removal */
        }

        /// <summary>
        /// Sets jump back spins.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void SetJumpBackSpinsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // New MaxCountForm instance
            SetNumericValueForm numericValueForm = new SetNumericValueForm("Set jump back spins:", this.jumpBackValue, 1000);

            // Show it as dialog
            DialogResult dialogResult = numericValueForm.ShowDialog(this);

            // Get value
            if (dialogResult == DialogResult.OK)
            {
                // Assign maxCount
                this.jumpBackValue = numericValueForm.GetNumericValueField;
            }

            // Update
            this.UpdateRoutine();
        }

        /// <summary>
        /// Sets the max shows.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void SetMaxShowsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // New MaxCountForm instance
            SetNumericValueForm numericValueForm = new SetNumericValueForm("Set max. shows:", this.maxCount, this.maxCountMaximum);

            // Show it as dialog
            DialogResult dialogResult = numericValueForm.ShowDialog(this);

            // Get value
            if (dialogResult == DialogResult.OK)
            {
                // Assign maxCount
                this.maxCount = numericValueForm.GetNumericValueField;
            }

            // Update
            this.UpdateRoutine();
        }

        /// <summary>
        /// European tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void EuropeanToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.americanToolStripMenuItem.Checked = false;
            this.noZeroToolStripMenuItem.Checked = false;

            // Check
            this.europeanToolStripMenuItem.Checked = true;

            // Set proper maximum
            this.maxCountMaximum = 37;

            // Set wheel type
            this.wheelType = 1;

            // Update
            this.UpdateRoutine();
        }

        /// <summary>
        /// American tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void AmericanToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.europeanToolStripMenuItem.Checked = false;
            this.noZeroToolStripMenuItem.Checked = false;

            // Check
            this.americanToolStripMenuItem.Checked = true;

            // Set proper maximum
            this.maxCountMaximum = 38;

            // Set wheel type
            this.wheelType = 2;

            // Update
            this.UpdateRoutine();
        }

        /// <summary>
        /// No zero tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void NoZeroToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.europeanToolStripMenuItem.Checked = false;
            this.americanToolStripMenuItem.Checked = false;

            // Check
            this.noZeroToolStripMenuItem.Checked = true;

            // Set proper maximum
            this.maxCountMaximum = 36;

            // Set wheel type
            this.wheelType = 0;

            // Update
            this.UpdateRoutine();
        }

        /// <summary>
        /// Single click tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void SingleClickToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.doubleClickToolStripMenuItem.Checked = false;
            this.allCrosingsToolStripMenuItem.Checked = false;

            // Check
            this.singleClickToolStripMenuItem.Checked = true;

            // Set bet mode
            this.betMode = 0;
        }

        /// <summary>
        /// Double click tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void DoubleClickToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.singleClickToolStripMenuItem.Checked = false;
            this.allCrosingsToolStripMenuItem.Checked = false;

            // Check
            this.doubleClickToolStripMenuItem.Checked = true;

            // Set bet mode
            this.betMode = 1;
        }

        /// <summary>
        /// All crosings tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void AllCrosingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Uncheck
            this.singleClickToolStripMenuItem.Checked = false;
            this.doubleClickToolStripMenuItem.Checked = false;

            // Check
            this.allCrosingsToolStripMenuItem.Checked = true;

            // Set bet mode
            this.betMode = 2;
        }
    }
}