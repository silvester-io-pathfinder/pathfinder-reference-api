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
    public class MedusasWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("15b34d0b-a7e6-454f-8f93-63f9e3c70116");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Medusa's Wrath",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f90f4b3-ccea-4af9-97cf-33244ee1d294"), Type = TextBlockType.Text, Text = $"You learn a monstrous ki technique that infuses your blows with the petrifying power of a medusa's gaze. You gain the {ToMarkdownLink<Models.Entities.Spell>("medusa's wrath", Spells.Instances.MedusasWrath.ID)} ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("b0684d3a-99b9-48fc-bba7-ab7ae27775bd"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bbcda509-b2e9-41b0-85af-6b4301beabae"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83703905-9321-4744-a4a2-9a31b7bdd4da"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
