# MessageGateBot API Service

Welcome to the **MessageGateBot** API service! This bot allows users to send messages to a specific Telegram chat or group using a simple RESTful API. Whether you want to automate alerts, notifications, or any other kind of messaging, MessageGateBot provides an easy-to-use interface to deliver your messages seamlessly to Telegram.

## Features
- **Easy API integration**: Use standard HTTP POST requests to send messages to Telegram.
- **Key management**: Retrieve and manage your API keys directly through the bot using simple commands.
- **Reliable and secure**: Your messages are sent securely with no logging of your data, ensuring privacy and confidentiality.

## How to Get Started

### Step 1: Retrieve Your API Key
To send messages using the API, you will first need an API key. You can easily get your key by messaging the bot:

1. Open [MessageGateBot](https://t.me/MessageGateBot) on Telegram.
2. Use the command `/key` to retrieve your API key.
3. If you need a new key, you can generate one using the `/newkey` command.

### Step 2: Send Messages via API

Once you have your API key, you can send messages to Telegram using the following example code:

```python
import requests
from loguru import logger

def alarm_message(message: str) -> None:
    alarm = 'https://t69.me'
    key = "xxx-xxx-xxx-xxx"  # Replace this with your actual API key

    try:
        response = requests.post(alarm, json={'key': key, 'message': message})

        # Optional: Log the response if needed
        if response.status_code != 200:
            logger.error(f"Alarm request failed with status {response.status_code}: {response.text}")
        else:
            logger.info("Alarm sent successfully")
    except Exception as ex:
        logger.error(f'Alarm error for {key}: {str(type(ex))}')

```
## Conclusion

MessageGateBot provides a straightforward API for sending messages to Telegram. It’s perfect for integrating into scripts or applications that need to deliver alerts or notifications quickly and securely. Get started by retrieving your API key and integrating the provided example into your projects!
