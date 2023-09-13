namespace Project_TO_DO_LISTS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.MonthCalendar();
            this.cbcatigory = new System.Windows.Forms.ComboBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.cbdificulty = new System.Windows.Forms.ComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(311, 470);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(96, 470);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 23);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 30);
            this.textBox1.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(111, 212);
            this.dtp.Name = "dtp";
            this.dtp.TabIndex = 7;
            // 
            // cbcatigory
            // 
            this.cbcatigory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcatigory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcatigory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcatigory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbcatigory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcatigory.FormattingEnabled = true;
            this.cbcatigory.Items.AddRange(new object[] {
            "fun",
            "play",
            "study",
            "work"});
            this.cbcatigory.Location = new System.Drawing.Point(146, 107);
            this.cbcatigory.Name = "cbcatigory";
            this.cbcatigory.Size = new System.Drawing.Size(190, 33);
            this.cbcatigory.Sorted = true;
            this.cbcatigory.TabIndex = 9;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // cbdificulty
            // 
            this.cbdificulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdificulty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbdificulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdificulty.FormattingEnabled = true;
            this.cbdificulty.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.cbdificulty.Location = new System.Drawing.Point(146, 167);
            this.cbdificulty.Name = "cbdificulty";
            this.cbdificulty.Size = new System.Drawing.Size(190, 33);
            this.cbdificulty.TabIndex = 21;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "easy.png");
            this.imageList2.Images.SetKeyName(1, "hard.png");
            this.imageList2.Images.SetKeyName(2, "medium.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 512);
            this.Controls.Add(this.cbdificulty);
            this.Controls.Add(this.cbcatigory);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar dtp;
        private System.Windows.Forms.ComboBox cbcatigory;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.ComboBox cbdificulty;
        private System.Windows.Forms.ImageList imageList2;
    }
}