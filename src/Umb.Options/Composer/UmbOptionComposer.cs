using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umb.Options.PropertyValueConverters;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Umb.Options.Composer
{
    public class UmbOptionComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            //If the type is not accessible you will need to locate the instance and then remove it:
            var contentPickerValueConverter = builder.PropertyValueConverters().GetTypes().FirstOrDefault(x => x.Name == nameof(UmbOptionsValueConverter));
            //if (contentPickerValueConverter != null)
            //{
            //    builder.PropertyValueConverters().Remove(contentPickerValueConverter);
            //}
        }
    }
}
