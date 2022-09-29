
namespace HotelSYS
{
    partial class frmUpdateRoomType
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoomTypes = new System.Windows.Forms.ComboBox();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Room Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboRoomTypes
            // 
            this.cboRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cboRoomTypes.FormattingEnabled = true;
            this.cboRoomTypes.Location = new System.Drawing.Point(179, 36);
            this.cboRoomTypes.Name = "cboRoomTypes";
            this.cboRoomTypes.Size = new System.Drawing.Size(144, 23);
            this.cboRoomTypes.Sorted = true;
            this.cboRoomTypes.TabIndex = 1;
            this.cboRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cboRoomTypes_SelectedIndexChanged);
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.btnSubmit);
            this.grpRoomType.Controls.Add(this.txtDescription);
            this.grpRoomType.Controls.Add(this.label3);
            this.grpRoomType.Controls.Add(this.txtRate);
            this.grpRoomType.Controls.Add(this.label2);
            this.grpRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grpRoomType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpRoomType.Location = new System.Drawing.Point(55, 83);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(713, 356);
            this.grpRoomType.TabIndex = 2;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Update Room Type Details";
            this.grpRoomType.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(102, 37);
            this.txtDescription.MaxLength = 20;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 23);
            this.txtDescription.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(102, 75);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(78, 22);
            this.txtRate.TabIndex = 7;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rate";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(102, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmUpdateRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 473);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.cboRoomTypes);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateRoomType";
            this.Text = "Happy House Hotel - [Update Room Type]";
            this.Load += new System.EventHandler(this.frmUpdateRoomType_Load);
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRoomTypes;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}