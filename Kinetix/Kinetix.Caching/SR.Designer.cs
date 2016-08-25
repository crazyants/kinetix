﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kinetix.Caching {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kinetix.Caching.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à {0}Cache: Exception {1}.
        /// </summary>
        public static string DebugException {
            get {
                return ResourceManager.GetString("DebugException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à {0}Cache: Could not create disk store. Initial cause was {1}.
        /// </summary>
        public static string ErrorCouldNotCreateStore {
            get {
                return ResourceManager.GetString("ErrorCouldNotCreateStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à {0}Cache: Could not expire elements from disk due to {1}. Continuing....
        /// </summary>
        public static string ErrorCouldNotExpireElements {
            get {
                return ResourceManager.GetString("ErrorCouldNotExpireElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à {0}Cache: Could not flush elements to disk due to {1}. Continuing....
        /// </summary>
        public static string ErrorCouldNotFlushElements {
            get {
                return ResourceManager.GetString("ErrorCouldNotFlushElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à {0}Cache: Could not shut down disk cache. Initial cause was {1}.
        /// </summary>
        public static string ErrorCouldNotShutdownStore {
            get {
                return ResourceManager.GetString("ErrorCouldNotShutdownStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à The {0} Cache is not alive..
        /// </summary>
        public static string ExceptionCacheNotAlive {
            get {
                return ResourceManager.GetString("ExceptionCacheNotAlive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Cannot initialise the {0} cache because its status is not UNINITIALISED..
        /// </summary>
        public static string ExceptionCannotInitialise {
            get {
                return ResourceManager.GetString("ExceptionCannotInitialise", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Could not create cache directory {0}..
        /// </summary>
        public static string ExceptionCouldNotCreateDirectory {
            get {
                return ResourceManager.GetString("ExceptionCouldNotCreateDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Index file {0} could not created..
        /// </summary>
        public static string ExceptionCouldNotCreateIndex {
            get {
                return ResourceManager.GetString("ExceptionCouldNotCreateIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Store directory {0} exists and is not a directory..
        /// </summary>
        public static string ExceptionStoreDirectoryIsFile {
            get {
                return ResourceManager.GetString("ExceptionStoreDirectoryIsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Cache: {0} has a maxElementsInMemory of 0. It is strongly recommended to have a maximumSize of at least 1. Performance is halved by not using a MemoryStore..
        /// </summary>
        public static string WarnZeroMemoryStoreSize {
            get {
                return ResourceManager.GetString("WarnZeroMemoryStoreSize", resourceCulture);
            }
        }
    }
}