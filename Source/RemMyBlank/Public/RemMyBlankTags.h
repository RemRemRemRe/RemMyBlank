// Copyright RemRemRemRe, All Rights Reserved.

#pragma once

#include "RemMetaTags.h"
#include "RemMyBlankTags.generated.h"

#define REM_API REMMYBLANK_API

UCLASS(Config = RemMyBlankTags)
class REM_API URemMyBlankTags : public URemMetaTags
{
	GENERATED_BODY()
};

#undef REM_API
