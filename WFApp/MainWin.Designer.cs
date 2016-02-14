namespace WFApp
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.startButton = new System.Windows.Forms.Button();
            this.numShow = new System.Windows.Forms.Label();
            this.rangeInput = new System.Windows.Forms.TextBox();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(12, 257);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start);
            // 
            // numShow
            // 
            this.numShow.Font = new System.Drawing.Font("Segoe UI Symbol", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShow.Location = new System.Drawing.Point(17, 52);
            this.numShow.Name = "numShow";
            this.numShow.Size = new System.Drawing.Size(250, 180);
            this.numShow.TabIndex = 1;
            this.numShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rangeInput
            // 
            this.rangeInput.Font = new System.Drawing.Font("Segoe UI Symbol", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeInput.Location = new System.Drawing.Point(245, 7);
            this.rangeInput.Name = "rangeInput";
            this.rangeInput.Size = new System.Drawing.Size(30, 26);
            this.rangeInput.TabIndex = 2;
            this.rangeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rangeInput.TextChanged += new System.EventHandler(this.rangeInput_TextChanged);
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rangeLabel.Location = new System.Drawing.Point(207, 10);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(37, 20);
            this.rangeLabel.TabIndex = 3;
            this.rangeLabel.Text = "人数";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.rangeInput);
            this.Controls.Add(this.numShow);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢乐抽学号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label numShow;
        private System.Windows.Forms.TextBox rangeInput;
        private System.Windows.Forms.Label rangeLabel;
    }
}