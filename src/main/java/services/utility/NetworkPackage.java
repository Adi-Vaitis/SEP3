package services.utility;

import com.fasterxml.jackson.annotation.JsonProperty;

public class NetworkPackage
{
  @JsonProperty
  private NetworkType type;
  @JsonProperty
  private String content;

  public NetworkPackage(NetworkType type, String content) {
    this.type = type;
    this.content = content;
  }

  public NetworkType getType() {
    return type;
  }

  public String getContent() {
    return content;
  }

  @Override
  public String toString() {
    return "NetworkPackage{" + "type=" + type + ", content=" + content + '}';
  }
}
