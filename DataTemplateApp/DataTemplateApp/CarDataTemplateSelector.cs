using DataTemplateApp.ViewModels;
using Xamarin.Forms;

namespace DataTemplateApp
{
    public class CarDataTemplateSelector : DataTemplateSelector
    {
        private static readonly DataTemplate ToyotaViewCellDataTemplate = new DataTemplate(typeof(ToyotaViewCell));
        private static readonly DataTemplate PorscheViewCellDataTemplate = new DataTemplate(typeof(PorscheViewCell));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Toyota) return ToyotaViewCellDataTemplate;
            if (item is Porsche) return PorscheViewCellDataTemplate;

            if (((Car)item).Name.Equals("Porsche")) return PorscheViewCellDataTemplate;

            return null;
        }
    }
}