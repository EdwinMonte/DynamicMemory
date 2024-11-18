namespace DynamicMemory
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
            btnCreateObject = new Button();
            btnClearMemory = new Button();
            lstObjects = new ListBox();
            SuspendLayout();
            // 
            // btnCreateObject
            // 
            btnCreateObject.Location = new Point(54, 61);
            btnCreateObject.Name = "btnCreateObject";
            btnCreateObject.Size = new Size(127, 50);
            btnCreateObject.TabIndex = 0;
            btnCreateObject.Text = "Create";
            btnCreateObject.UseVisualStyleBackColor = true;
            btnCreateObject.Click += btnCreateObject_Click;
            // 
            // btnClearMemory
            // 
            btnClearMemory.Location = new Point(54, 130);
            btnClearMemory.Name = "btnClearMemory";
            btnClearMemory.Size = new Size(127, 52);
            btnClearMemory.TabIndex = 1;
            btnClearMemory.Text = "Clean";
            btnClearMemory.UseVisualStyleBackColor = true;
            // 
            // lstObjects
            // 
            lstObjects.FormattingEnabled = true;
            lstObjects.Location = new Point(202, 12);
            lstObjects.Name = "lstObjects";
            lstObjects.Size = new Size(573, 404);
            lstObjects.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstObjects);
            Controls.Add(btnClearMemory);
            Controls.Add(btnCreateObject);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateObject;
        private Button btnClearMemory;
        private ListBox lstObjects;
    }
}
