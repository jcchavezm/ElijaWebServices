﻿using System.ServiceModel;
using System.ServiceModel.Web;
using Freakybite.ElijaWebServices.Entities.DataContracts;

namespace Freakybite.ElijaWebServices.RestServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IElijaWebServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IElijaWebServices
    {
        #region Public Methods and Operators

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "UserRegistration/")]
        Result UserRegistration(UserDeviceModel userDevice);

        #endregion
    }
}