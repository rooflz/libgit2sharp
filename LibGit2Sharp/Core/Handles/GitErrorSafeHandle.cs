using System;

namespace LibGit2Sharp.Core.Handles
{
    internal class GitErrorSafeHandle : NotOwnedSafeHandleBase
    {
        public GitError MarshalAsGitError()
        {
            return handle.MarshalAs<GitError>();
        }
    }
}
