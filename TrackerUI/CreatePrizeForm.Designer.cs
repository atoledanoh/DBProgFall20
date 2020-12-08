
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.lblCreatePrize = new System.Windows.Forms.Label();
            this.lblPlaceNumber = new System.Windows.Forms.Label();
            this.txtPlaceNumber = new System.Windows.Forms.TextBox();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.txtPrizeAmount = new System.Windows.Forms.TextBox();
            this.lblPrizeAmount = new System.Windows.Forms.Label();
            this.txtPrizePercentage = new System.Windows.Forms.TextBox();
            this.lblPrizePercentage = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreatePrize
            // 
            this.lblCreatePrize.Location = new System.Drawing.Point(47, 53);
            this.lblCreatePrize.Name = "lblCreatePrize";
            this.lblCreatePrize.Size = new System.Drawing.Size(108, 28);
            this.lblCreatePrize.TabIndex = 0;
            this.lblCreatePrize.Text = "Create Prize";
            // 
            // lblPlaceNumber
            // 
            this.lblPlaceNumber.AutoSize = true;
            this.lblPlaceNumber.Location = new System.Drawing.Point(47, 98);
            this.lblPlaceNumber.Name = "lblPlaceNumber";
            this.lblPlaceNumber.Size = new System.Drawing.Size(117, 23);
            this.lblPlaceNumber.TabIndex = 1;
            this.lblPlaceNumber.Text = "Place Number";
            // 
            // txtPlaceNumber
            // 
            this.txtPlaceNumber.Location = new System.Drawing.Point(191, 95);
            this.txtPlaceNumber.Name = "txtPlaceNumber";
            this.txtPlaceNumber.Size = new System.Drawing.Size(173, 31);
            this.txtPlaceNumber.TabIndex = 2;
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(191, 152);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(173, 31);
            this.txtPlaceName.TabIndex = 4;
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(47, 155);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(99, 23);
            this.lblPlaceName.TabIndex = 3;
            this.lblPlaceName.Text = "Place Name";
            // 
            // txtPrizeAmount
            // 
            this.txtPrizeAmount.Location = new System.Drawing.Point(191, 209);
            this.txtPrizeAmount.Name = "txtPrizeAmount";
            this.txtPrizeAmount.Size = new System.Drawing.Size(173, 31);
            this.txtPrizeAmount.TabIndex = 6;
            this.txtPrizeAmount.Text = "0";
            // 
            // lblPrizeAmount
            // 
            this.lblPrizeAmount.AutoSize = true;
            this.lblPrizeAmount.Location = new System.Drawing.Point(47, 212);
            this.lblPrizeAmount.Name = "lblPrizeAmount";
            this.lblPrizeAmount.Size = new System.Drawing.Size(104, 23);
            this.lblPrizeAmount.TabIndex = 5;
            this.lblPrizeAmount.Text = "Prize Amout";
            // 
            // txtPrizePercentage
            // 
            this.txtPrizePercentage.Location = new System.Drawing.Point(191, 319);
            this.txtPrizePercentage.Name = "txtPrizePercentage";
            this.txtPrizePercentage.Size = new System.Drawing.Size(173, 31);
            this.txtPrizePercentage.TabIndex = 8;
            this.txtPrizePercentage.Text = "0";
            // 
            // lblPrizePercentage
            // 
            this.lblPrizePercentage.AutoSize = true;
            this.lblPrizePercentage.Location = new System.Drawing.Point(47, 322);
            this.lblPrizePercentage.Name = "lblPrizePercentage";
            this.lblPrizePercentage.Size = new System.Drawing.Size(138, 23);
            this.lblPrizePercentage.TabIndex = 7;
            this.lblPrizePercentage.Text = "Prize Percentage";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(162, 268);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(47, 23);
            this.lblOr.TabIndex = 9;
            this.lblOr.Text = "- or -";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Location = new System.Drawing.Point(127, 399);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(151, 72);
            this.btnCreatePrize.TabIndex = 10;
            this.btnCreatePrize.Text = "CreatePrize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 538);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.txtPrizePercentage);
            this.Controls.Add(this.lblPrizePercentage);
            this.Controls.Add(this.txtPrizeAmount);
            this.Controls.Add(this.lblPrizeAmount);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.txtPlaceNumber);
            this.Controls.Add(this.lblPlaceNumber);
            this.Controls.Add(this.lblCreatePrize);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreatePrizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "createPrizeFrm";
            this.Text = "Create Prize";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatePrize;
        private System.Windows.Forms.Label lblPlaceNumber;
        private System.Windows.Forms.TextBox txtPlaceNumber;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.TextBox txtPrizeAmount;
        private System.Windows.Forms.Label lblPrizeAmount;
        private System.Windows.Forms.TextBox txtPrizePercentage;
        private System.Windows.Forms.Label lblPrizePercentage;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}