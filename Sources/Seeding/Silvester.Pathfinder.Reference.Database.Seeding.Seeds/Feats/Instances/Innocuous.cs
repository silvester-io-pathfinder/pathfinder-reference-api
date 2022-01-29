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
    public class Innocuous : Template
    {
        public static readonly Guid ID = Guid.Parse("49b97551-3ec4-4b97-8f9b-3d63f6bd0a34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Innocuous",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00add803-04b7-4fb3-8248-27d971fb7a42"), Type = TextBlockType.Text, Text = $"Halflings have been unobtrusive assistants of larger folk for untold ages, and your people count on this assumption of innocence. You gain the trained proficiency rank in Deception (or another skill of your choice, if you're already trained in Deception). If you fail a Deception check to {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)}, humanoid creatures aren't aware that you were trying to trick them unless you get a critical failure on your roll." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("92063437-cffa-4ea1-a486-1a2aa12c0d98"), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e8674ac-b644-4959-a9cb-3b12208276ef"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
