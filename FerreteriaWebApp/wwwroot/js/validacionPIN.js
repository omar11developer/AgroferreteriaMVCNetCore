$(document).ready(function () {
    const $pinInput = $('#pin');
    const $confirmPinInput = $('#confirm-pin');
    const $errorIcon = $('#error-icon');
    const $successIcon = $('#success-icon');
    const $errorMessage = $('#pin-error-message');
    const $submitButton = $('#submit-btn');

   
    function validatePins() {
        if ($pinInput.val() != "") {
            if ($confirmPinInput.val() === $pinInput.val() || $pinInput.val() === $confirmPinInput.val()) {
                $successIcon.removeClass('visually-hidden');
                $errorIcon.addClass('visually-hidden');
                $errorMessage.addClass('visually-hidden');
                $submitButton.prop('disabled', false);
            } else {
                $successIcon.addClass('visually-hidden');
                $errorIcon.removeClass('visually-hidden');
                $errorMessage.removeClass('visually-hidden');
                $submitButton.prop('disabled', true);
            }
        }       
        }

       
   
    $confirmPinInput.on('input', validatePins);
    $pinInput.on('input', validatePins);
});