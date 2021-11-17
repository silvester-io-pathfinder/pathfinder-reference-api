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
    public class Azarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("6f449503-156a-46db-b364-f84175ba06ac");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 20, 
                Name = "Azarketi", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Aft, Aliz, Cascade, Delta, Harbor, Ilani, Inkua, Jib, Lagoon, Lobay, Marine, Tidal, Windward, Zarket"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("aa45f5cb-421c-4a57-b1ad-4c8e1f13d75a"), Type = TextBlockType.Text, Text = "Azarketis, inheritors of a shattered empire's legacy, hold their proud traditions close but still surface to interact with the rest of the world." };
            yield return new TextBlock { Id = Guid.Parse("c1ec3dc2-178b-4468-8c92-c9bc9fad32c9"), Type = TextBlockType.Text, Text = "The aquatic humanoids of the Inner Sea share a somber and burdened history. Most refer to these aquatic peoples as gillmen or sometimes Low Azlanti, though they typically refer to themselves as azarketi, an Azlanti word that translates roughly to “people of the seas.” After Earthfall, these proud humans were mutated into aquatic servants by their alghollthu foes. Feeling like they don't fully belong with their human brethren nor with the sea that binds them, many azarketis struggle for a sense of identity and purpose. Though they remain distrusted by the surface dwellers, azarketis celebrate their unique lineage and their descent from the venerated Azlanti culture." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("eea56e38-c09a-4053-a51a-dfbbcaec65ac"), Type = TextBlockType.Enumeration, Text = "Ambitiously seek to defy negative perceptions and prejudice laid against you." };
            yield return new TextBlock { Id = Guid.Parse("8b951051-a928-497a-ac07-ddb9cfde13ad"), Type = TextBlockType.Enumeration, Text = "Be reclusive and skeptical of strangers." };
            yield return new TextBlock { Id = Guid.Parse("2186d62c-ef8a-4b67-b112-2d0ae5af3122"), Type = TextBlockType.Enumeration, Text = "Regard the water as your home, but be intrigued by societies along the shore." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("0dd6a72c-b164-4350-834e-4e903321d404"), Type = TextBlockType.Enumeration, Text = " Assume you are an ambassador to the sea and ask for your advice on nautical matters." };
            yield return new TextBlock { Id = Guid.Parse("c622d978-6e62-4a37-acd1-8526b781007d"), Type = TextBlockType.Enumeration, Text = "Misunderstand your gentle gestures and mild expressions." };
            yield return new TextBlock { Id = Guid.Parse("e93154a9-0d3b-43d2-99be-720dcc8e1886"), Type = TextBlockType.Enumeration, Text = "Treat you with distrust or suspicion and anticipate betrayal from you." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("7f4d8446-e42b-48a5-91be-c98c6b1db8d3"), Type = TextBlockType.Text, Text = "Azarketis appear as regal, athletic humans. Their soft, hydrophilic skin ranges in tones from pearlescent white to pinkish, greenish, or brown tones reminiscent of coral. Azarketis with hair are somewhat rare; many sport fins or scaled ridges on their heads instead. Like the Azlanti people from which they descend, they often have violet eyes. Their aquatic lineage is obvious thanks to the sets of three gills on either side of their necks, as well as their webbed hands and feet. Azarketis have been known to live longer than humans, although they mature at about the same rate." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("774b5d6e-cacf-4595-b5e9-bad787e218c9"), Type = TextBlockType.Text, Text = "Azarketis lack the center for combined culture that helps other groups maintain a cohesive identity. The vastness of the oceans and waterways spread these swift-swimming people across the Inner Sea and beyond. Many azarketis rely only on the small familial groups in their immediate community and prefer smaller populations with comrades they trust and know intimately." };
            yield return new TextBlock { Id = Guid.Parse("054c9fff-c8ec-4b6d-a64b-b4fb209d6357"), Type = TextBlockType.Text, Text = "Some azarketis prefer to foster connections with their surface-dwelling brethren. Living in ports, river towns and along the shore allows azarketis a greater scope of opportunities not afforded to exclusively land or sea peoples. Although integrating with land society can be difficult, azarketis manage by forming bonded communities. Members will often have fond familial names for one another, regardless of actual relation." };
            yield return new TextBlock { Id = Guid.Parse("1c66d8b4-b5c0-42df-bd32-2876340f7469"), Type = TextBlockType.Text, Text = "If they have the means, some azarketis dress in attire reflecting their Azlanti heritage. More commonly, azarketis do their best to remain inconspicuous when they emerge from the water. Many will wear shemaghs or other head wrappings, which both hide their gills and provide a few extra comfortable hours out of water if soaked before donning." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("5c37784e-d0a5-4032-bc19-b0303164ccf5"), Type = TextBlockType.Text, Text = "As they are typically outsiders to the domains of surface life, azarketis tend toward deities with an affinity for the ocean or other forms of water, the most popular beingGozreh. They are also likely to give reverence to other deities of nature or navigation, such asDesna." };
            yield return new TextBlock { Id = Guid.Parse("e2e1c53e-38f4-4c70-9d69-0f99303c31f1"), Type = TextBlockType.Text, Text = "Some azarketis are tempted toward the call of the deep and serve their oldalghollthumasters as gods. These individuals are enticed by eldritch entities such as the mysteriousveiled masters—powerful beings of the deep ocean responsible for both uplifting and destroying the Azlanti people." };
            yield return new TextBlock { Id = Guid.Parse("ab3e2c6c-5e05-4e43-a9e5-a0a88ea2a0a5"), Type = TextBlockType.Text, Text = "Azarketis vary wildly in beliefs and values, as evidenced by their broad divergence in allegiance; thus, azarketis can be of any alignment." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("58c5ea6b-6fe3-428c-a82d-dcb159491d10"), Type = TextBlockType.Text, Text = "With their affinity to water, nautical navigation skills, and athletic capabilities, azarketis make idealrangers. Azarketis' versatility both on land and in water make them particularly formidablefighters, while their direct connection to the sea leads many others to becomedruids. As many azarketis have a connection to alghollthus' occult magic, it's not uncommon for azarketis to besorcerers, though studious individuals sometimes becomebardsorwizardsinstead." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("ea1b059e-e990-4e6d-9df6-29044cf89c3e"), Type = TextBlockType.Text, Text = "Azarketis often take the names of nautical, weather, or geographical features important to the azarketi's family. Other azarketi groups will choose human names in order to encourage conformity with surface cultures. Some azarketi names have been passed down through so many generations that they still use ancient Azlanti roots or refer to bodies of water that no longer exist." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("f00806d1-d80e-409f-98b3-53f91af3e5d7"), Type = TextBlockType.Heading, Text = "Alghollthus" };
            yield return new TextBlock { Id = Guid.Parse("aa8518e1-6e16-44d1-aea7-eadebe9f121d"), Type = TextBlockType.Text, Text = "Azarketis have a complex relationship with alghollthus, who saved but then enslaved their people. Alvadnas have the greatest chance of meeting an alghollthu face to face. Azarketi sentiments toward these creatures vary: some fight fiercely against their ancient enemies; others bargain for power or safety, or even serve through compulsion." };
            yield return new TextBlock { Id = Guid.Parse("6458ac31-0ca4-40ac-a6a3-191726a2bf48"), Type = TextBlockType.Heading, Text = "Legacy of Azlant" };
            yield return new TextBlock { Id = Guid.Parse("3b00500a-0589-4457-bee2-362a8185a5df"), Type = TextBlockType.Text, Text = "Directly descended from the people of Azlant, azarketis have preserved their ancestors' culture through art, oral traditions, songs, and stories. Azarketi scholars study the history of Azlant and Earthfall, elders recite tales of Azlanti legends, and musicians sing songs to long-lost gods. Most azarketis know the location of the nearest Azlanti ruin, and many possess a piece of Azlanti jewelry." };
            yield return new TextBlock { Id = Guid.Parse("eed9b31e-226f-41d7-9928-7fbeff1cd5c7"), Type = TextBlockType.Heading, Text = "Other Sea Creatures" };
            yield return new TextBlock { Id = Guid.Parse("8529a6cf-2ddf-441d-90d9-652f4d545fd7"), Type = TextBlockType.Text, Text = "Azarketis are one of many ancestries to live beneath the water's surface. They have the most contact with locathahs, humanoid fish-folk with an easygoing, friendly demeanor. Azarketis find merfolk territorial neighbors, though their shared private tendencies lead to mostly amicable relations. Together they combat their shared enemies, the monstrous but intelligent sahuagins." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("c469c47c-1abd-4650-a0bf-aea86c09e9e7"), Type = TextBlockType.Heading, Text = "Hydration" };
            yield return new TextBlock { Id = Guid.Parse("3603f4e3-61ee-40ce-8aec-4174ee72f270"), Type = TextBlockType.Text, Text = "While you are an amphibious being equally as capable on land as in the water, your body requires you to return to aquatic environments at least once in a 24-hour period. You must submerge in water in order to rehydrate your water-acclimated skin. If you fail to do this, your skin begins to crack and your gills become painful. After the first 24 hours outside of water, you take a –1 status penalty to Fortitude saves. After 48 hours, you struggle to breathe air and begin to suffocate until returned to water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Amphibious.ID;
            yield return Traits.Instances.Azarketi.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("2e4ebfbf-dc06-42aa-adcf-7fbc8664bb7c"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("4a744a32-4ca1-4abb-97a0-6b2cc1493f0b"), MovementMethod.Walking, ModifierType.Add, modifier: 20);
            builder.ModifySpecificSpeed(Guid.Parse("eead2016-1846-4b3b-8552-962920663196"), MovementMethod.Swimming, ModifierType.Add, modifier: 30);
            builder.GainSpecificAbilityBoost(Guid.Parse("f78d6a08-133e-4d35-8b30-81e9477b9730"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("87a39a0c-8abb-4709-aad2-3c7ba30351fb"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("cde76849-5e77-4327-b741-28bdac9e5e58"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("bc91167d-7779-4918-a81b-f36d4f2b81c4"), Stats.Instances.Wisdom.ID);
            builder.GainSpecificLanguage(Guid.Parse("459cde9d-83e8-437f-83fb-905fc3a98136"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("f001d785-90d2-43c6-8cda-79affd8609ef"), Languages.Instances.Alghollthu.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("4f211536-1a72-4fb6-95f8-6535412edf6d"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add hydration effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fee332d8-81e2-4ce7-83be-601845c451c9"),
                SourceId = Sources.Instances.AzarketiAncestryWebSupplement.ID,
                Page = 3
            };
        }
    }
}
