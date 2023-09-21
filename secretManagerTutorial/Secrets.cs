namespace secretManagerTutorial;

public class Secrets
{
    public static string FetchSecret()
    {
        // Setup the config object
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        
        // Access the ServiceApiKey secret
        var clientId = config["ServiceApiKey"];
        
        // clientId could be null since we aren't sure what's in the secret manager. Make sure to check :)
        return clientId ?? "secret not found :(";
    }
}