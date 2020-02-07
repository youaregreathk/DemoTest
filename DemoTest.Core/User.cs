using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoTest.Core
{
    public class User
    {
        public User()
        {}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Uid { get; set; }

        public Guid UserMetadataCorrelationId { get; set; }

        public UserMetadata UserMetadata { get; set; }

    }
}
