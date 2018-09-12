# How to close window

## References

- Microsoft.Expression.Interactions
- System.Windows.Interactivity

## xaml

``` xml
xmlns:ei="http://schemas.microsoft.com/expression/2010/interactions"
xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
```

``` xml
<i:Interaction.Triggers>
    <i:EventTrigger EventName="[Event name]">
        <ei:CallMethodAction MethodName="Close"
            TargetObject="{Binding RelativeSource={RelativeSource AncestorType=Window}}" />
    </i:EventTrigger>
</i:Interaction.Triggers>
```

When call ShowDialog method.  

``` xml
<i:Interaction.Triggers>
     <i:EventTrigger EventName="[Event name]">
        <ei:ChangePropertyAction
            PropertyName="DialogResult"
            TargetObject="{Binding RelativeSource={RelativeSource AncestorType=Window}}"
            Value="[True/False]" />
    </i:EventTrigger>
</i:Interaction.Triggers>
```