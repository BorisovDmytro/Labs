﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace lab4mongo.Entities
{
  public class MongoEntity : IMongoEntity
  {
    [BsonId]
    public ObjectId Id { get; set; }
  }
}
