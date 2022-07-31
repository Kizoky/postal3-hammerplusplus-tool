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
![scr-1](https://imgur.com/i3TwxXu.png)

# How-To
- Use the program to link directories, it'll look for a valid Hammer++ installation in Source SDK Base 2013 (Hammer++ should not be put in Postal 3's bin folder!!), and 'p3' or 'cr_base' folder in Postal 3 if it's a valid Postal 3 installation
- Put Postal 3's Hammer FGD file into the FGD Fixer, it'll create a fixed copy of the FGD which you need to use later
- In Hammer++ use 'SourceTest' when it asks for a game configuration to use (don't attempt creating a custom configuration because it will not work properly!)
- Go to 'Tools->Options...' and add the fixed FGD into 'Game Data files'
- If Hammer++ is showing black screen, relink directories, and avoid linking 'shaders' or 'sound' folder next time

# Why does this work?
Hammer++ crashes whenever it's opened in Postal 3's root folder, as such there had to be an alternative way of loading maps with the map editor.

Creating a custom folder in sourcetest, game folders, and linking them correctly will make Hammer++ work without any issues, of course that is if we don't mention it's original FGD.

Hammer++ needs to be placed in the bin folder (not Postal III's!!) for this to work.

Note: This DOES NOT actually copy the files, this creates a LINK which won't affect your hard disk space
