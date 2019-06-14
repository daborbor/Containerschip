namespace Containerschip
{
    partial class Form1
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
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.nudContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.butMakeShip = new System.Windows.Forms.Button();
            this.lbContainer = new System.Windows.Forms.ListBox();
            this.btnSorteer = new System.Windows.Forms.Button();
            this.cbWaardevol = new System.Windows.Forms.CheckBox();
            this.cbElektriciteit = new System.Windows.Forms.CheckBox();
            this.nudRandom = new System.Windows.Forms.NumericUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBalans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddContainer.Location = new System.Drawing.Point(138, 420);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(107, 23);
            this.btnAddContainer.TabIndex = 1;
            this.btnAddContainer.Text = "Voeg container toe";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // nudContainerWeight
            // 
            this.nudContainerWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudContainerWeight.Location = new System.Drawing.Point(12, 423);
            this.nudContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudContainerWeight.Name = "nudContainerWeight";
            this.nudContainerWeight.Size = new System.Drawing.Size(120, 20);
            this.nudContainerWeight.TabIndex = 2;
            this.nudContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudX.Location = new System.Drawing.Point(302, 423);
            this.nudX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(69, 20);
            this.nudX.TabIndex = 3;
            this.nudX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudY
            // 
            this.nudY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudY.Location = new System.Drawing.Point(423, 423);
            this.nudY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(78, 20);
            this.nudY.TabIndex = 4;
            this.nudY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butMakeShip
            // 
            this.butMakeShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butMakeShip.Location = new System.Drawing.Point(507, 420);
            this.butMakeShip.Name = "butMakeShip";
            this.butMakeShip.Size = new System.Drawing.Size(81, 23);
            this.butMakeShip.TabIndex = 5;
            this.butMakeShip.Text = "Maak schip";
            this.butMakeShip.UseVisualStyleBackColor = true;
            this.butMakeShip.Click += new System.EventHandler(this.butMakeShip_Click);
            // 
            // lbContainer
            // 
            this.lbContainer.FormattingEnabled = true;
            this.lbContainer.Location = new System.Drawing.Point(12, 12);
            this.lbContainer.Name = "lbContainer";
            this.lbContainer.Size = new System.Drawing.Size(120, 264);
            this.lbContainer.TabIndex = 0;
            // 
            // btnSorteer
            // 
            this.btnSorteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorteer.AutoSize = true;
            this.btnSorteer.Location = new System.Drawing.Point(594, 420);
            this.btnSorteer.Name = "btnSorteer";
            this.btnSorteer.Size = new System.Drawing.Size(81, 23);
            this.btnSorteer.TabIndex = 6;
            this.btnSorteer.Text = "Sorteer";
            this.btnSorteer.UseVisualStyleBackColor = true;
            this.btnSorteer.Click += new System.EventHandler(this.btnSorteer_Click);
            // 
            // cbWaardevol
            // 
            this.cbWaardevol.AutoSize = true;
            this.cbWaardevol.Location = new System.Drawing.Point(12, 400);
            this.cbWaardevol.Name = "cbWaardevol";
            this.cbWaardevol.Size = new System.Drawing.Size(78, 17);
            this.cbWaardevol.TabIndex = 7;
            this.cbWaardevol.Text = "Waardevol";
            this.cbWaardevol.UseVisualStyleBackColor = true;
            // 
            // cbElektriciteit
            // 
            this.cbElektriciteit.AutoSize = true;
            this.cbElektriciteit.Location = new System.Drawing.Point(12, 377);
            this.cbElektriciteit.Name = "cbElektriciteit";
            this.cbElektriciteit.Size = new System.Drawing.Size(77, 17);
            this.cbElektriciteit.TabIndex = 8;
            this.cbElektriciteit.Text = "Elektriciteit";
            this.cbElektriciteit.UseVisualStyleBackColor = true;
            // 
            // nudRandom
            // 
            this.nudRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudRandom.Location = new System.Drawing.Point(12, 282);
            this.nudRandom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandom.Name = "nudRandom";
            this.nudRandom.Size = new System.Drawing.Size(120, 20);
            this.nudRandom.TabIndex = 9;
            this.nudRandom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandom.Location = new System.Drawing.Point(12, 308);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(134, 23);
            this.btnRandom.TabIndex = 10;
            this.btnRandom.Text = "Voeg random containers toe";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Breedte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lengte";
            // 
            // lbBalans
            // 
            this.lbBalans.AutoSize = true;
            this.lbBalans.Location = new System.Drawing.Point(12, 334);
            this.lbBalans.Name = "lbBalans";
            this.lbBalans.Size = new System.Drawing.Size(45, 13);
            this.lbBalans.TabIndex = 13;
            this.lbBalans.Text = "Balans: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 452);
            this.Controls.Add(this.lbBalans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.nudRandom);
            this.Controls.Add(this.cbElektriciteit);
            this.Controls.Add(this.cbWaardevol);
            this.Controls.Add(this.btnSorteer);
            this.Controls.Add(this.butMakeShip);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.nudContainerWeight);
            this.Controls.Add(this.btnAddContainer);
            this.Controls.Add(this.lbContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.NumericUpDown nudContainerWeight;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Button butMakeShip;
        private System.Windows.Forms.ListBox lbContainer;
        private System.Windows.Forms.Button btnSorteer;
        private System.Windows.Forms.CheckBox cbWaardevol;
        private System.Windows.Forms.CheckBox cbElektriciteit;
        private System.Windows.Forms.NumericUpDown nudRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBalans;
    }
}

