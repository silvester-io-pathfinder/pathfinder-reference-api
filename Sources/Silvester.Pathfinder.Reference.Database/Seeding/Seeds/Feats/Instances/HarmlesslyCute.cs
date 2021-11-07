using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarmlesslyCute : Template
    {
        public static readonly Guid ID = Guid.Parse("636e694e-4b6e-414f-b34b-4e4642f3195a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harmlessly Cute",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d20baa5c-3dd2-427f-8ad8-133b14425fbe"), Type = TextBlockType.Text, Text = "Your size and demeanor make it easy for you to convince others that you mean no harm. You gain the (Feat: Shameless Request) skill feat as a bonus feat. Additionally, you gain a +1 circumstance bonus to initiative checks when you roll Deception for initiative." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8823a7e0-c912-4dd2-b21f-623cb25366d7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
