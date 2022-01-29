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
    public class SolidLead : Template
    {
        public static readonly Guid ID = Guid.Parse("e450e633-5922-40fd-8e35-02037c647cf3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Solid Lead",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8034fc7-4795-4e2f-a8d0-a7dc8f94ed39"), Type = TextBlockType.Text, Text = $"Sometimes your case splinters into smaller mysteries, but you never lose sight of the big picture. Once per day when you give up on the subject of a lead due to using {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)} again, you can designate the lead you stopped pursuing as your solid lead for the day. Even though you stopped following the solid lead, you can change back to your solid lead any number of times by using a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. Doing so ends one of your current leads as normal." };
            yield return new TextBlock { Id = Guid.Parse("f3d31c5a-941f-4d05-be98-4e041efcb4cf"), Type = TextBlockType.Text, Text = $"During your next daily preparations, you can maintain your solid lead or you can remove it; removing it allows you to designate a new solid lead later that day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c439ea05-8b17-40bc-9ed4-cbcd280bb5c6"), Traits.Instances.Investigator.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fea97f73-a86f-4eca-82a9-556e1e2433af"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
