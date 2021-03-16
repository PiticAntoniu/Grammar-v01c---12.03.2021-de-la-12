namespace Grammar_v01c
{
    partial class GrammarEditorForm
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
            this.startSymbolTextBox = new System.Windows.Forms.TextBox();
            this.terminalsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nonterminalsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productionsDataGridView = new System.Windows.Forms.DataGridView();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simbol de start";
            // 
            // startSymbolTextBox
            // 
            this.startSymbolTextBox.Location = new System.Drawing.Point(192, 50);
            this.startSymbolTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startSymbolTextBox.Name = "startSymbolTextBox";
            this.startSymbolTextBox.Size = new System.Drawing.Size(196, 31);
            this.startSymbolTextBox.TabIndex = 1;
            // 
            // terminalsTextBox
            // 
            this.terminalsTextBox.Location = new System.Drawing.Point(190, 113);
            this.terminalsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.terminalsTextBox.Name = "terminalsTextBox";
            this.terminalsTextBox.Size = new System.Drawing.Size(196, 31);
            this.terminalsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terminale";
            // 
            // nonterminalsTextBox
            // 
            this.nonterminalsTextBox.Location = new System.Drawing.Point(190, 183);
            this.nonterminalsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nonterminalsTextBox.Name = "nonterminalsTextBox";
            this.nonterminalsTextBox.Size = new System.Drawing.Size(196, 31);
            this.nonterminalsTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Neterminale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Productii";
            // 
            // productionsDataGridView
            // 
            this.productionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionsDataGridView.Location = new System.Drawing.Point(190, 258);
            this.productionsDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productionsDataGridView.Name = "productionsDataGridView";
            this.productionsDataGridView.RowHeadersWidth = 82;
            this.productionsDataGridView.Size = new System.Drawing.Size(480, 288);
            this.productionsDataGridView.TabIndex = 7;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(170, 573);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(150, 44);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(398, 573);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GrammarEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(818, 679);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.productionsDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nonterminalsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.terminalsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startSymbolTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GrammarEditorForm";
            this.Text = "GrammarEditorForm";
            this.Load += new System.EventHandler(this.GrammarEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startSymbolTextBox;
        private System.Windows.Forms.TextBox terminalsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nonterminalsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView productionsDataGridView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
    }
}