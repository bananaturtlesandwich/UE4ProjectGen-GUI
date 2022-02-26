Some utility applications I made to streamline generating SDKs using UE4SS and UE4ProjectGenerator:

UE4ProjectGeneratorAutomator gives the [commandlet](https://github.com/Archengius/UE4GameProjectGenerator) a GUI, and will generate batchfiles so the process need not be repeated (still requires building the uproject beforehand)

HeaderCleaner iterates through the generated header files making everything public and all UPROPERTIES BlueprintReadWrite and EditAnywhere
It omits delegates and makes all UFUNCTIONS BlueprintCallable
