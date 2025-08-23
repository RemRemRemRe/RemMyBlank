// Copyright RemRemRemRe, All Rights Reserved.

#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"
#include "RemMyBlankStatics.generated.h"

#define REM_API REMMYBLANK_API

UCLASS()
class REM_API URemMyBlankStatics : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

public:
};

namespace Rem::MyBlank
{

}

#undef REM_API
