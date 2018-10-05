using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace DatabaseCatalogReader
{
    [Serializable]
    public sealed class DatabaseCatalogReaderException : Exception, ISerializable
    {
        #region ISerializable

        private DatabaseCatalogReaderException(
            SerializationInfo info, StreamingContext context)
            : base(info, context) // pass on to base class
        {
            // deserialize each field
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        void ISerializable.GetObjectData(
            SerializationInfo info, StreamingContext context)
        {
            // serialize each field

            // pass on to bas class
            base.GetObjectData(info, context);
        }

        #endregion ISerializable

        #region The three standard public constructors

        public DatabaseCatalogReaderException()
            : base()
        {
        }

        public DatabaseCatalogReaderException(string message)
            : base(message)
        {
        }

        public DatabaseCatalogReaderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        #endregion The three standard public constructors
    }
}