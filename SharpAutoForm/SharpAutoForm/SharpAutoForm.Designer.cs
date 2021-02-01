namespace SharpAutoForm
{
    partial class SharpAutoForm
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
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AdditionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomizedRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.Menu_Strip.SuspendLayout();
            this.AdditionalItemsGroupBox.SuspendLayout();
            this.ExteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.EditMenuStrip,
            this.HelpMenuStrip});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.Size = new System.Drawing.Size(705, 28);
            this.Menu_Strip.TabIndex = 0;
            this.Menu_Strip.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuStrip});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FileMenuStrip.Size = new System.Drawing.Size(46, 24);
            this.FileMenuStrip.Text = "File";
            // 
            // ExitMenuStrip
            // 
            this.ExitMenuStrip.Name = "ExitMenuStrip";
            this.ExitMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMenuStrip.Size = new System.Drawing.Size(169, 26);
            this.ExitMenuStrip.Text = "Exit";
            this.ExitMenuStrip.Click += new System.EventHandler(this.ExitMenuStrip_Click);
            // 
            // EditMenuStrip
            // 
            this.EditMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateMenuStrip,
            this.ClearMenuStrip,
            this.FontMenuStrip,
            this.ColorMenuStrip});
            this.EditMenuStrip.Name = "EditMenuStrip";
            this.EditMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditMenuStrip.Size = new System.Drawing.Size(49, 24);
            this.EditMenuStrip.Text = "Edit";
            // 
            // CalculateMenuStrip
            // 
            this.CalculateMenuStrip.Name = "CalculateMenuStrip";
            this.CalculateMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.CalculateMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.CalculateMenuStrip.Text = "Calculate";
            this.CalculateMenuStrip.Click += new System.EventHandler(this.CalculateMenuStrip_Click);
            // 
            // ClearMenuStrip
            // 
            this.ClearMenuStrip.Name = "ClearMenuStrip";
            this.ClearMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.ClearMenuStrip.Size = new System.Drawing.Size(200, 26);
            this.ClearMenuStrip.Text = "Clear";
            this.ClearMenuStrip.Click += new System.EventHandler(this.ClearMenuStrip_Click);
            // 
            // FontMenuStrip
            // 
            this.FontMenuStrip.Name = "FontMenuStrip";
            this.FontMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FontMenuStrip.Size = new System.Drawing.Size(200, 26);
            this.FontMenuStrip.Text = "Font";
            this.FontMenuStrip.Click += new System.EventHandler(this.FontMenuStrip_Click);
            // 
            // ColorMenuStrip
            // 
            this.ColorMenuStrip.Name = "ColorMenuStrip";
            this.ColorMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ColorMenuStrip.Size = new System.Drawing.Size(200, 26);
            this.ColorMenuStrip.Text = "Color";
            this.ColorMenuStrip.Click += new System.EventHandler(this.ColorMenuStrip_Click);
            // 
            // HelpMenuStrip
            // 
            this.HelpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuStrip});
            this.HelpMenuStrip.Name = "HelpMenuStrip";
            this.HelpMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HelpMenuStrip.Size = new System.Drawing.Size(55, 24);
            this.HelpMenuStrip.Text = "Help";
            // 
            // AboutMenuStrip
            // 
            this.AboutMenuStrip.Name = "AboutMenuStrip";
            this.AboutMenuStrip.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutMenuStrip.Size = new System.Drawing.Size(157, 26);
            this.AboutMenuStrip.Text = "About";
            this.AboutMenuStrip.Click += new System.EventHandler(this.AboutMenuStrip_Click);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceLabel.Location = new System.Drawing.Point(63, 55);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(96, 18);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price :  ";
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(165, 54);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(135, 22);
            this.BasePriceTextBox.TabIndex = 2;
            this.BasePriceTextBox.Text = "0";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(20, 96);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(143, 18);
            this.AdditionalOptionsLabel.TabIndex = 3;
            this.AdditionalOptionsLabel.Text = "Additional Options :  ";
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(165, 96);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(135, 22);
            this.AdditionalOptionsTextBox.TabIndex = 4;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(72, 142);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(91, 18);
            this.SubTotalLabel.TabIndex = 5;
            this.SubTotalLabel.Text = "Sub Total :   ";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(165, 142);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(135, 22);
            this.SubTotalTextBox.TabIndex = 6;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(35, 180);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(120, 18);
            this.SalesTaxLabel.TabIndex = 7;
            this.SalesTaxLabel.Text = "Sales Tax (13%):";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(165, 180);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(135, 22);
            this.SalesTaxTextBox.TabIndex = 8;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(106, 224);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(53, 18);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total : ";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(165, 224);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(135, 22);
            this.TotalTextBox.TabIndex = 10;
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(14, 261);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(145, 18);
            this.TradeInAllowanceLabel.TabIndex = 11;
            this.TradeInAllowanceLabel.Text = "Trade-in Allowance : ";
            // 
            // TradeInAllowanceTextBox
            // 
            this.TradeInAllowanceTextBox.Location = new System.Drawing.Point(165, 261);
            this.TradeInAllowanceTextBox.Name = "TradeInAllowanceTextBox";
            this.TradeInAllowanceTextBox.Size = new System.Drawing.Size(135, 22);
            this.TradeInAllowanceTextBox.TabIndex = 12;
            this.TradeInAllowanceTextBox.Text = "0";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDueLabel.Location = new System.Drawing.Point(57, 299);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(102, 18);
            this.AmountDueLabel.TabIndex = 13;
            this.AmountDueLabel.Text = "Amount Due : ";
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(165, 298);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(135, 22);
            this.AmountDueTextBox.TabIndex = 14;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(300, 446);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 44);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(600, 446);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 44);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(17, 446);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 44);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AdditionalItemsGroupBox
            // 
            this.AdditionalItemsGroupBox.Controls.Add(this.ComputerNavigationCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalItemsGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalItemsGroupBox.Location = new System.Drawing.Point(372, 54);
            this.AdditionalItemsGroupBox.Name = "AdditionalItemsGroupBox";
            this.AdditionalItemsGroupBox.Size = new System.Drawing.Size(244, 133);
            this.AdditionalItemsGroupBox.TabIndex = 18;
            this.AdditionalItemsGroupBox.TabStop = false;
            this.AdditionalItemsGroupBox.Text = "Additional Items";
            this.AdditionalItemsGroupBox.Enter += new System.EventHandler(this.AdditionalItemsGroupBox_Enter);
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(18, 82);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(169, 22);
            this.ComputerNavigationCheckBox.TabIndex = 2;
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.ComputerNavigationCheckBox.CheckedChanged += new System.EventHandler(this.ComputerNavigationCheckBox_CheckedChanged);
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(18, 51);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(128, 22);
            this.LeatherInteriorCheckBox.TabIndex = 1;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.LeatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this.LeatherInteriorCheckBox_CheckedChanged);
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(18, 23);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(128, 22);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.StereoSystemCheckBox.CheckedChanged += new System.EventHandler(this.StereoSystemCheckBox_CheckedChanged);
            // 
            // ExteriorFinishGroupBox
            // 
            this.ExteriorFinishGroupBox.Controls.Add(this.CustomizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExteriorFinishGroupBox.Location = new System.Drawing.Point(372, 193);
            this.ExteriorFinishGroupBox.Name = "ExteriorFinishGroupBox";
            this.ExteriorFinishGroupBox.Size = new System.Drawing.Size(244, 139);
            this.ExteriorFinishGroupBox.TabIndex = 19;
            this.ExteriorFinishGroupBox.TabStop = false;
            this.ExteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // CustomizedRadioButton
            // 
            this.CustomizedRadioButton.AutoSize = true;
            this.CustomizedRadioButton.Location = new System.Drawing.Point(18, 75);
            this.CustomizedRadioButton.Name = "CustomizedRadioButton";
            this.CustomizedRadioButton.Size = new System.Drawing.Size(169, 22);
            this.CustomizedRadioButton.TabIndex = 2;
            this.CustomizedRadioButton.Text = "Customized Detailing";
            this.CustomizedRadioButton.UseVisualStyleBackColor = true;
            this.CustomizedRadioButton.CheckedChanged += new System.EventHandler(this.CustomizedRadioButton_CheckedChanged);
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(18, 47);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(90, 22);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.CheckedChanged += new System.EventHandler(this.PearlizedRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(18, 19);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(88, 22);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 497);
            this.Controls.Add(this.ExteriorFinishGroupBox);
            this.Controls.Add(this.AdditionalItemsGroupBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TradeInAllowanceTextBox);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.Menu_Strip);
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "SharpAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Center";
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.AdditionalItemsGroupBox.ResumeLayout(false);
            this.AdditionalItemsGroupBox.PerformLayout();
            this.ExteriorFinishGroupBox.ResumeLayout(false);
            this.ExteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CalculateMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FontMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ColorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuStrip;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.TextBox TradeInAllowanceTextBox;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox AdditionalItemsGroupBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.GroupBox ExteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton CustomizedRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
    }
}

