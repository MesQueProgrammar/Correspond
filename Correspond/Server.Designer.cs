namespace Correspond
{
    partial class Server
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.buttonOberserve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(66, 36);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(100, 21);
            this.textHost.TabIndex = 0;
            this.textHost.Text = "192.168.1.19";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(187, 36);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(77, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "10001";
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(66, 63);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(453, 155);
            this.textLog.TabIndex = 2;
            // 
            // buttonOberserve
            // 
            this.buttonOberserve.Location = new System.Drawing.Point(427, 34);
            this.buttonOberserve.Name = "buttonOberserve";
            this.buttonOberserve.Size = new System.Drawing.Size(92, 23);
            this.buttonOberserve.TabIndex = 4;
            this.buttonOberserve.Text = "监听";
            this.buttonOberserve.UseVisualStyleBackColor = true;
            this.buttonOberserve.Click += new System.EventHandler(this.buttonOberserve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(733, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOberserve);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button buttonOberserve;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

