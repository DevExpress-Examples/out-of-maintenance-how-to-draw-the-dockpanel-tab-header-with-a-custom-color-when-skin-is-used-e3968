<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyPaintStyle.cs](./CS/MyPaintStyle.cs) (VB: [MyPaintStyle.vb](./VB/MyPaintStyle.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to draw the DockPanel Tab header with a custom Color when Skin is used


<p>The <a href="https://www.devexpress.com/Support/Center/p/E2502">How to implement the custom draw functionality for skinned dock panels</a> example illustrates the most common approach to implement this functionality by raising a custom CustomDrawDockPanelCaption event.</p><p>The current example illustrates an alternative approach that allows you to change the dock panel appearance by creating a custom paint style. </p><p>To change an active panel tab header appearance, you can create your own SkinBarManagerPaintStyle and override DrawActiveTab in the corresponding DockElementsSkinPainter descendant.</p>

<br/>


