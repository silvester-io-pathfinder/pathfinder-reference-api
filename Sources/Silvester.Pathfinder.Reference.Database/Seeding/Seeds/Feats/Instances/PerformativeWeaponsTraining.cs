using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerformativeWeaponsTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("676bea0c-c4a0-48bd-9df2-174b8db72492");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Performative Weapons Training",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14ae2f7d-c217-4ab4-a368-7d5e3478f69d"), Type = TextBlockType.Text, Text = "You’re skilled with flashy weapons. You are trained with the (item: bo staff), (item: dueling cape), (item: spiked chain), (item: sword cane), and (item: whip). Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency in the weapons listed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("91c283fa-4eb0-4722-a2fd-0797243c00b5"), Feats.Instances.GladiatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c1630d5-6a82-4060-acfe-2e2df02f0079"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
