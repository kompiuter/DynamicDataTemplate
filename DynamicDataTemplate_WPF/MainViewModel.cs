using DynamicDataTemplate_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataTemplate_WPF
{
    public class MainViewModel
    {
        public List<IModel> Coll { get; set; } = new List<IModel>
        {
            new ModelA {Title = "Model A" },
            new ModelB {Title = "Model B" },
        };
    }

    namespace Models
    {
        public interface IModel { string Title { get; set; } }
        public class ModelA : IModel { public string Title { get; set; } }
        public class ModelB : IModel { public string Title { get; set; } }
    }
}
