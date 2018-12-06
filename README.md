# MixedReality-FieldOfViewFeedback

You would like to display some text in the field of view for you Windows Mixed Reality apps either Immersives or Holographics?

This project is for you!

To use it, just download the unity package from the latest [release](../../releases)

Of course, this repository gives you the source code. Feel free to give your feedback and comments.

# How to use the Unity Package 📦

- In Unity, use the Assets menu / Import Package / Custom Package… ; Choose the **FOV-Feedback.unitypackage** you downloaded
- Drag & drop the FOVFeedback prefabs as a child of the camera
- Anywhere in the code, just use
`FOVFeedback.instance.ModifyText("Some text to display in the FOV");`

You are done 🎈:
Each time you use `FOVFeedback.instance.ModifyText("text")` you will display this text in the field of view.

# The sample scene 🎭

There is also a sample scene provided as an Unity package named **FOV-Feedback-SampleScene.unitypackage**. You will also find it in the [release](../../releases) section.

This scene just uses a StartUp script to modify the text in the field of view:
```csharp
void Start()
{
    StartCoroutine(DoSomeWork());
}

private IEnumerator DoSomeWork()
{
    for (int i = 0; i < 50; i++)
    {
        StartCoroutine(ChangeTextForTesting(i));
        yield return new WaitForSeconds(1f);
    }
}

private IEnumerator ChangeTextForTesting(int i)
{
    FOVFeedback.instance.ModifyText("I count: " + i);
    yield return 1;
}
```

## Tools' versions 🛠
- Visual Studio 2017 15.9
- Unity 2017.4.16f1
