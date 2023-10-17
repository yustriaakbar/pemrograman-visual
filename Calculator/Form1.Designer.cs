namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDisplay = new TextBox();
            btnBracket = new Button();
            btnMod = new Button();
            btnDiv = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnHistory = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnResult = new Button();
            btnClr = new Button();
            btn7 = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.Location = new Point(12, 12);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(288, 135);
            textDisplay.TabIndex = 0;
            textDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnBracket
            // 
            btnBracket.Location = new Point(90, 166);
            btnBracket.Name = "btnBracket";
            btnBracket.Size = new Size(60, 46);
            btnBracket.TabIndex = 2;
            btnBracket.Text = "()";
            btnBracket.UseVisualStyleBackColor = true;
            btnBracket.Click += btn00_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(165, 166);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(60, 46);
            btnMod.TabIndex = 3;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(240, 166);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(60, 46);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 291);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 46);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 355);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 46);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(12, 417);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(60, 46);
            btnHistory.TabIndex = 8;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += button8_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(90, 229);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 46);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(90, 291);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 46);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(90, 355);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 46);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(90, 417);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 46);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(165, 229);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 46);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(165, 291);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 46);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(165, 355);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 46);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(165, 417);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 46);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(241, 229);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(60, 46);
            btnMul.TabIndex = 17;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += button17_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(241, 291);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(60, 46);
            btnSub.TabIndex = 18;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(240, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 46);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(241, 417);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(60, 46);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(12, 166);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(60, 46);
            btnClr.TabIndex = 21;
            btnClr.Text = "C";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += button1_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 229);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 46);
            btn7.TabIndex = 22;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 471);
            Controls.Add(btn7);
            Controls.Add(btnClr);
            Controls.Add(btnResult);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnHistory);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnDiv);
            Controls.Add(btnMod);
            Controls.Add(btnBracket);
            Controls.Add(textDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button btnBracket;
        private Button btnMod;
        private Button btnDiv;
        private Button btn4;
        private Button btn1;
        private Button btnHistory;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn0;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnDot;
        private Button btnMul;
        private Button btnSub;
        private Button btnAdd;
        private Button btnResult;
        private Button btnClr;
        private Button btn7;
    }
}