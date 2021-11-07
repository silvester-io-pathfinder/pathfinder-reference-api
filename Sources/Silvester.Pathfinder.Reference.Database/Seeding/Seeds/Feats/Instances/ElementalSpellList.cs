using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalSpellList : Template
    {
        public static readonly Guid ID = Guid.Parse("b1b90446-990b-4098-8006-a834e607c077");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Spell List",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3309b0dc-6c62-4129-af1f-61874ead716f"), Type = TextBlockType.Text, Text = "You can discuss with the GM any spells from other sources you want to add to your list. As a general rule, spells with the (trait: air), (trait: earth), (trait: fire), or (trait: water) trait belong on the list, including spells that add one of those traits depending on how they’re cast, such as (spell: elemental zone). Spells that are general and appear on every tradition’s spell list also make good candidates." };
            yield return new TextBlock { Id = Guid.Parse("4698bb29-d1e8-42b2-a16e-00a8e06f1db4"), Type = TextBlockType.Enumeration, Text = "**Elemental Cantrips***" };
            yield return new TextBlock { Id = Guid.Parse("201b35ff-a8cd-4bed-ada6-9b98bd186250"), Type = TextBlockType.Text, Text = "(spell: Dancing Lights): Create four floating lights you can move." };
            yield return new TextBlock { Id = Guid.Parse("da61f9f6-0ea9-4a5f-8db1-1371cf366977"), Type = TextBlockType.Text, Text = "(spell: Detect Magic): Sense whether magic is nearby." };
            yield return new TextBlock { Id = Guid.Parse("07d5c67e-9c58-415f-8dd4-1fe572a44870"), Type = TextBlockType.Text, Text = "(spell: Gale Blast): Damage and push adjacent creatures with air." };
            yield return new TextBlock { Id = Guid.Parse("3b92bd72-bec5-428c-b146-762fb77d864f"), Type = TextBlockType.Text, Text = "(spell: Healing Plaster): Transform mud into a healing plaster to treat wounds without healer’s tools." };
            yield return new TextBlock { Id = Guid.Parse("be03d8ed-f854-478c-93bc-8de72784575f"), Type = TextBlockType.Text, Text = "(spell: Light): Make an object glow." };
            yield return new TextBlock { Id = Guid.Parse("b07ffdd4-6119-4ba9-9f23-4654078a46b8"), Type = TextBlockType.Text, Text = "(spell: Mage Hand): Command a floating hand to move an object." };
            yield return new TextBlock { Id = Guid.Parse("053b96f5-0fc9-45c7-be5f-f5ed313d9371"), Type = TextBlockType.Text, Text = "(spell: Message): Speak a message to a distant creature, who can reply." };
            yield return new TextBlock { Id = Guid.Parse("0c19e19c-657b-4678-ae5d-9f6d8ce367e7"), Type = TextBlockType.Text, Text = "(spell: Prestidigitation): Perform a minor magical trick." };
            yield return new TextBlock { Id = Guid.Parse("53bb5534-223c-4828-b3f8-95d39b300505"), Type = TextBlockType.Text, Text = "(spell: Produce Flame): Kindle small flames to attack close or at range." };
            yield return new TextBlock { Id = Guid.Parse("ab37dbf8-98cc-4290-ac77-273c4b2480b4"), Type = TextBlockType.Text, Text = "(spell: Read Aura): Detect if an object is magical, and determine the school of its magic." };
            yield return new TextBlock { Id = Guid.Parse("e3657b74-d956-4f12-8628-d266547d7619"), Type = TextBlockType.Text, Text = "(spell: Scatter Scree): Evoke rocks to deal bludgeoning damage and make rocky difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("c4e73d8a-c0c7-43aa-9fa5-cdb58400dafc"), Type = TextBlockType.Text, Text = "(spell: Shield): A shield of magical force blocks attacks and magic missiles." };
            yield return new TextBlock { Id = Guid.Parse("5dddc084-cb01-4943-ba65-bcf9b3e38aa7"), Type = TextBlockType.Text, Text = "(spell: Sigil): Leave a magical mark." };
            yield return new TextBlock { Id = Guid.Parse("735e91da-2494-4ec0-8f8b-bce40f0d9d26"), Type = TextBlockType.Text, Text = "(spell: Spout): Water blast batters creatures and is larger if cast in a body of water." };
            yield return new TextBlock { Id = Guid.Parse("0375676a-37f7-4915-8ebb-f7328ce3a7d7"), Type = TextBlockType.Enumeration, Text = "**Elemental 1st-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("149c2b19-d6e1-4eda-a54d-660735471538"), Type = TextBlockType.Text, Text = "(spell: Air Bubble): React to create air for a creature to breathe." };
            yield return new TextBlock { Id = Guid.Parse("c6266c98-630f-42dc-9b79-eebadc278943"), Type = TextBlockType.Text, Text = "(spell: Breadcrumbs): Make a trail behind a creature." };
            yield return new TextBlock { Id = Guid.Parse("0c767b68-3ca4-4845-a072-0af05d184290"), Type = TextBlockType.Text, Text = "(spell: Burning Hands): A small cone of flame rushes from your hands." };
            yield return new TextBlock { Id = Guid.Parse("e713cd5b-18d4-49a6-adc0-55067268d9e6"), Type = TextBlockType.Text, Text = "(spell: Create Water): Conjure 2 gallons of water." };
            yield return new TextBlock { Id = Guid.Parse("96945af5-50a6-4e7a-8232-45b9da6533db"), Type = TextBlockType.Text, Text = "(spell: Feather Fall): React to slow a creature’s fall." };
            yield return new TextBlock { Id = Guid.Parse("792628c0-09d5-49e0-b574-44069bc4fe40"), Type = TextBlockType.Text, Text = "(spell: Gust of Wind): Wind blows out fires and knocks back objects and creatures." };
            yield return new TextBlock { Id = Guid.Parse("bdfdb8ab-d1ee-4e35-b59a-02334c0d6d18"), Type = TextBlockType.Text, Text = "(spell: Hydraulic Push): Damage and push a creature with a blast of water." };
            yield return new TextBlock { Id = Guid.Parse("a6f141c5-6d03-4d1d-bea9-0193b9bfd049"), Type = TextBlockType.Text, Text = "(spell: Mage Armor): Ward yourself with magical armor." };
            yield return new TextBlock { Id = Guid.Parse("81a072cc-9eb0-4609-a20e-68a0ea626dc4"), Type = TextBlockType.Text, Text = "(spell: Magic Stone): Make ordinary stones into magical sling bullets that are especially dangerous to undead." };
            yield return new TextBlock { Id = Guid.Parse("5d957178-bcdb-4483-a88b-97066f2f9add"), Type = TextBlockType.Text, Text = "(spell: Magic Weapon): Make a weapon temporarily magical." };
            yield return new TextBlock { Id = Guid.Parse("7724d01e-a2d9-48d2-8877-77920d413911"), Type = TextBlockType.Text, Text = "(spell: Mending): Repair one non-magical item." };
            yield return new TextBlock { Id = Guid.Parse("c627656c-b0b7-4cd7-a83d-c25a943c23df"), Type = TextBlockType.Text, Text = "(spell: Mud Pit): Conjure mud to slow movement." };
            yield return new TextBlock { Id = Guid.Parse("390f2e4b-3fd4-442c-a956-d1bc475a558d"), Type = TextBlockType.Text, Text = "(spell: Pet Cache): Hide a familiar or animal companion in a pocket dimension." };
            yield return new TextBlock { Id = Guid.Parse("20e01a0d-27ec-45d3-a064-50d1f1c0b743"), Type = TextBlockType.Text, Text = "(spell: Pummeling Rubble): Hurl a cone of rocks to batter creatures." };
            yield return new TextBlock { Id = Guid.Parse("2512a7f7-bcc8-4c8a-8569-8d8fd81c5e97"), Type = TextBlockType.Text, Text = "(spell: Shattering Gem): Make a protective gem orbit a target. The gem shatters against an attacker if destroyed." };
            yield return new TextBlock { Id = Guid.Parse("d456f365-c596-4c91-8c13-b71409c75d0a"), Type = TextBlockType.Text, Text = "(spell: Shockwave): Knock creatures down with a shockwave through the earth." };
            yield return new TextBlock { Id = Guid.Parse("340859b1-1d87-473f-8023-a7bcdcfc0bab"), Type = TextBlockType.Text, Text = "(spell: Snowball): Throw a snowball to chill and hinder a creature." };
            yield return new TextBlock { Id = Guid.Parse("2fa60023-3e06-450c-9ce4-f013677db9e2"), Type = TextBlockType.Text, Text = "(spell: Ventriloquism): Throw your voice." };
            yield return new TextBlock { Id = Guid.Parse("90482cfb-b69b-444b-be10-942b39bcaa34"), Type = TextBlockType.Enumeration, Text = "**Elemental 2nd-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("ee2a4f2d-26e6-470d-8342-13e676f74891"), Type = TextBlockType.Text, Text = "(spell: Ash Cloud): Summon a cloud of hot ash and smoke." };
            yield return new TextBlock { Id = Guid.Parse("3308f2ed-71a3-469a-afcf-0fbe526abb7e"), Type = TextBlockType.Text, Text = "(spell: Blistering Invective): Light a creature on fire with the sheer viciousness of your words." };
            yield return new TextBlock { Id = Guid.Parse("439fdeec-441f-446f-9345-c93c418b5c5c"), Type = TextBlockType.Text, Text = "(spell: Continual Flame): A magical flame burns indefinitely." };
            yield return new TextBlock { Id = Guid.Parse("72671807-7af1-4365-8ae5-79d2d13ceecd"), Type = TextBlockType.Text, Text = "(spell: Darkvision): See in the dark." };
            yield return new TextBlock { Id = Guid.Parse("24fa2d62-4b33-4e3c-ace0-e7e895267aa7"), Type = TextBlockType.Text, Text = "(spell: Dispel Magic): End a spell or suppress an item’s magic." };
            yield return new TextBlock { Id = Guid.Parse("1a36ce15-71bd-4bf6-bcd8-5c361f77f766"), Type = TextBlockType.Text, Text = "(spell: Elemental Zone): Make one element more damaging within a zone." };
            yield return new TextBlock { Id = Guid.Parse("7ee796b0-0a94-48f2-bc4f-19be8a63a6d8"), Type = TextBlockType.Text, Text = "(spell: Endure Elements): Protect a creature from severe cold or heat." };
            yield return new TextBlock { Id = Guid.Parse("08bec617-a665-4bef-b6e9-6b92bf388a10"), Type = TextBlockType.Text, Text = "(spell: Expeditious Excavation): Dig up loose soil, sand, and gravel." };
            yield return new TextBlock { Id = Guid.Parse("0c51df96-1d10-465c-854f-b17926379c54"), Type = TextBlockType.Text, Text = "(spell: Faerie Fire): Colorful light prevents creatures from being concealed or invisible." };
            yield return new TextBlock { Id = Guid.Parse("eb68533c-e971-4021-9c1b-716f24736e26"), Type = TextBlockType.Text, Text = "(spell: Final Sacrifice): Channel energy to blow up your minion." };
            yield return new TextBlock { Id = Guid.Parse("a7c6ed83-abac-489c-b3dc-11fd162ab211"), Type = TextBlockType.Text, Text = "(spell: Flame Wisp): Fire wisps damage those you strike, and more grow if you cast fire spells." };
            yield return new TextBlock { Id = Guid.Parse("42cdb351-8ed2-4e7e-b4a8-b465c132aea0"), Type = TextBlockType.Text, Text = "(spell: Flaming Sphere): A ball of fire rolls about at your command." };
            yield return new TextBlock { Id = Guid.Parse("bb106ed1-760d-455e-ad34-e86b93abfa66"), Type = TextBlockType.Text, Text = "(spell: Gentle Repose): A corpse doesn’t decay and can’t become undead." };
            yield return new TextBlock { Id = Guid.Parse("4610a6aa-f78f-48fd-b605-19687d6708a5"), Type = TextBlockType.Text, Text = "(spell: Heat Metal): Make metal red hot." };
            yield return new TextBlock { Id = Guid.Parse("7442ae98-e017-47b8-a2b5-74c21c645672"), Type = TextBlockType.Text, Text = "(spell: Ignite Fireworks): Throw exploding fireworks." };
            yield return new TextBlock { Id = Guid.Parse("dac4a853-73b9-43a1-8371-48104be646a3"), Type = TextBlockType.Text, Text = "(spell: Obscuring Mist): Conceal creatures in a cloud of mist." };
            yield return new TextBlock { Id = Guid.Parse("d4d167d1-72d9-4438-8542-b4907c7be5a9"), Type = TextBlockType.Text, Text = "(spell: Quench): Put out fires and hurt fire creatures." };
            yield return new TextBlock { Id = Guid.Parse("120986e8-1a3f-4468-912a-df4144af7395"), Type = TextBlockType.Text, Text = "(spell: Resist Energy): Protect a creature from one type of energy damage." };
            yield return new TextBlock { Id = Guid.Parse("2248ce71-d5fa-4ca3-af13-a0917ac95944"), Type = TextBlockType.Text, Text = "(spell: Scorching Ray): Fire one to three rays of heat and flame at different foes." };
            yield return new TextBlock { Id = Guid.Parse("7230f06d-84d5-4d72-948e-a2e8b197f9ae"), Type = TextBlockType.Text, Text = "(spell: Summon Elemental): Conjure an elemental to fight on your behalf." };
            yield return new TextBlock { Id = Guid.Parse("fbade2a1-2b90-4d9d-b91a-a63ced0ab991"), Type = TextBlockType.Text, Text = "(spell: Water Breathing): Allow creatures to breathe underwater." };
            yield return new TextBlock { Id = Guid.Parse("678b8639-3e35-42ec-9bd5-3e34b0a858ad"), Type = TextBlockType.Text, Text = "(spell: Water Walk): Buoy a creature so it can walk on water." };
            yield return new TextBlock { Id = Guid.Parse("d96d180d-75d1-4ed3-a8b2-adbf4db1bbf5"), Type = TextBlockType.Enumeration, Text = "**Elemental 3rd-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("f10c5b2c-5009-4b59-afa9-c6e841057648"), Type = TextBlockType.Text, Text = "(spell: Aqueous Orb): Roll a ball of water to put out fires and engulf creatures." };
            yield return new TextBlock { Id = Guid.Parse("9bfdf3b0-9e12-410e-a247-66f6ce2b683b"), Type = TextBlockType.Text, Text = "(spell: Blazing Dive): Fly up then dive in an explosion of superheated air." };
            yield return new TextBlock { Id = Guid.Parse("20fd1319-bb7e-4450-8ad7-53efaaee0cb8"), Type = TextBlockType.Text, Text = "(spell: Crashing Wave): Smash a cone of water against foes." };
            yield return new TextBlock { Id = Guid.Parse("5bd1130c-b5ca-40e2-8b5d-c8a20a1f3fce"), Type = TextBlockType.Text, Text = "(spell: Cup of Dust): Curse a creature with unquenchable thirst." };
            yield return new TextBlock { Id = Guid.Parse("58144ce4-ed4b-4235-a455-6bbd0e806fce"), Type = TextBlockType.Text, Text = "(spell: Earthbind): Bring a flying creature to the ground." };
            yield return new TextBlock { Id = Guid.Parse("6bfba4f8-7ba5-44c6-80cf-7702a599cf3b"), Type = TextBlockType.Text, Text = "(spell: Elemental Absorption): Resist elemental effects and then release the energy against a foe." };
            yield return new TextBlock { Id = Guid.Parse("962d4a56-0f72-4b36-be93-3d505568069a"), Type = TextBlockType.Text, Text = "(spell: Elemental Annihilation Wave): Draw in elemental energy to unleash a cone of burning destruction." };
            yield return new TextBlock { Id = Guid.Parse("f175dc0c-1f34-4c4a-90f6-204f360f474c"), Type = TextBlockType.Text, Text = "(spell: Feet to Fins): Turn a creature’s feet into fins, enabling it swim but slowing it on land." };
            yield return new TextBlock { Id = Guid.Parse("3e73b3f8-60b4-48b4-ae8f-0061b6e96aa8"), Type = TextBlockType.Text, Text = "(spell: Fireball): An explosion of fire in an area burns creatures." };
            yield return new TextBlock { Id = Guid.Parse("0bba265d-790a-47e2-908c-dd34dd89573e"), Type = TextBlockType.Text, Text = "(spell: Glyph of Warding): Store a spell in a symbol to make a trap." };
            yield return new TextBlock { Id = Guid.Parse("9c7c4154-c5a2-41b6-a4ff-25e18f7204e2"), Type = TextBlockType.Text, Text = "(spell: Levitate): Float an object or creature a few feet off the ground." };
            yield return new TextBlock { Id = Guid.Parse("489da4b6-4168-4cfe-a1ac-a7bcb7b53147"), Type = TextBlockType.Text, Text = "(spell: Meld into Stone): Merge into a block of stone." };
            yield return new TextBlock { Id = Guid.Parse("cf8679d0-d6d1-4ecc-aac7-30531ea93d56"), Type = TextBlockType.Text, Text = "(spell: Safe Passage): Make an area safe to move through." };
            yield return new TextBlock { Id = Guid.Parse("555feedd-0386-4b3a-83a0-b0daa55681e6"), Type = TextBlockType.Text, Text = "(spell: Searing Light): A ray of burning light deals extra damage to undead and counteracts darkness." };
            yield return new TextBlock { Id = Guid.Parse("47242a79-9a40-49f9-a610-12698bf56619"), Type = TextBlockType.Text, Text = "(spell: Shifting Sand): Cause sand or earth to become unstable and possibly immobilize and move creatures atop it." };
            yield return new TextBlock { Id = Guid.Parse("83493d77-1e0f-4c2d-b98b-2024ec23c145"), Type = TextBlockType.Text, Text = "(spell: Wall of Water): Create a wall of water, forcing foes to swim through." };
            yield return new TextBlock { Id = Guid.Parse("e80edcee-bda2-4af5-9e7e-7cc50c6609e4"), Type = TextBlockType.Text, Text = "(spell: Wall of Wind): Create a wall of gusting winds that hinders movement and ranged attacks." };
            yield return new TextBlock { Id = Guid.Parse("6cdef792-303b-49d5-9ede-93eef634a539"), Type = TextBlockType.Enumeration, Text = "**Elemental 4th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("8fab57c2-a7e3-478f-b6e3-e40d77f1439c"), Type = TextBlockType.Text, Text = "(spell: Air Walk): Walk on air as though it were solid ground." };
            yield return new TextBlock { Id = Guid.Parse("d4e6fe79-eb04-42d6-a4c0-69169a74c86b"), Type = TextBlockType.Text, Text = "(spell: Elemental Gift): Infuse an ally with one of the four elements." };
            yield return new TextBlock { Id = Guid.Parse("45cc0943-6857-43e4-9143-f4dcdc760dd1"), Type = TextBlockType.Text, Text = "(spell: Fire Shield): Flames protect you from cold and harm those that touch you." };
            yield return new TextBlock { Id = Guid.Parse("018bd35c-a343-4c5a-bac2-ccb454e3beab"), Type = TextBlockType.Text, Text = "(spell: Fly): Cause the target creature to gain a fly Speed." };
            yield return new TextBlock { Id = Guid.Parse("75766079-a980-4431-824d-11bbd3ad98c6"), Type = TextBlockType.Text, Text = "(spell: Gaseous Form): Turn a willing creature into a flying cloud." };
            yield return new TextBlock { Id = Guid.Parse("7c9806ed-0f6e-46fa-82d5-74abca8d72e7"), Type = TextBlockType.Text, Text = "(spell: Holy Cascade): Turn a vial of holy water into an explosion of blessed water." };
            yield return new TextBlock { Id = Guid.Parse("629a1cfa-69df-4013-9f7c-d670b148afb1"), Type = TextBlockType.Text, Text = "(spell: Hydraulic Torrent): Force creatures back with a damaging line of water." };
            yield return new TextBlock { Id = Guid.Parse("30556ecf-c4e6-4aa4-a5d1-be882ecfbef4"), Type = TextBlockType.Text, Text = "(spell: Petal Storm): A storm of razor-sharp petals slash creatures in the area." };
            yield return new TextBlock { Id = Guid.Parse("be7b38e8-2793-433d-bd6a-d348858b5484"), Type = TextBlockType.Text, Text = "(spell: Shape Stone): Reshape a cube of stone." };
            yield return new TextBlock { Id = Guid.Parse("4e2c6dd7-a9b5-4b51-ace3-b2cca00ec3dd"), Type = TextBlockType.Text, Text = "(spell: Solid Fog): Conjure heavy fog that obscures sight and is hard to move through." };
            yield return new TextBlock { Id = Guid.Parse("84806b1f-091b-4f07-9f27-531786803715"), Type = TextBlockType.Text, Text = "(spell: Soothing Spring): Create a rejuvenating hot spring that heals the wounded and tired." };
            yield return new TextBlock { Id = Guid.Parse("adbce89d-e8b7-4ee9-9bec-5c658e804aa4"), Type = TextBlockType.Text, Text = "(spell: Spell Immunity): Name a spell to negate its effects on you." };
            yield return new TextBlock { Id = Guid.Parse("7e8ef9d8-0593-4da6-8b00-8e62b82266dc"), Type = TextBlockType.Text, Text = "(spell: Spike Stones): Grow sharp spikes out of the ground." };
            yield return new TextBlock { Id = Guid.Parse("7a17dcb3-4307-4974-b0ea-b3e86490b33f"), Type = TextBlockType.Text, Text = "(spell: Stoneskin): Harden a creature’s skin into durable stone." };
            yield return new TextBlock { Id = Guid.Parse("31f25529-9579-4018-b5f3-725f3b919e6d"), Type = TextBlockType.Text, Text = "(spell: Wall of Fire): Create a blazing wall that burns creatures that pass through." };
            yield return new TextBlock { Id = Guid.Parse("b6f3cc84-7be5-4078-9329-e535db3b6ccf"), Type = TextBlockType.Enumeration, Text = "**Elemental 5th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("fd57b1f9-3fe9-4304-96a6-734add218106"), Type = TextBlockType.Text, Text = "(spell: Banishment): Send a creature back to its home plane." };
            yield return new TextBlock { Id = Guid.Parse("f23102b7-10fa-4190-8bed-13ee467bc549"), Type = TextBlockType.Text, Text = "(spell: Blazing Fissure): Rip a crack of magma in the earth." };
            yield return new TextBlock { Id = Guid.Parse("c8ddbaa8-bbc7-406b-9ea8-70353f20f887"), Type = TextBlockType.Text, Text = "(spell: Control Water): Raise or lower the water in a large area." };
            yield return new TextBlock { Id = Guid.Parse("82115e5b-3d02-47e9-b863-206a221124d1"), Type = TextBlockType.Text, Text = "(spell: Elemental Form): Turn into an elemental." };
            yield return new TextBlock { Id = Guid.Parse("fd691464-80ec-4199-823c-f7bb8061fce0"), Type = TextBlockType.Text, Text = "(spell: Flame Strike): Call divine fire from the sky." };
            yield return new TextBlock { Id = Guid.Parse("18b90f62-07af-49fb-8a07-19e9d166d41f"), Type = TextBlockType.Text, Text = "(spell: Flammable Fumes): Conjure poisonous fumes that can explode in flame." };
            yield return new TextBlock { Id = Guid.Parse("0f317db3-24c6-4c33-b5f2-f93b9626b227"), Type = TextBlockType.Text, Text = "(spell: Flowing Strike): Flow on a wave and attack on the way." };
            yield return new TextBlock { Id = Guid.Parse("bbaf5488-ca18-4eb5-9e76-e749a4eceb35"), Type = TextBlockType.Text, Text = "(spell: Geyser): Blast foes upward with superheated water, causing them to fall and leaving concealing fog." };
            yield return new TextBlock { Id = Guid.Parse("eae6971f-13cb-497d-9724-cf612f68fc83"), Type = TextBlockType.Text, Text = "(spell: Mantle of the Frozen Heart): Morph your body with ice, which you can change during the spell." };
            yield return new TextBlock { Id = Guid.Parse("4183d521-4311-4231-9296-71e202cfbb11"), Type = TextBlockType.Text, Text = "(spell: Mantle of the Magma Heart): Morph yourself with fire, which you can change during the spell." };
            yield return new TextBlock { Id = Guid.Parse("df1878d5-8db1-4b3f-8f98-637859d50ed5"), Type = TextBlockType.Text, Text = "(spell: Mariner’s Curse): Infect a creature with the curse of the rolling sea." };
            yield return new TextBlock { Id = Guid.Parse("cf0bbb3a-444c-400a-b2cd-c88558845863"), Type = TextBlockType.Text, Text = "(spell: Passwall): Form an earthen tunnel through a wall." };
            yield return new TextBlock { Id = Guid.Parse("2aaaec88-15c7-4e2b-bb4e-fd215ce8062b"), Type = TextBlockType.Text, Text = "(spell: Summon Giant): Conjure a giant to fight on your behalf." };
            yield return new TextBlock { Id = Guid.Parse("63d9ade3-634c-4f4b-aaf5-cc6dcba54d65"), Type = TextBlockType.Text, Text = "(spell: Temporary Glyph): Quickly scribe a short-lived glyph to blast foes." };
            yield return new TextBlock { Id = Guid.Parse("e5002151-5061-43cd-a29f-a6f20eb425f9"), Type = TextBlockType.Text, Text = "(spell: Transmute Rock and Mud): Turn an area of rock into mud or vice versa." };
            yield return new TextBlock { Id = Guid.Parse("1c21ba6c-043e-4cc1-b7b8-c03d542c540c"), Type = TextBlockType.Text, Text = "(spell: Wall of Ice): Sculpt a foot-thick wall of ice that blocks sight and can chill creatures." };
            yield return new TextBlock { Id = Guid.Parse("961ef56d-c367-495d-9234-27b101732a5b"), Type = TextBlockType.Text, Text = "(spell: Wall of Stone): Shape a wall of stone." };
            yield return new TextBlock { Id = Guid.Parse("302d983f-33a4-4a03-8cd8-55d2d5f466f0"), Type = TextBlockType.Enumeration, Text = "**Elemental 6th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("c59ade63-252a-489c-84b1-f24c0a969a90"), Type = TextBlockType.Text, Text = "(spell: Elemental Confluence): Summon a confluence of elementals of all four elements." };
            yield return new TextBlock { Id = Guid.Parse("474464a6-8704-4c8f-8e5d-35ae4fe15622"), Type = TextBlockType.Text, Text = "(spell: Fire Seeds): Make four explosive acorns." };
            yield return new TextBlock { Id = Guid.Parse("fcc2b3b0-c5e9-4047-8db3-116cd39e8f48"), Type = TextBlockType.Text, Text = "(spell: Flame Vortex): Invoke a moving tornado of fire and wind." };
            yield return new TextBlock { Id = Guid.Parse("b0fa6485-9b18-41a1-aa2f-0f8ca261f662"), Type = TextBlockType.Text, Text = "(spell: Flesh To Stone): Turn a living creature to a stone statue." };
            yield return new TextBlock { Id = Guid.Parse("aa7a0f9e-d656-4de1-a370-c8e6dc507d50"), Type = TextBlockType.Text, Text = "(spell: Scintillating Safeguard): Reactively protect multiple creatures from harm with a magic barrier." };
            yield return new TextBlock { Id = Guid.Parse("a77b6200-9474-4eda-93c8-73ce14e006d2"), Type = TextBlockType.Text, Text = "(spell: Stone Tell): Speak to spirits within natural stone." };
            yield return new TextBlock { Id = Guid.Parse("1cdadf27-c115-4d3d-bee0-97e1c3cbd42c"), Type = TextBlockType.Text, Text = "(spell: Stone to Flesh): Turn a creature turned to stone back to flesh." };
            yield return new TextBlock { Id = Guid.Parse("4f0787fe-d3de-4001-81c9-8ec008fd8dd5"), Type = TextBlockType.Text, Text = "(spell: Teleport): Transport you and willing creatures a great distance." };
            yield return new TextBlock { Id = Guid.Parse("7a7d0a6b-e92a-46c4-a941-e3140a0c61a7"), Type = TextBlockType.Text, Text = "(spell: True Seeing): See through illusions and transmutations." };
            yield return new TextBlock { Id = Guid.Parse("0d147d08-4773-4b9f-bae4-c4dda3a4efcb"), Type = TextBlockType.Enumeration, Text = "**Elemental 7th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("dc2b743e-e142-456e-b353-3dcb6f391414"), Type = TextBlockType.Text, Text = "(spell: Dimensional Lock): Prevent teleportation and planar travel." };
            yield return new TextBlock { Id = Guid.Parse("9b67a3cd-0674-49e9-8168-b5efde98356f"), Type = TextBlockType.Text, Text = "(spell: Energy Aegis): A creature gains resistance to acid, cold, electricity, fire, force, and sonic." };
            yield return new TextBlock { Id = Guid.Parse("9d183021-4d2e-4ff0-ba7f-2d4f01e753fd"), Type = TextBlockType.Text, Text = "(spell: Fiery Body): Turn your body into living flame." };
            yield return new TextBlock { Id = Guid.Parse("f50c1247-10ce-419e-96d5-a0068b1aff7a"), Type = TextBlockType.Text, Text = "(spell: Frigid Flurry): Turn into slashing snowflakes and fly in a straight line." };
            yield return new TextBlock { Id = Guid.Parse("3606029d-0b15-4651-a688-6fd8a20d35a7"), Type = TextBlockType.Text, Text = "(spell: Plane Shift): Transport creatures to another plane of existence." };
            yield return new TextBlock { Id = Guid.Parse("11c5ae1b-d0ed-4652-ad47-6870e8114c99"), Type = TextBlockType.Text, Text = "(spell: Sunburst): A globe of sunlight deals fire damage, hurts undead, and overcomes darkness." };
            yield return new TextBlock { Id = Guid.Parse("c351393b-51b2-4794-92e9-57d6ab8dafb8"), Type = TextBlockType.Text, Text = "(spell: Unfettered Pack): Let creatures avoid environmental hindrances." };
            yield return new TextBlock { Id = Guid.Parse("76e7715d-06e6-4d91-91fe-80f56414ba83"), Type = TextBlockType.Text, Text = "(spell: Volcanic Eruption): Cause massive lava sprays that burn creatures and encase them in rock." };
            yield return new TextBlock { Id = Guid.Parse("a62bbc5d-e5c9-4796-b233-db24b5ef8a1d"), Type = TextBlockType.Enumeration, Text = "**Elemental 8th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("02e8a987-b7bf-4f66-a9f6-42eaa93c8cc0"), Type = TextBlockType.Text, Text = "(spell: Boil Blood): Boil a foe’s blood." };
            yield return new TextBlock { Id = Guid.Parse("89a65a31-14e9-4a64-a92c-19b8c69ffc8f"), Type = TextBlockType.Text, Text = "(spell: Burning Blossoms): A tree fascinates enemies and burns people who stay under it." };
            yield return new TextBlock { Id = Guid.Parse("167949ad-248c-4697-9b21-03bf5e255b59"), Type = TextBlockType.Text, Text = "(spell: Earthquake): Shake the ground with a devastating earthquake." };
            yield return new TextBlock { Id = Guid.Parse("6611aba1-0c3b-4500-bda1-76af58d8d8af"), Type = TextBlockType.Text, Text = "(spell: Horrid Wilting): Pull moisture from creatures, damaging them." };
            yield return new TextBlock { Id = Guid.Parse("1b0bd8fe-928e-4755-9737-98f29667e0b4"), Type = TextBlockType.Text, Text = "(spell: Punishing Winds): A cyclone inhibits flight and traps creatures." };
            yield return new TextBlock { Id = Guid.Parse("5b2e6d4d-57e4-4cc7-b7a9-ece34091282c"), Type = TextBlockType.Text, Text = "(spell: Whirlwind): Create a moving tornado to damage creatures and raise them into the air." };
            yield return new TextBlock { Id = Guid.Parse("d3cb737d-51da-4bbe-8925-9fb34d28aaa7"), Type = TextBlockType.Text, Text = "(spell: Wind Walk): Turn creatures into swift-moving clouds." };
            yield return new TextBlock { Id = Guid.Parse("92ba31ef-01d6-43e7-a86e-15744db29c04"), Type = TextBlockType.Enumeration, Text = "**Elemental 9th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("43111f2a-20f5-4082-bcb8-6a71845f7e8a"), Type = TextBlockType.Text, Text = "(spell: Meteor Swarm): Call down four blazing meteors that explode." };
            yield return new TextBlock { Id = Guid.Parse("9c226fa5-4c05-4557-afbb-be162f702a43"), Type = TextBlockType.Text, Text = "(spell: Storm of Vengeance): Create a massive, dangerous storm." };
            yield return new TextBlock { Id = Guid.Parse("4c730be4-8321-48ab-9bfc-b48b49a04cf3"), Type = TextBlockType.Enumeration, Text = "**Elemental 10th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("7f8999a6-ea47-4756-8385-8d48fe678fae"), Type = TextBlockType.Text, Text = "(spell: Cataclysm): Call an instant, damaging cataclysm." };
            yield return new TextBlock { Id = Guid.Parse("22b0836b-f695-4a61-886c-1332f286f4ba"), Type = TextBlockType.Text, Text = "(spell: Element Embodied): Turn into a massive elemental." };
            yield return new TextBlock { Id = Guid.Parse("4dd91539-1de9-41cc-a258-8b15a8c524fc"), Type = TextBlockType.Text, Text = "(spell: Gate): Tear open a portal to another plane." };
            yield return new TextBlock { Id = Guid.Parse("ab78876c-ab7b-4959-bc88-32ed15907b1f"), Type = TextBlockType.Text, Text = "(spell: Indestructibility): Become briefly immune to everything." };
            yield return new TextBlock { Id = Guid.Parse("266b986d-fad0-4420-be96-bd672e567d33"), Type = TextBlockType.Text, Text = "(spell: Nullify): React to automatically counteract a spell and take backlash damage." };
            yield return new TextBlock { Id = Guid.Parse("7d5200ba-767f-4446-87a0-c79f3200dd23"), Type = TextBlockType.Text, Text = "(spell: Remake): Recreate a destroyed object." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da35a23c-63b3-4ee5-bd89-6410a5483f6d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
