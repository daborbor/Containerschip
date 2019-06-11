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
            this.lbContainer = new System.Windows.Forms.ListBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.nudContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.butMakeShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContainer
            // 
            this.lbContainer.FormattingEnabled = true;
            this.lbContainer.Location = new System.Drawing.Point(12, 12);
            this.lbContainer.Name = "lbContainer";
            this.lbContainer.Size = new System.Drawing.Size(120, 95);
            this.lbContainer.TabIndex = 0;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(138, 418);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(107, 23);
            this.btnAddContainer.TabIndex = 1;
            this.btnAddContainer.Text = "Voeg container toe";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // nudContainerWeight
            // 
            this.nudContainerWeight.Location = new System.Drawing.Point(12, 421);
            this.nudContainerWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContainerWeight.Name = "nudContainerWeight";
            this.nudContainerWeight.Size = new System.Drawing.Size(120, 20);
            this.nudContainerWeight.TabIndex = 2;
            this.nudContainerWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(251, 421);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 3;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(377, 421);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 4;
            // 
            // butMakeShip
            // 
            this.butMakeShip.Location = new System.Drawing.Point(503, 418);
            this.butMakeShip.Name = "butMakeShip";
            this.butMakeShip.Size = new System.Drawing.Size(81, 23);
            this.butMakeShip.TabIndex = 5;
            this.butMakeShip.Text = "Maak schip";
            this.butMakeShip.UseVisualStyleBackColor = true;
            this.butMakeShip.Click += new System.EventHandler(this.butMakeShip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.NumericUpDown nudContainerWeight;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Button butMakeShip;
    }
}

