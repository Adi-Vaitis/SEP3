package services.communication;

import services.utility.NetworkPackage;

public interface SocketClient
{
  void startClient();
  String communicate(NetworkPackage networkPackage);
  void disconnect();
}
