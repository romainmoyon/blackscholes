namespace BlackSchole
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCalculate = new System.Windows.Forms.Label();
            this.radioButtonCall = new System.Windows.Forms.RadioButton();
            this.radioButtonPut = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.labelRisk = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelVolatility = new System.Windows.Forms.Label();
            this.labelStrikePrice = new System.Windows.Forms.Label();
            this.labelStockPrice = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxStockPrice = new System.Windows.Forms.TextBox();
            this.textBoxRisk = new System.Windows.Forms.TextBox();
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxStrikePrice = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.groupBoxRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCalculate
            // 
            this.labelCalculate.AutoSize = true;
            this.labelCalculate.Location = new System.Drawing.Point(1, 18);
            this.labelCalculate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculate.Name = "labelCalculate";
            this.labelCalculate.Size = new System.Drawing.Size(77, 18);
            this.labelCalculate.TabIndex = 0;
            this.labelCalculate.Text = "Calculate :";
            // 
            // radioButtonCall
            // 
            this.radioButtonCall.AutoSize = true;
            this.radioButtonCall.Checked = true;
            this.radioButtonCall.Location = new System.Drawing.Point(85, 16);
            this.radioButtonCall.Name = "radioButtonCall";
            this.radioButtonCall.Size = new System.Drawing.Size(51, 22);
            this.radioButtonCall.TabIndex = 1;
            this.radioButtonCall.TabStop = true;
            this.radioButtonCall.Tag = "call";
            this.radioButtonCall.Text = "Call";
            this.radioButtonCall.UseVisualStyleBackColor = true;
            // 
            // radioButtonPut
            // 
            this.radioButtonPut.AutoSize = true;
            this.radioButtonPut.Location = new System.Drawing.Point(142, 18);
            this.radioButtonPut.Name = "radioButtonPut";
            this.radioButtonPut.Size = new System.Drawing.Size(48, 22);
            this.radioButtonPut.TabIndex = 2;
            this.radioButtonPut.Tag = "put";
            this.radioButtonPut.Text = "Put";
            this.radioButtonPut.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(196, 18);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(41, 22);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.Tag = "all";
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // labelRisk
            // 
            this.labelRisk.AutoSize = true;
            this.labelRisk.Location = new System.Drawing.Point(13, 200);
            this.labelRisk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRisk.Name = "labelRisk";
            this.labelRisk.Size = new System.Drawing.Size(148, 18);
            this.labelRisk.TabIndex = 21;
            this.labelRisk.Text = "Risk free interest rate";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(13, 142);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(114, 18);
            this.labelTime.TabIndex = 20;
            this.labelTime.Text = "Time to maturity";
            // 
            // labelVolatility
            // 
            this.labelVolatility.AutoSize = true;
            this.labelVolatility.Location = new System.Drawing.Point(13, 171);
            this.labelVolatility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolatility.Name = "labelVolatility";
            this.labelVolatility.Size = new System.Drawing.Size(61, 18);
            this.labelVolatility.TabIndex = 19;
            this.labelVolatility.Text = "Volatility";
            // 
            // labelStrikePrice
            // 
            this.labelStrikePrice.AutoSize = true;
            this.labelStrikePrice.Location = new System.Drawing.Point(13, 108);
            this.labelStrikePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrikePrice.Name = "labelStrikePrice";
            this.labelStrikePrice.Size = new System.Drawing.Size(82, 18);
            this.labelStrikePrice.TabIndex = 18;
            this.labelStrikePrice.Text = "Strike price";
            // 
            // labelStockPrice
            // 
            this.labelStockPrice.AutoSize = true;
            this.labelStockPrice.Location = new System.Drawing.Point(13, 74);
            this.labelStockPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockPrice.Name = "labelStockPrice";
            this.labelStockPrice.Size = new System.Drawing.Size(83, 18);
            this.labelStockPrice.TabIndex = 17;
            this.labelStockPrice.Text = "Stock price";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(108, 243);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 39);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxStockPrice
            // 
            this.textBoxStockPrice.Location = new System.Drawing.Point(197, 71);
            this.textBoxStockPrice.Name = "textBoxStockPrice";
            this.textBoxStockPrice.Size = new System.Drawing.Size(100, 24);
            this.textBoxStockPrice.TabIndex = 11;
            // 
            // textBoxRisk
            // 
            this.textBoxRisk.Location = new System.Drawing.Point(197, 200);
            this.textBoxRisk.Name = "textBoxRisk";
            this.textBoxRisk.Size = new System.Drawing.Size(100, 24);
            this.textBoxRisk.TabIndex = 15;
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Location = new System.Drawing.Point(197, 170);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(100, 24);
            this.textBoxVolatility.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(197, 139);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 24);
            this.textBoxTime.TabIndex = 13;
            // 
            // textBoxStrikePrice
            // 
            this.textBoxStrikePrice.Location = new System.Drawing.Point(197, 105);
            this.textBoxStrikePrice.Name = "textBoxStrikePrice";
            this.textBoxStrikePrice.Size = new System.Drawing.Size(100, 24);
            this.textBoxStrikePrice.TabIndex = 12;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 294);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 18);
            this.labelResult.TabIndex = 2;
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.labelCalculate);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonCall);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonPut);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonAll);
            this.groupBoxRadioButton.Location = new System.Drawing.Point(16, 12);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Size = new System.Drawing.Size(243, 46);
            this.groupBoxRadioButton.TabIndex = 1;
            this.groupBoxRadioButton.TabStop = false;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "year",
            "month",
            "day"});
            this.comboBoxUnit.Location = new System.Drawing.Point(301, 139);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(99, 26);
            this.comboBoxUnit.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 423);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.groupBoxRadioButton);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxStrikePrice);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxVolatility);
            this.Controls.Add(this.textBoxRisk);
            this.Controls.Add(this.textBoxStockPrice);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelStockPrice);
            this.Controls.Add(this.labelStrikePrice);
            this.Controls.Add(this.labelVolatility);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelRisk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Black schole calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalculate;
        private System.Windows.Forms.RadioButton radioButtonCall;
        private System.Windows.Forms.RadioButton radioButtonPut;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label labelRisk;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelVolatility;
        private System.Windows.Forms.Label labelStrikePrice;
        private System.Windows.Forms.Label labelStockPrice;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxStockPrice;
        private System.Windows.Forms.TextBox textBoxRisk;
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxStrikePrice;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxRadioButton;
        private System.Windows.Forms.ComboBox comboBoxUnit;
    }
}

