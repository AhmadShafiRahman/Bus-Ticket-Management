namespace BusTicketAdmin
{
    partial class UserControlBusOperator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBusOperator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelWelcomeName = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWelcomUser = new System.Windows.Forms.Label();
            this.TextBoxOperatorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxFare = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.busTicketDataSet = new BusTicketAdmin.BusTicketDataSet();
            this.businfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bus_infoTableAdapter = new BusTicketAdmin.BusTicketDataSetTableAdapters.Bus_infoTableAdapter();
            this.busTicketDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOperatorList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatorList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dataGridViewOperatorList);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 670);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ButtonDelete);
            this.panel2.Controls.Add(this.textBoxFare);
            this.panel2.Controls.Add(this.TextBoxId);
            this.panel2.Controls.Add(this.TextBoxOperatorName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.LabelWelcomeName);
            this.panel2.Controls.Add(this.ButtonSearch);
            this.panel2.Controls.Add(this.ButtonSignUp);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelWelcomUser);
            this.panel2.Location = new System.Drawing.Point(367, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 669);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(26, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fare";
            // 
            // LabelWelcomeName
            // 
            this.LabelWelcomeName.AutoSize = true;
            this.LabelWelcomeName.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelWelcomeName.Location = new System.Drawing.Point(22, 74);
            this.LabelWelcomeName.Name = "LabelWelcomeName";
            this.LabelWelcomeName.Size = new System.Drawing.Size(193, 44);
            this.LabelWelcomeName.TabIndex = 16;
            this.LabelWelcomeName.Text = "Welcome!";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(30, 398);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(306, 37);
            this.ButtonSearch.TabIndex = 11;
            this.ButtonSearch.Text = "ADD OPERATOR";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ButtonSignUp.Location = new System.Drawing.Point(30, 527);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(306, 37);
            this.ButtonSignUp.TabIndex = 3;
            this.ButtonSignUp.Text = "BACK";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelId.Location = new System.Drawing.Point(26, 247);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 23);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Operator Name";
            // 
            // labelWelcomUser
            // 
            this.labelWelcomUser.AutoSize = true;
            this.labelWelcomUser.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelWelcomUser.Location = new System.Drawing.Point(19, 30);
            this.labelWelcomUser.Name = "labelWelcomUser";
            this.labelWelcomUser.Size = new System.Drawing.Size(193, 44);
            this.labelWelcomUser.TabIndex = 0;
            this.labelWelcomUser.Text = "Welcome!";
            // 
            // TextBoxOperatorName
            // 
            this.TextBoxOperatorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxOperatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxOperatorName.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxOperatorName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxOperatorName.HintText = "Operator Name";
            this.TextBoxOperatorName.isPassword = false;
            this.TextBoxOperatorName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxOperatorName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxOperatorName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxOperatorName.LineThickness = 3;
            this.TextBoxOperatorName.Location = new System.Drawing.Point(27, 206);
            this.TextBoxOperatorName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxOperatorName.Name = "TextBoxOperatorName";
            this.TextBoxOperatorName.Size = new System.Drawing.Size(303, 37);
            this.TextBoxOperatorName.TabIndex = 30;
            this.TextBoxOperatorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxId.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxId.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxId.HintText = "ID";
            this.TextBoxId.isPassword = false;
            this.TextBoxId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxId.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxId.LineThickness = 3;
            this.TextBoxId.Location = new System.Drawing.Point(30, 274);
            this.TextBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(303, 37);
            this.TextBoxId.TabIndex = 31;
            this.TextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxFare
            // 
            this.textBoxFare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxFare.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFare.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxFare.HintText = "User Name";
            this.textBoxFare.isPassword = false;
            this.textBoxFare.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxFare.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxFare.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxFare.LineThickness = 3;
            this.textBoxFare.Location = new System.Drawing.Point(30, 354);
            this.textBoxFare.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFare.Name = "textBoxFare";
            this.textBoxFare.Size = new System.Drawing.Size(303, 37);
            this.textBoxFare.TabIndex = 32;
            this.textBoxFare.Text = "Fare";
            this.textBoxFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(30, 441);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(306, 37);
            this.ButtonDelete.TabIndex = 33;
            this.ButtonDelete.Text = "DELETE OPERATOR";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 37);
            this.button2.TabIndex = 34;
            this.button2.Text = "UPDATE OPERATOR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // busTicketDataSet
            // 
            this.busTicketDataSet.DataSetName = "BusTicketDataSet";
            this.busTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businfoBindingSource
            // 
            this.businfoBindingSource.DataMember = "Bus_info";
            this.businfoBindingSource.DataSource = this.busTicketDataSet;
            // 
            // bus_infoTableAdapter
            // 
            this.bus_infoTableAdapter.ClearBeforeFill = true;
            // 
            // busTicketDataSetBindingSource
            // 
            this.busTicketDataSetBindingSource.DataSource = this.busTicketDataSet;
            this.busTicketDataSetBindingSource.Position = 0;
            // 
            // dataGridViewOperatorList
            // 
            this.dataGridViewOperatorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperatorList.Location = new System.Drawing.Point(0, 145);
            this.dataGridViewOperatorList.Name = "dataGridViewOperatorList";
            this.dataGridViewOperatorList.Size = new System.Drawing.Size(369, 464);
            this.dataGridViewOperatorList.TabIndex = 1;
            this.dataGridViewOperatorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserControlBusOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlBusOperator";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControlBusOperator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelWelcomeName;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWelcomUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxFare;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxOperatorName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.BindingSource businfoBindingSource;
        private BusTicketDataSet busTicketDataSet;
        private BusTicketDataSetTableAdapters.Bus_infoTableAdapter bus_infoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOperatorList;
        private System.Windows.Forms.BindingSource busTicketDataSetBindingSource;
    }
}
