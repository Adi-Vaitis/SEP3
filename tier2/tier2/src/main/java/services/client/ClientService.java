package services.client;

import models.Client;
import network.clientNetwork.ClientAccount;
import org.springframework.stereotype.Service;

@Service
public class ClientService implements IClientService
{
  private ClientAccount clientAccount;

  public ClientService(ClientAccount clientAccount){
    this.clientAccount = clientAccount;
  }

  @Override public Client validateClient(String Username, String Password)
  {
    return clientAccount.validateClient(Username, Password);
  }
}
