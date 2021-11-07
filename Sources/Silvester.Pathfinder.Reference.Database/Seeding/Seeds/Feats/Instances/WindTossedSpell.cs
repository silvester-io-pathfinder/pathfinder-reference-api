using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WindTossedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("39abe8bd-18b3-476f-bfcb-dfe9ee5380ae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wind-Tossed Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c99db2b-999f-44d0-864e-223d1a326ab0"), Type = TextBlockType.Text, Text = "You enhance your spell with elemental air, using the wind to find your target and carry your magic around cover. If the next action you use is to (action: Cast a Spell) that requires a spell attack roll, you ignore the target’s concealed condition and any cover they have from you. The spell gains the (trait: air) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("950ec470-248b-428c-8afc-164e5fca8da9"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("570e67de-d8e3-492a-9473-b712ff97362d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
