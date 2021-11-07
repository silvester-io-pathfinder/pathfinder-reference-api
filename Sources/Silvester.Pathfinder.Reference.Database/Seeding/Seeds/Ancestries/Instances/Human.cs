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
    public class Human : Template
    {
        public static readonly Guid ID = Guid.Parse("8880a5b5-1094-4808-9836-365c8858a4b2");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Human", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "A variety of human ethnic groups—many of which have origins on distant lands— populates the continents bordering Golarion’s Inner Sea. Human characters can be any of these ethnicities, regardless of what lands they call home. Characters of human ethnicities in the Inner Sea region speak Common (also known as Taldane), and some ethnicities grant access to an uncommon language."
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("241bc818-ae5d-4439-a960-b6719498f96a"), Type = TextBlockType.Text, Text = "As unpredictable and varied as any of Golarion’s peoples, humans have exceptional drive and the capacity to endure and expand. Though many civilizations thrived before humanity rose to prominence, humans have built some of the greatest and the most terrible societies throughout the course of history, and today they are the most populous people in the realms around the Inner Sea." };
            yield return new TextBlock { Id = Guid.Parse("33bd5233-6d0e-4962-a515-3a6e511cf4f7"), Type = TextBlockType.Text, Text = "Humans’ ambition, versatility, and exceptional potential have led to their status as the world’s predominant ancestry. Their empires and nations are vast, sprawling things, and their citizens carve names for themselves with the strength of their sword arms and the power of their spells. Humanity is diverse and tumultuous, running the gamut from nomadic to imperial, sinister to saintly. Many of them venture forth to explore, to map the expanse of the multiverse, to search for long-lost treasure, or to lead mighty armies to conquer their neighbors—for no better reason than because they can." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who can be just about anything, you should play a human." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("2d252ff5-a269-4522-b9f3-6f8e1d55f28a"), Type = TextBlockType.Enumeration, Text = "Strive to achieve greatness, either in your own right or on behalf of a cause. " };
            yield return new TextBlock { Id = Guid.Parse("4489973b-a5e7-42d0-868c-e4bd2bedc16d"), Type = TextBlockType.Enumeration, Text = "Seek to understand your purpose in the world. " };
            yield return new TextBlock { Id = Guid.Parse("c4d2f7f7-10b7-4554-8cf2-f8aa4e93c1d6"), Type = TextBlockType.Enumeration, Text = "Cherish your relationships with family and friends." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("8ac7ddf2-796d-4606-ae50-bde17ae595ae"), Type = TextBlockType.Enumeration, Text = "Respect your flexibility, your adaptability, and—in most cases— your open‑mindedness. " };
            yield return new TextBlock { Id = Guid.Parse("e2e04343-2422-492b-af78-0867a69457c8"), Type = TextBlockType.Enumeration, Text = "Distrust your intentions, fearing you seek only power or wealth. " };
            yield return new TextBlock { Id = Guid.Parse("aa77be0a-418b-406e-a470-e482656278c9"), Type = TextBlockType.Enumeration, Text = "Aren’t sure what to expect from you and are hesitant to assume your intentions." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("249786cc-1efb-4467-a81b-a25d6cb91382"), Type = TextBlockType.Text, Text = "Humans' physical characteristics are as varied as the world's climes. Humans have a wide variety of skin and hair colors, body types, and facial features. Generally speaking, their skin has a darker hue the closer to the equator they or their ancestors lived." };
            yield return new TextBlock { Id = Guid.Parse("de2e0427-afc9-4d53-80d9-f964483bcb73"), Type = TextBlockType.Text, Text = "Humans reach physical adulthood around the age of 15, though mental maturity occurs a few years later. A typical human can live to be around 90 years old. Humans often intermarry with people of other ancestries, giving rise to children who bear the traits of both parents. The most notable half-humans arehalf-elvesandhalf-orcs." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("178c2703-d8d0-48fa-ac61-9221dea5b901"), Type = TextBlockType.Text, Text = "Human variety also manifests in terms of their governments, attitudes, and social norms. Though the oldest of human cultures can trace their shared histories thousands of years into the past, when compared to the societies of theelvesordwarves, human civilizations seem in a state of constant flux as empires fragment and new kingdoms subsume the old." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("4daa00a0-8bdb-4225-9413-af78a126852f"), Type = TextBlockType.Text, Text = "Humanity is perhaps the most heterogeneous of all the ancestries, with a capacity for great evil and boundless good. Some humans assemble into vast raging hordes, while others build sprawling cities. Considered as a whole, most humans are neutral, yet they tend to congregate into nations or communities of a shared alignment, or at least a shared tendency toward an alignment. Humans also worship a wide range of gods and practice many different religions, tending to seek favor from any divine being they encounter." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield break;
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("f98f694a-8d6b-4e39-b2aa-3ef45be0211c"), Type = TextBlockType.Text, Text = "Unlike many ancestral cultures, which generally cleave to specific traditions and shared histories, humanity's diversity has resulted in a near-infinite set of names. The humans of northern tribes have different names than those dwelling in southern nation-states. Humans throughout much of the world speakCommon(though some continents on Golarion have their own regional common languages), yet their names are as varied as their beliefs and appearances." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Human.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("2d6862f4-b2b6-40af-bd6d-27e009c33a9a"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("53899532-3cfc-4613-b7e1-da5583ff2c23"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificLanguage(Guid.Parse("2b420d13-119b-48a9-b6b4-78818740458a"), Languages.Instances.Common.ID);
            //TODO: Add intelligence modifier languages.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("704555a0-74c4-4fe3-a0eb-1fc97508d09c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 55
            };
        }
    }
}
