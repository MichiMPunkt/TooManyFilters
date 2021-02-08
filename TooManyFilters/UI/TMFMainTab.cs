using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.ViewControllers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace TooManyFilters.UI
{
    internal class TMFMainTab : NotifiableSingleton<TMFMainTab>
    {
        // For this method of setting the ResourceName, this class must be the first class in the file.
        public static string ResourceName => string.Join(".", instance.GetType().Namespace, instance.GetType().Name);
    }
}
