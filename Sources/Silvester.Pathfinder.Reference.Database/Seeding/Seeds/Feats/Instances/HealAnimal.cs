using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("355b3c3a-9553-4aa2-bdd3-bdd642c5f38a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heal Animal",
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
            yield return new TextBlock { Id = Guid.Parse("6b8fbd86-a6a8-409c-b3a2-4431f3dda2f2"), Type = TextBlockType.Text, Text = "You can heal your animal companion’s wounds. You can cast (spell: heal animal) as a beastmaster focus spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e93718e1-036e-4803-ac4c-98cdb336d707"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76913693-16f2-4001-bc52-6d083f19a2cd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
