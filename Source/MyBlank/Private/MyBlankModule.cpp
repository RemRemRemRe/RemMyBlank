// Copyright Epic Games, Inc. All Rights Reserved.

#include "MyBlankModule.h"

class FMyBlankModule : public IMyBlankModule
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FMyBlankModule, MyBlankModule)

void FMyBlankModule::StartupModule()
{
	// This code will execute after your module is loaded into memory (but after global variables are initialized, of course.)
	IMyBlankModule::StartupModule();
}

void FMyBlankModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
	IMyBlankModule::ShutdownModule();
}