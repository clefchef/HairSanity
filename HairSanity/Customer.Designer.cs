namespace HairSanity
{
    /// <summary>
    /// 
    /// </summary>
    partial class Customer
    {
        /// <summary>
        /// Accessor functions
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string DOB { get; set; }
        public string CustomerTalkingPoints { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void SomeMethod(){}
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
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

