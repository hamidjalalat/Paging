using System.Linq;
using System.Data.Entity;

namespace LEARNING_ENTITY_FRAMEWORK
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public int PageSize { get; set; }

		public int PageIndex { get; set; }

		private Models.DatabaseContext MyDatabaseContext { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			PageSize = 10;
			PageIndex = 0;

			try
			{
				MyDatabaseContext =
					new Models.DatabaseContext();

				DisplayCountries();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		private void DisplayCountries()
		{
			labelPageIndex.Text = (PageIndex + 1).ToString("#,##0");
			labelPageCount.Text = (GetLastPageIndex() + 1).ToString("#,##0");

			// در زمان استفاده از
			// Skip و Take
			// استفاده از دستور
			// OrderBy
			// الزامی است
			var varCountries =
				MyDatabaseContext.Countries
				.OrderBy(current => current.Name)
				.Skip(PageIndex * PageSize)
				.Take(PageSize)
				.ToList()
				;

			countriesListBox.ValueMember = "Id";
			countriesListBox.DisplayMember = "Name";
			countriesListBox.DataSource = varCountries;
		}

		private int GetCountryCount()
		{
			int intCount =
				MyDatabaseContext.Countries
				.Count();

			return (intCount);
		}

		private int GetLastPageIndex()
		{
			int intCount = GetCountryCount();

			if (intCount % PageSize == 0)
			{
				return ((intCount / PageSize) - 1);
			}
			else
			{
				return (intCount / PageSize);
			}
		}

		private void MainForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			if (MyDatabaseContext != null)
			{
				MyDatabaseContext.Dispose();
				MyDatabaseContext = null;
			}
		}

		private void firstButton_Click(object sender, System.EventArgs e)
		{
			PageIndex = 0;

			DisplayCountries();
		}

		private void previousButton_Click(object sender, System.EventArgs e)
		{
			if (PageIndex > 0)
			{
				PageIndex--;

				DisplayCountries();
			}
		}

		private void nextButton_Click(object sender, System.EventArgs e)
		{
			if (PageIndex < GetLastPageIndex())
			{
				PageIndex++;

				DisplayCountries();
			}
		}

		private void lastButton_Click(object sender, System.EventArgs e)
		{
			PageIndex = GetLastPageIndex();

			DisplayCountries();
		}

        private void pnlButtons_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
