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
    public class BlastTackle : Template
    {
        public static readonly Guid ID = Guid.Parse("1c5aab51-8393-4637-869b-d8b22da6c950");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blast Tackle",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7b99322-e632-4958-9e77-595836ad013c"), Type = TextBlockType.Text, Text = $"You throw yourself at an enemy, bracing your weapon against it and pulling it close before releasing a destructive shot. Attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}; if you're wielding your weapon in both hands, you {ToMarkdownLink<Models.Entities.Action>("Release", Actions.Instances.Release.ID)} one hand to do so. If your {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} succeeds, you can immediately {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} the target of the {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)} with the required weapon, even if it's a two-handed weapon you're holding in one hand. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals an additional 3d6 precision damage." };
            yield return new TextBlock { Id = Guid.Parse("3deed722-6708-4670-aea0-e37b03571cbd"), Type = TextBlockType.Text, Text = $"As long the creature remains grabbed or restrained, you can use just one hand to reload the weapon and {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that creature with it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("41dd14b0-2de8-4df5-accf-e512a5817a12"), GunslingersWays.Instances.WayOfTheVanguard.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4ebaf647-717b-4201-a885-48e9082eb534"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e61b607f-3d25-419d-9a87-097187a2ea2e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
