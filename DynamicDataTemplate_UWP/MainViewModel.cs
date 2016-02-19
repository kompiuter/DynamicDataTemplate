using DynamicDataTemplate_UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DynamicDataTemplate_UWP
{
    public class MainViewModel
    {
        public List<IModel> Coll { get; set; } = new List<IModel>
        {
            new ModelA {Title = "Model A" },
            new ModelB {Title = "Model B" },
        };
    }

    public class DynamicDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ModelATemplate { get; set; }
        public DataTemplate ModelBTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is Models.ModelA)
                return ModelATemplate;
            else if (item is Models.ModelB)
                return ModelBTemplate;
            else return base.SelectTemplate(item, container);
        }
    }

    namespace Models
    {
        public interface IModel { string Title { get; set; } }
        public class ModelA : IModel { public string Title { get; set; } }
        public class ModelB : IModel { public string Title { get; set; } }
    }
}
