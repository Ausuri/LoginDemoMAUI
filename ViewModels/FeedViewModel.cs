using CommunityToolkit.Mvvm.ComponentModel;
using LoginDemoMAUI.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMAUI.ViewModels
{
    public class FeedViewModel : ObservableObject
    {
        ObservableCollection<StoryBoardItem> _storyBoardItems; 
    }
}
