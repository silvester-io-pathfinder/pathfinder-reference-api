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
    public class HydraulicManeuvers : Template
    {
        public static readonly Guid ID = Guid.Parse("849cd979-2ed2-42d4-98fe-47c8a58e3a68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hydraulic Maneuvers",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ec46021-ecc5-48c2-b841-3bb8e36435b3"), Type = TextBlockType.Text, Text = $"You batter your foes with a torrent of water siphoned from your surroundings. If the next action you take is an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}, that action has a range of 15 feet. You don't receive any item bonuses to that check or any circumstance bonuses related to your physical body, but if you roll a critical failure on that Athletics check, you get a failure instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Azarketi.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Water.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaecf3fe-5c6c-416a-a1d3-8b6737694829"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
