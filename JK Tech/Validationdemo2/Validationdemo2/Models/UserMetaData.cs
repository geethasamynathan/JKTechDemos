using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Validationdemo2.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    { }

    public class UserMetaData
    {
        [Remote("IsUserNameAvailable","Users",ErrorMessage =" Username  is already in use")]
        public string UserName { get; set; }

    }
}