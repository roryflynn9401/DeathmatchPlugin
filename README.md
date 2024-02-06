# Deathmatch Plugin

## Changes/Features
- Remove healthshots
- Add auto-heal on headshot
- Make auto-reload on headshot
- Auto exec server cfg on hibernation change & map start

### Coming Soon
- Server leaderboard
- Admin controls
- Server info/management API (might release as seperate plugin, check my [profile](https://github.com/roryflynn9401) to see)

## Intended use
This is built as a team deathmatch plugin, with player configurable loadouts, killstreaks, and a buy menu integration.

## Installation
NOTE: I'd recommend updating `dllinclude\CounterStrikeSharp.dll` to the exact version running on your server for maximum compatibility, the included dll is `v27`.

- `dotnet build`
- [Install CounterStrikeSharp](https://docs.cssharp.dev/)
- Create a directory named `DeathmatchPlugin` in `game/csgo/addons/counterstrikesharp/plugins`
- Place `bin/[Release|Debug]/net7.0/DeathmatchPlugin.dll` in the directory you just created
- profit?

## Configuration
`plugins/deathmatch.config.json`: (default)
```json
{
  "chatSpamMessages": [
    "<lime>Type /guns in chat to get a printout (in console) of all weapon commands!</lime>"
  ],
  "chatPrefix": "[<green>DM</green>]",
  "debug": false
}
```
`chatSpamMessages` and `chatPrefix` are configurable with colors as seen above, a full list of tag names is available in [Utilities/Colored.cs](DeathmatchPlugin/Utilities/Colored.cs) 

## Dependencies
- CounterStrikeSharp

## License
see [LICENSE.md](./LICENSE.md)
