using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateSelectorDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorderView : ContentView
    {
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(BorderView), default(int));
        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(BorderView), default(Color));
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty OuterFrameStyleProperty =
            BindableProperty.Create(nameof(OuterFrameStyle), typeof(Style), typeof(BorderView), default(Style));
        public Style OuterFrameStyle
        {
            get { return (Style)GetValue(OuterFrameStyleProperty); }
            set { SetValue(OuterFrameStyleProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(BorderView), default(int));
        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly BindableProperty OFHeightRequestProperty =
            BindableProperty.Create(nameof(OFHeightRequest), typeof(int), typeof(BorderView), default(int));
        public int OFHeightRequest
        {
            get { return (int)GetValue(OFHeightRequestProperty); }
            set { SetValue(OFHeightRequestProperty, value); }
        }

        public static readonly BindableProperty OFWidthRequestProperty =
            BindableProperty.Create(nameof(OFWidthRequest), typeof(int), typeof(BorderView), default(int));
        public int OFWidthRequest
        {
            get { return (int)GetValue(OFWidthRequestProperty); }
            set { SetValue(OFWidthRequestProperty, value); }
        }

        public static readonly BindableProperty InnerBackgroundColorProperty =
            BindableProperty.Create(nameof(InnerBackgroundColor), typeof(Color), typeof(BorderView), default(Color));
        public Color InnerBackgroundColor
        {
            get { return (Color)GetValue(InnerBackgroundColorProperty); }
            set { SetValue(InnerBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty InnerContentProperty =
            BindableProperty.Create(nameof(InnerContent), typeof(View), typeof(BorderView), default(View));
        public View InnerContent
        {
            get { return (View)GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }

        public BorderView()
        {
            InitializeComponent();
        }
    }
}