# MixedReality-FieldOfViewFeedback

You would like to display som text in the field of view for you Windows Mixed Reality apps either Immersives or Holographics?

This project is for you!

To use it, just download the unity package from the latest [release](../../releases)

Of course, feel free to give your feedback and comments.
# How to use the Unity Package 

- In Unity 2017.4.x, use the Assets menu / Import Package / Custom Package… ; Choose the FOVFeedback.unitypackage you downloaded
- Drag & drop the FOVFeedback prefabs as a child of the camera
- Anywhere in the code, just use
`FOVFeedback.instance.ModifyText("Some text to display in the FOV");`

You are done 🎈:
Each time you use `FOVFeedback.instance.ModifyText("text")` you will display this text in the field of view.

## Tools' versions 🛠
- Visual Studio 2017 15.9
- Unity 2017.4.16f1
