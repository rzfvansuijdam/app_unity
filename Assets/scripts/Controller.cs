using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class Controller : MonoBehaviour
{
    public PluxDeviceManager PluxDevManager;
    public List<int> ActiveChannels;
    public List<string> ListDevices;
    public int samplingRate;
    public int resolution = 8;
    float valueChannel1, valueChannel2;
    public Line lineEcg;
    public GameObject connectionText;

    [System.NonSerialized]
    public List<string> domains = new List<string>() { "BTH" };

    // Start is called before the first frame update
    void Start()
    {
        StartConnection();
    }

    public void StartConnection()
    {
        // Welcome Message, showing that the communication between C++ dll and Unity was established correctly.
        PluxDevManager = new PluxDeviceManager(ScanResults, ConnectionDone, AcquisitionStarted, OnDataReceived, OnEventDetected, OnExceptionRaised);
        int welcomeNumber = PluxDevManager.WelcomeFunctionUnity();
        Debug.Log("Connection between C++ Interface and Unity established with success !\n");
        Debug.Log("Welcome Number: " + welcomeNumber);

        // Initialization of Variables.      
        ActiveChannels = new List<int>();
        // valueChannel1 = 0f;
        // valueChannel2 = 0f;
        ScanFunction();
    }
    // Callback invoked once the connection with a PLUX device was established.
    // connectionStatus -> A boolean flag stating if the connection was established with success (true) or not (false).
    public void ConnectionDone(bool connectionStatus)
    {
        if (connectionStatus)
        {
            print("connectionstatus " + connectionStatus);
        }
        else
        {
            print("connectionstatus " + connectionStatus);
        }
    }

    // Method called when the "Scan for Devices" button is pressed.
    public void ScanFunction()
    {
        // Search for PLUX devices
        PluxDevManager.GetDetectableDevicesUnity(domains);
        print(domains);
    }

    // Callback invoked every time an exception is raised in the PLUX API Plugin.
    // exceptionCode -> ID number of the exception to be raised.
    // exceptionDescription -> Descriptive message about the exception.
    public void OnExceptionRaised(int exceptionCode, string exceptionDescription)
    {
        if (PluxDevManager.IsAcquisitionInProgress())
        {
            print(exceptionCode + " " + exceptionDescription);
        }
    }

    // Callback that receives the events raised from the PLUX devices that are streaming real-time data.
    // pluxEvent -> Event object raised by the PLUX API.
    public void OnEventDetected(PluxDeviceManager.PluxEvent pluxEvent)
    {
        if (pluxEvent is PluxDeviceManager.PluxDisconnectEvent)
        {
            // Present an error message.
            print("kaput");

            // Securely stop the real-time acquisition.
            PluxDevManager.StopAcquisitionUnity(-1);

        }
        else if (pluxEvent is PluxDeviceManager.PluxDigInUpdateEvent)
        {
            PluxDeviceManager.PluxDigInUpdateEvent digInEvent = (pluxEvent as PluxDeviceManager.PluxDigInUpdateEvent);
            Console.WriteLine("Digital Input Update Event Detected on channel " + digInEvent.channel + ". Current state: " + digInEvent.state);
        }
    }


    public void AcquisitionStarted(bool acquisitionStatus, bool exceptionRaised = false, string exceptionMessage = "")
    {
        if (acquisitionStatus)
        {
            // Enable the "Stop Acquisition" button and disable the "Start Acquisition" button.
            //enabaled acq 
        }
        else
        {
            //failed acq
        }
    }

    // Callback that receives the data acquired from the PLUX devices that are streaming real-time data.
    // nSeq -> Number of sequence identifying the number of the current package of data.
    // data -> Package of data containing the RAW data samples collected from each active channel ([sample_first_active_channel, sample_second_active_channel,...]).
    public void OnDataReceived(int nSeq, int[] data)
    {
        // Show samples with a 1s interval.
        if (nSeq % samplingRate == 0)
        {
            // Show the current package of data.
            string outputString = "Acquired Data:\n";
            for (int j = 0; j < data.Length; j++)
            {
                outputString += data[j] + "\t";
            }

        }
    }

    // Callback that receives the list of PLUX devices found during the Bluetooth scan.
    public void ScanResults(List<string> listDevices)
    {
        if (listDevices.Count > 0)
        {
            // Show an informative message about the number of detected devices.
            print("Scan completed.\nNumber of devices found: " + listDevices.Count);
        }
        else
        {
            // Show an informative message stating the none devices were found.
            print("Bluetooth device scan didn't found any valid devices.");
        }
    }
}
