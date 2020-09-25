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

I'm in the process of changing over all the movement in this profile to be handled by Lisbeth. Saga's new Sextant 2.0 is far suprior to anything else RebornBuddy has to offer and makes for a much smoother questing experience. As such, you will need Lisbeth to make these profiles work. If you don't have it, you can find it here: https://www.siune.io/


## Current Progress

### A Relic Reborn
- [x] A Relic Reborn Quest
- [x] A Relic Reborn the Chimera, A Relic Reborn the Hydra, The Howling Eye (Hard), The Bowl of Embers (Hard), The Naval (Hard)

### Zenith Zodiac Weapons
- [x] Purchase Zenith relic from Furnace. Requires 3 Thavnairian Mists.

### Atma Zodiac Weapons
- [x] Up in Arms
- [x] Atma Fate Farm
- [x] Purchase Atma from Jalzahn

### Animus Zodia Weapons
- [x] Trials of the Braves
- [x] Book of Skyfire I
- [x] Book of Skyfire II
- [x] Book of Netherfire I
- [X] Book of Skyfall I
- [X] Book of Skyfall II
- [X] Book of Netherfall I
- [X] Book of Skywind I
- [X] Book of Skywind II
- [X] Book of Skyearth I
- [ ] Purchase Animus from Jalzahn

### Novus Zodiac Weapons
- [ ] Celestial Radiance
- [ ] Star Light, Star Bright
- [ ] Farming 75 Alexandrite
- [ ] Melding Materia
- [ ] Purchase Novus Zodiac

### Nexus Zodiac Weapons
- [ ] Mmmmmm, Soulglazed Relics
- [ ] Light Farming
- [ ] Purchase Nexus Zodiac

### Zodiac Braves Weapons
- [ ] Wherefore Art Thou, Zodiac
- [ ] One Man's Trash
- [ ] A Ponze of Flesh
- [ ] Labor of Love
- [ ] Mtheod in His Malice
- [ ] A Treasured Mother
- [ ] His Dark Materia

### Zodiac Zeta Weapons
- [ ] Rise and Shine
- [ ] The Vital Title
- [ ] Mahatma Light Farming

## Known Issues

If you die at any time, you'll need to restart the bot.

* Fates
	* Fates are wonky. Mostly due to Navigation with RB, so don't completely AFK during this part. Or ever, really.
	* Tower of Power is triggered by speaking to the House Haillenarte Guard at Boulder Downs, Coerthas Central Highlands (x10,y28).
	
* Dungeons
	* Copperbell Mines (Hard): One of the Collapsed Rocks has a smaller hitbox then RB thinks it does. Sometimes melee classes don't get close enough. Watch this.
	* The Tousand Maws of Toto-Rak: The meshing here is absolutely horrible. Keep an eye on it as you run as it may not be able to get to some of the photocells that drop. And could possibly get stuck on things.
	* Hullbreaker Isle: Currently cannot fight the kraken due to no meshing of the fight area. You will need to do this fight manually, but the bot will do the rest of the instance.
	
* Leves
	* You must already have levequests unlocked for the Whitebrim, Saint Coinarch's Find and Camp Bluefog. I can't automate those quests yet as they combine a quest and a levequest in one.
	* Levequests sometimes don't turn in all the way. May have to turn them in manually.
	* "Someone's in the Doghouse" will need to be done manually until I can find a way to automate the beckon escort quest.
	* Necrologos: The Liminal Ones & Necrologos: Pale Oblation. I can't figure ou thow to get these to exit the UseObject tag properly. So for now they're set to manual completion.





