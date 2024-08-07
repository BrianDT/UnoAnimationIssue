// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2015-2020 All rights reserved</copyright>

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace UnoAnimationIssue;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    /// <summary>
    /// The current visual state
    /// </summary>
    string currentState = "Shutoff";

    /// <summary>
    /// Initializes a new instance of the <see cref="MainPage"/> class
    /// </summary>
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = new SmokeViewModel();
    }

    /// <summary>
    /// Gets the viewmodel used for binding.
    /// </summary>
    public SmokeViewModel VM
    {
        get
        {
            return this.DataContext as SmokeViewModel;
        }
    }

    /// <summary>
    /// Event handler for start double colour animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ColourAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ColourAndSize");
    }

    /// <summary>
    /// Event handler for start key frame colour animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ColourKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ColourAndSizeKF");
    }

    /// <summary>
    /// Event handler for start double colour animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ColourAndPositionAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ColourAndPosition");
    }

    /// <summary>
    /// Event handler for start key frame colour animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ColourAndPositionKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ColourAndPositionKF");
    }

    private void Start_OpacityAndSizeAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacityAndSize");
    }

    private void Start_OpacityAndSizeKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacityAndSizeKF");
    }

    /// <summary>
    /// Event handler for start opacity and position animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_OpacityAndPositionAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacityAndPosition");
    }

    /// <summary>
    /// Event handler for start opacity and position animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_OpacityAndPositionKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacityAndPositionKF");
    }

    /// <summary>
    /// Event handler for start double animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ScaleAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ScaleTransform");
    }

    /// <summary>
    /// Event handler for start double animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_ScaleKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("ScaleTransformKF");
    }

    /// <summary>
    /// Event handler for start double key frame animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_TranslationAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("TranslateTransform");
    }

    /// <summary>
    /// Event handler for start double key frame animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_TranslationKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("TranslateTransformKF");
    }

    private void Start_OpacitySizeTranslationAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacitySizeAndTranslateTransform");
    }

    private void Start_OpacitySizeTranslationKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("OpacitySizeAndTranslateTransformKF");
    }

    /// <summary>
    /// Event handler for start double key frame animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_CombinedAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("CombinedTransform");
    }

    /// <summary>
    /// Event handler for start double key frame animation.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Start_CombinedKFAnimation_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("CombinedTransformKF");
    }

    /// <summary>
    /// Event handler for stopping the animations.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void Stop_Animations_Click(object sender, RoutedEventArgs e)
    {
        this.ChangeState("Shutoff");
    }

    /// <summary>
    /// Change the visual state.
    /// </summary>
    /// <param name="newState">The new state name.</param>
    private void ChangeState(string newState)
    {
        if (this.currentState != newState)
        {
            this.currentState = newState;
            bool stateChanged = VisualStateManager.GoToState(this, newState, false);
        }
    }
}
