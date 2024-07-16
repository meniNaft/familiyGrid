namespace familiyGrid
{
    partial class MainGrid
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_main = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_main).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_main
            // 
            dataGridView_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_main.Location = new Point(12, 12);
            dataGridView_main.Name = "dataGridView_main";
            dataGridView_main.RowHeadersWidth = 51;
            dataGridView_main.Size = new Size(749, 433);
            dataGridView_main.TabIndex = 0;
            // 
            // MainGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_main);
            Name = "MainGrid";
            Text = "Form1";
            Load += MainGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_main;
    }
}
