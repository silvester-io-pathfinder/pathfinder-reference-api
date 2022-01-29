using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactivePursuit : Template
    {
        public static readonly Guid ID = Guid.Parse("a524ebeb-5159-4594-8bb5-e705a5588492");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Pursuit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent foe moves away from you, and you can reach at least one space adjacent to the foe with a Stride action.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91a501ff-7fdb-4782-bc05-ef12a78078f7"), Type = TextBlockType.Text, Text = $"You keep pace with a retreating foe. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, but you must end your movement adjacent to the triggering enemy. Your move does not trigger reactions from the triggering enemy. You can use Reactive Pursuit to {ToMarkdownLink<Models.Entities.Action>("Burrow", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a600cb3c-70e7-4d26-b298-45b7c98dc4ed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
