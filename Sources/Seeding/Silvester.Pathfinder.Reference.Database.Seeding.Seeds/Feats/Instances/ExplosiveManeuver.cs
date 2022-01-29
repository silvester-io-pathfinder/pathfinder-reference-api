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
    public class ExplosiveManeuver : Template
    {
        public static readonly Guid ID = Guid.Parse("deb35321-8591-4bbc-94be-1686981058ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Maneuver",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8a5c112-803d-40e3-9053-be5eaf037798"), Type = TextBlockType.Text, Text = $"Thanks to a hidden experimental feature you built into your weapon, your weapon explosively deploys levers, tangling hooks, or similar mechanisms to provide significant assistance when you perform a combat maneuver. When you use Explosive Maneuver, choose {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}. Your weapon innovation must have a weapon trait that matches the action you chose (for instance, to choose {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}, your weapon must have the {ToMarkdownLink<Models.Entities.Trait>("grapple", Traits.Instances.Grapple.ID)} trait). You take the chosen action against the same foe as your previous successful {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, using the same multiple attack penalty as your previous successful {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You still increase your multiple attack penalty after the {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)}, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("c39897f6-1903-4138-8793-88d9d3a5285f"), Innovations.Instances.Weapon.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("46dc319a-3ab2-4179-b19f-16531af0dda0"), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5da8f614-3189-438d-b2f3-f3cf50353f99"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
