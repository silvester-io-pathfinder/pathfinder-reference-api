using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoaringArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("5ff19d3a-b8ff-4ed1-897a-f0ee351ea552");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Armor",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c64a18c9-f90f-4a9c-88c3-8f169b6e9dac"), Type = TextBlockType.Text, Text = "Whether through a release of jets of flame, propeller blades, sonic bursts, streamlined aerodynamic structure, electromagnetic fields, or some combination of the above, you’ve managed to free your innovation from the bonds of gravity! While wearing your innovation, you gain a fly Speed equal to your land Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("ae026ce0-a9c5-4390-85cf-41a634b67434"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45eb3342-26e2-4946-905a-5684f369dc3b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
