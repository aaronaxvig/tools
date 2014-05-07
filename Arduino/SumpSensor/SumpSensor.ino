#include <SPI.h>
#include <Ethernet.h>

// Enter a MAC address for your controller below.
// Newer Ethernet shields have a MAC address printed on a sticker on the shield
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
IPAddress server(10,10,1,54);  

// Initialize the Ethernet client library
// with the IP address and port of the server 
// that you want to connect to (port 80 is default for HTTP):
EthernetClient client;

int sensorPin = A0;
int sensorValue = 0;

void setup() {
  Serial.begin(9600);
   while (!Serial) {
  }

  if (Ethernet.begin(mac) == 0) {
    Serial.println("Failed to configure Ethernet using DHCP");
    // no point in carrying on, so do nothing forevermore:
  }
  delay(1000);
  
}

void loop()
{
  Serial.println("connecting...");

  // if you get a connection, report back via serial:
  if (client.connect(server, 80)) {
    Serial.println("connected");
    // Make a HTTP request:
    sensorValue = analogRead(sensorPin);
    Serial.println(String(((int) (sensorValue / 1.8))));
    client.println("POST /service/Sump.svc/" + String(((int) (sensorValue / 1.8))) + " HTTP/1.1");
    client.println("Host: aaron.axvig.com");
    client.println("Content-Length: 0");
    client.println("Connection: close");
    client.println();
  } 
  else {
    // kf you didn't get a connection to the server:
    Serial.println("connection failed");
  }
    
    
  // if there are incoming bytes available 
  // from the server, read them and print them:
  while (client.available()) {
    char c = client.read();
    Serial.print(c);
  }

  // if the server's disconnected, stop the client:
  if (!client.connected()) {
    Serial.println();
    Serial.println("disconnecting.");
    client.stop();

    // do nothing forevermore:
    //while(true);
  }
  delay(5000);
}

