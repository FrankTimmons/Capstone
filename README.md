# Iai

## Description
This will be an online multiplayer versus game where you can compete with your friends to see who's the best!

## Technologies Used
* C#
* Unity
* Visual Studio
* Visual Studio Code

## Acknowledgements
* The base of this project was made following [this course](https://www.udemy.com/course/unity-online-multiplayer/) on Udemy.

<!-- ABOUT THE PROJECT -->
## About The Project

Iai will be a melee focused online multiplayer versus game.  It will allow players to connect in a room and battle it out to see who is the best.  The combat will be focused around hitting eachother off of the arena similar to something like Super Smash Brothers, but in first person.  There will be a fluid movement system and a way to chain your moves together in combos.  The multiplayer will be setup using Photon, a multiplayer solution for Unity, and will allow up to 20 concurrent users with the free plan I will be using.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

* C#
* Unity
* Photon

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Installation/Prerequesites

1. Download the Unity Hub

    Click "Download Unity Hub" at this link: https://unity3d.com/get-unity/download. 

2. Download the PUN 2 asset

    Go to this [link](https://assetstore.unity.com/packages/tools/network/pun-2-free-119922) and click "Add to My Assets".  If you don't have a Unity account you will be prompted to make one. 

3. Make a Photon account and create a new app
    
    Go to the [Photon Website](https://www.photonengine.com/en-US/Photon) and click "TRY PHOTON FREE".  After making an account, go to your dashboard (link in the top right of the page), and click "CREATE A NEW APP".  The only setting you need to change here is the Photon Type.  Change it to PUN. 

    You will be taken back to your dashboard and will see a box with your project.  In the middle you will have an "AppId", keep that handy and don't share it with anyone!

4. Clone the repo
   ```sh
   git clone https://github.com/FrankTimmons/Capstone
   ```
5. Open the project

    In the Unity Hub, make sure you are logged in, and then click the Open button. Navigate to the projects directory and open the "My Project" Folder.

6. Import the Photon Assets

    Once you have the Unity editor open, click the Window tab in the top left and open the Package Manager.  In the top left of the Package Manager window, there will be a "Packages: **** " dropdown.  Make sure to select "My Assets".  Once you are looking at your assets find "PUN 2 - FREE" and click download, then import.  In the import menu, you will see a ton of folders and files.  There will be a couple we want to skip.

    In the PhotonChat, PhotonRealtime, and PhotonUnityNetworking folders, there will be a subfolder called "Demos".  Uncheck all 3 of the demo folders and click import. (Some other files will automatically be unchecked because they are not in the project)

7. Use your photon AppId

    Once you have imported the assets, navigate to the PhotonServerSettings file in Unity:  
    <pre>
    Assets  
    └── Photon  
        └── PhotonUnityNetworking
            └── Resources
                └── PhotonServerSettings </pre>
    Open this file in the inspector by left clicking it, and add your Photon AppId in the App Id PUN field. 

8. Run the project
    
    Ctrl+S to save all your changes, then click "file - build and run" in the top left of the project window. Congrats! You're running the project!

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Roadmap

- [ ] Complete Course
- [ ] Refactor for melee combat
- [ ] Add custom assets (3D models, animations, maps, audio)
- [ ] Publish to Itch.io

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

Frank Timmons - [LinkedIn](https://www.linkedin.com/in/frank-timmons-pdx/) - franktimmonspdx@gmail.com

Project Link: [https://github.com/FrankTimmons/Capstone](https://github.com/FrankTimmons/Capstone)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Course I followed to build out the base of my game.](https://www.udemy.com/course/unity-online-multiplayer/)

## License

[MIT](/LICENSE)

<p align="right">(<a href="#readme-top">back to top</a>)</p>