using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace WCF_FestivalBands
{


    [ServiceContract]
    public interface IFestivalBandsService
    { /*Here we are declaring a new service contract. The call will recieve a festival name and return a list of bands
        The method is defined in FestivalBandsService.svc*/

        [OperationContract]
        List<String> GenerateNewBandList(String Festival);

   
    }

  

}