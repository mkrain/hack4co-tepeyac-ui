﻿using MongoDB.Bson.Serialization.Attributes;

namespace Clinical.API.Models
{
    public class Event : Entity
    {
        [BsonIgnoreIfNull]
        public string GoalId { get; set; }

        [BsonIgnoreIfNull]
        public string Description { get; set; }

        [BsonIgnoreIfNull]
        public string Status { get; set; }
    }
}