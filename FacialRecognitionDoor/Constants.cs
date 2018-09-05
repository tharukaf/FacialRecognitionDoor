namespace FacialRecognitionDoor
{
    /// <summary>
    /// General constant variables
    /// </summary>
    public static class GeneralConstants
    {
        // This variable should be set to false for devices, unlike the Raspberry Pi, that have GPU support
        public const bool DisableLiveCameraFeed = false;

        // Oxford Face API Primary should be entered here
        // Link to obtain the subscription key for Face API: https://azure.microsoft.com/en-us/try/cognitive-services/
        public const string OxfordAPIKey = "108d66b600504cfba89a1c15837f20d6";

        // Enter the API endpoint address.
        // If you have a 'free trial' key, you can find the here: https://azure.microsoft.com/en-us/try/cognitive-services/my-apis/
        // If you have a key from Azure, find your account here: https://portal.azure.com/#blade/HubsExtension/Resources/resourceType/Microsoft.CognitiveServices%2Faccounts.
        public const string FaceAPIEndpoint = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0";

        // Name of the folder in which all Whitelist data is stored
        public const string WhiteListFolderName = "Facial Recognition Door Whitelist";

    }

    /// <summary>
    /// Constant variables that hold messages to be read via the SpeechHelper class
    /// </summary>
    public static class SpeechContants
    {
        public const string InitialGreetingMessage = "Welcome to Team beholder's Facial Recognition door";

        public const string VisitorNotRecognizedMessage = "Welcome Visitor";
        public const string NoCameraMessage = "Sorry! It seems like your camera has not been fully initialized.";

        public static string GeneralGreetigMessage(string visitorName)
        {
            return "Welcome  " + visitorName;
        }
    }

    /// <summary>
    /// Constant variables that hold values used to interact with device Gpio
    /// </summary>
    public static class GpioConstants
    {
        // The GPIO pin that the doorbell button is attached to
        public const int ButtonPinID = 5;

        // The GPIO pin that the door lock is attached to
        public const int DoorLockPinID = 4;

        // The amount of time in seconds that the door will remain unlocked for
        public const int DoorLockOpenDurationSeconds = 10;
    }
}
