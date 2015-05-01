namespace BrainTrainingApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.handPictureBox = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.QNumLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.winOrLoseLabel = new System.Windows.Forms.Label();
            this.handStateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.handPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // handPictureBox
            // 
            this.handPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("handPictureBox.Image")));
            this.handPictureBox.Location = new System.Drawing.Point(257, 194);
            this.handPictureBox.Name = "handPictureBox";
            this.handPictureBox.Size = new System.Drawing.Size(440, 426);
            this.handPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handPictureBox.TabIndex = 0;
            this.handPictureBox.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(162, 786);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(221, 106);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(438, 693);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(399, 221);
            this.SecondsLabel.TabIndex = 2;
            this.SecondsLabel.Text = "38.6";
            // 
            // QNumLabel
            // 
            this.QNumLabel.AutoSize = true;
            this.QNumLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QNumLabel.Location = new System.Drawing.Point(13, 13);
            this.QNumLabel.Name = "QNumLabel";
            this.QNumLabel.Size = new System.Drawing.Size(133, 159);
            this.QNumLabel.TabIndex = 3;
            this.QNumLabel.Text = "1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(433, 891);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(895, 918);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // winOrLoseLabel
            // 
            this.winOrLoseLabel.AutoSize = true;
            this.winOrLoseLabel.Font = new System.Drawing.Font("メイリオ", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winOrLoseLabel.Location = new System.Drawing.Point(721, 14);
            this.winOrLoseLabel.Name = "winOrLoseLabel";
            this.winOrLoseLabel.Size = new System.Drawing.Size(195, 180);
            this.winOrLoseLabel.TabIndex = 6;
            this.winOrLoseLabel.Text = "勝";
            // 
            // handStateTimer
            // 
            //this.handStateTimer.Tick += new System.EventHandler(this.handStateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.winOrLoseLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.QNumLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.handPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.handPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox handPictureBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label QNumLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label winOrLoseLabel;
        private System.Windows.Forms.Timer handStateTimer;
    }
}

