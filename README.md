# Dynamic Interior Variety

Dynamic Interior Variety is a mod that dynamically raises and lowers the rarity of possible interiors based on how many times in a session it’s been successfully selected and how many times it’s been unsuccessfully selected. The aim of this mod is to naturally increase interior variety on top of handcrafted configuration.

The mod has two configurable values in the form of a `selectedMultiplier` and a `unselectedMultplier`. The rarity of each interior during the selection process is raised by the amount of times it’s been unsuccessfully chosen multiplied by the `unselectedMultiplier` and then lowered by the amount of times it’s been successfully selected multiplied by the `selectedMultiplier`.

Currently the mod runs on previously selection knowledge via all playthroughs in the current session and not per save.

The config values in the mod are not network synced but due to LethalLevelLoader’s selection process this will never desync the actual selection, only the simulate command.