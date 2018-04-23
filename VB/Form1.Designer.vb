Namespace WindowsFormsApplication1
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel5 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel5_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel6 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel6_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel7 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel7_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            Me.dockPanel4.SuspendLayout()
            Me.dockPanel5.SuspendLayout()
            Me.dockPanel6.SuspendLayout()
            Me.dockPanel7.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Controller = Me.barAndDockingController1
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatVertical = True
            Me.dockPanel1.ID = New System.Guid("60353a40-4fb7-4210-97a5-d2cf009e9bb5")
            Me.dockPanel1.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel1.Text = "dockPanel1"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.FloatVertical = True
            Me.dockPanel2.ID = New System.Guid("b4585cc9-f387-4eed-883d-3a7c0ad222e2")
            Me.dockPanel2.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel2.Text = "dockPanel2"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel3.FloatVertical = True
            Me.dockPanel3.ID = New System.Guid("1dcb3aee-d403-4064-b27c-8b0d792fa699")
            Me.dockPanel3.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel3.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel3.Text = "dockPanel3"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' dockPanel4
            ' 
            Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
            Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel4.FloatVertical = True
            Me.dockPanel4.ID = New System.Guid("76cbdd32-678b-456c-8cd7-a3219a94d9cc")
            Me.dockPanel4.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel4.Name = "dockPanel4"
            Me.dockPanel4.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel4.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel4.Text = "dockPanel4"
            ' 
            ' dockPanel4_Container
            ' 
            Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel4_Container.Name = "dockPanel4_Container"
            Me.dockPanel4_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel4_Container.TabIndex = 0
            ' 
            ' dockPanel5
            ' 
            Me.dockPanel5.Controls.Add(Me.dockPanel5_Container)
            Me.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel5.FloatVertical = True
            Me.dockPanel5.ID = New System.Guid("9aaeb376-0dd2-4528-af9b-1681660d6e0f")
            Me.dockPanel5.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel5.Name = "dockPanel5"
            Me.dockPanel5.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel5.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel5.Text = "dockPanel5"
            ' 
            ' dockPanel5_Container
            ' 
            Me.dockPanel5_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel5_Container.Name = "dockPanel5_Container"
            Me.dockPanel5_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel5_Container.TabIndex = 0
            ' 
            ' dockPanel6
            ' 
            Me.dockPanel6.Controls.Add(Me.dockPanel6_Container)
            Me.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel6.FloatVertical = True
            Me.dockPanel6.ID = New System.Guid("ed029328-d7dd-4a44-8fb9-dbe7c3eec65d")
            Me.dockPanel6.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel6.Name = "dockPanel6"
            Me.dockPanel6.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel6.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel6.Text = "dockPanel6"
            ' 
            ' dockPanel6_Container
            ' 
            Me.dockPanel6_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel6_Container.Name = "dockPanel6_Container"
            Me.dockPanel6_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel6_Container.TabIndex = 0
            ' 
            ' dockPanel7
            ' 
            Me.dockPanel7.Controls.Add(Me.dockPanel7_Container)
            Me.dockPanel7.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel7.FloatVertical = True
            Me.dockPanel7.ID = New System.Guid("ab1b68b4-3aae-4aa8-be89-8f2ec5ea2294")
            Me.dockPanel7.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel7.Name = "dockPanel7"
            Me.dockPanel7.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel7.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel7.Text = "dockPanel7"
            ' 
            ' dockPanel7_Container
            ' 
            Me.dockPanel7_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel7_Container.Name = "dockPanel7_Container"
            Me.dockPanel7_Container.Size = New System.Drawing.Size(620, 222)
            Me.dockPanel7_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel7
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel3)
            Me.panelContainer1.Controls.Add(Me.dockPanel4)
            Me.panelContainer1.Controls.Add(Me.dockPanel5)
            Me.panelContainer1.Controls.Add(Me.dockPanel6)
            Me.panelContainer1.Controls.Add(Me.dockPanel7)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
            Me.panelContainer1.FloatVertical = True
            Me.panelContainer1.ID = New System.Guid("439fda71-1ebc-4cee-96bd-c6a1947b7a46")
            Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 276)
            Me.panelContainer1.Size = New System.Drawing.Size(628, 276)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(628, 287)
            Me.Controls.Add(Me.panelContainer1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            Me.dockPanel4.ResumeLayout(False)
            Me.dockPanel5.ResumeLayout(False)
            Me.dockPanel6.ResumeLayout(False)
            Me.dockPanel7.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel7 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel7_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel5 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel5_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private dockPanel6 As DevExpress.XtraBars.Docking.DockPanel
        Private dockPanel6_Container As DevExpress.XtraBars.Docking.ControlContainer
    End Class
End Namespace

