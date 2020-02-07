using DemoTest.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoTest.Core
{
    public class UserMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Uid { get; set; }

        [NotMapped]
        public UserMetaDataModel UserMetaDataModel { get; set; }

        [Column("userMetaData")]
        public string UserMetaData
        {
            get
            {
                return JsonConvert.SerializeObject(UserMetaDataModel);
            }
            set
            {
                UserMetaDataModel = string.IsNullOrEmpty(value)
                        ? new UserMetaDataModel()
                        : JsonConvert.DeserializeObject<UserMetaDataModel>(value);
            }
        }

        public User User { get; set; }
    }
}

