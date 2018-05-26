namespace MatinCheckList
{
    partial class Add_task
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
            this.b_add = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.l_topic = new System.Windows.Forms.Label();
            this.l_info = new System.Windows.Forms.Label();
            this.l_ass = new System.Windows.Forms.Label();
            this.l_importance = new System.Windows.Forms.Label();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.tb_ass = new System.Windows.Forms.TextBox();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.cb_imp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(34, 212);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(89, 39);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(129, 212);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(89, 39);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // l_topic
            // 
            this.l_topic.AutoSize = true;
            this.l_topic.Location = new System.Drawing.Point(19, 20);
            this.l_topic.Name = "l_topic";
            this.l_topic.Size = new System.Drawing.Size(37, 13);
            this.l_topic.TabIndex = 2;
            this.l_topic.Text = "Topic:";
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Location = new System.Drawing.Point(19, 48);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(67, 13);
            this.l_info.TabIndex = 3;
            this.l_info.Text = "Informations:";
            // 
            // l_ass
            // 
            this.l_ass.AutoSize = true;
            this.l_ass.Location = new System.Drawing.Point(19, 150);
            this.l_ass.Name = "l_ass";
            this.l_ass.Size = new System.Drawing.Size(53, 13);
            this.l_ass.TabIndex = 4;
            this.l_ass.Text = "Assignee:";
            // 
            // l_importance
            // 
            this.l_importance.AutoSize = true;
            this.l_importance.Location = new System.Drawing.Point(19, 177);
            this.l_importance.Name = "l_importance";
            this.l_importance.Size = new System.Drawing.Size(63, 13);
            this.l_importance.TabIndex = 5;
            this.l_importance.Text = "Importance:";
            // 
            // tb_topic
            // 
            this.tb_topic.Location = new System.Drawing.Point(92, 17);
            this.tb_topic.Name = "tb_topic";
            this.tb_topic.Size = new System.Drawing.Size(148, 20);
            this.tb_topic.TabIndex = 6;
            this.tb_topic.TextChanged += new System.EventHandler(this.tb_topic_TextChanged);
            // 
            // tb_ass
            // 
            this.tb_ass.Location = new System.Drawing.Point(92, 150);
            this.tb_ass.Name = "tb_ass";
            this.tb_ass.Size = new System.Drawing.Size(148, 20);
            this.tb_ass.TabIndex = 8;
            this.tb_ass.TextChanged += new System.EventHandler(this.tb_ass_TextChanged);
            // 
            // tb_info
            // 
            this.tb_info.Location = new System.Drawing.Point(92, 48);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(148, 92);
            this.tb_info.TabIndex = 9;
            this.tb_info.TextChanged += new System.EventHandler(this.tb_info_TextChanged);
            // 
            // cb_imp
            // 
            this.cb_imp.FormattingEnabled = true;
            this.cb_imp.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cb_imp.Location = new System.Drawing.Point(92, 177);
            this.cb_imp.Name = "cb_imp";
            this.cb_imp.Size = new System.Drawing.Size(121, 21);
            this.cb_imp.TabIndex = 10;
            // 
            // Add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_imp);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.tb_ass);
            this.Controls.Add(this.tb_topic);
            this.Controls.Add(this.l_importance);
            this.Controls.Add(this.l_ass);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.l_topic);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_add);
            this.Name = "Add_task";
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label l_topic;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Label l_ass;
        private System.Windows.Forms.Label l_importance;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.TextBox tb_ass;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.ComboBox cb_imp;
    }
}