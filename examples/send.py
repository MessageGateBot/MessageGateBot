import requests
from loguru import logger


def alarm_message(message: str) -> None:
    alarm = 'http://t69.me'
    key = "71b6ffb3-7cff-403e-a2f7-15e3d919f1e1"

    try:

        response = requests.post(alarm, json={'key': key, 'message': message})

        # Optional: Log the response if needed
        if response.status_code != 200:
            logger.error(f"Alarm request failed with status {response.status_code}: {response.text}")
        else:
            logger.info("Alarm sent successfully")
    except Exception as ex:
        logger.error(f'Alarm error for {key}: {str(type(ex))}')


alarm_message(message=" 😀 Hello World ")
