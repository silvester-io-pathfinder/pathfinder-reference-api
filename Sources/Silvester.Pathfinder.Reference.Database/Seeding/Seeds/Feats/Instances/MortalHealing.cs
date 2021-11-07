using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MortalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("939ef60b-d309-4242-b3e3-a1ec620187b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mortal Healing",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61ebc833-75d4-4e2b-a9e9-fe544c377583"), Type = TextBlockType.Text, Text = "You grant greater healing when the gods don’t interfere. When you roll a success to (Action: Treat Wounds) for a creature that hasn’t regained Hit Points from divine magic in the past 24 hours, you get a critical success on your check instead and restore the corresponding amount of Hit Points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90ac2fb2-bb72-4e8f-b9c0-3bdf6f623ed5"), Feats.Instances.GodlessHealing.ID);
            builder.FollowSpecificPhilosophy(Guid.Parse("166d86b6-8af6-46cb-830e-edb90552b6ed"), Philosophies.Instances.LawsOfMortality.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd92ad42-2104-4cb8-864d-d13952f94125"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
