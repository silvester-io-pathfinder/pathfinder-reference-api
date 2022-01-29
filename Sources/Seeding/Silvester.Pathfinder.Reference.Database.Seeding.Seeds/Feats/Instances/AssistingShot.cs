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
    public class AssistingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("dd423334-70b5-4c93-93c9-ef1e253a9b13");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assisting Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70634893-0cc4-45dc-a0e5-9aee9f9a15e8"), Type = TextBlockType.Text, Text = $"With a quick shot, you interfere with a foe in combat. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a ranged weapon. If the strike hits, the next creature other than you to attack the same target before the start of your next turn gains a +1 circumstance bonus on their roll, or a +2 circumstance bonus if your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} was a critical hit." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66e2a6a6-8d9d-4ebf-9afc-f32b9b86db21"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
