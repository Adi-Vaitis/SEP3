package network.clientNetwork;

import com.google.gson.Gson;
import models.Client;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import services.communication.SocketClient;
import services.utility.NetworkPackage;
import services.utility.NetworkType;

@Component
public class ClientAccountImpl implements ClientAccount
{
  @Autowired SocketClient socketClient;

  @Override public Client validateClient(String Username, String Password)
  {
    Gson gson = new Gson();
    Client client = new Client();
    client.setUsername(Username);
    client.setPassword(Password);
    String serializedAccount = gson.toJson(client);
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.LOGIN, serializedAccount);
    String input = socketClient.communicate(networkPackage);
    return gson.fromJson(input, Client.class);
  }
}
