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
    Gson gson = new Gson();
    String serializedClient = gson.toJson(client);
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.EDITACCOUNT, serializedClient);
    return socketClient.communicate(networkPackage);
  }

  @Override public void deleteClient(int clientId)
  {
    Gson gson = new Gson();
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.DELETECLIENT, String.valueOf(clientId));
    socketClient.communicate(networkPackage);
  }

  @Override public Client getClientByUsername(String username)
  {
    Gson gson = new Gson();
    Client client = new Client();
    client.setUsername(username);

    String serializedClient = gson.toJson(client);
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.GETCLIENTBYUSERNAME, serializedClient);
    String input = socketClient.communicate(networkPackage);

    return gson.fromJson(input, Client.class);
  }

  @Override public Client getClientById(int clientId)
  {
    Gson gson = new Gson();
    NetworkPackage networkPackage = new NetworkPackage(NetworkType.GETCLIENTBYID, String.valueOf(clientId));
    String input = socketClient.communicate(networkPackage);
    return gson.fromJson(input, Client.class);
  }

}
