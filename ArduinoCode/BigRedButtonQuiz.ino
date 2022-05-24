#define PIN_BUTTON A0
#define PIN_LIGHT 9

#define PI 3.14159265359

bool _connected = false;
bool _lastButtonState = false;
bool _lightState = false;

void setup()
{
    pinMode(PIN_BUTTON, INPUT);
    pinMode(PIN_LIGHT, OUTPUT);

    Serial.begin(38400);
    _lastButtonState = readButtonState();
}

void loop()
{
    // Wait for PC to open COM port
    while (!Serial)
    {
        _connected = false;
        analogWrite(PIN_LIGHT, 32 + static_cast<int>((sin(static_cast<float>(millis()) / 1000.0f * PI) * 0.5f + 0.5f) * 192.0f));
    }

    /// Wait for initialization command from PC
    while (!_connected)
    {
        // Keep LED flashing
        unsigned long t = millis() % 1000;
        setLight(t < 100 || (200 <= t && t < 300));
        
        if (Serial.available())
        {
            String result = Serial.readStringUntil('\n');
            if (result.equals("**BRBQ*I"))
            {
                _connected = true;
                _lightState = false;
                Serial.print("ACK\n");
            }
            else
            {
                Serial.print("NAK\n");
            }
        }
    }
    
    // Connection and initialization OK...
    
    // Read button state
    bool buttonState = readButtonState();

    // Check for manual state poll, and answer
    if (Serial.available())
    {
        String result = Serial.readStringUntil('\n');
        if (result.equals("**BRBQ*S"))
        {
            Serial.print(buttonState ? "SBD\n" : "SBU\n");
        }
        else if (result.equals("**BRBQ*H"))
        {
            _lightState = true;
            Serial.print("ACK\n");
        }
        else if (result.equals("**BRBQ*L"))
        {
            _lightState = false;
            Serial.print("ACK\n");
        }
        else
        {
            Serial.print("NAK\n");
        }
    }

    // Set LED to last set state
    setLight(_lightState);
    
    // Report wire state change
    if (buttonState != _lastButtonState)
    {
        Serial.print(buttonState ? "EBD\n" : "EBU\n");
        _lastButtonState = buttonState;
    }
}

bool readButtonState()
{
    // (Reads LOW when connected, HIGH when disconnected)
    int value = analogRead(PIN_BUTTON);

    // Schmitt trigger
    if (_lastButtonState && value >= 768) return false;
    if (!_lastButtonState && value < 256) return true;
    return _lastButtonState;
}

void setLight(bool on)
{
    digitalWrite(PIN_LIGHT, on ? LOW : HIGH);
}
