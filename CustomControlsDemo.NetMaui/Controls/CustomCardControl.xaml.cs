namespace CustomControlsDemo.NetMaui.Controls;

public partial class CustomCardControl : ContentView
{
	public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomCardControl), propertyChanged: (bindable, oldValue, newValue) =>
	{
		var control = (CustomCardControl)bindable;

		control.CustomCardControlLabel.Text = newValue as string;
	});

    public static readonly BindableProperty SizeOfFontProperty = BindableProperty.Create(nameof(SizeOfFont), typeof(double?), typeof(CustomCardControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (CustomCardControl)bindable;

        control.CustomCardControlLabel.FontSize = (double)newValue;
    });

    public CustomCardControl()
	{
		InitializeComponent();
	}

    public string LabelText 
	{
		get => GetValue(LabelTextProperty) as string; 
		set => SetValue(LabelTextProperty, value);
	}

    public double? SizeOfFont
    {
        get => GetValue(SizeOfFontProperty) as double?;
        set => SetValue(SizeOfFontProperty, value);
    }
}