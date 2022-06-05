
namespace QuizApp
{
    partial class TextAnswerInput
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.AnswerCorrectCheckbox = new System.Windows.Forms.CheckBox();
            this.AnswerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AnswerCorrectCheckbox
            // 
            this.AnswerCorrectCheckbox.AutoSize = true;
            this.AnswerCorrectCheckbox.Location = new System.Drawing.Point(3, 6);
            this.AnswerCorrectCheckbox.Name = "AnswerCorrectCheckbox";
            this.AnswerCorrectCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AnswerCorrectCheckbox.TabIndex = 0;
            this.AnswerCorrectCheckbox.UseVisualStyleBackColor = true;
            // 
            // AnswerInput
            // 
            this.AnswerInput.Location = new System.Drawing.Point(24, 3);
            this.AnswerInput.Name = "AnswerInput";
            this.AnswerInput.Size = new System.Drawing.Size(361, 20);
            this.AnswerInput.TabIndex = 1;
            // 
            // TextAnswerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnswerInput);
            this.Controls.Add(this.AnswerCorrectCheckbox);
            this.Name = "TextAnswerInput";
            this.Size = new System.Drawing.Size(390, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AnswerCorrectCheckbox;
        private System.Windows.Forms.TextBox AnswerInput;
    }
}
