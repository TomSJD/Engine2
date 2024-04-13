Public Class Game

    Private Const FPS As Double = 1000.0F / 60.0F
    Private CLEAR_COLOUR As Brush = Brushes.White

    Private parentForm As Form1
    Private device As Graphics
    Private pictureBox As PictureBox
    Private renderImage As Bitmap
    Private WithEvents gameTimer As Timer
    Public Shared stateManager As StateManager

    Private title As String
    Private windowWidth As Integer
    Private windowHeight As Integer

    ' Variables for game loop
    Private currentTime As Long = 0
    Private endTime As Long = 0

    Public Sub New(ByVal parent As Form1, ByVal title As String, ByVal width As Integer, ByVal height As Integer)
        Me.parentForm = parent
        Me.title = title
        Me.windowWidth = width
        Me.windowHeight = height
    End Sub

    Public Sub Init()
        ' Setup parent form
        With parentForm
            .MinimumSize = New Size(windowWidth, windowHeight)
            .MaximumSize = New Size(windowWidth, windowHeight)
            .Size = New Size(windowWidth, windowHeight)
        End With
        ' Setup PixtureBox that will be rendered on
        pictureBox = New PictureBox
        With pictureBox
            .Parent = Me.parentForm
            .Dock = DockStyle.Fill
            .Location = New Point(0, 0)
            .Size = New Size(windowWidth, windowHeight)
            .BackColor = Color.White
        End With
        parentForm.Controls.Add(pictureBox)
        ' Setup bitmap to be rendered to
        renderImage = New Bitmap(windowWidth, windowHeight)
        pictureBox.Image = renderImage
        ' Setup render device
        device = Graphics.FromImage(renderImage)
        ' Setup update timer
        gameTimer = New Timer
        With gameTimer
            .Interval = FPS
            .Enabled = True
        End With
        ' Setup StateManager
        stateManager = New StateManager(New MenuState())
        ' Start game tick timer
        gameTimer.Start()
    End Sub

    Private Sub GameLoop() Handles gameTimer.Tick
        currentTime = DateTimeOffset.Now.ToLocalTime.Millisecond
        Tick(endTime - currentTime)
        device.FillRectangle(CLEAR_COLOUR, 0, 0, windowWidth, windowHeight)
        Render(device)
        pictureBox.Image = renderImage
        endTime = DateTimeOffset.Now.ToLocalTime.Millisecond
    End Sub

    Private Sub Tick(ByVal delta As Double)
        stateManager.Tick(delta)
    End Sub

    Private Sub Render(ByVal g As Graphics)
        stateManager.Render(g)
    End Sub

    Protected Overrides Sub Finalize()
        ' Free memory after class is destructed
        Me.Device.Dispose()
        Me.renderImage.Dispose()
        Me.pictureBox.Dispose()
        Me.gameTimer.Dispose()
        stateManager.Dispose()
    End Sub
End Class
