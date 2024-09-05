<?php
function alarm_message($message) {
    $alarm = 'http://t69.me';
    $key = '71b6ffb3-7cff-403e-a2f7-15e3d919f1e1';

    $data = json_encode(['key' => $key, 'message' => $message]);

    $options = [
        'http' => [
            'header'  => "Content-Type: application/json\r\n",
            'method'  => 'POST',
            'content' => $data,
        ]
    ];

    $context  = stream_context_create($options);
    $response = file_get_contents($alarm, false, $context);

    if ($response === FALSE) {
        error_log("Alarm request failed");
    } else {
        echo "Alarm sent successfully";
    }
}

alarm_message("😀 Hello World");
?>
