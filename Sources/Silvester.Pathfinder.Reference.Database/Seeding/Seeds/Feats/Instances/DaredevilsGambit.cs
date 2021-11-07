using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaredevilsGambit : Template
    {
        public static readonly Guid ID = Guid.Parse("25be77ce-b496-4e3c-9287-f00b538a238f");

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
            yield return new TextBlock { Id = Guid.Parse("3507620d-f7af-42fa-a858-b5a32255701b"), Type = TextBlockType.Text, Text = "If you critically succeed at your (feat: Daring Act), you can enter the target’s space and remain there until the beginning of your next turn or until the target moves, whichever comes first. You gain a +2 circumstance bonus to AC, and your target is flat-footed against your attacks while you are sharing its space in this way." };
            yield return new TextBlock { Id = Guid.Parse("925b2b30-356d-4da9-8b2d-628f86c97e50"), Type = TextBlockType.Text, Text = "If any creature other than your target hits you with an attack roll while you are sharing your target’s space, attempt a DC 15 flat check. On a success, resolve the attack against the target instead of you, using the same attack roll result that hit you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b5ea348b-802b-4759-8ccd-7f2013fdf5cd"), Feats.Instances.DaringAct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23b0ba62-7f50-4d77-afc5-bfc92068153d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
