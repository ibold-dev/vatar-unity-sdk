# Contributing

## Before opening a pull request

1. Open an issue for behavior changes, new public APIs, or new platform support.
2. Keep each pull request focused and backwards-compatible within the current major version.
3. Add or update EditMode tests for behavior changes.
4. Verify a Unity WebGL build when interop, packaging, or lifecycle behavior changes.
5. Never include credentials, sessions, payment data, or customer information in commits, logs, tests, or screenshots.

## Branch and commit conventions

Use short-lived branches and focused conventional commit messages, for example:

- `feat: add purchase recovery callback`
- `fix: reject malformed browser payloads`
- `docs: clarify sandbox integration`

## Pull request requirements

- Explain the user-visible change and any compatibility impact.
- Link the relevant issue.
- Include tests or explain why testing is not applicable.
- Update package version and changelog only as part of an approved release preparation change.

## Review requirements

At least one maintainer approval and passing required checks are required before merge. Maintainers should squash merge unless preserving a multi-commit history is valuable for release auditability.
