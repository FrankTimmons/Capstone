# Iai

## Description
This will be an online multiplayer versus game where you can compete with your friends to see who's the best!

## Technologies Used
* C#
* Unity
* Visual Studio
* Visual Studio Code

## Acknowledgements
* This was made following [this course](https://www.udemy.com/course/unity-online-multiplayer/) on Udemy.


<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <h3 align="center">IAI</h3>

  <p align="center">
    An awesome README template to jumpstart your projects!
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

There are many great README templates available on GitHub; however, I didn't find one that really suited my needs so I created this enhanced one. I want to create a README template so amazing that it'll be the last one you ever need -- I think this is it.

Here's why:
* Your time should be focused on creating something amazing. A project that solves a problem and helps others
* You shouldn't be doing the same tasks over and over like creating a README from scratch
* You should implement DRY principles to the rest of your life :smile:

Of course, no one template will serve all projects since your needs may be different. So I'll be adding more in the near future. You may also suggest changes by forking this repo and creating a pull request or opening an issue. Thanks to all the people have contributed to expanding this template!

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
    
    Ctrl+S to save all your changes

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