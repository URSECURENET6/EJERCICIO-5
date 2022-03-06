Public Class Stiffener

    Private PartNumber As String
    Private Description As String
    Private IsCustom As Boolean
    ''' <summary>
    ''' Pone u obtiene el nombre del parametro.
    ''' </summary>
    Friend Property _PartNumber() As String
        Get
            Return PartNumber
        End Get
        Set(ByVal value As String)
            PartNumber = value
        End Set
    End Property
    ''' <summary>
    ''' Pone u obtiene el nombre del parametro.
    ''' </summary>
    Friend Property _Description() As String
        Get
            Return Description
        End Get
        Set(ByVal value As String)
            Description = value
        End Set
    End Property
    ''' <summary>
    ''' Pone u obtiene el nombre del parametro.
    ''' </summary>
    Friend Property _IsCustom() As Boolean
        Get
            Return IsCustom
        End Get
        Set(ByVal value As Boolean)
            IsCustom = value
        End Set
    End Property

End Class
