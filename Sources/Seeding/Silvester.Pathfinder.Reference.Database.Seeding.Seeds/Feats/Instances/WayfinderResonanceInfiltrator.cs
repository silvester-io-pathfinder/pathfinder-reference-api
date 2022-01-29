using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WayfinderResonanceInfiltrator : Template
    {
        public static readonly Guid ID = Guid.Parse("396513a4-b335-4996-9f4d-34bdcf34e9fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wayfinder Resonance Infiltrator",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c5e23e9-42c3-4377-a68a-5b04ff09af14"), Type = TextBlockType.Text, Text = $"You are adept at using the unusual resonance of your wayfinder to aid in any deceptions you might employ. Once per day you can activate your {ToMarkdownLink<Models.Items.Instances.WornItem>("wayfinder", Items.WornItems.Instances.Wayfinder.ID)} to cast {ToMarkdownLink<Models.Entities.Spell>("illusory disguise", Spells.Instances.IllusoryDisguise.ID)}, heightened to 2nd level, as an arcane spell." };
            yield return new TextBlock { Id = Guid.Parse("78b014a1-4da6-4b04-9afe-647454c15aff"), Type = TextBlockType.Text, Text = $"Additionally, once per day, you can activate your {ToMarkdownLink<Models.Items.Instances.WornItem>("wayfinder", Items.WornItems.Instances.Wayfinder.ID)} with a single-action envision activation to transform it into a perfect replica of another similarly sized badge of membership or office, such as an Aspis Consortium badge. This transformation lasts for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("95b88d7b-149d-4c5d-9bdf-1ae0478a4ccf"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("dead93c0-f7ba-45d9-83f3-092cd5c721aa"), Feats.Instances.WayfinderResonanceTinkerer.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4bfad4a4-7a65-48dc-ae78-f6bcd5d015d2"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e4e5fd6-8121-4bd8-9dc7-3e02dfe22f7a"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
