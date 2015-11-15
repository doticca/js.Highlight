using System;
using System.Collections.Generic;
using System.Linq;
using Orchard;
using Orchard.Caching;
using Orchard.Environment.Extensions;
using Orchard.MediaLibrary.Services;
using js.Highlight.Models;

namespace js.Highlight.Services
{
    public interface IHighlightService : IDependency
    {
        string GetStyle();
        bool GetAutoEnable();
        bool GetAutoEnableAdmin();
        bool GetFullBundle();
    }

    public class HighlightService : IHighlightService
    {
        private readonly IWorkContextAccessor _wca;
        private readonly ICacheManager _cacheManager;
        private readonly ISignals _signals;
        private readonly IMediaLibraryService _mediaService;

        private const string ScriptsFolder = "scripts";

        public HighlightService(IWorkContextAccessor wca, ICacheManager cacheManager, ISignals signals, IMediaLibraryService mediaService)
        {
            _wca = wca;
            _cacheManager = cacheManager;
            _signals = signals;
            _mediaService = mediaService;
        }

        public string GetStyle()
        {
            return _cacheManager.Get(
                "js.Highlight.Style",
                ctx =>
                {
                    ctx.Monitor(_signals.When("js.Highlight.Changed"));
                    WorkContext workContext = _wca.GetContext();
                    var highlightSettings =
                        (HighlightSettingsPart)workContext
                                                  .CurrentSite
                                                  .ContentItem
                                                  .Get(typeof(HighlightSettingsPart));
                    return highlightSettings.Style;
                });
        }
        public bool GetAutoEnable()
        {
            return _cacheManager.Get(
                "js.Highlight.AutoEnable",
                ctx =>
                {
                    ctx.Monitor(_signals.When("js.Highlight.Changed"));
                    WorkContext workContext = _wca.GetContext();
                    var highlightSettings =
                        (HighlightSettingsPart)workContext
                                                  .CurrentSite
                                                  .ContentItem
                                                  .Get(typeof(HighlightSettingsPart));
                    return highlightSettings.AutoEnable;
                });
        }

        public bool GetAutoEnableAdmin()
        {
            return _cacheManager.Get(
                "js.Highlight.AutoEnableAdmin",
                ctx =>
                {
                    ctx.Monitor(_signals.When("js.Highlight.Changed"));
                    WorkContext workContext = _wca.GetContext();
                    var highlightSettings =
                        (HighlightSettingsPart)workContext
                                                  .CurrentSite
                                                  .ContentItem
                                                  .Get(typeof(HighlightSettingsPart));
                    return highlightSettings.AutoEnableAdmin;
                });
        }

        public bool GetFullBundle()
        {
            return _cacheManager.Get(
                "js.Highlight.FullBundle",
                ctx =>
                {
                    ctx.Monitor(_signals.When("js.Highlight.Changed"));
                    WorkContext workContext = _wca.GetContext();
                    var highlightSettings =
                        (HighlightSettingsPart)workContext
                                                  .CurrentSite
                                                  .ContentItem
                                                  .Get(typeof(HighlightSettingsPart));
                    return highlightSettings.FullBundle;
                });
        }

    }
}