using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JumpingJennyDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("cca056b9-b200-4beb-bd86-41d38b3198e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jumping Jenny Display",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6922c31-25bc-4ac8-a2e5-742b6c952a29"), Type = TextBlockType.Text, Text = $"This multi-sequence rocket blasts confetti at a series of altitudes. While the design is intended to delight children of all ages, you've found it has an unexpected side effect of confounding enemy fliers. You gain the Jumping Jenny fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("0e93ade9-a8d2-41a9-8a2e-dfc136a2a6b6"), Type = TextBlockType.Text, Text = $"~ Jumping Jenny: ONE-ACTION **Cost** 2 batches of infused reagents; **Effect** Target a flying creature within 60 feet. Until the start of your next turn, each time that creature attempts to {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)}, they must succeed at an Acrobatics check to {ToMarkdownLink<Models.Entities.SkillAction>("Maneuver in Flight", SkillActions.Instances.ManeuverInFlight.ID)} against the DC of your fireworks display, or the {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)} action is disrupted. If all the creature's attempts to {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)} are disrupted, at the end of its turn, it falls harmlessly to the ground below. A jumping jenny costs 2 batches of infused reagents, rather than 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("59a5a57c-8473-4412-b6c2-39523a047ecb"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a99d3d7-4013-4b20-bfac-8c229591a7d3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
