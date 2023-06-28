# Medical Office Management
Medical Office is a UWP application to consume this [Medical Office API](https://medicalofficewebapi.azurewebsites.net/). It is a good start to have a better understanding on how to consume an API.

## Installation
- Clone your this repository.
- Add your scripts.
- Have fun. :smiley:

## Usage
Just run the application, the connection with the API is already in place. Important, you may need to wait a minute or two the first time you run the application to allow the API 'to activate' again.
<div>
    Home  
</div>
<img src="https://github.com/NicolasKeidong/MedicalOfficeUWP_Solution/assets/122652469/d8bb1ce8-bde3-4f95-bc08-2c1c304b4bd3" width="450" height="450">
<div>
  Add a new patient
</div>
<img src="https://github.com/NicolasKeidong/MedicalOfficeUWP_Solution/assets/122652469/ae4eb981-f6cf-4fb3-95e3-0de4585d94c5" width="450" height="450">

Note: If you want to use this UWP app as a base file to consume a different API(locally or online), just comment out the line of code located in Jeeves file(Utilities/Jeeves), you are going to have to modify the logic and Models as well.

``` C#
//Local
public static Uri DBUri = new Uri("https://localhost:yourport#here/");
//Online
public static Uri DBUri = new Uri("https://medicalofficewebapi.azurewebsites.net");
```

## Additional notes
At the moment, I don't have future plans for this project which is why there is no guide on how to contribute to this project, but if I change my mind I will update this file, thank you for your understanding.
I hope that this small project helps you in your learning process, keep coding, you got this! :muscle:

Lastly, the credits of the background image used in this app correspond to [Martha Dominguez de Gouveia](https://unsplash.com/photos/nMyM7fxpokE) 
