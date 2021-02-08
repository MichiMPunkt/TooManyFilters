using IPA;
using IPA.Config;
using IPA.Config.Stores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

using BS_Utils.Utilities;
using BeatSaberMarkupLanguage;
using HMUI;
using UnityEngine.UI;
using System.Reflection;
using BeatSaberMarkupLanguage.GameplaySetup;
using System.ComponentModel;
using SiraUtil.Zenject;
using TooManyFilters.UI;

namespace TooManyFilters
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        /// <summary>
        /// Called when the plugin is first loaded by IPA (either when the game starts or when the plugin is enabled if it starts disabled).
        /// [Init] methods that use a Constructor or called before regular methods like InitWithConfig.
        /// Only use [Init] with one Constructor.
        /// </summary>
        public void Init(Zenjector zenjector)
        {
            Instance = this;
            zenjector.OnMenu<TMFMenuInstaller>();
        }

        #region BSIPA Config
        //Uncomment to use BSIPA's config
        /*
        [Init]
        public void InitWithConfig(Config conf)
        {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
            Log.Debug("Config loaded");
        }
        */
        #endregion

        [OnStart]
        public void OnApplicationStart()
        {
            new GameObject("TooManyFiltersController").AddComponent<TooManyFiltersController>();

            
            GameplaySetup.instance.AddTab("Too Many Filters", TMFMainTab.ResourceName, TMFMainTab.instance, MenuType.Solo); 

            BSEvents.OnLoad();
            BSEvents.lateMenuSceneLoadedFresh += CreateTMFUI;
        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }

        private void CreateTMFUI(ScenesTransitionSetupDataSO data)
        {

        }

    }

}

