namespace hrms_win_app;

partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.lstEmployees = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colFName = new System.Windows.Forms.ColumnHeader();
            this.colLName = new System.Windows.Forms.ColumnHeader();
            this.colMName = new System.Windows.Forms.ColumnHeader();
            this.colPosition = new System.Windows.Forms.ColumnHeader();
            this.colGender = new System.Windows.Forms.ColumnHeader();
            this.colBDate = new System.Windows.Forms.ColumnHeader();
            this.colAddress = new System.Windows.Forms.ColumnHeader();
            this.colTelNo = new System.Windows.Forms.ColumnHeader();
            this.colMobNo = new System.Windows.Forms.ColumnHeader();
            this.colEmailAddress = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colFName,
            this.colLName,
            this.colMName,
            this.colPosition,
            this.colGender,
            this.colBDate,
            this.colAddress,
            this.colTelNo,
            this.colMobNo,
            this.colEmailAddress});
            this.lstEmployees.FullRowSelect = true;
            this.lstEmployees.GridLines = true;
            this.lstEmployees.Location = new System.Drawing.Point(12, 191);
            this.lstEmployees.MultiSelect = false;
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(1367, 410);
            this.lstEmployees.TabIndex = 0;
            this.lstEmployees.UseCompatibleStateImageBehavior = false;
            this.lstEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colFName
            // 
            this.colFName.Text = "First Name";
            // 
            // colLName
            // 
            this.colLName.Text = "Last Name";
            // 
            // colMName
            // 
            this.colMName.Text = "Middle Name";
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            // 
            // colBDate
            // 
            this.colBDate.Text = "Birth Date";
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            // 
            // colTelNo
            // 
            this.colTelNo.Text = "Tel No";
            // 
            // colMobNo
            // 
            this.colMobNo.Text = "Mobile No";
            // 
            // colEmailAddress
            // 
            this.colEmailAddress.Text = "Email Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1391, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdmin
            // 
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddEmployee,
            this.menuAddPosition});
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(81, 29);
            this.menuAdmin.Text = "Admin";
            // 
            // menuAddEmployee
            // 
            this.menuAddEmployee.Name = "menuAddEmployee";
            this.menuAddEmployee.Size = new System.Drawing.Size(231, 34);
            this.menuAddEmployee.Text = "Add Employee";
            this.menuAddEmployee.Click += new System.EventHandler(this.menuAddEmployee_Click);
            // 
            // menuAddPosition
            // 
            this.menuAddPosition.Name = "menuAddPosition";
            this.menuAddPosition.Size = new System.Drawing.Size(231, 34);
            this.menuAddPosition.Text = "Add Position";
            this.menuAddPosition.Click += new System.EventHandler(this.menuAddPosition_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 613);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "HRMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ListView lstEmployees;
    private ColumnHeader colID;
    private ColumnHeader colFName;
    private ColumnHeader colLName;
    private ColumnHeader colMName;
    private ColumnHeader colPosition;
    private ColumnHeader colGender;
    private ColumnHeader colBDate;
    private ColumnHeader colAddress;
    private ColumnHeader colTelNo;
    private ColumnHeader colMobNo;
    private ColumnHeader colEmailAddress;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem menuAdmin;
    private ToolStripMenuItem menuAddEmployee;
    private ToolStripMenuItem menuAddPosition;
    private System.Windows.Forms.Timer tmrUpdate;
}
