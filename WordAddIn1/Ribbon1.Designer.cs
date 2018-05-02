namespace WordAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.gallery1 = this.Factory.CreateRibbonGallery();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "页面排版";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.button4);
            this.group1.Items.Add(this.button5);
            this.group1.Items.Add(this.button3);
            this.group1.Items.Add(this.gallery1);
            this.group1.Items.Add(this.button6);
            this.group1.Label = "文档操作";
            this.group1.Name = "group1";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::WordAddIn1.Properties.Resources._267b;
            this.button1.Label = "竖排";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = global::WordAddIn1.Properties.Resources._270a;
            this.button2.Label = "字号变大";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = global::WordAddIn1.Properties.Resources._2614;
            this.button4.Label = "button4";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::WordAddIn1.Properties.Resources._267b;
            this.button3.Label = "button3";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            // 
            // button5
            // 
            this.button5.Image = global::WordAddIn1.Properties.Resources._2615;
            this.button5.Label = "button5";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            // 
            // button6
            // 
            this.button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button6.Image = global::WordAddIn1.Properties.Resources._2615;
            this.button6.Label = "button6";
            this.button6.Name = "button6";
            this.button6.ShowImage = true;
            // 
            // gallery1
            // 
            this.gallery1.Buttons.Add(this.button7);
            this.gallery1.Buttons.Add(this.button8);
            this.gallery1.Buttons.Add(this.button9);
            this.gallery1.Buttons.Add(this.button10);
            this.gallery1.Buttons.Add(this.button11);
            this.gallery1.ColumnCount = 3;
            this.gallery1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.gallery1.Description = "test";
            this.gallery1.Image = global::WordAddIn1.Properties.Resources._267b;
            ribbonDropDownItemImpl1.Image = global::WordAddIn1.Properties.Resources._2614;
            ribbonDropDownItemImpl1.Label = "Item0";
            ribbonDropDownItemImpl2.Image = global::WordAddIn1.Properties.Resources._2615;
            ribbonDropDownItemImpl2.Label = "Item1";
            ribbonDropDownItemImpl3.Image = global::WordAddIn1.Properties.Resources._267b;
            ribbonDropDownItemImpl3.Label = "Item2";
            ribbonDropDownItemImpl4.Image = global::WordAddIn1.Properties.Resources._270a;
            ribbonDropDownItemImpl4.Label = "Item3";
            this.gallery1.Items.Add(ribbonDropDownItemImpl1);
            this.gallery1.Items.Add(ribbonDropDownItemImpl2);
            this.gallery1.Items.Add(ribbonDropDownItemImpl3);
            this.gallery1.Items.Add(ribbonDropDownItemImpl4);
            this.gallery1.Label = "gallery1";
            this.gallery1.Name = "gallery1";
            this.gallery1.RowCount = 3;
            this.gallery1.ShowImage = true;
            // 
            // button7
            // 
            this.button7.Image = global::WordAddIn1.Properties.Resources._267b;
            this.button7.Label = "button7";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            // 
            // button8
            // 
            this.button8.Image = global::WordAddIn1.Properties.Resources._270a;
            this.button8.Label = "button8";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            // 
            // button9
            // 
            this.button9.Image = global::WordAddIn1.Properties.Resources._2600;
            this.button9.Label = "button9";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            // 
            // button10
            // 
            this.button10.Image = global::WordAddIn1.Properties.Resources._2615;
            this.button10.Label = "button10";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            // 
            // button11
            // 
            this.button11.Image = global::WordAddIn1.Properties.Resources._2614;
            this.button11.Label = "button11";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery gallery1;
        private Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        private Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        private Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        private Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        private Microsoft.Office.Tools.Ribbon.RibbonButton button11;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
