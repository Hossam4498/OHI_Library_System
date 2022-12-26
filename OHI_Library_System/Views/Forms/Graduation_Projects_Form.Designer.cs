namespace OHI_Library_System.Views.Forms
{
    partial class Graduation_Projects_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graduation_Projects_Form));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.studentName = new DevExpress.XtraEditors.TextEdit();
            this.projectYear = new DevExpress.XtraEditors.TextEdit();
            this.projectDepartment = new DevExpress.XtraEditors.TextEdit();
            this.projectName = new DevExpress.XtraEditors.TextEdit();
            this.projectID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.AutoSize = true;
            this.groupControl4.Controls.Add(this.dataGridView);
            this.groupControl4.Location = new System.Drawing.Point(565, 18);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(689, 520);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Data";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(667, 468);
            this.dataGridView.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.AutoSize = true;
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnDeleteAll);
            this.groupControl3.Controls.Add(this.btnAdd);
            this.groupControl3.Controls.Add(this.btnNew);
            this.groupControl3.Controls.Add(this.btnUpdate);
            this.groupControl3.Location = new System.Drawing.Point(24, 554);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1230, 100);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Process";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.Options.UseTextOptions = true;
            this.btnDelete.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearancePressed.Options.UseFont = true;
            this.btnDelete.AppearancePressed.Options.UseTextOptions = true;
            this.btnDelete.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(715, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(154, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Appearance.Options.UseFont = true;
            this.btnDeleteAll.Appearance.Options.UseTextOptions = true;
            this.btnDeleteAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteAll.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteAll.AppearanceHovered.Options.UseTextOptions = true;
            this.btnDeleteAll.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteAll.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.AppearancePressed.Options.UseFont = true;
            this.btnDeleteAll.AppearancePressed.Options.UseTextOptions = true;
            this.btnDeleteAll.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDeleteAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.ImageOptions.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(890, 39);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteAll.Size = new System.Drawing.Size(154, 49);
            this.btnDeleteAll.TabIndex = 2;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseTextOptions = true;
            this.btnAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseTextOptions = true;
            this.btnAdd.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.AppearancePressed.Options.UseFont = true;
            this.btnAdd.AppearancePressed.Options.UseTextOptions = true;
            this.btnAdd.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(386, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(154, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Appearance.Options.UseTextOptions = true;
            this.btnNew.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnNew.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.AppearanceHovered.Options.UseFont = true;
            this.btnNew.AppearanceHovered.Options.UseTextOptions = true;
            this.btnNew.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnNew.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.AppearancePressed.Options.UseFont = true;
            this.btnNew.AppearancePressed.Options.UseTextOptions = true;
            this.btnNew.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(216, 38);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNew.Size = new System.Drawing.Size(154, 51);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseTextOptions = true;
            this.btnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.Options.UseTextOptions = true;
            this.btnUpdate.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.AppearancePressed.Options.UseFont = true;
            this.btnUpdate.AppearancePressed.Options.UseTextOptions = true;
            this.btnUpdate.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(542, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(154, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.btnLast);
            this.groupControl2.Controls.Add(this.btnPrevious);
            this.groupControl2.Controls.Add(this.btnNext);
            this.groupControl2.Controls.Add(this.btnFirst);
            this.groupControl2.Location = new System.Drawing.Point(24, 433);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(505, 105);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Moving Arrows";
            // 
            // btnLast
            // 
            this.btnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.ImageOptions.Image")));
            this.btnLast.Location = new System.Drawing.Point(78, 45);
            this.btnLast.Name = "btnLast";
            this.btnLast.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnLast.Size = new System.Drawing.Size(47, 49);
            this.btnLast.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ImageOptions.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(183, 43);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrevious.Size = new System.Drawing.Size(46, 51);
            this.btnPrevious.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.Location = new System.Drawing.Point(272, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNext.Size = new System.Drawing.Size(46, 51);
            this.btnNext.TabIndex = 2;
            // 
            // btnFirst
            // 
            this.btnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.ImageOptions.Image")));
            this.btnFirst.Location = new System.Drawing.Point(374, 43);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFirst.Size = new System.Drawing.Size(46, 51);
            this.btnFirst.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.studentName);
            this.groupControl1.Controls.Add(this.projectYear);
            this.groupControl1.Controls.Add(this.projectDepartment);
            this.groupControl1.Controls.Add(this.projectName);
            this.groupControl1.Controls.Add(this.projectID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(24, 18);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(505, 398);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Graduation Projects Data";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(189, 334);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(266, 26);
            this.studentName.TabIndex = 1;
            this.studentName.EditValueChanged += new System.EventHandler(this.studentName_EditValueChanged);
            // 
            // projectYear
            // 
            this.projectYear.Location = new System.Drawing.Point(189, 275);
            this.projectYear.Name = "projectYear";
            this.projectYear.Size = new System.Drawing.Size(266, 26);
            this.projectYear.TabIndex = 1;
            // 
            // projectDepartment
            // 
            this.projectDepartment.Location = new System.Drawing.Point(189, 204);
            this.projectDepartment.Name = "projectDepartment";
            this.projectDepartment.Size = new System.Drawing.Size(266, 26);
            this.projectDepartment.TabIndex = 1;
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(189, 140);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(266, 26);
            this.projectName.TabIndex = 1;
            // 
            // projectID
            // 
            this.projectID.Location = new System.Drawing.Point(189, 75);
            this.projectID.Name = "projectID";
            this.projectID.Size = new System.Drawing.Size(266, 26);
            this.projectID.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl5.AppearanceDisabled.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AppearanceDisabled.Options.UseFont = true;
            this.labelControl5.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl5.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl5.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AppearanceHovered.Options.UseFont = true;
            this.labelControl5.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl5.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl5.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AppearancePressed.Options.UseFont = true;
            this.labelControl5.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl5.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl5.Location = new System.Drawing.Point(39, 334);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 24);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Student Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl4.AppearanceDisabled.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AppearanceDisabled.Options.UseFont = true;
            this.labelControl4.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl4.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl4.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AppearanceHovered.Options.UseFont = true;
            this.labelControl4.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl4.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl4.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AppearancePressed.Options.UseFont = true;
            this.labelControl4.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl4.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl4.Location = new System.Drawing.Point(39, 275);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 24);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Project Year";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl3.AppearanceDisabled.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AppearanceDisabled.Options.UseFont = true;
            this.labelControl3.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl3.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl3.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AppearanceHovered.Options.UseFont = true;
            this.labelControl3.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl3.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl3.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AppearancePressed.Options.UseFont = true;
            this.labelControl3.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl3.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(39, 194);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 48);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Project \r\nDepartment";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl2.AppearanceDisabled.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AppearanceDisabled.Options.UseFont = true;
            this.labelControl2.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl2.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AppearanceHovered.Options.UseFont = true;
            this.labelControl2.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl2.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl2.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AppearancePressed.Options.UseFont = true;
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(39, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Project Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl1.AppearanceDisabled.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearanceDisabled.Options.UseFont = true;
            this.labelControl1.AppearanceDisabled.Options.UseTextOptions = true;
            this.labelControl1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl1.AppearanceHovered.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearanceHovered.Options.UseFont = true;
            this.labelControl1.AppearanceHovered.Options.UseTextOptions = true;
            this.labelControl1.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl1.AppearancePressed.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AppearancePressed.Options.UseFont = true;
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Project ID";
            // 
            // Graduation_Projects_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 673);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Graduation_Projects_Form";
            this.Text = "Graduation Projects";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit studentName;
        private DevExpress.XtraEditors.TextEdit projectYear;
        private DevExpress.XtraEditors.TextEdit projectDepartment;
        private DevExpress.XtraEditors.TextEdit projectName;
        private DevExpress.XtraEditors.TextEdit projectID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}