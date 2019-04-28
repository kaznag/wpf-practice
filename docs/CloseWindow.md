# How to close window

## References

- Microsoft.Xaml.Behaviors

## xaml

``` xml
xmlns:i="http://schemas.microsoft.com/xaml/behaviors"
```

``` xml
<i:Interaction.Triggers>
    <i:EventTrigger EventName="[Event name]">
        <i:CallMethodAction MethodName="Close"
            TargetObject="{Binding RelativeSource={RelativeSource AncestorType=Window}}" />
    </i:EventTrigger>
</i:Interaction.Triggers>
```

When call ShowDialog method.  

``` xml
<i:Interaction.Triggers>
     <i:EventTrigger EventName="[Event name]">
        <i:ChangePropertyAction
            PropertyName="DialogResult"
            TargetObject="{Binding RelativeSource={RelativeSource AncestorType=Window}}"
            Value="[True/False]" />
    </i:EventTrigger>
</i:Interaction.Triggers>
```