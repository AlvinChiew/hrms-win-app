using System.Data;
using System.Data.SqlClient;

namespace hrms_win_app;

public partial class frmShowEmployees : Form
{
    DBUtilities dbUtilities;
    public static bool isNewEmployeeAdded = false;

    public frmShowEmployees()
    {
        InitializeComponent();
        loadEmployeeData();
    }

    private void loadEmployeeData()
    {
        dbUtilities = new DBUtilities();
        lstEmployees.Items.Clear();  // Avoid stacking duplicates in ListView
        DataTable dt = dbUtilities.queryTable("SELECT e.*, p.PositionName " +
                                              "FROM dbHrmsProj.dbo.tblEmployees AS e " +
                                              "INNER JOIN dbHrmsProj.dbo.tblPosition AS p " +
                                              "ON e.PositionID = p.PositionID " +
                                              "ORDER BY ID;");
        foreach (DataRow dr in dt.Rows)
        {
            ListViewItem item = new ListViewItem();
            foreach (DataColumn col in dt.Columns)
            {
                string colNm = col.ColumnName == "PositionID" ? "PositionName" : col.ColumnName;
                string? cellVal = colNm == "BDate" ? Convert.ToDateTime(dr[colNm].ToString()).ToString("MMM dd, yyy") : dr[colNm].ToString();
                item.SubItems.Add(cellVal);                
            }
            item.SubItems.RemoveAt(0);
            lstEmployees.Items.Add(item);
        }

        lstEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        lstEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

    }

    private void tmrUpdate_Tick(object sender, EventArgs e)
    {
        if (isNewEmployeeAdded)
        {
            loadEmployeeData();
            isNewEmployeeAdded = false;
        }
    }
}
