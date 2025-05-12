
# PCSX2 QT EEMEM Finder

This project demonstrates how to access the shared memory of the PCSX2 emulator (QT version) to read data directly from its memory-mapped file. It can be useful for debugging, memory analysis, or creating tools that interact with PCSX2.

## How It Works

The program identifies the running PCSX2 process and accesses its memory-mapped file using the process ID. It then reads the first 32 bytes of the shared memory and displays them in hexadecimal format.

## Inspiration

The technique used in this project was inspired by studying the source code of PCSX2. The emulator uses memory-mapped files to share data between its components, which can be accessed externally with the appropriate permissions.

## Usage

1. Ensure that PCSX2 (QT version) is running.
2. Build and run the program.
3. The program will attempt to locate the shared memory and display the first 32 bytes.

## Disclaimer

This project is for educational purposes only. Use it responsibly and ensure compliance with any applicable laws or terms of service.
