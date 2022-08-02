# Postal III Hammer++ Tool
This is a program to help you getting Hammer++ work with the infamously bad Source engine game called Postal III. Only works on Windows 7 or above.

# Features
- Link Directories with just a few clicks
- Select Folders you wish to link
- Built-in Hammer FGD tool, which fixes errors with Postal III's FGD
- Clear linked folders with just a single click
- Save current path to both SDK and P3 installations, or switch between presets

![App](https://i.imgur.com/e63Xsia.png)
![Features](https://i.imgur.com/8ujpwC9.png)

# Postal 3 Maps with Hammer++
![scr-1](https://imgur.com/i3TwxXu.png)
![scr-2](https://imgur.com/E2ZGByn.png)
![scr-3](https://imgur.com/gm3k6ye.png)

# Tutorial
- Make sure you have the Source SDK 2013 Singleplayer version of Hammer++ downloaded, and installed in Source SDK Base 2013. (NOT in Postal 3)
- Make sure you have the Postal 3 SDK already installed. (for the FGD file)
- When opening the program, give the path to both Source SDK Base 2013, and Postal 3. (for Source SDK Base 2013 the program will check if you have Hammer++ installed)
- Use the program to link directories, models, materials, particles, shaders, sound... (models and materials are already ticked by default)
- Put Postal 3's Hammer FGD file into the FGD Fixer, it'll create a fixed copy of the FGD which you need to use later in Hammer++.
- In Hammer++ use 'SourceTest' when it asks for a game configuration to use (don't attempt creating a custom configuration because it will not work properly!)
- Go to 'Tools->Options...' and add the fixed Postal 3 FGD file into 'Game Data files', then restart Hammer++.
- If Hammer++ is showing a black screen, relink directories, and avoid linking 'shaders' or 'sound' folder next time.
- When compiling maps, AVOID using Hammer++'s built-in compiler, use Postal 3's Hammer for that - or by using CompilePal.

# Technical Details
- Hammer++ crashes whenever it's opened from Postal 3's bin folder, the reason is unknown.
- Hammer++ Tool will create a folder called 'custom' in 'sourcetest' directory (Source SDK Base 2013), and creates the linkaging there, this way we are able to load Postal 3 content for the maps.
- Hammer++ Tool's FGD Fixer will comment out a few Postal 3-only features that are called prefabs, which is unsupported by any HL2-like Hammer. (npc_prefab; ammo_prefab; node_prefab; item_prefab)
- Linking DOES NOT affect disk space, it is just "redirection".
- Clicking 'Clear Linked Folders' will delete the linkers from 'sourcetest/custom' folder, it will NOT delete the real content.
- If you have a Preset saved, it will be automatically loaded on program startup.
