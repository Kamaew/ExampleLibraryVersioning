using Resto.Front.Api;
using Resto.Front.Api.Attributes;
using Resto.Front.Api.Data.Orders;
using Resto.Front.Api.Extensions;
using Resto.Front.Api.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibraryVersioning
{
    [PluginLicenseModuleId(21016318)]
    public class Class1 : IFrontPlugin
    {
        private readonly Stack<IDisposable> subscriptions = new Stack<IDisposable>();
        public Class1()
        {
            subscriptions.Push(new AddOneButton());
            subscriptions.Push(PluginContext.Notifications.SubscribeOnBeforeOrderBill(OnNavigating));
        }

        private void OnNavigating(IOrder arg1, IViewManager arg2)
        {
            PluginContext.Log.Info($"Оплата заказа {arg1.Id}");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
