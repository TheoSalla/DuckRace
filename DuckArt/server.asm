; Declare constants for use in the program
%define SOCKET_ERROR -1
%define INVALID_SOCKET -1
%define AF_INET 2
%define SOCK_STREAM 1
%define IPPROTO_TCP 6

; Import functions from the Windows API
%include "win32a.inc"

; Declare variables
section .data
    hinst dd 0
    hwnd dd 0
    wc WNDCLASSEX 16
    msg MSG
    wndclassName db "MyWindowClass",0
    szTitle db "My Window",0
    port dd 10000
    addr sockaddr_in
    listen_sock SOCKET INVALID_SOCKET
    client_sock SOCKET INVALID_SOCKET
    buffer db 1024 dup(0)
    addr_size dd sizeof sockaddr_in
    bytes_received dd 0

section .text
    ; Initialize the Windows Sockets API
    invoke WSAStartup, 0x0202, addr wsaData
    cmp eax, 0
    jne exit
    
    ; Create a socket for the server
    invoke socket, AF_INET, SOCK_STREAM, IPPROTO_TCP
    mov listen_sock, eax
    cmp eax, INVALID_SOCKET
    je exit
    
    ; Set up the sockaddr_in structure
    mov [addr.sin_family], AF_INET
    mov [addr.sin_port], port
    mov [addr.sin_addr], 0
    
    ; Bind the socket to the port
    invoke bind, listen_sock, addr sockaddr_in, sizeof sockaddr_in
    cmp eax, SOCKET_ERROR
    je exit
    
    ; Start listening for incoming connections
    invoke listen, listen_sock, SOMAXCONN
    cmp eax, SOCKET_ERROR
    je exit
    
loop:
    ; Accept an incoming connection
    invoke accept, listen_sock, addr sockaddr_in, addr addr_size
    mov client_sock, eax
    cmp eax, INVALID_SOCKET
    je exit
    
    ; Receive data from the client
    invoke recv, client_sock, buffer, 1024, 0
    mov bytes_received, eax
    cmp eax, SOCKET_ERROR
    je exit
    
    ; Print the received data to the console
    invoke printf, buffer
    
    ; Close the client socket
    invoke closesocket, client_sock
    
    ; Loop to accept more connections
    jmp loop
    
exit:
    ; Clean up
    invoke closesocket, listen_sock
    invoke WSACleanup
    ret
