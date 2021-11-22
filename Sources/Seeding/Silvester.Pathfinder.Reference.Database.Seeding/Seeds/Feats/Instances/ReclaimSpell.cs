using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReclaimSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("9c82064b-bdf9-4d25-beec-130820f44842");

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
            yield return new TextBlock { Id = Guid.Parse("aabec015-1778-4701-a9eb-8af4eb6ea157"), Type = TextBlockType.Text, Text = "You have learned to manipulate reflections of magic, similar to the resonant reflections. You reclaim the magic of an ongoing spell, using it to reprepare a spell with a duration. You (action: Dismiss) a spell of 4th level or lower that you cast today from a spell slot with at least half its duration remaining, even if that spell can't normally be (action: Dismissed | Dismiss). You can then spend 10 minutes to reprepare the spell in that spell slot, as (feat: Reprepare Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c7446867-dbab-44fe-9045-8fbf0b3a7ea6"), Feats.Instances.ReprepareSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a01168b-f1d2-425a-8bd5-257e8c190338"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
