using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurgingMight : Template
    {
        public static readonly Guid ID = Guid.Parse("24feac1f-b923-45b2-9007-fdcea3278ff8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surging Might",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59635da3-a762-4ac2-92fb-2dfe9c4af765"), Type = TextBlockType.Text, Text = "With a complex gesture, you focus the power of your spell to overcome enemies’ resistances. If the next action you use is to (action: Cast a Spell), the spell ignores an amount of the target’s resistance equal to your level against all the following types of damage: chaotic, evil, good, lawful, negative, and positive. This applies to all damage the spell deals, including persistent damage and damage caused by an ongoing effect of the spell, such as the positive energy within a (spell: field of life). This doesn’t cause the spell to ignore immunities, only resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("46932cf9-7254-4a9c-a59c-9e5b0ae6a8f0"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1c39032-4f9f-419d-875e-2e13515fa1c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
