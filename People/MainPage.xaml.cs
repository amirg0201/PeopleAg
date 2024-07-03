using People.Models;
using System.Collections.Generic;

namespace People;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        App.PersonRepoAg.AddNewPerson(newPerson.Text);
        statusMessage.Text = App.PersonRepoAg.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<PersonAg> people = App.PersonRepoAg.GetAllPeople();
        peopleList.ItemsSource = people;
    }

}

