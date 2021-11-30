package network.clientNetwork;

import models.Client;

public interface ClientAccount
{
  Client validateClient(String username, String password);

  String createClientAccount(Client client);

  String editClientAccount(Client client);

  void deleteClient(int clientId);

  Client getClientByUsername(String username);

  Client getClientById(int clientId);

}
