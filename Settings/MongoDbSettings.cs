namespace Catalog.Settings
{    
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        //Deploy mongodb to docker by using following command.
        //docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD={password} mongo
        public string ConnectionString
        {
            get
            {
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
            }
        }
    }
}