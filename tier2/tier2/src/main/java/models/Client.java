package models;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Client
{
  @JsonProperty
  private int id;
  @JsonProperty
  private String username;
  @JsonProperty
  private String password;
  @JsonProperty
  private String email;
  @JsonProperty
  private String name;
  @JsonProperty
  private String phoneNumber;
  @JsonProperty
  private String country;

  public Client()
  {
  }

  public String getUsername()
  {
    return username;
  }

  public String getPassword()
  {
    return password;
  }

  public void setUsername(String username)
  {
    this.username = username;
  }

  public void setPassword(String password)
  {
    this.password = password;
  }

  @Override public String toString() {
    return "id=" + id + ", name='" + name + '\'' + ", username='" + username + '\'' + ", password='" + password + '\'';
  }
}
