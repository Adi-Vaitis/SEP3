package network.clientNetwork;

import com.google.gson.Gson;
import models.Client;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import services.communication.SocketClient;
import network.utility.NetworkPackage;
import network.utility.NetworkType;

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

  @Override public String createClientAccount(Client client)
  {
    Gson gson = new Gson();
    String serializedClient = gson.toJson(client);
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.REGISTER, serializedClient);
    return socketClient.communicate(networkPackage);
  }

  @Override public String editClientAccount(Client client)
  {
    return null;
  }

  @Override public void deleteClient(int clientId)
  {

  }

  @Override public Client getClientByUsername(String username)
  {
    return null;
  }

  @Override public Client getClientById(int clientId)
  {
    return null;
  }

}
