# Releasing

1. Confirm the target changes have passed CI and sandbox validation.
2. Update `Packages/com.vatar.games/package.json` and `CHANGELOG.md` in one release-preparation pull request.
3. Merge the pull request after approval.
4. Create and push an annotated tag matching the package version, for example `v0.1.0`.
5. The protected `release` GitHub Environment runs the release workflow, which verifies the tag and attaches the package archive to the GitHub Release.

The workflow does not publish to a registry. Registry publishing is enabled only after a maintainer explicitly adds the selected registry credentials and an approved publishing job.
