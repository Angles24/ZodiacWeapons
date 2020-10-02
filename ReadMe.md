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
- [X] Book of Skyfall II *
- Leve "Someone's In The Doghouse" must be done manually. The profile will pick it up and stop at the place for you to do it. Load the Start profile after.
- [X] Book of Netherfall I *
- The Ceruleum Road is triggered by speaking to the Wary Merchant at Camp Bluefog, Northern Thanalan (x21,y29). Start this manually.
- [X] Book of Skywind I *
- Fate "Suprise" is kinda hard for the bot to solo. It lets the NPCs die and then the Fate fails. Might need to do this manually.
- [X] Book of Skywind II
- [X] Book of Skyearth I
- [ ] Purchase Animus from Jalzahn


### Novus Zodiac Weapons
- [X] Celestial Radiance
- [X] Star Light, Star Bright
- [X]  Farming 75 Alexandrite
- [ ] Melding Materia to Scroll
- [ ] Purchase Novus Zodiac

### Nexus Zodiac Weapons
- [X] Mmmmmm, Soulglazed Relics
- [X] Light Farming * +
- [ ] Purchase Nexus Zodiac
* You must manually have Jalzhan soulglaze your relic before starting light farming.
+ You have three choices for Light Farming, see below.

### Zodiac Braves Weapons
- [X] Wherefore Art Thou, Zodiac
- [X] One Man's Trash
- [X] A Ponze of Flesh
- [X] Labor of Love
- [X] Mtheod in His Malice
- [X] A Treasured Mother
- Hullbreaker Isle: You will need to kill the final boss manually, then restart the Start.xml profile.
- [X] His Dark Materia
- [ ] Purchase Zodiac Weapon

### Zodiac Zeta Weapons
- [X] Rise and Shine
- [X] The Vital Title
- [X] Mahatma Light Farming
- [ ] Purchase Zodiac Zeta



+ I have written profiles to run Ifrit (Normal), Garuda (Extreme), and Satasha (Normal). By default the profiles will do Ifrit, which is the fastest but requires 250 runs, taking about 2.5hrs. Satasha takes 3.5hrs unless it's on bonus then it only takes 1.7hr. There's no way to check bonus other than just running the dungeon. Bonus rotates every2 hours. Gardua (Ex) is just slightly slwer than Ifrit, clocking in at about 2.7hr but it gets the advantage of possibly getting the Nightmare pony while running it. You can choose which one you want to do by opening /Quests/Relic Nexus.xml and changing the dungeon you wish to do to 1 at the top.

## Known Issues

If you die at any time, you'll need to restart the bot.

We cannot manually meld materia to your Sphere scroll. It will farm the 75 Alexandrite and obtain your Sphere scroll but you will need to manually meld the materia and go purchase the next level of relic.


* Fates
	* Fates are wonky. Mostly due to Navigation with RB, so don't completely AFK during this part. Or ever, really.
	* 'Tower of Power' is triggered by speaking to the House Haillenarte Guard at Boulder Downs, Coerthas Central Highlands (x10,y28). This must be done manually.
	* 'The Ceruleum Road' is trigger by speaking to the Wary Merchant. This must be done manually.
	* 'Surprise' FATE is hard for the bot to do on it's own. There's only two NPCs that need to be kept alive and the bot is horrible at that. Might want to do this one manually.
	
* Dungeons
	* Copperbell Mines (Hard): One of the Collapsed Rocks has a smaller hitbox then RB thinks it does. Sometimes melee classes don't get close enough. Watch this.
	* The Tousand Maws of Toto-Rak: The meshing here is absolutely horrible. Keep an eye on it as you run as it may not be able to get to some of the photocells that drop. And could possibly get stuck on things.
	* Hullbreaker Isle: Currently cannot fight the kraken due to no meshing of the fight area. You will need to do this fight manually, but the bot will do the rest of the instance.
	* Stone Vigil (Hard): The second fight Curca Fera is neigh impossible to solo, even by hand. Do this dungeon synced manually.
	
* Leves
	* You must already have levequests unlocked for the Whitebrim, Saint Coinarch's Find and Camp Bluefog. I can't automate those quests yet as they combine a quest and a levequest in one.
	* Levequests sometimes don't turn in all the way. May have to turn them in manually.
	* "Someone's in the Doghouse" will need to be done manually until I can find a way to automate the beckon escort quest.





