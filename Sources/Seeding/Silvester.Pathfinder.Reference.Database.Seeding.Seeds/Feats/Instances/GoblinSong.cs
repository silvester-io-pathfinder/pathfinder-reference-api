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
    public class GoblinSong : Template
    {
        public static readonly Guid ID = Guid.Parse("f1290ed9-9d72-44d1-ae5e-fbaf434ea8d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Song",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2acebcff-fd77-4171-94a9-edf2154463fe"), Type = TextBlockType.Text, Text = $"You sing annoying goblin songs, distracting your foes with silly and repetitive lyrics. Attempt a Performance check against the Will DC of a single enemy within 30 feet. This has all the usual traits and restrictions of a Performance check." };
            yield return new TextBlock { Id = Guid.Parse("90a481ba-891b-49ca-8662-fee095619d74"), Type = TextBlockType.Text, Text = $"You can affect up to two targets within range if you have expert proficiency in Performance, four if you have master proficiency, and eight if you have legendary proficiency." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Goblin.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5cb1dfc9-4e8f-4e6d-ac5e-4016c5b39209"),
                CriticalSuccess = "The target takes a -1 status penalty to Perception checks and Will saves for 1 minute.",
                Success = "The target takes a -1 status penalty to Perception checks and Will saves for 1 round.",
                
                CriticalFailure = "The target is temporarily immune to attempts to use Goblin Song for 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c580cd0-7628-42c0-a2b5-35a5cbdea958"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
