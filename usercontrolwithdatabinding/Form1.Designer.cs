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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameControl2 = new usercontrolwithdatabinding.UserControls.NameControl();
            this.nameControl1 = new usercontrolwithdatabinding.UserControls.NameControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addressControl1 = new usercontrolwithdatabinding.UserControls.AddressControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addressControl2 = new usercontrolwithdatabinding.UserControls.AddressControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addressControl3 = new usercontrolwithdatabinding.UserControls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModel.Size = new System.Drawing.Size(361, 128);
            this.txtModel.TabIndex = 1;
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
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(usercontrolwithdatabinding.Model.Customer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LastName";
            // 
            // nameControl2
            // 
            this.nameControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameControl2.Location = new System.Drawing.Point(76, 69);
            this.nameControl2.Name = "nameControl2";
            this.nameControl2.Size = new System.Drawing.Size(248, 30);
            this.nameControl2.TabIndex = 7;
            // 
            // nameControl1
            // 
            this.nameControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameControl1.Location = new System.Drawing.Point(76, 32);
            this.nameControl1.Name = "nameControl1";
            this.nameControl1.Size = new System.Drawing.Size(248, 30);
            this.nameControl1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 100);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addressControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DefaultAddress";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addressControl1
            // 
            this.addressControl1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bsCustomer, "DefaultAddress", true));
            this.addressControl1.DataSource = null;
            this.addressControl1.Location = new System.Drawing.Point(48, 7);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(296, 146);
            this.addressControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addressControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "InvoiceAddress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addressControl2
            // 
            this.addressControl2.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bsCustomer, "InvoiceAddress", true));
            this.addressControl2.DataSource = null;
            this.addressControl2.Location = new System.Drawing.Point(48, 7);
            this.addressControl2.Name = "addressControl2";
            this.addressControl2.Size = new System.Drawing.Size(296, 146);
            this.addressControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addressControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(451, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "deliveryAddress";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addressControl3
            // 
            this.addressControl3.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bsCustomer, "DeliveryAddress", true));
            this.addressControl3.DataSource = null;
            this.addressControl3.Location = new System.Drawing.Point(29, 6);
            this.addressControl3.Name = "addressControl3";
            this.addressControl3.Size = new System.Drawing.Size(296, 146);
            this.addressControl3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nameControl2);
            this.Controls.Add(this.nameControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControls.NameControl nameControl1;
        private UserControls.NameControl nameControl2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.AddressControl addressControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.AddressControl addressControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private UserControls.AddressControl addressControl3;
    }
}

