package services.client;

import models.Client;

public interface IClientService
{
  Client validateClient(String Username, String Password);
}
