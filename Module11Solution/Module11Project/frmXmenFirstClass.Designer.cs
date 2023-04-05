
namespace Module11Project
{
    partial class frmXmenFirstClass
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
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnByte = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOperators = new System.Windows.Forms.GroupBox();
            this.radMod = new System.Windows.Forms.RadioButton();
            this.radDiv = new System.Windows.Forms.RadioButton();
            this.radMulti = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.grpOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLeft
            // 
            this.txtLeft.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeft.Location = new System.Drawing.Point(12, 46);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(375, 32);
            this.txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            this.txtRight.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRight.Location = new System.Drawing.Point(413, 46);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(375, 32);
            this.txtRight.TabIndex = 1;
            // 
            // lblLeft
            // 
            this.lblLeft.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(130, 9);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(139, 34);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Left Operand";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            this.lblRight.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(526, 9);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(146, 34);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "Right Operand";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnByte
            // 
            this.btnByte.BackColor = System.Drawing.Color.MistyRose;
            this.btnByte.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByte.Location = new System.Drawing.Point(12, 95);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(139, 72);
            this.btnByte.TabIndex = 4;
            this.btnByte.Text = "&Byte";
            this.btnByte.UseVisualStyleBackColor = false;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.MistyRose;
            this.btnShort.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShort.Location = new System.Drawing.Point(157, 95);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(139, 72);
            this.btnShort.TabIndex = 5;
            this.btnShort.Text = "&Short";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.MistyRose;
            this.btnInt.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(302, 95);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(139, 72);
            this.btnInt.TabIndex = 6;
            this.btnInt.Text = "&Int";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.MistyRose;
            this.btnLong.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLong.Location = new System.Drawing.Point(447, 95);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(139, 72);
            this.btnLong.TabIndex = 7;
            this.btnLong.Text = "&Long";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(447, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 72);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDecimal.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(302, 173);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(139, 72);
            this.btnDecimal.TabIndex = 10;
            this.btnDecimal.Text = "D&ecimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDouble.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(157, 173);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(139, 72);
            this.btnDouble.TabIndex = 9;
            this.btnDouble.Text = "&Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFloat.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloat.Location = new System.Drawing.Point(12, 173);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(139, 72);
            this.btnFloat.TabIndex = 8;
            this.btnFloat.Text = "&Float";
            this.btnFloat.UseVisualStyleBackColor = false;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(447, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 72);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpOperators
            // 
            this.grpOperators.Controls.Add(this.radMod);
            this.grpOperators.Controls.Add(this.radDiv);
            this.grpOperators.Controls.Add(this.radMulti);
            this.grpOperators.Controls.Add(this.radSub);
            this.grpOperators.Controls.Add(this.radAdd);
            this.grpOperators.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperators.Location = new System.Drawing.Point(593, 95);
            this.grpOperators.Name = "grpOperators";
            this.grpOperators.Size = new System.Drawing.Size(200, 228);
            this.grpOperators.TabIndex = 16;
            this.grpOperators.TabStop = false;
            this.grpOperators.Text = "Operators";
            // 
            // radMod
            // 
            this.radMod.AutoSize = true;
            this.radMod.Location = new System.Drawing.Point(6, 193);
            this.radMod.Name = "radMod";
            this.radMod.Size = new System.Drawing.Size(128, 28);
            this.radMod.TabIndex = 4;
            this.radMod.Text = "Modulus (%)";
            this.radMod.UseVisualStyleBackColor = true;
            // 
            // radDiv
            // 
            this.radDiv.AutoSize = true;
            this.radDiv.Location = new System.Drawing.Point(6, 151);
            this.radDiv.Name = "radDiv";
            this.radDiv.Size = new System.Drawing.Size(110, 28);
            this.radDiv.TabIndex = 3;
            this.radDiv.Text = "Divide (/)";
            this.radDiv.UseVisualStyleBackColor = true;
            // 
            // radMulti
            // 
            this.radMulti.AutoSize = true;
            this.radMulti.Location = new System.Drawing.Point(6, 109);
            this.radMulti.Name = "radMulti";
            this.radMulti.Size = new System.Drawing.Size(124, 28);
            this.radMulti.TabIndex = 2;
            this.radMulti.Text = "Multiply (*)";
            this.radMulti.UseVisualStyleBackColor = true;
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Location = new System.Drawing.Point(6, 67);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(128, 28);
            this.radSub.TabIndex = 1;
            this.radSub.Text = "Subtract (-)";
            this.radSub.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(6, 25);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(91, 28);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add (+)";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Thistle;
            this.btnCalc.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(12, 251);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(429, 72);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Compute";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblResults.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 336);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(776, 202);
            this.lblResults.TabIndex = 17;
            this.lblResults.Text = "Click a Button.";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(275, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(245, 34);
            this.lblMode.TabIndex = 18;
            this.lblMode.Text = "Current Mode: NULL";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmXmenFirstClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpOperators);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnByte);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Name = "frmXmenFirstClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Commence";
            this.grpOperators.ResumeLayout(false);
            this.grpOperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOperators;
        private System.Windows.Forms.RadioButton radMod;
        private System.Windows.Forms.RadioButton radDiv;
        private System.Windows.Forms.RadioButton radMulti;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblMode;
    }
}

