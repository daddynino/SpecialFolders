'Imports System
Imports System.IO
Imports System.Runtime.InteropServices

Public Class PathNotFoundException
    Inherits ApplicationException
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
''' <summary>
''' Class containing methods to retrieve specific file system paths.
''' </summary>
Public Module KnownFolders

#Region "---- MEMBERS ------------------------------------------------------------------------------"
#End Region

#Region "private static string[] _knownFolderGuids = new string[]"
    Private ReadOnly _knownFolderGuids As String() =
    {
        "{008CA0B1-55B4-4C56-B8A8-4DE4B299D3BE}",
        "{724EF170-A42D-4FEF-9F26-B60E846FBA4F}",
        "{A3918781-E5F2-4890-B3D9-A7E54332328C}",
        "{AB5FB87B-7CE2-4F83-915D-550846C9537B}",
        "{9E52AB10-F80D-49DF-ACB8-4330F5687855}",
        "{D0384E7D-BAC3-4797-8F14-CBA229B392B5}",
        "{C1BAE2D0-10DF-4334-BEDD-7AA20B227A9D}",
        "{0139D44E-6AFE-49F2-8690-3DAFCAE6FFB8}",
        "{A4115719-D62E-491D-AA7C-E74B8BE3B067}",
        "{82A5EA35-D9CD-47C5-9629-E15D2F714E6E}",
        "{B94237E7-57AC-4347-9151-B08C6C32D1F7}",
        "{56784854-C6CB-462B-8169-88E350ACB882}",
        "{2B0F765D-C0E9-4171-908E-08A611B84FF6}",
        "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}",
        "{5CE4A5E9-E4EB-479D-B89F-130C02886155}",
        "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}",
        "{7B0DB17D-9CD2-4A93-9733-46CC89022E7C}",
        "{374DE290-123F-4565-9164-39C4925E467B}",
        "{1777F761-68AD-4D8A-87BD-30B759FA33DD}",
        "{FD228CB7-AE11-4AE3-864C-16F3910AB8FE}",
        "{054FAE61-4DD8-4787-80B6-090220C4B700}",
        "{D9DC8A3B-B784-432E-A781-5A1130A75963}",
        "{BCB5256F-79F6-4CEE-B725-DC34E402FD46}",
        "{352481E8-33BE-4251-BA85-6007CAEDCF9D}",
        "{1B3EA5DC-B587-4786-B4EF-BD1DC332AEAE}",
        "{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}",
        "{F1B32785-6FBA-4FCF-9D55-7B8E7F157091}",
        "{A520A1A4-1780-4FF6-BD18-167343C5AF16}",
        "{2A00375E-224C-49DE-B8D1-440DF7EF3DDC}",
        "{4BD8D571-6D19-48D3-BE97-422220080E43}",
        "{2112AB0A-C86A-4FFE-A368-0DE96E47012E}",
        "{C5ABBF53-E17F-4121-8900-86626FC2C973}",
        "{2C36C0AA-5812-4B87-BFD0-4CD0DFB19B39}",
        "{69D2CF90-FC33-4FB7-9A0C-EBB0F0FCB43C}",
        "{A990AE9F-A03B-4E80-94BC-9912D7504104}",
        "{33E28130-4E1E-4676-835A-98395C3BC3BB}",
        "{DE92C1C7-837F-4F69-A3BB-86E631204A23}",
        "{9274BD8D-CFD1-41C3-B35E-B13F55A758F4}",
        "{5E6C858F-0E22-4760-9AFE-EA3317B67173}",
        "{62AB5D82-FDC1-4DC3-A9DD-070D1D495D97}",
        "{905E63B6-C1BF-494E-B29C-65B732D3D21A}",
        "{6D809377-6AF0-444B-8957-A3773F02200E}",
        "{7C5A40EF-A0FB-4BFC-874A-C0F2E0B9FA8E}",
        "{F7F1ED05-9F6D-47A2-AAAE-29D317C6F066}",
        "{6365D5A7-0F0D-45E5-87F6-0DA56B6A4F7D}",
        "{DE974D24-D9C6-4D3E-BF91-F4455120B917}",
        "{A77F5D77-2E2B-44C3-A6A2-ABA601054A51}",
        "{DFDF76A2-C82A-4D63-906A-5644AC457385}",
        "{C4AA340D-F20F-4863-AFEF-F87EF2E6BA25}",
        "{ED4824AF-DCE4-45A8-81E2-FC7965083634}",
        "{3D644C9B-1FB8-4F30-9B45-F670235F79C0}",
        "{DEBF2536-E1A8-4C59-B6A2-414586476AEA}",
        "{48DAF80B-E6CF-4F4E-B800-0E69D84EE384}",
        "{3214FAB5-9757-4298-BB61-92A9DEAA44FF}",
        "{B6EBFB86-6907-413C-9AF7-4FC2ABF07CC5}",
        "{E555AB60-153B-4D17-9F04-A5FE99FC15EC}",
        "{0482AF6C-08F1-4C34-8C90-E17EC98B1E17}",
        "{2400183A-6185-49FB-A2D8-4A392A602BA3}",
        "{52A4F021-7B75-48A9-9F6B-4B87A210BC8F}",
        "{AE50C081-EBD2-438A-8655-8A092E34987A}",
        "{1A6FDBA2-F42D-4358-A798-B74D745926C5}",
        "{8AD10C31-2ADB-4296-A8F7-E4701232C972}",
        "{C870044B-F49E-4126-A9C3-B52A1FF411E8}",
        "{3EB685DB-65F9-4CF6-A03A-E3EF65729F3D}",
        "{AAA8D5A5-F1D6-4259-BAA8-78E7EF60835E}",
        "{00BCFC5A-ED94-4E48-96A1-3F6217F21990}",
        "{B250C668-F57D-4EE1-A63C-290EE7D1AA1F}",
        "{C4900540-2379-4C75-844B-64E6FAF8716B}",
        "{15CA69B3-30EE-49C1-ACE1-6B5EC372AFB5}",
        "{859EAD94-2E85-48AD-A71A-0969CB56A6CD}",
        "{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}",
        "{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}",
        "{B7BEDE81-DF94-4682-A7D8-57A52620B86F}",
        "{0D4C3DB6-03A3-462F-A0E6-08924C41B5D4}",
        "{7E636BFE-DFA9-4D5E-B456-D7B39851D8A9}",
        "{8983036C-27C0-404B-8F08-102D10DCFD74}",
        "{7B396E54-9EC5-4300-BE0A-2482EBAE1A26}",
        "{A75D362E-50FC-4FB7-AC2C-A8BEAA314493}",
        "{A52BBA46-E9E1-435F-B3D9-28DAA648C0F6}",
        "{767E6811-49CB-4273-87C2-20F355E1085B}",
        "{24D89E24-2F19-4534-9DDE-6A6671FBB8FE}",
        "{339719B5-8C47-4894-94C2-D8F77ADD44A6}",
        "{625B53C3-AB48-4EC1-BA1F-A1EF4146FC19}",
        "{B97D20BB-F46A-4C97-BA10-5E3608430854}",
        "{1AC14E77-02E7-4E5D-B744-2EB1AE5198B7}",
        "{D65231B0-B2F1-4857-A4CE-A8E7C6EA7D27}",
        "{A63293E8-664E-48DB-A079-DF759E0509F7}",
        "{9E3995AB-1F9C-4F13-B827-48B24B6C7174}",
        "{0762D272-C50A-4BB0-A382-697DCD729B80}",
        "{5CD7AEE2-2219-4A67-B85D-6C9CE15660CB}",
        "{BCBD3057-CA5C-4622-B42D-BC56DB0AE516}",
        "{18989B1D-99B5-455B-841C-AB7C74E4DDFC}",
        "{491E922F-5643-4AF4-A7EB-4E7A138D8174}",
        "{F38BF404-1D43-42F2-9305-67DE0B28FC23}"
    }
#End Region

#Region "---- METHODS (PUBLIC) ---------------------------------------------------------------------"


    ''' <summary>
    ''' Gets the current path to the specified known folder as currently configured. This does
    ''' not require the folder to be existent.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which current path will be returned.</param>
    ''' <returns>The default path of the known folder.</returns>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the path
    '''     could not be retrieved.</exception>
    Public Function GetPath(ByVal myKnownFolder As KnownFolder) As String

        Return GetPath(myKnownFolder, False)

    End Function

    ''' <summary>
    ''' Gets the current path to the specified known folder as currently configured. This does
    ''' not require the folder to be existent.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which current path will be returned.</param>
    ''' <param name="defaultUser">Specifies if the paths of the default user (user profile
    '''     template) will be used. This requires administrative rights.</param>
    ''' <returns>The default path of the known folder.</returns>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the path
    '''     could not be retrieved.</exception>
    Public Function GetPath(ByVal myKnownFolder As KnownFolder, ByVal defaultUser As Boolean) As String

        Return GetPath(myKnownFolder, KnownFolderFlags.DontVerify, defaultUser)

    End Function

    ''' <summary>
    ''' Gets the default path to the specified known folder. This does not require the folder
    ''' to be existent.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which default path will be returned.</param>
    ''' <returns>The current (and possibly redirected) path of the known folder.</returns>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the path
    '''     could not be retrieved.</exception>
    Public Function GetDefaultPath(ByVal myKnownFolder As KnownFolder) As String

        Return GetDefaultPath(myKnownFolder, False)

    End Function

    ''' <summary>
    ''' Gets the default path to the specified known folder. This does not require the folder
    ''' to be existent.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which default path will be returned.</param>
    ''' <param name="defaultUser">Specifies if the paths of the default user (user profile
    '''     template) will be used. This requires administrative rights.</param>
    ''' <returns>The current (and possibly redirected) path of the known folder.</returns>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the path
    '''     could not be retrieved.</exception>
    Public Function GetDefaultPath(ByVal myKnownFolder As KnownFolder, ByVal defaultUser As Boolean) As String

        Return GetPath(myKnownFolder, KnownFolderFlags.DefaultPath Or KnownFolderFlags.DontVerify,
                defaultUser)

    End Function

    ''' <summary>
    ''' Sets the path for a specified known folder.
    ''' </summary>
    ''' <param name="myKnownFolder">The known folder to update.</param>
    ''' <param name="DestinationFolder">The new path for the known folder.</param>
    ''' <returns>
    ''' A <see cref="FunctionResult"/> indicating the success or failure of the operation.
    ''' </returns>
    ''' <remarks>
    ''' This method uses the SHSetKnownFolderPath API to update the location of a known folder.
    ''' </remarks>
    Public Function SetFolderPath(ByVal myKnownFolder As KnownFolder, ByVal DestinationFolder As String) As FunctionResult
        If String.IsNullOrEmpty(DestinationFolder) Then
            Return FunctionResult.InvalidInput
        End If

        Dim FldGuid As New Guid(_knownFolderGuids(CInt(myKnownFolder)))

        Dim result As Integer = SHSetKnownFolderPath(FldGuid, 0, IntPtr.Zero, DestinationFolder)

        If result = 0 Then ' S_OK
            Console.WriteLine("Desktop path updated successfully.")
            Return FunctionResult.Success
        Else
            Console.WriteLine("Error updating known folder path.")
            Return FunctionResult.UnknownError
        End If

    End Function

    ''' <summary>
    ''' Moves all files and subdirectories from the source folder to the destination folder.
    ''' </summary>
    ''' <param name="SourceFolder">The full path of the folder from which files and directories will be moved.</param>
    ''' <param name="DestFolder">The full path of the folder to which files and directories will be moved.</param>
    ''' <returns>A <see cref="FunctionResult"/> value indicating the result of the operation.</returns>
    ''' <exception cref="IOException">Thrown when an I/O error occurs during the operation.</exception>
    ''' <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
    Public Function MoveAffectedFolderItems(ByVal SourceFolder As String, ByVal DestFolder As String) As FunctionResult
        ' Check if the source folder exists
        If Not Directory.Exists(SourceFolder) Then
            Return FunctionResult.InvalidInput
        End If

        ' Ensure the source and destination folders are not the same
        If SourceFolder.Equals(DestFolder, StringComparison.OrdinalIgnoreCase) Then
            Return FunctionResult.MatchingFile
        End If

        ' Attempt to create the destination folder if it doesn't exist
        Try
            If Not Directory.Exists(DestFolder) Then
                Directory.CreateDirectory(DestFolder)
            End If
        Catch ex As Exception
            ' Return an I/O error if the destination folder cannot be created
            Return FunctionResult.IOError
        End Try

        ' Attempt to move files and directories from source to destination
        Try
            ' Move files from source to destination
            MoveFiles(SourceFolder, DestFolder)
            ' Move subdirectories from source to destination
            MoveDirectories(SourceFolder, DestFolder)
            ' If everything succeeds, return success
            Return FunctionResult.Success
        Catch ex As Exception
            ' Return an I/O error if any operation fails
            Return FunctionResult.IOError
        End Try
    End Function

    ''' <summary>
    ''' Moves all files from the source folder to the destination folder.
    ''' </summary>
    ''' <param name="SourceFolder">The full path of the source folder.</param>
    ''' <param name="DestFolder">The full path of the destination folder.</param>
    ''' <exception cref="IOException">Thrown when an I/O error occurs during the operation.</exception>
    Private Sub MoveFiles(ByVal SourceFolder As String, ByVal DestFolder As String)
        ' Get all files in the source folder
        Dim files As String() = Directory.GetFiles(SourceFolder)
        For Each file As String In files
            ' Determine the destination file path
            Dim destFile As String = Path.Combine(DestFolder, Path.GetFileName(file))
            ' Move the file to the destination
            IO.File.Move(file, destFile)
        Next
    End Sub

    ''' <summary>
    ''' Moves all subdirectories from the source folder to the destination folder.
    ''' </summary>
    ''' <param name="SourceFolder">The full path of the source folder.</param>
    ''' <param name="DestFolder">The full path of the destination folder.</param>
    ''' <exception cref="IOException">Thrown when an I/O error occurs during the operation.</exception>
    Private Sub MoveDirectories(ByVal SourceFolder As String, ByVal DestFolder As String)
        ' Get all directories in the source folder
        Dim directories As String() = Directory.GetDirectories(SourceFolder)
        For Each dir As String In directories
            ' Determine the destination directory path
            Dim destDir As String = Path.Combine(DestFolder, Path.GetFileName(dir))
            ' Move the directory to the destination
            Directory.Move(dir, destDir)
        Next
    End Sub

#End Region
    ''' <summary>
    ''' Creates and initializes the known folder.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which will be initialized.</param>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the known
    '''     folder could not be initialized.</exception>
#Disable Warning IDE0051 ' Remove unused private members
    Private Sub Initialize(ByVal myKnownFolder As KnownFolder)
#Enable Warning IDE0051 ' Remove unused private members

        Initialize(myKnownFolder, False)

    End Sub

    ''' <summary>
    ''' Creates and initializes the known folder.
    ''' </summary>
    ''' <param name="knownFolder">The known folder which will be initialized.</param>
    ''' <param name="defaultUser">Specifies if the paths of the default user (user profile
    '''     template) will be used. This requires administrative rights.</param>
    ''' <exception cref="System.Runtime.InteropServices.ExternalException">Thrown if the known
    '''     folder could not be initialized.</exception>
    Private Sub Initialize(ByVal myKnownFolder As KnownFolder, ByVal defaultUser As Boolean)

        GetPath(myKnownFolder, (KnownFolderFlags.Create Or KnownFolderFlags.Init), defaultUser)

    End Sub

#Region "---- METHODS (PRIVATE) --------------------------------------------------------------------"


    Public ExternalException As New Exception

#Disable Warning IDE0060 ' Remove unused parameter
    ''' <summary>
    ''' Retrieves the path for a specified known folder.
    ''' </summary>
    ''' <param name="myKnownFolder">The known folder to retrieve the path for.</param>
    ''' <param name="flags">Options that specify special retrieval options.</param>
    ''' <param name="defaultUser">Indicates whether to retrieve the path for the default user or the current user.</param>
    ''' <returns>The path of the specified known folder as a <see cref="String"/>.</returns>
    ''' <exception cref="PathNotFoundException">
    ''' Thrown when the known folder path cannot be retrieved, 
    ''' typically because the folder is not available on this system.
    ''' </exception>
    ''' <remarks>
    ''' This method uses the SHGetKnownFolderPath API to retrieve the path of a known folder.
    ''' </remarks>
    Private Function GetPath(ByVal myKnownFolder As KnownFolder, ByVal flags As KnownFolderFlags,
            ByVal defaultUser As Boolean) As String
#Enable Warning IDE0060 ' Remove unused parameter
        Dim outPath As String ' = Nothing
        Dim hOutPath As IntPtr
        Dim result As Integer

        result = SHGetKnownFolderPath(New Guid(_knownFolderGuids(CInt(myKnownFolder))),
                CType(flags, UInteger), Nothing, hOutPath)
        If (result >= 0) Then
            outPath = Marshal.PtrToStringUni(hOutPath)
            Return outPath
        Else
            Throw New PathNotFoundException("Unable to retrieve the known folder path: " &
                    myKnownFolder.ToString & ". " _
                    & "It may not be available on this system.")
        End If
    End Function

    ''' <summary>
    ''' Retrieves the full path of a known folder identified by the folder's KnownFolderID.
    ''' </summary>
    ''' <param name="rfid">A KnownFolderID that identifies the folder.</param>
    ''' <param name="dwFlags">Flags that specify special retrieval options. This value can be
    '''     0; otherwise, one or more of the KnownFolderFlag values.</param>
    ''' <param name="hToken">An access token that represents a particular user. If this
    '''     parameter is NULL, which is the most common usage, the function requests the known
    '''     folder for the current user. Assigning a value of -1 indicates the Default User.
    '''     The default user profile is duplicated when any new user account is created.
    '''     Note that access to the Default User folders requires administrator privileges.
    '''     </param>
    ''' <param name="ppszPath">When this method returns, contains the address of a string that
    '''     specifies the path of the known folder. The returned path does not include a
    '''     trailing backslash.</param>
    ''' <returns>Returns S_OK if successful, or an error value otherwise.</returns>
    Declare Auto Function SHGetKnownFolderPath Lib "Shell32.dll" (
        ByVal rfid As Guid, ByVal dwFlags As UInteger, ByVal hToken As IntPtr,
        ByRef pszPath As String) As Integer
    <DllImport("shell32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Friend Function SHGetKnownFolderPath(
        <MarshalAs(UnmanagedType.LPStruct)> ByVal rfid As Guid,
        ByVal dwFlags As UInt32,
        ByVal hToken As IntPtr,
        <Out> ByRef pszPath As IntPtr
    ) As Integer
    End Function

    <DllImport("shell32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Friend Function SHSetKnownFolderPath(
        <MarshalAs(UnmanagedType.LPStruct)> ByVal rfid As Guid,
        ByVal dwFlags As UInt32,
        ByVal hToken As IntPtr,
        ByVal pszPath As String
    ) As Integer
    End Function

    'Private Function MoveFolderContents(sourcePath As String, destinationPath As String) As FunctionResult
    '    '         Get files And subdirectories from source path
    '    '        Dim files As String() = Directory.GetFiles(sourcePath)
    '    '        Dim directories As String() = Directory.GetDirectories(sourcePath)

    '    '        Move files
    '    '        For Each file In files
    '    '            Dim fileName As String = Path.GetFileName(file)
    '    '            Dim destFile As String = Path.Combine(destinationPath, fileName)
    '    '            file.Move(file, destFile)
    '    '        Next

    '    '        Move directories recursively
    '    '        For Each directory In directories
    '    '            Dim dirName As String = New DirectoryInfo(directory).Name
    '    '            Dim destDir As String = Path.Combine(destinationPath, dirName)
    '    '            MoveFolderContents(directory, destDir)
    '    '        Next

    '    '        Delete original source directory if empty
    '    '        If Directory.GetFiles(sourcePath).Length = 0 AndAlso Directory.GetDirectories(sourcePath).Length = 0 Then
    '    '            Directory.Delete(sourcePath)
    '    '        End If
    '    '    End Sub
    'End Function
#End Region

#Region "---- ENUMERATIONS -------------------------------------------------------------------------"


    '[flags]()
    Private Enum KnownFolderFlags As UInteger
        SimpleIDList = &H100
        NotParentRelative = &H200
        DefaultPath = &H400
        Init = &H800
        NoAlias = &H1000
        DontUnexpand = &H2000
        DontVerify = &H4000
        Create = &H8000
        NoAppcontainerRedirection = &H10000
        AliasOnly = &H80000000UL
    End Enum

    Public Enum FunctionResult As UInteger
        Success = 0
        Failure = 1
        NotFound = 2
        InvalidInput = 3
        AccessDenied = 4
        Timeout = 5
        AlreadyExists = 6
        NotSupported = 7
        NoDownloadFolder = 8
        OnlineError = 9
        MatchingFile = 10
        HTTPError = 11
        IOError = 12
        IOException = 13
        FileReadOnly = 14
        OperationCanceled = 15
        UnknownError = 99
    End Enum

    ''' <summary>
    ''' Standard folders registered with the system. These folders are installed with
    ''' Windows Vista and later operating systems, and a computer will have only folders
    ''' appropriate to it installed.
    ''' </summary>
    Public Enum KnownFolder
        ''' <summary>
        ''' The per-user Account Pictures folder. Introduced in Windows 8.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\AccountPictures&quot;.
        ''' </summary>
        AccountPictures

        ''' <summary>
        ''' The per-user Administrative Tools folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
        ''' </summary>
        AdminTools

        ''' <summary>
        ''' The per-user Application Shortcuts folder. Introduced in Windows 8.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Application Shortcuts&quot;.
        ''' </summary>
        ApplicationShortcuts

        ''' <summary>
        ''' The per-user Camera Roll folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;.%USERPROFILE%\Pictures\Camera Roll&quot;.
        ''' </summary>
        CameraRoll

        ''' <summary>
        ''' The per-user Temporary Burn Folder.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Burn\Burn&quot;.
        ''' </summary>
        CDBurning

        ''' <summary>
        ''' The common Administrative Tools folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
        ''' </summary>
        CommonAdminTools

        ''' <summary>
        ''' The common OEM Links folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\OEM Links&quot;.
        ''' </summary>
        CommonOemLinks

        ''' <summary>
        ''' The common Programs folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs&quot;.
        ''' </summary>
        CommonPrograms

        ''' <summary>
        ''' The common Start Menu folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu&quot;.
        ''' </summary>
        CommonStartMenu

        ''' <summary>
        ''' The common Startup folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
        ''' </summary>
        CommonStartup

        ''' <summary>
        ''' The common Templates folder.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Templates&quot;.
        ''' </summary>
        CommonTemplates

        ''' <summary>
        ''' The per-user Contacts folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%USERPROFILE%\Contacts&quot;.
        ''' </summary>
        Contacts

        ''' <summary>
        ''' The per-user Cookies folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Cookies&quot;.
        ''' </summary>
        Cookies

        ''' <summary>
        ''' The per-user Desktop folder.
        ''' Defaults to &quot;%USERPROFILE%\Desktop&quot;.
        ''' </summary>
        Desktop

        ''' <summary>
        ''' The common DeviceMetadataStore folder. Introduced in Windows 7.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\DeviceMetadataStore&quot;.
        ''' </summary>
        DeviceMetadataStore

        ''' <summary>
        ''' The per-user Documents folder.
        ''' Defaults to &quot;%USERPROFILE%\Documents&quot;.
        ''' </summary>
        Documents

        ''' <summary>
        ''' The per-user Documents library. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Documents.library-ms&quot;.
        ''' </summary>
        DocumentsLibrary

        ''' <summary>
        ''' The per-user Downloads folder.
        ''' Defaults to &quot;%USERPROFILE%\Downloads&quot;.
        ''' </summary>
        Downloads

        ''' <summary>
        ''' The per-user Favorites folder.
        ''' Defaults to &quot;%USERPROFILE%\Favorites&quot;.
        ''' </summary>
        Favorites

        ''' <summary>
        ''' The fixed Fonts folder.
        ''' Points to &quot;%WINDIR%\Fonts&quot;.
        ''' </summary>
        Fonts

        ''' <summary>
        ''' The per-user GameExplorer folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\GameExplorer&quot;.
        ''' </summary>
        GameTasks

        ''' <summary>
        ''' The per-user History folder.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\History&quot;.
        ''' </summary>
        History

        ''' <summary>
        ''' The per-user ImplicitAppShortcuts folder. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned\ImplicitAppShortcuts&quot;.
        ''' </summary>
        ImplicitAppShortcuts

        ''' <summary>
        ''' The per-user Temporary Internet Files folder.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Temporary Internet Files&quot;.
        ''' </summary>
        InternetCache

        ''' <summary>
        ''' The per-user Libraries folder. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries&quot;.
        ''' </summary>
        Libraries

        ''' <summary>
        ''' The per-user Links folder.
        ''' Defaults to &quot;%USERPROFILE%\Links&quot;.
        ''' </summary>
        Links

        ''' <summary>
        ''' The per-user Local folder.
        ''' Defaults to &quot;%LOCALAPPDATA%&quot; (&quot;%USERPROFILE%\AppData\Local&quot;)&quot;.
        ''' </summary>
        LocalAppData

        ''' <summary>
        ''' The per-user LocalLow folder.
        ''' Defaults to &quot;%USERPROFILE%\AppData\LocalLow&quot;.
        ''' </summary>
        LocalAppDataLow

        ''' <summary>
        ''' The fixed LocalizedResourcesDir folder.
        ''' Points to &quot;%WINDIR%\resources\0409&quot; (code page).
        ''' </summary>
        LocalizedResourcesDir

        ''' <summary>
        ''' The per-user Music folder.
        ''' Defaults to &quot;%USERPROFILE%\Music&quot;.
        ''' </summary>
        Music

        ''' <summary>
        ''' The per-user Music library. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Music.library-ms&quot;.
        ''' </summary>
        MusicLibrary

        ''' <summary>
        ''' The per-user Network Shortcuts folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Network Shortcuts&quot;.
        ''' </summary>
        NetHood

        ''' <summary>
        ''' The per-user Original Images folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Photo Gallery\Original Images&quot;.
        ''' </summary>
        OriginalImages

        ''' <summary>
        ''' The per-user Slide Shows folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%USERPROFILE%\Pictures\Slide Shows&quot;.
        ''' </summary>
        PhotoAlbums

        ''' <summary>
        ''' The per-user Pictures library. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Pictures.library-ms&quot;.
        ''' </summary>
        PicturesLibrary

        ''' <summary>
        ''' The per-user Pictures folder.
        ''' Defaults to &quot;%USERPROFILE%\Pictures&quot;.
        ''' </summary>
        Pictures

        ''' <summary>
        ''' The per-user Playlists folder.
        ''' Defaults to &quot;%USERPROFILE%\Music\Playlists&quot;.
        ''' </summary>
        Playlists

        ''' <summary>
        ''' The per-user Printer Shortcuts folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Printer Shortcuts&quot;.
        ''' </summary>
        PrintHood

        ''' <summary>
        ''' The fixed user profile folder.
        ''' Defaults to &quot;%USERPROFILE%&quot; (&quot;%SYSTEMDRIVE%\USERS\%USERNAME%&quot;)&quot;.
        ''' </summary>
        Profile

        ''' <summary>
        ''' The fixed ProgramData folder.
        ''' Points to &quot;%ALLUSERSPROFILE%&quot; (&quot;%PROGRAMDATA%&quot;,
        ''' &quot;%SYSTEMDRIVE%\ProgramData&quot;).
        ''' </summary>
        ProgramData

        ''' <summary>
        ''' The fixed Program Files folder.
        ''' This is the same as the ProgramFilesX86 known folder in 32-bit applications or the
        ''' ProgramFilesX64 known folder in 64-bit applications.
        ''' Points to %SYSTEMDRIVE%\Program Files on a 32-bit operating system or in 64-bit
        ''' applications on a 64-bit operating system and to %SYSTEMDRIVE%\Program Files (x86) in
        ''' 32-bit applications on a 64-bit operating system.
        ''' </summary>
        ProgramFiles

        ''' <summary>
        ''' The fixed Program Files folder (64-bit forced).
        ''' This known folder is unsupported in 32-bit applications.
        ''' Points to %SYSTEMDRIVE%\Program Files.
        ''' </summary>
        ProgramFilesX64

        ''' <summary>
        ''' The fixed Program Files folder (32-bit forced).
        ''' This is the same as the ProgramFiles known folder in 32-bit applications.
        ''' Points to &quot;%SYSTEMDRIVE%\Program Files&quot; on a 32-bit operating system and to
        ''' &quot;%SYSTEMDRIVE%\Program Files (x86)&quot; on a 64-bit operating system.
        ''' </summary>
        ProgramFilesX86

        ''' <summary>
        ''' The fixed Common Files folder.
        ''' This is the same as the ProgramFilesCommonX86 known folder in 32-bit applications or
        ''' the ProgramFilesCommonX64 known folder in 64-bit applications.
        ''' Points to&quot; %PROGRAMFILES%\Common Files&quot; on a 32-bit operating system or in
        ''' 64-bit applications on a 64-bit operating system and to
        ''' &quot;%PROGRAMFILES(X86)%\Common Files&quot; in 32-bit applications on a 64-bit
        ''' operating system.
        ''' </summary>
        ProgramFilesCommon

        ''' <summary>
        ''' The fixed Common Files folder (64-bit forced).
        ''' This known folder is unsupported in 32-bit applications.
        ''' Points to &quot;%PROGRAMFILES%\Common Files&quot;.
        ''' </summary>
        ProgramFilesCommonX64

        ''' <summary>
        ''' The fixed Common Files folder (32-bit forced).
        ''' This is the same as the ProgramFilesCommon known folder in 32-bit applications.
        ''' Points to &quot;%PROGRAMFILES%\Common Files&quot; on a 32-bit operating system and to
        ''' &quot;%PROGRAMFILES(X86)%\Common Files&quot; on a 64-bit operating system.
        ''' </summary>
        ProgramFilesCommonX86

        ''' <summary>
        ''' The per-user Programs folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs&quot;.
        ''' </summary>
        Programs

        ''' <summary>
        ''' The fixed Public folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%PUBLIC%&quot; (&quot;%SYSTEMDRIVE%\Users\Public)&quot;.
        ''' </summary>
        [Public]

        ''' <summary>
        ''' The common Public Desktop folder.
        ''' Defaults to &quot;%PUBLIC%\Desktop&quot;.
        ''' </summary>
        PublicDesktop

        ''' <summary>
        ''' The common Public Documents folder.
        ''' Defaults to &quot;%PUBLIC%\Documents&quot;.
        ''' </summary>
        PublicDocuments

        ''' <summary>
        ''' The common Public Downloads folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%PUBLIC%\Downloads&quot;.
        ''' </summary>
        PublicDownloads

        ''' <summary>
        ''' The common GameExplorer folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\GameExplorer&quot;.
        ''' </summary>
        PublicGameTasks

        ''' <summary>
        ''' The common Libraries folder. Introduced in Windows 7.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Libraries&quot;.
        ''' </summary>
        PublicLibraries

        ''' <summary>
        ''' The common Public Music folder.
        ''' Defaults to &quot;%PUBLIC%\Music&quot;.
        ''' </summary>
        PublicMusic

        ''' <summary>
        ''' The common Public Pictures folder.
        ''' Defaults to &quot;%PUBLIC%\Pictures&quot;.
        ''' </summary>
        PublicPictures

        ''' <summary>
        ''' The common Ringtones folder. Introduced in Windows 7.
        ''' Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Ringtones&quot;.
        ''' </summary>
        PublicRingtones

        ''' <summary>
        ''' The common Public Account Pictures folder. Introduced in Windows 8.
        ''' Defaults to &quot;%PUBLIC%\AccountPictures&quot;.
        ''' </summary>
        PublicUserTiles

        ''' <summary>
        ''' The common Public Videos folder.
        ''' Defaults to &quot;%PUBLIC%\Videos&quot;.
        ''' </summary>
        PublicVideos

        ''' <summary>
        ''' The per-user Quick Launch folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch&quot;.
        ''' </summary>
        QuickLaunch

        ''' <summary>
        ''' The per-user Recent Items folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Recent&quot;.
        ''' </summary>
        Recent

        ''' <summary>
        ''' The common Recorded TV library. Introduced in Windows 7.
        ''' Defaults to &quot;%PUBLIC%\RecordedTV.library-ms&quot;.
        ''' </summary>
        RecordedTVLibrary

        ''' <summary>
        ''' The fixed Resources folder.
        ''' Points to &quot;%WINDIR%\Resources&quot;.
        ''' </summary>
        ResourceDir

        ''' <summary>
        ''' The per-user Ringtones folder. Introduced in Windows 7.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Ringtones&quot;.
        ''' </summary>
        Ringtones

        ''' <summary>
        ''' The per-user Roaming folder.
        ''' Defaults to &quot;%APPDATA%&quot; (&quot;%USERPROFILE%\AppData\Roaming&quot;).
        ''' </summary>
        RoamingAppData

        ''' <summary>
        ''' The per-user RoamedTileImages folder. Introduced in Windows 8.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamedTileImages&quot;.
        ''' </summary>
        RoamedTileImages

        ''' <summary>
        ''' The per-user RoamingTiles folder. Introduced in Windows 8.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamingTiles&quot;.
        ''' </summary>
        RoamingTiles

        ''' <summary>
        ''' The common Sample Music folder.
        ''' Defaults to &quot;%PUBLIC%\Music\Sample Music&quot;.
        ''' </summary>
        SampleMusic

        ''' <summary>
        ''' The common Sample Pictures folder.
        ''' Defaults to &quot;%PUBLIC%\Pictures\Sample Pictures&quot;.
        ''' </summary>
        SamplePictures

        ''' <summary>
        ''' The common Sample Playlists folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%PUBLIC%\Music\Sample Playlists&quot;.
        ''' </summary>
        SamplePlaylists

        ''' <summary>
        ''' The common Sample Videos folder.
        ''' Defaults to &quot;%PUBLIC%\Videos\Sample Videos&quot;.
        ''' </summary>
        SampleVideos

        ''' <summary>
        ''' The per-user Saved Games folder. Introduced in Windows Vista.
        ''' Defaults to &quot;%USERPROFILE%\Saved Games&quot;.
        ''' </summary>
        SavedGames

        ''' <summary>
        ''' The per-user Searches folder.
        ''' Defaults to &quot;%USERPROFILE%\Searches&quot;.
        ''' </summary>
        SavedSearches

        ''' <summary>
        ''' The per-user Screenshots folder. Introduced in Windows 8.
        ''' Defaults to &quot;%USERPROFILE%\Pictures\Screenshots&quot;.
        ''' </summary>
        Screenshots

        ''' <summary>
        ''' The per-user History folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\History&quot;.
        ''' </summary>
        SearchHistory

        ''' <summary>
        ''' The per-user Templates folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\Templates&quot;.
        ''' </summary>
        SearchTemplates

        ''' <summary>
        ''' The per-user SendTo folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\SendTo&quot;.
        ''' </summary>
        SendTo

        ''' <summary>
        ''' The common Gadgets folder. Introduced in Windows 7.
        ''' Defaults to &quot;%ProgramFiles%\Windows Sidebar\Gadgets&quot;.
        ''' </summary>
        SidebarDefaultParts

        ''' <summary>
        ''' The per-user Gadgets folder. Introduced in Windows 7.
        ''' Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Sidebar\Gadgets&quot;.
        ''' </summary>
        SidebarParts

        ''' <summary>
        ''' The per-user OneDrive folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%USERPROFILE%\OneDrive&quot;.
        ''' </summary>
        SkyDrive

        ''' <summary>
        ''' The per-user OneDrive Camera Roll folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%USERPROFILE%\OneDrive\Pictures\Camera Roll&quot;.
        ''' </summary>
        SkyDriveCameraRoll

        ''' <summary>
        ''' The per-user OneDrive Documents folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%USERPROFILE%\OneDrive\Documents&quot;.
        ''' </summary>
        SkyDriveDocuments

        ''' <summary>
        ''' The per-user OneDrive Pictures folder. Introduced in Windows 8.1.
        ''' Defaults to &quot;%USERPROFILE%\OneDrive\Pictures&quot;.
        ''' </summary>
        SkyDrivePictures

        ''' <summary>
        ''' The per-user Start Menu folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu&quot;.
        ''' </summary>
        StartMenu

        ''' <summary>
        ''' The per-user Startup folder.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
        ''' </summary>
        Startup

        ''' <summary>
        ''' The fixed System32 folder.
        ''' This is the same as the SystemX86 known folder in 32-bit applications.
        ''' Points to &quot;%WINDIR%\system32&quot; on 32-bit operating systems or in 64-bit
        ''' applications on a 64-bit operating system and to &quot;%WINDIR%\syswow64&quot; in
        ''' 32-bit applications on a 64-bit operating system.
        ''' </summary>
        System

        ''' <summary>
        ''' The fixed System32 folder (32-bit forced).
        ''' This is the same as the System known folder in 32-bit applications.
        ''' Points to &quot;%WINDIR%\syswow64&quot; in 64-bit applications or in 32-bit
        ''' applications on a 64-bit operating system and to &quot;%WINDIR%\system32&quot; on
        ''' 32-bit operating system
        ''' </summary>
        SystemX86

        ''' <summary>
        ''' The per-user Templates folder
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Templates&quot;
        ''' </summary>
        Templates

        ''' <summary>
        ''' The per-user User Pinned folder. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned&quot;.
        ''' </summary>
        UserPinned

        ''' <summary>
        ''' The fixed Users folder. Introduced in Windows Vista.
        ''' Points to &quot;%SYSTEMDRIVE%\Users&quot;.
        ''' </summary>
        UserProfiles

        ''' <summary>
        ''' The per-user Programs folder. Introduced in Windows 7.
        ''' Defaults to &quot;%LOCALAPPDATA%\Programs.&quot;.
        ''' </summary>
        UserProgramFiles

        ''' <summary>
        ''' The per-user common Programs folder. INtroduced in Windows 7.
        ''' Defaults to &quot;%LOCALAPPDATA%\Programs\Common&quot;.
        ''' </summary>
        UserProgramFilesCommon

        ''' <summary>
        ''' The per-user Videos folder.
        ''' Defaults to &quot;%USERPROFILE%\Videos&quot;.
        ''' </summary>
        Videos

        ''' <summary>
        ''' The per-user Videos library. Introduced in Windows 7.
        ''' Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Videos.library-ms&quot;.
        ''' </summary>
        VideosLibrary

        ''' <summary>
        ''' The fixed Windows folder.
        ''' Points to &quot;%WINDIR%&quot;.
        ''' </summary>
        Windows
    End Enum
#End Region
End Module
