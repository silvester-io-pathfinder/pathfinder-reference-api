using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JumpingJennyDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("3faa7264-9d98-46a4-b019-efffd10a73ee");

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
            yield return new TextBlock { Id = Guid.Parse("97720bf4-406b-4348-8857-b947c69b4504"), Type = TextBlockType.Text, Text = "This multi-sequence rocket blasts confetti at a series of altitudes. While the design is intended to delight children of all ages, you’ve found it has an unexpected side effect of confounding enemy fliers. You gain the Jumping Jenny fireworks display." };
            yield return new TextBlock { Id = Guid.Parse("2eeb3668-eafe-441e-9de2-61cc7d8d69c3"), Type = TextBlockType.Text, Text = "~ Jumping Jenny: ONE-ACTION **Cost** 2 batches of infused reagents; **Effect** Target a flying creature within 60 feet. Until the start of your next turn, each time that creature attempts to (action: Fly), they must succeed at an Acrobatics check to (action: Maneuver in Flight) against the DC of your fireworks display, or the (action: Fly) action is disrupted. If all the creature’s attempts to (action: Fly) are disrupted, at the end of its turn, it falls harmlessly to the ground below. A jumping jenny costs 2 batches of infused reagents, rather than 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("95569fcc-fed5-4536-aaef-b0f773505d10"), Feats.Instances.FireworkTechnicianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3071955-b02c-4cce-a262-4944c6c28bb5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
