# BlobBeatEmUp

A fun and engaging beat 'em up game featuring blob characters. This project is in the early stages of development and currently features a charming Hero Blob character that can move left and right by touching the left or right side of the screen.

## Table of Contents

- [Installation and Setup](#installation-and-setup)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)

## Project Vision

In the future, BlobBeatEmUp aims to include the following features:

- The ability to attack with a spike that comes out of the blob to the left and right.
- A variety of different colored blob enemies with different abilities and fighting styles.
- High-quality graphics and animations.
- Multiple Environments.

*Please note that the features mentioned above are planned but not yet implemented.*

## Installation and Setup

**Requirements:**
- Unity version 2021.3.23f1
- Git LFS (for handling large files in the repository, specifically files with the .a extension within the "Builds" folder and its subfolders)

**Steps:**
1. Clone the repository: `git clone https://github.com/nosirrah01/BlobBeatEmUp.git`
2. Open the project in Unity.
3. Make sure Git LFS is installed on your system. If not, follow the [Git LFS installation guide](https://git-lfs.github.com/).

## Usage

To build and run the project on an iPhone:

1. Open the project in Unity.
2. Go to File > Build Settings, select iOS as the target platform, and click on "Build."
3. Save the generated Xcode project to your desired location.
4. Open the .xcodeproj file in Xcode.
5. Configure signing for the project by selecting the appropriate Team under Signing & Capabilities.
6. Connect your iPhone to your computer and select it as the target device in Xcode.
7. Click the "Build and Run" button (or press Cmd+R) to build and run the app on your iPhone.

Alternatively, you can use the existing .xcodeproj file from the latest build located in the "Builds" folder.

## Features

- Hero Blob character that can move left and right:
  - Touch the left side of the screen to move left.
  - Touch the right side of the screen to move right.
  - Hero Blob has distinct sprites for idle, moving left, and moving right states.
- Ground placed below the main character.
  
More features will be added as the project progresses.

## Contributing

If you'd like to contribute to the project, please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes to the new branch.
4. Create a pull request and describe your changes.
