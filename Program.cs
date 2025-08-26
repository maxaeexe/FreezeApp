using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class Program : Form
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);
    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);
    [DllImport("kernel32.dll")]
    private static extern uint SuspendThread(IntPtr hThread);
    [DllImport("kernel32.dll")]
    private static extern int ResumeThread(IntPtr hThread);
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hHandle);

    private const int THREAD_SUSPEND_RESUME = 0x0002;

    private Process targetProcess;

    public Program()
    {
        string processName = "RobloxPlayerBeta";
        var process = Process.GetProcessesByName(processName);
        if (process.Length == 0)
        {
            MessageBox.Show("Process bulunamadı!");
            Environment.Exit(0);
        }
        targetProcess = process[0];

        RegisterHotKey(this.Handle, 1, 0, Keys.E);
        RegisterHotKey(this.Handle, 2, 0, Keys.R);
    }

    protected override void WndProc(ref Message m)
    {
        const int WM_HOTKEY = 0x0312;

        if (m.Msg == WM_HOTKEY)
        {
            int id = m.WParam.ToInt32();
            if (id == 1)
            {
                foreach (ProcessThread pT in targetProcess.Threads)
                {
                    IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, pT.Id);
                    if (pOpenThread != IntPtr.Zero)
                    {
                        SuspendThread(pOpenThread);
                        CloseHandle(pOpenThread);
                    }
                }
                Console.WriteLine("Process DONDURULDU!");
            }
            else if (id == 2)
            {
                foreach (ProcessThread pT in targetProcess.Threads)
                {
                    IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, pT.Id);
                    if (pOpenThread != IntPtr.Zero)
                    {
                        while (ResumeThread(pOpenThread) > 0) ;
                        CloseHandle(pOpenThread);
                    }
                }
                Console.WriteLine("Process DEVAM ETTİRİLDİ!");
            }
        }
        base.WndProc(ref m);
    }

    protected override void OnClosed(EventArgs e)
    {
        UnregisterHotKey(this.Handle, 1);
        UnregisterHotKey(this.Handle, 2);
        base.OnClosed(e);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Program());
    }
}
