<table>
<thead>
  <tr>
    <th>Version</th>
    <th>Changes</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>2.4.6</td>
    <td>
    <ul>
        <li>Disable HD now swaps the piece materials for low quality versions instead of changing the texture filtering. Toggling it applies straight away, including to pieces already built.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.5</td>
    <td>
    <ul>
        <li>Re-built for Valheim 1.0.21.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.4</td>
    <td>
    <ul>
      <li>Added carved planks 2m</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.3</td>
    <td>
    <ul>
      <li>Added 1x1 planks (request).</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.2</td>
    <td>
    <ul>
      <li>Updated F7 control panel.</li>
      <li>Fixed some small issues.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.1</td>
    <td>
    <ul>
      <li>Fixed "Material 'skybox' with Shader" error. It is a Jotunn error, but my plugin was triggering it.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.4.0</td>
    <td>
    <ul>
      <li>The asset bundle (corewood_new) is now a separate file next to CoreWoodExtras.dll instead of being packed inside it. This lowers memory use and speeds up loading. If you install manually, copy the whole plugins folder, not just the dll.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.9</td>
    <td>
    <ul>
      <li>Fixed the Seed Bed giving seeds back, or growing and then giving nothing, in multiplayer when players had different SeedBedItems.json files. The server's SeedBedItems.json is now sent to everyone who joins (and again when the server's file changes), so every player uses the same list. Your own file is used again when you leave the server.</li>
      <li>A Seed Bed growing something that isn't in the seed bed items is no longer emptied at harvest time, so the seeds aren't lost. It waits for a player who can harvest it.</li>
      <li>Fixed modded items added to SeedBedItems.json sometimes being skipped as "unknown item" when the mod that adds them registers its items late.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.8</td>
    <td>
    <ul>
      <li>Fixed flame shader issues!</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.7</td>
    <td>
    <ul>
      <li>Fixed items moved in or out of a Stackable Chest sometimes being lost in multiplayer. Renaming the chest (Shift + Use or 1-8) while another player had it open took the chest away from them, and their changes were not saved. The chest can no longer be renamed while someone else has it open.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.6</td>
    <td>
    <ul>
      <li>Fixed the Seed Bed showing no plants for items added to SeedBedItems.json, like the Deep North Oats, Kale, Lingonberries and Poteitr. The Seed Bed now shows the plant that grows the harvested item, so modded crops show up too.</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.5</td>
    <td>
    <ul>
      <li>Fixed Magic Mike's Mod Settings (F7) not saving: settings changed in the panel were lost when the game was closed. Changed server-synced settings are now also sent on to the other players when the panel closes.</li>
      <li>Fixed more shader issues!</li>
    </ul>
    </td>
  </tr>
  <tr>
    <td>2.3.4</td>
    <td>
    <ul>
      <li>Added Magic Mike's Mod Settings: press F7, in game or on the main menu, to open a panel with the settings of all your installed Magic Mike mods. Change them with sliders, toggles, dropdowns and key buttons, search them, and reset them to their defaults; changes are saved when the panel closes. Server-synced settings can only be changed by an admin. The key and scroll speed can be changed in the panel's own Mod Settings Panel tab.</li>
      <li>Fixed several shader issues.</li>
      <li>Updated for Valheim 1.0.17</li>
      <li>When CorewoodFortified is installed, the Palisade Entrance, Wall, Corner, Gates, Lift Gate, fences and drawbridge are hidden from the hammer menu. Pieces already built are kept.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.3.3</td>
    <td>
    <ul>
      <li>The footbridges are now in the Decor tab.</li>
      <li>Fixed the Small Bookshelf showing as "Cabinet", and added the missing Paving Curve and Wall Banner 04 names.</li>
      <li>A broken translation file no longer stops the mod from loading.</li>
      <li>Fixed the lights missing from the build menu when their Shadow Type setting was None or Hard.</li>
      <li>Moved all assets into a single asset bundle and rebuilt against valheim 1.0.16.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.3.2</td>
    <td>
    <ul>
      <li>Fixed greenhouse roof snappoints, and rain and snow no longer fall through the Greenhouse Glass roof panels.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.3.1</td>
    <td>
    <ul>
      <li>Fixed picture frame text not being saved or shown to other players when it contained " &lt; &gt; or |.</li>
      <li>Farming and Herbalist XP from the seed bed is now only given when your harvest actually happens.</li>
      <li>Tames now feed from another trough in range when a player has one open.</li>
      <li>Fixed fish schools that could stop moving.</li>
      <li>"Container Range" is now limited to 1 - 50 meters.</li>
      <li>Added the missing Fish Pond name to the built-in English text.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.3.0</td>
    <td>
    <ul>
      <li>Updated for Valheim 1.0.16</li>
      <li>Added Greenhouse Glass roof panel 45.</li>
      <li>Added Greenhouse Glass roof corner 45.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.9</td>
    <td>
    <ul>
      <li>The feeding trough now accepts every food a tameable creature eats, including creatures added by other mods. Troughs can hold mixed foods, and each animal eats what it can and leaves the rest.</li>
      <li>Adjusted the Greenhouse Panel and Greenhouse Door to align better. (You may need to realign your greenhouse door!).</li>
      <li>Added Greenhouse Glass roof panel.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.8</td>
    <td>
    <ul>
      <li>Fixed snappoints on trough and seedbed.</li>
      <li>Added Boar Roaster, roasts 5 raw boar meat at once over a fire. [CoreWood-Decor and Crafting categories]. The Boar Roaster unlocks after Eikthyr is defeated. The unlock key can be changed with "Required Key" in the "Boar Roaster Settings" (leave it empty to always show it).</li>
      <li>Fixed a crash when "Feed Check Cooldown" was set to 0. The cooldown is now limited to 0.5 - 60 seconds.</li>
      <li>Seed beds, feeding troughs and auto feeding no longer take a chest from a player who has it open, which could lose or duplicate items.</li>
      <li>Feeding troughs no longer fight over ownership when several players are nearby, only the trough's owner collects dropped food.</li>
      <li>Players standing on an elevator are let go before it is removed or unloaded, instead of being removed with it.</li>
      <li>Seed bed produce is no longer lost when the seed bed is unloaded, removed or changes owner during the harvest delay.</li>
      <li>Picture frames share loaded images, free their material when removed and show the right name for the square and vertical frames. Added "Web Images" in the "Picture Frame Settings" to stop your game downloading images from links on picture frames.</li>
      <li>Translation files are reloaded safely when they change.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.7</td>
    <td>
    <ul>
      <li>Updated Jotunn 2.30.2</li>
      <li>The Seed Bed now stores produce in a feeding trough first (for the food the trough accepts), then in the nearest chest with room.</li>
      <li>Fixed the Seed Bed logging "Trying to add item to occupied slot" when the chest it stored in was full.</li>
      <li>Fixed Jotunn logging "Not fixing potential mock references" warnings for the Seed Bed and moving platform.</li>
      <li>Feeding troughs now automatically pick up items they accept (Carrot, Turnip, Onion, Raspberry, Blueberries) when dropped on the ground within "Container Range" of the trough.</li>
      <li>Added a "Trough Auto Collect" setting to the Auto-Feed settings (on by default) to turn this off.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.6</td>
    <td>
    <ul>
      <li>Added an "Auto Harvest" setting to the Seed Bed settings (off by default). When on, the Seed Bed harvests itself as soon as the seeds finish germinating. No Farming or Herbalist XP is given for automatic harvests.</li>
      <li>Added an "Auto Store" setting to the Seed Bed settings (on by default, needs "Auto Harvest"). The produce of an automatic harvest is stored in the nearest chest with room (then the next nearest), or appears at the Seed Bed if there is no chest in range or they are all full. Feeding troughs count for the food they accept, so the Seed Bed can keep your tames fed.</li>
      <li>Added an "Auto Replant" setting to the Seed Bed settings (off by default). When on, the Seed Bed starts growing again after each harvest. Items that give themselves back (like Barley or Dandelion) are replanted from the harvest. Items like CarrotSeeds -> Carrot take their seeds from a chest near the Seed Bed and wait until the chest has enough. Only chests the builder of the Seed Bed could open are used.</li>
      <li>Added a "Chest Range" setting to the Seed Bed settings, how far away the Seed Bed looks for chests to take seeds from and store harvests in. Only chests the builder of the Seed Bed could open are used. It never takes seeds from feeding troughs or tombstones.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.5</td>
    <td>
    <ul>
      <li>Added the Seed Bed (Corewood-Greenhouse category). Plant seeds or produce, wait for them to germinate, then harvest more than you put in.</li>
      <li>Added "Seed Bed Settings" to the config: "Germination Duration", "Harvest Delay", "Farming XP" and "Herbalist XP" (the XP settings need the Farming / Herbalist mods).</li>
      <li>What the Seed Bed can germinate, and which harvested items count as herbs for Herbalist XP, is stored in SeedBedItems.json in your "BepInEx\config\CoreWoodExtras" folder. The file is created for you and reloads when you save it.</li>
      <li>Elevators are now properly network synced. They move the same for every player and the start sound plays for everyone nearby. Existing elevators keep their position.</li>
      <li>Fixed elevator sounds not being routed to the ambient mixer.</li>
      <li>Fixed the moving platform becoming removable while someone was still standing on it.</li>
      <li>Scarecrow, light, toilet effects and "Disable HD" settings now apply straight away, including to pieces that are already placed. No restart or rebuild needed.</li>
      <li>Fixed the Scarecrow forcefield still keeping monsters away after it was switched off, and not working again after being switched back on. The "No Monsters" status effect is now only given to players.</li>
      <li>Fixed changing light settings sometimes not updating the other lights when a shadow type was set to None or Hard.</li>
      <li>Fixed "Disable HD" not switching back off without a restart.</li>
      <li>Fixed translation files not reloading when edited.</li>
      <li>Fixed the feeding trough feeding animals for free when another player owned the trough, and tidied up destroyed troughs.</li>
      <li>Fixed the fish pond toggle not showing for other players.</li>
      <li>Fixed picture frames throwing errors on some text (decimal commas, repeated options, text starting with "http").</li>
      <li>Fixed a few missing null checks (elevator, trough, school bubbles) and image loading on Linux.</li>
      <li>A piece that fails to load no longer stops the rest of its category from loading, the log now names the piece that failed.</li>
      <li>Fixed the trader store: buying the Mystical Seed (or one of Burt's items) threw an error and left the list stale, and the selected item jumped back to the top after each purchase. Made the trader code safer for other mods that add to the trader window (such as EpicLoot).</li>
      <li>Fixed "requiredGlobalKey" in BurtItems.json not being applied, items are now hidden until that key is set.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.4</td>
    <td>
    <ul>
      <li>Added a protection forcefield to the Scarecrow that can be toggled on and off. It can be found in the Corewood-Greenhouse category.</li>
      <li>The scarecrow will show "No Access" when you cannot use it because of a ward.</li>
      <li>Added "Scarecrow Settings" to the config: "Enable Protection Toggle" (if Off, the scarecrow does nothing) and "Show Forcefield" (hides the forcefield visual).</li>
      <li>Optimised more code, Elevators should now be network synced.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.3</td>
    <td>
    <ul>
      <li>Optimised trader code and enabled editing a json file to update Burts items. You will need to delete your config file and let the game regenerate it. Burts list for adding/removing items is stored in your "BepInEx\config\CoreWoodExtras" folder.</li>
      <li>Updated category usage tags for build menu.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.2</td>
    <td>
    <ul>
      <li>Missed some changes!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.1</td>
    <td>
    <ul>
      <li>Updated for Valheim 1.0.14</li>
      <li>Updated Jotunn 2.30.1</li>
      <li>Added auto feeder trough for tamed creatures. It can be found in the storage category or Corewood-Decor category.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.2.0</td>
    <td>
    <ul>
      <li>Fixed trader issues.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.9</td>
    <td>
    <ul>
      <li>Updated for Valheim 1.0.12</li>
      <li>Updated Jotunn 2.30.0</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.8</td>
    <td>
    <ul>
      <li>Added config option to disable elevators.</li>
      <li>Fixed config for stacked chest.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.7</td>
    <td>
    <ul>
      <li>Reworked some code.</li>
      <li>Added rope fences.</li>
      <li>Added new Discord link.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.6</td>
    <td>
    <ul>
      <li>Added Large Aquarium.</li>
      <li>Added Garden Hedges.</li>
      <li>Added Noticeboard.</li>
      <li>Fixed Gnomes not being placeable on wood.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.5</td>
    <td>
    <ul>
      <li>Fixed sfx for shower.</li>
      <li>Fixed placing trader.</li>
      <li>Added GlobalKey to trader configs.</li>
      <li>Added snappoints to aquarium.</li>
      <li>Added 4 more elevators.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.4</td>
    <td>
    <ul>
      <li>Added Aquarium.</li>
      <li>Added Garden Gnomes.</li>
      <li>Added config option to disable hotbar naming on stackable chests.</li>
      <li>Added config options for Trader items (Burt).</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.3</td>
    <td>
    <ul>
      <li>Added Garden Pergola.</li>
      <li>Added Small & Large Footbridge.</li>
      <li>Added Arch Corner.</li>
      <li>Added Gravel Paving.</li>
      <li>Added placeable Ivy.</li>
      <li>Added a toggle for Burt the barman until I can sort out configs.</li>
      <li>Rearranged categories to help with further updates.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.2</td>
    <td>
    <ul>
      <li>Hopefully fixed magic floating fish!</li>
      <li>Replaced Ivy on corewood arch.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.1</td>
    <td>
    <ul>
      <li>Added Burts Bar!</li>
      <li>Added Gazebo.</li>
      <li>Added Barrel and Kegs.</li>
      <li>Fixed leaky roof parts.</li>
      <li>Fixed well colliders.</li>
      <li>Rebuilt pond to try and resolve issues.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.1.0</td>
    <td>
    <ul>
      <li>Added frogs sound fx.</li>
      <li>Added Old Well.</li>
      <li>Maybe fixed fish appearing outside pool!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.9</td>
    <td>
    <ul>
      <li>Added frogs to pond.</li>
      <li>Fixed pond ground offset.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.8</td>
    <td>
    <ul>
      <li>Fixed snappoints on tall pallisade wall.</li>
      <li>Fixed snappoints on rasta lights.</li>
      <li>Fixed warning for birch seeds.</li>
      <li>Added more snappoints to bridge stairs.</li>
      <li>Added fish pond.</li>
      <li>Added swimming pool!</li>
      <li>Added plank flooring.</li>
      <li>Added parasol.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.7</td>
    <td>
    <ul>
      <li>Added Shower Block!</li>
      <li>Moved Outhouse to clutter.</li>
      <li>Updated Jotunn to 2.25.0</li>
      <li>Setup new Discord channel.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.6</td>
    <td>
    <ul>
      <li>Added SFX for fountain.</li>
      <li>Added another fountain.</li>
      <li>Added straw bale.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.5</td>
    <td>
    <ul>
      <li>Fixed Stacked chest config in wrong place.</li>
      <li>Fixed issue with mystical seed not being available.</li>
      <li>Added water fountain to clutter. (no sound yet!)</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.4</td>
    <td>
    <ul>
      <li>Added back config for lower res textures.</li>
      <li>Added back fixed stacked chests.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.3</td>
    <td>
    <ul>
      <li>Fixed missing lights!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.2</td>
    <td>
    <ul>
      <li>Fixed missing snappoints. (Sorry!)</li>
      <li>Added back Market pieces.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.1</td>
    <td>
    <ul>
      <li>Repacked assetbundle for smaller file size.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>2.0.0</td>
    <td>
    <ul>
      <li>Update for Jotunn 2.24.3.</li>
      <li>Update for Valheim 0.220.5.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.8</td>
    <td>
    <ul>
      <li>Fixed snappoints for Fortified pieces.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.7</td>
    <td>
    <ul>
      <li>Added Fortified Palisade Entrance.</li>
      <li>Added Fortified Palisade Wall.</li>
      <li>Added Fortified Palisade Wall Corner.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.6</td>
    <td>
    <ul>
      <li>Update for Jotunn 2.20.3.</li>
      <li>Update for Valheim 0.218.21.</li>
      <li>Fixed FPS drops with building destruction.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.5</td>
    <td>
    <ul>
      <li>Just some minor fixes and code changes.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.4</td>
    <td>
    <ul>
      <li>Added Hot Food Stall to Market.</li>
      <li>Added 8 Hot Food containers to Market.</li>
      <li>Added Asksvin Meat to Food Crates.</li>
      <li>Added Boar Meat to Food Crates.</li>
      <li>Added missing colliders to Bridge T-Junction.</li>
      <li>Added Bridge Cross-Junction.</li>
      <li>Removed ground restriction for Spikes.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.3</td>
    <td>
    <ul>
      <li>Fixed Elevator animations.</li>
      <li>Added Portcullis to Tower Drawbridge.</li>
      <li>Added Market Category.</li>
      <li>Added 4 Market Stalls to Market.</li>
      <li>Added 18 Dynamic Food Crate containers to Market.</li>
      <li>Added 9 Seed Sack containers to Market.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.2</td>
    <td>
    <ul>
      <li>Added Scarecrow to Clutter.</li>
      <li>Added Bridge T-Junction to Building.</li>
      <li>Fixed missing Chandelier textures!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.1</td>
    <td>
    <ul>
      <li>Added Brazier to Furniture.</li>
      <li>Added Palisade Beacon to Building.</li>
      <li>Added lighting configs for Brazier and Beacon.</li>
      <li>Added 1 more Sharp Stakes to Building.</li>
      <li>Added 2 more Elevators to Building.</li>
      <li>Added 3 Creature Stands to Clutter.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.3.0</td>
    <td>
    <ul>
      <li>Added Stuffed Werewolf to Clutter.</li>
      <li>Added Stuffed Crow to Clutter.</li>
      <li>Added Stuffed Seagul to Clutter.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.9</td>
    <td>
    <ul>
      <li>Fixed Stuffed Creature icons.</li>
      <li>Fixed Vulture recipe.</li>
      <li>Fixed issue with Wall/Floor pieces, Sorry.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.8</td>
    <td>
    <ul>
      <li>Fixed recipes for Stuffed Creatures.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.7</td>
    <td>
    <ul>
      <li>Update for Valheim 0.218.19.</li>
      <li>Added 2m Decking.</li>
      <li>Added Stuffed Creatures to Clutter.</li>
      <li>Fixed issue with Trapdoor collider.</li>
      <li>Fixed missing texture for Crystal Light destruction.</li>
      <li>Optimised more meshes.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.6</td>
    <td>
    <ul>
      <li>Added Wall Banners to Clutter.</li>
      <li>Added customisable Picture Frames to Clutter. Sample images included.</li>
      <li>Fixed reverse sign textures!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.5</td>
    <td>
    <ul>
      <li>Adjusted textures for signs.</li>
      <li>Fixed reverse sign textures!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.4</td>
    <td>
    <ul>
      <li>Made signs double sided.</li>
      <li>Added arrows to signs.</li>
      <li>Added arrows to Boss Banners.</li>
      <li>Added Haldor & Hildir Banners.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.3</td>
    <td>
    <ul>
      <li>Added Signs to Clutter.</li>
      <li>Added Boss Banners to Clutter.</li>
      <li>Added Mystic Seeds to Traders. Now needed to craft plants.</li>
      <li>Added more Plants.</li>
      <li>Moved Plants to Greenhouse category.</li>
      <li>Added Greenhouse clutter.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.2</td>
    <td>
    <ul>
      <li>Added Greenhouse category.</li>
      <li>Added Greenhouse pieces and workbench.</li>
      <li>Added more Sharp Stakes.</li>
      <li>Added Corewood Elevators.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.1</td>
    <td>
    <ul>
      <li>Renamed categories and moved pieces about a bit!</li>
      <li>Added Log Stump & Log Table to Furniture.</li>
      <li>Added Large Display Case to Furniture.</li>
      <li>Added 3 more Potted Plants to Clutter.</li>
      <li>Added 3 Rugs to Clutter.</li>
      <li>Added 2x Wood Carvings to Clutter.</li>
      <li>Added Decorative Bowl, Goblet, Pitcher & Plate to Clutter.</li>
      <li>Added Cutlery Set to Clutter.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.2.0</td>
    <td>
    <ul>
      <li>Hotfix for Tower Drawbridge.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.9</td>
    <td>
    <ul>
      <li>Added Tower Drawbridge to Building.</li>
      <li>Added Wattle Fence to Building.</li>
      <li>Added 3 more Planters to Decor.</li>
      <li>Added 3 Potted Plants to Clutter.</li>
      <li>Rebuilt Stepladder prefab.</li>
      <li>Optimised some meshes.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.8</td>
    <td>
    <ul>
      <li>Fixed texture flickering on vanilla pieces.</li>
      <li>Added snappoints to Pallisade Watch Tower.</li>
      <li>Adjusted Watch Tower activation distance.</li>
      <li>Added Fence Gate.</li>
      <li>Added Planters to Decor.</li>
      <li>Added Config option to set textures to be more vanilla like. (WIP)</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.7</td>
    <td>
    <ul>
      <li>Fixed Decking destruction.</li>
      <li>Added Pallisade Watch Tower.</li>
      <li>Added Config options for stackable chest. You may need to rebuild your config file.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.6</td>
    <td>
    <ul>
      <li>Updated Ivy textures.</li>
      <li>Added Stackable Chests with signs.</li>
      <li>Added Core Wood Decking.</li>
      <li>Added another fence piece.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.5</td>
    <td>
    <ul>
      <li>Added Crystal Light.</li>
      <li>Added Crystal Rope Lights.</li>
      <li>Added config options for light sources.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.4</td>
    <td>
    <ul>
      <li>Added Pallisade Gates.</li>
      <li>Added Core Wood Throne.</li>
      <li>Adjusted ceiling offset for torches.</li>
      <li>Fixed snappoints for Garden Arches.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.3</td>
    <td>
    <ul>
      <li>Fixed Chest Container.</li>
      <li>Added snappoints to Garden Arches.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.2</td>
    <td>
    <ul>
      <li>Moved Core Wood Stack to Decor.</li>
      <li>Added Dynamic Core Wood Stack.</li>
      <li>Added another Bridge Part.</li>
      <li>Added another Bridge Foundation.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.1</td>
    <td>
    <ul>
      <li>Added Bridge parts.</li>
      <li>Properly added Garden Arches!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.1.0</td>
    <td>
    <ul>
      <li>Added snappoints to Display Cabinet.</li>
      <li>Added Garden Arches.</li>
      <li>Added Outhouse and config setting for effects.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.9</td>
    <td>
    <ul>
      <li>Fixed Display Cabinet destruction.</li>
      <li>Added Armor Stand Cabinet.</li>
      <li>Added Clutter items.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.8</td>
    <td>
    <ul>
      <li>Fixed Core Wood Shutters.</li>
      <li>Fixed Core Wood Animated Windows.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.7</td>
    <td>
    <ul>
      <li>Added 4 Poster Bed.</li>
      <li>Added Boss Trophy Display Cabinet.</li>
      <li>Added config options to enable resizing of boss trophies for displaying in cabinet.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.6</td>
    <td>
    <ul>
      <li>Rebuilt Tall Cabinet.</li>
      <li>Added Double Cabinet.</li>
      <li>Added configs for chest sizes.</li>
      <li>Fixed Wall Cabinet.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.5</td>
    <td>
    <ul>
      <li>Added Core Wood Bookshelves.</li>
      <li>Added Core Wood Cabinets.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.4</td>
    <td>
    <ul>
      <li>Fixed stump chair destruction.</li>
      <li>Added 4m floor and wall pieces.</li>
      <li>Added Core Wood Bed.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.3</td>
    <td>
    <ul>
      <li>Removed static shutters.</li>
      <li>Added animated windows and shutters.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.2</td>
    <td>
    <ul>
      <li>Fixed stake damage properly!!</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.1</td>
    <td>
    <ul>
      <li>Fixed stake damage.</li>
    </ul>
	</td>
  </tr>
  <tr>
    <td>1.0.0</td>
    <td>
    <ul>
      <li>Initial Release</li>
    </ul>
	</td>
  </tr>
</tbody>
</table>