namespace WinFormsApp8_BorrowAndRepay_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.friendNameLable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.repayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名子";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入朋友的名子";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(265, 33);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(222, 23);
            this.myNameInput.TabIndex = 2;
            // 
            // friendNameInput
            // 
            this.friendNameInput.Location = new System.Drawing.Point(265, 82);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(222, 23);
            this.friendNameInput.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(559, 33);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(155, 69);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "確認";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名子";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的$$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myNameLabel.Location = new System.Drawing.Point(168, 152);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(67, 24);
            this.myNameLabel.TabIndex = 7;
            this.myNameLabel.Text = "無名氏";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myMoneyLabel.Location = new System.Drawing.Point(168, 189);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(21, 24);
            this.myMoneyLabel.TabIndex = 8;
            this.myMoneyLabel.Text = "0";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendMoneyLabel.Location = new System.Drawing.Point(494, 189);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(76, 24);
            this.friendMoneyLabel.TabIndex = 12;
            this.friendMoneyLabel.Text = "200000";
            // 
            // friendNameLable
            // 
            this.friendNameLable.AutoSize = true;
            this.friendNameLable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendNameLable.Location = new System.Drawing.Point(494, 152);
            this.friendNameLable.Name = "friendNameLable";
            this.friendNameLable.Size = new System.Drawing.Size(67, 24);
            this.friendNameLable.TabIndex = 11;
            this.friendNameLable.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(389, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的$$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(389, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名子";
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowButton.Location = new System.Drawing.Point(63, 248);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(651, 69);
            this.borrowButton.TabIndex = 13;
            this.borrowButton.Text = "跟 XXX 借 1000 元";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // repayButton
            // 
            this.repayButton.Enabled = false;
            this.repayButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repayButton.Location = new System.Drawing.Point(62, 323);
            this.repayButton.Name = "repayButton";
            this.repayButton.Size = new System.Drawing.Size(651, 69);
            this.repayButton.TabIndex = 14;
            this.repayButton.Text = "還給 XXX 1000";
            this.repayButton.UseVisualStyleBackColor = true;
            this.repayButton.Click += new System.EventHandler(this.repayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repayButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.friendNameLable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox myNameInput;
        private TextBox friendNameInput;
        private Button submitButton;
        private Label label3;
        private Label label4;
        private Label myNameLabel;
        private Label myMoneyLabel;
        private Label friendMoneyLabel;
        private Label friendNameLable;
        private Label label9;
        private Label label10;
        private Button borrowButton;
        private Button repayButton;
    }
}