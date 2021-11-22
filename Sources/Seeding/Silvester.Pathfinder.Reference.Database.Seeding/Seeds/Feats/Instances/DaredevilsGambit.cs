using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaredevilsGambit : Template
    {
        public static readonly Guid ID = Guid.Parse("d755a67b-e99a-4fcf-a963-99d40ea1920e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daredevil's Gambit",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b063c371-aeae-4af5-8b25-56804e5c67b8"), Type = TextBlockType.Text, Text = "If you critically succeed at your (feat: Daring Act), you can enter the target's space and remain there until the beginning of your next turn or until the target moves, whichever comes first. You gain a +2 circumstance bonus to AC, and your target is flat-footed against your attacks while you are sharing its space in this way." };
            yield return new TextBlock { Id = Guid.Parse("c904c958-9d77-41b6-9022-ad73490f399f"), Type = TextBlockType.Text, Text = "If any creature other than your target hits you with an attack roll while you are sharing your target's space, attempt a DC 15 flat check. On a success, resolve the attack against the target instead of you, using the same attack roll result that hit you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cbe55386-5e35-43fd-bcfe-7836e328879a"), Feats.Instances.DaringAct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e2c8d82-0755-4c77-9f06-545c5ec108c3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
