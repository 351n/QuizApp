
namespace QuizApp
{
    partial class Creator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MenuButton = new System.Windows.Forms.Button();
            this.QuestionInput = new System.Windows.Forms.TextBox();
            this.AnswersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(713, 13);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // QuestionInput
            // 
            this.QuestionInput.Location = new System.Drawing.Point(12, 133);
            this.QuestionInput.Name = "QuestionInput";
            this.QuestionInput.Size = new System.Drawing.Size(776, 20);
            this.QuestionInput.TabIndex = 1;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.Location = new System.Drawing.Point(12, 230);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(410, 208);
            this.AnswersPanel.TabIndex = 4;
            // 
            // AddAnswerButton
            // 
            this.AddAnswerButton.Location = new System.Drawing.Point(12, 201);
            this.AddAnswerButton.Name = "AddAnswerButton";
            this.AddAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.AddAnswerButton.TabIndex = 5;
            this.AddAnswerButton.Text = "Add Answer";
            this.AddAnswerButton.UseVisualStyleBackColor = true;
            this.AddAnswerButton.Click += new System.EventHandler(this.AddAnswerButton_Click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAnswerButton);
            this.Controls.Add(this.AnswersPanel);
            this.Controls.Add(this.QuestionInput);
            this.Controls.Add(this.MenuButton);
            this.Name = "Creator";
            this.Text = "Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Creator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.TextBox QuestionInput;
        private System.Windows.Forms.FlowLayoutPanel AnswersPanel;
        private System.Windows.Forms.Button AddAnswerButton;
    }
}