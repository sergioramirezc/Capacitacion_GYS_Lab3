using Autofac;
using Lab3.App.Services;
using System;
using System.Globalization;
using System.Reflection;
using Lab3.App.Services.RequestProvider;
using Xamarin.Forms;
using Lab3.App.Services.RamService;
using Lab3.App.Services.Events;
using Lab3.App.ViewModels.Events;

namespace Lab3.App.ViewModels.Base
{
    public static class ViewModelLocator
    {
        #region Public Fields

        public static readonly BindableProperty AutoWireViewModelProperty =
            BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator), default(bool), propertyChanged: OnAutoWireViewModelChanged);

        #endregion Public Fields

        #region Private Fields

        private static IContainer _container;

        #endregion Private Fields

        #region Public Properties

        public static bool UseMockService { get; set; }

        #endregion Public Properties

        #region Public Methods

        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ViewModelLocator.AutoWireViewModelProperty);
        }

        public static void RegisterDependencies(bool useMockServices)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MasterViewModel>();
            builder.RegisterType<MasterDetailViewModel>();
            builder.RegisterType<EventListViewModel>();
            builder.RegisterType<RamListViewModel>();
            builder.RegisterType<RamDetailViewModel>();
            builder.RegisterType<EventDetailViewModel>();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<RequestProvider>().As<IRequestProvider>();
            if (useMockServices)
            {
                builder.RegisterType<RamMockService>().As<IRamService>();
                builder.RegisterType<EventsMockService>().As<IEventsService>();
            }
            else
            {
                builder.RegisterType<RamService>().As<IRamService>();
            }

            if (_container != null)
            {
                _container.Dispose();
            }
            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(ViewModelLocator.AutoWireViewModelProperty, value);
        }

        #endregion Public Methods

        #region Private Methods

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as Element;
            if (view == null)
            {
                return;
            }

            var viewType = view.GetType();
            var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
            var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
            var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}Model, {1}", viewName, viewAssemblyName);

            var viewModelType = Type.GetType(viewModelName);
            if (viewModelType == null)
            {
                return;
            }
            var viewModel = _container.Resolve(viewModelType);
            view.BindingContext = viewModel;
        }

        #endregion Private Methods
    }
}