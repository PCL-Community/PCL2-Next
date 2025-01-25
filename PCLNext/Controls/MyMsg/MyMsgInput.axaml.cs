using System;
using Avalonia.Controls.Primitives;
using PCL.Migration;

namespace PCL.Next.Controls.MyMsg;

public class MyMsgInput : TemplatedControl
{
    private readonly ModMain.MyMsgBoxConverter MyConverter;
    private readonly int Uuid = ModBase.GetUuid();

    public MyMsgInput(ModMain.MyMsgBoxConverter Converter)
    {
        try
        {
            InitializeComponent();

        } 
        catch (Exception ex)
        {
            Log(ex, "");
        }
    }
}