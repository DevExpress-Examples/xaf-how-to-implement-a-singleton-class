Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Xpo

Namespace HowToImplementSingleton.Module
    <RuleObjectExists("AnotherSingletonExists", DefaultContexts.Save, "True", InvertResult := True, CustomMessageTemplate := "Another Singleton already exists."), RuleCriteria("CannotDeleteSingleton", DefaultContexts.Delete, "False", CustomMessageTemplate := "Cannot delete Singleton.")> _
    Public Class Singleton
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub


        Private name_Renamed As String
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", name_Renamed, value)
            End Set
        End Property

        Private description_Renamed As String
        Public Property Description() As String
            Get
                Return description_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Description", description_Renamed, value)
            End Set
        End Property

    End Class
End Namespace
