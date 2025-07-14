namespace Kanban_ToDoList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCreateTaskForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelCanalled = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelDone = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelReview = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelDoing = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateTaskForm
            // 
            this.btnCreateTaskForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnCreateTaskForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTaskForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCreateTaskForm.ForeColor = System.Drawing.Color.Snow;
            this.btnCreateTaskForm.Location = new System.Drawing.Point(42, 62);
            this.btnCreateTaskForm.Name = "btnCreateTaskForm";
            this.btnCreateTaskForm.Size = new System.Drawing.Size(185, 43);
            this.btnCreateTaskForm.TabIndex = 2;
            this.btnCreateTaskForm.Text = "New Task";
            this.btnCreateTaskForm.UseVisualStyleBackColor = false;
            this.btnCreateTaskForm.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelCanalled);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PanelDone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PanelReview);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PanelDoing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PanelToDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 355);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // PanelCanalled
            // 
            this.PanelCanalled.BackColor = System.Drawing.Color.White;
            this.PanelCanalled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCanalled.Location = new System.Drawing.Point(551, 42);
            this.PanelCanalled.Name = "PanelCanalled";
            this.PanelCanalled.Size = new System.Drawing.Size(141, 313);
            this.PanelCanalled.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(551, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cancalled";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelDone
            // 
            this.PanelDone.BackColor = System.Drawing.Color.White;
            this.PanelDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDone.Location = new System.Drawing.Point(413, 42);
            this.PanelDone.Name = "PanelDone";
            this.PanelDone.Size = new System.Drawing.Size(141, 313);
            this.PanelDone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelReview
            // 
            this.PanelReview.BackColor = System.Drawing.Color.White;
            this.PanelReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelReview.Location = new System.Drawing.Point(275, 42);
            this.PanelReview.Name = "PanelReview";
            this.PanelReview.Size = new System.Drawing.Size(141, 313);
            this.PanelReview.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Review";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelDoing
            // 
            this.PanelDoing.BackColor = System.Drawing.Color.White;
            this.PanelDoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDoing.Location = new System.Drawing.Point(137, 42);
            this.PanelDoing.Name = "PanelDoing";
            this.PanelDoing.Size = new System.Drawing.Size(141, 313);
            this.PanelDoing.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelToDo
            // 
            this.PanelToDo.BackColor = System.Drawing.Color.White;
            this.PanelToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelToDo.Location = new System.Drawing.Point(0, 42);
            this.PanelToDo.Name = "PanelToDo";
            this.PanelToDo.Size = new System.Drawing.Size(141, 313);
            this.PanelToDo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(787, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateTaskForm);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban ToDoList";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTaskForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel PanelToDo;
        public System.Windows.Forms.FlowLayoutPanel PanelCanalled;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.FlowLayoutPanel PanelDone;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.FlowLayoutPanel PanelReview;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel PanelDoing;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

