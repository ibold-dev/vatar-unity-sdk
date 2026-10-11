# Security Policy

## Supported versions

Security fixes are provided for the latest released minor version. Pre-release builds may change without notice.

## Reporting a vulnerability

Do not open a public issue for a suspected vulnerability. Email [support@lagoslife.app](mailto:support@lagoslife.app?subject=Security) with subject `Security` and include:

- a concise description and affected version;
- reproduction steps or a proof of concept;
- potential impact; and
- a safe contact method for follow-up.

Do not include real secrets, payment data, player sessions, or personal information. Reports are acknowledged as soon as practical, assessed privately, and fixed through a coordinated release when confirmed.

## Security boundaries

- The Unity package is an untrusted browser client.
- Vatar API, webhook, and match-result secrets must only exist in a developer-controlled backend.
- Purchase callbacks are not proof of payment; the backend must verify every purchase with Vatar before granting an entitlement.
- Webhook signatures must be verified over the raw body using constant-time comparison.
