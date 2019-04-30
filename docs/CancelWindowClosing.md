# How to cancel window closing

## References

- Microsoft.Xaml.Behaviors

## Behavior

``` cs
public class WindowClosingAction : TriggerAction<Window>
{
    public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register(
        nameof(Caption),
        typeof(string),
        typeof(WindowClosingAction),
        new PropertyMetadata("Confirm"));

    public static readonly DependencyProperty MessageBoxTextProperty = DependencyProperty.Register(
        nameof(MessageBoxText),
        typeof(string),
        typeof(WindowClosingAction),
        new PropertyMetadata("Are you sure to want to exit?"));

    public string Caption
    {
        get { return (string)this.GetValue(CaptionProperty); }
        set { this.SetValue(CaptionProperty, value); }
    }

    public string MessageBoxText
    {
        get { return (string)this.GetValue(MessageBoxTextProperty); }
        set { this.SetValue(MessageBoxTextProperty, value); }
    }

    protected override void Invoke(object parameter)
    {
        if (parameter is CancelEventArgs)
        {
            var e = parameter as CancelEventArgs;

            if (MessageBox.Show(
                this.MessageBoxText,
                this.Caption,
                MessageBoxButton.OKCancel,
                MessageBoxImage.Question,
                MessageBoxResult.Cancel) != MessageBoxResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
```

## Xaml

``` xml
xmlns:i="http://schemas.microsoft.com/xaml/behaviors"
```

``` xml
<Window>
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Closing">
            <b:WindowClosingAction />
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Window>
```
