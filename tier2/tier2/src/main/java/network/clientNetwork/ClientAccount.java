package network.clientNetwork;

import models.Client;

public interface ClientAccount
{
  Client validateClient(String username, String password);
}
