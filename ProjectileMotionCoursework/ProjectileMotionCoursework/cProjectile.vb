Public Class cProjectile
    'PROPERTIES
    Private InitialVelocity As Decimal
    Private Angle As Decimal
    Private InitialHeight As Decimal
    Private InitialVerticalVelocity As Decimal
    Private HorizontalVelocity As Decimal
    Private Acceleration As Decimal
    Private Maximumheight As Decimal
    Private Range As Decimal
    Private TimeUntilMaximumHeight As Decimal
    Private TimeUntilLanding As Decimal
    Private CoordPoints() As PointF

    'CONSTRUCTOR
    Public Sub New()
        InitialVelocity = 0
        Angle = 0
        InitialHeight = 0
        InitialVerticalVelocity = 0
        HorizontalVelocity = 0
        Acceleration = 9.81
        Maximumheight = 0
        Range = 0
        TimeUntilMaximumHeight = 0
        TimeUntilLanding = 0
        CoordPoints = Nothing
    End Sub

    'METHODS
    Public Function GetInitialVelocity() As Decimal
        Return Me.InitialVelocity
    End Function

    Public Sub SetInitialVelocity(ByVal inInitialVelocity As Decimal)
        Me.InitialVelocity = inInitialVelocity
    End Sub

    Public Function GetAngle() As Decimal
        Return Me.Angle
    End Function

    Public Sub SetAngle(ByVal inAngle As Decimal)
        Me.Angle = inAngle
    End Sub

    Public Function GetInitialHeight() As Decimal
        Return Me.InitialHeight
    End Function

    Public Sub SetInitialHeight(ByVal inInitialHeight As Decimal)
        Me.InitialHeight = inInitialHeight
    End Sub

    Public Function GetInitialVerticalVelocity() As Decimal
        Return Me.InitialVerticalVelocity
    End Function

    Public Sub SetInitialVerticalVelocity(ByVal inInitialVerticalVelocity As Decimal)
        Me.InitialVerticalVelocity = inInitialVerticalVelocity
    End Sub

    Public Function GetHorizontalVelocity() As Decimal
        Return Me.HorizontalVelocity
    End Function

    Public Sub SetAcceleration(ByVal inAcceleration As Decimal)
        Me.Acceleration = inAcceleration
    End Sub

    Public Function GetAcceleration() As Decimal
        Return Me.Acceleration
    End Function

    Public Function GetMaximumHeight() As Decimal
        Return Me.Maximumheight
    End Function

    Public Function GetHorizontalDisplacementAtMaximumHeight()
        Return Me.HorizontalVelocity * Me.TimeUntilMaximumHeight
    End Function

    Public Function GetRange() As Decimal
        Return Me.Range
    End Function

    Public Function GetTimeUntilmaximumHeight() As Decimal
        Return Me.TimeUntilMaximumHeight
    End Function

    Public Function GetTimeUntilLanding() As Decimal
        Return Me.TimeUntilLanding
    End Function

    Public Function GetCoordPoints() As PointF()
        Return Me.CoordPoints
    End Function

    'Procedure to calculate all the important values for a single projectile based on the inputs from the user
    Public Sub CalculateValuesForProjectile()
        CalculateInitialVerticalVelocity()
        CalculateHorizontalVelocity()
        CalculateMaximumHeight()
        CalculateTimeUntilMaximumHeight()
        CalculateTimeUntilLanding()
        CalculateRange()
    End Sub

    'Trigonometric function used here to calculate the vertical velocity using the initial velocity and angle provided by the user
    Private Sub CalculateInitialVerticalVelocity()
        Me.InitialVerticalVelocity = Math.Sin(Me.Angle * Math.PI / 180) * Me.InitialVelocity
    End Sub

    'Trigonometric function used to calculate the horizontal velocity based on the initial velocity and angle provided by the user
    Private Sub CalculateHorizontalVelocity()
        Me.HorizontalVelocity = Math.Cos(Me.Angle * Math.PI / 180) * Me.InitialVelocity
    End Sub

    'Maximum height the projectile can reach is calculated by rearranging a SUVAT equation into the form: (u^2) / 2*a
    'The Initial Height is also added as that is extra vertical displacement
    Private Sub CalculateMaximumHeight()
        Me.Maximumheight = ((Me.InitialVerticalVelocity ^ 2) / (2 * Me.Acceleration)) + Me.InitialHeight
    End Sub

    'Time until maximum height is from v = u +a*t where v=0
    Private Sub CalculateTimeUntilMaximumHeight()
        Me.TimeUntilMaximumHeight = Me.InitialVerticalVelocity / Me.Acceleration
    End Sub

    'Using SUVAT equations, an equation for time is derived
    Private Sub CalculateTimeUntilLanding()
        'Time until max height is the journey to the top, then the other portion is the time for travelling the distance from the top to the bottom.
        Me.TimeUntilLanding = Me.TimeUntilMaximumHeight + (Math.Sqrt((2 * Me.Maximumheight) / Me.Acceleration))
    End Sub

    'SUVAT equation s=ut, horizontal velocity is constant so mutliplying by time of flight gives total displacement.
    Private Sub CalculateRange()
        Me.Range = Me.HorizontalVelocity * Me.TimeUntilLanding
    End Sub

    'Procedure to calculate the coordinates of the position of the projectile at specific intervals of its flight path.
    Public Sub SetCoordinatesArray()
        'An array is made to store all the coordinate pairs as floating point coordinates.
        'The size of the array is the time until landing which is in seconds, multiplied by 100 so that means there will be 100 readings per second of flight that will be plotted.
        'ArrayPos is the position in the array of the point that is being calculated
        'CurrentTime is the time value of that particular instance of the flight of the projectile
        Dim TempArray(Me.TimeUntilLanding * 100) As PointF
        Dim ArrayPos As Long = 0
        Dim CurrentTime As Decimal = 0

        'Loop that will calculate the vertical and horizontal displacement based on SUVAT equations
        Do
            'For each coordinate, the x and y values are calculated and added to the array at ArrayPosition
            TempArray(ArrayPos).X = (Me.HorizontalVelocity * CurrentTime)
            TempArray(ArrayPos).Y = Me.InitialHeight + ((Me.InitialVerticalVelocity * CurrentTime) + (0.5 * -Me.Acceleration * CurrentTime ^ 2))

            'CurrentTime is incremented by 0.01 seconds and ArrayPosition is increased by 1 as it will look at the next coordinate pair.
            CurrentTime += 0.01
            ArrayPos += 1

            'The loop will terminate when the current time of flight is equal to the calculated time until landing, since after landing it will no longer be in flight.
        Loop Until CurrentTime >= Me.TimeUntilLanding

        'After the array is filled in, the last x and y coordinate pair of the flight of the projectile is set
        'to have an x value of the range, which is the total horizontal distance travelled
        'and the y value to be 0, as that means its vertical displacement is 0 and it has landed.
        TempArray(ArrayPos - 1).X = Me.Range
        TempArray(ArrayPos - 1).Y = 0

        'Lastly, the CoordPoints array is set equal to the temporary array from this procedure.
        Me.CoordPoints = TempArray
    End Sub

    'The SetCoordinatesArray procedure is overloaded with a parameter to simulate air resistance if the user wants it
    Public Sub SetCoordinatesArray(ByVal inDragCoefficient As Decimal)

        Dim TempArray(Me.TimeUntilLanding * 100) As PointF
        Dim ArrayPos As Long = 0
        Dim CurrentTime As Decimal = 0

        'Loop that will calculate the vertical and horizontal displacement based on SUVAT equations
        Do
            'As velocity is inversely proportional to drag, the velocity is divided by 1 plus the drag coefficient chosen by the user
            TempArray(ArrayPos).X = (Me.HorizontalVelocity / (1 + inDragCoefficient)) * CurrentTime
            TempArray(ArrayPos).Y = ((((Me.InitialVerticalVelocity / (1 + inDragCoefficient)) * CurrentTime) + (0.5 * -Me.Acceleration * CurrentTime ^ 2))) + Me.InitialHeight

            'CurrentTime is incremented by 0.01 seconds and ArrayPosition is increased by 1 as it will look at the next coordinate pair.
            CurrentTime += 0.01
            ArrayPos += 1

            'The loop will terminate when the current time of flight is equal to the calculated time until landing, since after landing it will no longer be in flight.
        Loop Until CurrentTime >= Me.TimeUntilLanding

        'The last pair of coordinates are when the projectile has landed, so the X value will be the calculated range, divided by 1 plus the drag coefficient
        'and the Y value is set to 0
        TempArray(ArrayPos - 1).X = Me.Range / (1 + inDragCoefficient)
        TempArray(ArrayPos - 1).Y = 0

        'Lastly, the CoordPoints array is set equal to the temporary array from this procedure.
        Me.CoordPoints = TempArray
    End Sub

End Class