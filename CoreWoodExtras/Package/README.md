![](https://imgup.uk/i/RlDzGrHb.png)

# 🎯 HD Corewood Extras

<br>

## 💶 Donations: 

If you enjoy using this Valheim mod, please consider making a small donation to help support its development and future updates.

Even £1 or $1 would be greatly appreciated and would help more than you might think!

Thank you for your support, and happy gaming! ⚔️  ...... (A Paypal account is NOT required!)

<a href="https://www.paypal.com/donate/?hosted_button_id=BN8HEWHRMAREU">![](https://imgup.uk/i/n7Sg7WK9.png)</a>
<br>
<br>
<br>

  
## 🎚️ Configuration:

Settings are in `BepInEx/config/MagicMike.CoreWoodExtras.cfg` (or press F7, in game or on the main menu, to open a panel with the settings of all your installed Magic Mike mods).

Most settings apply straight away. Any setting that needs a restart or a rebuilt piece says so in its description.

<br>

## 💻 Installation:

### Automatic Install

  * Plugin is created to be installed with r2modman or Gale.
For Nexus downloads you will need to install manually.

### Manual Install

  * Un-zip and drag the `plugins` folder into your `BepInEx` folder.

<br>

## 🌐 Multiplayer:

  * Every player and the server need this mod installed.
  * Versions only need to match on the first number: anyone on 1.x.x can play with anyone else on 1.x.x, so a server and its players do not all have to update at the same time.
  * Settings marked "synced from the server" use the server's values for everyone.

<br>

  
## 💜 Credits: 
  * blacks7ar for the original idea, and for the Seed Bed idea.
  * firstD for the Picture Frame code.

<br>

## 💥 Plugins Created by Magic Mike:
  * <a href="https://valheim.hexium.gg/mods/MagicMike/AuroraBorealis">Aurora Borealis</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/BetterBuildMenu">Better Build Menu</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/BetterEquipSlots">Better Equip Slots</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/CorewoodAdditions">Corewood Additions</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/CoreWoodExtras">Corewood Extras</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/CorewoodFortified">Corewood Fortified</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/ChestPreview">Chest Preview</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/DestroyIt">Destroy It</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/EinherjarBodies">Einherjar Bodies</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/ExtraInventorySlots">Extra Inventory Slots</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/MyDirtyHoe">My Dirty Hoe</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/ValheimSkies">Valheim Skies</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/VanityWardrobe">Vanity Wardrobe</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/VillagePlebs">Village Plebs</a>
  * <a href="https://valheim.hexium.gg/mods/MagicMike/YabbaDabbaDoo">YabbaDabbaDoo</a>

<br>

## ❓ FAQs:

<details>
    <summary><strong> How do I get Mystical Seeds?</strong></summary>
    Mystical Seeds can be bought from the traders.
</details>

<details>
    <summary><strong> How do I customise a Picture Frame?</strong></summary>
    To customise a picture frame you must first place the image you want to use in to your "BepInEx/config/CoreWoodExtras" directory. It is best to use a 16:9 ratio for the horizontal and vertical picture frames.<br><br>
    When in game look at the picture frame and press your use key (default E). Now paste the name off the image you want to add in to the text box.<br><br>
    For example: image-1_h.jpg<br><br>
    Images/Frames can also be scaled by adding the "s" abbreviation.<br><br>
    For example: image-1_h.jpg:s=2 (you can put a pictureframe that is 2 times bigger).<br><br>
    If you would like to run a slideshow of your images, you will need to create a new folder within the "BepInEx/config/CoreWoodExtras" directory. And then use the "i" abbreviation.<br><br>
    For example: horizontalimages:i=5 (Play the images in the horizontalimages folder at five-second intervals).
</details>

<details>
    <summary><strong> How do I add/remove items from Burt the trader?</strong></summary>
Edit BurtItems.json in the BepInEx\config\CoreWoodExtras folder to add extra items for Burt to sell.
<br><br>
Each entry in the "items" array supports:<br><br>
prefabName -------- the internal Valheim/mod prefab name for the item (not its display name).<br>
stack ---------------- how many are sold per purchase.<br>
price ---------------- coin price per stack.<br>
requiredGlobalKey - leave empty to always be available, or set to a global key such as defeated_bonemass to gate it behind a boss kill.<br>
enabled ------------set to false to keep an entry in the file without selling it.<br><br>
Restart the game after editing BurtItems.json for changes to take effect.
</details>  

<details>
    <summary><strong> How do I use the Seed Bed and change what it can grow?</strong></summary>
    The Seed Bed is in the Corewood-Greenhouse category. Press your use key while carrying enough seeds (or produce) to plant them, or use an item on the bed. When the timer finishes, press use again to harvest. The time it takes is the "Germination Duration" setting.<br><br>
    Turn on the "Auto Harvest" setting if you want the Seed Bed to harvest itself when it is ready. No Farming or Herbalist XP is given for automatic harvests. Harvesting by hand always drops the produce at the bed.<br><br>
    With the "Auto Store" setting on (the default), the produce of an automatic harvest is stored in the nearest chest with room (within the "Chest Range" setting), moving on to the next nearest when one is full. Feeding troughs count too, for the food they accept (carrots, turnips, onions and berries), so the bed can keep your tames fed. If there is no chest in range, or they are all full, the produce appears at the bed instead. Turn "Auto Store" off if you always want it to drop at the bed.<br><br>
    Turn on the "Auto Replant" setting to have the Seed Bed start growing again after each harvest (by hand or automatic).<br>
    Items that give themselves back, like Barley or Dandelion, are replanted from the harvest, you get the rest.<br>
    Any other item (CarrotSeeds -> Carrot, or one that gives back no more than you plant) takes its seeds from a chest within the "Chest Range" setting instead, the nearest one with enough is used. Keep a chest with seeds near the bed. If the chest runs out the bed waits empty, and starts again as soon as you add more seeds.<br>
    The Seed Bed only uses chests that its builder could open, so a private chest belonging to someone else is left alone. Seeds are never taken from feeding troughs (that would empty the food for your tames), and tombstones are never used.<br><br>
    Edit SeedBedItems.json in the BepInEx\config\CoreWoodExtras folder to change what it can grow. The file is created for you and reloads when you save it.<br><br>
    Each entry in the "conversions" array supports:<br><br>
    from ----------------- the prefab name of the item you plant (for example CarrotSeeds).<br>
    to -------------------- the prefab name of the item you get back (for example Carrot).<br>
    seedAmount ------ how many you plant.<br>
    producedItems --- how many you harvest.<br><br>
    The "herbs" array lists the harvested items that give Herbalist XP. Each entry can be a prefab name (Dandelion) or a shared name ($item_dandelion). Leave the array out to use the default list, or leave it empty for no Herbalist XP.<br><br>
    If you play on a server, use the same SeedBedItems.json on the server and every client. Delete the file and restart if you want it regenerated with the defaults.
</details>  

<br>

  
## 💬 Comments/Suggestions/Help: <a href="https://discord.gg/mnr36G6J4x">Discord</a>.

