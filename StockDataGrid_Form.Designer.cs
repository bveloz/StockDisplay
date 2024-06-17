namespace StockDisplay
{
    partial class StockDataGrid_Form
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
            this.openFile_Button = new System.Windows.Forms.Button();
            this.loadStock_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFile_Button
            // 
            this.openFile_Button.Location = new System.Drawing.Point(12, 415);
            this.openFile_Button.Name = "openFile_Button";
            this.openFile_Button.Size = new System.Drawing.Size(99, 23);
            this.openFile_Button.TabIndex = 0;
            this.openFile_Button.Text = "Load Stock";
            this.openFile_Button.UseVisualStyleBackColor = true;
            // 
            // StockDataGrid_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFile_Button);
            this.Name = "StockDataGrid_Form";
            this.Text = "Data Grid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile_Button;
        private System.Windows.Forms.OpenFileDialog loadStock_openFileDialog;
    }
}

