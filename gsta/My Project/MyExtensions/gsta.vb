Imports System.Diagnostics.CodeAnalysis
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices

Partial Class gsta
    Inherits Application

    <SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
    <SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")>
    Friend ReadOnly Property Info As AssemblyInfo
        <DebuggerHidden>
        Get
            Return New AssemblyInfo(Assembly.GetExecutingAssembly())
        End Get
    End Property
End Class