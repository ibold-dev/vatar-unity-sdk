# Repository guidance

## Scope

This repository contains the Vatar Games Unity package for Unity WebGL. The package is a client-side bridge only: developer secrets, purchase verification, entitlement delivery, webhook verification, and match-result signatures belong on a developer-controlled server.

## Working rules

- Keep the public API platform-neutral, but implement browser interop only in WebGL-specific files.
- Do not copy, bundle, or modify the upstream `vatar-games-v1.js`; load it from its official URL at runtime.
- Never log session tokens, secrets, payment identifiers, or webhook payloads in production code.
- Add or update tests whenever public behavior changes.
- Maintain backward compatibility within a major version, and document breaking changes in the release notes.
- Keep commits focused, with one behavior or maintenance concern per commit.

## Validation

- Validate JSON and YAML before committing.
- Run Unity EditMode tests for package changes when Unity is available.
- Validate a WebGL build in the Vatar sandbox before publishing a release.
