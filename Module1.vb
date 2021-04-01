Module Module1
    Public Declare Function OpenProcess Lib "KERNEL32" _
    (ByVal DesiredAccess As Int32, _
     ByVal InheritHandle As Boolean, _
     ByVal ProcessId As Int32) _
    As Int32

    Private Declare Function ReadProcessMemory Lib "KERNEL32" _
    (ByVal Handle As Int32, _
     ByVal address As Int32, _
     ByRef Value As Int32, _
     Optional ByVal Size As Int32 = 4, _
     Optional ByVal lpNumberOfBytesWritten As Int64 = 0) _
    As Long

    Public PROCESS_VM_OPERATION As Int32 = 8
    Public PROCESS_VM_READ As Int32 = 16
    Public PROCESS_VM_WRITE As Int32 = 32

    Private process_id As Int32 = 0
    Public pHandle As Integer = 0

    Public Function GetProcessId(ByVal game_name As String) As Boolean
        Dim Processes() As Process = Process.GetProcesses
        Dim process_name As String
        Dim i As Byte
        For i = LBound(Processes) To UBound(Processes)
            process_name = Processes(i).ProcessName
            If process_name = game_name Then
                process_id = Processes(i).Id
                pHandle = OpenProcess(PROCESS_VM_OPERATION + PROCESS_VM_WRITE + PROCESS_VM_READ, False, process_id)
                Return True
            End If
        Next
        If process_id = 0 Then
            Return False
        End If
        Return False
    End Function

    Public Function ReadByte(ByVal address As Int32) As Integer
        Dim value As Integer
        ReadProcessMemory(pHandle, address, value, 1, 0)
        Return value
    End Function

    Public Function AOBSCAN(ByVal GameName As String, ByVal ModuleName As String, ByVal Signature As Byte()) As Integer
        Dim BaseAddress, EndAddress As Int32
        For Each PM As ProcessModule In Process.GetProcessesByName(GameName)(0).Modules
            If ModuleName = PM.ModuleName Then
                BaseAddress = PM.BaseAddress
                EndAddress = BaseAddress + PM.ModuleMemorySize
            End If
        Next
        Dim curAddr As Int32 = BaseAddress
        Do
            For i As Integer = 0 To Signature.Length - 1
                If ReadByte(curAddr + i) = Signature(i) Then
                    If i = Signature.Length - 1 Then
                        MsgBox(curAddr.ToString("X"))
                        Return curAddr
                    End If
                    Continue For
                End If
                Exit For
            Next
            curAddr += 1
        Loop While curAddr < EndAddress
        Return 0
    End Function
End Module
