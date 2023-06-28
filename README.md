# Medical Office Management
Medical Office is a UWP application to consume this [Medical Office API](https://medicalofficewebapi.azurewebsites.net/). It is a good start to better understand how to consume an API.

## Installation
- Clone your this repository.
- Add your scripts.
- Have fun. :smiley:

## Usage
Just run the application, the connection with the API is already in place. Important, you may need to wait a minute or two the first time you run the application to allow the API 'to activate' again.
![Home](https://github.com/NicolasKeidong/MedicalOfficeUWP_Solution/assets/122652469/53947654-1753-42bf-a47d-36d613039cd5)
![Add new Patient](https://github.com/NicolasKeidong/MedicalOfficeUWP_Solution/assets/122652469/0414d53e-3191-4ff8-9761-93867e209108)

Note: If you want to use this UWP app as a base file to consume a different API(locally or online), just comment out the line of code located in Jeeves file(Utilities/Jeeves), you are going to have to modify the logic and Models as well.

``` C#
//Local
public static Uri DBUri = new Uri("https://localhost:yourport#here/");
//Online
public static Uri DBUri = new Uri("https://medicalofficewebapi.azurewebsites.net");
```

## Additional notes
At the moment, I don't have future plans for this project, but if I change my mind I will update this file, on the other hand, if you want to contribute to it, please do, thank you.
I hope that this small project helps you in your learning process, keep coding, you got this! :muscle:

Lastly, the credits of the background image used in this app correspond to [Martha Dominguez de Gouveia](https://unsplash.com/photos/nMyM7fxpokE) 
