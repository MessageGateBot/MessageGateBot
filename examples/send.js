const axios = require('axios');

async function alarmMessage(message) {
    const alarm = 'http://t69.me';
    const key = '71b6ffb3-7cff-403e-a2f7-15e3d919f1e1';

    try {
        const response = await axios.post(alarm, {
            key: key,
            message: message
        });

        if (response.status !== 200) {
            console.error(`Alarm request failed with status ${response.status}: ${response.data}`);
        } else {
            console.log("Alarm sent successfully");
        }
    } catch (error) {
        console.error(`Alarm error for ${key}: ${error}`);
    }
}

alarmMessage("😀 Hello World");
