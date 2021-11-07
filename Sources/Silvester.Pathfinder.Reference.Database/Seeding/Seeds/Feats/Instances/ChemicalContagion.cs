using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChemicalContagion : Template
    {
        public static readonly Guid ID = Guid.Parse("35b0ed84-ac6a-4619-b0d8-b14b606eae67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chemical Contagion",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 30 feet critically fails its initial saving throw against a poison you created.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4a6bfd5-adc9-4f4a-ba57-37a3fd48f9c9"), Type = TextBlockType.Text, Text = "With carefully engineered enzymes, you coax some of your poison to infect another target, using the original victim as a carrier. A creature adjacent to the triggering creature is exposed to the triggering poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c890a112-f04b-4a74-9511-99aefdad449f"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c35d43df-6642-402e-9739-b01b111e05e3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
