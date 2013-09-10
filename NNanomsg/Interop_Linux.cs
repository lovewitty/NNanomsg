﻿using System;
using System.Runtime.InteropServices;

public partial class NNanomsg
{
    internal class Interop_Linux
    {
        [DllImport("libnanomsg.so")]
        public static extern int nn_socket(int domain, int protocol);

        [DllImport("libnanomsg.so")]
        public static extern int nn_connect(int s, [MarshalAs(UnmanagedType.LPTStr)]string addr);

        [DllImport("libnanomsg.so")]
        public static extern int nn_bind(int s, [MarshalAs(UnmanagedType.LPTStr)]string addr);

        [DllImport("libnanomsg.so")]
        public static extern int nn_send(int s, byte[] buf, int len, int flags);

        [DllImport("libnanomsg.so")]
        public static extern int nn_recv(int s, byte[] buf, int len, int flags);

        [DllImport("libnanomsg.so")]
        public static extern int nn_errno();

        [DllImport("libnanomsg.so")]
        public static extern int nn_close(int s);

        [DllImport("libnanomsg.so")]
        public static extern int nn_shutdown(int s, int how);

        [DllImport("libnanomsg.so")]
        public static extern IntPtr nn_strerror(int errnum);

        [DllImport("libnanomsg.so")]
        public static extern int nn_device(int s1, int s2);
        
        [DllImport("libnanomsg.so")]
        public static extern void nn_term();
    }
}