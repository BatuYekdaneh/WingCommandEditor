using WingTextEditor.Core;

namespace WingEditor
{
    public class WingCommandEditor
    {
        static void ExecutingTheWing()
        {
            while (true)
            {
                string data = "";
                string tempData = "";
                while (tempData != "run")
                {
                    data += tempData + "\n";
                    tempData = Console.ReadLine();
                    if (tempData == "exit")
                        return;
                }
                Console.WriteLine(Wing.Execute(data));
            }
        }
        public static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(ExecutingTheWing));
            thread.Start();
        }
    }
}
