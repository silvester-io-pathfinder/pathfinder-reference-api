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
    public class BrutishShove : Template
    {
        public static readonly Guid ID = Guid.Parse("37352e20-263c-4bf4-9cb6-bc420a1cba91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutish Shove",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3cf5ae8-8aeb-4265-9c75-4084521954e4"), Type = TextBlockType.Text, Text = $"Throwing your weight behind your attack, you hit your opponent hard enough to make it stumble back. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a two-handed melee weapon. If you hit a target that is your size or smaller, that creature is flat-footed until the end of your current turn, and you can automatically {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} it, with the same benefits as the {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} action (including the critical success effect, if your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} was a critical hit). If you move to follow the target, your movement doesn't trigger reactions." };
            yield return new TextBlock { Id = Guid.Parse("6ede90ce-f7ac-4b0c-a8b3-98168aa0a3d6"), Type = TextBlockType.Text, Text = $"This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} has the following failure effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b4cda445-4884-4019-b643-1791c2e380f1"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("cd574fd9-65be-4195-afdd-6eab1f3e298f"), Traits.Instances.Press.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("4bb2f77f-5b2d-4615-a302-a4dd0d8bd5f3"),
                
                
                Failure = "The target becomes flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9a01e6e-4ed8-4344-b2aa-d3e31f4f6f1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
