package services.communication;

import network.utility.NetworkPackage;

public interface SocketClient
{
  void startClient();
  String communicate(NetworkPackage networkPackage);
  void disconnect();
}
