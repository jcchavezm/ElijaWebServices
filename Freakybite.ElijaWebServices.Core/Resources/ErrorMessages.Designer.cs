﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34003
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Freakybite.ElijaWebServices.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Freakybite.ElijaWebServices.Core.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a Something went wrong, please try again later..
        /// </summary>
        public static string ErrorMessage {
            get {
                return ResourceManager.GetString("ErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The user token is not valid..
        /// </summary>
        public static string InvalidUserToken {
            get {
                return ResourceManager.GetString("InvalidUserToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a User cannot be null..
        /// </summary>
        public static string NullUserError {
            get {
                return ResourceManager.GetString("NullUserError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The user token is missing..
        /// </summary>
        public static string UserTokenMissing {
            get {
                return ResourceManager.GetString("UserTokenMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The date of birth has a wrong format..
        /// </summary>
        public static string WrongDateOfBirthFormat {
            get {
                return ResourceManager.GetString("WrongDateOfBirthFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a The registration date has a wrong format..
        /// </summary>
        public static string WrongRegistrationDateFormat {
            get {
                return ResourceManager.GetString("WrongRegistrationDateFormat", resourceCulture);
            }
        }
    }
}
