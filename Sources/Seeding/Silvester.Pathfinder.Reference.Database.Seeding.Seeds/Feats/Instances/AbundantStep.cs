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
    public class AbundantStep : Template
    {
        public static readonly Guid ID = Guid.Parse("8100c235-fa85-45ab-942b-8138110a2ac9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Abundant Step",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("247333ae-b3d7-4bc1-9edc-54e1bcabee36"), Type = TextBlockType.Text, Text = $"You can teleport yourself a short distance. You gain the {ToMarkdownLink<Models.Entities.Spell>("abundant step", Spells.Instances.AbundantStep.ID)} ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("c376ae9c-db43-41e4-af72-eb73a89577df"), ClassFeatures.Monks.IncredibleMovement.ID);
            builder.HaveAnyKiSpells(Guid.Parse("ec0454f8-9f93-4735-9684-bf5fc429f22c"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8a10084-9693-46f7-b4c5-de77cf00546d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
