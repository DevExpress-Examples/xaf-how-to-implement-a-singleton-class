﻿Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Xpo

Namespace HowToImplementSingleton.Module
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            'Create the Singleton object
            If ObjectSpace.GetObjectsCount(GetType(Singleton), Nothing) = 0 Then
                Dim _singleton As Singleton = ObjectSpace.CreateObject(Of Singleton)()
                _singleton.Name = "My Singleton"
                _singleton.Description = "Sample Description"
            End If
            ObjectSpace.CommitChanges()
        End Sub
    End Class
End Namespace
