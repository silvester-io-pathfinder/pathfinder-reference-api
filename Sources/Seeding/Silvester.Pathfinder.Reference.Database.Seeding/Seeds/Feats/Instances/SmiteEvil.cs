using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmiteEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("c7cc5b73-bc91-42fc-a155-1a3e188857aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smite Evil",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85f09d59-62c8-48d4-b59c-cc560bb61d5f"), Type = TextBlockType.Text, Text = "Your blade ally becomes an even more powerful tool against evildoers. Select one foe you can see. Until the start of your next turn, your (action: Strikes | Strike) with the weapon your blade ally inhabits against that foe deal an extra 4 good damage, increasing to 6 if you have master proficiency with this weapon." };
            yield return new TextBlock { Id = Guid.Parse("e2b0c65d-0585-447b-aca1-d7235ed40771"), Type = TextBlockType.Text, Text = "If the foe attacks one of your allies, the duration extends to the end of that foe's next turn. If the foe continues to attack your allies each turn, the duration continues to extend." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("40f5faea-5ebd-482c-bb1a-460dc6fc11a1"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("e2a801b8-0dfe-466c-9ce2-3cc17e4574e4"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bb2f811-0a74-4f5d-9966-417237303cfc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
