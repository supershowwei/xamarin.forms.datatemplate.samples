using System.Collections.ObjectModel;

namespace DataTemplateApp.ViewModels
{
    public class MainPageViewModel
    {
        private ObservableCollection<Car> cars;

        public MainPageViewModel()
        {
            this.Cars = new ObservableCollection<Car>
                            {
                                new Toyota { Name = "Toyota" },
                                new Porsche { Name = "Porsche" }
                            };
        }

        public ObservableCollection<Car> Cars { get; set; }
    }
}