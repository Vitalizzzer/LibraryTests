
namespace TaxCalculator
{
    partial class MainForm
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
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtEsv = new System.Windows.Forms.TextBox();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.txtTransCommission = new System.Windows.Forms.TextBox();
            this.txtOtherCommissions = new System.Windows.Forms.TextBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblEsv = new System.Windows.Forms.Label();
            this.lblEp = new System.Windows.Forms.Label();
            this.lblTransCommission = new System.Windows.Forms.Label();
            this.lblOtherCommission = new System.Windows.Forms.Label();
            this.lblTotalTaxes = new System.Windows.Forms.Label();
            this.lblTotalTaxesResult = new System.Windows.Forms.Label();
            this.lblTransCommissionDisplay = new System.Windows.Forms.Label();
            this.lblTransCommissionResult = new System.Windows.Forms.Label();
            this.lblAllCommissions = new System.Windows.Forms.Label();
            this.lblAllCommissionsResult = new System.Windows.Forms.Label();
            this.lblClearIncome = new System.Windows.Forms.Label();
            this.lblCleanIncomeResult = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.groupBoxTaxes = new System.Windows.Forms.GroupBox();
            this.groupBoxCommissions = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxTaxes.SuspendLayout();
            this.groupBoxCommissions.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(244, 26);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(242, 22);
            this.txtIncome.TabIndex = 0;
            // 
            // txtEsv
            // 
            this.txtEsv.Location = new System.Drawing.Point(227, 37);
            this.txtEsv.Name = "txtEsv";
            this.txtEsv.Size = new System.Drawing.Size(242, 22);
            this.txtEsv.TabIndex = 1;
            // 
            // txtEp
            // 
            this.txtEp.Location = new System.Drawing.Point(227, 83);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(242, 22);
            this.txtEp.TabIndex = 2;
            // 
            // txtTransCommission
            // 
            this.txtTransCommission.Location = new System.Drawing.Point(224, 29);
            this.txtTransCommission.Name = "txtTransCommission";
            this.txtTransCommission.Size = new System.Drawing.Size(242, 22);
            this.txtTransCommission.TabIndex = 3;
            // 
            // txtOtherCommissions
            // 
            this.txtOtherCommissions.Location = new System.Drawing.Point(224, 74);
            this.txtOtherCommissions.Name = "txtOtherCommissions";
            this.txtOtherCommissions.Size = new System.Drawing.Size(242, 22);
            this.txtOtherCommissions.TabIndex = 4;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblIncome.Location = new System.Drawing.Point(29, 25);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(123, 17);
            this.lblIncome.TabIndex = 5;
            this.lblIncome.Text = "Прибуток, грн.:";
            // 
            // lblEsv
            // 
            this.lblEsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEsv.Location = new System.Drawing.Point(14, 25);
            this.lblEsv.Name = "lblEsv";
            this.lblEsv.Size = new System.Drawing.Size(194, 39);
            this.lblEsv.TabIndex = 6;
            this.lblEsv.Text = "Єдиний Соціальний Внесок (ЄСВ), грн.:";
            // 
            // lblEp
            // 
            this.lblEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEp.Location = new System.Drawing.Point(14, 86);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(194, 23);
            this.lblEp.TabIndex = 7;
            this.lblEp.Text = "Єдиний Податок (ЄП), %:";
            // 
            // lblTransCommission
            // 
            this.lblTransCommission.AutoSize = true;
            this.lblTransCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransCommission.Location = new System.Drawing.Point(14, 29);
            this.lblTransCommission.Name = "lblTransCommission";
            this.lblTransCommission.Size = new System.Drawing.Size(178, 17);
            this.lblTransCommission.TabIndex = 8;
            this.lblTransCommission.Text = "Комісія за переказ, %:";
            // 
            // lblOtherCommission
            // 
            this.lblOtherCommission.AutoSize = true;
            this.lblOtherCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtherCommission.Location = new System.Drawing.Point(14, 74);
            this.lblOtherCommission.Name = "lblOtherCommission";
            this.lblOtherCommission.Size = new System.Drawing.Size(133, 17);
            this.lblOtherCommission.TabIndex = 9;
            this.lblOtherCommission.Text = "Інші комісії, грн.:";
            // 
            // lblTotalTaxes
            // 
            this.lblTotalTaxes.AutoSize = true;
            this.lblTotalTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalTaxes.Location = new System.Drawing.Point(13, 28);
            this.lblTotalTaxes.Name = "lblTotalTaxes";
            this.lblTotalTaxes.Size = new System.Drawing.Size(226, 17);
            this.lblTotalTaxes.TabIndex = 10;
            this.lblTotalTaxes.Text = "Загальна сума податку, грн.:";
            // 
            // lblTotalTaxesResult
            // 
            this.lblTotalTaxesResult.Location = new System.Drawing.Point(245, 28);
            this.lblTotalTaxesResult.Name = "lblTotalTaxesResult";
            this.lblTotalTaxesResult.Size = new System.Drawing.Size(219, 17);
            this.lblTotalTaxesResult.TabIndex = 11;
            this.lblTotalTaxesResult.Text = "0";
            // 
            // lblTransCommissionDisplay
            // 
            this.lblTransCommissionDisplay.AutoSize = true;
            this.lblTransCommissionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransCommissionDisplay.Location = new System.Drawing.Point(13, 60);
            this.lblTransCommissionDisplay.Name = "lblTransCommissionDisplay";
            this.lblTransCommissionDisplay.Size = new System.Drawing.Size(194, 17);
            this.lblTransCommissionDisplay.TabIndex = 12;
            this.lblTransCommissionDisplay.Text = "Комісія за переказ, грн.:";
            // 
            // lblTransCommissionResult
            // 
            this.lblTransCommissionResult.Location = new System.Drawing.Point(245, 60);
            this.lblTransCommissionResult.Name = "lblTransCommissionResult";
            this.lblTransCommissionResult.Size = new System.Drawing.Size(216, 17);
            this.lblTransCommissionResult.TabIndex = 13;
            this.lblTransCommissionResult.Text = "0";
            // 
            // lblAllCommissions
            // 
            this.lblAllCommissions.AutoSize = true;
            this.lblAllCommissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllCommissions.Location = new System.Drawing.Point(13, 94);
            this.lblAllCommissions.Name = "lblAllCommissions";
            this.lblAllCommissions.Size = new System.Drawing.Size(174, 17);
            this.lblAllCommissions.TabIndex = 14;
            this.lblAllCommissions.Text = "Всі комісії банку, грн.:";
            // 
            // lblAllCommissionsResult
            // 
            this.lblAllCommissionsResult.Location = new System.Drawing.Point(245, 94);
            this.lblAllCommissionsResult.Name = "lblAllCommissionsResult";
            this.lblAllCommissionsResult.Size = new System.Drawing.Size(217, 17);
            this.lblAllCommissionsResult.TabIndex = 15;
            this.lblAllCommissionsResult.Text = "0";
            // 
            // lblClearIncome
            // 
            this.lblClearIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClearIncome.Location = new System.Drawing.Point(13, 124);
            this.lblClearIncome.Name = "lblClearIncome";
            this.lblClearIncome.Size = new System.Drawing.Size(198, 38);
            this.lblClearIncome.TabIndex = 16;
            this.lblClearIncome.Text = "Чистий дохід (без податків і комісій), грн.:";
            // 
            // lblCleanIncomeResult
            // 
            this.lblCleanIncomeResult.Location = new System.Drawing.Point(245, 138);
            this.lblCleanIncomeResult.Name = "lblCleanIncomeResult";
            this.lblCleanIncomeResult.Size = new System.Drawing.Size(216, 17);
            this.lblCleanIncomeResult.TabIndex = 17;
            this.lblCleanIncomeResult.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.Location = new System.Drawing.Point(17, 532);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(482, 36);
            this.btnResult.TabIndex = 18;
            this.btnResult.Text = "Розрахувати";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // groupBoxTaxes
            // 
            this.groupBoxTaxes.Controls.Add(this.lblEp);
            this.groupBoxTaxes.Controls.Add(this.lblEsv);
            this.groupBoxTaxes.Controls.Add(this.txtEp);
            this.groupBoxTaxes.Controls.Add(this.txtEsv);
            this.groupBoxTaxes.Location = new System.Drawing.Point(17, 58);
            this.groupBoxTaxes.Name = "groupBoxTaxes";
            this.groupBoxTaxes.Size = new System.Drawing.Size(482, 127);
            this.groupBoxTaxes.TabIndex = 19;
            this.groupBoxTaxes.TabStop = false;
            this.groupBoxTaxes.Text = "Податки";
            // 
            // groupBoxCommissions
            // 
            this.groupBoxCommissions.Controls.Add(this.lblOtherCommission);
            this.groupBoxCommissions.Controls.Add(this.lblTransCommission);
            this.groupBoxCommissions.Controls.Add(this.txtOtherCommissions);
            this.groupBoxCommissions.Controls.Add(this.txtTransCommission);
            this.groupBoxCommissions.Location = new System.Drawing.Point(17, 204);
            this.groupBoxCommissions.Name = "groupBoxCommissions";
            this.groupBoxCommissions.Size = new System.Drawing.Size(482, 115);
            this.groupBoxCommissions.TabIndex = 20;
            this.groupBoxCommissions.TabStop = false;
            this.groupBoxCommissions.Text = "Комісії банку";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.lblCleanIncomeResult);
            this.groupBoxResult.Controls.Add(this.lblClearIncome);
            this.groupBoxResult.Controls.Add(this.lblAllCommissionsResult);
            this.groupBoxResult.Controls.Add(this.lblAllCommissions);
            this.groupBoxResult.Controls.Add(this.lblTransCommissionResult);
            this.groupBoxResult.Controls.Add(this.lblTransCommissionDisplay);
            this.groupBoxResult.Controls.Add(this.lblTotalTaxesResult);
            this.groupBoxResult.Controls.Add(this.lblTotalTaxes);
            this.groupBoxResult.Location = new System.Drawing.Point(17, 336);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(482, 181);
            this.groupBoxResult.TabIndex = 21;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Розрахунок";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 585);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxCommissions);
            this.Controls.Add(this.groupBoxTaxes);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.txtIncome);
            this.Name = "MainForm";
            this.Text = "Податковий міні калькулятор";
            this.groupBoxTaxes.ResumeLayout(false);
            this.groupBoxTaxes.PerformLayout();
            this.groupBoxCommissions.ResumeLayout(false);
            this.groupBoxCommissions.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtEsv;
        private System.Windows.Forms.TextBox txtEp;
        private System.Windows.Forms.TextBox txtTransCommission;
        private System.Windows.Forms.TextBox txtOtherCommissions;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblEsv;
        private System.Windows.Forms.Label lblEp;
        private System.Windows.Forms.Label lblTransCommission;
        private System.Windows.Forms.Label lblOtherCommission;
        private System.Windows.Forms.Label lblTotalTaxes;
        private System.Windows.Forms.Label lblTotalTaxesResult;
        private System.Windows.Forms.Label lblTransCommissionDisplay;
        private System.Windows.Forms.Label lblTransCommissionResult;
        private System.Windows.Forms.Label lblAllCommissions;
        private System.Windows.Forms.Label lblAllCommissionsResult;
        private System.Windows.Forms.Label lblClearIncome;
        private System.Windows.Forms.Label lblCleanIncomeResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.GroupBox groupBoxTaxes;
        private System.Windows.Forms.GroupBox groupBoxCommissions;
        private System.Windows.Forms.GroupBox groupBoxResult;
    }
}

