using Syncfusion.Maui.ProgressBar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepProgressBarStatusSteppedEvent;

/// <summary>
/// Represents the view model for the step progress bar functionality.
/// </summary>
public class StepProgressBarViewModel
{
    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    private ObservableCollection<StepProgressBarItem> stepProgressItem;

    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    public ObservableCollection<StepProgressBarItem> StepProgressItem
    {
        get
        {
            return stepProgressItem;
        }
        set
        {
            stepProgressItem = value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StepProgressBarViewModel"/> class.
    /// </summary>
    public StepProgressBarViewModel()
    {
        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Cart" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Address" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Delivery" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered" });
    }
}

