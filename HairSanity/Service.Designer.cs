﻿namespace HairSanity
{
    /// <summary>
    /// 
    /// </summary>
    partial class Service
    {
        /// <summary>
        /// Accessor functions
        /// </summary>
        //public string name { get; set; }
        public string Desc { get; set; }
        public string Price { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void SomeMethod(){}
        /// <summary>
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Service";
        }

        #endregion
    }
}