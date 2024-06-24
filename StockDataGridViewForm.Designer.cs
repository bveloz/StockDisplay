using System;

namespace StockDisplay
{
    partial class StockDataGridViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadDataButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.loadStocksOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(3, 2);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(129, 27);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Load Stock";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.updateButton.Location = new System.Drawing.Point(748, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 27);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // loadStocksOpenFileDialog
            // 
            this.loadStocksOpenFileDialog.FileName = "loadStocksOpenFileDialog";
            this.loadStocksOpenFileDialog.Filter = "Monthly|*-Month.csv|Weekly|*-Week.csv|Daily|*Day.csv|All Files|*.*";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(223, 3);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(518, 3);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(145, 7);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(69, 16);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(440, 7);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(66, 16);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date:";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.updateButton);
            this.bottomPanel.Controls.Add(this.endDateLabel);
            this.bottomPanel.Controls.Add(this.loadDataButton);
            this.bottomPanel.Controls.Add(this.startDateLabel);
            this.bottomPanel.Controls.Add(this.startDateTimePicker);
            this.bottomPanel.Controls.Add(this.endDateTimePicker);
            this.bottomPanel.Location = new System.Drawing.Point(12, 415);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(882, 37);
            this.bottomPanel.TabIndex = 6;
            // 
            // StockDataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockDataGridViewForm";
            this.Text = "StockDataGridViewForm";
            this.Load += new System.EventHandler(this.StockDataGridViewForm_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.OpenFileDialog loadStocksOpenFileDialog;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Panel bottomPanel;
    }
}

