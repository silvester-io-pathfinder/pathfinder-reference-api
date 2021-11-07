using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedRedMantisMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("cc7aa4b6-a9f2-4a22-a5c8-41791449a60f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Red Mantis Magic",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d2836f3-5a19-402f-8ddb-9960f1c3190b"), Type = TextBlockType.Text, Text = "Your Red Mantis magical training has improved. Add two 2nd-level spells to your Red Mantis assassin spellbook. You gain a 2nd-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
            yield return new TextBlock { Id = Guid.Parse("d5d6d561-d245-4335-8cb2-5dd2a37b5682"), Type = TextBlockType.Text, Text = "At 8th level, add two 3rd-level spells to your Red Mantis assassin spellbook. You gain a 3rd-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
            yield return new TextBlock { Id = Guid.Parse("4824e416-ccb2-4942-a1ea-5d0e7f197a83"), Type = TextBlockType.Text, Text = "At 10th level, add two 4th-level spells to your Red Mantis assassin spellbook. You gain a 4th-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8a500548-02db-4e24-8a20-500a258a7296"), Feats.Instances.BasicRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f02bf65-b435-4035-9f8b-86aff8759408"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
