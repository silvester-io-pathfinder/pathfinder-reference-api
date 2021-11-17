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
    public class Gnome : Template
    {
        public static readonly Guid ID = Guid.Parse("d6640493-d5ee-4f49-acd2-f33bda131358");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Gnome", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Abroshtor, Bastargre, Besh, Fijit, Halungalom, Krolmnite, Neji, Majet, Pai, Poshment, Queck, Trig, Zarzuket, Zatqualmie"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("ef2615bc-15a0-46a2-b7b8-70dd74afe272"), Type = TextBlockType.Text, Text = "Long ago, early gnome ancestors emigrated from the First World, realm of the fey. While it’s unclear why the first gnomes wandered to Golarion, this lineage manifests in modern gnomes as bizarre reasoning, eccentricity, obsessive tendencies, and what some see as naivete. These qualities are further reflected in their physical characteristics, such as spindly limbs, brightly colored hair, and childlike and extremely expressive facial features that further reflect their otherworldly origins." };
            yield return new TextBlock { Id = Guid.Parse("508baa79-8faf-454a-ab94-3ddddb814570"), Type = TextBlockType.Text, Text = "Always hungry for new experiences, gnomes constantly wander both mentally and physically, attempting to stave off a terrible ailment that threatens all of their people. This affliction—the Bleaching—strikes gnomes who fail to dream, innovate, and take in new experiences, in the gnomes' absence of crucial magical essence from theFirst World. Gnomes latch onto a source of localized magic where they live, typicallyprimalmagic, as befits theirfeylineage, but this isn't enough to avoid the Bleaching unless they supplement this magic with new experiences. The Bleaching slowly drains the color—literally—from gnomes, and it plunges those affected into states of deep depression that eventually claim their lives. Very few gnomes survive this scourge, becoming deeply morose and wise survivors known as bleachlings." };
            yield return new TextBlock { Id = Guid.Parse("1d223f31-924f-444f-b0f1-e2f142d2d33c"), Type = TextBlockType.Text, Text = "If you want a character with boundless enthusiasm and an alien, fey outlook on morality and life, you should play a gnome." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("fb5d1b09-a499-43fe-8ab1-f82b987b7e08"), Type = TextBlockType.Enumeration, Text = "Embrace learning and hop from one area of study to another without warning. " };
            yield return new TextBlock { Id = Guid.Parse("a262e101-3eb7-4fac-b9bb-d21505f092cf"), Type = TextBlockType.Enumeration, Text = "Rush into action before fully taking stock of the entire situation. " };
            yield return new TextBlock { Id = Guid.Parse("a8d0f3af-232c-4d7f-b842-3d382af3a6b6"), Type = TextBlockType.Enumeration, Text = "Speak, think, and move quickly, and lose patience with those who can’t keep up." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("34096c46-a305-4e39-a52f-2d0e2856f451"), Type = TextBlockType.Enumeration, Text = "Appreciate your enthusiasm and the energy with which you approach new situations. " };
            yield return new TextBlock { Id = Guid.Parse("68fba10e-c8bd-4cf8-82f1-cf5a4a046956"), Type = TextBlockType.Enumeration, Text = "Struggle to understand your motivations or adapt to your rapid changes of direction. " };
            yield return new TextBlock { Id = Guid.Parse("cba9b3b6-d61e-474b-b801-a7e6bd671e59"), Type = TextBlockType.Enumeration, Text = "See you as unpredictable, flighty, unreliable, or even reckless." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("c999b9b5-7140-4e49-a3aa-535c1c41662a"), Type = TextBlockType.Text, Text = "Most gnomes stand just over 3 feet in height and weigh little more than a human child. They exhibit a wide range of natural skin, hair, and eye colors. For gnomes that haven’t begun the Bleaching, nearly any hair and eye color other than white is possible, with vibrant colors most frequent, while skin tones span a slightly narrower spectrum and tend toward earthy tones and pinkish hues, though occasionally green, black, or pale blue. Gnomes’ large eyes and dense facial muscles allow them to be particularly expressive in their emotions. Gnomes typically reach physical maturity at the age of 18, though many gnomes maintain a childlike curiosity about the world even into adulthood. A gnome can theoretically live to any age if she can stave off the Bleaching indefinitely, but in practice gnomes rarely live longer than around 400 years." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("298ee62b-4021-47f9-97e4-bd4648f531f9"), Type = TextBlockType.Text, Text = "While most gnomes adopt some of the cultural practices of the region in which they live, they tend to pick and choose, adjusting their communities to fit their own fey logic. This often leads to majority gnome communities eventually consisting almost entirely of gnomes, as other people, bewildered by gnomish political decisions, choose to move elsewhere. Gnomes have little culture that they would consider entirely their own. No gnome kingdoms or nations exist on the surface of Golarion, and gnomes wouldn’t know what to do with such a state if they had one." };
            yield return new TextBlock { Id = Guid.Parse("d1d42cbb-c84c-44ce-a10d-740687e6b5d6"), Type = TextBlockType.Text, Text = "By necessity, few gnomes marry for life, instead allowing relationships to run their course before amicably moving on, the better to stave off the Bleaching with new experiences. Though gnome families tend to be small, many gnome communities raise children communally, with fluid family boundaries. As adults depart the settlement, unrelated adolescents sometimes tag along, creating adopted families to journey together." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("c48e555c-dba9-4593-86a1-34eca5aabeec"), Type = TextBlockType.Text, Text = "Though gnomes are impulsive tricksters with inscrutable motives and confusing methods, many at least attempt to make the world a better place. They are prone to fits of powerful emotion, and they are often good but rarely lawful. Gnomes most commonly worship deities that value individuality and nature, such asCayden Cailean,Desna,Gozreh, andShelyn." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("8998f558-7e79-491f-9b1d-98daea45fbb0"), Type = TextBlockType.Text, Text = "Adventure is not so much a choice as a necessity for most gnomes. Adventuring gnomes often claim mementos, allowing them to remember and relive their most exciting stories." };
            yield return new TextBlock { Id = Guid.Parse("cfb1f8b1-ea60-4239-babe-43096e79b198"), Type = TextBlockType.Text, Text = "Gnomes often consider theentertainer,merchant, ornomadbackgrounds. In addition, theanimal whisperer,barkeep,gambler, andtinkerbackgrounds are particularly appropriate." };
            yield return new TextBlock { Id = Guid.Parse("cfd289ea-b82f-45cd-a18e-09c7d84b054a"), Type = TextBlockType.Text, Text = "Gnomes' connection to magic makes spellcasting classes particularly thematic for you, especially classes that match the tradition of your primal innate spells, such asdruidor primalsorcerer, though wellspring gnomes might choose others." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("3d906827-f296-4c9f-a5be-8834c9f7a4a6"), Type = TextBlockType.Text, Text = "Gnome names can get quite complex and polysyllabic. They have little interest in familial names, and most children receive their names purely on a parent’s whim. Gnomes rarely concern themselves with how easy their names are to pronounce, and they often go by shorter nicknames. Some even collect and chronicle these nicknames. Among gnomes, the shorter the name, the more feminine it’s considered to be." };
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
            yield return Traits.Instances.Gnome.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("1661d5c8-e728-4afb-b322-71e69f841a2e"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("5c30b9c3-0efb-4284-afe6-825bcaeb6a10"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("cf9bd323-6c6b-43de-842e-aef6a5cde905"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("4f331db7-7f6b-427f-8a62-de6c5998cba0"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("5b39cdcc-4eda-4b38-90c7-fe06521cf880"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("00e2ba09-900a-4d57-9d71-643436cac8d0"), Stats.Instances.Strength.ID);
            builder.GainSpecificLanguage(Guid.Parse("952bf38a-b98a-497c-8d8d-a0e71bf27814"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("9c275c5c-3fec-4428-8581-a09eb37d5aa3"), Languages.Instances.Gnomish.ID);
            builder.GainSpecificLanguage(Guid.Parse("def9eb67-7b0d-464e-ad0c-6447123f58f3"), Languages.Instances.Sylvan.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("96786520-5848-44b1-8e6f-8612483bfb99"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93ee59e1-0aec-4d96-ae65-6f5eea8838ef"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 43
            };
        }
    }
}
