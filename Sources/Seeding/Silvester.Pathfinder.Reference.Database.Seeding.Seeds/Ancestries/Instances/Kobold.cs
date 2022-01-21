using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Kobold : Template
    {
        public static readonly Guid ID = Guid.Parse("e6fe9bb0-f42c-44e1-a75b-8432091a1fe6");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Kobold", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Azrnak, Draahzin, Enga, Fazgyn, Fazij, Jekkajak, Kib, Kirrok, Mirkol, Tarka, Urkak, Varshez, Vroklan, Zekstikah, Zgaz"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("4999aa61-dda6-4ec5-8f4f-010fbd95844f"), Type = TextBlockType.Text, Text = "PFS NoteDue to years of successful Pathfinder Society activities, all characters have access to the kobold ancestry." };
            yield return new TextBlock { Id = Guid.Parse("13c68ad1-f0ab-4d74-b9c9-b5c8fa3abf8b"), Type = TextBlockType.Text, Text = "Every kobold knows that their slight frame belies true, mighty draconic power. They are ingenious crafters and devoted allies within their warrens, but those who trespass into their territory find them to be inspired skirmishers, especially when they have the backing of a draconic sorcerer or true dragon overlord. However, these reptilian opportunists prove happy to cooperate with other humanoids when it's to their benefit, combining caution and cunning to make their fortunes in the wider world." };
            yield return new TextBlock { Id = Guid.Parse("a6123675-e9d2-45b9-bb21-77124414dd7b"), Type = TextBlockType.Text, Text = "Kobolds are resourceful survivors whose snare-guarded warrens and opportunistic scavenging have cast them as villains to most other humanoids, with their draconic reverence lending them a reputation as mere minions and nuisances. Yet some kobolds have emerged from their secluded warrens seeking the relative safety of surface settlements, the lucrative prospects of the adventuring life, or validating awe from followers of their own." };
            yield return new TextBlock { Id = Guid.Parse("7587a92d-2068-41eb-9215-48255aae1da4"), Type = TextBlockType.Text, Text = "If you want a character with oversized confidence, deadly cunning, and the ancient power of dragons flowing through their veins, you should play a kobold." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("a8f59a5f-5b43-45fd-8f37-88a44b09597e"), Type = TextBlockType.Enumeration, Text = "Take pride in your draconic connections, whether you believe dragons are your ancestors or simply patrons. " };
            yield return new TextBlock { Id = Guid.Parse("0c93ec12-0d2e-47c6-a132-fe37d1149155"), Type = TextBlockType.Enumeration, Text = "Analyze your surroundings, always looking for ambushes, advantageous terrain, and escape routes. " };
            yield return new TextBlock { Id = Guid.Parse("4c7ac5db-c63c-476e-b88a-a0506f149533"), Type = TextBlockType.Enumeration, Text = "Naturally observe, adopt, and respect group dynamics, whether as leader, subordinate, or equal." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("a0437c54-bade-430b-a022-f9bfcf922e07"), Type = TextBlockType.Enumeration, Text = "Assume that you are cowardly and won't stick around in the face of danger. " };
            yield return new TextBlock { Id = Guid.Parse("81bc72c1-c83b-45db-a872-f7a6b599d467"), Type = TextBlockType.Enumeration, Text = "Appreciate your ingenuity and resourcefulness, especially when it comes to building defenses. " };
            yield return new TextBlock { Id = Guid.Parse("0c72eeb5-622b-4033-b332-04d21879f0a8"), Type = TextBlockType.Enumeration, Text = "Consider your claims of draconic power to be overblown, delusional, or endearing." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("53a2e057-d1f3-425a-82f9-2f081d82c7fd"), Type = TextBlockType.Text, Text = "Kobolds are short (about 3 feet tall) reptilian humanoids with slender bodies and long tails. They often boast distant draconic ancestry, and every kobold displays one or more draconic features, such as stout horns, razor-sharp teeth, or—more rarely—vestigial wings or draconic breath. They mature quickly, reaching adulthood by about 12 years and living to about 60." };
            yield return new TextBlock { Id = Guid.Parse("8df664ad-bf58-4ef6-9f10-fb69b38e53be"), Type = TextBlockType.Text, Text = "The color of a kobold's scales can vary widely. Most often, they mimic the hues of chromatic or metallic dragons, with a mix of slightly darker or lighter scales that create a mottled appearance. The scales of newly hatched kobolds often reflect the community's draconic exemplar, whether that's the dragon they currently serve or the dragon type from which they're descended." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("1a36ce57-22c5-456b-83d7-c1e89fe44276"), Type = TextBlockType.Text, Text = "Kobolds have an ingrained cautiousness that keeps them alive. They're secretive or subservient around powerful creatures to avoid becoming victims. This meekness fades once kobolds secure either a formidable patron (like a dragon) or a potent source of supernatural power (like an artifact or sorcerous leader). They often achieve an unshakable fervor and loyalty to their new cause or leader. However, kobolds are infamous for sensing a proverbial sinking ship, and once their source of power fails or seems doomed, their morale breaks swiftly." };
            yield return new TextBlock { Id = Guid.Parse("af792359-146e-48a6-b81a-c58b131b0b87"), Type = TextBlockType.Text, Text = "Whether led by a dragon or not, kobolds almost always identify themselves with a type of dragon that serves as their spiritual exemplar. Their societies regularly adopt laws and cultural norms inspired by the exemplar's personality." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("98e5512c-27c4-4bb6-9cf1-b4e5e2f7e1b4"), Type = TextBlockType.Text, Text = "All but the most iconoclastic kobolds have a natural respect for hierarchies and rules, and so kobolds are rarely chaotic. Kobold adventurers tend to be lawful neutral or neutral, relying on their ancestral social strategies for survival." };
            yield return new TextBlock { Id = Guid.Parse("083d884d-8747-40f4-8444-2a4f36be39dc"), Type = TextBlockType.Text, Text = "Organized religion feels natural for most kobolds, especially when a deity assumes a commanding or tyrannical disposition. Many gravitate towardAbadar's order orShelyn's artistic flair. More sinister communities upholdAsmodeusand other archdevils as common patrons. The dragon deitiesApsuandDahakare also common subjects of worship. Kobolds also often find themselves drawn to cults, particularly those with dragons or devils as figureheads." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("aa2cebf3-5d50-4515-8424-465b35302798"), Type = TextBlockType.Text, Text = "Kobolds often adventure in pursuit of the power, lore, and treasure that they feel befit their disproportionately large egos. When adventurers, militias, or careless tyrants shatter a kobold community, the survivors often latch onto new families, seeking emotional solace—and sometimes revenge. Typical kobold backgrounds includeartisan,artist,criminal,hunter,miner,scout, andtinkerfrom theCore Rulebook, plusbandit,cultist,scavenger, andservantfrom this book. Kobolds excel asbards,rangers,rogues, andsorcerers, though they also often channel their ingenuity asalchemistsorwizards." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("fad8ef11-afe2-4b14-bc17-a0f48cae72d1"), Type = TextBlockType.Text, Text = "A young kobold's given name is rarely more than a syllable or two. However, as they age, achieve status, and accomplish great deeds, kobolds add more syllables to their names, imitating a common draconic practice. Kobolds rarely have surnames except in an effort to better fit into a community, in which case they typically adopt the surname of an inspiring figure in that group." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("dc71e5a0-96a2-4fd2-98eb-5a73b12b45aa"), Type = TextBlockType.Heading, Text = "Kobold Origin" };
            yield return new TextBlock { Id = Guid.Parse("ff52ede7-db8d-46c2-ab3d-a140207870bd"), Type = TextBlockType.Text, Text = "Kobolds in the Inner Sea region have numerous origin stories, many tied to the conflict between the dragon gods Dahak and Apsu. Kobolds who live in caves near the surface often believe they predate true dragons, as Dahak scooped up their ancestors and transformed them into dragons. The further a kobold settlement is from a cave system, the less these tales link kobolds directly to dragons. Kobolds in swamps generally tell of their birth from blood that Dahak shed in battle, while those who dwell in trees and mountains often believe they were born of Dahak's tears." };

            yield return new TextBlock { Id = Guid.Parse("5e653097-33c1-451e-80d6-d7003a2c7759"), Type = TextBlockType.Heading, Text = "Other Kobolds" };
            yield return new TextBlock { Id = Guid.Parse("7928b089-6cf6-428d-9650-a05c81f562b7"), Type = TextBlockType.Text, Text = "Kobolds most commonly share the coloration and some physical resemblance to chromatic and metallic dragons, but others closely match different sets of true dragons—notably esoteric, imperial, planar, and primal dragons. In Tian Xia, kobolds with an imperial dragon appearance are nearly as common as those with chromatic and metallic features, and often take roles as advisors and spellcasters. Planar and primal kobolds sometimes hatch when a settlement is in great danger or exposed to planar energies, and are often considered to be destined for greatness. Esoteric kobolds are rare anywhere, though they appear more regularly in places with strange energies (such as the Impossible Lands), and are often feared and mistrusted by their clutchmates." };

            yield return new TextBlock { Id = Guid.Parse("9348c8e4-068a-41df-abdd-0aa03943df5b"), Type = TextBlockType.Heading, Text = "Traps!" };
            yield return new TextBlock { Id = Guid.Parse("aadb5a86-e6ea-4e4e-93df-2d9b12008956"), Type = TextBlockType.Text, Text = "Kobolds are renowned trap-makers and take great pride in their ability to design, develop, and construct cunning and complex varieties of these hidden defensive mechanisms, which they call “slow fangs.” They often test new trap concepts far from their homes, using them to hunt or harass disliked neighbors. This allows kobolds to iterate on designs, sometimes mixing traps to see if they're more effective in tandem rather than alone. Only once a trap idea has proven effective is it considered worthy to defend a kobold settlement." };
            yield return new TextBlock { Id = Guid.Parse("f2862d5f-2eb2-412d-a2a7-d06ab9382737"), Type = TextBlockType.Text, Text = "Trap-makers are treated by most kobold settlements as intellectual elites, and are often given the kind of deference other cultures reserve for priests and war heroes. A kobold tribe lacking a trap-maker is likely to send an emissary to find one and implore them to come teach their craft." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("6dcf5396-c59d-4feb-9426-617648e91416"), Type = TextBlockType.Heading, Text = "Draconic Exemplar" };
            yield return new TextBlock { Id = Guid.Parse("532d71ba-5e63-422b-8983-79fba6fa2be1"), Type = TextBlockType.Text, Text = "You draw minor powers from your draconic exemplar. Choose a type of chromatic or metallic dragon to be your exemplar. This determines your scale color and appearance, and dragons sometimes look more favorably upon those kobolds who resemble them, at the GM's discretion. Your exemplar may also determine details of other abilities you have, using the Draconic Exemplars table on page 13 of the Advanced Player's Guide" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Kobold.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("54bae08a-6fc6-46e8-a6f4-bdb9b85f9e01"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("e2999e6b-9060-4db9-be54-8e0215a4c92e"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("0e228cb3-a773-4a2c-aedc-5bdfe16a3647"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("51523533-4043-4e8c-be67-17e6674de591"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("a5a9dc30-1e14-45a2-abf8-8cd4f2a91d64"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("ac4ab466-dce9-4833-b9fe-d65ed01c16cf"), Stats.Instances.Constitution.ID);
            builder.GainSpecificLanguage(Guid.Parse("d98ed023-84c2-4564-aa42-75c9205525f0"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("b9b52271-71c5-49d0-8f64-039a6bf94b10"), Languages.Instances.Draconic.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("9c87e054-9baa-4ca9-a47d-6b1eaf08244e"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.GainAnyDraconicExemplar(Guid.Parse("46a2bf84-efcc-4956-b8f3-d0956db60d80"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbda3579-787a-4a66-82af-b0e97c3bd0ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }
    }
}
