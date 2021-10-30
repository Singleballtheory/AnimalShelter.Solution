# The Dog and Dragon Animal Shelter

#### A pet shelter plus a whole lot more

#### By Scott Hutley

## Technologies Used

* _C#_
* _.Net 5.0_
* _.Net ef_
* _ASP.NET Core_
* _NuGet_
* _Swagger_

## Description

This seeded API is configured to run with Swagger which allows users to Get, Post, Put and Delete animals that the shelter without the need for a front-end webpage. Users can access data in several ways that will be helpful in narrowing down the creature they are interested in.

## Setup/Installation

#### Technology Requirements

* .NET 5
* VS Code or other text editor
* MySQL Workbench

#### Cloning and Database Creation

* Clone this repository to your desktop
* Open with text editor and navigate into AnimalShelter.Solution/AnimalShelter folder
* Create an appsettings.json file
* Add the following code to the appsettings.json:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* Replace "YOUR_PASSWORD" in the above code with your own personal MySql password
* Open a Windows Powershell terminal (or Mac equivalent)
* In that terminal run *mysql -uroot -p<YOUR_PASSWORD>* (again, replacing with your actual password)
* Open MySQL Workbench
* Return to your text editor
* Navigate to the AnimalShelter.Solution/AnimalShelter folder level (if you are not already there)
* Run *dotnet restore*
* Run *dotnet build*
* Run *dotnet ef database update*
* Run *dotnet run*
* Enter http://localhost:5000 into your web browser to bring up the Animal Shelter API with Swagger

## How To Use Swagger

Swagger allows us to visualize our API endpoints without any implementation logic in place. To use any of the Swagger functions (GET, POST, PUT, DELETE) click on the respective button then click on the "Try it out" button.

## API Endpoints

Base URL: http://localhost:5000

GET requests:

For complete list of creatures:   /api/Creatures

To find creatures by name:   /api/Creatures?name="Name"

To find creatures by spieces:    /api/Creatures?spieces="Spieces"

To find creatures by mythical:   /api/Creatures?mythical="yes/no"

To find a creature by ID number:   /api/Creatures/{id} where {id} is the ID of the creature being searched for


POST requests:

Format POST requests in the following way:
```
{
  "creatureId": {id},
  "name": "string",
  "spieces": "string",
  "mythical": "string",
  "description": "string",
  "image": "url string"
  "age: number
}
```

Note that quotations are required around each string entry. Example, to enter a creature named Scott, the entry needs to be "Scott".

In addition, while creatureId needs to be entered (it's default is 0), you must enter an Id number that does not already exist.


PUT requests:

To edit a single creature:   /api/Creatures/{id} where {id} is the ID of the creature to edit.
Request body must be formatted as following:
```
{
  "creatureId": {id},
  "name": "string",
  "spieces": "string",
  "mythical": "yes/no",
  "description": "string",
  "image": "url string"
  "age: number
}
```

DELETE requests:
To delete a single creature:   /api/Creatures/{id} where {id} is the ID of the creature to delete.


## Known Bugs

* No known bugs at this time

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Scott Hutley

## Contact Information

Scott Hutley: scotthutley1@comcast.net
