<table>
<thead>
  <tr>
    <th>Version</th>
    <th>Changes</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td>2.2.8</td>
    <td>
    Fixed snappoints on trough and seedbed.<br>
    Added Boar Roaster, roasts 5 raw boar meat at once over a fire. [CoreWood-Decor and Crafting categories]. The Boar Roaster unlocks after Eikthyr is defeated. The unlock key can be changed with "Required Key" in the "Boar Roaster Settings" (leave it empty to always show it).<br>
    Fixed a crash when "Feed Check Cooldown" was set to 0. The cooldown is now limited to 0.5 - 60 seconds.<br>
    Seed beds, feeding troughs and auto feeding no longer take a chest from a player who has it open, which could lose or duplicate items.<br>
    Feeding troughs no longer fight over ownership when several players are nearby, only the trough's owner collects dropped food.<br>
    Players standing on an elevator are let go before it is removed or unloaded, instead of being removed with it.<br>
    The Boar Roaster only puts out fires that can be lit again by hand, other fires keep burning.<br>
    Boar Roaster and Seed Bed effects are now seen and heard by every player nearby.<br>
    Seed bed produce is no longer lost when the seed bed is unloaded, removed or changes owner during the harvest delay.<br>
    Fixed Core Wood pieces each getting their own copy of their materials.<br>
    Picture frames share loaded images, free their material when removed and show the right name for the square and vertical frames. Added "Web Images" in the "Picture Frame Settings" to stop your game downloading images from links on picture frames.<br>
    Translation files are reloaded safely when they change.<br>
    "Enable Elevators" and "Enable Trader" now follow the server's setting and no longer need a restart. "Enable Plugin" is now a local setting.<br>
	</td>
  </tr>
  <tr>
    <td>2.2.7</td>
    <td>
    Updated Jotunn 2.30.2<br>
    The Seed Bed now stores produce in a feeding trough first (for the food the trough accepts), then in the nearest chest with room.<br>
    Fixed the Seed Bed logging "Trying to add item to occupied slot" when the chest it stored in was full.<br>
    Fixed Jotunn logging "Not fixing potential mock references" warnings for the Seed Bed and moving platform.<br>
    Feeding troughs now automatically pick up items they accept (Carrot, Turnip, Onion, Raspberry, Blueberries) when dropped on the ground within "Container Range" of the trough.<br>
    Added a "Trough Auto Collect" setting to the Auto-Feed settings (on by default) to turn this off.
	</td>
  </tr>
  <tr>
    <td>2.2.6</td>
    <td>
    Added an "Auto Harvest" setting to the Seed Bed settings (off by default). When on, the Seed Bed harvests itself as soon as the seeds finish germinating. No Farming or Herbalist XP is given for automatic harvests.<br>
    Added an "Auto Store" setting to the Seed Bed settings (on by default, needs "Auto Harvest"). The produce of an automatic harvest is stored in the nearest chest with room (then the next nearest), or appears at the Seed Bed if there is no chest in range or they are all full. Feeding troughs count for the food they accept, so the Seed Bed can keep your tames fed.<br>
    Added an "Auto Replant" setting to the Seed Bed settings (off by default). When on, the Seed Bed starts growing again after each harvest. Items that give themselves back (like Barley or Dandelion) are replanted from the harvest. Items like CarrotSeeds -> Carrot take their seeds from a chest near the Seed Bed and wait until the chest has enough. Only chests the builder of the Seed Bed could open are used.<br>
    Added a "Chest Range" setting to the Seed Bed settings, how far away the Seed Bed looks for chests to take seeds from and store harvests in. Only chests the builder of the Seed Bed could open are used. It never takes seeds from feeding troughs or tombstones.
	</td>
  </tr>
  <tr>
    <td>2.2.5</td>
    <td>
    Added the Seed Bed (Corewood-Greenhouse category). Plant seeds or produce, wait for them to germinate, then harvest more than you put in.<br>
    Added "Seed Bed Settings" to the config: "Germination Duration", "Harvest Delay", "Farming XP" and "Herbalist XP" (the XP settings need the Farming / Herbalist mods).<br>
    What the Seed Bed can germinate, and which harvested items count as herbs for Herbalist XP, is stored in SeedBedItems.json in your "BepInEx\config\CoreWoodExtras" folder. The file is created for you and reloads when you save it.<br>
    Elevators are now properly network synced. They move the same for every player and the start sound plays for everyone nearby. Existing elevators keep their position.<br>
    Fixed elevator sounds not being routed to the ambient mixer.<br>
    Fixed the moving platform becoming removable while someone was still standing on it.<br>
    Scarecrow, light, toilet effects and "Disable HD" settings now apply straight away, including to pieces that are already placed. No restart or rebuild needed.<br>
    Fixed the Scarecrow forcefield still keeping monsters away after it was switched off, and not working again after being switched back on. The "No Monsters" status effect is now only given to players.<br>
    Fixed changing light settings sometimes not updating the other lights when a shadow type was set to None or Hard.<br>
    Fixed "Disable HD" not switching back off without a restart.<br>
    Fixed translation files not reloading when edited.<br>
    Fixed the feeding trough feeding animals for free when another player owned the trough, and tidied up destroyed troughs.<br>
    Fixed the fish pond toggle not showing for other players.<br>
    Fixed picture frames throwing errors on some text (decimal commas, repeated options, text starting with "http").<br>
    Fixed a few missing null checks (elevator, trough, school bubbles) and image loading on Linux.<br>
    A piece that fails to load no longer stops the rest of its category from loading, the log now names the piece that failed.<br>
    Fixed the trader store: buying the Mystical Seed (or one of Burt's items) threw an error and left the list stale, and the selected item jumped back to the top after each purchase. Made the trader code safer for other mods that add to the trader window (such as EpicLoot).<br>
    Fixed "requiredGlobalKey" in BurtItems.json not being applied, items are now hidden until that key is set.
	</td>
  </tr>
  <tr>
    <td>2.2.4</td>
    <td>
    Added a protection forcefield to the Scarecrow that can be toggled on and off. It can be found in the Corewood-Greenhouse category.<br>
    The scarecrow will show "No Access" when you cannot use it because of a ward.<br>
    Added "Scarecrow Settings" to the config: "Enable Protection Toggle" (if Off, the scarecrow does nothing) and "Show Forcefield" (hides the forcefield visual).<br>
    Optimised more code, Elevators should now be network synced.
	</td>
  </tr>
  <tr>
    <td>2.2.3</td>
    <td>
    Optimised trader code and enabled editing a json file to update Burts items. You will need to delete your config file and let the game regenerate it. Burts list for adding/removing items is stored in your "BepInEx\config\CoreWoodExtras" folder.<br>
    Updated category usage tags for build menu.
	</td>
  </tr>
  <tr>
    <td>2.2.2</td>
    <td>
    Missed some changes!
	</td>
  </tr>
  <tr>
    <td>2.2.1</td>
    <td>
    Updated for Valheim 1.0.14<br>
    Updated Jotunn 2.30.1<br>
    Added auto feeder trough for tamed creatures. It can be found in the storage category or Corewood-Decor category.
	</td>
  </tr>
  <tr>
    <td>2.2.0</td>
    <td>
    Fixed trader issues.
	</td>
  </tr>
  <tr>
    <td>2.1.9</td>
    <td>
    Updated for Valheim 1.0.12<br>
    Updated Jotunn 2.30.0
	</td>
  </tr>
  <tr>
    <td>2.1.8</td>
    <td>
    Added config option to disable elevators.<br>
    Fixed config for stacked chest.
	</td>
  </tr>
  <tr>
    <td>2.1.7</td>
    <td>
    Reworked some code.<br>
    Added rope fences.<br>
    Added new Discord link.
	</td>
  </tr>
  <tr>
    <td>2.1.6</td>
    <td>
    Added Large Aquarium.<br>
    Added Garden Hedges.<br>
    Added Noticeboard.<br>
    Fixed Gnomes not being placeable on wood.
	</td>
  </tr>
  <tr>
    <td>2.1.5</td>
    <td>
    Fixed sfx for shower.<br>
    Fixed placing trader.<br>
    Added GlobalKey to trader configs.<br>
    Added snappoints to aquarium.<br>
    Added 4 more elevators.
	</td>
  </tr>
  <tr>
    <td>2.1.4</td>
    <td>
    Added Aquarium.<br>
    Added Garden Gnomes.<br>
    Added config option to disable hotbar naming on stackable chests.<br>
    Added config options for Trader items (Burt).
	</td>
  </tr>
  <tr>
    <td>2.1.3</td>
    <td>
    Added Garden Pergola.<br>
    Added Small & Large Footbridge.<br>
    Added Arch Corner.<br>
    Added Gravel Paving.<br>
    Added placeable Ivy.<br>
    Added a toggle for Burt the barman until I can sort out configs.<br>
    Rearranged categories to help with further updates.
	</td>
  </tr>
  <tr>
    <td>2.1.2</td>
    <td>
    Hopefully fixed magic floating fish!<br>
    Replaced Ivy on corewood arch.
	</td>
  </tr>
  <tr>
    <td>2.1.1</td>
    <td>
    Added Burts Bar!<br>
    Added Gazebo.<br>
    Added Barrel and Kegs.<br>
    Fixed leaky roof parts.<br>
    Fixed well colliders.<br>
    Rebuilt pond to try and resolve issues.
	</td>
  </tr>
  <tr>
    <td>2.1.0</td>
    <td>
    Added frogs sound fx.<br>
    Added Old Well.<br>
    Maybe fixed fish appearing outside pool!
	</td>
  </tr>
  <tr>
    <td>2.0.9</td>
    <td>
    Added frogs to pond.<br>
    Fixed pond ground offset.
	</td>
  </tr>
  <tr>
    <td>2.0.8</td>
    <td>
    Fixed snappoints on tall pallisade wall.<br>
    Fixed snappoints on rasta lights.<br>
    Fixed warning for birch seeds.<br>
    Added more snappoints to bridge stairs.<br>
    Added fish pond.<br>
    Added swimming pool!<br>
    Added plank flooring.<br>
    Added parasol.
	</td>
  </tr>
  <tr>
    <td>2.0.7</td>
    <td>
    Added Shower Block!<br>
    Moved Outhouse to clutter.<br>
    Updated Jotunn to 2.25.0<br>
    Setup new Discord channel.
	</td>
  </tr>
  <tr>
    <td>2.0.6</td>
    <td>
    Added SFX for fountain.<br>
    Added another fountain.<br>
    Added straw bale.
	</td>
  </tr>
  <tr>
    <td>2.0.5</td>
    <td>
    Fixed Stacked chest config in wrong place.<br>
    Fixed issue with mystical seed not being available.<br>
    Added water fountain to clutter. (no sound yet!)
	</td>
  </tr>
  <tr>
    <td>2.0.4</td>
    <td>
    Added back config for lower res textures.<br>
    Added back fixed stacked chests.
	</td>
  </tr>
  <tr>
    <td>2.0.3</td>
    <td>
    Fixed missing lights!<br>
	</td>
  </tr>
  <tr>
    <td>2.0.2</td>
    <td>
    Fixed missing snappoints. (Sorry!)<br>
    Added back Market pieces.
	</td>
  </tr>
  <tr>
    <td>2.0.1</td>
    <td>
    Repacked assetbundle for smaller file size.
	</td>
  </tr>
  <tr>
    <td>2.0.0</td>
    <td>
    Update for Jotunn 2.24.3.<br>
    Update for Valheim 0.220.5.
	</td>
  </tr>
  <tr>
    <td>1.3.8</td>
    <td>
    Fixed snappoints for Fortified pieces.
	</td>
  </tr>
  <tr>
    <td>1.3.7</td>
    <td>
    Added Fortified Palisade Entrance.<br>
    Added Fortified Palisade Wall.<br>
    Added Fortified Palisade Wall Corner.
	</td>
  </tr>
  <tr>
    <td>1.3.6</td>
    <td>
    Update for Jotunn 2.20.3.<br>
    Update for Valheim 0.218.21.<br>
    Fixed FPS drops with building destruction.
	</td>
  </tr>
  <tr>
    <td>1.3.5</td>
    <td>
        Just some minor fixes and code changes.
    </td>
  </tr>
  <tr>
    <td>1.3.4</td>
    <td>
        Added Hot Food Stall to Market.<br>
        Added 8 Hot Food containers to Market.<br>
        Added Asksvin Meat to Food Crates.<br>
        Added Boar Meat to Food Crates.<br>
        Added missing colliders to Bridge T-Junction.<br>
        Added Bridge Cross-Junction.<br>
        Removed ground restriction for Spikes.<br>
    </td>
  </tr>
  <tr>
    <td>1.3.3</td>
    <td>
        Fixed Elevator animations.<br>
        Added Portcullis to Tower Drawbridge.<br>
        Added Market Category.<br>
        Added 4 Market Stalls to Market.<br>
        Added 18 Dynamic Food Crate containers to Market.<br>
        Added 9 Seed Sack containers to Market.<br>
    </td>
  </tr>
  <tr>
    <td>1.3.2</td>
    <td>
        Added Scarecrow to Clutter.<br>
        Added Bridge T-Junction to Building.<br>
        Fixed missing Chandelier textures!<br>
    </td>
  </tr>
  <tr>
    <td>1.3.1</td>
    <td>
        Added Brazier to Furniture.<br>
        Added Palisade Beacon to Building.<br>
        Added lighting configs for Brazier and Beacon.<br>
        Added 1 more Sharp Stakes to Building.<br>
        Added 2 more Elevators to Building.<br>
        Added 3 Creature Stands to Clutter.<br>
    </td>
  </tr>
  <tr>
    <td>1.3.0</td>
    <td>
        Added Stuffed Werewolf to Clutter.<br>
        Added Stuffed Crow to Clutter.<br>
        Added Stuffed Seagul to Clutter.
    </td>
  </tr>
  <tr>
    <td>1.2.9</td>
    <td>
        Fixed Stuffed Creature icons.<br>
        Fixed Vulture recipe.<br>
        Fixed issue with Wall/Floor pieces, Sorry.
    </td>
  </tr>
  <tr>
    <td>1.2.8</td>
    <td>
        Fixed recipes for Stuffed Creatures.
    </td>
  </tr>
  <tr>
    <td>1.2.7</td>
    <td>
        Update for Valheim 0.218.19.<br>
        Added 2m Decking.<br>
        Added Stuffed Creatures to Clutter.<br>
        Fixed issue with Trapdoor collider.<br>
        Fixed missing texture for Crystal Light destruction.<br>
        Optimised more meshes.
    </td>
  </tr>
  <tr>
    <td>1.2.6</td>
    <td>
        Added Wall Banners to Clutter.<br>
        Added customisable Picture Frames to Clutter. Sample images included.<br>
        Fixed reverse sign textures!
    </td>
  </tr>
  <tr>
    <td>1.2.5</td>
    <td>
        Adjusted textures for signs.<br>
        Fixed reverse sign textures!
    </td>
  </tr>
  <tr>
    <td>1.2.4</td>
    <td>
        Made signs double sided.<br>
        Added arrows to signs.<br>
        Added arrows to Boss Banners.<br>
        Added Haldor & Hildir Banners.
    </td>
  </tr>
  <tr>
    <td>1.2.3</td>
    <td>
        Added Signs to Clutter.<br>
        Added Boss Banners to Clutter.<br>
        Added Mystic Seeds to Traders. Now needed to craft plants.<br>
        Added more Plants.<br>
        Moved Plants to Greenhouse category.<br>
        Added Greenhouse clutter.
    </td>
  </tr>
  <tr>
    <td>1.2.2</td>
    <td>
        Added Greenhouse category.<br>
        Added Greenhouse pieces and workbench.<br>
        Added more Sharp Stakes.<br>
        Added Corewood Elevators.
    </td>
  </tr>
  <tr>
    <td>1.2.1</td>
    <td>
        Renamed categories and moved pieces about a bit!<br>
        Added Log Stump & Log Table to Furniture.<br>
        Added Large Display Case to Furniture.<br>
        Added 3 more Potted Plants to Clutter.<br>
        Added 3 Rugs to Clutter.<br>
        Added 2x Wood Carvings to Clutter.<br>
        Added Decorative Bowl, Goblet, Pitcher & Plate to Clutter.<br>
        Added Cutlery Set to Clutter.
    </td>
  </tr>
  <tr>
    <td>1.2.0</td>
    <td>
        Hotfix for Tower Drawbridge.
    </td>
  </tr>
  <tr>
    <td>1.1.9</td>
    <td>
        Added Tower Drawbridge to Building.<br>
        Added Wattle Fence to Building.<br>
        Added 3 more Planters to Decor.<br>
        Added 3 Potted Plants to Clutter.<br>
        Rebuilt Stepladder prefab.<br>
        Optimised some meshes.
    </td>
  </tr>
  <tr>
    <td>1.1.8</td>
    <td>
        Fixed texture flickering on vanilla pieces.<br>
        Added snappoints to Pallisade Watch Tower.<br>
        Adjusted Watch Tower activation distance.<br>
        Added Fence Gate.<br>
        Added Planters to Decor.<br>
        Added Config option to set textures to be more vanilla like. (WIP)
    </td>
  </tr>
  <tr>
    <td>1.1.7</td>
    <td>
        Fixed Decking destruction.<br>
        Added Pallisade Watch Tower.<br>
        Added Config options for stackable chest. You may need to rebuild your config file.
    </td>
  </tr>
  <tr>
    <td>1.1.6</td>
    <td>
        Updated Ivy textures.<br>
        Added Stackable Chests with signs.<br>
        Added Core Wood Decking.<br>
        Added another fence piece.
    </td>
  </tr>
  <tr>
    <td>1.1.5</td>
    <td>
        Added Crystal Light.<br>
        Added Crystal Rope Lights.<br>
        Added config options for light sources.
    </td>
  </tr>
  <tr>
    <td>1.1.4</td>
    <td>
        Added Pallisade Gates.<br>
        Added Core Wood Throne.<br>
        Adjusted ceiling offset for torches.<br>
        Fixed snappoints for Garden Arches.
    </td>
  </tr>
  <tr>
    <td>1.1.3</td>
    <td>
        Fixed Chest Container.<br>
        Added snappoints to Garden Arches.
    </td>
  </tr>
  <tr>
    <td>1.1.2</td>
    <td
        Moved Core Wood Stack to Decor.<br>
        Added Dynamic Core Wood Stack.<br>
        Added another Bridge Part.<br>
        Added another Bridge Foundation.
    </td>
  </tr>
  <tr>
    <td>1.1.1</td>
    <td>
        Added Bridge parts.<br>
        Properly added Garden Arches!
    </td>
  </tr>
  <tr>
    <td>1.1.0</td>
    <td>
        Added snappoints to Display Cabinet.<br>
        Added Garden Arches.<br>
        Added Outhouse and config setting for effects.
    </td>
  </tr>
  <tr>
    <td>1.0.9</td>
    <td>
        Fixed Display Cabinet destruction.<br>
        Added Armor Stand Cabinet.<br>
        Added Clutter items.
    </td>
  </tr>
  <tr>
    <td>1.0.8</td>
    <td>
        Fixed Core Wood Shutters.<br>
        Fixed Core Wood Animated Windows.
    </td>
  </tr>
  <tr>
    <td>1.0.7</td>
    <td>
        Added 4 Poster Bed.<br>
        Added Boss Trophy Display Cabinet.<br>
        Added config options to enable resizing of boss trophies for displaying in cabinet.
    </td>
  </tr>
  <tr>
    <td>1.0.6</td>
    <td>
        Rebuilt Tall Cabinet.<br>
        Added Double Cabinet.<br>
        Added configs for chest sizes.<br>
        Fixed Wall Cabinet.
    </td>
  </tr>
  <tr>
    <td>1.0.5</td>
    <td>
        Added Core Wood Bookshelves.<br>
        Added Core Wood Cabinets.
    </td>
  </tr>
  <tr>
    <td>1.0.4</td>
    <td>
        Fixed stump chair destruction.<br>
        Added 4m floor and wall pieces.<br>
        Added Core Wood Bed.
    </td>
  </tr>
  <tr>
    <td>1.0.3</td>
    <td>
        Removed static shutters.<br>
        Added animated windows and shutters.
    </td>
  </tr>
  <tr>
    <td>1.0.2</td>
    <td>Fixed stake damage properly!!</td>
  </tr>
  <tr>
    <td>1.0.1</td>
    <td>Fixed stake damage.</td>
  </tr>
  <tr>
    <td>1.0.0</td>
    <td>Initial Release</td>
  </tr>
</tbody>
</table>