using System;
using System.Reactive.Disposables;
using Resto.Front.Api.Attributes.JetBrains;
using Resto.Front.Api;
using Resto.Front.Api.UI;
using Resto.Front.Api.Extensions;

namespace ExampleLibraryVersioning
{
    public class AddOneButton : IDisposable
    {
        [CanBeNull]
        private readonly CompositeDisposable subscriptions;
        public AddOneButton()
        {
            subscriptions = new CompositeDisposable
            {
               PluginContext.Integration.AddButton("Тестовая кнопка",DownButton)
            };
        }

        private void DownButton(IViewManager viewManager, IReceiptPrinter receiptPrinter)
        {
            PluginContext.Log.Info("На кнопку нажали.");
        }
        public void Dispose()
        {
            subscriptions.Dispose();
        }
    }
}
