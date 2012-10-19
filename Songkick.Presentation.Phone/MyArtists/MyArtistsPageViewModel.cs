using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Songkick.Entities.Phone.Events;
using Songkick.Presentation.Phone.ServicesLocators;
using WG.Presentation.Phone.ViewModels;
using WG.Tools.Phone.Helpers;
using System.Linq;

namespace Songkick.Presentation.Phone.MyArtists
{
    public class MyArtistsPageViewModel : ViewModelBase
    {
        public ObservableCollection<WGGrouping<Char, Artist>> TrackedArtists
        {
            get { return GetValue<ObservableCollection<WGGrouping<Char, Artist>>>("TrackedArtists", null); }
            set { SetValue("TrackedArtists", value);
                this.ExecuteOnDispatcher(() => this.Services().Notifications.ClearProgressIndicator());
            }
        }

        private int _totalEntries;

        public int Page { get; set; }

        public ICommand EndListCommand
        {
            get { return GetValue<ICommand>("EndListCommand", null); }
            set { SetValue("EndListCommand", value);}
        }

        public MyArtistsPageViewModel()
        {
            EndListCommand = new WGCommand(_ =>
                                               {  
                                                   if (TrackedArtists.SelectMany(art => art.ToList()).Count() >= _totalEntries)
                                                       return;
                                                   this.Services().Notifications.SetProgress("");
                                                   Page++;
                                                   this.ExecuteAsync(__ =>
                                                       {
                                                       this
                                                       .BusinessServices()
                                                       .Tracking
                                                       .GetTrackedArtists("DavidMelo", Page)
                                                       .Item2
                                                       .ToList()
                                                       .ForEach(element => 
                                                            {
                                                                if (TrackedArtists.Select(e => e.Key).Contains(element.Key))
                                                                {
                                                                    ReorganizeGroups(element);
                                                                }
                                                                else
                                                                {
                                                                    ExecuteOnDispatcher(() =>
                                                                       TrackedArtists.Add(element));
                                                                }      
                                                            });
                                                           this.ExecuteOnDispatcher(()=>
                                                              this.Services().Notifications.ClearProgressIndicator());
                                                            
                                                       });
                                               });
        }

        private void ReorganizeGroups(WGGrouping<char,Artist> element )
        {
            var oldArtists = TrackedArtists.Where(e => e.Key == element.Key).SelectMany(g => g.ToList()).ToList();
            var newArtists = element.ToList();
            oldArtists.AddRange(newArtists);
            var group =
                TrackedArtists.Single(
                    e => e.Key == element.Key);
            var groupindex = TrackedArtists.IndexOf(group);
            group.Group = oldArtists
                .GroupBy(a => a.DisplayName.ToLower().First())
                .Select(groups => new WGGrouping<char, Artist>(groups)).Single();
            ExecuteOnDispatcher(() =>
                TrackedArtists[groupindex] = group);
        }

        public override void Charged()
        {
            
            this.Services().Notifications.SetProgress("");
            Page = 1;
            this.ExecuteAsync(_ =>
                {
                    var trackedArtists = this
                        .BusinessServices()
                        .Tracking
                        .GetTrackedArtists("DavidMelo", Page);
                    TrackedArtists = new ObservableCollection<WGGrouping<char, Artist>>(trackedArtists.Item2);
                    _totalEntries = trackedArtists.Item1;
                });    
        }
    }
}
