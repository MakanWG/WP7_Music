using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Ninject;

namespace Songkick.Presentation.Phone
{
    public static class Initializer
    {
        private static IKernel _kernel;
        private static Application _app;
        public static void InitializeInjection()
        {
            Module module = new Module();
            _kernel = new StandardKernel();
            _kernel.Load(module);
        }

        public static void SetApp(Application app)
        {
            _app = app;
        }

        public static IKernel GetKernel()
        {
            return _kernel;
        }

        public static Application GetApp()
        {
            return _app;
        }


    }
}
