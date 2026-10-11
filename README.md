# Vatar Games Unity SDK

The Vatar Games Unity SDK integrates Unity WebGL games with the Vatar Games browser SDK. It exposes player identity, session tokens, purchases, leaderboards, lifecycle events, and multiplayer matches through a typed C# API.

## Status

The repository is being prepared for its first production release. Until a stable release is tagged, consume it from a pinned Git commit and validate in the Vatar sandbox.

## Platform support

| Platform | Support |
| --- | --- |
| Unity WebGL in the Vatar game player | Supported |
| Unity Editor | Simulated or unsupported runtime behavior only |
| Native mobile, desktop, and console | Not supported |

## Security boundary

The package must never contain Vatar API, webhook, or match-result secrets. A game sends a fresh Vatar session token and purchase identifier to its own backend; that backend verifies and delivers purchases through the Vatar API.

See the official [Vatar Games documentation](https://lagoslife.app/developers/docs) for platform and review requirements.

## Package location

The Unity Package Manager package is located at `Packages/com.vatar.games`.

## Contributing and security

Read [CONTRIBUTING.md](CONTRIBUTING.md), [SECURITY.md](SECURITY.md), and [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) before participating.
