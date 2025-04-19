using System;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

class Program
{
    static void Main()
    {
        var proc = Process.GetProcessesByName("pcsx2-qt").FirstOrDefault();
        if (proc == null) { Console.WriteLine("PCSX2 not running."); return; }
        string mapName = $"pcsx2_{proc.Id}";
        try
        {
            var mmf = MemoryMappedFile.OpenExisting(mapName);
            using var accessor = mmf.CreateViewAccessor();
            Console.WriteLine($"Opened shared memory: {mapName}");

            // Read some bytes
            byte[] buffer = new byte[32];
            accessor.ReadArray(0, buffer, 0, buffer.Length);
            Console.Write("First 32 bytes: ");
            foreach (byte b in buffer)
                Console.Write($"{b:X2} ");
        }
        catch
        {
            Console.WriteLine($"Shared memory '{mapName}' not found.");
        }
    }
}
