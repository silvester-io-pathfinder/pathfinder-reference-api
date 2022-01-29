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
    public class DaemonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("862a2c3f-4a21-4121-9a1a-864a6a05085f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daemon Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("608cb8f6-792c-46b6-8e26-bf4de3d9623b"), Type = TextBlockType.Text, Text = $"The magic of Abaddon runs through your blood, and you can wield that power. You can cast {ToMarkdownLink<Models.Entities.Spell>("death knell", Spells.Instances.DeathKnell.ID)} and {ToMarkdownLink<Models.Entities.Spell>("false life", Spells.Instances.FalseLife.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7eaa30fe-7761-41f6-a297-9af961fc95ab"), Feats.Instances.Grimspawn.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c489edca-61d3-4d18-9699-5ad84326cc10"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
