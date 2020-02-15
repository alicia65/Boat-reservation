namespace Boat_reservation
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
            this.btnReservation = new System.Windows.Forms.Button();
            this.cbxboat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalOfRenters = new System.Windows.Forms.TextBox();
            this.txtNumberOfAdult = new System.Windows.Forms.Label();
            this.txtNumberOfChildren = new System.Windows.Forms.Label();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReservation
            // 
            this.btnReservation.Enabled = false;
            this.btnReservation.Location = new System.Drawing.Point(25, 167);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(131, 36);
            this.btnReservation.TabIndex = 0;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // cbxboat
            // 
            this.cbxboat.FormattingEnabled = true;
            this.cbxboat.Location = new System.Drawing.Point(215, 10);
            this.cbxboat.Name = "cbxboat";
            this.cbxboat.Size = new System.Drawing.Size(121, 26);
            this.cbxboat.TabIndex = 1;
            this.cbxboat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renting a  boat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total of Renters";
            // 
            // txtTotalOfRenters
            // 
            this.txtTotalOfRenters.Location = new System.Drawing.Point(215, 139);
            this.txtTotalOfRenters.Name = "txtTotalOfRenters";
            this.txtTotalOfRenters.Size = new System.Drawing.Size(121, 24);
            this.txtTotalOfRenters.TabIndex = 4;
            // 
            // txtNumberOfAdult
            // 
            this.txtNumberOfAdult.AutoSize = true;
            this.txtNumberOfAdult.Location = new System.Drawing.Point(22, 58);
            this.txtNumberOfAdult.Name = "txtNumberOfAdult";
            this.txtNumberOfAdult.Size = new System.Drawing.Size(137, 18);
            this.txtNumberOfAdult.TabIndex = 5;
            this.txtNumberOfAdult.Text = "Number of adults";
            // 
            // txtNumberOfChildren
            // 
            this.txtNumberOfChildren.AutoSize = true;
            this.txtNumberOfChildren.Location = new System.Drawing.Point(22, 107);
            this.txtNumberOfChildren.Name = "txtNumberOfChildren";
            this.txtNumberOfChildren.Size = new System.Drawing.Size(151, 18);
            this.txtNumberOfChildren.TabIndex = 6;
            this.txtNumberOfChildren.Text = "Number of children";
            // 
            // txtAdults
            // 
            this.txtAdults.Location = new System.Drawing.Point(215, 58);
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.Size = new System.Drawing.Size(121, 24);
            this.txtAdults.TabIndex = 7;
            // 
            // txtChildren
            // 
            this.txtChildren.Location = new System.Drawing.Point(215, 104);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(121, 24);
            this.txtChildren.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 226);
            this.Controls.Add(this.txtChildren);
            this.Controls.Add(this.txtAdults);
            this.Controls.Add(this.txtNumberOfChildren);
            this.Controls.Add(this.txtNumberOfAdult);
            this.Controls.Add(this.txtTotalOfRenters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxboat);
            this.Controls.Add(this.btnReservation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Boat reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.ComboBox cbxboat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalOfRenters;
        private System.Windows.Forms.Label txtNumberOfAdult;
        private System.Windows.Forms.Label txtNumberOfChildren;
        private System.Windows.Forms.TextBox txtAdults;
        private System.Windows.Forms.TextBox txtChildren;
    }
}

