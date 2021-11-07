using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReclaimSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("47356674-96d9-40f1-8dbd-1de0bffeb5d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reclaim Spell",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15ca6435-40e3-4332-bd10-79008fbf1d97"), Type = TextBlockType.Text, Text = "You have learned to manipulate reflections of magic, similar to the resonant reflections. You reclaim the magic of an ongoing spell, using it to reprepare a spell with a duration. You (action: Dismiss) a spell of 4th level or lower that you cast today from a spell slot with at least half its duration remaining, even if that spell can’t normally be (action: Dismissed | Dismiss). You can then spend 10 minutes to reprepare the spell in that spell slot, as (feat: Reprepare Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e8840bcd-f879-4589-b360-230c8c363b7c"), Feats.Instances.ReprepareSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7713573a-ffc0-4887-946e-5bee7b39fe12"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
