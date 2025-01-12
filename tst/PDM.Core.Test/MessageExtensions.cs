﻿namespace PDM.Core.Test;

[ExcludeFromCodeCoverage]
public static class MessageExtensions
{
    public static byte[] ToByteArray(this IMessage message)
    {
        var memStream = new MemoryStream();
        var stream = new CodedOutputStream(memStream);
        message.WriteTo(stream);
        stream.Flush();
        return memStream.ToArray();
    }

}
