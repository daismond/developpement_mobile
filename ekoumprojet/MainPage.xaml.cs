
using rattrapageProfile.Model;
namespace rattrapageProfile;

public partial class MainPage : ContentPage
{

	private User armand;
	public MainPage()
	{
		InitializeComponent();
       // armand = new ("Emane Armand", "Ingénieur de Génie Informatique", "@armand", "armand", 25, 250, "standard","tof.jpg");
		this.BindingContext = new User();

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		login.IsReadOnly = false;
	}

	private void PassEditClicked(object sender, EventArgs e)
	{
		pwd.IsReadOnly = false;
	}

	private void nameEditClicked(object sender, EventArgs e)
	{
		name.IsReadOnly = false;
	}

	private void kpiEditClicked(object sender, EventArgs e)
	{
		kpi.IsReadOnly = false;
	}
}

