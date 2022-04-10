#pragma warning disable CS8604 // Possible null reference argument.
Console.Write("Enter the directory of UE4SS generated header files you wish to clean: ");
foreach (string file in Directory.GetFiles(@Console.ReadLine()))
{
    bool publicpassed = false;
    List<string> newfile = new List<string>();
    //List<string> delegates = new List<string>();
    //bool leavealone=false;
    string[] text = File.ReadAllLines(file);
    for (int i = 0; i < text.Length; i++)
    {
        //if(text[i].Contains("USTRUCT")|| text[i].Contains("UINTERFACE")) leavealone = true;
        /*Delegate declarations look like this so to get the data types I have to isolate FPlayerEventsHandChanged via string manipulation
                                                            |
                                                            |
                                                            V
        UDELEGATE() DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FPlayerEventsHandChanged, const UBaseHandData*, HandData);*/

        //if (text[i].Contains("UDELEGATE")) delegates.Add(text[i].Split('(')[2].Split(',')[0]);

        //This is only called on the first public:
        if (!publicpassed)
            if (text[i].Contains("public:"))
            {
                publicpassed = true;
                newfile.Add(text[i]);
                continue;
            }

        if (text[i].Contains("private:") || text[i].Contains("public:") || text[i].Contains("protected:")) continue;

        /*if (text[i].Contains("UPROPERTY"))
        {
            if (delegates.Contains(text[i + 1].Split(' ')[0])) newfile.Add(text[i + 1]);
            else newfile.Add("    UPROPERTY(EditAnywhere, BlueprintReadWrite)");
            continue;
        }

        if (text[i].Contains("UFUNCTION"))
        {
            newfile.Add("    UFUNCTION(BlueprintCallable,BlueprintNativeEvent)");
            continue;
        }*/
        newfile.Add(text[i]);
    }
    /*if(!leavealone)*/File.WriteAllLines(file, newfile);
}
Console.WriteLine("Cleaning operation complete");
Console.ReadKey();