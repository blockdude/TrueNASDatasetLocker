# TrueNAS Dataset Locker

A Windows desktop application that connects to TrueNAS via WebSocket JSON-RPC to lock, unlock, and change passwords of encrypted ZFS datasets without using the TrueNAS web UI.

## Features

- Browse encrypted datasets under a configurable base path
- Lock one or more datasets (children first)
- Unlock one or more datasets with a passphrase (parents first)
- Change dataset passphrases
- Query dataset encryption status and usage
- Auto-update via GitHub releases

## Prerequisites

- Windows 10/11
- [.NET 8 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)
- TrueNAS server with:
  - WebSocket service enabled
  - Encrypted ZFS datasets
  - A user account with dataset management privileges

## Installation

Download the latest release from the [Releases page](https://github.com/blockdude/TrueNASDatasetLocker/releases) and run the executable.

## Usage

1. **Login** — Enter the TrueNAS hostname/IP, username, and password.
2. **Browse** — Datasets under the configured base path (default: `pool00/shares`) are displayed with their lock status and space usage.
3. **Select datasets** — Click to select one or more datasets from the list.
4. **Actions:**
   - **Lock** — Locks unlocked datasets (children locked before parents).
   - **Unlock** — Unlocks locked datasets (parents unlocked before children).
   - **Change Password** — Changes the passphrase for unlocked datasets.

## Configuration

Settings are stored in `Settings.json` next to the executable:

| Setting | Default | Description |
|---------|---------|-------------|
| `Path` | `pool00/shares` | Base dataset path to filter |
| `Port` | `80` | WebSocket port |
| `WSS` | `false` | Use secure WebSocket (`wss://`) |
| `SaveHostname` | `true` | Remember hostname between sessions |
| `SaveUsername` | `true` | Remember username between sessions |
| `ShowPatchNotes` | `true` | Show release notes after update |

## Security Notes

- Authentication uses the `PASSWORD_PLAIN` mechanism — passphrase is sent over the WebSocket connection. Enable WSS in settings when connecting over untrusted networks.
- Passwords are never saved to disk.
- Hostname and username are stored locally only when the corresponding save options are enabled.

## Auto-Update

On startup, the app checks GitHub for new releases. Updates are downloaded, verified by SHA-256, and applied automatically.
