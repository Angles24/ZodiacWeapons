# Zodiac Relic Weapons

This rofile set is designed to obtain your level 50 Zodiac weapon with as little interaction from the user as possible.

## Setup

Before you start, open the Start.xml and set your desired job to 1, all other jobs to 0. Only set one job to 1 or it will confuse the profiles. You really need to be level 80 to successfully bot these duties. You can do it at lower levels but you will need help on the duties.

Make sure you have completed your class quests up through level 50 to begin the relic quest.

In the Start.xml you will find a list of items, one for each job. You must buy this item and meld it with the required materia (also listed) and have it in your inventory before starting the profile. You can also find this list below.

			Bard		Longarm's Composite Bow				Heavens Eye Materia III X2
			Black Mage	Sanguine Scepter				Savage Might Materia III X2
			Dragoon		Champion's Lance				Savage Aim Materia III X2
			Monk		Wildling's Cesti				Savage Aim Materia III X2
			Ninja		Vamper's Knives	Heavens 			Eye Materia III X2
			Paladin		Aeolian Scimitar				Battledance Materia III X2
			Scholar		Erudite's Picatrix Of Healing			Quicktongue Materia III X2
			Summoner	Erudite's Picatrix Of Casting			Savage Might Materia III X2
			Warrior		Barbarian's Bardiche				Battledance Materia III X2
			White Mage	Madman's Whispering Rod				Quicktongue Materia III X2

You will need ExBuddy installed in your plugins folder which can be found here https://github.com/Entrax643/ExBuddy
You will need to take the ExTurnInGuildLeveTag.cs file from my Plugins folder and place it in RebornBuddy\Plugins\ExBuddy\OrderBotTags\Behaviors folder, overwriting the current one. This files makes some changes to fix the GuildLeve turn ins.

You will also need the latest version of LlamaLibrary installed in your botbases folder which can be found here https://github.com/nt153133/LlamaLibrary
(Make sure you update before running the profiles, Kayla is constantly making new tags for this set and you'll need the absolute latest.)


## Current Progress

All classes should be coded up to and acquiring the Atma weapon. 
The first three Fire books are done on Warrior, White Mage, and Summoner. 
Working on the rest.  

## Known Issues

Fates are wonky. Mostly due to Navigation with RB, so don't completely AFK during this part.

Copperbell Mines (Hard): One of the Collapsed Rocks has a smaller hitbox then RB thinks it does. Sometimes melee classes don't get close enough. Watch this.
