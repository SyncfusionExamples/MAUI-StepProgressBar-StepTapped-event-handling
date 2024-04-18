using Syncfusion.Maui.ProgressBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepProgressBarStatusSteppedEvent;
public class StepProgressBarBehaviour : Behavior<ContentPage>
{
    #region Fields

    /// <summary>
    /// The step progress bar instance.
    /// </summary>
    private SfStepProgressBar? stepProgressBar;

    #endregion

    #region Override methods

    /// <summary>
    /// Invoked when behavior is attached to a view.
    /// </summary>
    /// <param name="sampleView">The sample view to which the behavior is attached.</param>
    protected override void OnAttachedTo(ContentPage sampleView)
    {
        base.OnAttachedTo(sampleView);
        this.stepProgressBar = sampleView.FindByName<SfStepProgressBar>("stepProgress");
        
        if (this.stepProgressBar != null)
        {
            this.stepProgressBar.StepTapped += OnStepProgressBar_StepTapped;
        }
    }

    /// <summary>
    /// Invoked when behavior is detached from a view.
    /// </summary>
    /// <param name="sampleView">The sample view from which the behavior is detached.</param>
    protected override void OnDetachingFrom(ContentPage sampleView)
    {
        base.OnDetachingFrom(sampleView);

        if (this.stepProgressBar != null)
        {
            this.stepProgressBar.StepTapped -= OnStepProgressBar_StepTapped;
            this.stepProgressBar = null;
        }
    }

    #endregion

    #region Property changed

    /// <summary>
    /// Invokes on step tapped changed.
    /// </summary>
    /// <param name="sender">The step progress bar.</param>
    /// <param name="e">The event args.</param>
    private void OnStepProgressBar_StepTapped(object? sender, StepTappedEventArgs e)
    {
        StepProgressBarItem? stepProgressBarItem = e.StepItem;
        if (stepProgressBarItem != null)
        {
            string primaryText = stepProgressBarItem.PrimaryText;
            Application.Current?.MainPage?.DisplayAlert("StepItem",primaryText , "OK");
        }
    }

    #endregion

}

