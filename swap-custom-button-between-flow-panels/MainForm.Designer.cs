namespace swap_custom_button_between_flow_panels
{
    partial class MainForm
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
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddLeft = new System.Windows.Forms.Button();
            this.buttonAddRight = new System.Windows.Forms.Button();
            this.tableLayoutPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.ColumnCount = 2;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.Controls.Add(this.flowLayoutPanelRight, 1, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.flowLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.buttonAddLeft, 0, 1);
            this.tableLayoutPanelContainer.Controls.Add(this.buttonAddRight, 1, 1);
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 2;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelContainer.TabIndex = 0;
            // 
            // flowLayoutPanelRight
            // 
            this.flowLayoutPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelRight.Location = new System.Drawing.Point(403, 3);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            this.flowLayoutPanelRight.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelRight.Size = new System.Drawing.Size(394, 399);
            this.flowLayoutPanelRight.TabIndex = 1;
            // 
            // flowLayoutPanelLeft
            // 
            this.flowLayoutPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanelLeft.Size = new System.Drawing.Size(394, 399);
            this.flowLayoutPanelLeft.TabIndex = 0;
            // 
            // buttonAddLeft
            // 
            this.buttonAddLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddLeft.Location = new System.Drawing.Point(3, 408);
            this.buttonAddLeft.Name = "buttonAddLeft";
            this.buttonAddLeft.Size = new System.Drawing.Size(112, 39);
            this.buttonAddLeft.TabIndex = 2;
            this.buttonAddLeft.Text = "Add";
            this.buttonAddLeft.UseVisualStyleBackColor = true;
            // 
            // buttonAddRight
            // 
            this.buttonAddRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRight.Location = new System.Drawing.Point(685, 408);
            this.buttonAddRight.Name = "buttonAddRight";
            this.buttonAddRight.Size = new System.Drawing.Size(112, 39);
            this.buttonAddRight.TabIndex = 2;
            this.buttonAddRight.Text = "Add";
            this.buttonAddRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.tableLayoutPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelContainer;
        private FlowLayoutPanel flowLayoutPanelRight;
        private FlowLayoutPanel flowLayoutPanelLeft;
        private Button buttonAddLeft;
        private Button buttonAddRight;
    }
}