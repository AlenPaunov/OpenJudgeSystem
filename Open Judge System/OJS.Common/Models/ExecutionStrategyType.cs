﻿namespace OJS.Common.Models
{
    public enum ExecutionStrategyType
    {
        DoNothing = 0,
        CompileExecuteAndCheck = 1,
        NodeJsPreprocessExecuteAndCheck = 2,
        RemoteExecution = 3,
        JavaPreprocessCompileExecuteAndCheck = 4,
        PhpCgiExecuteAndCheck = 5,
        PhpCliExecuteAndCheck = 6,
        CheckOnly = 7,
        JavaZipFileCompileExecuteAndCheck = 8
    }
}
