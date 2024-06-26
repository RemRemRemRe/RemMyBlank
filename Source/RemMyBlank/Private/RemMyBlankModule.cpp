// Copyright RemRemRemRe, All Rights Reserved.

#include "RemMyBlankModule.h"
#include "Modules/ModuleManager.h"

IRemMyBlankModule& IRemMyBlankModule::Get()
{
	return FModuleManager::LoadModuleChecked< IRemMyBlankModule >( "RemMyBlank" );
}

bool IRemMyBlankModule::IsAvailable()
{
	return FModuleManager::Get().IsModuleLoaded( "RemMyBlank" );
}


class FRemMyBlankModule final : public IRemMyBlankModule
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FRemMyBlankModule, RemMyBlank)

void FRemMyBlankModule::StartupModule()
{
	// This code will execute after your module is loaded into memory (but after global variables are initialized, of course.)
	IRemMyBlankModule::StartupModule();
}

void FRemMyBlankModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
	IRemMyBlankModule::ShutdownModule();
}
