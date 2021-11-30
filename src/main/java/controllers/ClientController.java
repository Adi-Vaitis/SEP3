package controllers;

import models.Client;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import services.client.IClientService;

@RestController
public class ClientController
{
  @Autowired IClientService service;

  @PostMapping("/login")
  public Client getClient(@RequestBody Client client){
    return service.validateClient(client.getUsername(), client.getPassword());
  }

}