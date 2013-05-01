namespace usercontrolwithdatabinding
{
    partial class Form1
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(381, 216);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(92, 38);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Show model in JSON";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(11, 218);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(361, 128);
            this.txtModel.TabIndex = 1;
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(usercontrolwithdatabinding.Model.Customer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitle.Location = new System.Drawing.Point(66, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(191, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 351);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
    }
}

