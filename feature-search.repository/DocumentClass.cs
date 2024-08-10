using System;

namespace feature_search.repository
{
    //public interface IDocument
    //{
    //    [BsonId]
    //    [BsonRepresentation(BsonType.String)]
    //    ObjectId Id { get; set; }

    //    DateTime CreatedAt { get; }
    //}
    //public abstract class Document : IDocument
    //{
    //    public ObjectId Id { get; set; }

    //    public DateTime CreatedAt => Id.CreationTime;
    //}

    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; }

        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
