namespace ExampleSeliwareUI
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
            this.components = new System.ComponentModel.Container();
            this.scriptBox = new System.Windows.Forms.RichTextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.injectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.injectedLabel = new System.Windows.Forms.Label();
            this.injectionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scriptBox
            // 
            this.scriptBox.Location = new System.Drawing.Point(12, 12);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(570, 325);
            this.scriptBox.TabIndex = 0;
            this.scriptBox.Text = "";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(12, 343);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(507, 343);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 2;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 343);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // injectedLabel
            // 
            this.injectedLabel.AutoSize = true;
            this.injectedLabel.Location = new System.Drawing.Point(436, 348);
            this.injectedLabel.Name = "injectedLabel";
            this.injectedLabel.Size = new System.Drawing.Size(65, 13);
            this.injectedLabel.TabIndex = 4;
            this.injectedLabel.Text = "Not Injected";
            this.injectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // injectionTimer
            // 
            this.injectionTimer.Enabled = true;
            this.injectionTimer.Tick += new System.EventHandler(this.injectionTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 378);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.injectedLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.scriptBox);
            this.Name = "MainForm";
            this.Text = "Seliware Example UI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox scriptBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label injectedLabel;
        private System.Windows.Forms.Timer injectionTimer;
    }
}

