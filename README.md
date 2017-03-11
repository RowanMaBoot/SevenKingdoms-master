# SevenKingdoms-master
Seven Kingdoms for Crusader Kings 2 Master

Current State: Alpha, Prototype

Status: Functional

Paradox Forum Link: https://forum.paradoxplaza.com/forum/index.php?threads/wip-the-seven-kingdoms.1003243/

-------------

NOTE:
ZeroFighterR, using Excel, ran into an issue where the (C) symbol would be autocorrected into the copyright symbol ©. This is bad, because it won't be recognised and will throw up errors when we compile the map. A quick fix can be found here: http://www.journalofaccountancy.com/issues/2008/nov/stopexcelfromdisplayingthecopyrightsymbolwhenyouwantc.html

OpenOffice Calc does the same, but you can navigate to Tools -> AutoCorrectOptions (at the bottom) and delete the (C) to copyright symbol.

NEW:
I've also recently added a section concerning barony counts for provinces. It is an extension of the already existing group 'How many baronies should be assigned to a province?'. It is a fairly straightforward list.

-------------

Welcome!

The Seven Kingdoms is a mod for Crusader Kings 2, built for large multiplayer games in a sandbox environment, generally with a predefined setting. It will feature bookmarks from the years 7400-8000, the last dates stopping before the 'Doom of Valyria'.

With over 1400 Provinces, the mod rivals the Vanilla game and exceeds the 'Game of Thrones Mod' in regards to the number of provinces. However, it will likely feature far fewer events and simplified mechanics for the purpose of stable and engaging multiplayer.

Intensity wise, it will likely be on par with the Vanilla game, though we intend for it to be just as stable as what most users would have come to expect from the official developers. Good practice with how we create our events and decisions, and how we write our triggers will be of great importance. Avoiding intensive events and mechanics, although great for singleplayer, such as the Winter event and Slavery Chains seen in the excellent Game of Thrones mod, will be but a small way we hope to boost our performance.

We intend to make all of this mod's mechanics from scratch, if possible. It will be updated on a very much long-term process, and early playable versions will likely be used for our weeklies.

# So, looking to contribute?

One of the main objectives is to fill the map. Baronies need to be added, names need to be assigned to duchies, baronies and provinces. This can all be done through one file:

You can find it in:

SevenKingdoms-master/The_Seven_Kingdoms/map/

The Name of the file is:

provinceDef.xls

I personally use OpenOffice to edit this file.

If you have Excel, that will be fine. If you edit the file, when you save it you will generally be prompted as to whether or not you want to save it in it's existing format, or convert it to a new format. This message will be different for each tool, so make sure that whatever option is selected, it is one that preserves the format being used, otherwise there may be issues.

###### So what to do with Baronies?

The column, titled numH, contains everything related to the number of holdings. For example, you'll see in that column values such as 1_1 (by default) or in some cases 1_7, 7_7 and so on.

The first number (x) x_1 is the number of prebuilt holdings. The second number (x) 1_x is the maximum number of holdings that can be built. With a value of 1_7, we will have a prebuilt capital holding (you cannot have any less) with 6 possible sub-baronies.

With a value of 2_3, you will have the capital barony, one sub barony and one barony that can be built.

By default, if you do not specify a name for the barony in the following cells to the right of 1_1, they will have a name generated for them based on the name of the province. Examples would be Temple of Winterfell, Castle of Winterfell, Town of Winterfell 1, Town of Winterfell 2.

If you can, please try naming all of the slots!

NEW:

Quick overview (needs to be adjusted):

x_7 = City of the World's Desire
Examples: King's Landing, Braavos, Pentos

x_6 = Major City or Region
Examples: Highgarden, Lannisport

x_5 = Regional Capital, or Duchy Capital of unusually small duchy
Examples: Casterly Rock

x_4 = Duchy Capital

x_3 = Minor Province

x_2 = Insignificant Region

x_1 = Small Island

###### How many baronies should be assigned to a province?

Generally major provinces, such as blackwater bay, the capitals of the free cities and places of major economic significance may have a maximum of 1+6 holdings.

The capitals of Kingdoms/Paramounts should have 1+4or5, unless there is good reason to have a higher number.

Duchy capitals should have 1+3or4, whilst most provinces should have 1+2or3.

Small islands or unusually small provinces should just have 1_1, in other words; just their capital. If we feel there is good reason to increase the maximum number of holdings to say 1_2, that can be done but generally we want to avoid it.

Beyond the wall should average at 1_3 at minimum, whilst 1_6 at most, unless we decided to allow building of holdings and feudalism for Wildlings.

Iron Isles, Pirate Isles should be limited. Pirate isles should probably have no possible buildable holdings, regardless of island size.

# Land Titles and History

You can edit files within:

The_Seven_Kingdoms/history/titles/
The_Seven_Kingdoms/history/characters/

Be extremely careful about edits made within this folder:

The_Seven_Kingdoms/common/landed_titles/

This is because 01_landed_titles.txt will be overwritten repeatedly during development. This cannot be avoided. This file is generated by one of the tools we use; the MapFiller tool. If you want to make soft changes to landed_titles, you need to create an override file.

An example file has been provided:

02_OVERRIDE_vanilla_hardcoded_titles.txt

So, for example, if you want to edit titles, create a file called 02_OVERRRIDE_regionname_titles.txt, however do not edit tiles with a placeholder name. For example, editing c_province_id_554 or d_duchy_id_336 won't work if those titles are renamed. In other words, only edit properly named titles.

If you want to add new titular titles, put them in a 03_TITULAR_regionname_titles.txt file. Try not to link them to any pre-existing title, in case said titles are not final. That sort of stuff can be sorted later.

# Characters and Dynasties

We are also looking for characters and Dynasties. Banners for their houses are not important, and placeholders can be used.
