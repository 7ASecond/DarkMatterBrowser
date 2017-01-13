namespace DarkMatterBrowser.Controls.Custom
{
    partial class BrowserControlBarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserControlBarControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonBack = new System.Windows.Forms.ToolStripSplitButton();
            this.buttonForward = new System.Windows.Forms.ToolStripSplitButton();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.buttonHome = new System.Windows.Forms.ToolStripButton();
            this.URIInputBox = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSettings = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonBack,
            this.buttonForward,
            this.buttonRefresh,
            this.buttonHome,
            this.URIInputBox,
            this.buttonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1142, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.SizeChanged += new System.EventHandler(this.toolStrip1_SizeChanged);
            this.toolStrip1.Resize += new System.EventHandler(this.toolStrip1_Resize);
            // 
            // buttonBack
            // 
            this.buttonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 22);
            this.buttonBack.Text = "toolStripSplitButton1";
            // 
            // buttonForward
            // 
            this.buttonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonForward.Image")));
            this.buttonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(32, 22);
            this.buttonForward.Text = "toolStripSplitButton2";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(23, 22);
            this.buttonRefresh.Text = "toolStripButton1";
            // 
            // buttonHome
            // 
            this.buttonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(23, 22);
            this.buttonHome.Text = "toolStripButton2";
            // 
            // URIInputBox
            // 
            this.URIInputBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.URIInputBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.URIInputBox.AutoSize = false;
            this.URIInputBox.BackColor = System.Drawing.Color.PaleGreen;
            this.URIInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URIInputBox.Name = "URIInputBox";
            this.URIInputBox.Size = new System.Drawing.Size(100, 23);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(23, 22);
            this.buttonSettings.Text = "toolStripButton3";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(25, 25);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BrowserControlBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "BrowserControlBarControl";
            this.Size = new System.Drawing.Size(1142, 28);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton buttonBack;
        private System.Windows.Forms.ToolStripSplitButton buttonForward;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.ToolStripButton buttonHome;
        private System.Windows.Forms.ToolStripTextBox URIInputBox;
        private System.Windows.Forms.ToolStripButton buttonSettings;
        private System.Windows.Forms.ImageList imageList;
    }
}
