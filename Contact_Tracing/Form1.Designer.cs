namespace Contact_Tracing
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
            this.label1 = new System.Windows.Forms.Label();
            this.fill_form = new System.Windows.Forms.Button();
            this.review_form = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bar_time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing Form";
            // 
            // fill_form
            // 
            this.fill_form.BackColor = System.Drawing.Color.Silver;
            this.fill_form.FlatAppearance.BorderSize = 5;
            this.fill_form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fill_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fill_form.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill_form.Location = new System.Drawing.Point(36, 82);
            this.fill_form.Name = "fill_form";
            this.fill_form.Size = new System.Drawing.Size(157, 42);
            this.fill_form.TabIndex = 1;
            this.fill_form.Text = "Fill-Up Form";
            this.fill_form.UseVisualStyleBackColor = false;
            this.fill_form.Click += new System.EventHandler(this.fill_form_Click);
            // 
            // review_form
            // 
            this.review_form.BackColor = System.Drawing.Color.Silver;
            this.review_form.FlatAppearance.BorderSize = 5;
            this.review_form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.review_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.review_form.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_form.Location = new System.Drawing.Point(225, 82);
            this.review_form.Name = "review_form";
            this.review_form.Size = new System.Drawing.Size(157, 42);
            this.review_form.TabIndex = 2;
            this.review_form.Text = "Review Data";
            this.review_form.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(346, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // bar_time
            // 
            this.bar_time.Tick += new System.EventHandler(this.bar_time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 197);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.review_form);
            this.Controls.Add(this.fill_form);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fill_form;
        private System.Windows.Forms.Button review_form;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer bar_time;
    }
}

