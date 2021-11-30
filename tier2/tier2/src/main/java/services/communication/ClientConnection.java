package services.communication;

import com.google.gson.Gson;
import network.utility.NetworkPackage;
import network.utility.NetworkType;

import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;

@org.springframework.stereotype.Component
public class ClientConnection implements SocketClient
{

  @Override public void startClient()
  {
    try{
      new Thread(() -> communicate(new NetworkPackage(NetworkType.CONNECTION, "conFromTier2"))).start();
    }
    catch ( Exception e ){
      e.printStackTrace();
    }
  }

  @Override public String communicate(NetworkPackage networkPackage)
  {
    try {
      Gson gson = new Gson();
      Socket socket = new Socket("localhost", 2525);
      OutputStream out = socket.getOutputStream();
      InputStream in = socket.getInputStream();
      String request = gson.toJson(networkPackage);
      byte[] requestBytes = request.getBytes();
      out.write(requestBytes);

      byte[] data = new byte[1024 * 1024];
      int count = in.read(data);
      String string = new String(data);
      String updatedString = "";
      for(int i=0;i<string.length();i++)
      {
        if(string.charAt(i) == 0)
        {
          break;
        }
        updatedString += string.charAt(i);
      }

      if(!updatedString.equals("Tier3")) {
        return updatedString;
      }
      else System.out.println("Client connection problem");
    } catch (Exception e) {
      e.printStackTrace();
    }
    return null;
  }

  @Override public void disconnect()
  {
    try{

    } catch ( Exception e ){
      e.printStackTrace();
    }
  }
}
