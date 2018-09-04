namespace Kaznag.WpfPractice.ViewModels
{
    using System;
    using Prism.Mvvm;

    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
            }
        }
    }
}
