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
    public class SuddenLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("2f5fc6a3-8c17-4b99-9909-07bdf7ad318e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sudden Leap",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have (feat: Felling Strike), you can spend 3 actions to make a Sudden Leap and use (feat: Felling Strike) instead of a normal (action: Strike).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68a30ca4-98ea-4f04-8d62-593c953a6cb8"), Type = TextBlockType.Text, Text = $"You make an impressive leap and swing while you soar. Make a {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} and attempt one melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} at any point during your jump. Immediately after the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you fall to the ground if you're in the air, even if you haven't reached the maximum distance of your jump. If the distance you fall is no more than the height of your jump, you take no damage and land upright." };
            yield return new TextBlock { Id = Guid.Parse("6d3e837d-4ec4-44b9-b3db-81ecaea60573"), Type = TextBlockType.Text, Text = $"When attempting a {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} during a Sudden Leap, determine the DC using the {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} DCs, and increase your maximum distance to double your Speed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25044586-6fd7-4508-8029-4674d9d96c62"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
