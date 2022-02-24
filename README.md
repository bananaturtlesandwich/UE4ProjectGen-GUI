Some utility applications I made to streamline generating SDKs using UE4SS and UE4ProjectGenerator:

UE4ProjectGeneratorAutomator gives the [commandlet](https://github.com/Archengius/UE4GameProjectGenerator) a GUI, and will generate batchfiles so the process need not be repeated

HeaderCleaner iterates through the generated header files making everything public and all UPROPERTIES BlueprintReadWrite and EditAnywhere
It omits delegates and as of now does not touch UFUNCTIONS
