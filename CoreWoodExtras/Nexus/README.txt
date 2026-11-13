[size=6][b]HD Corewood Extras[/b][/size]

[img]https://imgup.uk/i/uAKTdABf.png[/img]


[size=5][b]Donations[/b][/size]

If you enjoy using this Valheim mod, please consider making a small donation to help support its development and future updates.

Even £1 or $1 would be greatly appreciated and would help more than you might think!

Thank you for your support, and happy gaming! ...... (A Paypal account is NOT required!)

[url=https://www.paypal.com/donate/?hosted_button_id=BN8HEWHRMAREU][img]https://imgup.uk/i/n7Sg7WK9.png[/img][/url]


[size=5][b]Configuration[/b][/size]

Settings are in [b]BepInEx/config/MagicMike.CoreWoodExtras.cfg[/b] (or press F7, in game or on the main menu, to open a panel with the settings of all your installed Magic Mike mods).

Most settings apply straight away. Any setting that needs a restart or a rebuilt piece says so in its description.


[size=5][b]Installation[/b][/size]

[b]Automatic Install[/b]

[list]
[*]Plugin is created to be installed with r2modman or Gale.
[/list]
For Nexus downloads you will need to install manually.

[b]Manual Install[/b]

[list]
[*]Un-zip and drag the [b]plugins[/b] folder into your [b]BepInEx[/b] folder.
[/list]


[size=5][b]Multiplayer[/b][/size]

[list]
[*]Every player and the server need this mod installed.
[*]Versions only need to match on the first number: anyone on 1.x.x can play with anyone else on 1.x.x, so a server and its players do not all have to update at the same time.
[*]Settings marked "synced from the server" use the server's values for everyone.
[/list]


[size=5][b]Credits[/b][/size]

[list]
[*]blacks7ar for the original idea, and for the Seed Bed idea.
[*]firstD for the Picture Frame code.
[/list]


[size=5][b]Plugins Created by Magic Mike[/b][/size]

[list]
[*][url=https://valheim.hexium.gg/mods/MagicMike/CoreWoodExtras]Corewood Extras[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/CorewoodFortified]Corewood Fortified[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/CorewoodAdditions]Corewood Additions[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/MyDirtyHoe]My Dirty Hoe[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/ChestPreview]Chest Preview[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/YabbaDabbaDoo]YabbaDabbaDoo[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/BetterBuildMenu]Better Build Menu[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/BetterCrafting]Better Crafting[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/BetterEquipSlots]Better Equip Slots[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/ExtraInventorySlots]Extra Inventory Slots[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/VillagePlebs]Village Plebs[/url]
[*][url=https://valheim.hexium.gg/mods/MagicMike/BodyReplacer]Body Replacer[/url]
[/list]


[size=5][b]FAQs[/b][/size]

[b]How do I get Mystical Seeds?[/b]
[spoiler]
Mystical Seeds can be bought from the traders.
[/spoiler]

[b]How do I customise a Picture Frame?[/b]
[spoiler]
To customise a picture frame you must first place the image you want to use in to your "BepInEx/config/CoreWoodExtras" directory. It is best to use a 16:9 ratio for the horizontal and vertical picture frames.

When in game look at the picture frame and press your use key (default E). Now paste the name off the image you want to add in to the text box.

For example: image-1_h.jpg

Images/Frames can also be scaled by adding the "s" abbreviation.

For example: image-1_h.jpg:s=2 (you can put a pictureframe that is 2 times bigger).

If you would like to run a slideshow of your images, you will need to create a new folder within the "BepInEx/config/CoreWoodExtras" directory. And then use the "i" abbreviation.

For example: horizontalimages:i=5 (Play the images in the horizontalimages folder at five-second intervals).
[/spoiler]

[b]How do I add/remove items from Burt the trader?[/b]
[spoiler]
Edit BurtItems.json in the BepInEx\config\CoreWoodExtras folder to add extra items for Burt to sell.

Each entry in the "items" array supports:

prefabName -------- the internal Valheim/mod prefab name for the item (not its display name).
stack ---------------- how many are sold per purchase.
price ---------------- coin price per stack.
requiredGlobalKey - leave empty to always be available, or set to a global key such as defeated_bonemass to gate it behind a boss kill.
enabled ------------set to false to keep an entry in the file without selling it.

Restart the game after editing BurtItems.json for changes to take effect.
[/spoiler]

[b]How do I use the Seed Bed and change what it can grow?[/b]
[spoiler]
The Seed Bed is in the Corewood-Greenhouse category. Press your use key while carrying enough seeds (or produce) to plant them, or use an item on the bed. When the timer finishes, press use again to harvest. The time it takes is the "Germination Duration" setting.

Turn on the "Auto Harvest" setting if you want the Seed Bed to harvest itself when it is ready. No Farming or Herbalist XP is given for automatic harvests. Harvesting by hand always drops the produce at the bed.

With the "Auto Store" setting on (the default), the produce of an automatic harvest is stored in the nearest chest with room (within the "Chest Range" setting), moving on to the next nearest when one is full. Feeding troughs count too, for the food they accept (carrots, turnips, onions and berries), so the bed can keep your tames fed. If there is no chest in range, or they are all full, the produce appears at the bed instead. Turn "Auto Store" off if you always want it to drop at the bed.

Turn on the "Auto Replant" setting to have the Seed Bed start growing again after each harvest (by hand or automatic).
Items that give themselves back, like Barley or Dandelion, are replanted from the harvest, you get the rest.
Any other item (CarrotSeeds -> Carrot, or one that gives back no more than you plant) takes its seeds from a chest within the "Chest Range" setting instead, the nearest one with enough is used. Keep a chest with seeds near the bed. If the chest runs out the bed waits empty, and starts again as soon as you add more seeds.
The Seed Bed only uses chests that its builder could open, so a private chest belonging to someone else is left alone. Seeds are never taken from feeding troughs (that would empty the food for your tames), and tombstones are never used.

Edit SeedBedItems.json in the BepInEx\config\CoreWoodExtras folder to change what it can grow. The file is created for you and reloads when you save it.

Each entry in the "conversions" array supports:

from ----------------- the prefab name of the item you plant (for example CarrotSeeds).
to -------------------- the prefab name of the item you get back (for example Carrot).
seedAmount ------ how many you plant.
producedItems --- how many you harvest.

The "herbs" array lists the harvested items that give Herbalist XP. Each entry can be a prefab name (Dandelion) or a shared name ($item_dandelion). Leave the array out to use the default list, or leave it empty for no Herbalist XP.

If you play on a server, use the same SeedBedItems.json on the server and every client. Delete the file and restart if you want it regenerated with the defaults.
[/spoiler]


[size=5][b]Comments/Suggestions/Help[/b][/size]

[url=https://www.nexusmods.com/valheim/mods/2806]Nexus[/url], [url=https://discord.gg/mnr36G6J4x]Discord[/url]


[size=5][b]Donations[/b][/size]

Please support this project if you can!

[url=https://www.paypal.com/donate/?hosted_button_id=BN8HEWHRMAREU][img]https://imgup.uk/i/n7Sg7WK9.png[/img][/url]
