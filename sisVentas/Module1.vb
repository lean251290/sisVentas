Module Module1
    Public Function ImageToByte(ByVal img As Image) As Byte()
        Dim ms As New IO.MemoryStream
        img.Save(ms, img.RawFormat)
        ImageToByte = ms.GetBuffer
    End Function

    Public Function ByteToImage(ByVal b As Byte()) As Image
        Dim ms As New IO.MemoryStream(b)
        Dim img As Image = Image.FromStream(ms)
        ByteToImage = img
    End Function
End Module
