using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalSpellList : Template
    {
        public static readonly Guid ID = Guid.Parse("c635dd91-981f-4724-a0a6-dbda820eaffe");

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
            yield return new TextBlock { Id = Guid.Parse("3db073eb-c6be-4025-84ab-2f0bc67339cc"), Type = TextBlockType.Text, Text = "You can discuss with the GM any spells from other sources you want to add to your list. As a general rule, spells with the (trait: air), (trait: earth), (trait: fire), or (trait: water) trait belong on the list, including spells that add one of those traits depending on how they’re cast, such as (spell: elemental zone). Spells that are general and appear on every tradition’s spell list also make good candidates." };
            yield return new TextBlock { Id = Guid.Parse("c0a75ed6-8804-435f-b4db-efec5ea867f7"), Type = TextBlockType.Enumeration, Text = "**Elemental Cantrips***" };
            yield return new TextBlock { Id = Guid.Parse("eec13e64-25c6-4929-aca8-6b1051caa392"), Type = TextBlockType.Text, Text = "(spell: Dancing Lights): Create four floating lights you can move." };
            yield return new TextBlock { Id = Guid.Parse("345e7469-7a55-42bf-ace2-e0e8963b410b"), Type = TextBlockType.Text, Text = "(spell: Detect Magic): Sense whether magic is nearby." };
            yield return new TextBlock { Id = Guid.Parse("43767f36-85f4-475c-a131-a7d2fdff2613"), Type = TextBlockType.Text, Text = "(spell: Gale Blast): Damage and push adjacent creatures with air." };
            yield return new TextBlock { Id = Guid.Parse("bc434280-635a-499d-961c-e138dfa4b41f"), Type = TextBlockType.Text, Text = "(spell: Healing Plaster): Transform mud into a healing plaster to treat wounds without healer’s tools." };
            yield return new TextBlock { Id = Guid.Parse("db95b8dd-5b70-4861-bf4f-568c8b059177"), Type = TextBlockType.Text, Text = "(spell: Light): Make an object glow." };
            yield return new TextBlock { Id = Guid.Parse("55556b64-6de2-4ac0-989e-f78dce8f4ba3"), Type = TextBlockType.Text, Text = "(spell: Mage Hand): Command a floating hand to move an object." };
            yield return new TextBlock { Id = Guid.Parse("4581aab2-82af-4c80-adcb-dff789731483"), Type = TextBlockType.Text, Text = "(spell: Message): Speak a message to a distant creature, who can reply." };
            yield return new TextBlock { Id = Guid.Parse("6f11234e-c869-4758-a0d8-3e7e555cf47b"), Type = TextBlockType.Text, Text = "(spell: Prestidigitation): Perform a minor magical trick." };
            yield return new TextBlock { Id = Guid.Parse("373f9bf1-6980-4cd6-91b2-c1f2a617d128"), Type = TextBlockType.Text, Text = "(spell: Produce Flame): Kindle small flames to attack close or at range." };
            yield return new TextBlock { Id = Guid.Parse("b6098ef7-1313-4de8-b4ab-f8ffa9301e76"), Type = TextBlockType.Text, Text = "(spell: Read Aura): Detect if an object is magical, and determine the school of its magic." };
            yield return new TextBlock { Id = Guid.Parse("15d84611-65de-4559-b64c-9c5bba2e8d90"), Type = TextBlockType.Text, Text = "(spell: Scatter Scree): Evoke rocks to deal bludgeoning damage and make rocky difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("358a624f-b1fe-4022-8271-b200c0329189"), Type = TextBlockType.Text, Text = "(spell: Shield): A shield of magical force blocks attacks and magic missiles." };
            yield return new TextBlock { Id = Guid.Parse("163abbf4-106e-4ced-8124-9712c414420a"), Type = TextBlockType.Text, Text = "(spell: Sigil): Leave a magical mark." };
            yield return new TextBlock { Id = Guid.Parse("c2edbe15-bc6b-42b5-a976-82a371d9e4ed"), Type = TextBlockType.Text, Text = "(spell: Spout): Water blast batters creatures and is larger if cast in a body of water." };
            yield return new TextBlock { Id = Guid.Parse("31d351d0-ff3d-4bd3-a3cd-fe918e2bcb63"), Type = TextBlockType.Enumeration, Text = "**Elemental 1st-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("5f3841a8-154d-4cb2-b1d8-669df2d4099f"), Type = TextBlockType.Text, Text = "(spell: Air Bubble): React to create air for a creature to breathe." };
            yield return new TextBlock { Id = Guid.Parse("aa26d11f-4447-4b90-ac81-7ab6828406c4"), Type = TextBlockType.Text, Text = "(spell: Breadcrumbs): Make a trail behind a creature." };
            yield return new TextBlock { Id = Guid.Parse("92495733-cc48-48b1-84c7-8e0269407986"), Type = TextBlockType.Text, Text = "(spell: Burning Hands): A small cone of flame rushes from your hands." };
            yield return new TextBlock { Id = Guid.Parse("653e74a3-ae24-4237-9c0c-e77acb671094"), Type = TextBlockType.Text, Text = "(spell: Create Water): Conjure 2 gallons of water." };
            yield return new TextBlock { Id = Guid.Parse("83cef998-e055-4a14-956b-d18467d12d7c"), Type = TextBlockType.Text, Text = "(spell: Feather Fall): React to slow a creature’s fall." };
            yield return new TextBlock { Id = Guid.Parse("3e33d6a0-7a62-4c29-be89-24d1f7cbd875"), Type = TextBlockType.Text, Text = "(spell: Gust of Wind): Wind blows out fires and knocks back objects and creatures." };
            yield return new TextBlock { Id = Guid.Parse("684ffd1d-44b0-4e82-9fd3-c2f5943b0be6"), Type = TextBlockType.Text, Text = "(spell: Hydraulic Push): Damage and push a creature with a blast of water." };
            yield return new TextBlock { Id = Guid.Parse("0658660f-a65d-43f2-84e9-5ac6dd6ae35d"), Type = TextBlockType.Text, Text = "(spell: Mage Armor): Ward yourself with magical armor." };
            yield return new TextBlock { Id = Guid.Parse("4a4db15a-14e0-4285-aee7-1d5350ed4993"), Type = TextBlockType.Text, Text = "(spell: Magic Stone): Make ordinary stones into magical sling bullets that are especially dangerous to undead." };
            yield return new TextBlock { Id = Guid.Parse("2c139110-26c3-4cd0-b938-b41b4896e63d"), Type = TextBlockType.Text, Text = "(spell: Magic Weapon): Make a weapon temporarily magical." };
            yield return new TextBlock { Id = Guid.Parse("75fcdd65-3b65-4279-99bd-47df5b6e1e8a"), Type = TextBlockType.Text, Text = "(spell: Mending): Repair one non-magical item." };
            yield return new TextBlock { Id = Guid.Parse("f0c5a497-5ae7-4e43-afb2-11634ce0d46f"), Type = TextBlockType.Text, Text = "(spell: Mud Pit): Conjure mud to slow movement." };
            yield return new TextBlock { Id = Guid.Parse("a13bc573-5423-4adc-b398-3ace3b9acc9d"), Type = TextBlockType.Text, Text = "(spell: Pet Cache): Hide a familiar or animal companion in a pocket dimension." };
            yield return new TextBlock { Id = Guid.Parse("5056bbff-cfc4-4431-b06b-1366ebcc1112"), Type = TextBlockType.Text, Text = "(spell: Pummeling Rubble): Hurl a cone of rocks to batter creatures." };
            yield return new TextBlock { Id = Guid.Parse("6c73d315-9372-440d-bf11-b41594eabf67"), Type = TextBlockType.Text, Text = "(spell: Shattering Gem): Make a protective gem orbit a target. The gem shatters against an attacker if destroyed." };
            yield return new TextBlock { Id = Guid.Parse("7562f159-826f-425c-a999-1744780d6b44"), Type = TextBlockType.Text, Text = "(spell: Shockwave): Knock creatures down with a shockwave through the earth." };
            yield return new TextBlock { Id = Guid.Parse("267cc00a-7827-4fc8-816e-c572edac902b"), Type = TextBlockType.Text, Text = "(spell: Snowball): Throw a snowball to chill and hinder a creature." };
            yield return new TextBlock { Id = Guid.Parse("b55ef9b9-6799-474a-88f3-cdf5524a0002"), Type = TextBlockType.Text, Text = "(spell: Ventriloquism): Throw your voice." };
            yield return new TextBlock { Id = Guid.Parse("25cee66c-38fa-4227-91f2-6a65ab7c5ec1"), Type = TextBlockType.Enumeration, Text = "**Elemental 2nd-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("fb71cbc3-86f4-4b32-ba3d-38aee05fbe6e"), Type = TextBlockType.Text, Text = "(spell: Ash Cloud): Summon a cloud of hot ash and smoke." };
            yield return new TextBlock { Id = Guid.Parse("86494327-7930-4872-934c-099f5781df32"), Type = TextBlockType.Text, Text = "(spell: Blistering Invective): Light a creature on fire with the sheer viciousness of your words." };
            yield return new TextBlock { Id = Guid.Parse("c6bee0bf-9e01-43c1-b6ff-dad07486a4b7"), Type = TextBlockType.Text, Text = "(spell: Continual Flame): A magical flame burns indefinitely." };
            yield return new TextBlock { Id = Guid.Parse("cefd3844-266e-45ea-bdd1-9c8f8a8cc8be"), Type = TextBlockType.Text, Text = "(spell: Darkvision): See in the dark." };
            yield return new TextBlock { Id = Guid.Parse("521a73ba-2a4b-409c-be36-d1d0a1cee9bc"), Type = TextBlockType.Text, Text = "(spell: Dispel Magic): End a spell or suppress an item’s magic." };
            yield return new TextBlock { Id = Guid.Parse("dec70c78-3edb-4d67-8199-e4fad91f0ee9"), Type = TextBlockType.Text, Text = "(spell: Elemental Zone): Make one element more damaging within a zone." };
            yield return new TextBlock { Id = Guid.Parse("5d0fcedc-5c2c-4502-b7e5-a6ead7622471"), Type = TextBlockType.Text, Text = "(spell: Endure Elements): Protect a creature from severe cold or heat." };
            yield return new TextBlock { Id = Guid.Parse("9efde31d-55d6-4d2f-bbf8-4a87ae8d9d61"), Type = TextBlockType.Text, Text = "(spell: Expeditious Excavation): Dig up loose soil, sand, and gravel." };
            yield return new TextBlock { Id = Guid.Parse("1e198792-34a6-445a-829c-491d85be77a7"), Type = TextBlockType.Text, Text = "(spell: Faerie Fire): Colorful light prevents creatures from being concealed or invisible." };
            yield return new TextBlock { Id = Guid.Parse("d7441636-dc1e-4dd6-bb8d-67a9ba7e2952"), Type = TextBlockType.Text, Text = "(spell: Final Sacrifice): Channel energy to blow up your minion." };
            yield return new TextBlock { Id = Guid.Parse("6b10185c-1a48-46bd-92d6-2e627e45c5ff"), Type = TextBlockType.Text, Text = "(spell: Flame Wisp): Fire wisps damage those you strike, and more grow if you cast fire spells." };
            yield return new TextBlock { Id = Guid.Parse("beee3380-7cec-4920-93b5-238bc5bf20ff"), Type = TextBlockType.Text, Text = "(spell: Flaming Sphere): A ball of fire rolls about at your command." };
            yield return new TextBlock { Id = Guid.Parse("8f222428-0d4e-46b6-bde3-7d94804571a5"), Type = TextBlockType.Text, Text = "(spell: Gentle Repose): A corpse doesn’t decay and can’t become undead." };
            yield return new TextBlock { Id = Guid.Parse("1b6bab4e-8b00-47dd-8679-a8a303ca12c1"), Type = TextBlockType.Text, Text = "(spell: Heat Metal): Make metal red hot." };
            yield return new TextBlock { Id = Guid.Parse("0dd42036-e4e2-407b-a95d-fb84611cbeb6"), Type = TextBlockType.Text, Text = "(spell: Ignite Fireworks): Throw exploding fireworks." };
            yield return new TextBlock { Id = Guid.Parse("442c7cb3-6e63-4130-b915-e4e31e0405cb"), Type = TextBlockType.Text, Text = "(spell: Obscuring Mist): Conceal creatures in a cloud of mist." };
            yield return new TextBlock { Id = Guid.Parse("9c047381-990e-458d-bc7d-d7a2155320b9"), Type = TextBlockType.Text, Text = "(spell: Quench): Put out fires and hurt fire creatures." };
            yield return new TextBlock { Id = Guid.Parse("c4490f65-a2df-443c-8c3f-74ae4ee45626"), Type = TextBlockType.Text, Text = "(spell: Resist Energy): Protect a creature from one type of energy damage." };
            yield return new TextBlock { Id = Guid.Parse("3bde79d8-dfa7-4a0d-9a32-409345c5aa3b"), Type = TextBlockType.Text, Text = "(spell: Scorching Ray): Fire one to three rays of heat and flame at different foes." };
            yield return new TextBlock { Id = Guid.Parse("53afad8f-5e2c-496a-a4c5-668a1132b6a4"), Type = TextBlockType.Text, Text = "(spell: Summon Elemental): Conjure an elemental to fight on your behalf." };
            yield return new TextBlock { Id = Guid.Parse("719c1cc7-d414-4e6e-8b9d-3ad31ee5f322"), Type = TextBlockType.Text, Text = "(spell: Water Breathing): Allow creatures to breathe underwater." };
            yield return new TextBlock { Id = Guid.Parse("0800848f-4c15-4f3e-8540-186aab51537e"), Type = TextBlockType.Text, Text = "(spell: Water Walk): Buoy a creature so it can walk on water." };
            yield return new TextBlock { Id = Guid.Parse("bcd5d129-a18c-4a71-bf46-671107c26746"), Type = TextBlockType.Enumeration, Text = "**Elemental 3rd-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("d952a206-a7d2-4a4e-804c-8b5c572c8ba4"), Type = TextBlockType.Text, Text = "(spell: Aqueous Orb): Roll a ball of water to put out fires and engulf creatures." };
            yield return new TextBlock { Id = Guid.Parse("56b96f1c-3703-49d7-b529-d0c349137f78"), Type = TextBlockType.Text, Text = "(spell: Blazing Dive): Fly up then dive in an explosion of superheated air." };
            yield return new TextBlock { Id = Guid.Parse("3de6ac2a-1df6-43fb-ab09-cf40d0adcc40"), Type = TextBlockType.Text, Text = "(spell: Crashing Wave): Smash a cone of water against foes." };
            yield return new TextBlock { Id = Guid.Parse("c4895041-743b-440e-8ddf-a7a2e3f642c9"), Type = TextBlockType.Text, Text = "(spell: Cup of Dust): Curse a creature with unquenchable thirst." };
            yield return new TextBlock { Id = Guid.Parse("2eb3fd31-2e9c-489f-965e-e675b9f9f519"), Type = TextBlockType.Text, Text = "(spell: Earthbind): Bring a flying creature to the ground." };
            yield return new TextBlock { Id = Guid.Parse("7e2e3cb1-db79-40a2-9134-325022170195"), Type = TextBlockType.Text, Text = "(spell: Elemental Absorption): Resist elemental effects and then release the energy against a foe." };
            yield return new TextBlock { Id = Guid.Parse("fd95295c-2287-4b3e-b411-774d1368f4d9"), Type = TextBlockType.Text, Text = "(spell: Elemental Annihilation Wave): Draw in elemental energy to unleash a cone of burning destruction." };
            yield return new TextBlock { Id = Guid.Parse("abee69db-bb94-4e11-ae27-6b489af5d1ed"), Type = TextBlockType.Text, Text = "(spell: Feet to Fins): Turn a creature’s feet into fins, enabling it swim but slowing it on land." };
            yield return new TextBlock { Id = Guid.Parse("4aa9b590-f99f-4b8e-a1ab-bf0611d3e634"), Type = TextBlockType.Text, Text = "(spell: Fireball): An explosion of fire in an area burns creatures." };
            yield return new TextBlock { Id = Guid.Parse("e19d1283-bf22-4f17-9106-e0f077b530f4"), Type = TextBlockType.Text, Text = "(spell: Glyph of Warding): Store a spell in a symbol to make a trap." };
            yield return new TextBlock { Id = Guid.Parse("3b9cd73c-1ad4-45d9-bfbb-8f01d8e267cf"), Type = TextBlockType.Text, Text = "(spell: Levitate): Float an object or creature a few feet off the ground." };
            yield return new TextBlock { Id = Guid.Parse("c86c5c0a-43ac-4957-b2f4-b1350c724116"), Type = TextBlockType.Text, Text = "(spell: Meld into Stone): Merge into a block of stone." };
            yield return new TextBlock { Id = Guid.Parse("77732073-50db-4242-95a0-bdbbcb034075"), Type = TextBlockType.Text, Text = "(spell: Safe Passage): Make an area safe to move through." };
            yield return new TextBlock { Id = Guid.Parse("9b7aa624-9e46-480d-b994-27d4270bbc41"), Type = TextBlockType.Text, Text = "(spell: Searing Light): A ray of burning light deals extra damage to undead and counteracts darkness." };
            yield return new TextBlock { Id = Guid.Parse("2b2af3fc-894d-4c21-99f1-190b4a10ca37"), Type = TextBlockType.Text, Text = "(spell: Shifting Sand): Cause sand or earth to become unstable and possibly immobilize and move creatures atop it." };
            yield return new TextBlock { Id = Guid.Parse("9870b6ba-4584-4c93-a2fc-43d14482c5d9"), Type = TextBlockType.Text, Text = "(spell: Wall of Water): Create a wall of water, forcing foes to swim through." };
            yield return new TextBlock { Id = Guid.Parse("1026b16e-3def-48e7-a403-50660b969dcb"), Type = TextBlockType.Text, Text = "(spell: Wall of Wind): Create a wall of gusting winds that hinders movement and ranged attacks." };
            yield return new TextBlock { Id = Guid.Parse("08875347-0d31-4195-a6cb-633c7a5702f8"), Type = TextBlockType.Enumeration, Text = "**Elemental 4th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("bb0a3193-520e-4d98-ba4c-41588760ea9e"), Type = TextBlockType.Text, Text = "(spell: Air Walk): Walk on air as though it were solid ground." };
            yield return new TextBlock { Id = Guid.Parse("389cc6f6-cccf-4c90-a3e1-68d8afdd720d"), Type = TextBlockType.Text, Text = "(spell: Elemental Gift): Infuse an ally with one of the four elements." };
            yield return new TextBlock { Id = Guid.Parse("990ff94c-c4a1-4b69-80c6-7200e87e7434"), Type = TextBlockType.Text, Text = "(spell: Fire Shield): Flames protect you from cold and harm those that touch you." };
            yield return new TextBlock { Id = Guid.Parse("0e808c13-fa8f-4239-9517-1666cdcd5f96"), Type = TextBlockType.Text, Text = "(spell: Fly): Cause the target creature to gain a fly Speed." };
            yield return new TextBlock { Id = Guid.Parse("25622e11-4b92-4198-8e22-c8477768e0f7"), Type = TextBlockType.Text, Text = "(spell: Gaseous Form): Turn a willing creature into a flying cloud." };
            yield return new TextBlock { Id = Guid.Parse("a6191004-bb2c-4f90-93e3-72b0c4eec607"), Type = TextBlockType.Text, Text = "(spell: Holy Cascade): Turn a vial of holy water into an explosion of blessed water." };
            yield return new TextBlock { Id = Guid.Parse("a922eb11-e8c3-4da3-a8b0-e8e0e324656a"), Type = TextBlockType.Text, Text = "(spell: Hydraulic Torrent): Force creatures back with a damaging line of water." };
            yield return new TextBlock { Id = Guid.Parse("9358bddb-2c0e-4172-8761-927cca655002"), Type = TextBlockType.Text, Text = "(spell: Petal Storm): A storm of razor-sharp petals slash creatures in the area." };
            yield return new TextBlock { Id = Guid.Parse("c0fee32d-3bf4-4f5c-9103-f3ab621a9255"), Type = TextBlockType.Text, Text = "(spell: Shape Stone): Reshape a cube of stone." };
            yield return new TextBlock { Id = Guid.Parse("9465d5f9-bd09-4c3c-a849-d997bb1178a7"), Type = TextBlockType.Text, Text = "(spell: Solid Fog): Conjure heavy fog that obscures sight and is hard to move through." };
            yield return new TextBlock { Id = Guid.Parse("c6c91be2-19b5-48a9-9a90-340c86063e29"), Type = TextBlockType.Text, Text = "(spell: Soothing Spring): Create a rejuvenating hot spring that heals the wounded and tired." };
            yield return new TextBlock { Id = Guid.Parse("6073fa2d-7f1d-43e7-bcaf-47cbb7539a40"), Type = TextBlockType.Text, Text = "(spell: Spell Immunity): Name a spell to negate its effects on you." };
            yield return new TextBlock { Id = Guid.Parse("1ac36e5e-66d7-429e-b14b-e31d532b89fc"), Type = TextBlockType.Text, Text = "(spell: Spike Stones): Grow sharp spikes out of the ground." };
            yield return new TextBlock { Id = Guid.Parse("e2fa4e99-931e-4ca2-aac0-abe7b8ced8f2"), Type = TextBlockType.Text, Text = "(spell: Stoneskin): Harden a creature’s skin into durable stone." };
            yield return new TextBlock { Id = Guid.Parse("64fc7b46-55c7-42f2-a33c-5c4e308409bd"), Type = TextBlockType.Text, Text = "(spell: Wall of Fire): Create a blazing wall that burns creatures that pass through." };
            yield return new TextBlock { Id = Guid.Parse("355e0508-01e6-404d-a6fa-5c785b738972"), Type = TextBlockType.Enumeration, Text = "**Elemental 5th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("70dc10bf-1791-4cc4-bd88-c214046bd5cb"), Type = TextBlockType.Text, Text = "(spell: Banishment): Send a creature back to its home plane." };
            yield return new TextBlock { Id = Guid.Parse("0bc98e7f-c0ae-45af-8b4e-abb1ee3f614b"), Type = TextBlockType.Text, Text = "(spell: Blazing Fissure): Rip a crack of magma in the earth." };
            yield return new TextBlock { Id = Guid.Parse("bb46661c-0457-4de6-aa37-5bd2dcb16bd8"), Type = TextBlockType.Text, Text = "(spell: Control Water): Raise or lower the water in a large area." };
            yield return new TextBlock { Id = Guid.Parse("ea9f4ef1-31b2-4199-b555-2bb88712d471"), Type = TextBlockType.Text, Text = "(spell: Elemental Form): Turn into an elemental." };
            yield return new TextBlock { Id = Guid.Parse("1a01d1c4-406f-4d65-ab76-eab5dc97534c"), Type = TextBlockType.Text, Text = "(spell: Flame Strike): Call divine fire from the sky." };
            yield return new TextBlock { Id = Guid.Parse("cec9cda4-65e2-4cb0-b402-a455f3b4f507"), Type = TextBlockType.Text, Text = "(spell: Flammable Fumes): Conjure poisonous fumes that can explode in flame." };
            yield return new TextBlock { Id = Guid.Parse("2555cbd0-488e-4172-9d01-e2f29e27b7de"), Type = TextBlockType.Text, Text = "(spell: Flowing Strike): Flow on a wave and attack on the way." };
            yield return new TextBlock { Id = Guid.Parse("cc55e0bc-b1ec-4a97-b9fe-35b130a3a8e3"), Type = TextBlockType.Text, Text = "(spell: Geyser): Blast foes upward with superheated water, causing them to fall and leaving concealing fog." };
            yield return new TextBlock { Id = Guid.Parse("eea643f4-f6f1-4f83-865c-06611dfce656"), Type = TextBlockType.Text, Text = "(spell: Mantle of the Frozen Heart): Morph your body with ice, which you can change during the spell." };
            yield return new TextBlock { Id = Guid.Parse("589b007f-a6eb-46a5-9633-1c7e3b3db74a"), Type = TextBlockType.Text, Text = "(spell: Mantle of the Magma Heart): Morph yourself with fire, which you can change during the spell." };
            yield return new TextBlock { Id = Guid.Parse("c9a338a6-c225-4d6a-aa4b-e04fda5eea01"), Type = TextBlockType.Text, Text = "(spell: Mariner’s Curse): Infect a creature with the curse of the rolling sea." };
            yield return new TextBlock { Id = Guid.Parse("26723f33-1726-434a-a49a-195c83efb35c"), Type = TextBlockType.Text, Text = "(spell: Passwall): Form an earthen tunnel through a wall." };
            yield return new TextBlock { Id = Guid.Parse("34fe1ca8-d6e0-4e73-901c-9a96dc4921fa"), Type = TextBlockType.Text, Text = "(spell: Summon Giant): Conjure a giant to fight on your behalf." };
            yield return new TextBlock { Id = Guid.Parse("f0a375a5-cdb2-4cb4-b683-ec2bfbc75569"), Type = TextBlockType.Text, Text = "(spell: Temporary Glyph): Quickly scribe a short-lived glyph to blast foes." };
            yield return new TextBlock { Id = Guid.Parse("79bb2c3b-c629-43b9-be41-3ea7222d45ad"), Type = TextBlockType.Text, Text = "(spell: Transmute Rock and Mud): Turn an area of rock into mud or vice versa." };
            yield return new TextBlock { Id = Guid.Parse("f82a0d00-4297-4c51-90c4-04f6ac725451"), Type = TextBlockType.Text, Text = "(spell: Wall of Ice): Sculpt a foot-thick wall of ice that blocks sight and can chill creatures." };
            yield return new TextBlock { Id = Guid.Parse("d04ddfa2-6fa5-4a66-b46e-aa1ea103bc46"), Type = TextBlockType.Text, Text = "(spell: Wall of Stone): Shape a wall of stone." };
            yield return new TextBlock { Id = Guid.Parse("b20d95bd-0491-4477-8d01-0fd1234951e6"), Type = TextBlockType.Enumeration, Text = "**Elemental 6th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("6dc6be89-5c76-4770-a1f2-9eae13e0ea92"), Type = TextBlockType.Text, Text = "(spell: Elemental Confluence): Summon a confluence of elementals of all four elements." };
            yield return new TextBlock { Id = Guid.Parse("341e0505-7a90-4112-8ec4-e6be7b950be4"), Type = TextBlockType.Text, Text = "(spell: Fire Seeds): Make four explosive acorns." };
            yield return new TextBlock { Id = Guid.Parse("5772e052-cba7-42ab-842f-120a7e644cd5"), Type = TextBlockType.Text, Text = "(spell: Flame Vortex): Invoke a moving tornado of fire and wind." };
            yield return new TextBlock { Id = Guid.Parse("91112821-bf64-4d81-9886-8530d4aff274"), Type = TextBlockType.Text, Text = "(spell: Flesh To Stone): Turn a living creature to a stone statue." };
            yield return new TextBlock { Id = Guid.Parse("b0a78f98-7527-4049-8b27-c5dca07e698b"), Type = TextBlockType.Text, Text = "(spell: Scintillating Safeguard): Reactively protect multiple creatures from harm with a magic barrier." };
            yield return new TextBlock { Id = Guid.Parse("be5d3a21-7b8a-4510-b85f-2c8e5e7002a5"), Type = TextBlockType.Text, Text = "(spell: Stone Tell): Speak to spirits within natural stone." };
            yield return new TextBlock { Id = Guid.Parse("6b27c21f-7ba6-4f5f-8cbc-b0bb9fa5ee72"), Type = TextBlockType.Text, Text = "(spell: Stone to Flesh): Turn a creature turned to stone back to flesh." };
            yield return new TextBlock { Id = Guid.Parse("bc6dfaab-95eb-474d-9234-a6334d72933b"), Type = TextBlockType.Text, Text = "(spell: Teleport): Transport you and willing creatures a great distance." };
            yield return new TextBlock { Id = Guid.Parse("9b515c9f-983d-41b5-aa37-d0e477bcfcdc"), Type = TextBlockType.Text, Text = "(spell: True Seeing): See through illusions and transmutations." };
            yield return new TextBlock { Id = Guid.Parse("3c91aaaa-de2f-4245-910c-425d68dd1d93"), Type = TextBlockType.Enumeration, Text = "**Elemental 7th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("87851588-a4e9-4662-a955-7d5959a9a2ee"), Type = TextBlockType.Text, Text = "(spell: Dimensional Lock): Prevent teleportation and planar travel." };
            yield return new TextBlock { Id = Guid.Parse("0b896e02-f11e-4d8e-bc6c-9a3f1c7003ec"), Type = TextBlockType.Text, Text = "(spell: Energy Aegis): A creature gains resistance to acid, cold, electricity, fire, force, and sonic." };
            yield return new TextBlock { Id = Guid.Parse("bf01e270-e39d-4ab7-8407-5ef549863c88"), Type = TextBlockType.Text, Text = "(spell: Fiery Body): Turn your body into living flame." };
            yield return new TextBlock { Id = Guid.Parse("e1aa9eef-d4a0-4d85-99d9-bf2ba7120965"), Type = TextBlockType.Text, Text = "(spell: Frigid Flurry): Turn into slashing snowflakes and fly in a straight line." };
            yield return new TextBlock { Id = Guid.Parse("2d612525-b113-4086-9df2-aa2df0a9202e"), Type = TextBlockType.Text, Text = "(spell: Plane Shift): Transport creatures to another plane of existence." };
            yield return new TextBlock { Id = Guid.Parse("f02b5ecf-d0c0-4efa-9605-9ebd70b3f813"), Type = TextBlockType.Text, Text = "(spell: Sunburst): A globe of sunlight deals fire damage, hurts undead, and overcomes darkness." };
            yield return new TextBlock { Id = Guid.Parse("7391c404-2ae2-4997-a3b1-2549ebe9a00e"), Type = TextBlockType.Text, Text = "(spell: Unfettered Pack): Let creatures avoid environmental hindrances." };
            yield return new TextBlock { Id = Guid.Parse("ed097c9e-d02f-4c6a-8e8c-2081d1dbd7f4"), Type = TextBlockType.Text, Text = "(spell: Volcanic Eruption): Cause massive lava sprays that burn creatures and encase them in rock." };
            yield return new TextBlock { Id = Guid.Parse("dc32c1d2-c110-4ef7-a6b1-8d6e72d96e9d"), Type = TextBlockType.Enumeration, Text = "**Elemental 8th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("a3aedf08-9b3d-405d-a7ab-3ceeadae79df"), Type = TextBlockType.Text, Text = "(spell: Boil Blood): Boil a foe’s blood." };
            yield return new TextBlock { Id = Guid.Parse("cd569060-784b-48d5-9195-20b4513176fa"), Type = TextBlockType.Text, Text = "(spell: Burning Blossoms): A tree fascinates enemies and burns people who stay under it." };
            yield return new TextBlock { Id = Guid.Parse("5d315984-c295-4223-9b6c-beb716cac6f9"), Type = TextBlockType.Text, Text = "(spell: Earthquake): Shake the ground with a devastating earthquake." };
            yield return new TextBlock { Id = Guid.Parse("7bcaf085-dddc-4cac-b8de-349e4f8e78fe"), Type = TextBlockType.Text, Text = "(spell: Horrid Wilting): Pull moisture from creatures, damaging them." };
            yield return new TextBlock { Id = Guid.Parse("b7038805-1852-4551-969b-aab185afd02e"), Type = TextBlockType.Text, Text = "(spell: Punishing Winds): A cyclone inhibits flight and traps creatures." };
            yield return new TextBlock { Id = Guid.Parse("ba1e939a-d6ba-44d3-ae0a-e00d12c9247c"), Type = TextBlockType.Text, Text = "(spell: Whirlwind): Create a moving tornado to damage creatures and raise them into the air." };
            yield return new TextBlock { Id = Guid.Parse("21dcc126-cd44-4996-8366-35e510fa65f6"), Type = TextBlockType.Text, Text = "(spell: Wind Walk): Turn creatures into swift-moving clouds." };
            yield return new TextBlock { Id = Guid.Parse("e1294765-1972-40b5-9160-4c8952254f51"), Type = TextBlockType.Enumeration, Text = "**Elemental 9th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("7e2455d6-dee5-4a5c-9d2f-41ce9629075c"), Type = TextBlockType.Text, Text = "(spell: Meteor Swarm): Call down four blazing meteors that explode." };
            yield return new TextBlock { Id = Guid.Parse("9abe33db-575d-4ab7-b625-67426ca6631d"), Type = TextBlockType.Text, Text = "(spell: Storm of Vengeance): Create a massive, dangerous storm." };
            yield return new TextBlock { Id = Guid.Parse("d9239244-6cd3-460d-9bfd-960895ccff16"), Type = TextBlockType.Enumeration, Text = "**Elemental 10th-Level Spells***" };
            yield return new TextBlock { Id = Guid.Parse("b07a678e-0095-4681-bd23-130b10dd9ed4"), Type = TextBlockType.Text, Text = "(spell: Cataclysm): Call an instant, damaging cataclysm." };
            yield return new TextBlock { Id = Guid.Parse("fb69ca76-2c71-4a7e-8ae5-d1841604156d"), Type = TextBlockType.Text, Text = "(spell: Element Embodied): Turn into a massive elemental." };
            yield return new TextBlock { Id = Guid.Parse("471d10c7-ff64-4386-b814-5ff6ad3f4b9d"), Type = TextBlockType.Text, Text = "(spell: Gate): Tear open a portal to another plane." };
            yield return new TextBlock { Id = Guid.Parse("449c849a-94f7-409f-a580-845fd974c875"), Type = TextBlockType.Text, Text = "(spell: Indestructibility): Become briefly immune to everything." };
            yield return new TextBlock { Id = Guid.Parse("eca1b0d8-c74a-4d6b-86df-379885c742e4"), Type = TextBlockType.Text, Text = "(spell: Nullify): React to automatically counteract a spell and take backlash damage." };
            yield return new TextBlock { Id = Guid.Parse("db6fada8-4377-45a5-a796-2cd278808a7f"), Type = TextBlockType.Text, Text = "(spell: Remake): Recreate a destroyed object." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b511411e-5fbf-4d98-8a8e-ae030b7466e4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
