using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastSpeaker : Template
    {
        public static readonly Guid ID = Guid.Parse("395930e5-02a4-4927-be29-41daafd5f947");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast Speaker",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8149a3ef-e71d-4ffb-8f3c-c317b7b2a8b4"), Type = TextBlockType.Text, Text = "You constantly have the effects of (spell: speak with animals) as a 2nd-level innate primal spell. You gain a +2 circumstance bonus to Diplomacy checks to make a (action: Request) of animals while this spell is active." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9bb9b65f-68b7-433e-95f2-a2234a27a547"), Feats.Instances.AnimalTrainerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2de3aac-51c3-454a-8ae6-326fd4d9b05d"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
